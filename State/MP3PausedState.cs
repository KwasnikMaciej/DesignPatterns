using System;

namespace State
{
    public class MP3PausedState : AudioPlayerState
    {
        public MP3PausedState()
        {
            Console.WriteLine("MP3 Paused");
        }

        public override void PressPlay(AudioPlayer player)
        {
            player.CurrentState = new MP3PlayingState();
        }

        public override void PressAudioSource(AudioPlayer player)
        {
            player.CurrentState = new RadioState();
        }
    }
}
