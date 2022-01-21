using menu;
using AtmObj;
namespace Data
{
    public class ATM
    {

        
            
        bool repeat = true;
        public void Atm()
        {
            AtmObt money = new AtmObt();
            while(repeat)
             {
                Console.WriteLine("===ATM Menu===");
                Console.WriteLine("[1] Add money to Account"); // Adds money to account
                Console.WriteLine("[2] View Balance");
                Console.WriteLine("[3] Search Account");
                Console.WriteLine("[4] Get Money");
                Console.WriteLine("[6] Finished");
                string? ans = Console.ReadLine();
                
                //will be changing this to a case statment
                /*
                    switch(ans)
                    {
                        case 1:
                            break

                        defualt:
                            break
                    }
                */
                if(ans == "1")
                {
                    money.AddMoney();
                }

                else if (ans == "2")
                {
                    money.Balance();
                }

                else if(ans == "3")
                {
                    
                    money.SearchMoney();
                }

                else if(ans =="4")
                {
                    money.RemoveMoney();
                }
                else if(ans == "6")
                {
                    repeat = false;
                }
            }
        }
    } 
}