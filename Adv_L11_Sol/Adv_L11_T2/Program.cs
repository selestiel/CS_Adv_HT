﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

 
namespace Adv_L11_T2
{
    class Program
    {
        
        
        //TODO: MUTATE INTO THREADING CODE!!!!
        // fields
        static Random rand = new Random();

        // properties
        static char AsciiCharacter
        {
            get
            {
                int t = rand.Next(10);
                if (t <= 2)
                    // returns a number
                    return (char)('0' + rand.Next(10));
                else if (t <= 4)
                    // small letter
                    return (char)('a' + rand.Next(27));
                else if (t <= 6)
                    // capital letter
                    return (char)('A' + rand.Next(27));
                else
                    // any ascii character
                    return (char)(rand.Next(32, 255));
            }
        }

        // methods
        static void Main()
        {
            ThreadStart thread = new ThreadStart(Run);
            Thread thread1 = new Thread(Run);
            thread1.Start();
            Console.WriteLine("ThreadStarted");
            


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowLeft = Console.WindowTop = 0;
            Console.WindowHeight = Console.BufferHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.BufferWidth = Console.LargestWindowWidth;
            Console.WriteLine("Hit Any Key To Continue");
            Console.ReadKey();
            Console.CursorVisible = false;

            int width, height;
            // setup array of starting y values
            int[] y;

            // width was 209, height was 81
            // setup the screen and initial conditions of y
            Initialize(out width, out height, out y);

            // do the Matrix effect
            // every loop all y's get incremented by 1
            
            while (true)
            {
                UpdateAllColumns(width, height, y);
            }        
        }

        private static void Run()
        {
            int width, height;
            // setup array of starting y values
            int[] y;

            // width was 209, height was 81
            // setup the screen and initial conditions of y
            Initialize(out width, out height, out y);

            // do the Matrix effect
            // every loop all y's get incremented by 1

            while (true)
            {
                List<Thread> threads = new List<Thread>();
                Thread thread = new Thread(() => UpdateAllColumns(width, height, y));
                thread.Start();
                threads.Add(thread);
                foreach (Thread t in threads)
                {
                    t.Join();
                }
                
            }
        }
        private static void UpdateAllColumns(int width, int height, int[] y)
        {
            int x;
            // draws 3 characters in each x column each time...
            // a dark green, light green, and a space

            // y is the position on the screen
            // y[x] increments 1 each time so each loop does the same thing but down 1 y value
            for (x = 0; x < width; ++x)
            {
                // the bright green character
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(x, y[x]);
                Console.Write(AsciiCharacter);

                // the dark green character -  2 positions above the bright green character
                Console.ForegroundColor = ConsoleColor.Green;
                int temp = y[x] - 1;
                Console.SetCursorPosition(x, inScreenYPosition(temp, height));
                Console.Write(AsciiCharacter);
                
                // the dark green character -  2 positions above the bright green character
                Console.ForegroundColor = ConsoleColor.Green;
                int temp1 = y[x] - 2;
                Console.SetCursorPosition(x, inScreenYPosition(temp1, height));
                Console.Write(AsciiCharacter);

                // the dark green character -  2 positions above the bright green character
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                int temp2 = y[x] - 2;
                Console.SetCursorPosition(x, inScreenYPosition(temp2, height));
                Console.Write(AsciiCharacter);

                // the 'space' - 20 positions above the bright green character
                //Console.ForegroundColor = ConsoleColor.DarkGreen;
                int temp3 = y[x] - 10;
                Console.SetCursorPosition(x, inScreenYPosition(temp3, height));
                Console.Write(' ');

                // increment y
                y[x] = inScreenYPosition(y[x] + 1, height);
            }

            // F5 to reset, F11 to pause and unpause
            if (Console.KeyAvailable)
            {
                if (Console.ReadKey().Key == ConsoleKey.F5)
                    Initialize(out width, out height, out y);
                if (Console.ReadKey().Key == ConsoleKey.F11)
                    System.Threading.Thread.Sleep(10);
            }

        }

        // Deals with what happens when y position is off screen
        public static int inScreenYPosition(int yPosition, int height)
        {
            if (yPosition < 0)
                return yPosition + height;
            else if (yPosition < height)
                return yPosition;
            else
                return 0;
        }

        // only called once at the start
        private static void Initialize(out int width, out int height, out int[] y)
        {
            height = Console.WindowHeight;
            width = Console.WindowWidth - 1;

            // 209 for me.. starting y positions of bright green characters
            y = new int[width];

            Console.Clear();
            // loops 209 times for me
            for (int x = 0; x < width; ++x)
            {
                // gets random number between 0 and 81
                y[x] = rand.Next(height);
            }
        }
    }
}
