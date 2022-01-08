using System;

namespace SnelStart.B2B.V2.Client.Operations
{
    /// <summary>
    /// De gegevenscontainer voor een verwijzing naar een verkoopordersjabloon.
    /// </summary>
    public class VerkooporderSjabloonIdentifierModel : IdentifierModel
    {
        /// <summary>
        /// De gegevenscontainer voor een verwijzing naar een verkoopboeking.
        /// </summary>
        public VerkooporderSjabloonIdentifierModel() : base(VerkoopBoekingModel.ResourceName)
        {
        }

        internal VerkooporderSjabloonIdentifierModel(Guid id) : this()
        {
            Id = id;
        }
    }
}