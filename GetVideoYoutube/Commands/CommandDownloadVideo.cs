using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetVideoYoutube
{
    class CommandDownloadVideo : IYoutubeAction
    {
        YoutubeReceiver _receiver;

        public CommandDownloadVideo(YoutubeReceiver receiver)
        {
            _receiver = receiver;
        }

        public async Task RunAsync()
        {
            await _receiver.DownloadVideoAsync();
        }
    }
}
