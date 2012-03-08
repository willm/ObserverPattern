using System;
using System.Collections.Generic;
using ObserverPattern;
using ObserverPatternDelegates.Subject;

namespace ObserverPatternDelegates.Observers
{
	public class PhoneObserver
	{
		private readonly Locker _locker;
		private Locker.LockerChangeHandler _lockerOnTracksChanged;

		public PhoneObserver(Locker locker)
		{
			_locker = locker;
			Connect();
		}

		private void Connect()
		{
			//add a pointer to the DisplayTracks Method whenever a tracks changed event is recieved
			_lockerOnTracksChanged = (DisplayTracks);
			_locker.TracksChanged += _lockerOnTracksChanged;
		}

		public void ConnectionDropped()
		{
			_locker.TracksChanged -= _lockerOnTracksChanged;
		}

		private void DisplayTracks(Locker locker, List<Track> tracks)
		{
			Console.WriteLine(this.GetType().Name);
			Console.WriteLine("====================");
			Console.WriteLine("This is your locker : ");
			foreach (var track in tracks)
			{
				Console.WriteLine("-------");
				Console.WriteLine(track.Artist);
				Console.WriteLine(track.Title);
			}
			Console.WriteLine();
			//Update phone display
		}
	}
}