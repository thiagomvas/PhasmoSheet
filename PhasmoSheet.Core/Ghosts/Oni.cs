using PhasmoSheet.Core.Common;
using System.Xml.Linq;

namespace PhasmoSheet.Core.Ghosts
{
    public class Oni : Ghost
    {
        public Oni()
        {

            Name = "Oni";
            Evidences = [Evidence.EMF5, Evidence.FreezingTemperatures, Evidence.DOTSProjector];
            GuaranteedEvidence = null;
            MinSanityPercentage = 50;
            ConditionalSanityPercentages = [];
            DefaultFootstepSpeed = 1.7;
            ConditionalFootstepSpeed = [];
            HasStandardLOSAccel = true;
            Tells = ["Blinks more frequently during hunts, making it more visible", "Extremely frequent physically manifested ghost events", "Throws objects far"];
            ConfirmationTests = ["Watch the ghost during a hunt, if its more visible than normal, it is an Oni",
            "Check the sanity monitor after a ghost event. If it dropped by 20% instead of 10%, then it is an Oni"];
            RuleOuts = [
                new("If it does the Airball event, it is not an Oni", Usefulness.High),
                ];
            Abilities = [];
            ExclusiveEvents = [GhostEvents.ThrowingObjectsFar];
            RuleOutEvents = [GhostEvents.AirballEvent];
        }
    }
}
