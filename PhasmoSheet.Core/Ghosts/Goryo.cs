using PhasmoSheet.Core.Common;

namespace PhasmoSheet.Core.Ghosts
{
    public class Goryo : Ghost
    {
        public Goryo()
        {

            Name = "Goryo";
            Evidences = [Evidence.EMF5, Evidence.Ultraviolet, Evidence.DOTSProjector];
            GuaranteedEvidence = Evidence.DOTSProjector;
            MinSanityPercentage = 50;
            ConditionalSanityPercentages = [];
            DefaultFootstepSpeed = 1.7;
            ConditionalFootstepSpeed = [];
            HasStandardLOSAccel = true;
            Tells = [
                new("DOTs will only be visible through a camera if no players are nearby.", Usefulness.Important),
                new("Cannot change favorite rooms", Usefulness.High),
            new("Does not wander from its room often", Usefulness.High)];
            ConfirmationTests = [];
            RuleOuts = [new("If the ghost is visible through DOTs while in the same room, it is not a Goryo", Usefulness.Important),
                new("If the ghost changes the favorite room, it is not a Goryo", Usefulness.High)];
            Abilities = [];
            ExclusiveEvents = [];
            RuleOutEvents = [GhostEvents.FavoriteRoomChanged];
        }
    }
}
