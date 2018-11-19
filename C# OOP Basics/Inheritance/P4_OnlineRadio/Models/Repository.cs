using System;
using System.Collections.Generic;

namespace P4_OnlineRadio.Models
{
    public class Repository
    {
        private List<Song> songs;

        public Repository()
        {
            songs = new List<Song>();
        }

        public int Count
        {
            get { return songs.Count; }
        }

        public string TotalRunTime
        {
            get { return CalculateTotalTime(); }
        }

        public void AddSong(Song song)
        {
            songs.Add(song);
            Console.WriteLine("Song added.");
        }

        public string CalculateTotalTime()
        {
            long seconds = GetTotalSeconds();
            TimeSpan span = TimeSpan.FromSeconds(seconds);
            string result = $"{span.Hours:0}h {span.Minutes}m {span.Seconds}s";
            return result;
        }

        private long GetTotalSeconds()
        {
            long seconds = 0L;
            foreach (var song in songs)
            {
                seconds += song.Seconds + song.Minutes * 60;
            }
            return seconds;
        }
    }
}
