using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Statistics<T>
    {
        private List<T> _datas;

        public Statistics (List<T> datas)
        {
            this._datas = datas;
        }

        public List<int> sum(string name, int count)
        {
            throw new NotImplementedException();
        }
    }
}
