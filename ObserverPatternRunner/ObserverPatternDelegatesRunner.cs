using System.Collections.Generic;
using NUnit.Framework;
using ObserverPattern;
using ObserverPatternDelegates.Observers;
using ObserverPatternDelegates.Subject;

namespace ObserverPatternRunner
{
	[TestFixture]
	public class ObserverPatternDelegatesRunner
	{
		[Test]
		public void Run()
		{
			var tracks = new List<Track>()
			{
				new Track {Artist = "Radiohead", Title = "Codex"},
				new Track {Artist = "Pulp", Title = "Disco 2000"}
			};
			var locker =new Locker(tracks);

			var phoneObserver = new PhoneObserver(locker);

			locker.AddTrack("Flim", "Aphex Twin");

			new DesktopObserver(locker);
			new SocialObserver(locker);

			locker.AddTrack("Get A Move ON", "Mr. Scruff");

			phoneObserver.ConnectionDropped();

			locker.AddTrack("Plug in Baby", "Muse");
		}
	}
}
