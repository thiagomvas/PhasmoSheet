using PhasmoSheet.Core.Common;

namespace PhasmoSheet.Core.Ghosts
{
    public class Demon : Ghost
    {
        public Demon()
        {
            Name = "Demon";
            Evidences = new[] { Evidence.Ultraviolet, Evidence.GhostWriting, Evidence.FreezingTemperatures };
            MinSanityPercentage = 70;
            ConditionalSanityPercentages = [100];
            DefaultFootstepSpeed = 1.7;
            HasStandardLOSAccel = true;
            Tells = [
                "Can start hunting at any sanity level",
                "Will not hunt within 5m of a crucifix",
                ];
            ConfirmationTests = [
                "If the ghost hunts above 80% sanity and no one has a sanity below 50%, with no candles being lit, it is a Demon."
                ];
            RuleOuts = [
                "Cannot hunt within 5m of a crucifix",
                ];

            RuleOutEvents = [GhostEvents.HuntedWithin5mOfCrucifix];
        }
    }
}
