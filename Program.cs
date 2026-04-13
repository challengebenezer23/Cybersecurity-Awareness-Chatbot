using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            AudioPlayer.PlayGreeting();

            UIHelper.DisplayHeader();

            Chatbot bot = new Chatbot();
            bot.StartChat();
        }
    }
}