using System.ComponentModel;
using ff14bot.Enums;

namespace BeastTribes
{
    public class ARRTribes
    {
        public ARRTribes()
        {
            this.InitializePropertyDefaultValues();
        }

        private bool _amaljaaEnabled;
        [Description("Whether or not to do Amalj'aa dailies.")]
        [Category("Amalj'aa")]
        [DefaultValue(false)]
        public bool AmaljaaEnabled
        {
            get => _amaljaaEnabled;
            set
            {
                if (_amaljaaEnabled != value)
                {
                    _amaljaaEnabled = value;
                    //Save();
                }
            }
        }
        
        private static ClassJobType _amaljaaJob;
        [Description("Job To use for Amalj'aa Dailies.")]
        [Category("Amalj'aa")]
        [DefaultValue(ClassJobType.Paladin)]
        public ClassJobType AmalaJaaClass
        {
            get => _amaljaaJob;
            set
            {
                if (_amaljaaJob != value)
                {
                    _amaljaaJob = value;
                    //Save();
                }
            }
        }
        
        private bool _sylphsEnabled;
        [Description("Whether or not to do Sylphs dailies.")]
        [Category("Sylphs")]
        [DefaultValue(false)]
        public bool SylphsEnabled
        {
            get => _sylphsEnabled;
            set
            {
                if (_sylphsEnabled != value)
                {
                    _sylphsEnabled = value;
                    //Save();
                }
            }
        }
        
        private static ClassJobType _sylphsJob;
        [Description("Job To use for Sylphs Dailies.")]
        [Category("Sylphs")]
        [DefaultValue(ClassJobType.Paladin)]
        public ClassJobType SylphsClass
        {
            get => _sylphsJob;
            set
            {
                if (_sylphsJob != value)
                {
                    _sylphsJob = value;
                    //Save();
                }
            }
        }
        
        private bool _koboldsEnabled;
        [Description("Whether or not to do Kobolds dailies.")]
        [Category("Kobolds")]
        [DefaultValue(false)]
        public bool KoboldsEnabled
        {
            get => _koboldsEnabled;
            set
            {
                if (_koboldsEnabled != value)
                {
                    _koboldsEnabled = value;
                    //Save();
                }
            }
        }
        
        private static ClassJobType _koboldsJob;
        [Description("Job To use for Kobolds Dailies.")]
        [Category("Kobolds")]
        [DefaultValue(ClassJobType.Paladin)]
        public ClassJobType KoboldsClass
        {
            get => _koboldsJob;
            set
            {
                if (_koboldsJob != value)
                {
                    _koboldsJob = value;
                    //Save();
                }
            }
        }
        
        private bool _sahaginEnabled;
        [Description("Whether or not to do Sahagin dailies.")]
        [Category("Sahagin")]
        [DefaultValue(false)]
        public bool SahaginEnabled
        {
            get => _sahaginEnabled;
            set
            {
                if (_sahaginEnabled != value)
                {
                    _sahaginEnabled = value;
                    //Save();
                }
            }
        }
        
        private static ClassJobType _sahaginJob;
        [Description("Job To use for Sahagin Dailies.")]
        [Category("Sahagin")]
        [DefaultValue(ClassJobType.Paladin)]
        public ClassJobType SahaginClass
        {
            get => _sahaginJob;
            set
            {
                if (_sahaginJob != value)
                {
                    _sahaginJob = value;
                    //Save();
                }
            }
        }
        
        private bool _ixalEnabled;
        [Description("Whether or not to do Ixal dailies.")]
        [Category("Ixal")]
        [DefaultValue(false)]
        public bool IxalEnabled
        {
            get => _ixalEnabled;
            set
            {
                if (_ixalEnabled != value)
                {
                    _ixalEnabled = value;
                    //Save();
                }
            }
        }
        
        private static ClassJobType _ixalJob;
        [Description("Job To use for Ixal Dailies.")]
        [Category("Ixal")]
        [DefaultValue(ClassJobType.Carpenter)]
        public ClassJobType IxalClass
        {
            get => _ixalJob;
            set
            {
                if (_ixalJob != value)
                {
                    _ixalJob = value;
                   //Save();
                }
            }
        }
    }
}