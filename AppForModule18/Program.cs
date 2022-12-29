namespace AppForModule18
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            // создадим отправителя
            var user = new User();
            // создадим получателя
            var Downloader = new YoutubeDownloader("https://www.youtube.com/watch?v=US0tGaBOOsE");

            //запрос информации
            var GetInfo = new GetAsync(Downloader);
            user.SetCommand(GetInfo);
            await user.Run();

            //загрузка
            var download = new DownloadAsync(Downloader);
            user.SetCommand(download);
            await user.Run();
        }
    }
}