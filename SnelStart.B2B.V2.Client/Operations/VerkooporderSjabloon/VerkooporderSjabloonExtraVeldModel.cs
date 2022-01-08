namespace SnelStart.B2B.V2.Client.Operations
{
    public class VerkooporderSjabloonExtraVeldModel
    {
        public int VeldNummer { get; set; }

        /// <summary>
        /// Omschrijving van het ordersjabloon extra regel.
        /// </summary>
        public string Omschrijving { get; set; }

        public string IngaveMasker { get; set; }

        public string SoortVeld { get; set; }

        public int MaximumTekstLengte { get; set; }
    }
}
