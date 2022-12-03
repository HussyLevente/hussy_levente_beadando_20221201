using System.Runtime.InteropServices;

Random rnd = new Random();

string[] ValasztasokTMB = "kő|papír|olló|gyík|speck".Split('|');


int FelhPontjai = 0;
int GepPontjai = 0;


while (FelhPontjai - GepPontjai != 3 && GepPontjai - FelhPontjai != 3)
{
    bool Szerzett = false;
    string GepFelel = ValasztasokTMB[rnd.Next(ValasztasokTMB.Length)];
    Console.Write($"Add meg hogy mit akarsz mutatni: ");
    string FelhMutat = Console.ReadLine();
    Console.WriteLine($"Amit a gép mutatott: {GepFelel}\n");
    if (FelhMutat == GepFelel)
    {
        Console.WriteLine("Döntetlen, senki nem kap pontot.\n");
        Szerzett = true;
    }
    if (FelhMutat == "kő" && GepFelel == "gyík" || FelhMutat == "kő" && GepFelel == "olló")
    {
        Console.WriteLine("A felhasználó szerzett egy pontot!\n");
        FelhPontjai += 1;
        Szerzett = true;
    }

    if (FelhMutat == "papír" && GepFelel == "spock" || FelhMutat == "papír" && GepFelel == "kő")
    {
        Console.WriteLine("A felhasználó szerzett egy pontot!\n");
        FelhPontjai += 1;
        Szerzett = true;
    }

    if (FelhMutat == "olló" && GepFelel == "papír" || FelhMutat == "olló" && GepFelel == "gyík")
    {
        Console.WriteLine("A felhasználó szerzett egy pontot!\n");
        FelhPontjai += 1;
        Szerzett = true;
    }

    if (FelhMutat == "gyík" && GepFelel == "spock" || FelhMutat == "gyík" && GepFelel == "papír")
    {
        Console.WriteLine("A felhasználó szerzett egy pontot!\n");
        FelhPontjai += 1;
        Szerzett = true;
    }

    if (FelhMutat == "spock" && GepFelel == "olló" || FelhMutat == "spock" && GepFelel == "kő")
    {
        Console.WriteLine("A felhasználó szerzett egy pontot!\n");
        FelhPontjai += 1;
        Szerzett = true;
    }

    if (Szerzett != true)
    {
        Console.WriteLine("A gép szerzett egy pontot\n");
        GepPontjai += 1;
    }
}

Console.WriteLine($"Felhasználó pontjai: {FelhPontjai}\nGép pontjai: {GepPontjai}");
if (FelhPontjai > GepPontjai)
{
    Console.WriteLine("A felhasználó nyert! :D");
}
else
{
    Console.WriteLine("A gép nyert! :(");
}