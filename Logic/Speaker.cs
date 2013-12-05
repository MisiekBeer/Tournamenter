using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Speaker
    {
        private static Lazy<Speaker> _instance = new Lazy<Speaker>(() => { return new Speaker(); }, true);
        public static Speaker Instance { get { return _instance.Value; } }


        private SpeechSynthesizer _synth;
        private Speaker ()
	    {
            // Initialize a new instance of the SpeechSynthesizer.
            _synth = new SpeechSynthesizer();
            _synth.SelectVoiceByHints(VoiceGender.Male, VoiceAge.Senior);

            // Configure the audio output. 
            _synth.SetOutputToDefaultAudioDevice();
	    }

        public void Speak(string textToSay)
        {
            // Speak a string.
            _synth.SpeakAsync(textToSay);
        }

        public void KillAll()
        {
            _synth.SpeakAsyncCancelAll();
            _synth.Dispose();
        }
    }
}
