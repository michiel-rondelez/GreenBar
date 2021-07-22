using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.Template
{
    public class LegendaryQuality : QualityTemplate
    {
        public LegendaryQuality(Item item) : base(item)
        {
        }

        protected override bool IsLegendaryItem()
        {
            return true;
        }

        protected override void QualityUpdate()
        {
        }
    }
}
