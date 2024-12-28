using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using Exiled.API.Features;
using Exiled.API.Interfaces;
using PlayerRoles;
using Scp914;

namespace RPNames
{
    public class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Is the Debug on?")]
        public bool Debug { get; set; } = false;

        [Description("Should There Be Random Instance Numbers at SCPS?")]

        public bool randnum { get; set; } = false;

        [Description("Should Nick Clear Out After Changing To Tutorial?")]
        public bool TutorialNick { get; set; } = true;

        [Description("Should Class D Have Random Number After Their Name?")]
        public bool DboisSetting { get; set; } = true;

        [Description("Should SCP`s Have Custom Names?")]
        public bool SCPSetting { get; set; } = true;

        [Description("Should SCP 049-2 Not Have Custom Names?")]
        public bool ZombieNames { get; set; } = false;

        [Description("Use only human_names (classd setting must be on!)?")]
        public bool randomnames { get; set; } = false;

        [Description("Should Nickname Clear After Death?")]
        public bool DeathReset { get; set; } = true;

        [Description("Should Player Nickname Be Shown At The Respawn?")]
        public bool ShowNick { get; set; } = true;

        [Description("Should Player Nickname Show After Custom Nickname?")]
        public bool ShowRealName { get; set; } = true;

        [Description("Editable Human Prefixes")]
        public Dictionary<RoleTypeId, string> ClassTitles { get; set; } = new Dictionary<RoleTypeId, string>
        {
            {
                RoleTypeId.ClassD, "D-"
            },
            {
                RoleTypeId.Scientist, "Dr."
            },
            {
                RoleTypeId.FacilityGuard, "Officer"
            },
            {
                RoleTypeId.NtfCaptain, "Captain"
            },
            {
                RoleTypeId.NtfPrivate, "Cadet"
            },
            {
                RoleTypeId.NtfSergeant, "Sergeant"
            },
            {
                RoleTypeId.NtfSpecialist, "Agent"
            },
            {
                RoleTypeId.ChaosConscript, "Chaos Agent"
            },
            {
                RoleTypeId.ChaosMarauder, "Chaos Agent"
            },
            {
                RoleTypeId.ChaosRepressor, "Chaos Agent"
            },
            {
                RoleTypeId.ChaosRifleman, "Chaos Agent"
            },
            {
                RoleTypeId.Scp049, "SCP-049"
            },
            {
                RoleTypeId.Scp0492, "SCP-049-2"
            },
            {
                RoleTypeId.Scp079, "SCP-079"
            },
            {
                RoleTypeId.Scp096, "SCP-096"
            },
            {
                RoleTypeId.Scp106, "SCP-106"
            },
            {
                RoleTypeId.Scp173, "SCP-173"
            },
            {
                RoleTypeId.Scp939, "SCP-939"
            },
            {
                RoleTypeId.Scp3114, "SCP-3114"
            },
        };

        [Description("List Of Names [Can Be Edited Without Errors] ")]
        public List<string> HumanNames { get; set; } = new List<string> { "K. Thompson", "A. Stevenson", "N. Novel", "M. Xray ", "R. High", "E. Evans", "A. Woodson", "P. Bing", "C. Zenon", "C. Cobble", "O. May", "V. Base", "D. Kevinson", "I. Zenix", "Z. Vai,", "A. Vorbixon", "T. Novix", "K. Water", "A. Ballix", "E. Simoned", "E. Simoned", "A. Zinxon", "Y. Morb", "J. Zenix", "P. Pompinson" };

    }
}



