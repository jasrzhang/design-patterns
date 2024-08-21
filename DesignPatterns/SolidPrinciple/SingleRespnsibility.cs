using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple
{
    /// <summary>
    /// A class should only have one reason to change
    /// Seperation of concerns - different classes handling different, independent tasks/problems
    /// </summary>
    public class Journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;
        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count;
        }

        public void Remove(int index) { 
            entries.RemoveAt(index);
        }

        public void Save(string filename)
        {
            File.WriteAllText(filename, ToString());
        }

        /// <summary>
        /// Not doing the following, as breach the Single Responsibility principle
        /// </summary>
        /// <returns></returns>

        //public static Journal Load(string filename)
        //{

        //}

        //public void Load(Uri uri)
        //{

        //}

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }
    }

    /// <summary>
    /// Use A persistence class to maintain persis functions (i.e. Save, Load)
    /// </summary>
    public class Persistence
    {
        public void SaveTofile(Journal j, string filename, bool overwrite = false) {
            if (overwrite || !File.Exists(filename)) { 
                File.WriteAllText(filename, j.ToString());
            }
        }
    }

    public class SingleResponsibility
    {
        public static void Main(string[] args)
        {
            Console.Title = "Singile Responsibility";

            var j = new Journal();
            j.AddEntry("I cried today");
            j.AddEntry("I ate a bug");
            Console.WriteLine(j.ToString());

            var p = new Persistence();
            var filename = @"D:\\temp\\journal.txt";
            p.SaveTofile(j, filename, true);
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = "notepad.exe", // Specify the application to open the file with
                Arguments = @"D:\temp\journal.txt", // Specify the file to open
                UseShellExecute = true // Use shell execution so the OS can find the application
            };
            Process.Start(startInfo);
        }
    }
}
