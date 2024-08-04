using PhasmoSheet.Core.Common;

namespace PhasmoSheet.Core.Ghosts
{
    public class Ghost
    {
        public string Name { get; set; }
        public Evidence[] Evidences { get; set; } = [];
        public Evidence? GuaranteedEvidence { get; set; }
        public int MinSanityPercentage { get; set; }
        public int[] ConditionalSanityPercentages { get; set; } = [];
        public double DefaultFootstepSpeed { get; set; }
        public double LOSFootstepSpeed { get; set; }
        public Information[] Tells { get; set; } = [];
        public Information[] RuleOuts { get; set; } = [];
        public Information[] ConfirmationTests { get; set; } = [];
        public Information[] Abilities { get; set; } = [];
    }
}
