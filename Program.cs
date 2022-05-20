
Random rnd = new();


//egy soros komment

//Console.Write("írd be a neved: ");
//string nev = Console.ReadLine();
//Console.Clear();
//Console.WriteLine($"Szia {nev}!");

Console.CursorVisible = false;

int szelesseg = Console.WindowWidth;
int magassag = Console.WindowHeight;

for (int i = 0; i < 100; i++)
{
    int w = rnd.Next(szelesseg);
    int h = rnd.Next(magassag);

    Console.SetCursorPosition(w, h);
    Console.ForegroundColor = (ConsoleColor)rnd.Next(16);
    Console.WriteLine("Zoli");    
}

Console.ReadKey();