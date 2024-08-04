using PhasmoSheet.Core.Common;

namespace PhasmoSheet.Core.Ghosts
{
    public class TheMimic : Ghost
    {
        public TheMimic()
        {

            Name = "The Mimic";
            Evidences = [Evidence.SpiritBox, Evidence.Ultraviolet, Evidence.FreezingTemperatures, Evidence.GhostOrb];
            GuaranteedEvidence = Evidence.GhostOrb;
            MinSanityPercentage = 50;
            ConditionalSanityPercentages = [12, 100];
            DefaultFootstepSpeed = 1.7;
            ConditionalFootstepSpeed = [];
            HasStandardLOSAccel = true;
            Tells = ["Will always show ghost orbs as an ADDITIONAL evidence."];
            ConfirmationTests = ["If the ghost shows more evidence than the difficult allows (eg 4 evidences in total, Ghost Orbs in 0 evidence difficulties, etc), it is a Mimic"];
            Abilities = ["Changes behaviour every 30s-2m to copy another ghost"];
            RuleOuts = ["If the favorite room does not show Ghost Orbs, it is not The Mimic"];
            ExclusiveEvents = [];
            RuleOutEvents = [];
        }
    }
}
