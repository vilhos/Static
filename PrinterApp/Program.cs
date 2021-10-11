using System;


namespace PrinterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer1 = new Printer();
            Printer printer2 = new Printer();
            Console.WriteLine(Printer.Count);
            Printer.label = "Test Print";
            Printer.Print();
            printer1.SetLabel("First Book");
            printer2.SetLabel("Last Book");
            Printer.Print();

            Console.ReadKey();
        }
    }

    class Printer
    {
        private static int count;
        public static string label;
        public Printer()
        {
            count++;
            Console.WriteLine("Ready to print");
        }

        static Printer()
        {
            Console.WriteLine("Printer is connected");  // static constructor is called first and once
        }

        public static int Count => count;

        public static void Print()
        {
            Console.WriteLine(label);
        }

        public void SetLabel(string label)
        {
            Printer.label = label;
            Console.WriteLine(label);
        }
    }
}