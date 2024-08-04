using PhasmoSheet.Core.Common;

namespace PhasmoSheet.Core.Ghosts
{
    public class Obake : Ghost
    {
        public Obake()
        {
            Name = "Obake";
            Evidences = new[] { Evidence.EMF5, Evidence.Ultraviolet, Evidence.GhostOrb };
            GuaranteedEvidence = Evidence.Ultraviolet;
            MinSanityPercentage = 50;
            Tells =
            [
                new("Has 6 fingered handprints on doors (~16.7%", Usefulness.Important),
                new("Has double fingerprints on light switches (~16.7%)", Usefulness.Important),
                "Has a chance to change models for a single blink during hunts (6.67%)",
                "25% chance to not leave fingerprints on doors and light switches",
            ];
            Abilities =
            [
                "Can make fingerprints disappear twice as fast",
            ];
            DefaultFootstepSpeed = 1.7;
            HasStandardLOSAccel = true;
            ExclusiveEvents = [GhostEvents.Showing6FingeredHand];
        }
    }
}
