using PhasmoSheet.Core.Common;

namespace PhasmoSheet.Core.Ghosts
{
    public class Poltergeist : Ghost
    {
        public Poltergeist()
        {
            Name = "Poltergeist";
            Evidences = new[] { Evidence.SpiritBox, Evidence.GhostWriting, Evidence.Ultraviolet };
            MinSanityPercentage = 50;
            Tells =
            [
                new Information("Throws items every 0.5s with increased force during hunts", Usefulness.Important),
                "Higher chance to throw and interact with objects",
            ];
            ConfirmationTests =
            [
                "Place multiple items in one spot. If the ghost throws multiple or all of them at once, it is a Poltergeist",
                "Place items in a line where the ghost will walk through during a hunt, if they are thrown far, it is a Poltergeist"
            ];
            Abilities =
            [
                new Information("Poltergeist Explosion - Throws multiple objects at once, decreasing sanity by 2% per item thrown", Usefulness.Important),
            ]
            ;
            DefaultFootstepSpeed = 1.7;
            HasStandardLOSAccel = true;
            ExclusiveEvents = [GhostEvents.ThrowingObjectsFar, GhostEvents.ThrowingMultipleObjectsAtOnce,];
        }
    }
}
