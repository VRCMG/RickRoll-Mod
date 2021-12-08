using System.Diagnostics;
using MelonLoader;

namespace rickfunny
{
    public class Class : MelonMod
    {
        // Original troll mod was by Boppr#0001 but he said I could make my own
        public override void OnApplicationStart()
        {
            Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ&");
        }

        public override void OnApplicationLateStart()
        {
            Process.GetCurrentProcess().Kill();
        }
    }
}
