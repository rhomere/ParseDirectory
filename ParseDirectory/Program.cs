using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Parse Directory App\n");
            Console.WriteLine("Ex: /fileName.pdf or /folderName1/folderName2/fileName.pdf");
            Console.Write("Enter Directory: ");
            var input = Console.ReadLine();
            var inputArr = input.Split('/').ToList();
            DoSomething(inputArr);
            
        }

        static void DoSomething(List<string> arr)
        {
            var fileName = arr.LastOrDefault();
            arr.RemoveRange(0, 1);

            if(arr.Count() == 1)
            {
                Console.WriteLine($"\nFileName: {fileName}");
            }
            else
            {
                arr.RemoveRange(arr.Count - 1, 1);
                for (int i = 0; i < arr.Count(); i++)
                {
                    Console.WriteLine($"\nFolder: {arr[i]}");
                }
                Console.WriteLine($"\nFileName: {fileName}");
            }
            
        }
    }
}
