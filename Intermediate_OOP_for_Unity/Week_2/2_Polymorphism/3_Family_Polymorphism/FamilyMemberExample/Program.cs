using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyMemberExample
{
    /// <summary>
    /// Demonstrates polymorphism
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates polymorphism
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            List<FamilyMember> familyMembers = new List<FamilyMember>();

            // add family members
            familyMembers.Add(new FamilyMember(69, 185));
            familyMembers.Add(new Gamer(70, 200));
            familyMembers.Add(new Geek(71, 165));

            // everybody have fun
            foreach (FamilyMember familyMember in familyMembers)
            {
                familyMember.HaveFun();
            }

            Console.WriteLine();
        }
    }
}