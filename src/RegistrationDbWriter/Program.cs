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
        private List<VotingRecord> votingRecordList;
        private List<string> lines;

        public Program()
        {
            this.addressList = new List<Address>();
            this.personList = new List<Person>();
            this.votingRecordList = new List<VotingRecord>();
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

        private int WritePerson(Person person)
        {

        }

        private int WriteAddress(Address address)
        {

        }

        private int WriteVotingRecord(VotingRecord votingRecord)
        {

        }

        public class Person
        {
            public int Id { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string MiddleName { get; set; }

            public DateTime? RegistrationDate { get; set; }

            public string Affiliation { get; set; }

            public int AddressId { get; set; }
        }

        public class Address
        {
            public int Id { get; set; }

            public string Line1 { get; set; }

            public string Line2 { get; set; }

            public string Line3 { get; set; }
            
            public string Precinct { get; set; }

            public string Ward { get; set; }
        }

        public class VotingRecord
        {
            public int Id { get; set; }

            public string Status1504 { get; set; }

            public string Status1411 { get; set; }

            public string Status1407 { get; set; }

            public string Status1404 { get; set; }

            public string Status1304 { get; set; }

            public string Status1211 { get; set; }

            public int PersonId { get; set; }
        }
    }
}
