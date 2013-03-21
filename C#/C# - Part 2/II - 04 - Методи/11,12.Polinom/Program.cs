﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
//        x2 + 5 = 1x2 + 0x + 5 
//Extend the program to support also subtraction and multiplication of polynomials.


class Polynomials11and12
{
   
    static void Main()
    {
        //input data
        decimal[] firstP = { 5, -1 };
        Console.Write("First:                 ");
        PrintPolinomial(firstP);

        decimal[] secondP = { 10, -5, 6 };
        Console.Write("Second:                ");
        PrintPolinomial(secondP);

        int maxLenght = 0;
        if (firstP.Length > secondP.Length)
        {
            maxLenght = firstP.Length;
        }
        else
        {
            maxLenght = secondP.Length;
        }

        decimal[] result = new decimal[maxLenght];
        Console.WriteLine();

        //sum the polinomials into result
        SumOfPolinomials(firstP, secondP, result);

        //print the sum
        Console.Write("Sum:                              ");
        PrintPolinomial(result);

        //substract the polinomials into result
        SubstractionOfPolinomials(firstP, secondP, result);

        //print the substraction
        Console.Write("Substraction:                     ");
        PrintPolinomial(result);

        decimal[] multiply = new decimal[firstP.Length + secondP.Length];

        //multiply the polinomials
        MultiplyPolinomials(firstP, secondP, multiply);

        //print multiplication
        Console.Write("Multiplication:                   ");
        PrintPolinomial(multiply);
    }
     
    static void SumOfPolinomials(decimal[] firstPolinomial, decimal[] secondPolinomial, decimal[] result)
    {
        int minLenght = 0;
        int smallerPolinomial = 0;

        if (firstPolinomial.Length > secondPolinomial.Length)
        {
            minLenght = secondPolinomial.Length;
            smallerPolinomial = 2;
        }
        else
        {
            minLenght = firstPolinomial.Length;
            smallerPolinomial = 1;
        }

        for (int i = 0; i < minLenght; i++)
        {
            result[i] = firstPolinomial[i] + secondPolinomial[i];
        }

        for (int i = minLenght; i < result.Length; i++)
        {
            if (smallerPolinomial == 1)
            {
                result[i] = secondPolinomial[i];
            }
            else
            {
                result[i] = firstPolinomial[i];
            }
        }
    }

    //substraction of polinomials
    static void SubstractionOfPolinomials(decimal[] firstPolinomial, decimal[] secondPolinomial, decimal[] result)
    {
        int minLenght = 0;
        int smallerPolinomial = 0;

        if (firstPolinomial.Length > secondPolinomial.Length)
        {
            minLenght = secondPolinomial.Length;
            smallerPolinomial = 2;
        }
        else
        {
            minLenght = firstPolinomial.Length;
            smallerPolinomial = 1;
        }

        for (int i = 0; i < minLenght; i++)
        {
            result[i] = firstPolinomial[i] - secondPolinomial[i];
        }

        for (int i = minLenght; i < result.Length; i++)
        {
            if (smallerPolinomial == 1)
            {
                result[i] = secondPolinomial[i];
            }
            else
            {
                result[i] = firstPolinomial[i];
            }
        }
    }

    //multiplication of polinomials
    static void MultiplyPolinomials(decimal[] firstPolinomial, decimal[] secondPolinomial, decimal[] result)
    {
        //declare zeros at result polinom
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = 0;
        }

        for (int i = 0; i < firstPolinomial.Length; i++)
        {
            for (int j = 0; j < secondPolinomial.Length; j++)
            {
                int position = i + j;
                result[position] += (firstPolinomial[i] * secondPolinomial[j]);
            }
        }
    }

    //print polinomial
    static void PrintPolinomial(decimal[] polinomial)
    {
        for (int i = polinomial.Length - 1; i >= 0; i--)
        {
            if (polinomial[i] != 0 && i != 0)
            {
                if (polinomial[i - 1] >= 0)
                {
                    Console.Write("{1}x^{0} +", i, polinomial[i]);
                }
                else
                {
                    Console.Write("{1}x^{0} ", i, polinomial[i]);
                }
            }
            else if (i == 0)
            {
                Console.Write("{0}", polinomial[i]);
            }
        }

        Console.WriteLine();
    }

}