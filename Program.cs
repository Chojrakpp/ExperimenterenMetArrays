// See https://aka.ms/new-console-template for more information
using System;
using System.Security.Cryptography.X509Certificates;

int[] studentennummers = new int[4];

int tel = studentennummers.Length +1;

studentennummers[0] = 1;
studentennummers[1] = 2;
studentennummers[2] = 3;
studentennummers[3] = 4;



while (studentennummers.Length <= 8)
{
    int max = 8 - studentennummers.Length;
    Console.Write("Je hebt " + studentennummers.Length + " studenten. Je moet nog " + max + " er bij doen. Geef een studentennummer in: ");
    string input = Console.ReadLine();
    int number;
    Int32.TryParse(input, out number);

    Array.Resize<int>(ref studentennummers, tel);
    studentennummers[tel-1] = number;
    tel++;
}

/*
if (y == )
{
        Array.Resize<int>(ref studentennummers, 5);
        string y = Console.ReadLine();
}
*/

for (int i = 0; i < studentennummers.Length; i++)
{
    Console.WriteLine("studentennmr " + i + " = " + studentennummers[i]);
}