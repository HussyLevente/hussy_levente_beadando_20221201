Random rnd = new Random();

string[] ValasztasokTMB = "kő|papír|olló|gyík|speck".Split('|');


int FelhPontjai = 0;
int GepPontjai = 0;

while (FelhPontjai - GepPontjai != 3 || GepPontjai - FelhPontjai != 3)
{
    string GepFelel = ValasztasokTMB[rnd.Next(ValasztasokTMB.Length)];
    Console.Write($"Add meg hogy mit akarsz mutatni: ");
    string FelhMutat = Console.ReadLine();
    Console.WriteLine($"Amit a gép mutatott: {GepFelel}\n");
    if (FelhMutat == GepFelel)
    {
        Console.WriteLine("Döntetlen.\n");
    }
}
