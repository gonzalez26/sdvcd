using System;
using System.Collections.Generic;

namespace ParcialMeta1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cicle = 0;

            do
            {
                int caseSwitch = 0; 
                Console.WriteLine("Welcome Selecction Your lenguaje/ Bienvenido Seleccione Su Lenguaje");
                Console.WriteLine("Enter 1 for Englis / Digita 2 para Español");
                caseSwitch = Console.ReadLine();
            
                switch (Caseswitch)
                {
                    case 1:
                    Console.WriteLine("Welcome, please enter your personal information.");
                    Console.WriteLine("Complete Name: ");
                    string name = Console.ReadLine();
                    int DUI;
                    do
                    {
                        DUI = validateDUI("Write your DUI number: ");

                    } while (DUI < 1);

                    int NIT;
                    do
                    {
                    NIT = validateNIT("Write your NIT number: ");

                    } while (NIT < 1);

                    int birthDate;
                    do
                    {
                        bithDate = validateBirth("Write your bith date (231100(23 nov 2000)): ");

                    } while (birthDate < 1);

                    Console.WriteLine("Your mail Adrees: ");
                    string mail = Console.WriteLine();

                    Console.WriteLine("Your phone Numer is");

                    phoneNumber = createPhoneNumber(string[] phoneNumber1)

                    Console.WriteLine("Your password Numer is");

                    password = generatorPassword(int zise);


                
                
                    break;



                    case 2:
                    Console.WriteLine("Bienvenido Porfavor ingresa tu informacion Personal.");
                    Console.WriteLine("Nombre completo ");
                    string name = Console.ReadLine();
                    int DUI;
                    do
                    {
                        DUI = validateDUI("Escribe tu numero de dui ");

                    } while (DUI < 1);

                    int NIT;
                    do
                    {
                        NIT = validateNIT("Escribe tu numero de nit: ");

                    } while (NIT < 1);

                    int birthDate;
                    do
                    {
                        birthDate = validateBirth("Escribe tu fecha de Nacimiento (231100(23 nov 2000)): ");

                    } while (birthDate < 1);

                    Console.WriteLine("Correo Electronico: ");
                    string mail = Console.ReadLine();

                    Console.WriteLine("Su Numero de telefono es: ");

                    phoneNumber = createPhoneNumber(string[] phoneNumber1)

                    Console.WriteLine("Su Contraseña es: ");

                    password = generatorPassword(int zise)


                    break;








                    default:
                    Console.WriteLine("Error invalid option");
                    break;
            
                    cicle = 1;
                }while (cicle == 1);


                int cicle2 =0;

                do
                {
                    Console.WriteLine("Whats your Divice");
                    Console.WriteLine("1. Legacy/old phone             2. Smartphone Android          3.Smartphone IOS  ");
                    int caseSwitch2 = int32.Parse(Console.ReadLine);
                    int divices = 0;

                    switch (caseSwitch2)
                    {
                        case 1: 
                        Console.WriteLine("You Have a old phone ");
                        divices = divices + 1;

                        break;
                        


                        case 2:
                        Console.WriteLine("You Have a smartphone Android ");
                        divices = divices + 1;
                        console.WriteLine("Please write The specificston of the divice");
                       

                        console.WriteLine("Whats is the proveer divice: ");
                        string[] proveer = new string[10];
                        for (int i = 0; i < 10; i++)
                        {
                            Console.Write("Proveer {0}: ", i);
                            proveer[i] = Console.ReadLine();
                        }

                        console.WriteLine("Whats the model of the divice: ");
                        string[] model = new string[10];
                        for (int j = 0; j < 10; j++)
                        {
                            Console.Write("Model Name {0}: ", j);
                            proveer[j] = Console.ReadLine();
                        }

                        console.WriteLine("Whats Operative System have your divice: ");
                        string[] operativeSystem = new string[10];
                        for (int i = 0; k < 10; k++)
                        {
                            Console.Write("Nombre {0}: ", k);
                            OperativeSystem[k] = Console.ReadLine();
                        }

                        Console.WriteLine("Thak for finalize your Register");
                        Console.WriteLine("To finilize your registration we give you 50mb and 1 dollar of balance");
                        int megaByte = 50;
                        double balance = 1.00;

                        console.WriteLine("Que accion Desea realizar? ");
                        int switchCase2 = int32.parse(Console.ReadLine);
                        

 

                        break;
                        
                        case 3:
                        Console.WriteLine("You Have a Smartphone IOS ");
                        divices = divices + 1;
 

                        break;


                        
                        default:
                    }





                    
                    cicle2 = 1;  
                } while (cicle2 == 1);
                
            }
        
        }
    }
}
