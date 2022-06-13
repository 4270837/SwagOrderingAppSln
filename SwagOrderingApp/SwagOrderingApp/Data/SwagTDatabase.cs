using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SwagOrderingApp.Data
{
    public class SwagTDatabase
    {
        static SQLiteAsyncConnection Database;

        public static readonly AsyncLazy<SwagTDatabase> Instance = new AsyncLazy<SwagTDatabase>(async () =>
            {
                var instance = new SwagTDatabase();
                CreateTableResult result = await Database.CreateTableAsync<SwagT>();
                return instance;
            });

        public SwagTDatabase()
        {
            Database = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);
        }

        public Task<List<SwagT>> GetTsAsync()
        {
            return Database.Table<SwagT>().ToListAsync();
        }

        public Task<List<SwagT>> GetTsNotDoneAsync()
        {
            return Database.QueryAsync<SwagT>("SELECT * FROM [SwagT] WHERE [Save] = 0");
        }

        public Task<SwagT> GetSwagTAsync(int id) 
        { 
        return Database.Table<SwagT>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveTAsync(SwagT t)
        {
            if (t.ID != 0)
            {
                return Database.UpdateAsync(t);
            }

            else
            {
                return Database.InsertAsync(t);
            }
            
        }

        public Task<int> DeleteItemAsync(SwagT t) 
        {
            return Database.DeleteAsync(t);
        }
        
    }
}
