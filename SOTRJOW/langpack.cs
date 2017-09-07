using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STORJOW
{
    class langpack
    {

        public Russian Rus;
        public English Eng;

       
        public class Russian
        {

            public string mFormTitle { get; } = "Storj share: Патруль";
            public string[] fMainMenu { get; } = { "Патруль", "Настройки", "Выход" };

            public string[] CliLinks { get; } = { "Чат STORJ", "http://community.storj.io", "Сайт STORJ.io", "http://storj.io", "Группа Facebook", "http://www.facebook.com/storjproject", "Группа VK", "http://vk.com/storjproject" };
            public string Title { get; set; }
            public string Year { get; set; }

           

        }

        public class English
        {

        }
   
    }
}
