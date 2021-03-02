using BusinessLogic;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft;
using Newtonsoft.Json;

namespace agrex.Controllers
{
    [EnableCors("AllowAll")]

    [Route("api/[controller]")]
    [ApiController]
    public class ItemCategoryController : ControllerBase
    {
        IItemCategoryLogic itemCategoryLogic;
        public ItemCategoryController(IItemCategoryLogic _itemCategoryLogic)
        {
            itemCategoryLogic = _itemCategoryLogic;
        }

        [HttpGet]
        public string List()
        {
            List<ItemCategory> itemCategories = null;

            itemCategories = itemCategoryLogic.List();

            return JsonConvert.SerializeObject(itemCategories);
        }

        [HttpPut]
        public void Add(ItemCategory itemCategory)
        {
            itemCategoryLogic.Add(itemCategory);
        }
    }
}
