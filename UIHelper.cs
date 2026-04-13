using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CyberSecurityChatbot
{
    public static class UIHelper
    {
        public static void DisplayHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(@"
   ____            _                ____        _   
  / ___| _   _ ___| |_ ___ _ __    | __ )  ___ | |_ 
 | |    | | | / __| __/ _ \ '__|   |  _ \ / _ \| __|
 | |___ | |_| \__ \ ||  __/ |      | |_) | (_) | |_ 
  \____| \__, |___/\__\___|_|      |____/ \___/ \__|
         |___/                                     
      CYBERSECURITY AWARENESS BOT
");

            Console.ResetColor();
            Console.WriteLine("==============================================");
        }

        public static void TypeText(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(20); // typing effect
            }
            Console.WriteLine();
        }
    }
}