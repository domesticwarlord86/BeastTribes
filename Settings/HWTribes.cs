using System.ComponentModel;
using ff14bot.Enums;

namespace BeastTribes
{
    public class HWTribes
    {
        public HWTribes()
        {
            this.InitializePropertyDefaultValues();
        }

        private bool _vanuEnabled;
        [Description("Whether or not to do Vanu Vanu dailies.")]
        [Category("Vanu Vanu")]
        [DefaultValue(false)]
        public bool VanuEnabled
        {
            get => _vanuEnabled;
            set
            {
                if (_vanuEnabled != value)
                {
                    _vanuEnabled = value;
                    //Save();
                }
            }
        }
        
        private static ClassJobType _vanuJob;
        [Description("Job To use for Vanu Vanu Dailies.")]
        [Category("Vanu Vanu")]
        [DefaultValue(ClassJobType.Paladin)]
        public ClassJobType VanuClass
        {
            get => _vanuJob;
            set
            {
                if (_vanuJob != value)
                {
                    _vanuJob = value;
                    //Save();
                }
            }
        }
        
        private bool _vathEnabled;
        [Description("Whether or not to do Vath dailies.")]
        [Category("Vath")]
        [DefaultValue(false)]
        public bool VathEnabled
        {
            get => _vathEnabled;
            set
            {
                if (_vathEnabled != value)
                {
                    _vathEnabled = value;
                    //Save();
                }
            }
        }
        
        private static ClassJobType _vathJob;
        [Description("Job To use for Vath Dailies.")]
        [Category("Vath")]
        [DefaultValue(ClassJobType.Paladin)]
        public ClassJobType VathClass
        {
            get => _vathJob;
            set
            {
                if (_vathJob != value)
                {
                    _vathJob = value;
                    //Save();
                }
            }
        }
        
        private bool _mooglesEnabled;
        [Description("Whether or not to do Moogles dailies.")]
        [Category("Moogles")]
        [DefaultValue(false)]
        public bool MooglesEnabled
        {
            get => _mooglesEnabled;
            set
            {
                if (_mooglesEnabled != value)
                {
                    _mooglesEnabled = value;
                    //Save();
                }
            }
        }
        
        private static ClassJobType _mooglesJob;
        [Description("Job To use for Moogles Dailies.")]
        [Category("Moogles")]
        [DefaultValue(ClassJobType.Carpenter)]
        public ClassJobType MooglesClass
        {
            get => _mooglesJob;
            set
            {
                if (_mooglesJob != value)
                {
                    _mooglesJob = value;
                    //Save();
                }
            }
        }
    }
}