using System;
using System.Collections.Generic;
using Test.Entities;


namespace Test {
    class Program {
        static void Main(string[] args) {

            Console.Write("How many students for couser: ");
            int n = int.Parse(Console.ReadLine());

            HashSet<Couser> couserA = new HashSet<Couser>();
            HashSet<Couser> couserB = new HashSet<Couser>();
            HashSet<Couser> couserC = new HashSet<Couser>();

            for (int i = 1; i <= n; i++) {
                int student = int.Parse(Console.ReadLine());
                couserA.Add(new Couser(student));
            }

            Console.Write("How many students for couser: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                int student = int.Parse(Console.ReadLine());
                couserB.Add(new Couser(student));
            }

            Console.Write("How many students for couser: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                int student = int.Parse(Console.ReadLine());
                couserC.Add(new Couser(student));
            }

            HashSet<Couser> total = new HashSet<Couser>(couserA);
            total.UnionWith(couserB);
            
            total.UnionWith(couserC);
            Console.WriteLine("Total students: " + total.Count);
        }
    }
}
