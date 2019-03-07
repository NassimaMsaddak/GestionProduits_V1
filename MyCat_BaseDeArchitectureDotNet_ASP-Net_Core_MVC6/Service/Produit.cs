using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCat_BaseDeArchitectureDotNet_ASP_Net_Core_MVC6.Service
{
    public class Produit
{
    [Display(Name="Id Produit")]  
    public int ProduitID { get; set; }
    [Required,MinLength(5),MaxLength(20)]
    public string Designation { get; set; }
    [Required,Range(100,5000)]
    public double Prix { get; set; }
}
}
