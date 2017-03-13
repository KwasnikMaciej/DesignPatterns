using System;

namespace State
{
    public class StandbyState : AudioPlayerState
    {
        public StandbyState()
        {
            Console.WriteLine("Standby state");
        }

        public override void PressPlay(AudioPlayer player)
        {
            Console.WriteLine("Play button pressed - nothing happened");
        }

        public override void PressAudioSource(AudioPlayer player)
        {
            player.CurrentState = new MP3PlayingState();
        }
    }
}
