using System;

namespace ConsoleApp15
{
    public class Program
    {
        public static void Main()
        {
            Console.Clear();



            arrow strlk = new arrow();
            Avtor menu = new Avtor();
            string login = "";
            string password = "";
            string newa = "";
            List<char> newpassword = new List<char>();            
            ConsoleKeyInfo parol;
            menu.Verify(login, password);
            int a = strlk.ARROW();
            while (a != 4)
            {
                newpassword.Clear();
                if (a == 2)
                {
                    Console.SetCursorPosition(8, a);
                    login = Convert.ToString(Console.ReadLine());
                }
                else if (a == 3)
                {
                    Console.SetCursorPosition(9, a);
                    ConsoleKeyInfo newkey = Console.ReadKey(true);
                    while (newkey.Key != ConsoleKey.Enter)
                    {
                        Console.Write("*");
                        newpassword.Add(newkey.KeyChar);
                        newkey = Console.ReadKey(true);


                        newa = "";
                        foreach (char s in newpassword)
                        {
                            newa = newa + s;                  
                        }


                    }


                }
                Console.Clear();
                menu.Verify(login, newa);
                a = strlk.ARROW();


            }



            List<Members> dlyaavt = Myconv.MyDeserialize<List<Members>>("Пользователи.json");


            foreach (var item in dlyaavt)
            {
                if (login == item.LOGIN)
                {
                    if (newa == item.PASSWORD)
                    {
                        if (item.ROLE == 1)
                        {
                            Admin f = new Admin();
                            f.Read();
                        }

                    }
                }


            }
            Console.WriteLine("Вы ввели неверные данные");
            Thread.Sleep(1000);
            Main();

        }
    }
}