using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    interface CInterface<T>
    {
        Task<List<T>> LayLst();
        Task<DataTable> LayDT();
        Task<int> Them(T obj);
        Task<int> CapNhap(T obj);
        Task<int> Xoa(T obj);
    }
}
