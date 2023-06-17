#region Tapsiriq A

try
{
    Console.Write("Bir score daxil edin: ");
    int score = Convert.ToInt32(Console.ReadLine());

    //a. 88 <= x <= 100 aralığında isə ekrana 'Success - AA'
    if (score >= 88 && score <= 100)
    {
        Console.WriteLine("Success - AA");
    }
    //b. 81 <= x < 88 aralığında isə ekrana 'Success - BA'
    else if (score >= 81 && score < 88)
    {
        Console.WriteLine("Success - BA");
    }
    //c. 74 <= x < 81 aralığında isə ekrana 'Success - BB'
    else if (score >= 74 && score < 81)
    {
        Console.WriteLine("Success - BB");
    }
    //d. 67 <= x < 74 aralığında isə ekrana 'Success - CB'
    else if (score >= 67 && score < 74)
    {
        Console.WriteLine("Success - CB");
    }
    //e. 60 <= x < 67 aralığında isə ekrana 'Success - CC'
    else if (score >= 60 && score < 67)
    {
        Console.WriteLine("Success - CC");
    }
    //f. 0 <= x < 60 aralığında isə ekrana 'Fail - FF'
    else if (score >= 0 && score < 60)
    {
        Console.WriteLine("Fail - FF");
    }
    //g.geri qalan case'lərdə ekrana 'Invalid score'
    else
    {
        Console.WriteLine("Invalid score");
    }
}
catch 
{
    Console.WriteLine("Duzgun score daxil edin! "); ;
}
#endregion.

#region Tapsiriq B
//    string command;
//    Console.WriteLine("Bir command daxil edin: ");
//    command = Console.ReadLine();

//    switch (command)
//    {
//        case "start":
//            // a. 'start' isə ekrana 'Game is starting'
//            Console.WriteLine("Game is starting");
//            break;
//        case "stop":
//            // b. 'stop' isə ekrana 'Game stopped'
//            Console.WriteLine("Game stopped");
//            break;
//        case "wait":
//            // c. 'wait' isə ekrana 'Game paused'
//            Console.WriteLine("Game paused");
//            break;
//        default:
//            // d. digər hallarda isə ekrana 'Command not found'
//            Console.WriteLine("Command not found");
//            break;
//}
#endregion

#region Tapsiriq C

//Console.Write("Deyer daxil edin: ");
//try
//{
//    int value = int.Parse(Console.ReadLine());
//    int sum = 0;
//    int i = 0;
//    while (i <= value)
//    {
//        sum += i;
//        i++;
//    }

//    Console.WriteLine("Cemlenmis eded sayi " + value + " edir, cavab: " + sum);
//}
//catch
//{
//    Console.WriteLine("Duzgun deyer daxil edin!");
//}

#endregion

#region Tapsiriq D

//int i = 1;
//while (i <= 100)
//{
//    if (i % 3 == 0 || i % 5 == 0)
//    {
//        Console.WriteLine(i);
//    }
//    i++;
//}
#endregion