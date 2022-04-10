using System;
using System.Linq;
using System.IO;

namespace _8_queens
{
    public sealed class VisualizeService
    {
        
        public static VisualizeService _instance;

        public static VisualizeService GetInstance()
        {
            if(_instance == null)
            {
                _instance = new VisualizeService();
            }
            return _instance;
        }

        public void PrintToConsole(Layout layout)
        {
            int i = 0;
            foreach (var item in layout.queens)
            {
                Console.Write((Enumerable.Range('A', 8).Select(x => (char)x).ToArray())[i] +item.place[1].ToString()+" ");
                i++;
            }
            Console.Write("\n\n");
        }

        public string CreateHtml(Layout layout)
        {
            int i = 0;
            string table = File.ReadAllText("assets/table.html");
            foreach (var item in layout.queens)
            {
                string toReplace = "<!--"+ (Enumerable.Range('A', 8).Select(x => (char)x).ToArray())[i] + item.place[1].ToString()+ "-->";
                table = table.Replace(toReplace, "<span>&#9813;</span>");
                
                i++;
            }
            return table;
        }

        public void TemplateHandler(string tablesContent)
        {
            string template = File.ReadAllText("assets/template.html");
            template = template.Replace("<!--IDE-->", tablesContent);
            File.WriteAllText("solution.html", template);
        }

    }
}
