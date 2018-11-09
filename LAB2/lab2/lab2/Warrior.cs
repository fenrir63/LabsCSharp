using System;

namespace lab2
/*
 https://proglib.io/p/structural-patterns/
  Разработать структуру организации армии в игре фэнтези. Армия может
состоять из отрядов эльфов, орков, минотавров, кентавров, циклопов,
драконов, гидр, рыцарей. Армия может содержать как отряды, так и
одиночных воинов, отряд может состоять из других отрядов и одиночных
воинов.
 */
{
    public interface IWarrior
    {
        string SaySlogan();
    }
    public class Elf : IWarrior
    {
        public string SaySlogan()
        {
            return "Elf is power!";
        }
    }
    public class Orc : IWarrior
    {
        public string SaySlogan()
        {
            return "Orc is power!";
        }
    }
    public class Minotaur : IWarrior
    {
        public string SaySlogan()
        {
            return "Minotaur is power!";
        }
    }
    public class Centaur: IWarrior
    {
        public string SaySlogan()
        {
            return "Centaur is power!";
        }
    }
    public class Cyclop : IWarrior
    {
        public string SaySlogan()
        {
            return "Cyclop is power!";
        }
    }
    public class Dragon : IWarrior
    {
        public string SaySlogan()
        {
            return "Dragon is power!";
        }
    }
    public class Hydra : IWarrior
    {
        public string SaySlogan()
        {
            return "Hydra is power!";
        }
    }
    public class Knight : IWarrior
    {
        public string SaySlogan()
        {
            return "Knight is power!";
        }
    }

}