using PhasmoSheet.Core.Common;

namespace PhasmoSheet.Core.Ghosts
{
    public class Spirit : Ghost
    {
        public Spirit()
        {
            Name = "Spirit";
            Evidences = new[] { Evidence.EMF5, Evidence.SpiritBox, Evidence.GhostWriting };
            MinSanityPercentage = 50;
            Tells =
            [
                "Incense prevents hunts for longer (double duration)"
            ];
            DefaultFootstepSpeed = 1.7;
            HasStandardLOSAccel = true;
        }
    }
}
