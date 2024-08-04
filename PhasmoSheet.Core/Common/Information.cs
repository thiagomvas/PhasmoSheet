namespace PhasmoSheet.Core.Common
{
    public struct Information
    {
        public string Info { get; set; }
        public Usefulness Usefulness { get; set; }

        public Information(string info, Usefulness usefulness)
        {
            Info = info;
            Usefulness = usefulness;
        }

        public static implicit operator Information(string info) => new Information { Info = info, Usefulness = Usefulness.Medium };
        public static implicit operator string(Information info) => info.Info;

        public override string ToString()
        {
            return Info;
        }
    }
}
