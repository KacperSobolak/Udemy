using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class ProxyYoutubeService : IYoutubeService
    {
        private readonly IYoutubeService _youtubeService;
        private Dictionary<int, byte[]> _cache = new();

        public ProxyYoutubeService(IYoutubeService youtubeService)
        {
            _youtubeService = youtubeService;
        }

        public byte[] GetVideo(int videoId)
        {
            Console.WriteLine($"Proxy Youtube service getting video: {videoId}");

            byte[] cachedVideo;

            if (_cache.TryGetValue(videoId, out cachedVideo))
            {
                Console.WriteLine($"Getting from cache {videoId}");
                return cachedVideo;
            }

            var video =  _youtubeService.GetVideo(videoId);
            _cache.Add(videoId, video);

            return video;
        }
    }
}
