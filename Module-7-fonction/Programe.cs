using System.Runtime.CompilerServices;

namespace ExerciseFonction
{
    internal class Programe
    {
        static void Main(string[] args)
        {

            
            
            fonction.Saluer("Jeff");

            int minimum = fonction.CalculerMinimum(10, 15);
            Console.WriteLine(minimum);

            int maximum = fonction.CalculerMaximum(10, 15);
            Console.WriteLine(maximum);

            int maximum2 = fonction.CalculerMaximum(maximum, 25);
            Console.WriteLine(maximum2);

            //Console.WriteLine("Entrer un nombre reel entre 0 et 100 (note) :");

            //double note = double.Parse(Console.ReadLine());
            //fonction.LireReel(note);  // alternative


            double note = 0.0;
            note = fonction.LireReel();
            Console.WriteLine(note);

            double[] tableau1 = new double[5] { 1, 2, 3, 4, 5 };
            double somme = fonction.TableauSomme(tableau1);
            Console.WriteLine("La somme du tableau est de: " + somme);

            Console.WriteLine(fonction.TableauMoyenne(tableau1));












        }
        //fonction.AfficherLigneEtoile(4, 'a');
        //int minimum = fonction.CalculerMinimum(13, 42);
        //Console.WriteLine(minimum);    
    }   
}