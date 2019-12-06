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
            float level = 0.36f;
            defaultDevice.AudioEndpointVolume.Channels[0].VolumeLevelScalar = level;
            defaultDevice.AudioEndpointVolume.Channels[1].VolumeLevelScalar = level;
            
        }
    }
}
