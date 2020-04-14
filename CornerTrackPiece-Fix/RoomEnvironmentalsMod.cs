using UnityEngine;  //Needed for most Unity Enginer manipulations: Vectors, GameObjects, Audio, etc.
using System.IO;    //For data read/write methods
using System;    //For data read/write methods
using System.Collections.Generic;   //Working with Lists and Collections
using System.Linq;   //More advanced manipulation of lists/collections
using Harmony;
using ReikaKalseki;

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

		try {
			harmony.PatchAll();
		}
		catch (Exception e) {
			FileLog.Log("Caught exception when running patcher!");
			FileLog.Log(e.Message);
			FileLog.Log(e.StackTrace);
			FileLog.Log(e.ToString());
		}
		
		return registrationData;
	}

}