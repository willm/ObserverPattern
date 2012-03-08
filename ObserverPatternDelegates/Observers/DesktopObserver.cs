using System;
using System.Collections.Generic;
using ObserverPattern;
using ObserverPatternDelegates.Subject;

namespace ObserverPatternDelegates.Observers
{
	public class DesktopObserver{
		private readonly Locker _locker;
		//private Locker. _lockerOnTracksChanged;

		public DesktopObserver(Locker locker)
		{
			_locker = locker;
			Connect();
		}

		private void Connect()
		{
			//_lockerOnTracksChanged = new Locker.LockerChangeHandler(Update);
			_locker.TracksChanged += Update;
		}

		public void Update(Locker locker, List<Track> tracks)
		{
			Console.WriteLine(GetType().Name);
			Console.WriteLine("====================");
			Console.WriteLine(String.Format("Downloaded {0} track(s) to disk", tracks.Count));
			//Download tracks
			Console.WriteLine();
		}
	}
}