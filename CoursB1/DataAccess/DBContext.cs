using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace CoursB1.DataAccess
{
    /// <summary>
    /// Contient toutes les fonctions necessitants un accès à la base de donnée
    /// </summary>
    public static class DBContext
    {
        /// <summary>
        /// Chaine de connexion à la base de donnée
        /// </summary>
        private static SqlConnection dbConnection;

        #region USERS

        /// <summary>
        /// Permet d'obtenir un utilisateur
        /// </summary>
        /// <param name="id">Id de l'utilisateur</param>
        /// <returns>Un utilisateur</returns>
        public static User GetUser(int id)
        {
            User user = new User();

            using (dbConnection = new SqlConnection("Data Source=PC-MAXIME;Initial Catalog=B1;User ID=sa;Password=p@ssw0rdmjp6433;"))
            {
                user = dbConnection.Query<User>("select USRSYSID, USRLASTNAME, USRFIRSTNAME from USERS where USRSYSID = @ID", new { ID = id }).Single();
            }

            return user;
        }

        /// <summary>
        /// permet de créer un utilisateur
        /// </summary>
        /// <param name="user">Utilisateur devant être créé</param>
        /// <returns>Utilisateur créé</returns>
        public static User CreateUser(User user)
        {
            int id = 0;

            using (dbConnection = new SqlConnection("Data Source=PC-MAXIME;Initial Catalog=B1;User ID=sa;Password=p@ssw0rdmjp6433;"))
            {
                //  La requête permet d'ajouter un utilisateur ET de récupérer l'identifiant de l'utilisateur venant d'être créé

                id = dbConnection.Query<int>("insert into USERS (USRLASTNAME, USRFIRSTNAME) values (@USRLASTNAME, @USRFIRSTNAME); select CAST(SCOPE_IDENTITY() as int)", user).Single();
            }


            //  Comme on ne connais pas encore l'identifiant de l'utilisateur qu'on vient de créé il est difficile de le récupérer par la suite
            //  On retourne donc l'utilisateur venant d'être créé grâce à l'identifiant que la requête nous donne

            return GetUser(id);
        }

        /// <summary>
        /// Permet d'obtenir la liste des utilisateurs
        /// </summary>
        /// <returns>Liste des utilisateurs</returns>
        public static List<User> GetAllUsers()
        {
            List<User> listOfUsers = new List<User>();

            using (dbConnection = new SqlConnection("Data Source=PC-MAXIME;Initial Catalog=B1;User ID=sa;Password=p@ssw0rdmjp6433;"))
            {
                listOfUsers = dbConnection.Query<User>("select USRSYSID, USRLASTNAME, USRFIRSTNAME from USERS").ToList();
            }

            return listOfUsers;
        }

        /// <summary>
        /// Permet de modifier un utilisateur
        /// </summary>
        /// <param name="user">Utilisateur devant être modifié</param>
        public static void UpdateUser(User user)
        {
            using (dbConnection = new SqlConnection("Data Source=PC-MAXIME;Initial Catalog=B1;User ID=sa;Password=p@ssw0rdmjp6433;"))
            {
                dbConnection.Execute("update USERS set USRLASTNAME = @USRLASTNAME, USRFIRSTNAME = @USRFIRSTNAME where USRSYSID = @USRSYSID", user);
            }
        }

        /// <summary>
        /// Permet de supprimer un utilisateur
        /// </summary>
        /// <param name="user">Utilisateur devant être supprimé</param>
        public static void DeleteUser(User user)
        {
            using (dbConnection = new SqlConnection("Data Source=PC-MAXIME;Initial Catalog=B1;User ID=sa;Password=p@ssw0rdmjp6433;"))
            {
                dbConnection.Execute("delete from USERS where USRSYSID = @USRSYSID", user);
            }
        }

        #endregion
    }
}
