using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CollegeProj
{
    public class Tamrin
    {
        public void Zoj()
        {
            Console.WriteLine("Please Insert a number:");
            int b = Convert.ToInt16(Console.ReadLine());
            if (b % 2 == 0)
            {
                Console.WriteLine( b.ToString()+" Zoj Ast");
                Console.WriteLine("Aji "+" Dadash");
            }
            else
            {
                Console.WriteLine("Fard Ast");
            }

        }

        public void Mazrab7()
        {
            Console.WriteLine("Please Insert a number: ");
            int a = Convert.ToInt16(Console.ReadLine());
            if ((a % 7) == 0)
            {
                Console.WriteLine(a.ToString()+" Mazrab 7 Ast ");
            }
            else
            {
                Console.WriteLine("Mazrab 7 nist");
            }

        }
        public void Bakhsh()
        {
            Console.WriteLine("Please insert a number");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please insert a number");
            int b = Convert.ToInt16(Console.ReadLine());
            if ((a % b) == 0)
            {
                string c = a.ToString();
                string g= b.ToString(); 

                Console.WriteLine(c+"&"+g+ " Bakhsh pazir hastand") ;

            }
            else
            {
                Console.WriteLine("Bakhsh pazir nistand");
            }
        }

        public void Mazrab3()
        {
            int b = 1;
            for (int i = 1; i*3 <100; i++) // i*3= 3 , 2*3= 6 3*3=9
            {
                b = i * 3;// b=3 b=6 
                Console.WriteLine(b);    //3 6 
            }
            Console.WriteLine("********************************");
            int a = 0;
            do
            {
                a++;
                int c;
                c = a * 3; // c=3 
               
                Console.WriteLine(c); //3
              
            }
            while (a*3<100); 

            Console.WriteLine("********************************");
            while (a <100)
            {
				a *= 3;
				a++;
                Console.WriteLine(a);
            }
        }

        public void Argham()
        {
            Console.WriteLine("Insert a number:");
            int  a = Convert.ToInt16(Console.ReadLine());
            int count = 0; 
           do
           {
                a = a / 10;
               count= count+1 ; 
				
		   }
           while (a != 0);
			Console.WriteLine(count + "number of digits=");


		}
        public void Fasl()
        {
			Console.WriteLine("Insert a number:");
			int a = Convert.ToInt16(Console.ReadLine());
            if (a ==0 && a < 91)
            {
                Console.WriteLine("Spring");
            }
			if (a == 91 && a < 182)
			{
				Console.WriteLine("Summer");
			}
			if (a == 182 && a < 273)
			{
				Console.WriteLine("Fall");
			}
			if (a == 273 && a < 365)
			{
				Console.WriteLine("Winter");
			}
		}
        public void Moaddel()
        {
			Console.WriteLine("Insert your moaddel:");
			double a = Convert.ToInt16(Console.ReadLine());
			if (a == 10)
			{
				Console.WriteLine("Mashroot");
			}
			if (a == 10 && a < 15)
			{
				Console.WriteLine("Khoob");
			}
			if (a>15)
			{
				Console.WriteLine("Awli");
			}
			
		}
        public void JadvalZarb()
        {
            Console.WriteLine("Insert a number:");
                int number = Convert.ToInt16(Console.ReadLine());

			for (int i = 1; i <= 10; i++)
			{
				Console.WriteLine($"{number} x {i} = {number * i}");
			}
		}
		public void Random()
		{
			// ایجاد یک شی Random
			Random random = new Random();

			// چاپ 5 عدد تصادفی بین 1 تا 100
			for (int i = 0; i < 5; i++)
			{
				int randomNumber = random.Next(1, 101);
				Console.WriteLine(randomNumber);
			}
		}

        //public void Setare()
        //{
        //    for (int i = 1 ;i<=4;i++)
        //    {
                
        //    }  
        //}




	}
}
