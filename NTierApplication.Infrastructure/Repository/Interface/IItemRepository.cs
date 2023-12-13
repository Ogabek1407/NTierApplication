using Microsoft.EntityFrameworkCore;
using NTierApplication.Domain.Models;

namespace NTierApplication.Inffrastructure.Repository.Interface;

public interface IItemRepository
{
    void Add(Item item);
    void Update(Item item);
    void Delete(Item item);
    IQueryable<Item> GetAll();
    void SaveChanges();
}