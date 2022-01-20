using menu;
namespace Data;

    public class ATM
    {

        private List<int> _money = new List<int>();
            
        bool repeat = true;
        public void Atm()
        {
            while(repeat)
             {
                Console.WriteLine("===ATM Menu===");
                Console.WriteLine("[1] Add money to Account"); // Adds money to account
                Console.WriteLine("[2] View Balance");
                Console.WriteLine("[3] Search Account");
                Console.WriteLine("[4] Get Money");
                Console.WriteLine("[6] Back to Main Game!");
                string? ans = Console.ReadLine();
                
                
                if(ans == "1")
                {
                    AddMoney();
                }

                else if (ans == "2")
                {
                    Balance();
                }

                else if(ans == "3")
                {
                    
                    SearchMoney();
                }

                else if(ans =="4")
                {
                    RemoveMoney();
                }
                else if(ans == "6")
                {
                    repeat = false;
                }
            }
        }
        //This function is used to Add indxes to the Generic Collection
        public void AddMoney()
            {
                int amount;
                Console.WriteLine("How much would you like to add?");
                amount = Convert.ToInt32(Console.ReadLine());
                _money.Add(amount);
                Console.WriteLine("Money Added!");
                Console.ReadLine();
            }
        
        //This function is used to search the Generic Collection
        public void SearchMoney() 
            {
                int amount;
                Console.WriteLine("What are ammount are you looking for?");
                amount = Convert.ToInt32(Console.ReadLine());

                foreach(int i in _money)
                {
                    if( amount == i )
                    {
                        Console.WriteLine(i);
                    }
                    else
                    {
                        Console.WriteLine("You Have nothing in your account!");
                    }
                }
            
            }
        
        // This function is to view what is inside of the Generic Collection type and sum the indexs together 
        public void Balance() 
            {
                
                    Console.WriteLine("===Balance Inqury===");
                    int sum = 0;
                    foreach(int cash in _money)
                    {
                        
                        Console.WriteLine(cash);
                        sum = cash + sum;    
                    }
                    //int sum = _money[0] + _money[1] + _money[2];
                    Console.WriteLine("Total Balance: $"+ sum);
                    Console.WriteLine("===End Balance===");
            
            }

        //This function is to remove an entry form a Generic Collection
        public void RemoveMoney() 
            {
                Console.WriteLine("How much would you like to withdraw?");

                int amount = Convert.ToInt32(Console.ReadLine());
                _money.Remove(amount);
                Console.WriteLine($"You took {amount} from your bank account");
                
            }

    } 