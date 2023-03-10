using Emilia_Morejon_ExamenP3.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Android.Content.ClipData;

namespace Emilia_Morejon_ExamenP3.Data
{
    public class DatabaseServiceEM
    {
        private readonly SQLiteAsyncConnection _database;
        public DatabaseServiceEM(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Root>().Wait();
        }

        public Task<List<Root>> ObtenerItemsAsync()
        {
            return _database.Table<Root>().ToListAsync();
        }

        public Task<int> GuardarItemAsync(Root root)
        {
            return _database.InsertAsync(root);
        }

    }
}
