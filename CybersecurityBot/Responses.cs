using System;

namespace CybersecurityBot
{
    internal class Responses
    {
        // Returns a response based on what the user typed
        public static (string message, ConsoleColor color) GetResponse(string input, string name)
        {
            if (input.Contains("how are you"))
            {
                return ("I am doing great, thanks for asking! " +
                        "I am ready to help you stay safe online " + name + ".",
                        ConsoleColor.Green);
            }

            if (input.Contains("purpose") || input.Contains("why are you here"))
            {
                return ("My purpose is to help South Africans learn about " +
                        "cybersecurity threats and how to stay safe online. " +
                        "Cybercrime is a serious problem in South Africa and I am here to help!",
                        ConsoleColor.Cyan);
            }

            if (input.Contains("what can i ask") || input.Contains("help") || input.Contains("topics"))
            {
                return ("Here are the topics you can ask me about:\n" +
                        "      Passwords\n" +
                        "      Phishing\n" +
                        "      Safe Browsing\n" +
                        "      Malware and Viruses\n" +
                        "      Banking Safety\n" +
                        "      Social Media Safety\n" +
                        "      Two-Factor Authentication\n" +
                        "      Social Engineering",
                        ConsoleColor.Yellow);
            }

            if (input.Contains("password"))
            {
                return (" PASSWORD SAFETY TIPS:\n" +
                        "   Use at least 12 characters\n" +
                        "   Mix uppercase, lowercase, numbers and symbols\n" +
                        "   Never use your name, birthday or ID number as a password\n" +
                        "   Use a different password for every account\n" +
                        "   A password manager like Bitwarden can help you keep track",
                        ConsoleColor.Magenta);
            }

            if (input.Contains("phishing"))
            {
                return (" PHISHING AWARENESS:\n" +
                        "   Criminals pretend to be your bank or SARS to steal your information\n" +
                        "   Watch out for messages that say things like Act NOW or Your account is blocked\n" +
                        "   Check the email address carefully for spelling mistakes\n" +
                        "   Never share your password or ID number via email\n" +
                        "   When you are not sure do not click — call the company directly",
                        ConsoleColor.Red);
            }

            if (input.Contains("browsing") || input.Contains("website"))
            {
                return (" SAFE BROWSING TIPS:\n" +
                        "   Always look for HTTPS and the padlock icon in the browser\n" +
                        "   Do not do your banking on public WiFi — use your mobile data\n" +
                        "   Do not click on links from people you do not know\n" +
                        "   Keep your browser updated at all times\n" +
                        "   Ignore popups that say your device is infected — they are scams",
                        ConsoleColor.Cyan);
            }

            if (input.Contains("malware") || input.Contains("virus"))
            {
                return (" MALWARE PROTECTION:\n" +
                        "   Install a good antivirus like Malwarebytes on your device\n" +
                        "   Never download software from websites you do not trust\n" +
                        "   Always keep your device updated\n" +
                        "   Back up your important files regularly\n" +
                        "   Common types are Virus, Ransomware, Spyware and Trojan",
                        ConsoleColor.Red);
            }

            if (input.Contains("banking") || input.Contains("bank"))
            {
                return ("  BANKING SAFETY:\n" +
                        "    Only use your bank's official app or website\n" +
                        "    Your bank will never ask for your PIN via SMS or email\n" +
                        "    Turn on transaction notifications so you know when money moves\n" +
                        "    South African Bank Fraud Lines:\n" +
                        "     ABSA: 0800 111 155\n" +
                        "     FNB: 087 575 9444\n" +
                        "     Standard Bank: 0800 020 600\n" +
                        "     Nedbank: 0800 110 929",
                        ConsoleColor.Yellow);
            }

            if (input.Contains("social media") || input.Contains("facebook") || input.Contains("instagram"))
            {
                return (" SOCIAL MEDIA SAFETY:\n" +
                        "   Set your profile to private\n" +
                        "   Never post your ID number or home address online\n" +
                        "   Be careful of friend requests from people you do not know\n" +
                        "   Think before you post — what goes online stays online\n" +
                        "   Romance scams and fake lottery wins are very common in South Africa",
                        ConsoleColor.Magenta);
            }

            if (input.Contains("2fa") || input.Contains("two factor") || input.Contains("authentication"))
            {
                return (" TWO-FACTOR AUTHENTICATION:\n" +
                        "   This adds an extra layer of security on top of your password\n" +
                        "   Use an app like Google Authenticator instead of SMS\n" +
                        "   Turn on two factor authentication for your email, banking and social media\n" +
                        "   Never share your one time PIN with anyone — not even your bank\n" +
                        "   If someone asks for your one time PIN it is a scam",
                        ConsoleColor.Green);
            }

            if (input.Contains("social engineering") || input.Contains("manipulation"))
            {
                return (" SOCIAL ENGINEERING:\n" +
                        "   This is when criminals trick you into giving them your information\n" +
                        "   Phone scams — criminals call you pretending to be your bank\n" +
                        "   Fake SMS — criminals send you fake messages to steal your details\n" +
                        "   Fake stories — they make up a story to get your personal information\n" +
                        "   Always verify who you are talking to before sharing anything",
                        ConsoleColor.Red);
            }

            // If nothing matched return unknown
            return ("__UNKNOWN__", ConsoleColor.DarkYellow);
        }
    }
}