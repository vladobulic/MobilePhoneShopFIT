using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface IPopustiService
    {
        IEnumerable<Popusti> GetPopusti();
        Popusti Get(int id);
    }
}





