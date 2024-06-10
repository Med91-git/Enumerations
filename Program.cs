using System.ComponentModel;

namespace Enumérations
{

    public enum EColors 
    {

        [Description("Rouge")]
        RED,

        [Description("Vert")]
        GREEN,

        [Description("Bleu")]
        BLUE,

        [Description("Jaune")]
        YELLOW,
    }

    public class User
    {
        public string Name { get; set; }
        public string FirstName { get; set; }

        public EColors Color{ get; set; } 

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // instancier la liste des utilisateurs avec des couleurs différentes

            List<User> users = new List<User>() 
            {
                new User {Name = "Turner", FirstName = "Carl", Color = EColors.RED }, 
                new User {Name = "Dubois", FirstName = "Charles", Color = EColors.YELLOW },
                new User {Name = "Nguyen", FirstName = "Julie", Color = EColors.RED},
                new User {Name = "Perez", FirstName = "Carlos", Color = EColors.GREEN },
                new User {Name = "VanderBeeld", FirstName = "Jiren", Color = EColors.YELLOW }, 
                new User {Name = "Johnson", FirstName = "Paul", Color = EColors.BLUE },

            }; 

            foreach(User user in users)
            {
                Console.WriteLine("Nom : " + user.Name);
                Console.WriteLine("Prénom : " + user.FirstName);
                Console.WriteLine("Couleur : " + user.Color);
                Console.WriteLine();
            }


            Console.WriteLine("Test affichage du nombre d'utilisateurs :");

            // nombre utilisateur
            
            
            // Parcourir chaque couleur disponible

            foreach (EColors color in Enum.GetValues(typeof(EColors)))
            {
                int compteurnbUtilisateurEnCours = 0;
                // Parcourir chaque utilisateur 
                foreach (User user in users)
                {
                    if (user.Color == color)
                    {
                        compteurnbUtilisateurEnCours++;
                    }
                }
                Console.WriteLine($" nombre d'utilisateurs avec la couleur {color} : {compteurnbUtilisateurEnCours} utilisateur (s)");

            }







        }
    }
}
