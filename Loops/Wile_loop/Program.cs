
Random rnd = new Random();
int cpuRandom;

bool loopActive = true; //bool true or false

while (loopActive)
{
    cpuRandom = rnd.Next(1, 9); //genereerib numbrid vahemikus 1-8

    //Console.WriteLine($"Arvuti geenreritud number on: {cpuRandom}."); //kuvab arvuti genereeritud numbri

    Console.WriteLine("Arva number ära:");

    int userNumber = Int32.Parse(Console.ReadLine());

    if (userNumber == cpuRandom)
    {
        Console.WriteLine("Palu Õnne!!");
        loopActive = false; //lõpetab loopi
        //break :võib ka seda ka kasut kui loop active ei meeldi 
    }
    else
    {
        Console.WriteLine("Proovi uuesti"); 
    }
}
Console.WriteLine("Kena Päeva!");
