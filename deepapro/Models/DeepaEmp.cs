using System.ComponentModel.DataAnnotations;

namespace deepapro.Models
{
    public class Employeee
    {
     
        public int id { get; set; }
        public int? ChkListType { get; set; }
        public string NameCheckList { get; set; }
        public string DisplayName { get; set; }
        public string TaskName { get; set; }
        public string Descrription { get; set; }
        public string Priority { get; set; }
        public int? TaskOwner { get; set; }
        public bool? CheckListStaus { get; set; }
    }
}
