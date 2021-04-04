using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Monitoring
{
    class Model
    {
        public List<WebSite> webSites { get; private set; }
        /// <summary>
        /// Название файла, где хранятся данные.
        /// </summary>
        private const string path = "dataWebSite.txt";

        public Model()
        {
            webSites = new List<WebSite>(10);
            FileInfo fileInf = new(path);

            if (fileInf.Exists)
            {
                using (StreamReader reader = new(path, Encoding.UTF8))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] buffer = reader.ReadLine().Split(' ');
                        webSites.Add(new WebSite(buffer[0], buffer[1], Convert.ToInt32(buffer[2])));
                    }
                }
            }
        }

        // Добавляем данные введеные с таблицы в List и файл.
        public bool Add(WebSite webSite)
        {
            if (webSite == null)
            {
                return false;
            }

            WebSite web = webSites.Find(x => x.name == webSite.name && x.url == webSite.url);

            if (web == null)
            {
                webSites.Add(webSite);

                using (StreamWriter writer = new(path, true, Encoding.UTF8))
                {
                    writer.WriteLine($"{webSite.name} {webSite.url} {webSite.timer}");
                }

                return true;
            }

            return false;
        }

        // Изменяем данные введеные с таблицы в List и обновляем файл.
        public bool Edit(int index, WebSite editWebSite)
        {
            if (webSites.Count == 0)
            {
                return false;
            }

            webSites[index] = editWebSite;

            using (StreamWriter writer = new(path, false, Encoding.UTF8))
            {
                foreach (WebSite site in webSites)
                {
                    writer.WriteLine($"{site.name} {site.url} {site.timer}");
                }
            }
           
            return true;
        }

        // Удаляем выбранную строку.
        public bool Delete(int index)
        {
            if (webSites.Count == 0)
            {
                return false;
            }

            webSites.RemoveAt(index);

            using (StreamWriter writer = new(path, false, Encoding.UTF8))
            {
                foreach (WebSite site in webSites)
                {
                    writer.WriteLine($"{site.name} {site.url} {site.timer}");
                }
            }
            return true;
        }

        // Проверка на отсуствие копии введенных данных.
        public bool FindWebSite(WebSite web)
        {
            WebSite result = webSites.Find( x => (x.name == web.name) && (x.url == web.url) );

            if (result == null)
            {
                return false;
            }

            return true;
        }
    }
}
