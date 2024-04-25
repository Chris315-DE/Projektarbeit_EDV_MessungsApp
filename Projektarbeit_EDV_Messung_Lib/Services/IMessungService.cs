using Projektarbeit_EDV_Messung_Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit_EDV_Messung_Lib.Services
{
    public interface IMessungService
    {

        Task<List<MessungsModel>> GetAllMessungenAsync();

        Task<int> AddMessungAsync(MessungsModel messung);

        Task<int> UpdateMessungAsync(MessungsModel messung);

        Task<int> DeleteMessungAsync(MessungsModel messung);
    }
}
