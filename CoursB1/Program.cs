using CoursB1.DataAccess;
using System;

namespace CoursB1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Création */

            Console.WriteLine("On créé deux utilisateurs et on les affiches : ");


            //  On créé deux utilisateurs avec un nom et un prénom

            User user1 = new User("LAMARCHE", "Maxime");
            user1 = DBContext.CreateUser(user1);

            User user2 = new User("DA SILVA", "Arnaud");
            user2 = DBContext.CreateUser(user2);


            //  On boucle sur tous les utilisateurs présents en BDD et on les affiches
            //  Le  but est de montrer que les utilisateurs sont bien créés

            foreach(User user in DBContext.GetAllUsers())
            {
                Console.WriteLine(" - " + user.USRSYSID + "     / " + user.USRLASTNAME + " " + user.USRFIRSTNAME + " \n");
            }


            /* Modification */

            Console.WriteLine("On modifie les deux utilisateurs et on les affiches : ");
            

            //  On modifie les deux utilisateurs (ici on modifie juste le prénom)

            user1.USRFIRSTNAME = "est modifé";
            DBContext.UpdateUser(user1);

            user2.USRFIRSTNAME = "est modifié";
            DBContext.UpdateUser(user2);


            //  On boucle sur tous les utilisateurs présents en BDD et on les affiches
            //  Le but est de montrer que les utilisateurs sont bien modifiés

            foreach (User user in DBContext.GetAllUsers())
            {
                Console.WriteLine(" - " + user.USRSYSID + "     / " + user.USRLASTNAME + " " + user.USRFIRSTNAME + " \n");
            }


            /* Suppression */

            Console.WriteLine("On supprime les deux utilisateurs et on vérifie qu'ils ne soient plus dans la BDD : ");


            //  On supprime les deux utilisateurs

            DBContext.DeleteUser(user1);
            DBContext.DeleteUser(user2);


            //  On boucles sur toues les utilisateurs présents en BDD et on les affiches
            //  Le but est de montrer que les utilisateurs sont bien supprimés

            foreach (User user in DBContext.GetAllUsers())
            {
                Console.WriteLine(" - " + user.USRSYSID + "     / " + user.USRLASTNAME + " " + user.USRFIRSTNAME + " \n");
            }


            //  Permet de laisser la console ouverte une fois le traitement terminé

            Console.ReadLine();
        }
    }
}