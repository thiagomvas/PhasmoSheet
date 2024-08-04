namespace PhasmoSheet.Core.Common
{
    public static class Format
    {
        public static string Evidence(Evidence evidence)
        {
            return evidence switch
            {
                Common.Evidence.EMF5 => "EMF 5",
                Common.Evidence.Ultraviolet => "Ultraviolet",
                Common.Evidence.GhostOrb => "Ghost Orb",
                Common.Evidence.GhostWriting => "Ghost Writing",
                Common.Evidence.SpiritBox => "Spirit Box",
                Common.Evidence.FreezingTemperatures => "Freezing Temperatures",
                Common.Evidence.DOTSProjector => "DOTS Projector",
                _ => "Unknown"
            };
        }

        public static string GhostEvent(GhostEvents e)
        {
            return e switch
            {
                GhostEvents.GhostTurnedOffBreaker => "Ghost turned off breaker",
                GhostEvents.GhostTurnedOnBreaker => "Ghost turned on breaker",
                GhostEvents.GhostTurnedOnLightSwitch => "Ghost turned on light switch",
                GhostEvents.AirballEvent => "Airball event",
                GhostEvents.GhostShowedFootprints => "Ghost showed footprints",
                GhostEvents.HuntedInSameRoomAsPlayer => "Hunted in same room as player",
                GhostEvents.HuntedWithin3mOfLitCandle => "Hunted within 3m of lit candle",
                GhostEvents.HuntedWithin5mOfCrucifix => "Hunted within 5m of crucifix",
                GhostEvents.LeftRoomWithin90sOfSmudge => "Left room within 90s of smudge",
                GhostEvents.EMFAtBreakerWithoutTurningOnOrOff => "EMF at breaker without turning on or off",
                GhostEvents.InteractingWith2ThingsInSeparateRoomsWithinSplitSecond => "Interacting with 2 things in separate rooms within split second",
                GhostEvents.HuntingUponBlowingCandle => "Hunting upon blowing candle",
                GhostEvents.TeleportingToPlayer => "Teleporting to player",
                GhostEvents.ShowingBreathDuringHunt => "Showing breath during hunt",
                GhostEvents.DisappearedDuringPhoto => "Disappeared during photo",
                GhostEvents.Showing6FingeredHand => "Showing 6-fingered hand",
                GhostEvents.ThrowingObjectsFar => "Throwing objects far",
                GhostEvents.ThrowingMultipleObjectsAtOnce => "Throwing multiple objects at once",
                GhostEvents.ExclusiveScreamInParamic => "Exclusive scream in paramic",
                GhostEvents.ClosingADoorQuickly => "Closing a door quickly",
                GhostEvents.ShowingUpAsShadowInSummoningCircle => "Showing up as shadow in summoning circle",
                GhostEvents.TurnsOffBreakerFrequently => "Turns off breaker frequently",
                GhostEvents.GhostIsVisibleInPhoto => "Ghost is visible in photo",
                GhostEvents.FavoriteRoomChanged => "Favorite room changed",
                GhostEvents.BreathingHeavilyAsSpiritBoxResponse => "Breathing heavily as spirit box response",
                _ => e.ToString()
            };

        }
    }
}
