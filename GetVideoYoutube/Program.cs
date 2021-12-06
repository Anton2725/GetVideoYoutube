using System;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;

namespace GetVideoYoutube
{
    class Program
    {
        public static async Task Main()
        {

            // Задание
            // Используя паттерн Команда и созданный выше шаблон, напишите консольную программу, которая будет:
            //      Принимать на вход ссылку на Youtube-видео.
            //      Выводить в консоль информацию: название видео и описание.
            //      Скачивать видео.
            // У вас должно быть две команды: на получение информации о видео и на скачивание.

            Console.OutputEncoding = Encoding.UTF8;

            // Отправитель
            YoutubeSenderCommand youtubeSenderCommand = new YoutubeSenderCommand();

            // Получатель
            YoutubeReceiver youtubeReceiver = new YoutubeReceiver("https://www.youtube.com/watch?v=slvzJgJUXxw",
                "h:\\projects\\CDEV-9\\GetVideoYoutube\\GetVideoYoutube\\bin\\video.mp4");

            // Команда показать информацию о видео
            CommandShowVideoMetadata commandShowVideoMetadata = new CommandShowVideoMetadata(youtubeReceiver);

            youtubeSenderCommand.SetCommand(commandShowVideoMetadata);
            await youtubeSenderCommand.RunAsync();

            // Команда скачать видео
            CommandDownloadVideo commandDownloadVideo = new CommandDownloadVideo(youtubeReceiver);

            youtubeSenderCommand.SetCommand(commandDownloadVideo);
            await youtubeSenderCommand.RunAsync();
        }
    }
}