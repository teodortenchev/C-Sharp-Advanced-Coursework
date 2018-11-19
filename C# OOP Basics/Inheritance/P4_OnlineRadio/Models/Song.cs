using P4_OnlineRadio.Exceptions;
namespace P4_OnlineRadio.Models
{
    public class Song
    {
        private string artistName;
        private string name;
        private int minutes;
        private int seconds;

        public Song(string artistName, string songName, int minutes, int seconds)
        {
            ArtistName = artistName;
            Name = songName;
            Minutes = minutes;
            Seconds = seconds;
        }
        public string ArtistName
        {
            get { return artistName; }
            private set
            {
                if (value == null || value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException();
                }
                artistName = value;
            }
        }


        public string Name
        {
            get { return name; }
            private set
            {
                if (value == null || value.Length < 3 || value.Length > 30)
                {
                    throw new InvalidSongNameException();
                }
                name = value;
            }
        }

        public int Minutes
        {
            get { return minutes; }
            private set
            {
                if (value < 0 || value > 14)
                {
                    throw new InvalidSongMinutesException();
                }
                minutes = value;
            }
        }

        public int Seconds
        {
            get { return seconds; }
            private set
            {
                if (value < 0 || value > 59)
                {
                    throw new InvalidSongSecondsException();
                }
                    seconds = value;
            }
        }
    }
}
