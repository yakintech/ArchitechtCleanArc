using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Models
{
    internal class AudioPlayer : IMediaPlayer
    {

        private MediaPlayerAdapter _mediaPlayerAdapter;

        public void Play(string audioType, string fileName)
        {
            if (audioType == "mp3")
            {
                Console.WriteLine("MP3 dosyası çalınıyor. Dosya adı: " + fileName);
            }
            else if (audioType == "mp4")
            {
                _mediaPlayerAdapter = new MediaPlayerAdapter(audioType);
                _mediaPlayerAdapter.Play(audioType, fileName);
            }
            else
            {
                Console.WriteLine("Geçersiz medya türü: " + audioType);
            }

        }
    }
}
