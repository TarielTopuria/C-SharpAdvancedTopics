using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ShartAdvancedTopics.Delegates
{
    delegate void NotificationDelegate(string text);
    delegate T MinNumberDelegate<T>(T firstNumber, T secondNumber);
    public class Delegates
    {
        public static void AddInConsole(string text)
        {
            Console.WriteLine(text);
        }

        public static void AddInFile(string text) 
        {
            string path = @"C:\Users\TTopuria\Desktop\Logger\Log.xml";
            File.WriteAllText(path, text);
        }
    }
}
