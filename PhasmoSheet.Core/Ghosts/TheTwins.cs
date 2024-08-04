using PhasmoSheet.Core.Common;

namespace PhasmoSheet.Core.Ghosts
{
    public class TheTwins : Ghost
    {
        public TheTwins()
        {

            Name = "The Twins";
            Evidences = [Evidence.EMF5, Evidence.SpiritBox, Evidence.FreezingTemperatures];
            GuaranteedEvidence = null;
            MinSanityPercentage = 50;
            ConditionalSanityPercentages = [];
            DefaultFootstepSpeed = 1.53;
            ConditionalFootstepSpeed = [1.87];
            HasStandardLOSAccel = true;
            Tells = ["Can do 2 interactions at the same time, one within 3m and another within 16m"];
            ConfirmationTests = ["If two objects are thrown in different rooms within a split second of each other, it is The Twins",
            "If there are interactions far from the ghost room frequently, it COULD be the Twins"];
            Abilities = [];
            ExclusiveEvents = [GhostEvents.InteractingWith2ThingsInSeparateRoomsWithinSplitSecond];
            RuleOutEvents = [];
        }
    }
}
