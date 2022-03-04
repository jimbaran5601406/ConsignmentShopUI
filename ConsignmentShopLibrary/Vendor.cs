using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commission { get; set; }

        public Vendor()
        {
            // デフォルト手数料の設定。プロパティに直接代入するようなことはせずコンストラクタで設定
            Commission = .5;
        }
    }
}
