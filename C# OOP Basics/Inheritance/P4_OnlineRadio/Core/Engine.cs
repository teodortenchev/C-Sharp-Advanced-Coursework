using P4_OnlineRadio.Exceptions;
using P4_OnlineRadio.Models;
using System;

namespace P4_OnlineRadio.Core
{
    public class Engine
    {
        private Repository repository;

        public Engine()
        {
            repository = new Repository();
        }

        public void Run()
        {
            int songsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < songsCount; i++)
            {
                try
                {
                    string[] args = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
                    string artistName = args[0];
                    string songName = args[1];
                    string[] timeArgs = args[2].Split(":", StringSplitOptions.RemoveEmptyEntries);


                    bool isMinutes = int.TryParse(timeArgs[0], out int minutes);
                    bool isSeconds = int.TryParse(timeArgs[1], out int seconds);

                    if (!isMinutes)
                    {
                        throw new InvalidSongLengthException();
                    }

                    if (!isSeconds)
                    {
                        throw new InvalidSongLengthException();
                    }

                    Song song = new Song(artistName, songName, minutes, seconds);
                    repository.AddSong(song);
                }
                catch (FormatException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            }

            DisplayResults();
        }

        private void DisplayResults()
        {
            Console.WriteLine("Songs added: " + repository.Count);
            Console.WriteLine("Playlist length: " + repository.TotalRunTime);
        }
    }
}
