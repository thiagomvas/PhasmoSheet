using PhasmoSheet.Core.Common;
using System.Reflection;

namespace PhasmoSheet.Core.Ghosts
{
    public class Ghost
    {
        public string Name { get; set; }
        public Evidence[] Evidences { get; set; } = [];
        public Evidence? GuaranteedEvidence { get; set; }
        public int MinSanityPercentage { get; set; }
        public int[] ConditionalSanityPercentages { get; set; } = [];
        public double DefaultFootstepSpeed { get; set; }
        public double[] ConditionalFootstepSpeed { get; set; } = [];
        public bool HasStandardLOSAccel { get; set; }
        public Information[] Tells { get; set; } = [];
        public Information[] RuleOuts { get; set; } = [];
        public Information[] ConfirmationTests { get; set; } = [];
        public Information[] Abilities { get; set; } = [];

        public GhostEvents[] RuleOutEvents { get; set; } = [];
        public GhostEvents[] ExclusiveEvents { get; set; } = [];

        public Ghost()
        {
            Name = "";
            Evidences = [];
            GuaranteedEvidence = null;
            MinSanityPercentage = 50;
            ConditionalSanityPercentages = [];
            DefaultFootstepSpeed = 1.7;
            ConditionalFootstepSpeed = [];
            HasStandardLOSAccel = true;
            Tells = [];
            ConfirmationTests = [];
            Abilities = [];
            ExclusiveEvents = [];
            RuleOutEvents = [];
        }

        public string FormatConditionalSanities()
        {
            var result = "";
            if (ConditionalSanityPercentages.Length > 0)
                result += " | ";
            foreach (var sanity in ConditionalSanityPercentages)
            {
                result += $"{sanity}%, ";
            }
            return result.TrimEnd(',');
        }
        public string FormatAdditionalSpeeds()
        {
            var result = "";
            if (ConditionalFootstepSpeed.Length > 0)
                result += " | ";
            foreach (var speed in ConditionalFootstepSpeed)
            {
                result += $"{speed} m/s, ";
            }
            return result.TrimEnd(',');
        }
        public static List<Ghost> GetAll()
        {
            return Assembly.GetAssembly(typeof(Ghost))!.GetTypes()
                .Where(t => t.IsSubclassOf(typeof(Ghost)))
                .Select(t => (Ghost)Activator.CreateInstance(t)!)
                .Where(t => t != null)
                .ToList() ?? [];
        }

        public static List<Ghost> Filter(List<Ghost> ghosts, params Evidence[] evidences)
        {
            return ghosts.Where(g => g.Evidences.Intersect(evidences).Count() == evidences.Count()).ToList();
        }

        public static List<Ghost> Filter(List<Ghost> ghosts, params GhostEvents[] events)
        {
            return ghosts.Where(g => g.RuleOutEvents.Intersect(events).Count() == 0).ToList();
        }


    }
}
