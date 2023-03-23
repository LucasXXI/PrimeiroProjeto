using PrimeiroProjeto.logica;
using PrimeiroProjeto.poo;
using PrimeiroProjeto.poo.exerciciosClasses;
using PrimeiroProjeto.poo.construtores;
using System.Globalization;
using PrimeiroProjeto.poo.Structs;
using PrimeiroProjeto.vetores;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Lucas");
            list.Add("Carla");
            list.Add("Anna");
            list.Insert(0, "Dracula");

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("List count: " + list.Count());
            string s1 = list.Find(x => x[0] == 'A'); //funcao lambda
            Console.WriteLine("Teste: " + s1);

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last: " + s2);

            int p1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine(p1);

            int p2 = list.FindLastIndex(x  => x[0] == 'A');
            Console.WriteLine(p2);

            Console.WriteLine("---------------");
            List<string> list2 = list.FindAll(x => x.Length == 5);

            foreach(var element in list2)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("---------------");
            list.Remove("Alex");
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("---------------");
            list.RemoveAll(x => x[0] == 'M');
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("---------------");
            list.RemoveAt(2);
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("---------------");
            list.RemoveAll(x => x[0] == 'D');
            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
            //pode ser passaado no find (forma explicita);
            static bool a(string s)
            {
                return s[0] == 'A';
            }
        }

    }
}
