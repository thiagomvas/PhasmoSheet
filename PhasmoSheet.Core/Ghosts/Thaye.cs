using PhasmoSheet.Core.Common;

namespace PhasmoSheet.Core.Ghosts
{
    public class Thaye : Ghost
    {
        public Thaye()
        {

            Name = "Thaye";
            Evidences = [Evidence.GhostOrb, Evidence.GhostWriting, Evidence.DOTSProjector];
            GuaranteedEvidence = null;
            MinSanityPercentage = 75;
            ConditionalSanityPercentages = [15];
            DefaultFootstepSpeed = 1;
            ConditionalFootstepSpeed = [2.75];
            HasStandardLOSAccel = false;
            Tells = [new("Ages over time every 1-2 minutes near the player.", Usefulness.Important), "More active when younger"];
            ConfirmationTests = [new("If you have an Ouija Board, ask the age. Ask again after sometime. If the number increases then its a Thaye", Usefulness.Important),
                "If the ghost slows down between hunts and has no LOS, it is a Thaye"];
            Abilities = [];
            ExclusiveEvents = [];
            RuleOutEvents = [];
        }
    }
}
