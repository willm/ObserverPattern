using System.Collections.Generic;

namespace ObserverPattern.Observers
{
	public interface ILockerObserver{
		void Update(List<Track> tracks);
	}
}