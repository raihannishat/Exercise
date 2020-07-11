using System;

namespace Code_6_6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioPlayer audioPlayer = new AudioPlayer();
            audioPlayer.openSpeaker(new Speaker());
        }
    }
}
