using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioSwitcher.AudioApi.CoreAudio;

namespace Volumecontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;
            string[] arg = Environment.GetCommandLineArgs();
            string volumeInstructions = string.Empty;
            double currentVolume = defaultPlaybackDevice.Volume;
            bool isOdd = currentVolume % 2 == 0;
            if (arg.Count()>1)
            {
                volumeInstructions = arg[1];
            }
            switch(volumeInstructions)
            {
                case "incBy2":
                    if (currentVolume % 2 == 0)
                    {
                        currentVolume += 2;
                    }
                    else
                    {
                        currentVolume += 3;
                    }
                    defaultPlaybackDevice.Volume = currentVolume;
                    break;
                case "incBy5":
                    currentVolume += 5;
                    defaultPlaybackDevice.Volume = currentVolume;
                    break;
                case "decBy2":
                    if (currentVolume % 2 == 0)
                    {
                        currentVolume -= 2;
                    }
                    else
                    {
                        currentVolume -= 3;
                    }
                    defaultPlaybackDevice.Volume = currentVolume;
                    break;
                case "decBy5":
                    currentVolume -= 5;
                    defaultPlaybackDevice.Volume = currentVolume;
                    break;
            }
        }
    }
}
