﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Xml;

namespace ServerTools
{
    class FlyingConsole : ConsoleCmdAbstract
    {
        public override string GetDescription()
        {
            return "[ServerTools]- Enable, Disable Flying Detection.";
        }
        public override string GetHelp()
        {
            return "Usage:\n" +
                   "  1. Flying off\n" +
                   "  2. Flying on\n" +
                   "1. Turn off flight detection\n" +
                   "2. Turn on flight detection\n";
        }
        public override string[] GetCommands()
        {
            return new string[] { "st-Flying", "flying" };
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
                    if (Flying.IsEnabled)
                    {
                        Flying.IsEnabled = false;
                        LoadConfig.WriteXml();
                        SdtdConsole.Instance.Output(string.Format("Flying has been set to off"));
                        return;
                    }
                    else
                    {
                        SdtdConsole.Instance.Output(string.Format("Flying is already off"));
                        return;
                    }
                }
                else if (_params[0].ToLower().Equals("on"))
                {
                    if (!Flying.IsEnabled)
                    {
                        Flying.IsEnabled = true;
                        LoadConfig.WriteXml();
                        SdtdConsole.Instance.Output(string.Format("Flying has been set to on"));
                        return;
                    }
                    else
                    {
                        SdtdConsole.Instance.Output(string.Format("Flying is already on"));
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
                Log.Out(string.Format("[SERVERTOOLS] Error in FlyingConsole.Execute: {0}", e));
            }
        }
    }
}