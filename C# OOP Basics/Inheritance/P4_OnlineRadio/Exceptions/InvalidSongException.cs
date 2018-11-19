using System;

namespace P4_OnlineRadio.Exceptions
{
    public class InvalidSongException : FormatException
    {
        public InvalidSongException(string message = "Invalid song.") : base(message)
        {
        }
    }
}
