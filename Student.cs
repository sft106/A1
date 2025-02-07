namespace DIKUCanteen;

public class Student : Person  
{
    // Felter
    public bool HasCup = false;  
//Students information
    public Student(string name, string occupation, int age) : base(name, occupation, age)
    {
    }
//has a cup
    public void TakeCup(Canteen canteen)
    {
        if (!HasCup && canteen.Cups > 0)  
        {
            canteen.Cups--;  
            HasCup = true;  
        }
    }

    public void ReturnCup(Canteen canteen)
    {
        if (HasCup)  
        {
            canteen.Cups++;  
            HasCup = false;  
        }
    }
}
