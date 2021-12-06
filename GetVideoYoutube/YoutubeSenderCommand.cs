using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GetVideoYoutube
{
    class YoutubeSenderCommand : IYoutubeAction
    {
        private IYoutubeAction _action;

        public void SetCommand(IYoutubeAction action)
        {
            _action = action;
        }
        public async Task RunAsync()
        {
            await _action.RunAsync();
        }
    }
}
