using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;

namespace GestionEmployee.Models
{
    [Table("Employes", Schema ="HR")]
    public class Employe
    {
        [Key]
        [Display(Name ="ID")]
        public int EmployeId { get; set; }

        [Display(Name = "Nom")]
        [Column (TypeName ="varchar(200)")]
        public string NomEmploye { get; set; }=String.Empty;

        [Display(Name = "Image User")]
        [Column(TypeName = "varchar(200)")]
        public string? UserImage { get; set; }

        //Le point d'interrogation (?) indique que la propriété peut être nulle (nullable). 
        [Display(Name = "Date Naissance")]
        [DataType(DataType.Date)]
        //Cet attribut spécifie le type de données de la propriété.Dans ce cas, la propriété DateNaissance est de type DateTime,
        //mais avec l'attribut [DataType(DataType.Date)], vous indiquez que la propriété représente une date (sans information sur l'heure).
        public DateTime DateNaissance { get; set; }

        [Display(Name ="Salaire")]
        [Column(TypeName ="decimal(12,2)")]
        public decimal Salaire { get; set; }

        [Display(Name ="Date Embauche")]
        [DataType (DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd-mm-yyyy}")]
        public DateTime DateEmbauche { get; set; }

        [Required]
        [Display(Name ="National ID")]
        [MaxLength(5)]
        [MinLength(5)]
        [Column(TypeName ="varchar(5)")]
        public string NationalId { get; set; }
        public int DepartementId { get; set; }
        public Departement? Departement { get; set; }
    }
}
