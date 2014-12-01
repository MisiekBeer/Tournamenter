using System;
using System.Collections.Concurrent;
using System.Speech.Synthesis;
using System.Threading;

namespace Logic
{
    public class Speaker
    {
        public static Speaker Instance { get { return _instance.Value; } }

        private static Lazy<Speaker> _instance = new Lazy<Speaker>(() => { return new Speaker(); }, true);

        private object _locker = new object();

        private ConcurrentQueue<string> _textsToSay = new ConcurrentQueue<string>();
        private SpeechSynthesizer _synth;

        private RoundTimer _roundTimer;

        private class RoundTimer
        {
            private readonly TimeSpan MINUTE = new TimeSpan(0, 1, 0);

            private TimeSpan _roundTimeRemaining;
            private Timer _timer;

            public void StartTimer(TimeSpan roundTime)
            {
                _roundTimeRemaining = roundTime;

                _timer = new Timer(OnTimer, this, MINUTE, MINUTE);

                Speaker.Instance.AddToSayQueue("Runda rozpoczęta!");
                Speaker.Instance.AddToSayQueue(string.Format("Do końca rundy pozostało {0}", _roundTimeRemaining));
            }

            public void StopTimer()
            {
                if (_timer != null)
                    _timer.Dispose();
            }

            private void OnTimer(object state)
            {
                _roundTimeRemaining = _roundTimeRemaining.Subtract(MINUTE);

                if (_roundTimeRemaining <= TimeSpan.Zero)
                {
                    Speaker.Instance.AddToSayQueue("Runda dobiegła końca!");
                    StopTimer();
                    return;
                }

                if (_roundTimeRemaining.TotalHours >= 1)
                {
                    if (((int)_roundTimeRemaining.TotalMinutes % 30) != 0)
                        return;

                    Speaker.Instance.AddToSayQueue(string.Format("Do końca rundy pozostało {0}.", _roundTimeRemaining));
                    return;
                }
                else if (_roundTimeRemaining.TotalMinutes >= 30)
                {
                    if (((int)_roundTimeRemaining.TotalMinutes % 15) != 0)
                        return;

                    Speaker.Instance.AddToSayQueue(string.Format("Do końca rundy pozostało {0}.", _roundTimeRemaining));
                    return;
                }
                else if (_roundTimeRemaining.TotalMinutes >= 10)
                {
                    if (((int)_roundTimeRemaining.TotalMinutes % 5) != 0)
                        return;
                }

                Speaker.Instance.AddToSayQueue(string.Format("Pozostało {0}.", _roundTimeRemaining));
            }
        }

        private Speaker()
        {
            // Initialize a new instance of the SpeechSynthesizer.
            _synth = new SpeechSynthesizer();
            _synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);

            // Configure the audio output.
            _synth.SetOutputToDefaultAudioDevice();

            _synth.SpeakCompleted += _synth_SpeakCompleted;

            _roundTimer = new RoundTimer();
        }

        /// <summary>
        /// Speak a string asynchronus
        /// </summary>
        /// <param name="textToSay"></param>
        public void SpeakAsync(string textToSay)
        {
            lock (_locker)
            {
                _synth.SpeakAsync(textToSay);
            }
        }

        public void AddToSayQueue(string textToSay)
        {
            lock (_locker)
            {
                if (_synth.State == SynthesizerState.Ready)
                {
                    SpeakPromptAsync(textToSay);
                    return;
                }
                //add to queue
                _textsToSay.Enqueue(textToSay);
            }
        }

        public void Pause()
        {
            lock (_locker)
            {
                _synth.Pause();
            }
        }

        public void Resume()
        {
            lock (_locker)
            {
                _synth.Resume();
            }
        }

        public void StartRoundTimerSpeaker(TimeSpan roundTime)
        {
            _roundTimer.StartTimer(roundTime);
        }

        public void KillAll()
        {
            _roundTimer.StopTimer();

            _synth.SpeakCompleted -= _synth_SpeakCompleted;
            _synth.SpeakAsyncCancelAll();
            _synth.Dispose();
        }

        private void _synth_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            string text = null;

            if (_textsToSay.TryDequeue(out text))
                SpeakPromptAsync(text);
        }

        private void SpeakPromptAsync(string textToSay)
        {
            var prompt = new PromptBuilder();
            prompt.AppendText(textToSay, PromptEmphasis.None);
            _synth.SpeakAsync(prompt);
        }
    }
}