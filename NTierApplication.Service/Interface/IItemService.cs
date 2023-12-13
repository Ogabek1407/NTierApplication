using NTierApplication.Domain.ViewModel;

namespace NTierApplication.Service.Interface;

public interface IItemService
{
    void CreateNew(ItemViewModel item);
    void Update(ItemViewModel item);
    void Delete(long itemId);
    ICollection<ItemViewModel> GetItems();
    ItemViewModel GetById(long id);
}