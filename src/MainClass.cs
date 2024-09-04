using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using MelonLoader;
using UnityEngine;
using HarmonyLib;

namespace SuperhotNoTime
{
    public static class BuildInfo
    {
        public const string Name = "Superhot No Time";
        public const string Description = "Mod for setting time to a constant.";
        public const string Author = "Gasterbuzzer";
        public const string Company = null;
        public const string Version = "1.0.0";
        public const string DownloadLink = "https://github.com/Gasterbuzzer/SuperhotNoTime/releases/";
    }
    public class MainClass: MelonMod
    {
    }


    [HarmonyPatch(typeof(TimeControl), "LateUpdate", new Type[] { })]
    public static class PatchTimeConstant
    {

        /// <summary>
        /// Patches timeScale to constant 1.
        /// </summary>
        /// <param name="__originalMethod"> Method which was called (Used to get class type.) </param>
        /// <param name="__instance"> Caller of function. </param>
        private static void Postfix(MethodBase __originalMethod, object __instance)
        {
            Time.timeScale = 0.6f;
        }
    }
}
