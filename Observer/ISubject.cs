namespace DesignPatterns
{
    public interface ISubject {
        public void Attach(IObserver observer);

        public void Dettach(IObserver observer);

        public void Notify();
    } 
}

