using System;
using System.Collections.Generic;
using ObserverPattern;

namespace ObserverPatternDelegates.Subject
{
	public class Locker
	{
		private readonly List<Track> _tracks;

		public Locker(List<Track> tracks)
		{
			_tracks = tracks;
		}

		//public delegate void LockerChangeHandler(Locker locker, List<Track> tracks);

		public event Action<Locker, List<Track>> TracksChanged;

		public void OnTracksChanged(List<Track> tracks)
		{
			var handler = TracksChanged;

			if(handler != null)
			{
				handler(this, tracks);
			}
		}

		public void AddTrack(string title, string artist)
		{
			_tracks.Add(new Track
			{
				Artist = artist,
				Title = title
			});
			OnTracksChanged(_tracks);
		}
	}
}