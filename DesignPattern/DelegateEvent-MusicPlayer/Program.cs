using DesignPattern.DelegateEvent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DelegateEvent_MusicPlayer
{
    // Define delegate
    public delegate void SongHandler(Song song);

    public class Program
    {
        public static void Main(string[] args)
        {
            MusicPlayer player = new MusicPlayer();
            Subscriber subscriber = new Subscriber();

            // Register the event
            player.SongPlayed += subscriber.OnSongPlayed;
            player.SongPaused += subscriber.OnSongPaused;
            player.SongStopped += subscriber.OnSongStopped;
            player.SongSkipped += subscriber.OnSongSkipped;

            // Raise events
            player.Play(new Song { Name = "Song1" });
            player.Pause(new Song { Name = "Song1" });
            player.Stop(new Song { Name = "Song1" });
            player.Skip(new Song { Name = "Song1" });
        }
    }
}
