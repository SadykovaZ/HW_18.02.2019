using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HW_18._02._2019
{
    public class Class1
    {
        int x = 1;
        int y = 0;
        public void Method()
        {

            try
            {
                int res = x/ y;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
        public static void Method1()
        {
            Class1 cl = new Class1();
            cl.Method();
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            //1.	Перехватить исключение запроса к несуществующему веб ресурсу и вывести сообщение о том, что произошла ошибка. Программа должна завершиться без ошибок
            WebClient myClient = new WebClient();

            try
            {
                Stream response = myClient.OpenRead("http://www.google.com");
                response.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

                myClient.Dispose();

            }

            //2.	Написать программу, которая обращается к элементам массива по индексу и выходит за его пределы. После обработки исключения вывести в финальном блоке сообщение о завершении обработки массива.
            int[] arr = { 1, 3, 4, 5, 6 };
            try
            {
                arr[6] = 7;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            //3.	Реализовать несколько методов или классов с методами и вызвать один метод из другого. В вызываемом методе сгенерировать исключение и «поднять» его в вызывающий метод.
            //4.	Реализовать несколько методов или классов с методами и вызвать один метод из другого. В вызываемом методе сгенерировать исключение и «поднять» его в вызывающий метод.
            try
            {
                Class1.Method1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }

            
        }
    }
}
