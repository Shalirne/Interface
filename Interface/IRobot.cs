using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IRobot
    {
        string GetInfo();
        public List<string> GetComponents();

        public string GetRobotType()
        {
            return " am a simple robot.";
        }
    }
}
