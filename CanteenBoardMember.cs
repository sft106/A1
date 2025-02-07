namespace DIKUCanteen;

public class CanteenBoardMember : Student  
{
    
    public static int CupBudget = 100; 

    public CanteenBoardMember(string name, string occupation, int age) 
        : base(name, occupation, age)  
    {
    }

    public void BuyCup(Canteen canteen)
    {
        if (CupBudget > 0 && canteen.Cups > 0)  
        {
            canteen.Cups++;  
            CupBudget--;     
            Console.WriteLine($"{Name} has bought a new cup. Remaining budget: {CupBudget}");
        }
        else
        {
            Console.WriteLine($"{Name} cannot buy a cup. Not enough budget or no cups left.");
        }
    }
}
