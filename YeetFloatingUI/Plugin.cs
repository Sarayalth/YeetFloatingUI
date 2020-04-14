using IPA;
using IPALogger = IPA.Logging.Logger;
using HarmonyLib;
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
			Harmony harmony = new Harmony("com.Sarayalth.FuckNewUI");
			harmony.PatchAll(System.Reflection.Assembly.GetExecutingAssembly());
		}
		[OnExit]
		public void OnApplicationQuit(){}
	}
}
