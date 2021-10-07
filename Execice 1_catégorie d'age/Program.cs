using System;

namespace Execice_1_catégorie_d_age
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            string categorie = "";
            Console.WriteLine("Donne moi ton age");
            age = Convert.ToInt32(Console.ReadLine());

            trouverLaCategori(age, out categorie);
            Console.WriteLine(categorie);
        }

        static void trouverLaCategori(int age, out string categorie) {
            if (age <= 5){
                categorie = "age trop petit";

            }
            else if (age <= 7){
                categorie = "Poussin";

            }
            else if (age <= 9){
                categorie = "pupille";

            }
            else if (age <= 11){
                categorie = "minime";

            }
            else if (age <= 14){
                categorie = "cadet";

            }
            else{
                categorie = "age trop grand";
            }
        }
    }
}
