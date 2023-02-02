Random rnd = new Random();
int myRandomnumber;
int randomsum = 0;

    for(int i = 0; i < 3; i++)

{
    myRandomnumber = rnd.Next(0, 7);
    randomsum = randomsum + myRandomnumber;
    Console.WriteLine($"My randomnumber is {myRandomnumber}");
    }
Console.WriteLine($"Random sum total {randomsum}");