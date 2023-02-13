
using System.Diagnostics.CodeAnalysis;
/*string[] names = { "rob", "trevor", "jacob", "jason", "zach", "Skyler", "Jake", "Tim", "Lynn", "Jace" };

foreach (string name in names)
{
    Console.WriteLine(name);
}*/
int[] nbrs = {
   754, 233, 509, 792, 700, 596, 833, 658, 998, 742,
   187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
   460, 241, 770, 324, 599, 259, 120, 800, 336, 609,
   690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
   435, 643, 809, 874, 906, 620, 328, 369, 426, 561
};
int lowest = 1000;
int highest = 100;
foreach (var nbr in nbrs)
{
    if (nbr > highest) 
    {
        highest = nbr;
    }
    if (nbr < lowest)
    {
        lowest = nbr;
    }
    Console.WriteLine($"{highest} | {lowest}");
}

/*int sum = 0;
for (int i = 1; i < 50; i++)
{
    if (i % 2 != 0) {
        sum = sum + i;
        Console.WriteLine($"i={i}, sum={sum}");

    }
   
}*/







/*Console.Write("Enter an integer: ");
string? answerString = Console.ReadLine();

int answer = Convert.ToInt32(answerString);

string evenOdd = "";

if(answer % 2 == 0)
{
    evenOdd = "even";
}
else
{
    evenOdd = "odd";
}
Console.WriteLine($"The number {answer} is {evenOdd}");
*/
