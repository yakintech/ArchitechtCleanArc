using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Models
{
    internal class MediaPlayerAdapter : IMediaPlayer
    {

        private MP4Player _mp4Player;


        public MediaPlayerAdapter(string audioType)
        {
            if (audioType == "mp4")
            {
                _mp4Player = new MP4Player();
            }
        }

        public void Play(string audioType, string fileName)
        {
            
            if (audioType == "mp4")
            {
                _mp4Player.PlayMP4(fileName);
            }
        }
    }
}
