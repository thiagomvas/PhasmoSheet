using PhasmoSheet.Core.Common;

namespace PhasmoSheet.Core.Ghosts
{
    public class Yurei : Ghost
    {
        public Yurei()
        {
            Name = "Yurei";
            Evidences = [];
            GuaranteedEvidence = null;
            MinSanityPercentage = 50;
            ConditionalSanityPercentages = [];
            DefaultFootstepSpeed = 1.7;
            ConditionalFootstepSpeed = [];
            HasStandardLOSAccel = true;
            Tells = [
                new("Only ghost that interacts with the exit outside of a hunt/event", Usefulness.Important)
                ];
            ConfirmationTests = [
                "Place sensors in the entrances to the room and smudge the ghost. If the ghost leaves the room within 90s, it is NOT a Yurei"];
            Abilities = [
                new("Can shut a door very quickly behind the player", Usefulness.High)
                ];
            RuleOuts = [
                "If the ghost leaves the room within 90s of a smudge, it is not a Yurei"
                ];
            ExclusiveEvents = [GhostEvents.ClosingADoorQuickly];
            RuleOutEvents = [GhostEvents.LeftRoomWithin90sOfSmudge];
        }
    }
}
