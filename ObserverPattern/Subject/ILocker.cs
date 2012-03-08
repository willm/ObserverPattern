using ObserverPattern.Observers;

namespace ObserverPattern.Subject
{
	public interface ILocker{
		void RegisterObserver(ILockerObserver observer);
		void RemoveObserver(ILockerObserver observer);
		void NotifyObservers();
	}
}