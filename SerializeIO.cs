using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * write a serilize and deseriliaze function for the contact struct
 * serilize should write the contents of the object into a file
 * deseriliaze shoudld read the contents of a file and assign them to the objects variables
 
 */
namespace ConsoleExercises
{
    struct Contact
    {
        public string name;
        public string email;
        public int id;

        public Contact(string name, string email, int id)
        {
            this.name = name;
            this.email = email;
            this.id = id;
        }
        public void Print()
        {
            Console.WriteLine(name + " |  " + email + "  |  " + id);
        }

        public void Serialize(string path)
        {
            
            
            if (!File.Exists(path))
            {
                try
                {
                    StreamWriter write = new StreamWriter(path, false);
                    write.WriteLine(name);
                    write.WriteLine(email);
                    write.WriteLine(id);

                   

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





        }

        public void DeSerialize(string path)
        {
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

    
    internal class SerializeIO
    {
        
        public void Run()
        {

            // make 3 contacts

            Contact bob = new Contact("Bob", "bob@email.com", 1234);
            Contact fred = new Contact("Fred", "fred@email.com", 12345);
            Contact jane = new Contact("Jane", "jane@email.com", 123456);

            //write each contact to a file
            
           

            bob.Serialize(@"bob.txt");
            fred.Serialize(@"fred.txt");
            jane.Serialize(@"jane.txt");


            // Clear out contacts
            bob = new Contact();
            fred = new Contact();
            jane  = new Contact();

           // Load contents from file
            bob.DeSerialize(@"bob.txt");
            fred.DeSerialize(@"fred.txt");
            jane.DeSerialize(@"jane.txt");


            //print contacts
            bob.Print();
            fred.Print();
            jane.Print();
        }

        
    }
}
