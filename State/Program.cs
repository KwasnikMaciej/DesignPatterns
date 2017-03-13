using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new AudioPlayer();
            player.PressPlay();
            player.PressAudioSource();
            player.PressPlay();
            player.PressPlay();
            player.PressAudioSource();
            player.PressPlay();
            player.PressAudioSource();

            Console.ReadKey();
        }
    }
}
