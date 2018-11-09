using System.Collections.Generic;
using System.Numerics;

namespace lab2
{
    public class Platoon : IWarrior
    {
        private List<IWarrior> _warriors;

        public Platoon()
        {
            _warriors = new List<IWarrior>();
        }
        public string SaySlogan()
        {
            if (_warriors[0] != null)
            {
               return _warriors[0].SaySlogan();
            }
            else
            {
                return "";
            }
        }

        public void AddWarrior(IWarrior warrior)
        {
            _warriors.Add(warrior);
        }
        
    }
    
    //Паттерн Adapter
    
    public class PlatoonAdapter : IWarrior
    {
        private Platoon _platoon;

        public PlatoonAdapter(Platoon platoon)
        {
            _platoon = platoon;
        }
        public void AddWarrior(IWarrior warrior)
        {
            _platoon.AddWarrior(warrior);
        }

        public string SaySlogan()
        {
            return _platoon.SaySlogan();
        }
    }
    
    
}