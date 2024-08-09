using PhasmoSheet.Core.Common;

namespace PhasmoSheet.Core.Ghosts
{
    public class Banshee : Ghost
    {
        public Banshee()
        {
            Name = "Banshee";
            Evidences = new[] { Evidence.Ultraviolet, Evidence.GhostOrb, Evidence.DOTSProjector };
            MinSanityPercentage = 50;
            ConditionalSanityPercentages = [12, 87];
            Tells =
            [
                new("Unique scream in Parabolic Microphone", Usefulness.Important),
                "Hunts based on target's sanity instead of average sanity",
                "Only chases after one player at a time",
                "Prefers singing events"
            ];
            ConfirmationTests = [
                new("Listen to the ghost using the Parabolic Microphone. If the ghost has the unique screams, it is a Banshee", Usefulness.Important)
                ];

            Abilities =
            [
                "Roams towards target without leaving EMF",
            ];
            DefaultFootstepSpeed = 1.7;
            HasStandardLOSAccel = true;
            ExclusiveEvents = [GhostEvents.ExclusiveScreamInParamic];
        }
    }
}
