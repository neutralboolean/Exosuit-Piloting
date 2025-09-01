using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoPilotSkill
{
    [DefOf]
    public static class PilotingDefOf
    {
        public static SkillDef EPS_Pilot;
        static PilotingDefOf() => DefOfHelper.EnsureInitializedInCtor(typeof(PilotingDefOf));
    }
}
