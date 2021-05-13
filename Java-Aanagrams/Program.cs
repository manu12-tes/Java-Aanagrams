using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Java_Aanagrams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dame primera cadena");
            String a = Console.ReadLine();
            Console.WriteLine("Dame segunda cadena");
            String b = Console.ReadLine();

             bool res= esAnagrama(a, b);
            Console.WriteLine((res)? "Anagrams": "No Anagarams");

        }
        static bool esAnagrama(String a, String b)
        {
            Hashtable cadA = new Hashtable();
            Hashtable cadB = new Hashtable();
            char[] aux1 = a.ToCharArray();
            char[] aux2 = b.ToCharArray();
            bool si = false;
            for (int x = 0; x < a.Length; x++)
            {
                if (cadA.ContainsKey(aux1[x]))
                {
                    cadA[aux1[x]] = +1;
                }
                else
                {
                    cadA.Add(aux1[x], 1);
                }
            }
            for (int x = 0; x < b.Length; x++)
            {
                if (cadB.ContainsKey(aux2[x]))
                {
                    cadB[aux2[x]] = +1;
                }
                else
                {
                    cadB.Add(aux2[x], 1);
                }
            }


            foreach (var element in cadA)
            {
                if (cadA[element] == cadB[element])
                {
                    si = true;
                }
            }
            return si;
        }
    }
}
