using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Item")]
    public class Item
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid ItemSubTypeId { get; set; }

        public ItemSubType ItemSubType { get; set; }
    }
}
