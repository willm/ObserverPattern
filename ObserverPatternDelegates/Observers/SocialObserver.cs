using System;
using System.Collections.Generic;
using ObserverPattern;
using ObserverPatternDelegates.Subject;

namespace ObserverPatternDelegates.Observers
{
	public class SocialObserver{
		private readonly Locker _locker;
		private Locker.LockerChangeHandler _lockerOnTracksChanged;

		public SocialObserver(Locker locker)
		{
			_locker = locker;
			Connect();
		}

		private void Connect()
		{
			_lockerOnTracksChanged = new Locker.LockerChangeHandler(Update);
			_locker.TracksChanged += _lockerOnTracksChanged;
		}

		public void Update(Locker locker,List<Track> tracks){
			Console.WriteLine(this.GetType().Name);
			Console.WriteLine("====================");

			Console.WriteLine("Look mum, I just bought some music!");
			//Publish tracks to Facebook/Twitter
			Console.WriteLine();
		}
	}
}