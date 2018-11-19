namespace P4_OnlineRadio.Exceptions
{
    public class InvalidSongLengthException : InvalidSongException
    {
        public InvalidSongLengthException(string message = "Invalid song length.") : base(message)
        {
        }
    }
}
