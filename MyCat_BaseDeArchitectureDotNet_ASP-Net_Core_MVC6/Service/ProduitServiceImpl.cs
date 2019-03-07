using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCat_BaseDeArchitectureDotNet_ASP_Net_Core_MVC6.Service
{
     public class ProduitServiceImpl : IProduitService
    {

        public Dictionary<int,Produit> Produits = new Dictionary<int,Produit>();

        public ProduitServiceImpl()
        {
            Save(new Produit { Designation = "HP 564", Prix = 7000 });
            Save(new Produit { Designation = "DELL", Prix = 1300 });
            Save(new Produit { Designation = "ASURE", Prix = 2300 });
            Save(new Produit { Designation = "Imprimante", Prix = 1100 });
            Save(new Produit { Designation = "Sumsung S5", Prix = 9000 });
            Save(new Produit { Designation = "Huawei J4", Prix = 9800 });
            Save(new Produit { Designation = "NOKIA", Prix = 6500 });
            Save(new Produit { Designation = "Sumsung J4", Prix = 7900 });


        }



        public void Delete(int ID)
        {
            Produits.Remove(ID);
        }

        public IEnumerable<Produit> FindAll()
        {
            return Produits.Values;
        }

        public Produit GetOne(int ID)
        {
            Produit p;
            Produits.TryGetValue(ID, out p);
            return p;
            // ou bien tous simplement : return Produits[ID];
        }

        public IEnumerable<Produit> ProduitParMC(string mc)
        {
            return Produits.Values.Where(p => p.Designation.Contains(mc));
           
         }

        public Produit Save(Produit p)
        {
            p.ProduitID = Produits.Count + 1;
            Produits[p.ProduitID] = p;
            return p;
           
        }

        public void Update(Produit p)
        {
            Produits[p.ProduitID] = p;
        }
    }
}
