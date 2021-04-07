using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace I_Feel_Great
{
    // This class is used to run the start up of the program where:
    // The user is asked how many people are answering this could be 1 or any other number
    // Then the program gets the total yes values and total no values and assigns them to txt doc
    // After this the program re-assigns them to arrays to get accurate results therefore get true values
    // of how many yes answers and no answers
    public class Welcome
    {
        public void startup()
        {
            string path = @"C:\Users\musta\Desktop\yes.txt";
            string path1 = @"C:\Users\musta\Desktop\no.txt";
            Console.WriteLine("How many people are answering today?");
            int size = Convert.ToInt32(Console.In.ReadLine());
            string[] yes = new string[size];
            string[] no = new string[size];
            string input = "";
            Console.WriteLine("Are you feeling great today?");
            for (int i = 0; i < yes.Length; i++)
            {
                Console.WriteLine("Enter yes or no");
                input = Console.ReadLine();
                if (input.Equals("yes"))
                {
                    yes[i] = input;
                    Console.WriteLine("Thanks");
                }
                else if (input.Equals("no"))
                {
                    no[i] = input;
                    Console.WriteLine("Hope you feel better");
                }
                else
                {
                    Console.WriteLine("Please enter yes or no");
                }
            }
            // Write all yes to file
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (string line in yes)
                {
                    if (!string.IsNullOrEmpty(line) && line.Length > 1)
                    {
                        sw.WriteLine(line.Replace(" ", string.Empty));
                    }
                }
            }
            // Write all no to file
            using (StreamWriter sw = new StreamWriter(path1))
            {
                foreach (string line in no)
                {
                    if (!string.IsNullOrEmpty(line) && line.Length > 1)
                    {
                        sw.WriteLine(line.Replace(" ", string.Empty));
                    }
                }
            }
        }
        public int totalyes()
        {
            string[] yes;
            var list = new List<string>();
            var fileStream = new FileStream(@"C:\Users\musta\Desktop\yes.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
            yes = list.ToArray();
            int totalElements = yes.Count();
            return totalElements;
        }
        public int totalno()
        {
            string[] no;
            var list = new List<string>();
            var fileStream = new FileStream(@"C:\Users\musta\Desktop\no.txt", FileMode.Open, FileAccess.Read);
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    list.Add(line);
                }
            }
            no = list.ToArray();
            int totalElements = no.Count();
            return totalElements;
        }
    }
}
