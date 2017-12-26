using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BL1
{
    public class FileInput_9
    {        
        public static int[,] ReturnNewMassiv(string path)
        {
            string[] fileLines = File.ReadAllLines(path);
            int[,] mass = new int[fileLines.Length, fileLines.Length];
            for (int i = 0; i < fileLines.Length; i++)
            {
                string[] parts = fileLines[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < parts.Length; j++)
                {
                    mass[i, j] = int.Parse(parts[j]);
                }
            }
            return mass;
        }
    }
}

