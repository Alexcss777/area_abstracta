using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_abstracta
{
    public abstract class ClsArea
    {
        public abstract double lado { get; set; }

        public abstract double radio { get; set; }

        public abstract string lad { get; set; }

        public abstract string rad { get; set; }

        public abstract double areac { get; set; }

        public abstract double areacu { get; set; }
    }
}
