using System.Threading;
using System.Threading.Tasks;

namespace SnelStart.B2B.V2.Client.Operations
{
    internal class BankafschriftBestandenOperations :
        IBankafschriftBestandenOperations
    {
        public BankafschriftBestandenOperations(ClientState clientState)
        {
            ClientState = clientState;
        }

        public ClientState ClientState { get; }

        public Task<Response<BankafschriftBestandResponse[]>> ReadBankafschriftBestandenAsync(BankafschriftBestand[] bestanden)
        {
            return ReadBankafschriftBestandenAsync(bestanden, CancellationToken.None);
        }

        public Task<Response<BankafschriftBestandResponse[]>> ReadBankafschriftBestandenAsync(BankafschriftBestand[] bestanden, CancellationToken cancellationToken)
        {
            return ClientState.ExecutePostAsync<BankafschriftBestand[], BankafschriftBestandResponse[]>(BankafschriftBestand.ResourceName, bestanden, cancellationToken);
        }
    }
}