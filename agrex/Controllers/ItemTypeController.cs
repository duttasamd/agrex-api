using BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace agrex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemTypeController : ControllerBase
    {
        IItemTypeLogic itemTypeLogic;
        public ItemTypeController(IItemTypeLogic itemtypeLogic)
        {
            this.itemTypeLogic = itemtypeLogic;
        }

        [HttpGet]
        public List<ItemType> Get()
        {
            List<ItemType> itemTypes = null;

            itemTypes = itemTypeLogic.Get();

            return itemTypes;
        }

        [HttpPut]
        public void Add(ItemType itemType)
        {
            itemTypeLogic.Add(itemType);
        }
    }
}
