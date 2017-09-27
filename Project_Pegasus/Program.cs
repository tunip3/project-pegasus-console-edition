
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Project_Pegasus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter a download directory\n");
            var cd = Console.ReadLine();
            var inloop = 1;
            // Setting up loop to allow repeated multcdle downloads
            while (inloop == 1)
            {

                //Create C:/Users/Public/homebrew directory if it doesn't already exist
                System.IO.Directory.CreateDirectory(@cd + @"\homebrew");

                //Clear the screen
                Console.Clear();

                // Setting up the design of the Console Interface
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________                          ");
                Console.WriteLine("|                                               |                         ");
                Console.WriteLine("| Project Pegasus - The Xbox One homebrew client|                         ");
                Console.WriteLine("|_______________________________________________|                         ");
                Console.WriteLine("                                                                          ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Enjoy Homebrew on Xbox One :-)   -wiired24                               ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("                                                                          ");
                Console.WriteLine("---------------------------------------                                   ");
                Console.WriteLine("                                       |");
                Console.WriteLine("   [Emulators for Xbox One]            |");
                Console.WriteLine("1.Chcd8     - (Chcd 8 Games)           |");
                Console.WriteLine("2.Nesbox    - (NES,SNES,GEN,GB,GBC,GBA)|");
                Console.WriteLine("3.Retrix    - (Libretro for Xbox One)  |");
                Console.WriteLine("4.PPSSPP    - (PSP Games)              |");
                Console.WriteLine("5.VBA10     - (GBA Games)              |");
                Console.WriteLine("6.Win64e10  - (N64 Games)              |");
                Console.WriteLine("                                       |");
                Console.WriteLine("                                       |");
                Console.WriteLine("    [Xbox One Homebrew Games]          |");
                Console.WriteLine("7.Dungeon Run  - 2D Zelda Clone        |");
                Console.WriteLine("8.Hedgephysics - Fan Made Sonic Game   |");
                Console.WriteLine("9.sonic realms - Fan Made Sonic Game   |");
                Console.WriteLine("                                       |");
                Console.WriteLine("                                       |");
                Console.WriteLine("    [Miscellaneous/Tools]              |");
                Console.WriteLine("10. WinIRC - IRC Chat Client           |");
                Console.WriteLine("11.Boxify - Spotify Music Client       |");
                Console.WriteLine("12.UWPStreamer - Stream 3DS to XB1     |");
                Console.WriteLine("----------------------------------------");



                // Converting user selection from string to int for the switch block
                string menuChoice_string = Console.ReadLine();
                int menuChoice = Convert.ToInt32(menuChoice_string);



                // Setting uo switch block to handle user selections
                switch (menuChoice)
                {


                    // Using the WebClient Class to connect to the server and download the file to the specified path
                    case 1:
                        System.IO.Directory.CreateDirectory(@cd + @"\chip8");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading Chcd8 from ProjectPegasus Repository Please Wait....");
                        WebClient Client = new WebClient();
                        Client.DownloadFile("https://github.com/wiired24/ProjectPegasus/releases/download/appx_chip8/CHIP8.rar", @cd + @"\homebrew\chip8\CHIP8.rar");
                        Console.WriteLine("Downloaded Chcd8 to C:\\Users\\Public\\homebrew Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;




                    case 2:
                        System.IO.Directory.CreateDirectory(@cd + @"\nesbox");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading Nesbox from ProjectPegasus Repository Please Wait....");
                        WebClient Client2 = new WebClient();
                        Client2.DownloadFile("https://github.com/wiired24/ProjectPegasus/releases/download/appx_nesbox/Nesbox.zip", @cd + @"\nesbox\Nesbox.zip");
                        Console.WriteLine("Downloaded Nesbox to C:\\Users\\Public\\homebrew Press Enter to Download Again... :-)");
                        Console.ResetColor();
                        break;



                    case 3:
                        System.IO.Directory.CreateDirectory(@cd + @"\retrix");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading RetriX from ProjectPegasus Repository please wait....");
                        WebClient Client3 = new WebClient();
                        Client3.DownloadFile("https://github.com/wiired24/ProjectPegasus/releases/download/appx_retrix/RetriX_v1.8.zip", @cd + @"\retrix\RetriX.zip");
                        Console.WriteLine("Downloaded RetriX to your chosen directory Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;


                    case 4:
                        System.IO.Directory.CreateDirectory(@cd + @"\ppsspp");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading PPPSSPP from ProjectPegasus Repository Please Wait....");
                        WebClient Client4 = new WebClient();
                        Client4.DownloadFile("https://github.com/wiired24/ProjectPegasus/releases/download/appx_ppsspp/PPSSPP.rar", @cd + @"\ppsspp\PPSSPP.rar");
                        Console.WriteLine("Downloaded PPSSPP to C:\\Users\\Public\\homebrew Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;


                    case 5:
                        System.IO.Directory.CreateDirectory(@cd + @"\vba10");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading VBA10 from ProjectPegasus Repository Please Wait....");
                        WebClient Client5 = new WebClient();
                        Client5.DownloadFile("https://github.com/wiired24/ProjectPegasus/releases/download/appx_vba10/VBA10.rar", @cd + @"\vba10\VBA10.rar");
                        Console.WriteLine("Downloaded VBA10 to C:\\Users\\Public\\homebrew Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;


                    case 6:
                        System.IO.Directory.CreateDirectory(@cd + @"\win64e10");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading Win64e10 from ProjectPegasus Repository Please Wait....");
                        WebClient Client6 = new WebClient();
                        Client6.DownloadFile("https://github.com/wiired24/ProjectPegasus/releases/download/appx_win64e10/Win64e10.zip", @cd + @"\win64e10\Win64e10.zip");
                        Console.WriteLine("Downloaded Win64e10 to C:\\Users\\Public\\homebrew Press Enter to Download Again :-)");
                        Console.ResetColor();

                        break;


                    case 7:
                        System.IO.Directory.CreateDirectory(@cd + @"\DungeonRun");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading Dungeon Run from ProjectPegasus Repository Please Wait....");
                        WebClient Client7 = new WebClient();
                        Client7.DownloadFile("https://github.com/wiired24/ProjectPegasus/releases/download/appx_dungeon_run/DungeonRUN.zip", @cd + @"\DungeonRun\DungeonRUN.zip");
                        Console.WriteLine("Downloaded Dungeon Run to C:\\Users\\Public\\homebrew Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;


                    case 8:
                        System.IO.Directory.CreateDirectory(@cd + @"\Hedge-physics");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading Hedgephysics from ProjectPegasus Repository Please Wait....");
                        WebClient Client8 = new WebClient();
                        Client8.DownloadFile("https://github.com/wiired24/ProjectPegasus/releases/download/appx_hedge_physics/Hedgephysics.zip", @cd + @"\Hedge-physics\hedgephysics.zip");
                        Console.WriteLine("Downloaded Hedgephysics to C:\\Users\\Public\\homebrew Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;

                    case 9:
                        System.IO.Directory.CreateDirectory(@cd + @"\sonic-realms");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading sonic realms from ProjectPegasus Repository Please Wait....");
                        WebClient Client9 = new WebClient();
                        Client9.DownloadFile("https://github.com/wiired24/ProjectPegasus/releases/download/appx_sonic_realms/sonic_realms.zip", @cd + @"\sonic-realms\sonic_realms.zip");
                        Console.WriteLine("Downloaded sonic realms to C:\\Users\\Public\\homebrew Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;

                    case 10:
                        System.IO.Directory.CreateDirectory(@cd + @"\WinIRC");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading WinIRC from ProjectPegasus Repository Please Wait....");
                        WebClient Client10 = new WebClient();
                        Client10.DownloadFile("https://github.com/wiired24/ProjectPegasus/releases/download/appx_winirc/winirc.zip", @cd + @"\WinIRC\WinIRC.zip");
                        Console.WriteLine("Downloaded WinIRC to C:\\Users\\Public\\homebrew Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;


                    case 11:
                        System.IO.Directory.CreateDirectory(@cd + @"\Boxify");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading Boxify from ProjectPegasus Repository Please Wait...");
                        WebClient Client11 = new WebClient();
                        Client11.DownloadFile("https://github.com/wiired24/ProjectPegasus/releases/download/appx_boxify/boxify.zip", @cd + @"\Boxify\boxify.zip");
                        Console.WriteLine("Downloaded Boxify to C:\\Users\\Public\\homebrew Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;

                    case 12:
                        System.IO.Directory.CreateDirectory(@cd + @"\UWPstreamer");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading UWPstreamer from ProjectPegasus Repository Please Wait...");
                        WebClient Client12 = new WebClient();
                        Client12.DownloadFile("https://raw.githubusercontent.com/wiired24/ProjectPegasus/appx_releases/UWPstreamer.zip", @cd + @"\UWPstreamer\UWPstreamer.zip");
                        Console.WriteLine("Downloaded UWP streamer to C:\\Users\\Public\\homebrew Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;

                    // Throws an Exception if the user pressed an invalid option
                    default:
                        Console.WriteLine("Exception! Invalid Input Try Again");
                        break;



                }

                Console.ReadLine();
            }
            while (inloop == 2)
            {
                Console.WriteLine("Exception! Invalid Input Try Again");
                Console.ReadKey();
            }
        }
    }
}
