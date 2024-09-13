using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPNames
{
    using System;
    using System.Collections.Generic;
    using Exiled.API.Features;
    using MEC;
    using Player = Exiled.Events.Handlers.Player;

    public class Plugin : Plugin<Config>
    {
        public override string Name { get; } = "RpNameEXILED8";
        public override string Author { get; } = "!CBX";
        public override string Prefix { get; } = "RP Names";

        public EventHandlers.EventHandlers PlayerHandlers;

        public List<string> NickNames = new List<string> { "If you see this something went wrong", "Uh oh" };
        public override void OnEnabled()
        {
            if (Config.HumanNames.Count == 0)
            {
                NickNames = new List<string> { "K. Thompson", "A. Stevenson", "N. Novel", "M. Xray ", "R. High", "E. Evans", "A. Woodson", "P. Bing", "C. Zenon", "C. Cobble", "O. May", "V. Base", "D. Kevinson", "I. Zenix" };
            }
            else
            {
                NickNames = Config.HumanNames;
            }
            PlayerHandlers = new EventHandlers.EventHandlers(this);
            Player.ChangingRole += PlayerHandlers.OnPlayerChangeRole;
            Player.Died += PlayerHandlers.OnPlayerDeath;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Player.ChangingRole -= PlayerHandlers.OnPlayerChangeRole;
            Player.Died -= PlayerHandlers.OnPlayerDeath;
            PlayerHandlers = null;
            base.OnDisabled();
        }
    }
}
