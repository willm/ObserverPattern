using System.Collections.Generic;
using ObserverPattern.Observers;

namespace ObserverPattern.Subject
{
	public class Locker : ILocker{
		private readonly List<ILockerObserver> _observers;
		private readonly List<Track> _tracks;
	
		public Locker(List<Track> tracks){
			_observers = new List<ILockerObserver>();
			_tracks = tracks;
		}
	
		public void RegisterObserver(ILockerObserver observer){
			_observers.Add(observer);
		}
	
		public void RemoveObserver(ILockerObserver
			observer){
			_observers.Remove(observer);
		}
	
		public void NotifyObservers(){
			foreach(var observer in _observers){
				observer.Update(_tracks);
			}
		}
	
		public void AddTrack(string artist, string title){
			_tracks.Add(
				new Track{
				         	Title = title,
				         	Artist = artist
				         });
			NotifyObservers();
			//Everytime a track is added to a locker, we update all of the users devices
		}
	}
}