using PhasmoSheet.Core.Common;

namespace PhasmoSheet.Core.Ghosts
{
    public class Wraith : Ghost
    {
        public Wraith()
        {
            Name = "Wraith";
            Evidences = new[] { Evidence.EMF5, Evidence.SpiritBox, Evidence.DOTSProjector };
            MinSanityPercentage = 50;
            Tells =
            [
                new("Never steps in salt", Usefulness.Important),
            "Will not be slowed down by tier 3 salt during a hunt",

        ];
            Abilities =
            [
                "Can teleport to a random player, leaving either EMF 2 or EMF5 at the location"
            ];
            DefaultFootstepSpeed = 1.7;
            HasStandardLOSAccel = true;
            RuleOutEvents = [GhostEvents.GhostShowedFootprints];
            ExclusiveEvents = [GhostEvents.TeleportingToPlayer];
        }
    }

}
