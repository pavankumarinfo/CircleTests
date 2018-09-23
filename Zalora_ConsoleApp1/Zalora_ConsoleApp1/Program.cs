using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalora_ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {

            var i = Console.ReadLine();

            List<string> arrayLines = new List<string>();
            for (int j = 0; j < int.Parse(i); j++)
            {
                arrayLines.Add(Console.ReadLine());
            }


            //print warriers list
            int totalAdjwarriors = 0;
            int totalDiagwarriors = 0;

            for (int k = 0; k < arrayLines.Count; k++)
            {
                totalAdjwarriors += verifyByteWarriers(arrayLines[k].ToString());
            }

            totalDiagwarriors += verifyByteWarriersDiagonal(arrayLines);
            //if (totalAdjwarriors == totalDiagwarriors)
            //{ Console.WriteLine("total diagional warriors" + totalDiagwarriors); }
            //else if (totalDiagwarriors > totalAdjwarriors)
            //{ Console.WriteLine(totalDiagwarriors - totalAdjwarriors); }
            Console.WriteLine(totalDiagwarriors);

            //Console.WriteLine("Total Byte Warriers" + totalwarriors);
            ////print verification of string            
            //for (int k = 0; k < arrayLines.Count; k++)
            //{

            //    if (verifyGivenStringIsContainsAlphabets(arrayLines[k].ToString()))
            //        Console.WriteLine("YES");
            //    else
            //        Console.WriteLine("NO");
            //}

            Console.ReadLine();
        }
        public static int verifyByteWarriers(string Warriors)
        {
            int totalByteCount = 0;
            for (int i = 0; i < Warriors.Length; i++)
            {
                if (i + 1 < Warriors.Length && Warriors[i].ToString() == "1" && Warriors[i + 1].ToString() == "1")
                {
                    totalByteCount += 1;
                }
            }

            return totalByteCount;
        }

        //diganoal warriors
        public static int verifyByteWarriersDiagonal(List<string> Warriors)
        {
            int totalByteCount = 0;
            for (int i = 0; i < Warriors.Count; i++)
            {

                for (int j = 0; j < Warriors[i].Length; j++)
                {
                   
                    if (Warriors.Count - 1 == i ) { break; }
                    for (int k = 0; k < Warriors[i + 1].Length; k++)
                    {
                        if(Warriors[i + 1].IndexOf("1") == 0) { break; }
                        if (j != 0 && k != 0 && k + 1 < Warriors[i + 1].Length 
                            && Warriors[i][j].ToString() == "1" && Warriors[i + 1][k + 1].ToString() == "1")
                        {
                            totalByteCount += 1;
                            break;
                        }
                    }
                }
            }


            //if (i + 1 < Warriors.Length && Warriors[i].ToString() == "1" && Warriors[i + 1].ToString() == "1")
            //{
            //    totalByteCount += 1;
            //}
            return totalByteCount;
        }

        //public static bool verifyGivenStringIsContainsAlphabets(string input)
        //{
        //    var alphabets26 = "abcdefghijklmnopqrstuvwxyz";
        //    var icount = 0;
        //    for (var i = 0; i < alphabets26.Length; i++)
        //    {
        //        var letter = alphabets26[i];
        //        if (input.IndexOf(letter) > -1)
        //            icount++;
        //    }
        //    if (icount == 26)
        //        return true;
        //    else
        //        return false;
        //}
    }
/*
 * Question1
 * 
Complete String
A string is said to be complete if it contains all the characters from a to z. Given a string, check if it complete or not.

Input
First line of the input contains the number of strings N. It is followed by N lines each contains a single string.

Output
For each test case print "YES" if the string is complete, else print "NO"

Constraints
1 <= N <= 10
The length of the string is at max 100 and the string contains only the characters a to z

Sample Input
3
wyyga
qwertyuioplkjhgfdsazxcvbnm
ejuxggfsts
Sample Output
NO
YES
NO
 * Problem 2:
War between two tribes
The inhabitants of BitVille and ByteVille are engaged in a periodic wars. Last month, BitVille successfully launched and orbited a spy telescope called the Hobble Scope. The purpose of the Hobble Scope is to count the number of Byte Warriors in ByteVille. The Hobble Scope, however, had problems due to poor quality control during its construction. Its primary lens was contaminated with bugs which block part of each image, and its focusing mechanism malfunctioned so that images vary in size and sharpness.
Each image is square and each pixel (or cell) contains either a 0 or a 1. The unique Hobble Scope Camera (HSC) records at each pixel location a 1 if part or all of a Byte Warrior is present and a 0 if any other object, including a bug, is visible. The programmers must assume the following:
1.	A Byte warrior is represented by at least a single binary one.
2.	Cells that contain binary ones that are adjacent or diagonal to each other comprise one Byte Warrior. A very large image of one Byte Warrior might contain all ones.
3.	Distinct Byte Warriors do not touch one another.
4.	There is no wrap-around. Pixels on the bottom are not adjacent to the top and the left is not adjacent to the right.
Input 
The first line of the input contains N, the dimension of the image. It is followed by N rows, each line containing N digits. Each digit is either 0 or 1.
Output
The output should be a single number specifying the number of unique Byte Warriors in the image.
Constraint: 
1 <= N <= 500
Sample Input
6
100100
001010
000000
110000
111000
010100
 */

}
