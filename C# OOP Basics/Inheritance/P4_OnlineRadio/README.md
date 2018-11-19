Online Radio Database
---------------------

Create an online radio station database. It should keep information about all of
the added songs. On the first line you are going to get the number of songs you
are going to try to add. On the next lines you will get the songs to be added in
the format **\<artist name\>;\<song name\>;\<minutes:seconds\>**. To be valid,
every song should have an artist name, a song name and a length.

Design a custom exception hierarchy for invalid songs:

-   InvalidSongException

    -   InvalidArtistNameException

    -   InvalidSongNameException

    -   InvalidSongLengthException

        -   InvalidSongMinutesException

        -   InvalidSongSecondsException

### Validation

-   Artist name should be between 3 and 20 symbols.

-   Song name should be between 3 and 30 symbols.

-   Song length should be between 0 second and 14 minutes and 59 seconds.

-   Song minutes should be between 0 and 14.

-   Song seconds should be between 0 and 59.

### Exception Messages

| **Exception**               | **Message**                                       |
|-----------------------------|---------------------------------------------------|
| InvalidSongException        | "Invalid song."                                   |
| InvalidArtistNameException  | "Artist name should be between 3 and 20 symbols." |
| InvalidSongNameException    | "Song name should be between 3 and 30 symbols."   |
| InvalidSongLengthException  | "Invalid song length."                            |
| InvalidSongMinutesException | "Song minutes should be between 0 and 14."        |
| InvalidSongSecondsException | "Song seconds should be between 0 and 59."        |

**Note**: Check validity in the order **artist name** -\> **song name** -\>
**song length**

### Output

If the song is added, print "**Song added.**". If you **can’t add a song**,
print an **appropriate exception message**. On the last two lines print the
**number of songs added** and the **total length of the playlist** in format
**{Playlist length: 0h 7m 47s}.**