using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseFonction
{
    internal class fonction
    {

        public static void AfficherLigneEtoile(int p_longeur, char p_motif)
        {
            for (int i = 0; i < p_longeur; i++) ;
                

        }

        public static int CalculerMinimum(int p_valeur1,int p_valeur2)
        {
            int result = p_valeur1;
            if(p_valeur2 < result)
                result = p_valeur2;
            return result;
        }
        public static void Saluer(string UserName)
        {
            
            Console.WriteLine("Salut " + UserName);
        }
        public static int CalculerMaximum(int nombre1,int nombre2)
        {
            int result = nombre1;
            if (nombre2 > result)
                result = nombre2;
            return result;
        }
        //public static double LireReel(double note)
        //{
        //    if (note < 0 | note > 100)
        //    {
        //        Console.WriteLine("Note trop base");
        //    }
        //    else
        //    {

        //        Console.WriteLine("Entrer un autre nombre reel entre 0 et 100 ");
        //        note = double.Parse(Console.ReadLine());
        //    }

        //    return note;

        //} //fonction alternative
        public static double LireReel()
        {
            
            Console.WriteLine("entrer une valeur entre 0 et 100");
            double note = double.Parse(Console.ReadLine());
            while (note < 0 | note > 100)
            {
                Console.WriteLine("Note incorrect entrer une note entre 0 et 100");
                note = double.Parse(Console.ReadLine());  
            }
            return note;
        }
        public static double TableauSomme(double[] tableau1)
        {
            double somme = 0.0;
            for (int i = 0; i < tableau1.Length; i++)
            {
                somme += tableau1[i];

            }

            return somme;
        }
        public static double TableauMoyenne(double[] tableau1)
        {
            double moyenne = 0.0;
            moyenne = (fonction.TableauSomme(tableau1) / tableau1.Length);


            return moyenne;
        }

    }
}
