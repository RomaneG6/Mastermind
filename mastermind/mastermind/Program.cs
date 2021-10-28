using System;

namespace mastermind
{
    class Program
    {
        //cette fonction est le début de mon programme
        static void Main(string[] args)
        {
            string combinaison;
            int proposition;
            int[] combi;
            ChoixCombi(out combi);
            Afficher(combi);
            Console.WriteLine("Définir les couleurs choisies");
            combinaison = Console.ReadLine();
        }

        //cette fonction permet à l'ordi de choisir une combinaison
        static void ChoixCombi(out int[] combi) {
            combi = new int[4];
            Random rnd = new Random();
            for (int i = 0; i <= 3; i++) {
                int valeur = rnd.Next(1, 7);
                combi[i] = valeur;
            }
        }

        static void Afficher(int[] combi) {
            for (int i = 0; i <= 3; i++) {
                Console.Write(combi[i]);
            }
        }

        static void stringToArray(string combinaison, out int[] proposition)
       {
            proposition = new int[4];
            for (int i = 0; i <= 3; i++)
            {
               proposition[i] = combinaison[i]
            }

        }

    }
}
