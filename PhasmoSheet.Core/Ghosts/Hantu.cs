using PhasmoSheet.Core.Common;

namespace PhasmoSheet.Core.Ghosts
{
    public class Hantu : Ghost
    {
        public Hantu()
        {
            Name = "Hantu";
            Evidences = [Evidence.Ultraviolet, Evidence.GhostOrb, Evidence.FreezingTemperatures];
            GuaranteedEvidence = Evidence.FreezingTemperatures;
            MinSanityPercentage = 50;
            ConditionalSanityPercentages = [];
            DefaultFootstepSpeed = 1.4;
            ConditionalFootstepSpeed = [2.7];
            HasStandardLOSAccel = false;
            Tells = [
                "Will have visible freezing breath cloud during hunts when the breaker is off/broken",
                "It is faster in colder rooms during hunts"
                ];
            RuleOuts = [new("Cannot turn on the breaker", Usefulness.Important)];
            ConfirmationTests = ["While the breaker is off, if the ghost has a breath cloud during a hunt, it is a Hantu",
            "If the ghost seems to change speeds randomly without influence of equipment or player, it is a Hantu"];
            Abilities = ["Is faster in colder rooms during hunts"];
            ExclusiveEvents = [GhostEvents.TurnsOffBreakerFrequently, GhostEvents.ShowingBreathDuringHunt];
            RuleOutEvents = [GhostEvents.GhostTurnedOnBreaker];
        }
    }
}
