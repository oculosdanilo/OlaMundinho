namespace OlaMundinho;

class Program
{
  static void Main(string[] args)
  {
    Console.Write($"você gosta de sorvete?{Environment.NewLine}>>>");
    var morri = Console.ReadLine();
    var data = DateTime.Now;

    Console.WriteLine($"foda-se, hoje é dia {data.Day} do {data.Month} de {data.Year}");
    Console.ReadKey(true);
  }
}
