using System.Net;
using System.Threading;

namespace Monitoring
{
    class WebSite
    {
        /// <summary>
        /// Наименование веб сайта.
        /// </summary>
       public string name;

       /// <summary>
       /// URL веб сайта.
       /// </summary>
       public string url;

        /// <summary>
        /// Промежуток времени провреки веб сайта.
        /// </summary>
       public int timer;

        /// <summary>
        /// Доступность веб сайта.
        /// </summary>
       public bool status;

        public WebSite(string name = "", string url = "", int timer = 0, bool status = true)
        {
            this.name = name;
            this.url = url;
            this.timer = timer;
            this.status = status;

            
            ThreadStart myDelegate = new ThreadStart(CheckingWebSite);
            Thread thread = new Thread(myDelegate);
            thread.Start();
            thread.IsBackground = true;
        }

        /// <summary>
        /// Получить статус доступности сайта.
        /// </summary>
        private bool isAvailable(string site)
        {
            try
            {
                new WebClient().DownloadString(site);
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Проверяем доступность сайта.
        private void CheckingWebSite()
        {
            int oneSecond = 1000;

            while (true)
            {
                Thread.Sleep(oneSecond * timer);
                status = isAvailable(url);
            }
        }
    };
}
