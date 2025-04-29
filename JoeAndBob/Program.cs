namespace JoeAndBob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guy joe = new Guy() { Cash = 50, Name = "Joe" };
            Guy bob = new Guy() { Cash = 100, Name = "Bob" };

            while (true)
            {
                joe.WriteMyInfo();
                bob.WriteMyInfo();

                Console.Write("Enter an amount: ");
                string? howMuch = Console.ReadLine();
                if (howMuch == "") return;
                if(int.TryParse(howMuch, out int amount))
                {
                    Console.Write("Who should give the cash: ");
                    string? whichGuy = Console.ReadLine();
                    if(whichGuy == "Joe")
                    {
                        int result = joe.GiveCash(amount);
                        bob.ReceiveCash(result);

                    } else if(whichGuy == "Bob")
                    {
                        int result = bob.GiveCash(amount);
                        bob.ReceiveCash(result);
                    }
                    else
                    {
                        Console.WriteLine("Please enter 'Joe' or 'Bob");
                    }

                }
                else
                {
                    Console.WriteLine("Please enter an amount (or a blank line to exit).");
                }
            }
        }
    }
}
