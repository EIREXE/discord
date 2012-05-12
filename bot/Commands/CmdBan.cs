﻿using System;
using SteamKit2;

namespace AgopBot.Commands
{
    public class CmdBan : Command
    {
        public CmdBan() : base("ban") { }

        public override void Use(SteamID room, SteamID sender, string[] args)
        {
            if (Util.IsAdmin(sender))
                Steam.Friends.BanChatMember(room, sender);
            else
                Chat.Send(room, "I can't let you do that " + Steam.Friends.GetFriendPersonaName(sender) + "!");
        }
    }
}