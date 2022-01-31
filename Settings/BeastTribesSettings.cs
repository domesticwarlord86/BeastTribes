using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Clio.Utilities;
using ff14bot.Enums;
using ff14bot.Helpers;
using ff14bot.Managers;
using Newtonsoft.Json;

namespace BeastTribes
{
    public class BeastTribesSettings : JsonSettings
    {
        private static BeastTribesSettings beastTribesSettingssettings;
        public static BeastTribesSettings Instance => beastTribesSettingssettings ?? (beastTribesSettingssettings = new BeastTribesSettings());
        
        public BeastTribesSettings() : base(Path.Combine(CharacterSettingsDirectory, "BeastTribesSettings.json")) 
        {
            
        }
        
        
        private ARRTribes _ArrSettings;
        
        public ARRTribes ArrSettings
        {
            get => _ArrSettings ?? (_ArrSettings = new ARRTribes());
            set
            {
                _ArrSettings = value;
                Save();
            }
        }
        
        private HWTribes _HWSettings;
        
        public HWTribes HWSettings
        {
            get => _HWSettings ?? (_HWSettings = new HWTribes());
            set
            {
                _HWSettings = value;
                Save();
            }
        }
        
        private SBTribes _SBSettings;
        
        public SBTribes SBSettings
        {
            get => _SBSettings ?? (_SBSettings = new SBTribes());
            set
            {
                _SBSettings = value;
                Save();
            }
        }
        
        private ShBTribes _ShBSettings;
        
        public ShBTribes ShBSettings
        {
            get => _ShBSettings ?? (_ShBSettings = new ShBTribes());
            set
            {
                _ShBSettings = value;
                Save();
            }
        }

        

        
    }
}