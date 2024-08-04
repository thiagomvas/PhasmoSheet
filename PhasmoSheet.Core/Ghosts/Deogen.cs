using PhasmoSheet.Core.Common;

namespace PhasmoSheet.Core.Ghosts
{
    public class Deogen : Ghost
    {
        public Deogen()
        {

            Name = "Deogen";
            Evidences = [Evidence.SpiritBox, Evidence.GhostWriting, Evidence.DOTSProjector];
            GuaranteedEvidence = Evidence.SpiritBox;
            MinSanityPercentage = 40;
            ConditionalSanityPercentages = [];
            DefaultFootstepSpeed = 0.4;
            ConditionalFootstepSpeed = [3.0];
            HasStandardLOSAccel = false;
            Tells = ["Is very fast but slows down when close to the player", "More visible during hunts", "Always has LOS, meaning you cannot hide"];
            ConfirmationTests = ["If the ghost speeds towards you but then slows down when near you, it is a Deogen", "If the ghost breathes heavily as a spirit box response, it is a Deogen"];
            Abilities = [];
            ExclusiveEvents = [GhostEvents.BreathingHeavilyAsSpiritBoxResponse];
            RuleOutEvents = [];
        }
    }
}
