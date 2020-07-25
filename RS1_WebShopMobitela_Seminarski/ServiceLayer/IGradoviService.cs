using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public interface IGradoviService
    {

        IEnumerable<Grad> GetGradovi();
        Grad GetGrad(int id);
    }
}
