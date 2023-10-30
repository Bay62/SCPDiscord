using System;
using System.Collections.Generic;
using System.Linq;
using CommandSystem;
using PluginAPI.Core;

namespace SCPDiscord.Commands
{
	public class GrantVanillaRankCommand : ICommand
	{
		public string Command { get; } = "grantvanillarank";
		public string[] Aliases { get; } = new string[] { "gvr" };
		public string Description { get; } = "Grants a player the vanilla rank provided.";

		public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
		{
			/*if (sender is Player admin)
			{
				if (!messages.HasPermission("scpdiscord.grantvanillarank"))
				{
					return new[] { "You don't have permission to use that command." };
				}
			}*/

			if (arguments.Count < 2)
			{
				response = "Invalid arguments.";
				return false;
			}

			string steamIDOrPlayerID = arguments.Array[2].Replace("@steam", ""); // Remove steam suffix if there is one

			List<Player> matchingPlayers = new List<Player>();
			try
			{
				SCPDiscord.plugin.Debug("Looking for player with SteamID/PlayerID: " + steamIDOrPlayerID);
				foreach (Player pl in Player.GetPlayers<Player>())
				{
					SCPDiscord.plugin.Debug("Player " + pl.PlayerId + ": SteamID " + pl.UserId + " PlayerID " + pl.PlayerId);
					if (pl.GetParsedUserID() == steamIDOrPlayerID)
					{
						SCPDiscord.plugin.Debug("Matching SteamID found");
						matchingPlayers.Add(pl);
					}
					else if (pl.PlayerId.ToString() == steamIDOrPlayerID)
					{
						SCPDiscord.plugin.Debug("Matching playerID found");
						matchingPlayers.Add(pl);
					}
				}
			}
			catch (Exception) { /* ignored */ }

			if (!matchingPlayers.Any())
			{
				response = "Player \"" + arguments.Array[2] + "\"not found.";
				return false;
			}

			try
			{
				foreach (Player matchingPlayer in matchingPlayers)
				{
					matchingPlayer.SetRank(null, null, arguments.Array[3]);
				}
			}
			catch (Exception)
			{
				response = "Vanilla rank \"" + arguments.Array[3] + "\" not found. Are you sure you are using the RA config role name and not the role title/badge?";
				return false;
			}

			response = "Player rank updated.";
			return true;
		}
	}
}