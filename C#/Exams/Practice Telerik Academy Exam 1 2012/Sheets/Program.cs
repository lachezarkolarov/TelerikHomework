﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheets
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()); // Броя на пърчетата А10, коите тпябва да пресметнем

            int counter = 0; // Брояч, който изброява всичси свободни листя и техния формат
            int countPow = 0; // Брои степените при търсенето на листа, който побира най много пъти A10
            int sizeNum = 10; // Броя на листата с формати от 0 до 10
            int usedFormats; // Държи номера на използвания формат
            int pieceHolder = 1; // Държи четния броят на парчетата A10*2, които могат да се поберат в най - големия лист
            int piece = N - N % 2; // Изчислява Максималния четен брой на A10 парчетата, който ще се побере във възможно най - голям лист А'x'. N % 2 = 1 когато остава един A10 лист.
            if (N == 1) // Когато входа е 1 -> A10 не правим провелка дали ще останат перче.
            {
                piece = N;
            }

            while (piece != 0)  // Докато има незаети парчета търси къде може да ги набута докато не останат
            {

                while (pieceHolder <= piece) // Търси броя на степентта(най-големия формат) в който ще побере най - много парчета A10
                {

                    pieceHolder *= 2;
                    countPow++;

                }
                usedFormats = sizeNum - (countPow - 1); // Изчисляба степентта (номера) на формата който ще побере определени парчета A10 от най - малкия към най - големия A10,A9,A8...A1,A0
                piece -= pieceHolder / 2; // Максималния броя на парчета А10 побиращи се в най - голечия формат. 
                pieceHolder = 1; // Зануляване
                countPow = 0; // Зануляване


                while (usedFormats > counter) // Тук, понеже търсим номерата на форматите, които НЕЯМА да се използват, а сме намерили тези които ще използваме, казваме че ИЗПОЛЗВАНИЯТ е по-голям(резличен) от номера на незиползваните формати и изписваме всички формати които са по - малки от този номер.
                {                             // Премер: Програмата ни казва че ще използваме A0, затова тя изписва всечки формати след А0 докато те станат по - малки от формата който сме използвали. Така изписва всечки неизползвани формати. На края на програмата counter++ прави usedFormats == counter
                    Console.WriteLine("A" + counter);
                    counter++;

                }

                if (piece == 0 && usedFormats == counter) // Изписва всечки останали формати след последния - най-малък формат.
                {
                    counter++;
                    if (N % 2 == 1)  // В зависимост ако N e нечетен брой парчета А10, останалото свободно парче А10 не се изписва на конзолата, като по този начин го считаме за използвано
                    {
                        sizeNum = 9;
                    }

                    while (sizeNum >= counter)
                    {
                        Console.WriteLine("A" + counter);
                        counter++;

                    }
                }



                counter++; // Брой незиползваните формати из мужде използваните




            }



        }
    }
}