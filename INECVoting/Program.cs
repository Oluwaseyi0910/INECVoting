using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment5
{
    internal class Program


    {
        public SortedList<string, int> MulVectors(string[] Voters)
        {
            SortedList<string, int> MultipleVoters = new SortedList<string, int>();
            foreach (var name in Voters)               //loop through the voters list
            {
                int count = 0;
                if (MultipleVoters.ContainsKey(name))  //check if the mulitple voters list already contains the name and count
                {
                    continue;
                }
                for (int i = 0; i < Voters.Length; i++)  //count the number of times the voter appears in the list
                {
                    if (name == Voters[i])
                    {
                        count++;
                    }
                }

                if (count > 1)
                {
                    MultipleVoters.Add(name, count);  // add the names and counts of multiple voters to a list
                }
            }
            return MultipleVoters;
        }

        public HashSet<string> PreventMulReg(string[] arr)
        {
            HashSet<string> newList = arr.ToHashSet();
            Console.WriteLine("Add New Voter to the Lists");
            string name = Console.ReadLine();
            bool isAdd = newList.Add(name);
            if (isAdd == false)
            {
                Console.WriteLine("Duplicate Registration Disallowed");
            }

            return newList;
        }

        static void Main(string[] args)
        {
            string[] Voters = { "Ade", "Bisi", "Bisi", "Kate", "Tayo", "Peter", "Pius" };

            var MultipleVoters = new Program();

            foreach (var item in MultipleVoters.MulVectors(Voters)) //printing the list of Multiple voters
            {
                Console.WriteLine("{0}, {1}", item.Key, item.Value);
            }

            var newList = MultipleVoters.PreventMulReg(Voters);



        }
    }
}