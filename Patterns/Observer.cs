using System.Collections;
using System.Collections.Generic;

namespace Patterns
{
    public interface IMyObserver
    {
        void Update(ISubject subject);
    }
    
    public class Observer
    {
        
    }

    public interface ISubject
    {
        void Attach(IMyObserver observer);
        void Detach(IMyObserver observer);
        void Notify();

    }

    public class Subject : ISubject
    {
        private List<IMyObserver> Observers { get; set; }
        
        public void Attach(IMyObserver observer) => Observers.Add(observer);

        public void Detach(IMyObserver observer) => Observers.Remove(observer);

        public void Notify() => Observers.ForEach(o => o.Update(this));
    }
}