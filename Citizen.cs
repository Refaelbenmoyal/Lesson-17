using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Citizen
    {
        public string _name;
        public Citizen[] _cildren;
        public readonly int _fatherID;
        public readonly int _iD;
        public static int _numberOfCurrentCitizens;
        public const int _MAXIMUM_NUMBER_OF_CITIZENS = 45000;

        public Citizen(string name,int fatherID)
        {
            _name = name;
            _fatherID = fatherID;
        }
        public static void PrintNumberOfCurrentCitizens()
        {
            Console.WriteLine(_numberOfCurrentCitizens);
        }

        public void PrintID()
        {
            Console.WriteLine("$ The ID is {iD}");
        }
        public void PrintGapBetweenMyIDAndFather()
        {
            int Gap;
            Gap = _fatherID - _iD;
            Console.WriteLine("$ The Gap is {Gap}");
        }
        public void SetChildren(Citizen[] citizens)
        {
            
        }

    }
}
