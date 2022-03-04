using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Store
    {
        public string Name { get; set; }
        public List<Vendor> Vendors { get; set; }
        public List<Item> Items { get; set; }
        public Store()
        {
            // プロパティに直接インスタンス化したListを代入するのではなく、コンストラクタで初期化
            Vendors = new List<Vendor>();
            Items = new List<Item>();
        }
    }
}
