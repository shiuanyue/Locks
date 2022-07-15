﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;

namespace Locks.Options
{
    public class LocksSettings : ModSettings
    {
        public static int childLockAge = 6;
        public static bool prisonerBreakRespectsLock = true;
        public static bool revoltRespectsLocks = true;

        public override void ExposeData()
        {
            Scribe_Values.Look<int>(ref childLockAge, "Locks_childLockAge", 6, true);

            Scribe_Values.Look<bool>(ref prisonerBreakRespectsLock, "Locks_BreakRespectsLocks", true, true);
            Scribe_Values.Look<bool>(ref revoltRespectsLocks, "Locks_RevoltRespectLocks", true, true);
        }
    }
}
