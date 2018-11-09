using System.Collections.Generic;

namespace lab2
{
    public class Army
    {
        private List<IWarrior> _army;

        public Army(List<IWarrior> army)
        {
            _army = army;
        }

        public Army()
        {
            _army = new List<IWarrior>();
        }

        public void AddPlatoon(IWarrior platoon)
        {
            _army.Add(platoon);
        }
        public List<string> SayAllSlogans()
        {
            List<string> slogans = new List<string>();
            foreach (var platoon in _army)
            {
                slogans.Add(platoon.SaySlogan());
            }

            return slogans;
        }
    }
}