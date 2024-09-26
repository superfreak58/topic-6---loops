namespace topic_6___loops_tut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min, max, userNum;
            bool done = false;

            Console.WriteLine("Give me a minimum number");
            while (!Int32.TryParse(Console.ReadLine(), out min))
                Console.WriteLine("Thats NOT A GOOD NUMBER");
            Console.WriteLine("good job, give me a maximum number now");

            while (!Int32.TryParse(Console.ReadLine(), out max))
                Console.WriteLine("NO GIVE ME A REAL NUMBER");


            while (!done)

            {

                Console.WriteLine("say a number in that range");
                userNum = Convert.ToInt32(Console.ReadLine());


                if (userNum >= min && userNum <= max)
                {
                    done = true;
                    Console.WriteLine("You Win");
                }

                else
                    Console.WriteLine("Incorrect, try again");
            }
            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            double bankBal, depoNum, withNum;
            
            bankBal = 150;
            done = false;
            Console.WriteLine("Welcome to the Bank Of Blorb ATM what would you like to do?");
            string choice = "";

            while (!done)
            {


                Console.WriteLine();
                Console.WriteLine("1 - Deposit");
                Console.WriteLine("2 - Withdraw");
                Console.WriteLine("...");
                Console.WriteLine("3 - Account Balance");
                Console.WriteLine("4 - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1")
                {

                    Console.WriteLine("You picked Deposit! how much are you depositing");
                    depoNum = Convert.ToInt32(Console.ReadLine());
                    bankBal += depoNum;

                }
                else if (choice == "2")
                {

                    Console.WriteLine("You chose Withdraw! how much are you taking out?");
                    withNum = Convert.ToInt32(Console.ReadLine());
                    bankBal -= withNum;
                }
                else if (choice == "3") 
                {
                    Console.WriteLine("Your current balance is $" + bankBal);
                }
                else if (choice == "4") 
                { 
                Console.WriteLine("Thank you for using BOB!");
                    done = true;    
                }
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();

                }


            }
        }
    }
}


