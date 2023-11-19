using Microsoft.VisualBasic;
using System;

namespace Week2Day1
{
    internal class Program
    {
        static void Main()
        {
            //-----------------------------------------
            //Type of casting:
            //a) Implictit
            //b) Explicit
            #region implicit and explicit and boxing
            // when change  between value type to itself
            Console.WriteLine("-----------------Type of casting:----------------");

            /////a)implicit type Casting :
            Console.WriteLine("a) implicit type Casting: ");
            int x1 = 100000000 ; //int maximum Value is smaller Than Long 
             long y1 = x1; //Long is bigger than int so it Can hold it 

            //implicit for double 
             float f = 3.14159f; // Implicit cast from double to float
             double d = f; // Implicit cast from float to double
             decimal dec = 123.456m; // Implicit cast from double to decimal

            //-----------------

            /////b) Explicit type Casting :
            Console.WriteLine("b) Explicit type Casting: ");
            double dd = 3.14159;
             int ia = (int)dd; // Explicit cast from double to int



            //-----------------------------------------------------------------------
            //-----------------------------------------
            Console.WriteLine(" Boxing and unBoxing (ValueType to RefrenceType:");
            // Boxing and unBoxing (ValueType ==> to RefrenceType )
            int x = 10;
                        //string is array of char [h,e,l,l,o]
                        string s = x.ToString();

                        Console.WriteLine(s[1]);

                        //---------------------
                        //form bool to string:
                        bool b = false;

                        string sb = b.ToString();

                        Console.WriteLine(sb);

            #endregion

            //---------------------------------

            Console.WriteLine("from RefrenceType ==> to ValueType :");
            //from RefrenceType ==> to ValueType

            //a) Parse :
            Console.WriteLine("a) Parse:");
            Console.WriteLine("string to int :");
            string value1 = "9999";
            int xa = int.Parse(value1);
            int y = Convert.ToInt32(value1);
            dynamic result =  (int.TryParse(value1, out int z) ) ? z : "error"  ;


            //b) int.TryParse() :
            Console.WriteLine("b) int.TryParse():");
            string input1 = "123";
            int number1;

            if (int.TryParse(input1, out number1))
            {
                Console.WriteLine("Conversion successful. Number: {0}", number1);
            }
            else
            {
                Console.WriteLine("Conversion failed.");
            }

           


            //c) Convert method:
            Console.WriteLine("c) Convert method:");
             bool bb = false;

                        string ssb = bb.ToString();

                        bool revFlag = Convert.ToBoolean(ssb);
                        Console.WriteLine(revFlag);

            //-------------------------------------------
            string value = "999a";
            int y;
            bool res = int.TryParse(value, out y);
            string resl = int.TryParse(value, out y) ? $"Succed" : "invalud";

            if (res)
                Console.WriteLine(resl);
            else
                Console.WriteLine( "invalid conversion Type");

            //self code
            Console.WriteLine(y);
            Console.WriteLine(resl);

            //------------------------------------------------

            //null collasing:
            Console.WriteLine("----null collasing----");
            string name = "ahamed";
            name = name ?? "yousef";
            Console.WriteLine("null collasing : "+name);

            string name2 = null;
            name2 = name2 ?? "yousef";
            Console.WriteLine("null collasing : "+name2);

            //null operater:
            Console.WriteLine("----null operater----");
            string name3 = "YOUSEF";
            Console.WriteLine(name3?.ToLower());

            //null operater and collasing:
            Console.WriteLine("----null operater and collasing----");
            string name4 = "YOUSEF" ;
            Console.WriteLine(name4?.ToLower() ?? "NA");

            Console.WriteLine("---");
            string name5 = null;
            Console.WriteLine(name5?.ToLower() ?? "NA");




            //-----------------------------------------------------------------------
            //-----------------------------------------------------------------------
            // Type of loop:
            Console.WriteLine("---------------------------Type of loop:-------");

            //a)for loop:
            int[] arr1 = { 1, 2, 3, 4 };
            Console.WriteLine("------For loop:-------");
            for (int i =0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            //---------------------------
            //b) while loop:
            Console.WriteLine("------While loop:-------");
            int wi = 0;
            while (wi < arr1.Length)
            {
                Console.WriteLine(arr1[wi]);
                wi++;
            }

            //-----------------------------
            //c)do-while:
            Console.WriteLine("------Do-while loop:-------");
            while (1==2)
            {
                Console.WriteLine(arr1[0]);
            }
           do {
                Console.WriteLine("Hi from Do-while ");
                
            }while (11==2);

            //-----------------------------
            //d) foreach loop:
            Console.WriteLine("------foreach loop:-------");
            foreach (int num in arr1)
            {
                Console.WriteLine(num);
            }
        }
    }
}