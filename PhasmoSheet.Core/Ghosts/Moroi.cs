using PhasmoSheet.Core.Common;

namespace PhasmoSheet.Core.Ghosts
{
    public class Moroi : Ghost
    {
        public Moroi()
        {

            Name = "Moroi";
            Evidences = [Evidence.SpiritBox, Evidence.GhostWriting, Evidence.FreezingTemperatures];
            GuaranteedEvidence = Evidence.SpiritBox;
            MinSanityPercentage = 50;
            ConditionalSanityPercentages = [];
            DefaultFootstepSpeed = 1.7;
            ConditionalFootstepSpeed = [2.25, 3.71];
            HasStandardLOSAccel = true;
            Tells = ["Places a curse on player when heard through parabolic microphone, causing sanity to drop 2x as fast", "Speeds up the lower the average sanity is, reaching up to 3.71m/s with LOS"];
            ConfirmationTests = ["If the ghost has its speed increased between hunts with LOS speed up, it is a Moroi",
            "If it takes the ghost longer than 5s to detect you after smudging, it is a Moroi",
            "If the ghost slows down during a hunt after taking sanity medication, it is a Moroi"];
            Abilities = [];
            ExclusiveEvents = [];
            RuleOutEvents = [];
        }
    }
}
