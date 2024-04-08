using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Labor2.Models
{
    public class DataBaseModel
    {
        public int ID { get; set; }

        [Display(Name = "Название")]
        [DisplayName("Название")]
        public string Name { get; set; }

        [Display(Name = "Дата создания")]
        [DisplayName("Дата создания")]
        public DateTime CreationDate { get; set; }

        [Display(Name = "Количество записей")]
        [DisplayName("Количество записей")]
        public int RecordCount { get; set; }

        [Display(Name = "Описание")]
        [DisplayName("Описание")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Важность")]
        [DisplayName("Важность")]
        public bool IsImportant { get; set; }
    }
}
