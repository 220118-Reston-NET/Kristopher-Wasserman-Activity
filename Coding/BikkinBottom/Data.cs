using Sandy;
using Data;
namespace menu
{

    public class Visiting
    {   
        ATM atmMenu = new ATM();
        public void Main()
        {
           string again;


            Console.WriteLine("Hello");
            Console.WriteLine("My name is Eugne Krabs");
            Console.WriteLine("What is yee name?");
            string ? name = Console.ReadLine();
            Console.WriteLine($"{name}, Welcome to Bikkin Bottom");
            

            string repeat = "true";
            do
            {
                Console.WriteLine("What would yee like to do while in Bikkin Bottom?");
                Console.WriteLine("[1] Go see Sandy at her Tree Dome.");
                Console.WriteLine("[2] Throw eggs at Squidward's house");
                Console.WriteLine("[3] Visit Spongbob");
                Console.WriteLine("[4] Talk to Patrick(not like he will understand)");
                Console.WriteLine("[5] Hangout at the Krusty Karbs");
                Console.WriteLine("[6] Visit the atm");
                Console.WriteLine("[7] See Balance");
                Console.WriteLine("[6] All done visiting Bikkin Bottom");
                string? ans = Console.ReadLine();
               
                if(ans == "1")
                {
                    Console.WriteLine("You went to see Sandy at her home. She was happy to see you");
                    Console.WriteLine("Choose Again!");
                    again = Console.ReadLine();

                }
                else if(ans == "2")
                {
                    Console.WriteLine("You did not see Squidward home and starting throwing eggs at his house before running away");
                    Console.WriteLine("Choose Again!");
                    again  = Console.ReadLine();
                }
                else if(ans == "3")
                {
                    Console.WriteLine("You passed SpongBob on his way to work, too bad");
                    Console.WriteLine("Choose Again!");
                    again  = Console.ReadLine();
                }
                
                else if(ans == "4")
                {
                    Console.WriteLine("You and Patrick started to talk but it was mostly about a kraby patty(he must be hunrgy!)");
                    Console.WriteLine("Choose Again!");
                    again  = Console.ReadLine();
                }

                else if(ans == "5")
                {
                    Console.WriteLine("You got hungry so you stopped by the Krusty Krabs. When you got you decided to eat lunch with Mr.Krabs and you two talked for a while");
                    Console.WriteLine("Choose Again!");
                    again  = Console.ReadLine();
                }
                else if(ans == "6")
                {
                    atmMenu.Atm();
                }
                else if(ans == "7")
                {
                    Console.WriteLine($"Do you have to leave so soon, Owell {name} come back soon and Thank you for visiting Bikkin Bottom!");
                    repeat = "false";
                    again  = Console.ReadLine();
                }
            }while(repeat == "true"); 
        }
        public void MoneyAdd()
        {

        }
        public void MoneySearch()
        {

        }
    }
}