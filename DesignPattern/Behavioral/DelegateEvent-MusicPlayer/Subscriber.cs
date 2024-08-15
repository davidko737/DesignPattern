using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DelegateEvent_MusicPlayer
{
    public class Subscriber
    {

        //SongPlayed, SongPaused, SongStopped, SongSkipped

        public void OnSongPlayed(Song song)
        {
            Console.WriteLine("Subscriber: Song played.");
        }

        public void OnSongPaused(Song song)
        {
            Console.WriteLine("Subscriber: Song paused.");
        }

        public void OnSongStopped(Song song)
        {
            Console.WriteLine("Subscriber: Song stopped.");
        }

        public void OnSongSkipped(Song song)
        {
            Console.WriteLine("Subscriber: Song skipped.");
        }
    }
}
