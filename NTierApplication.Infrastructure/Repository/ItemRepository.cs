using Microsoft.EntityFrameworkCore;
using NTierApplication.Domain.Models;
using NTierApplication.Inffrastructure.Repository.Interface;
using NTierApplication.Infrastructure.BdContext;
using System.Collections.Generic;

namespace NTierApplication.Inffrastructure.Repository;

public class ItemRepository:IItemRepository
{
    private readonly MainContext _context;

    public ItemRepository(MainContext context)
    {
        _context = context;
    }
    
    public void Add(Item item)
    {
        _context.Items.Add(item);
        _context.SaveChanges();
    }

    public void Update(Item item)
    {
        if (_context.Entry(item).State != EntityState.Modified)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }
    }

    public void Delete(Item item)
    {
        if (_context.Entry(item).State!= EntityState.Deleted)
        {
            _context.Items.Remove(item);
            _context.SaveChanges();
        }
    }

    public IQueryable<Item> GetAll()
    {
        return _context.Items;
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}