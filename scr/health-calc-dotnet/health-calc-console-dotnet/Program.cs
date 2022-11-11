using health_calc_dotnet;

Console.WriteLine("Entre com sua altura e peso para calcular seu IMC!");

Console.WriteLine("Altura: ");
var Height = Console.ReadLine();

Console.WriteLine("Peso: ");
var Weight = Console.ReadLine();

IMC objIMC = new IMC();

double Result = objIMC.Calc(double.Parse(Height), double.Parse(Weight));    
string Category =objIMC.GetIMCCategory(Result);

Console.WriteLine("Oresultado do seu IMC foi: " + Category);

Console.ReadKey();  

