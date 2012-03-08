using System;
using System.Collections.Generic;
using ObserverPattern.Subject;

namespace ObserverPattern.Observers
{
	public class SocialObserver : ILockerObserver{
	
		public SocialObserver(ILocker locker){
			locker.RegisterObserver(this);
		}
	
		public void Update(List<Track> tracks){
			Console.WriteLine(this.GetType().Name);
			Console.WriteLine("====================");

			Console.WriteLine("Look mum, I just bought some music!");
			//Publish tracks to Facebook/Twitter
			Console.WriteLine();
		}
	}
}