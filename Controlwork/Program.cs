Console.WriteLine("number of elements = ");
int numberofelements = Convert.ToInt32(Console.ReadLine());



var A = new string[numberofelements];



for (int i = 0; i < numberofelements; i++)
{
    A[i] = Console.ReadLine();

}
var b = new List<string>(); 
for (int i = 0; i < numberofelements; i++)
{
if (A[i].Length <= 3) b.Add(A[i]);
}
Console.WriteLine(string.Join(", ", b));