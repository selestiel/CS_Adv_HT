using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Adv_L5_T5
{
    public class MyClass2
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public int? Class1Id { get; set; }
        public MyClass1 class1 { get; set; }
    }
}
