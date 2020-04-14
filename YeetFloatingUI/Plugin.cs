using IPA;
using IPALogger = IPA.Logging.Logger;
using HarmonyLib;
using BS_Utils.Gameplay;
namespace YeetFloatingUI
{
	[Plugin(RuntimeOptions.SingleStartInit)]
	public class Plugin
	{
		internal static Plugin instance { get; private set; }
		internal static string Name => "YeetFloatingUI";
		internal static IPALogger log { get; set; }
		[Init]
		public void Init(IPALogger logger)
		{
			instance = this;
			log = logger;
		}
		[OnStart]
		public void OnApplicationStart()
		{
			log.Info("YEETING THAT UGLY THING.");
			Harmony harmony = new Harmony("com.Sarayalth.YeetFloatingUI");
			harmony.PatchAll(System.Reflection.Assembly.GetExecutingAssembly());
		}
		public static bool Is360()
		{
			if (Gamemode.SelectedCharacteristic.serializedName == "360Degree" || Gamemode.SelectedCharacteristic.serializedName == "90Degree")
				return true;
			else
				return false;
		}
		[OnExit]
		public void OnApplicationQuit(){}
	}
}
