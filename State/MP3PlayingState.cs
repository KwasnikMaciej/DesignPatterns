using System;

namespace State
{
    public class MP3PlayingState : AudioPlayerState
    {
        public MP3PlayingState()
        {
            Console.WriteLine("Playing MP3...");
        }

        public override void PressPlay(AudioPlayer player)
        {
            player.CurrentState = new MP3PausedState();
        }

        public override void PressAudioSource(AudioPlayer player)
        {
            player.CurrentState = new RadioState();
        }
    }
}
