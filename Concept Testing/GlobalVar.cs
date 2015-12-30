using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concept_Testing
{
   static class GlobalVar
    {
        static int _dungeonLevel;

        public static int DungeonLevel
        {
            get
            {
                return _dungeonLevel;
            }
            set
            {
                _dungeonLevel = value;
            }
        }
    }
}
