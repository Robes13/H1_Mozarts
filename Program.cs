using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace H1_Mozarts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Minuette and trio arrays
            int[,] minuet = {  // 1   2    3   4    5    6    7   8   9   10  11  12  13  14   15   16
                        /* 2*/   { 96, 22, 141, 41, 105, 122, 11, 30, 70, 121, 26, 9, 112, 49, 109, 14 },
                        /* 3*/   { 32, 6, 128, 63, 146, 46, 134, 81, 117, 39, 126, 56, 174, 18, 116, 83 },
                        /* 4*/   { 69, 95, 158, 13, 153, 55, 110, 24, 66, 139, 15, 132, 73, 58, 145, 79 },
                        /* 5*/   { 40, 17, 113, 85, 161, 2, 159, 100, 90, 176, 7, 34, 67, 160, 52, 170 },
                        /* 6*/   { 148, 74, 163, 45, 80, 97, 36, 107, 25, 143, 64, 125, 76, 136, 1, 93 },
                        /* 7*/   { 104, 157, 27, 167, 154, 68, 118, 91, 138, 71, 150, 29, 101, 162, 23, 151 },
                        /* 8*/   { 152, 60, 171, 53, 99, 133, 21, 127, 16, 155, 57, 175, 43, 168, 89, 172 },
                        /* 9*/   { 119, 84, 114, 50, 140, 86, 169, 94, 120, 88, 48, 166, 51, 115, 72, 111 },
                        /* 10*/  { 98, 142, 42, 156, 75, 129, 62, 123, 65, 77, 19, 82, 137, 38, 149, 8 },
                        /* 11*/  { 3, 87, 165, 61, 135, 47, 147, 33, 102, 4, 31, 164, 144, 59, 173, 78 },
                        /* 12*/  { 54, 130, 10, 103, 28, 37, 106, 5, 35, 20, 108, 92, 12, 124, 44, 131 } };


            int[,] trios = {   //  17  18 19  20  21  22  23  24  25  26 27  28  29  30  31  32
                          /* 1*/ { 72, 6, 59, 25, 81, 41, 89, 13, 36, 5, 46, 79, 30, 95, 19, 66 },
                          /* 2*/ { 56, 82, 42, 74, 14, 7, 26, 71, 76, 20, 64, 84, 8, 35, 47, 88 },
                          /* 3*/ { 75, 39, 54, 1, 65, 43, 15, 80, 9, 34, 93, 48, 69, 58, 90, 21 },
                          /* 4*/ { 40, 73, 16, 68, 29, 55, 2, 61, 22, 67, 49, 77, 57, 87, 33, 10 },
                          /* 5*/ { 83, 3, 28, 53, 37, 17, 44, 70, 63, 85, 32, 96, 12, 23, 50, 91 },
                          /* 6*/ { 18, 45, 62, 38, 4, 27, 52, 94, 11, 92, 24, 86, 51, 60, 78, 31 } };
            // Creating new random
            Random rnd = new Random();
            // Creating our two dices
            int diceOne = rnd.Next(0, 5);
            int diceTwo = rnd.Next(0, 5);
            // Creating file path array
            string[] files = new string[32];
            // Adding the minuette pathways.
            for (int i = 0; i < minuet.GetLength(1); i++)
            {
                int diceIndexTwo = diceOne;
                int diceIndex = diceOne + diceTwo;
                files[i] = @"M" + minuet[diceIndex, i] + ".wav";
                // Adding the trio pathways
                files[i + 1] = @"T" + trios[diceIndexTwo - 1, i] + ".wav";

            }
            // Creating new soundplayer

            System.Media.SoundPlayer sp = new
            System.Media.SoundPlayer();
            // Playing all the soundfiles from the paths.
            foreach (string musicelement in files)
            {
                sp.SoundLocation = musicelement;
                sp.Load();
                sp.PlaySync();
            }

        }
    }
}
