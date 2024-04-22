/*
    Fazer um programa para ler o caminho de um arquivo .csv
    contendo os dados de itens vendidos. Cada item possui um
    nome, preço unitário e quantidade, separados por vírgula. Você
    deve gerar um novo arquivo chamado "summary.csv", localizado
    em uma subpasta chamada "out" a partir da pasta original do
    arquivo de origem, contendo apenas o nome e o valor total para
    aquele item (preço unitário multiplicado pela quantidade),
    conforme exemplo. 
*/

using System.Globalization;

namespace ExerciciosCursoUdemy._10.Arquivos;
class ExercicioArquivos
{
    public void ExerciciosArquivoCSV()
    {
        string path = @"C:\temp\arquivo.csv";
        string outputPath = @"C:\temp\out\summary.csv";

        Directory.CreateDirectory(@"C:\temp\out");

        try
        {            
            string[] lines = File.ReadAllLines(path);
		    using (StreamReader sr = File.OpenText(path))
		    {
                foreach (string lineRead in lines)
                {                                                     
                    using (StreamWriter sw = File.AppendText(outputPath))
                    {
                        string line = sr.ReadLine();
                        string[] column = line.Split(';');
                        string name = column[0];
                        double value = double.Parse(column[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(column[2]);
                        sw.WriteLine(column[0] + ";" +(value * quantity).ToString("F2"), CultureInfo.InvariantCulture);
                    }
                }
            }
        }
		catch (IOException e)
		{
			Console.WriteLine("An error ocurred!");	
			Console.WriteLine(e.Message);	
		}
    }
}
