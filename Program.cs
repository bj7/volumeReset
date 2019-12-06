using System;
using NAudio.CoreAudioApi;

namespace volumeReset
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MMDeviceEnumerator denum = new MMDeviceEnumerator();
            MMDevice defaultDevice = denum.GetDefaultAudioEndpoint(DataFlow.Render, Role.Console);
            float level0 = defaultDevice.AudioEndpointVolume.Channels[0].VolumeLevelScalar;
            float level1 = defaultDevice.AudioEndpointVolume.Channels[1].VolumeLevelScalar;

            float masterLevel = level0 > level1 ? level0 : level1;
            defaultDevice.AudioEndpointVolume.Channels[0].VolumeLevelScalar = masterLevel;
            defaultDevice.AudioEndpointVolume.Channels[1].VolumeLevelScalar = masterLevel;
        }
    }
}
