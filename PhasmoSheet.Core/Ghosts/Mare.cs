using PhasmoSheet.Core.Common;

namespace PhasmoSheet.Core.Ghosts
{
    public class Mare : Ghost
    {
        public Mare()
        {
            Name = "Mare";
            Evidences = new[] { Evidence.SpiritBox, Evidence.GhostOrb, Evidence.GhostWriting };
            MinSanityPercentage = 60;
            Tells =
            [
                new("Can immediately turn off a light switch that a player has turned on if within 4m of the ghost", Usefulness.Important),
                "Won't hunt until 40% average sanity if its current room is lit up. 60% Otherwise.",
            ];
            ConfirmationTests = [
                "Turn off the lights and check if the ghost is more active. If it is, it is a Mare",
                ];
            Abilities =
            [
                "Increased chance of attack in the dark",
                "Decreased chance of attack in the light"
            ];
            RuleOuts = [
                new("If the ghost turned on the light switch, it is not a Mare", Usefulness.High)
                ];
            DefaultFootstepSpeed = 1.7;
            HasStandardLOSAccel = true;
            RuleOutEvents = [GhostEvents.GhostTurnedOnLightSwitch];
        }
    }
}
