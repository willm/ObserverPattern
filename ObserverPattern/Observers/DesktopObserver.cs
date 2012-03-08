using System;
using System.Collections.Generic;
using ObserverPattern.Subject;

namespace ObserverPattern.Observers
{
	public class DesktopObserver : ILockerObserver{
	
		public DesktopObserver(ILocker locker){
			locker.RegisterObserver(this);
		}
	
		public void Update(List<Track> tracks){
			Console.WriteLine(this.GetType().Name);
			Console.WriteLine("====================");
			Console.WriteLine(String.Format("Downloaded {0} track(s) to disk", tracks.Count));
			//Download tracks
			Console.WriteLine();
		}
	}
}