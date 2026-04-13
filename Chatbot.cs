using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatbot
{
    public class Chatbot
    {
        private User user = new User();

        public void StartChat()
        {
            AskUserName();
            WelcomeUser();
            MainMenu();
        }

        private void AskUserName()
        {
            Console.Write("Enter your name: ");
            string input = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(input))
            {
                Console.Write("Name cannot be empty. Please enter your name: ");
                input = Console.ReadLine();
            }

            user.Name = input;
        }

        private void WelcomeUser()
        {
            UIHelper.TypeText($"\nHello {user.Name}! Welcome to the Cybersecurity Awareness Bot.");
            UIHelper.TypeText("I will guide you through important cybersecurity topics.\n");
        }

        private void MainMenu()
        {
            while (true)
            {
                DisplayMenu();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Select an option (1-5): ");
                Console.ResetColor();

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        PasswordSafety();
                        break;
                    case "2":
                        PhishingAwareness();
                        break;
                    case "3":
                        SafeBrowsing();
                        break;
                    case "4":
                        GeneralQuestions();
                        break;
                    case "5":
                        ExitChat();
                        return;
                    default:
                        Console.WriteLine("⚠️ Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }

        private void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n========== CYBERSECURITY TOPICS ==========");
            Console.ResetColor();

            Console.WriteLine("1. Password Safety");
            Console.WriteLine("2. Phishing Awareness");
            Console.WriteLine("3. Safe Browsing");
            Console.WriteLine("4. Ask General Questions");
            Console.WriteLine("5. Exit");
            Console.WriteLine("==========================================");
        }

        // ================= EDUCATIONAL CONTENT =================

        private void PasswordSafety()
        {
            UIHelper.TypeText("\n🔐 PASSWORD SAFETY");

            UIHelper.TypeText("A strong password is your first line of defense against cyber attacks.");
            UIHelper.TypeText("Here are key principles:");

            UIHelper.TypeText("• Use at least 12 characters.");
            UIHelper.TypeText("• Combine uppercase, lowercase, numbers, and symbols.");
            UIHelper.TypeText("• Avoid personal information like names or birthdays.");
            UIHelper.TypeText("• Do not reuse passwords across multiple sites.");

            UIHelper.TypeText("\n💡 Tip: Use a password manager to securely store your passwords.");
        }

        private void PhishingAwareness()
        {
            UIHelper.TypeText("\n🎣 PHISHING AWARENESS");

            UIHelper.TypeText("Phishing is a cyber attack where attackers trick you into revealing sensitive information.");
            UIHelper.TypeText("It often comes through emails, messages, or fake websites.");

            UIHelper.TypeText("\n🚨 Warning signs:");
            UIHelper.TypeText("• Urgent or threatening language.");
            UIHelper.TypeText("• Suspicious links or attachments.");
            UIHelper.TypeText("• Requests for personal or financial information.");

            UIHelper.TypeText("\n✅ What to do:");
            UIHelper.TypeText("• Verify the sender before clicking links.");
            UIHelper.TypeText("• Hover over links to check URLs.");
            UIHelper.TypeText("• Never share sensitive information via email.");
        }

        private void SafeBrowsing()
        {
            UIHelper.TypeText("\n🌐 SAFE BROWSING");

            UIHelper.TypeText("Safe browsing helps protect your data while using the internet.");

            UIHelper.TypeText("\n🔍 Best practices:");
            UIHelper.TypeText("• Always use websites with HTTPS.");
            UIHelper.TypeText("• Avoid clicking unknown or suspicious links.");
            UIHelper.TypeText("• Keep your browser and antivirus updated.");

            UIHelper.TypeText("\n⚠️ Risks of unsafe browsing:");
            UIHelper.TypeText("• Malware infections");
            UIHelper.TypeText("• Data theft");
            UIHelper.TypeText("• Identity fraud");
        }

        private void GeneralQuestions()
        {
            Console.Write("\nAsk your question: ");
            string input = Console.ReadLine().ToLower();

            if (input.Contains("how are you"))
            {
                UIHelper.TypeText("I'm functioning optimally and ready to help you!");
            }
            else if (input.Contains("purpose"))
            {
                UIHelper.TypeText("My purpose is to educate users about cybersecurity and promote safe online behavior.");
            }
            else
            {
                UIHelper.TypeText("I didn't quite understand that. Try selecting a topic from the menu.");
            }
        }

        private void ExitChat()
        {
            UIHelper.TypeText($"\nGoodbye {user.Name}! Stay safe online.");
        }
    }
}