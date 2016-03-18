namespace CoursB1
{
    /// <summary>
    /// Contient les fonctions nécessaires pour un utilisateur
    /// </summary>
    public class User
    {
        #region Getter and Setter

        /// <summary>
        /// Id de l'utilisateur
        /// </summary>
        public int USRSYSID { get; set; }

        /// <summary>
        /// Nom de l'utilisateur
        /// </summary>
        public string USRLASTNAME { get; set; }

        /// <summary>
        /// Prénom de l'utilisateur
        /// </summary>
        public string USRFIRSTNAME { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Permet d'initialiser un utilisateur vide
        /// </summary>
        public User()
        {
            USRSYSID = 0;
            USRLASTNAME = null;
            USRFIRSTNAME = null;
        }

        /// <summary>
        /// Permet d'initialiser un utilisateur avec un nom et un prénom
        /// </summary>
        /// <param name="lastName">Nom de l'utilisateur</param>
        /// <param name="firstName">Prénom de l'utilisateur</param>
        public User(string lastName, string firstName)
        {
            USRSYSID = 0;
            USRLASTNAME = lastName;
            USRFIRSTNAME = firstName;
        }

        #endregion
    }
}
