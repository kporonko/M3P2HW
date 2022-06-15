using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Contact> contacts = new List<Contact>();
            FillContacts(contacts);

            // Where.
            var tempList = contacts.Where(x => x.Name.StartsWith('N')).ToList();
            foreach (var contact in tempList)
            {
                Console.WriteLine(contact.Name + ": " + contact.Number);
            }

            // Select.
            var numList = contacts.Select(x => x.Number).ToList();
            foreach (var number in numList)
            {
                Console.WriteLine(number);
            }

            // FirstOrDefault.
            var val = contacts.FirstOrDefault(x => x.Name.Contains('A'));
            Console.WriteLine(val.Name + ": " + val.Number);

            // Count.
            var count = contacts.Count();

            // Take.
            var takenList = contacts.Take(5);
            foreach (var contact in takenList)
            {
                Console.WriteLine(contact.Name + ": " + contact.Number);
            }

            // Group By.
            var groupby = contacts.GroupBy(x => x.Name);
            foreach (var item in groupby)
            {
                Console.WriteLine(item.Key); // Works like distinct here.
            }

            // Concat
            var doubleContacts = contacts.Concat(contacts).ToList();
            foreach (var contact in doubleContacts)
            {
                Console.WriteLine(contact.Name + ": " + contact.Number);
            }

            Console.ReadLine();
        }

        private static void FillContacts(List<Contact> contacts)
        {
            contacts.Add(new Contact(387924, "Nastya"));
            contacts.Add(new Contact(125326, "Vika"));
            contacts.Add(new Contact(454543, "Anya"));
            contacts.Add(new Contact(656444, "Jack"));
            contacts.Add(new Contact(322222, "Alex"));
            contacts.Add(new Contact(444444, "Alex"));
            contacts.Add(new Contact(111111, "Alex"));
            contacts.Add(new Contact(222222, "Andrew"));
            contacts.Add(new Contact(222223, "Vladik"));

        }
    }
}
