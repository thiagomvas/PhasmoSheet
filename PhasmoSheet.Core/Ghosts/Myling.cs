using PhasmoSheet.Core.Common;

namespace PhasmoSheet.Core.Ghosts
{
    public class Myling : Ghost
    {
        public Myling()
        {

            Name = "Myling";
            Evidences = [Evidence.EMF5, Evidence.Ultraviolet, Evidence.GhostWriting];
            GuaranteedEvidence = null;
            MinSanityPercentage = 50;
            ConditionalSanityPercentages = [];
            DefaultFootstepSpeed = 1.7;
            ConditionalFootstepSpeed = [];
            HasStandardLOSAccel = true;
            Tells = ["Increased number of sounds through the parabolic microphone"];
            ConfirmationTests = ["During a hunt, if you cannot hear the ghost between 12m and 20m away, it is a Myling"];
            Abilities = [];
            ExclusiveEvents = [];
            RuleOutEvents = [];
        }
    }
}
