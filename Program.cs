using System;

struct Books{
    public string Name, Author, Color;
    public int Age;

}
namespace ArrayStruct
{
    class Program
    {
        static void Main(string[] args)  
        {   

         Books[] Array = new Books[3];
            for(int i=0; i<3; i ++){
                Console.WriteLine("Name: ");
            Array[i].Name = Console.ReadLine();

            Console.WriteLine("Author: ");
            Array[i].Author = Console.ReadLine();
            
            Console.WriteLine("Color: ");
            Array[i].Color = Console.ReadLine();

            Console.WriteLine("Age: ");
            Array[i].Age = Int32.Parse(Console.ReadLine());
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Animals: #"+i);
            }    
             for(int k=0; k<3; k ++){
            Console.WriteLine("Name:" + Array[k].Name);
            Console.WriteLine("Clas:" + Array[k].Author);
            Console.WriteLine("Country:" + Array[k].Color);
            Console.WriteLine("Age:" + Array[k].Age+Environment.NewLine);

        Console.WriteLine("Book: #"+k);
    }
    }
    }
}