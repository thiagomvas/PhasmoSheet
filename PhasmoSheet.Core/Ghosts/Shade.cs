using PhasmoSheet.Core.Common;

namespace PhasmoSheet.Core.Ghosts
{
    public class Shade : Ghost
    {
        public Shade()
        {
            Name = "Shade";
            Evidences = new[] { Evidence.EMF5, Evidence.GhostWriting, Evidence.FreezingTemperatures };
            MinSanityPercentage = 35;
            DefaultFootstepSpeed = 1.7;
            HasStandardLOSAccel = true;
            Tells = [
                "Shade will never hunt if its in the same room as a player",
                "Shade will not do events that trigger EMF in the same room as player, "
                ];
            ConfirmationTests = [
                new("If you have a summoning circle, light it. If the ghost is a shadow or is translucent, it is a Shade", Usefulness.Important),
                ];
            RuleOuts = [
                "If the ghost atempts hunts while players are in the same room, it is not a Shade",
                "If the ghost does events that trigger EMF (excluding Writing and blowing candles) while players are in the same room, it is not a Shade",
                "If the ghost attempted to hunt above 35% average sanity, it is not a Shade",
                ];
            ExclusiveEvents = [GhostEvents.ShowingUpAsShadowInSummoningCircle];
            RuleOutEvents = [GhostEvents.HuntedInSameRoomAsPlayer];
        }
    }
}
