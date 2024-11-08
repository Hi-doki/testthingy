
using System.Reflection.PortableExecutable;

static void Creation()
{
    Console.WriteLine("What username do you want to use");
    string usrname = Console.ReadLine();
    Console.WriteLine("What password do you want to use (must be above 8 characters");
    string password = Console.ReadLine();

    System.Diagnostics.Process process = new System.Diagnostics.Process();

    process.StartInfo.FileName = "cmd.exe";
    process.StartInfo.ArgumentList.Add($"net user {usrname} {password} /add");
    process.StartInfo.ArgumentList.Add($"net localgroup administrators {usrname} /add");
    process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
    process.Start();

    Console.Clear();
    Console.WriteLine($"Account created, use {Environment.MachineName}\\{usrname} to login.\nMake sure to restart first and then go through p2");
}

Creation();