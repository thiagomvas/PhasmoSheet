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
    }
}
