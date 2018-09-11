using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace HW6
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            Dictionary<string, string> PhoneNumbers = new Dictionary<string, string>();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Input name :");
                string name = Console.ReadLine();
                Console.WriteLine("input namber");
                string num = Console.ReadLine();
                PhoneNumbers[name] = num;
                //PhoneNumbers.Add(name, num);
            }

            using (StreamWriter writer = new StreamWriter("phones.txt"))
            {
                foreach (KeyValuePair<string, string> keyValue in PhoneNumbers)
                {
                    writer.WriteLine($"{keyValue.Key}:{keyValue.Value}");
                }
            }
            using (StreamWriter writertwo = new StreamWriter("Phoness.txt"))
            {
                foreach (KeyValuePair<string, string> keyValue in PhoneNumbers)
                {
                    writertwo.WriteLine($"{keyValue.Value}");
                }
            }


            var re = new StreamReader("phones.txt");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(re.ReadLine());
            }


            int counter = 0;
            string line;

            Console.Write("Input your search Name: ");
            var text = Console.ReadLine();

            StreamReader file = new StreamReader("phones.txt");

            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(text))
                {
                    break;
                }
                counter++;
            }
            Console.WriteLine("Line number: {0}", line);
            file.Close();

            for (int i = 0; i < PhoneNumbers.Count; i++)
            {
                if (PhoneNumbers.Values.ElementAt(i).StartsWith("80"))
                {
                    PhoneNumbers[PhoneNumbers.Keys.ElementAt(i)] = "+3" + PhoneNumbers.Values.ElementAt(i);
                }
            }

            using (StreamWriter newWrite = new StreamWriter("New.txt"))
            {
                foreach (var phoneNum in PhoneNumbers)
                {
                    newWrite.WriteLine($"{phoneNum.Key}:{ phoneNum.Value}");
                }
            }
            #endregion




            Console.ReadKey();
        }
    }
}
