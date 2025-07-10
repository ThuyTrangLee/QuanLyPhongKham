using QLPKDAL;
using QLPKDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPKBUS
{
    public class donviBUS
    {
        private donViDAL dvDAL;
        public donviBUS()
        {
            dvDAL = new donViDAL();
        }
        public List<donViDTO> select()
        {
            return dvDAL.getdonvi();
        }
    }
}
