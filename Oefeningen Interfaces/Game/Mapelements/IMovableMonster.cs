using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    interface IMovableMonster
    {
        public void MoveUp(SpeelVeld speelveld);
        public void MoveDown(SpeelVeld speelveld);
        public void MoveLeft(SpeelVeld speelveld);
        public void MoveRight(SpeelVeld speelveld);
    }
}
