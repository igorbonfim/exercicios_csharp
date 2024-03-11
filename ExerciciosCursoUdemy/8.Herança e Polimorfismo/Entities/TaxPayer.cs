namespace ExerciciosCursoUdemy._8.Herança_e_Polimorfismo.Entities;
abstract class TaxPayer
{
    public string Name { get; set; }
    public double AnualIncome { get; set; }    

    public TaxPayer(string name, double anualIncome)
    {
        Name = name;
        AnualIncome = anualIncome;
    }

    public abstract double Tax();
}
