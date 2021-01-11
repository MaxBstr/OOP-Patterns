using System;
using System.Collections.Generic;

namespace Patterns._2._Structural._3._Composite
{
    public class Team
    {
        private List<_2._Bridge.IDeveloper> _developers = new List<_2._Bridge.IDeveloper>();

        public void AddDeveloper(_2._Bridge.IDeveloper dev)
        {
            _developers.Add(dev);
        }
        
        public void RemoveDeveloper(_2._Bridge.IDeveloper dev)
        {
            _developers.Remove(dev);
        }

        public void CreateProject()
        {
            Console.WriteLine("Starting project...");
            foreach (var dev in _developers)
            {
                dev.writeCode();
            }
        }
    }
}