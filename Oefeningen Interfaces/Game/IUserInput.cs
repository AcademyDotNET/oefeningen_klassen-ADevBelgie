using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    interface IUserInput
    {
        public ConsoleKey UserInputKey { get; set; }
        public ConsoleKey GetKey();
    }
}
