using System;

namespace SwordDamageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var damage = new SwordDamage();
            var random = new Random();

            while (true)
            {
                Console.Write("0 for no magic/flaming, 1 for magic, 2 for flaming, 3 for both, anything else to quit: ");
                var keyPressed = Console.ReadKey(false).KeyChar;                

                if (keyPressed != '0' && keyPressed != '1' && keyPressed != '2' && keyPressed != '3') return;

                for (int i = 0; i < 3; i++)
                {
                    damage.Roll += random.Next(1, 7);
                }

                damage.SetMagic(keyPressed == '1' || keyPressed == '3');
                damage.SetFlaming(keyPressed == '2' || keyPressed == '3');

                Console.WriteLine($"\nRolled {damage.Roll} for {damage.Damage} HP\n");
            }            
        }
    }
}
