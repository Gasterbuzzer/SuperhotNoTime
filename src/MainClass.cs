using MelonLoader;
using UnityEngine;
using HarmonyLib;

namespace SuperhotNoTime
{
    public class MainClass : MelonMod
    {
    }

    [HarmonyPatch(typeof(TimeControl), "LateUpdate")]
    public static class PatchTimeConstant
    {
        /// <summary>
        /// Changes the timescale to always be 0.6f.
        /// Setting it to 1 makes it impossible and too fast.
        /// </summary>
        // ReSharper disable once UnusedMember.Local
        private static void Postfix()
        {
            Time.timeScale = 0.6f;
        }
    }
}