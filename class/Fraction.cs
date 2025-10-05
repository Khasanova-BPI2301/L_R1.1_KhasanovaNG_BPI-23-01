using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_R1._1_Khasanova
{
    public class Fraction
    {
        private int numerator;   // числитель
        private int denominator; // знаменатель

        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int Denominator
        {
            get { return denominator; }
            set
            {
                if (value != 0)
                    denominator = value;
            }
        }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        //Функция-метод 1: Выразить значение дроби в процентах
        public double ToPercentage()
        {
            return ((double)Numerator / Denominator) * 100;)
         
        }

        //Функция-метод 2: Найти сумму цифр значения знаменателя

        public int SumOfDenominatorDigits()
        {
            int sum = 0;
            int temp = Math.Abs(Denominator);
        }
        
        
        
                 
        
          
    }

    