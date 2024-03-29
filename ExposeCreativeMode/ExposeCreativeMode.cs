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
using CommonAPI.Systems.ModLocalization;
using crecheng.DSPModSave;
using DysonSphereProgram.Modding.ExposeCreativeMode.UI.Builder;

namespace DysonSphereProgram.Modding.ExposeCreativeMode
{
  [BepInPlugin(PluginInfo.PLUGIN_GUID, PluginInfo.PLUGIN_NAME, PluginInfo.PLUGIN_VERSION)]
  [BepInDependency(CommonAPIPlugin.GUID)]
  [CommonAPISubmoduleDependency(nameof(LocalizationModule), nameof(CustomKeyBindSystem))]
  public class Plugin : BaseUnityPlugin, IModCanSave
  {
    private Harmony _harmony;
    internal static ManualLogSource Log;

    private void Awake()
    {
      Plugin.Log = Logger;
      _harmony = new Harmony(PluginInfo.PLUGIN_GUID);
      CreativeModeConfig.Init(Config);
      _harmony.PatchAll(typeof(InfiniteInventoryPatch));
      _harmony.PatchAll(typeof(InfinitePowerPatch));
      _harmony.PatchAll(typeof(InfiniteReachPatch));
      _harmony.PatchAll(typeof(InstantResearchPatch));
      _harmony.PatchAll(typeof(InstantReplicatePatch));
      _harmony.PatchAll(typeof(UIPatches));
      _harmony.PatchAll(typeof(OrbitalMechanicsOverride));
      CreativeModeLifecyclePatches.ApplyPatch(_harmony);
      _harmony.PatchAll(typeof(VanillaSavePreservationPatch));
      KeyBinds.RegisterKeyBinds();
      Logger.LogInfo("ExposeCreativeMode Awake() called");
    }

    private void OnDestroy()
    {
      Logger.LogInfo("ExposeCreativeMode OnDestroy() called");
      CreativeModeLifecyclePatches.DestroyPatch();
      _harmony?.UnpatchSelf();
      Plugin.Log = null;
    }
    
    public void Export(BinaryWriter w)
    {
      CreativeModeLifecyclePatches.instance.Export(w);
    }
    public void Import(BinaryReader r)
    {
      CreativeModeLifecyclePatches.instance.Import(r);
    }
    public void IntoOtherSave()
    {
      
    }
  }
  
  [HarmonyPatch]
  public static class CreativeModeLifecyclePatches
  {
    internal static CreativeModeController instance;

    public static void ApplyPatch(Harmony harmony)
    {
      harmony.PatchAll(typeof(CreativeModeLifecyclePatches));
      UIBuilderPlugin.Create(PluginInfo.PLUGIN_GUID, UIManager.CreateUIManager);
      var player = GameMain.mainPlayer;
      if (player != null)
        Create(ref player);
    }

    public static void DestroyPatch()
    {
      Free();
      UIManager.DestroyUIManager();
      UIBuilderPlugin.Destroy();
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(Player), nameof(Player.Create))]
    static void Create(ref Player __result)
    {
      if (DSPGame.IsMenuDemo)
        return;
      
      if (instance != null)
        instance.Free();

      instance = new CreativeModeController();
      instance.Init(__result);
      UIManager.Instance?.Init(instance);
    }

    [HarmonyPostfix]
    [HarmonyPatch(typeof(PlayerController), nameof(PlayerController.GameTick))]
    static void GameTick()
    {
      instance?.GameTick();
    }
    
    [HarmonyPostfix]
    [HarmonyPatch(typeof(VFInput), nameof(VFInput.OnUpdate))]
    static void InputUpdate()
    {
      instance?.OnInputUpdate();
    }

    [HarmonyPrefix]
    [HarmonyPatch(typeof(Player), nameof(Player.Free))]
    static void Free()
    {
      if (instance == null)
        return;
      UIManager.Instance?.Free();
      instance.Free();
      instance = null;
    }
  }
  
  [HarmonyPatch(typeof(GameSave), nameof(GameSave.SaveCurrentGame))]
  class VanillaSavePreservationPatch
  {
    [HarmonyPrefix]
    static void Prefix()
    {
      CreativeModeLifecyclePatches.instance?.PreserveVanillaSaveBefore();
    }

    [HarmonyPostfix]
    static void Postfix()
    {
      CreativeModeLifecyclePatches.instance?.PreserveVanillaSaveAfter();
    }
  }
}