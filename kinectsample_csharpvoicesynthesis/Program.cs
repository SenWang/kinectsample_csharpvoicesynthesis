using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace kinectsample_csharpvoicesynthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = "有愛行遍天下";


            SpeechSynthesizer synthesizer = new SpeechSynthesizer();

            Console.WriteLine("系統所有的語音合成引擎有:");
            foreach (var v in synthesizer.GetInstalledVoices())
                Console.WriteLine(v.VoiceInfo.Name);


            synthesizer.Rate = 0;
            synthesizer.Volume = 100;
            synthesizer.Speak(response);


            /* 底下程式碼不需要 System.Speech 組件，也不須 using System.Speech.Synthesis;
            string response = "心中一定要對技術有愛";

            Type type = Type.GetTypeFromProgID("SAPI.SpVoice");
            dynamic synthesizer = Activator.CreateInstance(type);

            synthesizer.Rate = 0;
            synthesizer.Volume = 100;
            synthesizer.Speak(response);
            */

        }
    }
}
