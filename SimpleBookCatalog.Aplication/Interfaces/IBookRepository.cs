﻿
using SimpleBookCatalog.Domain.Entities;

namespace SimpleBookCatalog.Aplication.Interfaces
{
    public interface IBookRepository
    {
        Task AddAsync(Book book);

        Task<List<Book>> GetAllAsync();

        Task<Book?> GetByIdAsync(int id);

        Task UpdateAsync(Book book);

        Task DeleteByIdAsync(int id);
    }
}
