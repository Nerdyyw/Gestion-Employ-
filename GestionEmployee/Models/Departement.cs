using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Runtime.ConstrainedExecution;
using System.Threading.Channels;

namespace GestionEmployee.Models
{
    [Table("Departements",Schema ="HR")]
    //Cet attribut est utilisé pour spécifier le nom de la table dans la base de données et le schéma 
    //auquel elle appartient.Dans cet exemple, la table s'appelle "Departements" et elle appartient au schéma "HR".
    //cela signifie que la classe Departement est mappée à une table nommée "Departements" dans la base de données, 
    //et cette table est située dans le schéma "HR"
    public class Departement
    {
        [Key]
        //Cet attribut indique que la propriété DepartementId est la clé primaire de la table.

       [Display(Name ="ID")]
        //Cet attribut spécifie le nom convivial à afficher pour la propriété DepartementId 
        //lorsqu'elle est utilisée dans une interface utilisateur. Dans cet exemple, le nom affiché serait "ID".


        public int DepartementId { get; set; }


        [Required]
        //Cet attribut indique que la propriété NomDepartement est obligatoire, 
        //c'est-à-dire qu'elle ne peut pas être nulle.

       [Display(Name ="Nom Departement")]
        [Column(TypeName ="varchar(200)")]
        //Cet attribut est utilisé pour spécifier le type de colonne dans la base de données.
        //Il indique que la colonne correspondant à la propriété NomDepartement doit être de type varchar(200).

        public string NomDepartement { get; set; }=String.Empty;
        //Définition de la propriété NomDepartement 
        //qui représente le nom du département.La valeur par défaut est une chaîne vide.
    }
}
