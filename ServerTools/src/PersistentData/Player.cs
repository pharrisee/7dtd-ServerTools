﻿using System;
using System.Runtime.Serialization;

namespace ServerTools
{
    [Serializable]
    public class Player
    {
        private readonly string steamId;
        [OptionalField]
        private int startingItems;
        [OptionalField]
        private string homeposition2;
        [OptionalField]
        private DateTime respawnTime;
        [OptionalField]
        private DateTime lastTravel;
        [OptionalField]
        private int worldSeedFirstClaim;
        [OptionalField]
        private bool adminChatColor;
        [OptionalField]
        private DateTime lastAnimals;
        [OptionalField]
        private DateTime lastVoteReward;
        [OptionalField]
        private DateTime lastgimme;
        [OptionalField]
        private DateTime lastkillme;
        [OptionalField]
        private string homeposition;
        [OptionalField]
        private DateTime lastsethome;
        [OptionalField]
        private string clanname;
        [OptionalField]
        private bool isclanowner;
        [OptionalField]
        private bool isclanofficer;
        [OptionalField]
        private string invitedtoclan;
        [OptionalField]
        private string lastwhisper;
        [OptionalField]
        private bool ismuted;
        [OptionalField]
        private bool isjailed;
        [OptionalField]
        private bool isremovedfromjail = true;
        [OptionalField]
        private int newspawntele;

        public int StartingItems
        {
            get
            {
                return startingItems;
            }
            set
            {
                startingItems = value;
            }
        }

        public string HomePosition2
        {
            get
            {
                return homeposition2;
            }
            set
            {
                homeposition2 = value;
            }
        }

        public DateTime RespawnTime
        {
            get
            {
                return respawnTime;
            }
            set
            {
                respawnTime = value;
            }
        }

        public DateTime LastTravel
        {
            get
            {
                return lastTravel;
            }
            set
            {
                lastTravel = value;
            }
        }

        public int WorldSeedFirstClaim
        {
            get
            {
                return worldSeedFirstClaim;
            }
            set
            {
                worldSeedFirstClaim = value;
            }
        }

        public bool AdminChatColor
        {
            get
            {
                return adminChatColor;
            }
            set
            {
                adminChatColor = value;
            }
        }

        public DateTime LastVoteReward
        {
            get
            {
                return lastVoteReward;
            }
            set
            {
                lastVoteReward = value;
            }
        }

        public DateTime LastAnimals
        {
            get
            {
                return lastAnimals;
            }
            set
            {
                lastAnimals = value;
            }
        }

        public DateTime LastGimme
        {
            get
            {
                return lastgimme;
            }
            set
            {
                lastgimme = value;
            }
        }

        public DateTime LastKillme
        {
            get
            {
                return lastkillme;
            }
            set
            {
                lastkillme = value;
            }
        }

        public string HomePosition
        {
            get
            {
                return homeposition;
            }
            set
            {
                homeposition = value;
            }
        }

        public DateTime LastSetHome
        {
            get
            {
                return lastsethome;
            }
            set
            {
                lastsethome = value;
            }
        }

        public string ClanName
        {
            get
            {
                return clanname;
            }
            set
            {
                clanname = value;
            }
        }

        public bool IsClanOwner
        {
            get
            {
                return isclanowner;
            }
            set
            {
                isclanowner = value;
            }
        }

        public bool IsClanOfficer
        {
            get
            {
                return isclanofficer;
            }
            set
            {
                isclanofficer = value;
            }
        }

        public string InvitedToClan
        {
            get
            {
                return invitedtoclan;
            }
            set
            {
                invitedtoclan = value;
            }
        }

        public string LastWhisper
        {
            get
            {
                return lastwhisper;
            }
            set
            {
                lastwhisper = value;
            }
        }

        public bool IsMuted
        {
            get
            {
                return ismuted;
            }
            set
            {
                ismuted = value;
            }
        }

        public bool IsJailed
        {
            get
            {
                return isjailed;
            }
            set
            {
                isjailed = value;
            }
        }
        
        public bool IsRemovedFromJail
        {
            get
            {
                return isremovedfromjail;
            }
            set
            {
                isremovedfromjail = value;
            }
        }

        public int NewSpawnTele
        {
            get
            {
                return newspawntele;
            }
            set
            {
                newspawntele = value;
            }
        }

        public Player(string steamId)
        {
            this.steamId = steamId;
        }
    }
}