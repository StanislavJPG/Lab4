namespace Task1
{
    class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine(value);
        }
    }

    class Company : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            base.Print(value);
        }
    }

    class Position : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.Print(value);
        }
    }

    class NamePerson : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            base.Print(value);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Printer name = new NamePerson();
            name.Print("Volodymyr Zelensky");
            Printer company = new Company();
            company.Print("President of Ukraine");
            Printer position = new Position();
            position.Print("Supreme commander");
        }
    }
}