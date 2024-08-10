

using AdapterPattern.Models;

AudioPlayer audioPlayer = new AudioPlayer();

audioPlayer.Play("mp3", "beyond the horizon.mp3");
audioPlayer.Play("mp4", "alone.mp4");

Console.ReadLine();