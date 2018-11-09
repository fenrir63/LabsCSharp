using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            var army = new Army();
            var platoon = new Platoon();
            var elfPlatoon = new PlatoonAdapter(new Platoon());
            
            elfPlatoon.AddWarrior(new Elf());
            elfPlatoon.AddWarrior(new Elf());
            platoon.AddWarrior(new Elf());
            platoon.AddWarrior(elfPlatoon);
            
            army.AddPlatoon(platoon);
            
            army.AddPlatoon(new Orc());
            
            army.AddPlatoon(new Hydra());
            
            army.AddPlatoon(new Cyclop());
            
            army.AddPlatoon(new Knight());

            foreach (var slogan in army.SayAllSlogans())
            {
                Console.WriteLine(slogan);
            }
            
            
        }
    }
}