using System;

namespace State
{
    public class RadioState : AudioPlayerState
    {
        public RadioState()
        {
            Console.WriteLine("Playing radio station...");
        }

        public override void PressPlay(AudioPlayer player)
        {
            Console.WriteLine("Play button pressed - new station selected");
        }

        public override void PressAudioSource(AudioPlayer player)
        {
            player.CurrentState = new StandbyState();
        }
    }
}
