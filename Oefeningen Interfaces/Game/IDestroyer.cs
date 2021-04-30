﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    interface IDestroyer
    {
        public void ShootRight(SpeelVeld speelveld);
        public void ShootLeft(SpeelVeld speelveld);
    }
}
