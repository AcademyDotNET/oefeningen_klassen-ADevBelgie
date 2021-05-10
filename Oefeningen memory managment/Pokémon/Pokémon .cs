using System;
using System.Collections.Generic;
using System.Text;

namespace Pokémon
{
    class Pokémon: IPokémon
    {
        //base stats
        private int _HP_Base;
        private int _Attack_Base;
        private int _Defense_Base;
        private int _SpecialAttack_Base;
        private int _SpecialDefense_Base;
        private int _Speed_Base;

        //Level
        private int _Level = 1;

        //Extra stats prop
        public string Naam { get; set; }
        public string Type { get; set; }
        public int Nummer { get; set; }

        //base stats prop
        public int HP_Base
        {
            get
            {
                return _HP_Base;
            }
            set
            {
                _HP_Base = value;
            }
        }
        public int Attack_Base
        {
            get
            {
                return _Attack_Base;
            }
            set
            {
                _Attack_Base = value;
            }
        }
        public int Defense_Base
        {
            get
            {
                return _Defense_Base;
            }
            set
            {
                _Defense_Base = value;
            }
        }
        public int SpecialAttack_Base
        {
            get
            {
                return _SpecialAttack_Base;
            }
            set
            {
                _SpecialAttack_Base = value;
            }
        }
        public int SpecialDefense_Base
        {
            get
            {
                return _SpecialDefense_Base;
            }
            set
            {
                _SpecialDefense_Base = value;
            }
        }
        public int Speed_Base
        {
            get
            {
                return _Speed_Base;
            }
            set
            {
                _Speed_Base = value;
            }
        }

        //Level prop
        public int Level
        {
            get { return _Level; }
            private set { _Level = value; }
        }

        //Statistieken prop
        public double Average {
            get 
            {
                return (_HP_Base + _Attack_Base + _Defense_Base + _SpecialAttack_Base + _SpecialDefense_Base + _Speed_Base) / 6.0;
            } 
        }
        public double Total
        {
            get
            {
                return _HP_Base + _Attack_Base + _Defense_Base + _SpecialAttack_Base + _SpecialDefense_Base + _Speed_Base;
            }
        }

        //Level-gebaseerde stats
        public int HP_Full
        {
            get
            {
                return (((_HP_Base + 50) * _Level) / 50) + 10;
            }
        }
        public int Attack_Full
        {
            get
            {
                return (((_Attack_Base + 50) * _Level) / 50) + 10;
            }
        }
        public int Defense_Full
        {
            get
            {
                return (((_Defense_Base + 50) * _Level) / 50) + 10;
            }
        }
        public int SpecialAttack_Full
        {
            get
            {
                return (((_SpecialAttack_Base + 50) * _Level) / 50) + 10;
            }
        }
        public int SpecialDefense_Full
        {
            get
            {
                return (((_SpecialDefense_Base + 50) * _Level) / 50) + 10;
            }
        }
        public int Speed_Full
        {
            get
            {
                return (((_Speed_Base + 50) * _Level) / 50) + 10;
            }
        }

        //Level methode
        public void VerhoogLevel()
        {
            Level++;
        }

        //De Pokémontester methode
        public void ShowInfo()
        {
            ILog log = new Log();
            log.WriteLine($"{Naam} (level {_Level})");

            log.WriteLine("Base stats:");
            log.WriteLine($"\t* Health = {HP_Base}");
            log.WriteLine($"\t* Attack = {Attack_Base}");
            log.WriteLine($"\t* Defence = {Defense_Base}");
            log.WriteLine($"\t* SP Attack = {SpecialAttack_Base}");
            log.WriteLine($"\t* SP Defence = {SpecialDefense_Base}");
            log.WriteLine($"\t* Speed = {Speed_Base}");

            log.WriteLine($"\n\t* Average = {Average}");
            log.WriteLine($"\t* Total = {Total}");

            log.WriteLine("Full stats:");
            log.WriteLine($"\t* Health = {HP_Full}");
            log.WriteLine($"\t* Attack = {Attack_Full}");
            log.WriteLine($"\t* Defence = {Defense_Full}");
            log.WriteLine($"\t* SP Attack = {SpecialAttack_Full}");
            log.WriteLine($"\t* SP Defence = {SpecialDefense_Full}");
            log.WriteLine($"\t* Speed = {Speed_Full}");
        }
    }
}
