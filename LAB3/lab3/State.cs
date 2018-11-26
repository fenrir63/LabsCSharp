using System;
using System.Collections.Generic;

namespace lab3
{
    public interface IState
    {
        string GetState();
        List<IState> GetNextState();
    }

    public class Created : IState
    {
        public string GetState()
        {
            return "created";
        }

        public List<IState> GetNextState()
        {
            var list = new List<IState>(); 
            list.Add(new Postponed());
            list.Add(new Reviewed());
           
            return list;
        }
    }
    
    public class  Reviewed : IState
    {
        public string GetState()
        {
            return "reviewed";
        }
        public List<IState> GetNextState()
        {
            var list = new List<IState>();
            list.Add(new Postponed());
            list.Add(new Confirmed());
            list.Add(new Rejected());

            return list;
        }
    }
    public class Postponed : IState
    {
        public string GetState()
        {
            return "postponed";
        }
        public List<IState> GetNextState()
        {
            var list = new List<IState>();
            list.Add(new Reviewed());
            list.Add(new Confirmed());
            list.Add(new Rejected());

            return list;
        }
    }
    public class Rejected : IState
    {
        public string GetState()
        {
            return "rejected";
        }
        public List<IState> GetNextState()
        {
            return null;

        }
    }
    public class Confirmed : IState
    {
        public string GetState()
        {
            return "confirmed";
        }
        public List<IState> GetNextState()
        {
            var list = new List<IState>();
            list.Add(new Recalled());
            
            return list;
           
        }
    }
    public class Recalled : IState
    {
        public string GetState()
        {
            return "recalled";
        }
        public List<IState> GetNextState()
        {
            var list = new List<IState>();
            list.Add(new Returned());

            return list;
            
        }
    }
    public class Returned : IState
    {
        public string GetState()
        {
            return "returned";
        }
        public List<IState> GetNextState()
        {
            var list = new List<IState>();
            list.Add(new Recalled());
            
            return list;
        }
    }
}