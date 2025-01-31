﻿using System;
using System.Threading;
using System.Threading.Tasks;
using SnelStart.B2B.V2.Client.Operations;

namespace SnelStart.B2B.V2.Client
{
    public interface IB2BClient : IDisposable
    {
        ICompanyInformationOperations CompanyInformation { get; }
        IKasboekingenOperations Kasboekingen { get; }
        IKostenplaatsenOperations Kostenplaatsen { get; }
        IGrootboekenOperations Grootboeken { get; }
        IGrootboekMutatiesOperations GrootboekMutaties { get; }
        ILandenOperations Landen { get; }
        IMemoriaalboekingenOperations Memoriaalboekingen { get; }
        IDagboekenOperations Dagboeken { get; }
        IRelatiesOperations Relaties { get; }
        IVerkoopboekingenOperations Verkoopboekingen { get; }
        IVerkoopboekingBijlagesOperations VerkoopboekingBijlages { get; }
        IVerkoopfacturenOperations Verkoopfacturen { get; }
        IInkoopfacturenOperations Inkoopfacturen { get; }
        IBankboekingenOperations Bankboekingen{ get; }
        IBankafschriftBestandenOperations BankafschriftBestanden { get; }
        IInkoopboekingenOperations Inkoopboekingen { get; }
        IRelatieInkoopboekingenOperations RelatieInkoopboekingen { get; }
        IInkoopBoekingBijlagesOperations InkoopboekingBijlages { get; }
        IRelatieBijlagesOperations RelatieBijlages { get; }
        IVerkoopordersOperations Verkooporders { get; }
        IArtikelenOperations Artikelen { get; }
        IVerkooporderSjablonenOperations VerkooporderSjablonen { get; }

        Task AuthorizeAsync();
        Task AuthorizeAsync(CancellationToken cancellationToken);
    }
}