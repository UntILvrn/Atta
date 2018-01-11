using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Library
{
    public class InputSaveFile
    {

        public static int[,] ReturnNewMassiv(string path)
        {
            string[] fileLines = File.ReadAllLines(path);
            int[,] mass = new int[fileLines.Length, fileLines[1].Split(' ').Length];
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
        public static void SaveFile(string path, List<Line> nl)
        {
            List<string> lines = new List<string>();
            foreach (Line el in nl)
            {
                lines.Add(el.A + " "+el.B +" "+el.C );
            }
            File.WriteAllLines(path, lines);
        }

    }
}




