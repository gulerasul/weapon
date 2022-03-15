using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Models
{
    class Weapon
    {
        public int bulletCapacityOfTheComb; //Darağın güllə tutumu
        public int numberOfBulletsIntheComb; //Daraqdakı güllələrin sayı
        public int secondsOfCombDischarge; //Boşalma saniyələri,
        public int shootingMode; // atış modu

        public Weapon(int bulletCapacityOfTheComb, int numberOfBulletsIntheComb, int secondsOfCombDischarge, int shootingMode)
        {
            this.bulletCapacityOfTheComb = bulletCapacityOfTheComb;
            this.numberOfBulletsIntheComb = numberOfBulletsIntheComb;
            this.secondsOfCombDischarge = secondsOfCombDischarge;
            this.shootingMode = shootingMode;

        }
        public void Shoot()
        {
           
            if (bulletCapacityOfTheComb>0 && numberOfBulletsIntheComb>0)
            {
                numberOfBulletsIntheComb = numberOfBulletsIntheComb - 1;


                Console.WriteLine($"{"pew ,atesh achildi gulle sayi"} { numberOfBulletsIntheComb}");
            }
           
             
        }
        public void Fire()
        {
            int endSeconds =  (numberOfBulletsIntheComb * secondsOfCombDischarge) / bulletCapacityOfTheComb;

            Console.WriteLine(endSeconds);
        }
        public void GetRemainBulletCount()
        {
            int bulletNeededCount = bulletCapacityOfTheComb - numberOfBulletsIntheComb;

            Console.WriteLine(bulletNeededCount);
        }
        public void Reload()
        {
            numberOfBulletsIntheComb = bulletCapacityOfTheComb;
        }
        public void ChangeFireMode()
        {
            if (shootingMode == 1)
            {
                shootingMode = 2;
                Console.WriteLine("avtomatikdir");
            }
            else if (shootingMode == 2)
            {
                shootingMode = 1;
                Console.WriteLine("teklidir");
            }
        }
            
    }
    

}
