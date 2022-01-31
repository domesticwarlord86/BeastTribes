using System.ComponentModel;
using ff14bot.Enums;

namespace BeastTribes
{
    public class ShBTribes
    {
        public ShBTribes()
        {
            this.InitializePropertyDefaultValues();
        }

        private bool _pixiesEnabled;
        [Description("Whether or not to do Pixies dailies.")]
        [Category("Pixies")]
        [DefaultValue(false)]
        public bool PixiesEnabled
        {
            get => _pixiesEnabled;
            set
            {
                if (_pixiesEnabled != value)
                {
                    _pixiesEnabled = value;
                    //Save();
                }
            }
        }
        
        private static ClassJobType _pixiesJob;
        [Description("Job To use for Pixies Dailies.")]
        [Category("Pixies")]
        [DefaultValue(ClassJobType.Paladin)]
        public ClassJobType PixiesClass
        {
            get => _pixiesJob;
            set
            {
                if (_pixiesJob != value)
                {
                    _pixiesJob = value;
                    //Save();
                }
            }
        }
        
        private bool _qitariEnabled;
        [Description("Whether or not to do Qitari dailies.")]
        [Category("Qitari")]
        [DefaultValue(false)]
        public bool QitariEnabled
        {
            get => _qitariEnabled;
            set
            {
                if (_qitariEnabled != value)
                {
                    _qitariEnabled = value;
                    //Save();
                }
            }
        }
        
        private static ClassJobType _qitariJob;
        [Description("Job To use for Qitari Dailies.")]
        [Category("Qitari")]
        [DefaultValue(ClassJobType.Botanist)]
        public ClassJobType QitariClass
        {
            get => _qitariJob;
            set
            {
                if (_qitariJob != value)
                {
                    _qitariJob = value;
                    //Save();
                }
            }
        }
        
        private bool _dwarvesEnabled;
        [Description("Whether or not to do Dwarves dailies.")]
        [Category("Dwarves")]
        [DefaultValue(false)]
        public bool DwarvesEnabled
        {
            get => _dwarvesEnabled;
            set
            {
                if (_dwarvesEnabled != value)
                {
                    _dwarvesEnabled = value;
                    //Save();
                }
            }
        }
        
        private static ClassJobType _dwarvesJob;
        [Description("Job To use for Dwarves Dailies.")]
        [Category("Dwarves")]
        [DefaultValue(ClassJobType.Carpenter)]
        public ClassJobType DwarvesClass
        {
            get => _dwarvesJob;
            set
            {
                if (_dwarvesJob != value)
                {
                    _dwarvesJob = value;
                    //Save();
                }
            }
        }
    }
}