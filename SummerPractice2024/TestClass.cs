using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerPractice2024
{
    class TestClass
    {
        public static int? First { get; set; } = null;
        public static int? Second { get; set; } = null;

        public static int? Summary() => (First is not null && Second is not null) ? First + Second : null;
    }
}
