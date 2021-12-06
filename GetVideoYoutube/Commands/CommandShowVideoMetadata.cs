using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetVideoYoutube
{
    class CommandShowVideoMetadata : IYoutubeAction
    {
        YoutubeReceiver _receiver;

        public CommandShowVideoMetadata(YoutubeReceiver receiver)
        {
            _receiver = receiver;
        }

        public async Task RunAsync()
        {
            await _receiver.ShowVideoMetadataAsync();
        }
    }
}
