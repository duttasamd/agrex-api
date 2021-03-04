using BusinessLogic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace agrex.Controllers
{
    [EnableCors("AllowAll")]
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
        public string List(Guid? itemCategoryId = null)
        {
            List<ItemType> itemTypes = null;

            if(itemCategoryId == null)
            {
                itemTypes = itemTypeLogic.List();
            } else
            {
                itemTypes = itemTypeLogic.List(itemCategoryId.GetValueOrDefault());
            }


            return JsonConvert.SerializeObject(itemTypes);
        }


        [HttpPut]
        public void Add(ItemType itemType)
        {
            itemTypeLogic.Add(itemType);
        }
    }
}
