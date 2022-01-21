using System.Text.Json;
namespace AtmObj
{
    public class AtmObt
    {
        private List<int> _money = new List<int>();

        private string _filepath = "./Database/ATM.json";

        public void AddMoney()
            {

                int amount;
                bool doneAdding = false;
                while(doneAdding == false)
                {
                    Console.WriteLine("How much would you like to add?");
                    amount = Convert.ToInt32(Console.ReadLine());
                    _money.Add(amount);
                    Console.WriteLine("Are you done adding money?");
                    string? qAnswer = Console.ReadLine();
                    
                    if(qAnswer == "yes" || qAnswer == "Yes")
                    {
                        doneAdding = true;
                    }
                }
                 string moneyString = JsonSerializer.Serialize(_money, new JsonSerializerOptions {WriteIndented = true});// getting List<> ready for saving
                File.WriteAllText(_filepath,moneyString);//saving said list to file
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
}