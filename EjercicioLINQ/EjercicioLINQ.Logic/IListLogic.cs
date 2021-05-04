using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioLINQ.Logic
{
    interface IListLogic <T>
    {
        List<T> GetList();

    }
}
