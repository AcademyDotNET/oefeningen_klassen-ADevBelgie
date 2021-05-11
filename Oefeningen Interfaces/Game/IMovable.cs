using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    interface IMovable
    {
        public void MoveUp(SpeelVeld speelveld, GameManager gameManager);
        public void MoveDown(SpeelVeld speelveld, GameManager gameManager);
        public void MoveLeft(SpeelVeld speelveld, GameManager gameManager);
        public void MoveRight(SpeelVeld speelveld, GameManager gameManager);
    }
}
