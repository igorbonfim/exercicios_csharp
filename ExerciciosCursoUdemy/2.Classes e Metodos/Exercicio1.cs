/*

Fazer um Programa para ler os valores da largura e altura de um retângulo. Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal. 
Usar uma classe como mostrado no projeto abaixo:

    Retangulo
-Largura: double
-Altura: double
+ Area(): double
+ Perimetro(): double
+ Diagonal(): double
 
*/
using System.Globalization;

namespace ExerciciosCursoUdemy._2.Classes_e_Metodos
{
    public class Exercicio1
    {        
        public void CalculosTriangulo()
        {
            Retangulo r = new Retangulo(); 

            Console.WriteLine("Entre com a largura e altura do retângulo:");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("ÁREA: " +r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERÍMETRO: " +r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL: " +r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
