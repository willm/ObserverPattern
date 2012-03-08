using System;
using System.Collections.Generic;
using ObserverPattern.Subject;

namespace ObserverPattern.Observers
{
	public class PhoneObserver : ILockerObserver{
	
		private ILocker _locker;
	
		public PhoneObserver(ILocker locker){
			_locker = locker;
			_locker.RegisterObserver(this);
		}
	
		public void Update(List<Track> tracks){
			Console.WriteLine(this.GetType().Name);
			Console.WriteLine("====================");
			Console.WriteLine("This is your locker : ");
			foreach(var track in tracks){
				Console.WriteLine("-------");
				Console.WriteLine(track.Artist);
				Console.WriteLine(track.Title);
			}
			Console.WriteLine();
			//Update phone display
		}
	
		public void DropConnection(){
			//let's say user is in a foreign country with expensive data rates and no wifi connection
			_locker.RemoveObserver(this);
		}
	}
}