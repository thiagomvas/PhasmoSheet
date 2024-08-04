using PhasmoSheet.Core.Common;

namespace PhasmoSheet.Core.Ghosts
{
    public class Raiju : Ghost
    {
        public Raiju()
        {

            Name = "Raiju";
            Evidences = [Evidence.EMF5, Evidence.GhostOrb, Evidence.DOTSProjector];
            GuaranteedEvidence = null;
            MinSanityPercentage = 50;
            ConditionalSanityPercentages = [65];
            DefaultFootstepSpeed = 1.7;
            ConditionalFootstepSpeed = [2.5];
            HasStandardLOSAccel = true;
            Tells = ["The ghost can hunt at 65% sanity when near active electronic equipments"];
            ConfirmationTests = ["If the ghost speeds up when near active equipment, it is a Raiju"];
            Abilities = [];
            ExclusiveEvents = [];
            RuleOuts = ["If the ghost does not speed up when near active equipment, it is not a Raiju"];
            RuleOutEvents = [];
        }
    }
}
