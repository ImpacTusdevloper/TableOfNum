using SupportLib;

//Var define
int num = 101;

SupportLib.ConsoleSupport.Separator();
Console.ForegroundColor = ConsoleColor.Green;

int i = 1;
Console.WriteLine($"This is a table of {num}");
while(i <= 20)
{
    Console.WriteLine(num * i);
    i+=1;
}