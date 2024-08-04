using PhasmoSheet.Core.Common;

namespace PhasmoSheet.Core.Ghosts
{
    public class Yokai : Ghost
    {
        public Yokai()
        {

            Name = "Yokai";
            Evidences = [Evidence.SpiritBox, Evidence.GhostOrb, Evidence.DOTSProjector];
            GuaranteedEvidence = null;
            MinSanityPercentage = 50;
            ConditionalSanityPercentages = [80];
            DefaultFootstepSpeed = 1.7;
            ConditionalFootstepSpeed = [];
            HasStandardLOSAccel = true;
            Tells = [
                "It will be more active when talking near it",
                "Can only hear you from 2.5m. Range is reduced during hunts",
            "Will start event at 2.5m from music box instead of 5m"];
            ConfirmationTests = [
                new("If you have a music box, use a tier 3 crucifix to see the 5m range. Activate the box and place it on the crucifix, if the ghost appears within the range of the crucifix it is a Yokai.", Usefulness.High),
                "During a hunt, speak while at a distance where a ghost would hear you. If the ghost doesn't detect you, it is a Yokai."];
            Abilities = ["Talking near a Yokai can cause it to hunt with 80% average sanity or below"];
            ExclusiveEvents = [];
            RuleOutEvents = [];
        }

    }
}
