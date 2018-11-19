﻿namespace P4_OnlineRadio.Exceptions
{
    class InvalidArtistNameException : InvalidSongException
    {
        public InvalidArtistNameException(string message = "Artist name should be between 3 and 20 symbols.") : base (message)
        {
        }
    }
}
