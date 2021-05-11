using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    interface IUserOutput
    {
        public ConsoleColor ForegroundColor { get; set; }
        public void WriteLine(string toWrite = "");
        public void Write(string toWrite = "");
        public void SetCursorPosition(int left, int top);
        public void Clear();
        public void WriteSpeelveld(SpeelVeld speelVeld, Settings gameSettings);
        public void ClearSpeelveld(SpeelVeld speelVeld);
    }
}
