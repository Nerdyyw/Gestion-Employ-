using GestionEmployee.Models;
//ce qui signifie que la classe GestionDbContext peut utiliser les classes définies dans ce namespace
//notamment les classes Departement et Employe.
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net;
using System.Text;

namespace GestionEmployee.Data 
{
    //Déclare la classe GestionDbContext qui hérite de la classe DbContext.
    //Cette classe représente le contexte de la base de données pour l'application.
    public class GestionDbContext :DbContext
    {
        public GestionDbContext(DbContextOptions<GestionDbContext> options) : base(options)
        { 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
        //Propriété qui représente une table dans la base de données pour l'entité Departement. 
        //Un DbSet est une collection d'objets qui correspond à une table dans la base de données.
        public DbSet<Departement> Departements { get; set;}

        public DbSet<Employe> Employes { get; set;}
    }
}

//la classe GestionDbContext agit comme un point central pour interagir avec la base de données.
//Elle inclut des propriétés DbSet pour les entités Departement et Employe et peut être utilisée pour effectuer 
//des opérations de lecture et d'écriture sur la base de données à l'aide d'Entity Framework Core.
//La méthode OnModelCreating peut être utilisée pour configurer le modèle de base de données, 
//bien que dans cet exemple, elle soit vide.