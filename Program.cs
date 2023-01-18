using System;
using System.Collections;

class Program
{
    public static void Main(String[] args)
    {
        ArrayList primeList = new ArrayList();
        ArrayList notPrimeList = new ArrayList();

        System.Console.WriteLine("Please enter the 20 numbers.");
        
        for (int i = 0; i < 20; i++)
        {
            int giveNum = int.Parse(Console.ReadLine());
            if(giveNum < 0)
            {
                
                i--;
                System.Console.WriteLine("Please , try again" + i);
                continue;
            }
            bool IsPrime=true;
            for (int j = 2; j < giveNum; j++)
            {
                if(giveNum % j == 0)
                {
                    IsPrime = false;
                }
            }
            if(IsPrime == true && giveNum != 1)
                primeList.Add(giveNum);
            else
                notPrimeList.Add(giveNum);
            
        }

        primeList.Sort();
        notPrimeList.Sort();
        primeList.Reverse();
        notPrimeList.Reverse();
        
        double sumPrime = 0;
        double sumNotPrime = 0;

        System.Console.WriteLine("** Prime List **");
        foreach (int item in primeList)
        {
            sumPrime += item; 
            System.Console.WriteLine(item);
        }

        System.Console.WriteLine("** Not Prime List");
        foreach (int item in notPrimeList)
        {
            sumNotPrime+=item;
            System.Console.WriteLine(item);
        }

        System.Console.WriteLine("Avarage Prime List :" + Convert.ToDouble((sumPrime/20)) );
        System.Console.WriteLine("Avarage Not Prime List :" + Convert.ToDouble((sumNotPrime/20)) );
    }
}