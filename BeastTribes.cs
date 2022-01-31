using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Media;
using Buddy.Coroutines;
using ff14bot;
using ff14bot.AClasses;
using ff14bot.Behavior;
using ff14bot.Enums;
using ff14bot.Managers;
using ff14bot.Navigation;
using ff14bot.Pathing.Service_Navigation;
using ff14bot.RemoteWindows;
using LlamaLibrary.Helpers;
using LlamaLibrary.Logging;
using LlamaLibrary.Memory;
using LlamaLibrary.RemoteWindows;
using TreeSharp;

namespace BeastTribes
{
    public class BeastTribes: BotBase
    {
        private static readonly LLogger Log = new LLogger("BeastTribes", Colors.Pink);

        private Composite _root;

        private static bool ranOrderbot = false;

        public override string Name => "BeastTribes";
        public override PulseFlags PulseFlags => PulseFlags.All;
        
        public Version Version => new Version(0, 1);

        public override bool IsAutonomous => true;
        public override bool RequiresProfile => false;

        public override Composite Root => _root;

        public override bool WantButton { get; } = true;

        private static string FolderPath;
        
        public static BeastTribesSettings BeastTribesSettings => BeastTribesSettings.Instance;
        
        private BeastTribesSettings _settings;
        private BeastTribesSettingsForm _form;
        
        public override void OnButtonPress()
        {
            if (_form == null)
            {
                _form = new BeastTribesSettingsForm()
                {
                    Text = $"BeastTribes Settings v{Version}",
                };
                _form.Closed += (o, e) => { _form = null; };
            }

            try
            {
                _form.Show();
            }
            catch (Exception)
            {
                // ignored
            }
        }
        
        public BeastTribes()
        {
            OffsetManager.Init();
            Log.Information("Want to set agents now...");
            OffsetManager.SetOffsetClassesAndAgents();
            
            var foldername = "BeastTribes";
            FolderPath = Path.Combine(BotManager.BotBaseDirectory, foldername);
            
        }
        
        public override void Start()
        {
            Navigator.PlayerMover = new SlideMover();
            Navigator.NavigationProvider = new ServiceNavigationProvider();
            _root = new ActionRunCoroutine(r => DutyRun());
        }


        public override void Stop()
        {
            _root = null;
            (Navigator.NavigationProvider as IDisposable)?.Dispose();
            Navigator.NavigationProvider = null;
        }
        
        private int maxDailiesPerTribe = 3;

        private async Task RunDailiesAsync(string tribeName, string profilePath, ClassJobType targetJob, IEnumerable<int> allTribeDailies)
        {
            var acceptedOrCompletedDailies = BeastTribeHelper.GetCurrentDailies();
            int numberComplete = acceptedOrCompletedDailies.Count(quest => quest.IsComplete && allTribeDailies.Contains(quest.ID));

            if (numberComplete >= maxDailiesPerTribe)
            {
                Log.Information($"Done with {tribeName}");
            }
            else
            {
                Log.Information($"Need to complete {maxDailiesPerTribe - numberComplete} of {maxDailiesPerTribe} dailies for {tribeName}.");

                if (targetJob != Core.Me.CurrentJob)
                {
                    Log.Information($"Changing job to {targetJob}.");
                    await ChangeJob(targetJob);
                }

                await RunProfile(profilePath);
            }
        }
        private async Task<bool> DutyRun()
        {
            // ARR Tribes
            if (BeastTribesSettings.ArrSettings.AmaljaaEnabled)
            {
                await RunDailiesAsync(
                    "Amaljaa",
                    "Profiles\\A Realm Reborn\\Amal'jaa Dailies.xml",
                    BeastTribesSettings.ArrSettings.AmalaJaaClass,
                    new HashSet<int>() {
                        66758, 66759, 66760, 66761, 66762, 66763, 66764, 66765, 
                        66766, 66767, 66768, 66769, 66770, 66771, 66772, 66773, 
                        66774, 66775, 66776, 66777, 66778, 66779, 66780, 66781, 
                        66782, 66783, 66784, 66785, 66786, 66787
                    }
                );
            }
            
            if (BeastTribesSettings.ArrSettings.SahaginEnabled)
            {
                await RunDailiesAsync(
                    "Sahagin",
                    "Profiles\\A Realm Reborn\\Sahagin Dailies.xml",
                    BeastTribesSettings.ArrSettings.SahaginClass,
                    new HashSet<int>() {
                        66915,66916,66917,66918,66919,66920,66921,66922,66923,
                        66924,66926,66927,66928,66929,66930,66931,66932,66933,
                        66934,66935,66936,66937,66938,66939,66940,66941,66942,
                        66943,66944,66945
                    }
                );
            }
            
            if (BeastTribesSettings.ArrSettings.SylphsEnabled)
            {
                await RunDailiesAsync(
                    "Sylphs",
                    "Profiles\\A Realm Reborn\\Sylph Dailies.xml",
                    BeastTribesSettings.ArrSettings.SylphsClass,
                    new HashSet<int>() {
                        66793,66794,66795,66796,66797,66798,66799,66800,66801,
                        66802,66803,66804,66805,66806,66807,66808,66809,66810,
                        66811,66812,66813,66814,66815,66816,66817,66818,66819,
                        66820,66821,66822
                    }
                );
            }
            
            if (BeastTribesSettings.ArrSettings.KoboldsEnabled)
            {
                await RunDailiesAsync(
                    "Kobolds",
                    "Profiles\\A Realm Reborn\\Kobold Dailies.xml",
                    BeastTribesSettings.ArrSettings.KoboldsClass,
                    new HashSet<int>() {
                        66900,66901,66902,66903,66904,66905,66906,66907,66908,
                        66909,66871,66872,66873,66874,66875,66876,66877,66878,
                        66879,66880,66861,66862,66863,66864,66865,66866,66867,
                        66868,66869,66870
                    }
                );
            }
            
            if (BeastTribesSettings.ArrSettings.IxalEnabled)
            {
                await RunDailiesAsync(
                    "Ixali",
                    "Profiles\\A Realm Reborn\\Ixal Dailies.xml",
                    BeastTribesSettings.ArrSettings.IxalClass,
                    new HashSet<int>() {
                        67030,67031,67032,67033,67034,67035,67036,67037,67038,
                        67039,67040,67041,67042,67043,67044,67045,67046,67047,
                        67048,67049,67050,67051,67052,67053,67054,67055,67056,
                        67057,67058,67059,67102,67103,67104
                    }
                );
            }
            
            // HW Tribes
            if (BeastTribesSettings.HWSettings.VanuEnabled)
            {
                await RunDailiesAsync(
                    "Vanu vanu",
                    "Profiles\\Heavensward\\Vanu Dailies.xml",
                    BeastTribesSettings.HWSettings.VanuClass,
                    new HashSet<int>() {
                        67707,67708,67709,67710,67711,67712,67713,67714,67715,
                        67716,67717,67718,67719,67720,67721,67722,67723,67724,
                        67725,67726,67727,67728,67729,67730,67731,67732,67733,
                        67734,67735,67736
                    }
                );
            }

            if (BeastTribesSettings.HWSettings.VathEnabled)
            {
                await RunDailiesAsync(
                    "Vath",
                    "Profiles\\Heavensward\\Vath Dailies.xml",
                    BeastTribesSettings.HWSettings.VathClass,
                    new HashSet<int>() {
                        67797,67798,67799,67800,67801,67802,67803,67804,67805,
                        67806,67807,67808,67809,67810,67811,67812,67813,67814,
                        67815,67816
                    }
                );
            }
            
            if (BeastTribesSettings.HWSettings.MooglesEnabled)
            {
                await RunDailiesAsync(
                    "Moogles",
                    "Profiles\\Heavensward\\Moogle Dailies.xml",
                    BeastTribesSettings.HWSettings.MooglesClass,
                    new HashSet<int>() {
                        67826,67827,67828,67829,67830,67831,67832,67833,67834,
                        67835,67836,67837,67838,67839,67840,67841,67842,67843,
                        67844,67845,67846,67847,67848,67849,67850,67851,67852,
                        67853,67854,67855
                    }
                );
            }
            
            // SB Tribes
            if (BeastTribesSettings.SBSettings.KojinEnabled)
            {
                await RunDailiesAsync(
                    "Kojin",
                    "Profiles\\Stormblood\\Kojin Dailies.xml",
                    BeastTribesSettings.SBSettings.KojinClass,
                    new HashSet<int>() {
                        68515,68516,68517,68518,68519,68520,68521,68522,68523,
                        68524,68525,68526,68527,68528,68529,68530,68531,68532,
                        68533,68534,68535,68536,68537,68538
                    }
                );
            }   
            
            if (BeastTribesSettings.SBSettings.AnantaEnabled)
            {
                await RunDailiesAsync(
                    "Ananta",
                    "Profiles\\Stormblood\\Ananta Dailies.xml",
                    BeastTribesSettings.SBSettings.AnantaClass,
                    new HashSet<int>() {
                        68578,68579,68580,68581,68582,68583,68584,68585,68586,
                        68587,68588,68589,68590,68591,68592,68593,68594,68595,
                        68596,68597,68598,68599,68600,68601,68602,68603,68604,
                        68605
                    }
                );
            } 
            
            if (BeastTribesSettings.SBSettings.NamazuEnabled)
            {
                await RunDailiesAsync(
                    "Namazu",
                    "Profiles\\Stormblood\\Namazu Dailies.xml",
                    BeastTribesSettings.SBSettings.NamazuClass,
                    new HashSet<int>() {
                        68639,68640,68641,68642,68643,68644,68645,68646,68647,
                        68648,68649,68650,68651,68652,68653,68654,68655,68656,
                        68657,68658,68659,68660,68661,68662,68663,68664,68665,
                        68666
                    }
                );
            } 
            
            
            // ShB Tribes
            if (BeastTribesSettings.ShBSettings.PixiesEnabled)
            {
                await RunDailiesAsync(
                    "Pixies",
                    "Profiles\\Shadowbringers\\Pixies Dailies.xml",
                    BeastTribesSettings.ShBSettings.PixiesClass,
                    new HashSet<int>() {
                        69225,69226,69227,69228,69229,69230,69231,69232,69233,
                        69234,69235,69236,69237,69238,69239,69240,69241,69242,
                        69243,69244,69245,69246,69247,69248,69249,69250,69251,
                        69252
                    }
                );
            }
            
            if (BeastTribesSettings.ShBSettings.QitariEnabled)
            {
                await RunDailiesAsync(
                    "Qitari",
                    "Profiles\\Shadowbringers\\Qitari Dailies.xml",
                    BeastTribesSettings.ShBSettings.QitariClass,
                    new HashSet<int>() {
                        69342,69343,69344,69345,69346,69347,69348,69349,69350,
                        69351,69352,69353,69354,69355,69356,69357,69358,69359,
                        69360,69361,69362,69363,69364,69365,69366,69367,69368,
                        69369
                    }
                );
            }

            if (BeastTribesSettings.ShBSettings.DwarvesEnabled)
            {
                await RunDailiesAsync(
                    "Dwarves",
                    "Profiles\\Shadowbringers\\Dwarf Dailies.xml",
                    BeastTribesSettings.ShBSettings.DwarvesClass,
                    new HashSet<int>() {
                        69438,69439,69440,69441,69442,69443,69444,69445,69446,
                        69447,69448,69449,69450,69451,69452,69453,69454,69455,
                        69456,69457,69458,69459,69460,69461,69462,69463,69464,
                        69465
                    }
                );
            }            

            
            TreeRoot.Stop("Stop Requested");
            return false;
        }

        public static async Task RunProfile(string profileName)
        {
            var absolutePath = Path.GetFullPath(Path.Combine(FolderPath, profileName));

            if (!File.Exists(absolutePath))
            {
                Log.Information($"You done fucked up and {absolutePath} doesn't exist");
                return;
            }
            
            Log.Information($"Starting ${profileName}");
            await OrderbotHelper.CallOrderbot(absolutePath);
            Log.Information("Should be starting");
            await Coroutine.Sleep(new TimeSpan(0, 1, 0));
            Log.Information("Shouldn't get here");
        }

        public static async Task ChangeJob(ClassJobType newjob)
        {
            var gearSets = GearsetManager.GearSets.Where(i => i.InUse);

            if (Core.Me.CurrentJob == newjob)
            {
                return;
            }

            Log.Information($"Found job: {newjob}");
            if (gearSets.Any(gs => gs.Class == newjob))
            {
                Log.Information($"Found GearSet");
                gearSets.First(gs => gs.Class == newjob).Activate();

                await Coroutine.Wait(3000, () => SelectYesno.IsOpen || Core.Me.CurrentJob == newjob);
                if (SelectYesno.IsOpen)
                {
                    SelectYesno.Yes();
                    await Coroutine.Sleep(3000);
                }
            }
        }
        
        public enum DohClasses
        {
            Carpenter = 8,
            Blacksmith = 9,
            Armorer = 10,
            Goldsmith = 11,
            Leatherworker = 12,
            Weaver = 13,
            Alchemist = 14,
            Culinarian = 15,
        }
        
        public enum DolClasses
        {
            Miner = 16,
            Botanist = 17,
            Fisher = 18,
        }
        
        public enum DowmClasses
        {
            Paladin = 19,
            Monk = 20,
            Warrior = 21,
            Dragoon = 22,
            Bard = 23,
            White_Mage = 24,
            Black_Mage = 25,
            Summoner = 27,
            Scholar = 28,
            Ninja = 30,
            Machinist = 31,
            Dark_Knight = 32,
            Astrologian = 33,
            Samurai = 34,
            Red_Mage = 35,
            Gunbreaker = 37,
            Dancer = 38,
            Reaper = 39,
            Sage = 40,
        }
        
        
                public static readonly Dictionary<ClassJobType, ClassJobType> ClassMap = new Dictionary<ClassJobType, ClassJobType>
        {
            {ClassJobType.Adventurer, ClassJobType.Adventurer},
            {ClassJobType.Gladiator, ClassJobType.Gladiator},
            {ClassJobType.Pugilist, ClassJobType.Pugilist},
            {ClassJobType.Marauder, ClassJobType.Marauder},
            {ClassJobType.Lancer, ClassJobType.Lancer},
            {ClassJobType.Archer, ClassJobType.Archer},
            {ClassJobType.Conjurer, ClassJobType.Conjurer},
            {ClassJobType.Thaumaturge, ClassJobType.Thaumaturge},
            {ClassJobType.Carpenter, ClassJobType.Carpenter},
            {ClassJobType.Blacksmith, ClassJobType.Blacksmith},
            {ClassJobType.Armorer, ClassJobType.Armorer},
            {ClassJobType.Goldsmith, ClassJobType.Goldsmith},
            {ClassJobType.Leatherworker, ClassJobType.Leatherworker},
            {ClassJobType.Weaver, ClassJobType.Weaver},
            {ClassJobType.Alchemist, ClassJobType.Alchemist},
            {ClassJobType.Culinarian, ClassJobType.Culinarian},
            {ClassJobType.Miner, ClassJobType.Miner},
            {ClassJobType.Botanist, ClassJobType.Botanist},
            {ClassJobType.Fisher, ClassJobType.Fisher},
            {ClassJobType.Paladin, ClassJobType.Gladiator},
            {ClassJobType.Monk, ClassJobType.Pugilist},
            {ClassJobType.Warrior, ClassJobType.Marauder},
            {ClassJobType.Dragoon, ClassJobType.Lancer},
            {ClassJobType.Bard, ClassJobType.Archer},
            {ClassJobType.WhiteMage, ClassJobType.Conjurer},
            {ClassJobType.BlackMage, ClassJobType.Thaumaturge},
            {ClassJobType.Arcanist, ClassJobType.Arcanist},
            {ClassJobType.Summoner, ClassJobType.Arcanist},
            {ClassJobType.Scholar, ClassJobType.Arcanist},
            {ClassJobType.Rogue, ClassJobType.Rogue},
            {ClassJobType.Ninja, ClassJobType.Rogue},
            {ClassJobType.Machinist, ClassJobType.Machinist},
            {ClassJobType.DarkKnight, ClassJobType.DarkKnight},
            {ClassJobType.Astrologian, ClassJobType.Astrologian},
            {ClassJobType.Samurai, ClassJobType.Samurai},
            {ClassJobType.RedMage, ClassJobType.RedMage},
            {ClassJobType.BlueMage, ClassJobType.BlueMage},
            {ClassJobType.Gunbreaker, ClassJobType.Gunbreaker},
            {ClassJobType.Dancer, ClassJobType.Dancer}
        };
                
    }
}