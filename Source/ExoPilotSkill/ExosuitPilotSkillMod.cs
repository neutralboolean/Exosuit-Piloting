//ExoPilotSkill
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using RimWorld;
using UnityEngine;
using Verse;

public class ExosuitPilotSkillMod : Mod
{
    public ExosuitPilotSkillMod(ModContentPack content) : base(content)
    {
        Log.Message("ExosuitPilotSkillMod: init innit");
    }

    public override void DoSettingsWindowContents(Rect inRect)
    {
        base.DoSettingsWindowContents(inRect);
    }

    public override bool Equals(object obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string SettingsCategory()
    {
        return base.SettingsCategory();
    }

    public override string ToString()
    {
        return base.ToString();
    }

    public override void WriteSettings()
    {
        base.WriteSettings();
    }
}