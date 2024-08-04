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
                new("Has 6 fingered fingerprints on doors", Usefulness.Important),
                new("Has 2 finger fingerprints on light switches", Usefulness.Important),
                "Has a chance to change models for a single blink during hunts"
            ];

        }
    }
}
