﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concept_Testing
{
    class Monster
    {
        string name = "default";
        int level = GlobalVar.DungeonLevel;
        double damage = GetStats("damage", level);
        double health = GetStats("health", level);

    }
}
