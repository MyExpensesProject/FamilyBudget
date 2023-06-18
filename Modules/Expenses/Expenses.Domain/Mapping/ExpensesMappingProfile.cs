using AutoMapper;
using Expenses.Domain.Dto;
using Expenses.Domain.Entities;

namespace Expenses.Domain.Mapping;

/// <summary>
/// Expense mapping profile
/// </summary>
public class ExpensesMappingProfile : Profile
{
    /// <summary>
    /// Expense mapping profile
    /// </summary>
    public ExpensesMappingProfile()
    {
        CreateMap<ExpenseDto, ExpenseEntity>();
        CreateMap<ExpenseEntity, ExpenseDto>();
        
        CreateMap<ExpenseTypeEntity, ExpenseTypeDto>();
        CreateMap<ExpenseTypeDto, ExpenseTypeEntity>();
    }
}