using PhasmoSheet.Core.Common;

namespace PhasmoSheet.Core.Ghosts
{
    public class Onryo : Ghost
    {
        public Onryo()
        {

            Name = "Onryo";
            Evidences = [Evidence.SpiritBox, Evidence.GhostOrb, Evidence.FreezingTemperatures];
            GuaranteedEvidence = null;
            MinSanityPercentage = 60;
            ConditionalSanityPercentages = [100];
            DefaultFootstepSpeed = 1.7;
            ConditionalFootstepSpeed = [];
            HasStandardLOSAccel = true;
            Tells = ["Can hunt at any sanity after extinguishing every 3rd flame",
            "Flames act like crucifixes, an Onryo will blow out a candle if it tries to hunt within 4m and prioritizes candles"];
            ConfirmationTests = [];
            Abilities = [];
            RuleOuts = [
                "Place a candle on top of a tier 3 crucifix. If the crucifix is used but the candle is not blown out, it is not an Onryo"
                ];
            ExclusiveEvents = [GhostEvents.HuntedWithin3mOfLitCandle, GhostEvents.HuntingUponBlowingCandle];
            RuleOutEvents = [];
        }
    }
}
