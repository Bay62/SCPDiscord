using System;
using CommandSystem;
using PluginAPI.Core;

namespace SCPDiscord.Commands
{
	public class ValidateCommand : SCPDiscordCommand
	{
		public string Command { get; } = "validate";
		public string[] Aliases { get; } = { };
		public string Description { get; } = "Creates a config validation report.";
		public string[] ArgumentList { get; } = { };

		public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
		{
			/*if (sender is Player player)
			{
				if (!player.HasPermission("scpdiscord.validate"))
				{
					return new[] { "You don't have permission to use that command." };
				}
			}*/

			Config.ValidateConfig(SCPDiscord.plugin);
			Language.ValidateLanguageStrings();

			response = "Validation report posted in server console.";
			return true;
		}
	}
}