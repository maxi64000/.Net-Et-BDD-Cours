# Cours B1 - .Net et BDD


Utilisation de SQL Server : 

  Il faut installer et créer une Base dans SQL Server
  Il faut pouvoir se connecter en tant qu'administrateur : 
  
- Login : sa
- MDP :   VotreMotDePasse

---

Utilisation d'un ORM : **Dapper** : 

Pour installer Dapper :
  
1. Clic droit sur le nom de la solution  
2. Gérer les packages NuGet  
3. Rechercher *Dapper*  
4. Cliquer sur **Installer**

Voila vous avez installer Dapper !

#

[Création de la chaine de connexion](http://www.connectionstrings.com/) :
  
    SqlConnection dbConnection = new SqlConnection("  
  
        Data Source=NOMDUSERVEUR;
        Initial Catalog=NOMDELABASE;
        User ID=sa;
        Password=MOTDEPASSE;
                                                    
      ");
  
Pour obtenir les informations nécessaires pour créer une bonne chaine de connexion : 
  
**NOMDUSERVEUR** :  
- Clic droit sur le serveur (tout en haut)
- Propriétés
- Nom (copier ce qui est renseigné)
                      
**NOMDELABASE** : 
- Nom de la base de donéne que vous avez créé
  
**LOGIN** : 
- sa (car on se connecte en tant qu'administrateur)
    
**MOTDEPASSE** :   
Le mot de passe que vous avez renseigné lors de l'installation de SQL Server (refaire l'installation si vous avez oublié votre mot de passe)

---

Le but ensuite et de créer une classe *USER*, et de pouvoir :

  - Créer un utilisateur
  - Modifier un utilisateur
  - Supprimer un utilisateur
  
Bonne chance !
