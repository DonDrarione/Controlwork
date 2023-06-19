Console.WriteLine("number of elements = ");
int numberofelements = Convert.ToInt32(Console.ReadLine());



var A = new string[numberofelements];
Adder(ref A, numberofelements);
var b = new List<string>();
searcher(A, numberofelements, ref b);
void Adder(ref string[] A, int numberofelements)
{
    for (int i = 0; i < numberofelements; i++)
    {
        A[i] = Console.ReadLine();

    }
}

void searcher(string[] A, int numberofelements, ref List<string> b)
{


    for (int i = 0; i < numberofelements; i++)
    {
        if (A[i].Length <= 3) b.Add(A[i]);
    }
}
Console.WriteLine(string.Join(", ", b));


