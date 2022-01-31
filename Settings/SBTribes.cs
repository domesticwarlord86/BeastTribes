using System.ComponentModel;
using ff14bot.Enums;

namespace BeastTribes
{
    public class SBTribes
    {
        public SBTribes()
        {
            this.InitializePropertyDefaultValues();
        }

        private bool _kojinEnabled;
        [Description("Whether or not to do Kojin dailies.")]
        [Category("Kojin")]
        [DefaultValue(false)]
        public bool KojinEnabled
        {
            get => _kojinEnabled;
            set
            {
                if (_kojinEnabled != value)
                {
                    _kojinEnabled = value;
                    //Save();
                }
            }
        }
        
        private static ClassJobType _kojinJob;
        [Description("Job To use for Kojin Dailies.")]
        [Category("Kojin")]
        [DefaultValue(ClassJobType.Paladin)]
        public ClassJobType KojinClass
        {
            get => _kojinJob;
            set
            {
                if (_kojinJob != value)
                {
                    _kojinJob = value;
                    //Save();
                }
            }
        }
        
        private bool _anantaEnabled;
        [Description("Whether or not to do Ananta dailies.")]
        [Category("Ananta")]
        [DefaultValue(false)]
        public bool AnantaEnabled
        {
            get => _anantaEnabled;
            set
            {
                if (_anantaEnabled != value)
                {
                    _anantaEnabled = value;
                    //Save();
                }
            }
        }
        
        private static ClassJobType _anantaJob;
        [Description("Job To use for Ananta Dailies.")]
        [Category("Ananta")]
        [DefaultValue(ClassJobType.Paladin)]
        public ClassJobType AnantaClass
        {
            get => _anantaJob;
            set
            {
                if (_anantaJob != value)
                {
                    _anantaJob = value;
                    //Save();
                }
            }
        }
        
        private bool _namazuEnabled;
        [Description("Whether or not to do Namazu dailies.")]
        [Category("Namazu")]
        [DefaultValue(false)]
        public bool NamazuEnabled
        {
            get => _namazuEnabled;
            set
            {
                if (_namazuEnabled != value)
                {
                    _namazuEnabled = value;
                    //Save();
                }
            }
        }
        
        private static ClassJobType _namazuJob;
        [Description("Job To use for Namazu Dailies.")]
        [Category("Namazu")]
        [DefaultValue(ClassJobType.Carpenter)]
        public ClassJobType NamazuClass
        {
            get => _namazuJob;
            set
            {
                if (_namazuJob != value)
                {
                    _namazuJob = value;
                    //Save();
                }
            }
        }
    }
}