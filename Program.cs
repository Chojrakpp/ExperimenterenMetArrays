// See https://aka.ms/new-console-template for more information
using System;

int[] studentennummers = new int[4];

studentennummers[0] = 1;
studentennummers[1] = 2;
studentennummers[2] = 3;
studentennummers[3] = 4;

if (studentennummers.Length < 5)
{
        Array.Resize<int>(ref studentennummers, 5);
        studentennummers[4] = 5;    
}

for (int i = 0; i < studentennummers.Length; i++)
{
    Console.WriteLine("studentennmr " + i + " = " + studentennummers[i]);
}