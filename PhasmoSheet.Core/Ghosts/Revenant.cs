using PhasmoSheet.Core.Common;

namespace PhasmoSheet.Core.Ghosts
{
    public class Revenant : Ghost
    {
        public Revenant()
        {
            Name = "Revenant";
            Evidences = new[] { Evidence.GhostOrb, Evidence.GhostWriting, Evidence.FreezingTemperatures };
            MinSanityPercentage = 50;
            DefaultFootstepSpeed = 1;
            ConditionalFootstepSpeed = new[] { 3.0 };
            HasStandardLOSAccel = false;
            Tells = [
                "Revenant will immediately speed up to 3m/s when it detects a player(voice, device or LOS) and only slow down when it reaches the last known location"
                ];
            ConfirmationTests = [
                "If the ghost is very slow but speeds up instantly when detecting a player, and proceeds to slows down, it is a Revenant"
                ];
        }
    }
}
