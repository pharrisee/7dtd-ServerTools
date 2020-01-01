﻿using System;
using System.Collections.Generic;
using System.Xml;

namespace ServerTools
{
    class PrayerConsole : ConsoleCmdAbstract
    {
        public override string GetDescription()
        {
            return "[ServerTools]- Enable or Disable Prayer.";
        }
        public override string GetHelp()
        {
            return "Usage:\n" +
                   "  1. Prayer off\n" +
                   "  2. Prayer on\n" +
                   "1. Turn off prayer\n" +
                   "2. Turn on prayer\n";
        }
        public override string[] GetCommands()
        {
            return new string[] { "st-Prayer", "prayer" };
        }
        public override void Execute(List<string> _params, CommandSenderInfo _senderInfo)
        {
            try
            {
                if (_params.Count != 1)
                {
                    SdtdConsole.Instance.Output(string.Format("Wrong number of arguments, expected 1, found {0}", _params.Count));
                    return;
                }
                if (_params[0].ToLower().Equals("off"))
                {
                    if (Prayer.IsEnabled)
                    {
                        Prayer.IsEnabled = false;
                        LoadConfig.WriteXml();
                        SdtdConsole.Instance.Output(string.Format("Prayer has been set to off"));
                        return;
                    }
                    else
                    {
                        SdtdConsole.Instance.Output(string.Format("Prayer is already off"));
                        return;
                    }
                }
                else if (_params[0].ToLower().Equals("on"))
                {
                    if (Prayer.IsEnabled)
                    {
                        Prayer.IsEnabled = true;
                        LoadConfig.WriteXml();
                        SdtdConsole.Instance.Output(string.Format("Prayer has been set to on"));
                        return;
                    }
                    else
                    {
                        SdtdConsole.Instance.Output(string.Format("Prayer is already on"));
                        return;
                    }
                }
                else
                {
                    SdtdConsole.Instance.Output(string.Format("Invalid argument {0}", _params[0]));
                }
            }
            catch (Exception e)
            {
                Log.Out(string.Format("[SERVERTOOLS] Error in PrayerConsole.Execute: {0}", e));
            }
        }
    }
}