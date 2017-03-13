namespace State
{
    public class AudioPlayer
    {
        private AudioPlayerState state;

        public AudioPlayer()
        {
            this.state = new StandbyState();
        }

        public void PressPlay()
        {
            state.PressPlay(this);
        }

        public void PressAudioSource()
        {
            state.PressAudioSource(this);
        }

        public AudioPlayerState CurrentState
        {
            get { return state; }
            set { state = value; }
        }
    }
}
