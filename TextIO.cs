using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleExercises
{
    internal class TextIO 
    {
        public void Run()
        {
            string path = @"test.txt";

            // write file


            if (!File.Exists(path))
            {
                try
                {
                    StreamWriter write = new StreamWriter(path, false);
                    write.WriteLine("Hello");
                    write.WriteLine("And");
                    write.WriteLine("Welcome");
                    write.Close();



                    //Dispose of the object
                    try
                    {
                        write.Dispose();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }



                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }



            }

            //read file
            try
            {
                using (StreamReader reader = new StreamReader(path))
                {

                    string str;
                    while ((str = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(str);
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
