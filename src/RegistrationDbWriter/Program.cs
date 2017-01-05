using RegistrationDbWriter.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationDbWriter
{
    public class Program
    {
        private List<Address> addressList;
        private List<Person> personList;
        private List<string> lines;

        public Program()
        {
            this.addressList = new List<Address>();
            this.personList = new List<Person>();
            this.lines = new List<string>();
        }

        public void Main(string[] args)
        {
            for (var currChar = 'A'; currChar <= 'Z'; currChar++)
            {
                Console.WriteLine($"Reading {currChar} File");
                this.ReadLines(currChar);
            }

            foreach(var line in lines)
            {

            }
        }

        private void ReadLines(char keyChar)
        {
            var currLines = System.IO.File.ReadAllLines($"C:\\Users\\Seth\\Personal\\Development\\Projects\\registration-parser\\RegistrationParser\\bin\\Debug\\registration-{keyChar}.csv").ToList();
            this.lines.AddRange(currLines);
        }
    }
}
