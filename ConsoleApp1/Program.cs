using System;
using ConsoleApp1.Models;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon gun = new Weapon(30, 12, 10, 5);

             int key = 0;
          
            do
            {
                
                Console.WriteLine("Reqem daxil edin : ");
                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("1ci metod");
                        gun.Shoot();
                        break;
                    case 2:
                        Console.WriteLine("2ci metod");
                        gun.Fire();
                        Console.WriteLine($"{"butun gulleler ateshlendi "}" );
                        break;
                    case 3:
                        Console.WriteLine("3cu metod");
                        gun.GetRemainBulletCount();
                        Console.WriteLine("daragin dolmasi uchun lazim olan gulle sayi");
                        break;
                    case 4:
                        Console.WriteLine("4cu metod");
                        gun.Reload();
                        Console.WriteLine("daraq doldu");
                        break;
                    case 5:
                        Console.WriteLine("5ci  metod");
                        gun.ChangeFireMode();
                        Console.WriteLine("atish mode deyishdi");
                        break;
                    case 6:
                        Console.WriteLine("Sagolun");
                        break;
                    case 0:
                        Console.WriteLine("0ci  metod");
                        Console.WriteLine($"{"Daragin tutumu:"} {gun.bulletCapacityOfTheComb}");
                        Console.WriteLine($"{"Daraqdaki gulle sayi:"} {gun.numberOfBulletsIntheComb}");
                        Console.WriteLine($"{"Daragin bosalma saniyesi:"} {gun.secondsOfCombDischarge}");
                        Console.WriteLine($"{"Atis modu:"} {gun.shootingMode}");
                        break;
                    default:
                        Console.WriteLine("Sehv daxil etdiniz");
                        break;
                }
            } while (key != 6);
        }
    }
}
