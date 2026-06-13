using System;
using System.Formats.Asn1;

class c1
{
    private static void Start(char[] args)
    {
        var local_system = new func();
        local_system.Start();
    }
}


class c2 : c1
{
    static void Main()
    {
        var new_fs = new func();
        new_fs.Start();

        char[] localData = { 'a', 'b', 'c', };
        localData[1] = 'b'; // Fair point self test(FOST)

        Console.WriteLine("The system hadded a error to load the FOST, by default, this message should come, because the system is trying to find the path, which is very normal, LocalData[1]:" + localData[1]);
    }

    int Start()
    {
        var callsystem;

    }
}

class c3 : c2
{

}