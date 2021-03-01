using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    [Table("ItemSubType")]
    public class ItemSubType
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(20)]
        public string Name { get; set; }

        public Guid ItemTypeId { get; set; }

        public ItemType ItemType { get; set; }

        public ICollection<Item> Items { get; set; }
    }
}
