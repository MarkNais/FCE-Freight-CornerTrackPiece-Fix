using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace CornerTrackPiece_Fix
{

    public class FreightCornerFix : FortressCraftMod
    {
        public override ModRegistrationData Register()
        {
            ModRegistrationData registrationData = new ModRegistrationData();

            var harmony = HarmonyInstance.Create("MarkNstein.FreightCornerFix");
            HarmonyInstance.DEBUG = true;
            //FileLog.Reset(); //clears output from other mods
            FileLog.Log("MarkNstein.FreightCornerFix registered. Begin Harmony");
            Debug.Log("MarkNstein.FreightCornerFix registered. Begin Harmony");

            try
            {
                harmony.PatchAll();
            }
            catch (Exception e)
            {
                FileLog.Log("Caught exception when running patcher!");
                FileLog.Log(e.Message);
                FileLog.Log(e.StackTrace);
                FileLog.Log(e.ToString());
            }

            return registrationData;
        }

    }
}
