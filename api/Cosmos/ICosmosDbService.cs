﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace api.Cosmos
{
    public interface ICosmosDbService<T>
    {
        Task<IEnumerable<T>> GetItemsAsync(string query);
        Task<T> GetItemAsync(string id);
        Task AddItemAsync(string id, T item);
        Task UpdateItemAsync(string id, T item);
        Task DeleteItemAsync(string id);
    }
}