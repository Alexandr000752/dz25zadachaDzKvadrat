Console.WriteLine("Ведите число A");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Ведите число B");
int B = int.Parse(Console.ReadLine());

int result = Convert.ToInt32(Math.Pow(A, B));

Console.WriteLine(result);