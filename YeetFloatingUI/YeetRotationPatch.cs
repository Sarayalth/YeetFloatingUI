using HarmonyLib;
using UnityEngine.SceneManagement;
namespace YeetFloatingUI
{
	[HarmonyPatch(typeof(BeatmapData))]
	[HarmonyPatch("spawnRotationEventsCount", MethodType.Getter)]
	class Yeet
	{
		static void Postfix(ref int __result)
		{
			string scene = SceneManager.GetActiveScene().name;
			if (scene == "GameCore" && !Plugin.Is360() && __result > 0)
				__result = 0;
		}
	}
}