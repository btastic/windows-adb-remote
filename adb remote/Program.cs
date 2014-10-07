using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adb_remote
{
    class Program
    {
        private static string IPAddress;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome.");

            while (string.IsNullOrEmpty(IPAddress))
            {
                Console.Write("Please enter the IP Address of the ADB Device: ");
                IPAddress = Console.ReadLine();
            }

            adbCommand("kill-server");
            adbCommand("start-server");
            adbCommand("connect " + IPAddress);

            while (true)
            {
                Console.Clear();
                PrintMainMenu();

                ConsoleKeyInfo cki;
                cki = Console.ReadKey();

                switch (cki.Key)
                {
                    case ConsoleKey.D1:
                        RemoteControlMode();
                        break;

                    case ConsoleKey.D2:
                        ADBMode();
                        break;

                    case ConsoleKey.D3:
                        ExitApplication();
                        break;

                    default:
                        PrintMainMenu();
                        break;
                }
            }
        }

        private static void adbCommand(string adbCommand)
        {
            var p = new Process();
            p.StartInfo = new ProcessStartInfo("adb", adbCommand)
            {
                UseShellExecute = false
            };
            p.Start();
            p.WaitForExit();
        }

        private static void PrintMainMenu()
        {
            Console.WriteLine("Connected to: " + IPAddress);
            Console.WriteLine("--------------------------------");
            Console.WriteLine("1) Remote Control");
            Console.WriteLine("2) ADB Mode");
            Console.WriteLine("3) Exit");
        }

        private static void ADBMode()
        {
            Console.Clear();
            Console.WriteLine("ADB Mode (Press F5 for Menu)");

            bool getOut = false;
            while (!getOut)
            {
                ConsoleKeyInfo cki = Console.ReadKey();
                if (cki.Key != ConsoleKey.F5)
                {
                    string command = Console.ReadLine();
                    adbCommand(command);
                }
                else
                {
                    getOut = true;
                }

            }
        }

        private static void RemoteControlMode()
        {
            Console.Clear();
            Console.WriteLine("Remote Control Mode (Press F5 for Menu)");

            bool getOut = false;
            while (!getOut)
            {
                ConsoleKeyInfo cki = Console.ReadKey();

                switch (cki.Key)
                {
                    case ConsoleKey.UpArrow:
                        adbCommand("shell input keyevent 19");
                        break;
                    case ConsoleKey.DownArrow:
                        adbCommand("shell input keyevent 20");
                        break;
                    case ConsoleKey.LeftArrow:
                        adbCommand("shell input keyevent 21");
                        break;
                    case ConsoleKey.RightArrow:
                        adbCommand("shell input keyevent 22");
                        break;
                    case ConsoleKey.Escape:
                        adbCommand("shell input keyevent 3");
                        break;
                    case ConsoleKey.Backspace:
                        adbCommand("shell input keyevent 4");
                        break;
                    case ConsoleKey.Enter:
                        adbCommand("shell input keyevent 66");
                        break;
                    case ConsoleKey.A:
                        adbCommand("shell input keyevent 29");
                        break;
                    case ConsoleKey.B:
                        adbCommand("shell input keyevent 30");
                        break;
                    case ConsoleKey.C:
                        adbCommand("shell input keyevent 31");
                        break;
                    case ConsoleKey.D:
                        adbCommand("shell input keyevent 32");
                        break;
                    case ConsoleKey.E:
                        adbCommand("shell input keyevent 33");
                        break;
                    case ConsoleKey.F:
                        adbCommand("shell input keyevent 34");
                        break;
                    case ConsoleKey.G:
                        adbCommand("shell input keyevent 35");
                        break;
                    case ConsoleKey.H:
                        adbCommand("shell input keyevent 36");
                        break;
                    case ConsoleKey.I:
                        adbCommand("shell input keyevent 37");
                        break;
                    case ConsoleKey.J:
                        adbCommand("shell input keyevent 38");
                        break;
                    case ConsoleKey.K:
                        adbCommand("shell input keyevent 39");
                        break;
                    case ConsoleKey.L:
                        adbCommand("shell input keyevent 40");
                        break;
                    case ConsoleKey.M:
                        adbCommand("shell input keyevent 41");
                        break;
                    case ConsoleKey.N:
                        adbCommand("shell input keyevent 42");
                        break;
                    case ConsoleKey.O:
                        adbCommand("shell input keyevent 43");
                        break;
                    case ConsoleKey.P:
                        adbCommand("shell input keyevent 44");
                        break;
                    case ConsoleKey.Q:
                        adbCommand("shell input keyevent 45");
                        break;
                    case ConsoleKey.R:
                        adbCommand("shell input keyevent 46");
                        break;
                    case ConsoleKey.S:
                        adbCommand("shell input keyevent 47");
                        break;
                    case ConsoleKey.T:
                        adbCommand("shell input keyevent 48");
                        break;
                    case ConsoleKey.U:
                        adbCommand("shell input keyevent 49");
                        break;
                    case ConsoleKey.V:
                        adbCommand("shell input keyevent 50");
                        break;
                    case ConsoleKey.W:
                        adbCommand("shell input keyevent 51");
                        break;
                    case ConsoleKey.X:
                        adbCommand("shell input keyevent 52");
                        break;
                    case ConsoleKey.Y:
                        adbCommand("shell input keyevent 53");
                        break;
                    case ConsoleKey.Z:
                        adbCommand("shell input keyevent 54");
                        break;
                    case ConsoleKey.D0:
                        adbCommand("shell input keyevent 7");
                        break;
                    case ConsoleKey.D1:
                        adbCommand("shell input keyevent 8");
                        break;
                    case ConsoleKey.D2:
                        adbCommand("shell input keyevent 9");
                        break;
                    case ConsoleKey.D3:
                        adbCommand("shell input keyevent 10");
                        break;
                    case ConsoleKey.D4:
                        adbCommand("shell input keyevent 11");
                        break;
                    case ConsoleKey.D5:
                        adbCommand("shell input keyevent 12");
                        break;
                    case ConsoleKey.D6:
                        adbCommand("shell input keyevent 13");
                        break;
                    case ConsoleKey.D7:
                        adbCommand("shell input keyevent 14");
                        break;
                    case ConsoleKey.D8:
                        adbCommand("shell input keyevent 15");
                        break;
                    case ConsoleKey.D9:
                        adbCommand("shell input keyevent 16");
                        break;
                    case ConsoleKey.OemPeriod:
                        adbCommand("shell input keyevent 56");
                        break;
                    case ConsoleKey.OemComma:
                        adbCommand("shell input keyevent 55");
                        break;
                    case ConsoleKey.F5:
                        getOut = true;
                        break;
                }
            }
        }

        private static void ExitApplication()
        {
            adbCommand("disconnect");
            adbCommand("kill-server");
            Environment.Exit(0);
        }
    }
}
