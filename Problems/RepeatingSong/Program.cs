using System;

/* 

A playlist is considered a repeating playlist if any of the songs contain a reference to a previous song in the playlist. Otherwise, the playlist will end with the last song which points to null.
Implement a function IsRepeatingPlaylist that, efficiently with respect to time used, returns true if a playlist is repeating or false if it is not.
For example, the following code prints "True" as both songs point to each other.

*/

public class Song {
    private string name;
    public Song NextSong { get; set; }

    public Song (string name) {
        this.name = name;
    }

    /// <summary>
    /// Determines whether [is repeating playlist].
    /// </summary>
    /// <returns>
    ///   <c>true</c> if [is repeating playlist]; otherwise, <c>false</c>.
    /// </returns>
    public bool IsRepeatingPlaylist () {
        Song next = this.NextSong;
        while (next != null) {
            if (next.name.Equals(name)) {
                return true;
            }
            next = next.NextSong;
        }
        return false;
    }

    public static void Main (string[] args) {
        Song first = new Song ("Hello");
        Song second = new Song ("Eye of the tiger");

        first.NextSong = second;
        second.NextSong = first;

        Console.WriteLine (first.IsRepeatingPlaylist ());
    }
}