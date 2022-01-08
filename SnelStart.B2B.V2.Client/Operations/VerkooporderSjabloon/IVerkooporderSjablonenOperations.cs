using System;
using System.Threading.Tasks;

namespace SnelStart.B2B.V2.Client.Operations
{
    public interface IVerkooporderSjablonenOperations : IGetAllOperations<VerkooporderSjabloonModel>
    {
        Task<Response<VerkooporderSjabloonModel>> GetByIdAsync(Guid id);
    }
}
