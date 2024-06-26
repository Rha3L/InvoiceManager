﻿using Server.Domain.Entities;
using Server.Application.Income.Dtos;

namespace Server.Domain.Repositories
{
    public interface IIncomeRepository
    {
        Task<List<Income>> GetAllAsync(QueryObject query);
        Task<Income?> GetByIdAsync(int id);
        Task<Income> CreateAsync(Income invoiceEntity);
        Task<Income?> UpdateAsync(int id, IncomeUpdateDto invoiceDto);
        Task<Income?> DeleteAsync(int id);
    }
}