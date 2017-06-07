using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBABlackBone.Parsers
{
    class TxtParse
    {
        public string[,] Parse(string location)
        {
            int counter = 0;

            string line;
            string[,] arr = new string[600, 200];

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(location);
            while ((line = file.ReadLine()) != null)
            {
                string[] arr1 = line.Split(' ', '\t');
                for (int i = 0; i < arr1.Length; i++)
                {
                    arr[counter, i] = arr1[i];
                }
                counter++;
            }

            file.Close();

            /*for (int i = 0; i < counter; i++)
             {
                 for (int j = 0; j < arr.GetLength(1); j++)
                 {
                     Console.Write(arr[i, j] + " " );
                 }
                 Console.WriteLine();
            }*/

            /*for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write(arr[0, j] + " ");
            }
            Console.WriteLine();*/


            //Console.WriteLine(arr[0, 1]);
            //Console.WriteLine(arr[1, 1]);

            return arr;
        }
    }
}
