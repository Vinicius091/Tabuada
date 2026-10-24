int m = 0;
int resultado;


Console.WriteLine("---Tabuada do número: 7---");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

while (m <= 10)
{
    resultado = n * m;
    Console.WriteLine($"{n} x {m} = {resultado}");
    m += 1;
}
