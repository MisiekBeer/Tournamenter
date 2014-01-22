using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace Logic
{
    public class Speaker
    {
        public static Speaker Instance { get { return _instance.Value; } }
        private static Lazy<Speaker> _instance = new Lazy<Speaker>(() => { return new Speaker(); }, true);
        private static object _locker = new object();

        private static ConcurrentQueue<string> _textsToSay = new ConcurrentQueue<string>();
        private static SpeechSynthesizer _synth;

        private Speaker ()
        {
            // Initialize a new instance of the SpeechSynthesizer.
            _synth = new SpeechSynthesizer();
            _synth.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult);

            // Configure the audio output. 
            _synth.SetOutputToDefaultAudioDevice();

            _synth.SpeakCompleted += _synth_SpeakCompleted;
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

        public void KillAll()
        {
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
