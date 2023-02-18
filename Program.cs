using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading;

namespace MultipleRoblox
{
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Syncing...");
            Thread.Sleep(100);
            //New Stuff
            [DllImport("kernel32.dll")]
            static extern IntPtr GetConsoleWindow();
            [DllImport("user32.dll")]
            static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
            const int SW_HIDE = 0;
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
            //Normal Stuff
            Console.Clear();
            new Mutex(true, "ROBLOX_singletonMutex");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to Roblox Multi-Instance - Startup Edition!\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Made by MiningTcup, some credit to MainDabRblx\n\n--- NOTES ---\nYou may now open as many Roblox instances as you like, ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("using seperate accounts");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(". If you close this window, all Roblox instances except for one will close. Make sure that you closed all Roblox instances before activating this.\n");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Roblox Multi-Instance is now activated!\n");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Please do not close this window.");
            Console.ForegroundColor = ConsoleColor.White;
            Thread.Sleep(-1);
        }
    }
}
