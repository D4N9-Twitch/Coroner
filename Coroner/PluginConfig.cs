using BepInEx.Configuration;

namespace Coroner
{
    public class PluginConfig
    {
        ConfigEntry<bool> DisplayCauseOfDeath;
        ConfigEntry<bool> SeriousDeathMessages;
        ConfigEntry<bool> DisplayFunnyNotes;
        ConfigEntry<bool> DeathReplacesNotes;

        // Constructor
        public PluginConfig()
        {
        }

        // Bind config values to fields
        public void BindConfig(ConfigFile _config)
        {
            DisplayCauseOfDeath = _config.Bind("General", "DisplayCauseOfDeath", true, "Display the cause of death in the player notes.");
            SeriousDeathMessages = _config.Bind("General", "SeriousDeathMessages", false, "Cause of death messages are more to-the-point.");
            DisplayFunnyNotes = _config.Bind("General", "DisplayFunnyNotes", true, "Display a random note when the player has no notes.");
            DeathReplacesNotes = _config.Bind("General", "DeathReplacesNotes", true, "True to replace notes when the player dies, false to append.");
        }

        public bool ShouldDisplayCauseOfDeath()
        {
            return DisplayCauseOfDeath.Value;
        }

        public bool ShouldUseSeriousDeathMessages()
        {
            return SeriousDeathMessages.Value;
        }

        public bool ShouldDisplayFunnyNotes()
        {
            return DisplayFunnyNotes.Value;
        }

        public bool ShouldDeathReplaceNotes()
        {
            return DeathReplacesNotes.Value;
        }
    }
}
