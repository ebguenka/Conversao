﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicita
            // byte num1 = 100; // 8 bits, de 0 a 255
            // ushort num2; //16 bits, 0 a 65.535

            // float num3 = 1250.45f;
            // double num4 = num3;

            // num3 = num1;
            // num2 = num1;

            // int numero = 'C';
            #endregion Implicita

            #region Explicita
            // ushort num1 = 100;
            // byte num2 = (byte)num1;

            // float num3 = 2500f;
            // int num4 = (int) num3;

            // char letra = (char)97;

            #endregion Explicita

            #region Parse
            //string txtNumero = "1985";

            //int numero = int.Parse(txtNumero);

            //byte num1 = byte.Parse("120");

            //double num2 = double.Parse("125623,45");

            //float num3 = float.Parse("457,75");
            #endregion Parse

            string texto = Convert.ToString(2500);

            double num1 = Convert.ToDouble(false);

            int num2 = Convert.ToInt32('C');
            
            Console.WriteLine(num2);
            Console.ReadKey();


        }
    }
}
