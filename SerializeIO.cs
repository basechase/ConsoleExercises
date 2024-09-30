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
            
                StreamWriter write = new StreamWriter(path, false); 
                write.Close();
                
               
                
            
        }

        public void DeSerialize(string path)
        {

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
            
           

            bob.Serialize(@"contacts\bob.txt");
            fred.Serialize(@"contacts\bob.txt");
            jane.Serialize(@"contacts\bob.txt");


            // Clear out contacts
            bob = new Contact();
            fred = new Contact();
            jane  = new Contact();

           // Load contents from file
            bob.DeSerialize(@"contacts\bob.txt");
            fred.DeSerialize(@"contacts\bob.txt");
            jane.DeSerialize(@"contacts\bob.txt");


            //print contacts
            bob.Print();
            fred.Print();
            jane.Print();
        }

        
    }
}
