using Projektarbeit_EDV_Messung_Lib.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projektarbeit_EDV_Messung_Lib.Services
{
    public class MessungService : IMessungService
    {

        private SQLiteAsyncConnection _dbConnection;

        public MessungService()
        {
            SetUpDb();
        }


        private async void SetUpDb()
        {
            if (_dbConnection == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Messungen.db3");
                _dbConnection = new SQLiteAsyncConnection(dbPath);
                await _dbConnection.CreateTableAsync<MessungsModel>();
            }
        }



        public async Task<int> AddMessungAsync(MessungsModel messung)
        {
            return await _dbConnection.InsertAsync(messung);
        }



        public async Task<int> DeleteMessungAsync(MessungsModel messung)
        {
            return await _dbConnection.DeleteAsync(messung);
        }

        public async Task<List<MessungsModel>> GetAllMessungenAsync()
        {
            return await _dbConnection.Table<MessungsModel>().ToListAsync();
        }

        public async Task<int> UpdateMessungAsync(MessungsModel messung)
        {
            return await _dbConnection.UpdateAsync(messung);
        }
    }
}
