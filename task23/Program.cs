Console.WriteLine("Introduce un numero: ");
int number =int.Parse(Console.ReadLine());
//int i = 1;

//while (i <= number)
//{
  // Console.WriteLine($"{i*i*i}");
   //i++;
//}
for (int i = 1; i <= number; i++)
{
    Console.WriteLine(Math.Pow(i, 3));
}
