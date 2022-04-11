using FuelStation.EF.Repositories;
using FuelStation.Models;
using Microsoft.AspNetCore.Mvc;
using The_App.Shared;
using static FuelStation.Models.Enumerations;

namespace The_App.Server.Controllers {
    [ApiController]
    [Route("[controller]")]
    public class ItemsController : ControllerBase {

        private readonly IEntityRepo<Item> _itemRepo;
        public ItemsController(IEntityRepo<Item> itemRepo) {
            _itemRepo = itemRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<ItemViewModel>> GetActiveItems() {
            var result = await _itemRepo.GetAllAsync();
            return result.FindAll(x => x.Status == true).Select(x => new ItemViewModel
            {
                ID = x.ID,
                Status = x.Status,
                Code = x.Code,
                Description = x.Description,
                Cost = x.Cost,
                ItemType = x.ItemType,
                Price = x.Price
            });
        }
        [HttpGet("getall")]
        public async Task<IEnumerable<ItemViewModel>> GetAllItems() {
            var result = await _itemRepo.GetAllAsync();
            return result.Select(x => new ItemViewModel
            {
                ID = x.ID,
                Status = x.Status,
                Code = x.Code,
                Description = x.Description,
                Cost = x.Cost,
                ItemType = x.ItemType,
                Price = x.Price
            });
        }

        [HttpPost]
        public async Task Post(ItemViewModel item) {
            
            var code = GenerateItemCode(item.ItemType, null).Result;
            var dbItem = new Item
            {
                ID = Guid.NewGuid(),
                Description = item.Description,
                ItemType = item.ItemType,
                Price = item.Price,
                Cost = item.Cost,
                Code = code
            };
            await _itemRepo.AddAsync(dbItem);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id) {
            var dbItem = await _itemRepo.GetByIdAsync(id);
            if (dbItem == null) return NotFound();
            dbItem.Status = !dbItem.Status;
            await _itemRepo.UpdateAsync(id, dbItem);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult> Put(ItemViewModel item) {
            var dbItem = await _itemRepo.GetByIdAsync(item.ID);
            if (dbItem == null) return NotFound();
            var code = GenerateItemCode(item.ItemType, item).Result;
            dbItem.ID = item.ID;
            dbItem.Code = code;
            dbItem.ItemType = item.ItemType;
            dbItem.Description = item.Description;
            dbItem.Price = item.Price;
            dbItem.Cost = item.Cost;
            dbItem.Status = item.Status;
            await _itemRepo.UpdateAsync(item.ID, dbItem);
            return Ok();
        }

        private async Task<string> GenerateItemCode(ItemType? type, ItemViewModel? item) {
            var result = await _itemRepo.GetAllAsync();
            if(result.Count() < 1)
                return $"{type}-001";
            if (item is null) {
                int codeCounter = result.Count();
                codeCounter++;
                return $"{type}-00{codeCounter}";
            }
            string[] splitCode = item.Code.Split("-");
            Int32.TryParse(splitCode[1], out int foundCode);
            return $"{type}-00{foundCode}";
        }

    }
}
