namespace Observer.Interfaces
{
    public interface IObserver
    {
        void React(NewMessageEvent e);
    }
}
