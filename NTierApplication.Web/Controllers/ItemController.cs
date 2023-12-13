using Microsoft.AspNetCore.Mvc;
using NTierApplication.Domain.ViewModel;
using NTierApplication.Service.Interface;
namespace NTierApplication.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IItemService ItemService;

        public ItemController(IItemService itemService)
        {
            ItemService = itemService;
        }

        [HttpGet]
        [Route("")]
        public ICollection<ItemViewModel> GetAll()
        {
            return ItemService.GetItems();
        }

        [HttpPost(Name = "CreateNew")]
        public ItemViewModel CreateNew(ItemViewModel itemViewModel)
        {
            ItemService.CreateNew(itemViewModel);
            return itemViewModel;
        }

        [HttpGet]
        [Route("{id}")]
        public ItemViewModel GetById(long id)
        {
            return ItemService.GetById(id);
        }
    }
}
