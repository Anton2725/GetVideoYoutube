using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace GetVideoYoutube
{
    class YoutubeReceiver
    {
        private string _URLVideo;
        private string _pathVideoFile;

        public YoutubeReceiver(string URLVideo, string pathVideoFile)
        {
            _URLVideo = URLVideo;
            _pathVideoFile = pathVideoFile;
        }

        public async Task ShowVideoMetadataAsync()
        {
            var youtube = new YoutubeClient();

            // You can specify both video ID or URL
            var video = await youtube.Videos.GetAsync(_URLVideo);

            var title = video.Title;
            var author = video.Author.Title;
            var duration = video.Duration;

            Console.WriteLine($"title: {title}\nauthor: {author}\nduration: {duration}");
        }

        public async Task DownloadVideoAsync()
        {
            var youtube = new YoutubeClient();

            await youtube.Videos.DownloadAsync(_URLVideo, _pathVideoFile);

            Console.WriteLine("Загрузка видео файла завершена");
        }

    }
}
