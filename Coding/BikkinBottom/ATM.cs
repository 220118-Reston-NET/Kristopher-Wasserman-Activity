using menu;
namespace Data;

    public class ATM
    {

        private List<int> _money = new List<int>();
        int cash = _money;
        bool repeat = true;
        public void Atm()
        {
            // while(repeat == true)
            // {
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
                Visiting menu = new Visiting();
                menu.Main();
            }
            //  repeat = false;
            // }
        }
        //This function is used to Add indxes to the Generic Collection
        public void AddMoney()
            {
                Console.WriteLine("You added $10 Dollars to your account");
                _money.Add(10);
            }
        
        //This function is used to search the Generic Collection
        public void SearchMoney() 
            {
                if(_money == )
            }
        
        // This function is to view what is inside of the Generic Collection type and sum the indexs together 
        public void Balance() 
            {
                
                    Console.WriteLine("===Balance Inqury");
                    foreach(int cash in _money)
                    {
                        
                        Console.WriteLine(cash);    
                    }
                    int sum;
                    sum = _money[0] + _money[1] + _money[2] + _money[3];
                    Console.WriteLine("Total Balance: "+ sum);
                    Console.WriteLine("===End Balance===");
   
            }

        //This function is to remove an entry form a Generic Collection
        public void RemoveMoney() 
            {
                cash = _money;
                Console.WriteLine("You took $10 from your bank account");
                _money.Remove();
            }

    } 