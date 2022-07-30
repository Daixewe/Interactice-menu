menu();
void menu()
{
    Console.WriteLine("Welcome");
    Console.WriteLine("Please select an option");
    Console.WriteLine("Addiion: a");
    Console.WriteLine("Subtraction:  b");
    Console.WriteLine("Multiplication:  c");
    Console.WriteLine("Division:  d");
    Console.WriteLine("Exist Menu: e");

    opcion();
}
void opcion ()
{
    string opcion = Console.ReadLine();
    if ( opcion == "a")
    {
    opcionAd();
    }
    if(opcion == "b")
    {
    opSub();
    }
    if (opcion == "c")
    {
        opMult();
    }
    if (opcion == "d"){
        opDivi();
    }
    if (opcion == "e")
    {
        exit();
    }
        
}











void opcionAd()
{
    Console.WriteLine("Please enter first number");
    int firstNub = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Please enter second number");
    int secNub = Int32.Parse(Console.ReadLine());
    int totalAd = firstNub + secNub;
    Console.WriteLine("Total =" + totalAd);
    menu();
}
void opSub()
{
  Console.WriteLine("Please enter first number");
    int firstNub = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Please enter second number");
    int secNub = Int32.Parse(Console.ReadLine());
    int totalAd = firstNub - secNub;
    Console.WriteLine("Total =" + totalAd);
    menu();
}  
void opMult()
{
     Console.WriteLine("Please enter first number");
    int firstNub = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Please enter second number");
    int secNub = Int32.Parse(Console.ReadLine());
    int totalAd = firstNub * secNub;
    Console.WriteLine("Total =" + totalAd);
    menu();
}
void opDivi()
{
      Console.WriteLine("Please enter first number");
    int firstNub = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Please enter second number");
    int secNub = Int32.Parse(Console.ReadLine());
    int totalAd = firstNub / secNub;
    Console.WriteLine("Total =" + totalAd);
    menu();
}    
void exit()
{
    return;
}