namespace Proxy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var youtubeService = new YoutubeService();

            youtubeService.GetVideo(10);
            youtubeService.GetVideo(10);

            var proxyYoutubeService = new ProxyYoutubeService(youtubeService);

            proxyYoutubeService.GetVideo(10);
            proxyYoutubeService.GetVideo(10);
        }
    }
}
