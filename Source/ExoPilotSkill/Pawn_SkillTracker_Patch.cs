//ExoPilotSkill
using HarmonyLib;
using RimWorld;
using System;
using System.Collections.Generic;
using Verse;

namespace ExoPilotSkill
{
    [HarmonyPatch(typeof(Pawn_SkillTracker), nameof(Pawn_SkillTracker.Learn))]
    public class Pawn_SkillTracker_Patch
    {

        public static void Postfix(Pawn_SkillTracker __instance, Pawn ___pawn, SkillDef sDef, float xp, bool direct, bool ignoreLearnRate)
        {
            Log.Warning("We in this bitch.");
            var fractionalXp = 0.0f;
            var relevantSkill = false;

            SkillDef _construction = SkillDefOf.Construction;
            _construction.ResolveReferences();
            SkillDef _crafting = SkillDefOf.Crafting;
            _crafting.ResolveReferences();
            SkillDef _plants = SkillDefOf.Plants;
            _plants.ResolveReferences();
            SkillDef _melee = SkillDefOf.Melee;
            _melee.ResolveReferences();
            SkillDef _shooting = SkillDefOf.Shooting;
            _shooting.ResolveReferences();

            if (ReferenceEquals(sDef,_construction)) { 
                fractionalXp = xp * 4f;
                relevantSkill = true;
            }
            else if (ReferenceEquals(sDef,_crafting)) { 
                fractionalXp = xp * 4f;
                relevantSkill = true;
            }
            else if (ReferenceEquals(sDef,_plants)) { 
                fractionalXp = xp * 4f;
                relevantSkill = true;
            }
            else if (ReferenceEquals(sDef,_melee)) { 
                fractionalXp = xp * 18f;
                relevantSkill = true;
            }
            else if (ReferenceEquals(sDef,_shooting)) { 
                fractionalXp = xp * 18f;
                relevantSkill = true;
            }

            Log.Message(String.Format("EPS: Dumped {0} XP", fractionalXp));
            Log.Message(String.Format("XP share from {0}", sDef.label));

            if (Exosuit.MechUtility.HasCore(___pawn) && relevantSkill) {
                __instance.Learn(PilotingDefOf.EPS_Pilot, Math.Max(fractionalXp, 1.0f), direct, ignoreLearnRate);
            }
            
        }
    }
}
