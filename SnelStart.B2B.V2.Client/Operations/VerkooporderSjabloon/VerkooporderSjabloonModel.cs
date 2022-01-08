namespace SnelStart.B2B.V2.Client.Operations
{
    /// <summary>
    /// De gegevenscontainer voor een verkoopordersjabloon.
    /// </summary>
    public class VerkooporderSjabloonModel : IdentifierModel
    {
        /// <summary>
        /// Geeft de naam van deze gegevenscontainer terug.
        /// </summary>
        public const string ResourceName = "verkoopordersjablonen";

        /// <summary>
        /// Geeft een instantie van een <see cref="VerkooporderSjabloonModel"/> terug.
        /// </summary>
        public VerkooporderSjabloonModel() : base(ResourceName)
        {
        }

        public string Omschrijving { get; set; }

        public bool NonActief { get; set; }

        public bool PrijsIngaveExclusiefBtw { get; set; }

        public bool NieuweOrdersBlokkeren { get; set; }

        public VerkooporderSjabloonExtraVeldModel[] ExtraHoofdVelden { get; set; } = new VerkooporderSjabloonExtraVeldModel[0];

        public VerkooporderSjabloonExtraVeldModel[] ExtraRegelVelden { get; set; } = new VerkooporderSjabloonExtraVeldModel[0];
    }
}
