using System;
using System.Collections.Generic;
using System.Text;

namespace Code_6_6_4
{
    public class VideoPlayer : AudioPlayer
    {
        protected override bool openSpeaker(Speaker sp)
        {
            return true;
        }
    }
}
