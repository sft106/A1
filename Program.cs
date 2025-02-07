namespace DIKUCanteen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create canteen with default 100 cups
            Canteen myCanteen = new Canteen("DIKU Cafeteria"); // 100 cups by default

            // Add student and board members
            Student student1 = new Student("Mads", "Student", 20);
            CanteenBoardMember boardMember1 = new CanteenBoardMember("Daniel", "Board Member", 40);

            // Student takes 1 cup
            student1.TakeCup(myCanteen);
            Console.WriteLine($"Canteen Cups: {myCanteen.Cups}, Mads HasCup: {student1.HasCup}");

            // Board Member buys a cup
            boardMember1.BuyCup(myCanteen);
            Console.WriteLine($"Canteen Cups: {myCanteen.Cups}, Budget Left: {CanteenBoardMember.CupBudget}");
        }
    }
}
