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
            ConfirmationTests =
            [
                new("If the ghost walks through a salt pile without disturbing during a hunt, it is a Wraith", Usefulness.Important),
                new("Place salt below a Tier 1/2 Motion sensor. If the sensor is triggered but salt is not disturbed, it is a Wraith", Usefulness.Important),
            ];
            Abilities =
            [
                "Can teleport to a random player, leaving either EMF 2 or EMF5 at the location"
            ];
            RuleOuts = [
                new("If the ghost disturbed salt in any way, it is not a Wraith", Usefulness.Important),
                ];
            DefaultFootstepSpeed = 1.7;
            HasStandardLOSAccel = true;
            RuleOutEvents = [GhostEvents.GhostShowedFootprints];
            ExclusiveEvents = [GhostEvents.TeleportingToPlayer];
        }
    }

}
