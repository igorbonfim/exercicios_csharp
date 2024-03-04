using System.Globalization;

namespace ExerciciosCursoUdemy._8.Herança_e_Polimorfismo.Entities;
class UsedProduct : Product
{
    public DateTime ManufacturedDate { get; set; }

    public UsedProduct()
    {
    } 
    
    public UsedProduct(string name, double price, DateTime manufacturedDate) : base(name, price)
    {
        ManufacturedDate = manufacturedDate;
    }

    public override string PriceTag()
    {
        return  Name + 
                " (Used) $ " + 
                Price.ToString("F2", CultureInfo.InvariantCulture) + 
                " (Manufactured Date: " + 
                ManufacturedDate.ToString("dd/MM/yyyy") + ")";
    }
}
