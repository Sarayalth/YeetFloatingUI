using HarmonyLib;
namespace YeetFloatingUI
{
	[HarmonyPatch(typeof(BeatmapData))]
	[HarmonyPatch("spawnRotationEventsCount", MethodType.Getter)]
	class Yeet
	{
		static void Postfix(ref int __result)
		{
			if (__result > 0)
				__result = 0;
		}
	}
}