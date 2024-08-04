using PhasmoSheet.Core.Common;

namespace PhasmoSheet.Core.Ghosts
{
    public class Jinn : Ghost
    {
        public Jinn()
        {
            Name = "Jinn";
            Evidences = [Evidence.EMF5, Evidence.Ultraviolet, Evidence.FreezingTemperatures];
            MinSanityPercentage = 50;
            Tells = [
                new("Jinn cannot turn off breaker", Usefulness.Important),
                new("Jinn has EMF at the breaker without turning it on/off", Usefulness.Important),
            ];
            ConfirmationTests = [
                "Leave a EMF reader at the breaker and check if it goes off. If it goes off without interacting with anything, it is a Jinn",
                ];
            Abilities = [
                "When the breaker is on, it can drop nearby players' sanities by 25% leaving EMF 2/5 at breaker"
                ];
            RuleOuts = [
                "Cannot turn off the breaker",
                ];
            DefaultFootstepSpeed = 1.7;
            ConditionalFootstepSpeed = [2.5];
            ExclusiveEvents = [GhostEvents.EMFAtBreakerWithoutTurningOnOrOff];
            RuleOutEvents = [GhostEvents.GhostTurnedOffBreaker];
        }
    }
}
