using PhasmoSheet.Core.Common;

namespace PhasmoSheet.Core.Ghosts
{
    public class Phantom : Ghost
    {
        public Phantom()
        {
            Name = "Phantom";
            Evidences = new[] { Evidence.SpiritBox, Evidence.Ultraviolet, Evidence.DOTSProjector };
            MinSanityPercentage = 50;
            Tells =
            [
                new("Will not appear in ghost photos", Usefulness.High),
                new("Taking a photo of the Phantom causes it to disappear (including DOTs)", Usefulness.High),
                "Less visible during hunts",
                new("Player will lose 0.5% sanity per second while in heartbeat range", Usefulness.Important)
            ];
            Abilities =
            [
                "Occasionaly roams to a random player leaving EMF2 where it wanders to"
            ];
            DefaultFootstepSpeed = 1.7;
            HasStandardLOSAccel = true;
            ExclusiveEvents = [GhostEvents.DisappearedDuringPhoto];
            RuleOutEvents = [GhostEvents.GhostIsVisibleInPhoto];
        }
    }

}
