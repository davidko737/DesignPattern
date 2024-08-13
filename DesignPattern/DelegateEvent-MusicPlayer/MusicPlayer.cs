using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DelegateEvent_MusicPlayer
{
    public class MusicPlayer
    {
        // Event
        public event SongHandler SongPlayed;
        public event SongHandler SongPaused;
        public event SongHandler SongStopped;
        public event SongHandler SongSkipped;

        public void Play(Song song)
        {
            Console.WriteLine("Playing song: " + song.Name);
            // Raise event
            SongPlayed?.Invoke(song);
        }

        public void Pause(Song song)
        {
            Console.WriteLine("Pausing song: " + song.Name);
            // Raise event
            SongPaused?.Invoke(song);
        }   

        public void Stop(Song song)
        {
            Console.WriteLine("Stopping song: " + song.Name);
            // Raise event
            SongStopped?.Invoke(song);
        }

        public void Skip(Song song)
        {
            Console.WriteLine("Skipping song: " + song.Name);
            // Raise event
            SongSkipped?.Invoke(song);
        }
    }
}
