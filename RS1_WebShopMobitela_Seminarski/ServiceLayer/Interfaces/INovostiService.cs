﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Interfaces
{
    public interface INovostiService
    {
        public IEnumerable<Novosti> GetNovosti();
    }
}
