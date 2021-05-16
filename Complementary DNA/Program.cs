using System;

/*Deoxyribonucleic acid(DNA) is a chemical found in the nucleus of cells and carries the "instructions" 
 * for the development and functioning of living organisms.
 * 
 * If you want to know more http://en.wikipedia.org/wiki/DNA
 * 
 * In DNA strings, symbols "A" and "T" are complements of each other, as "C" and "G". 
 * You have function with one side of the DNA (string, except for Haskell); you need to get the other complementary side. 
 * DNA strand is never empty or there is no DNA at all (again, except for Haskell).
*/
namespace Complementary_DNA
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "TATATATA";
            string s1 = "TTTAAA";
            string s2 = "AATTAA";
            string s3 = "CGCGCG";
            string s4 = "CCCGGG";
            string s5 = "CCGGCC";
            char placeholder = '-';

            Console.WriteLine(s + " -> " + complement(s));
            Console.WriteLine(s1 + " -> " + complement(s1));
            Console.WriteLine(s2 + " -> " + complement(s2));
            Console.WriteLine(s3 + " -> " + complement(s3));
            Console.WriteLine(s4 + " -> " + complement(s4));
            Console.WriteLine(s5 + " -> " + complement(s5));

            string complement(string dna)
            {
                string mu = dna
                    .Replace('A', placeholder)
                    .Replace('T','A')
                    .Replace(placeholder,'T')
                    .Replace('C', placeholder)
                    .Replace('G','C')
                    .Replace(placeholder,'G');
                return mu;
            }

        }
    }
}
