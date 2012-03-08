using System;
using System.Collections.Generic;
using NUnit.Framework;
using ObserverPattern;
using ObserverPattern.Observers;
using ObserverPattern.Subject;

namespace ObserverPatternRunner
{
	[TestFixture]
	public class ObserverPatternRunner
	{
		[Test]
		public void Run()
		{
			var locker = new Locker(
				new List<Track>{
				               	new Track{
				               	         	Title="One Armed Scissor", 
				               	         	Artist = "At The Drive In"
				               	         }
				               }
				);

			var samsungGalaxy = new PhoneObserver(locker);
			var lastFMAccount = new SocialObserver(locker);
			var myHomePC = new DesktopObserver(locker);

			locker.NotifyObservers();

			Console.WriteLine("Now I'll add a track");

			locker.AddTrack("Let's Dance", "David Bowie");

			samsungGalaxy.DropConnection();

			locker.AddTrack("Changes", "David Bowie");
		}
	}
}