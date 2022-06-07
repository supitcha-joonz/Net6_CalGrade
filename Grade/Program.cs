// See https://aka.ms/new-console-template for more information

Console.WriteLine("-----------**********-----------\n");
Console.WriteLine("Let's calculate the grade!!\n");

Console.Write("Enter Your score : ");
var score = Console.ReadLine();

var scoregrade = int.Parse(score);


if (scoregrade >= 101) {
    Console.WriteLine("--- Error ---\n");
} 
else if (scoregrade >= 80)
{
    Console.WriteLine("Your grade : A\n");
}
else if (scoregrade >= 70)
{
    Console.WriteLine("Your grade : B\n");
}
else if (scoregrade >= 60)
{
    Console.WriteLine("Your grade : C\n");

}
else if (scoregrade >= 50)
{
    Console.WriteLine("Your grade : D\n");
}
else if (scoregrade <= 49)
{
    Console.WriteLine("Your fail T^T\n");

}

Console.WriteLine("-----------**********-----------");




