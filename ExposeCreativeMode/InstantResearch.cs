using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection.Emit;
using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using UnityEngine;
using CommonAPI;
using CommonAPI.Systems;

namespace DysonSphereProgram.Modding.ExposeCreativeMode
{
  public class InstantResearch
  {
    private bool isEnabled;
    public bool IsEnabled
    {
      get => isEnabled;
      set
      {
        if (isEnabled == value)
          return;
        if (value) Enable(); else Disable();
      }
    }

    public bool EnableLocking = true;

    public void Enable()
    {
      isEnabled = true;
      Plugin.Log.LogDebug("Instant Research Enabled");
    }

    public void Disable()
    {
      isEnabled = false;
      Plugin.Log.LogDebug("Instant Research Disabled");
    }

    public void Toggle()
    {
      if (!isEnabled)
        Enable();
      else
        Disable();
    }

    public void GameTick()
    {
      if (!isEnabled)
        return;
      ResearchCurrentTechInstantly();
    }
    
    private static void ResearchCurrentTechInstantly()
    {
      var history = GameMain.history;
      if (history.currentTech > 0)
      {
        var techState = history.TechState(history.currentTech);
        var hashNeeded = techState.hashNeeded - techState.hashUploaded;
        history.AddTechHash(hashNeeded);
      }
    }
  }

  [HarmonyPatch]
  public static class InstantResearchPatch
  {
    private static InstantResearch instantResearch;

    public static void Register(InstantResearch instance)
    {
      instantResearch = instance;
    }

    public static void Unregister(InstantResearch instance)
    {
      if (instantResearch == instance)
        instantResearch = null;
    }
  }
}