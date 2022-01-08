using System;
using System.Threading;
using System.Threading.Tasks;

namespace SnelStart.B2B.V2.Client.Operations
{
    class VerkooporderSjablonenOperations : CrudOperationsBase<VerkooporderSjabloonModel>, IVerkooporderSjablonenOperations
    {
        public VerkooporderSjablonenOperations(ClientState clientState)
            : base(clientState, VerkooporderSjabloonModel.ResourceName)
        { }

        public Task<Response<VerkooporderSjabloonModel[]>> GetAllAsync() => GetAllAsync(CancellationToken.None);
        public Task<Response<VerkooporderSjabloonModel[]>> GetAllAsync(CancellationToken cancellationToken) => ClientState.ExecuteGetAllAsync<VerkooporderSjabloonModel>(ResourceName, cancellationToken);
        public new Task<Response<VerkooporderSjabloonModel>> GetByIdAsync(Guid id, CancellationToken cancellationToken) => ClientState.ExecuteGetByIdAsync<VerkooporderSjabloonModel>(ResourceName, id, cancellationToken);
    }
}
