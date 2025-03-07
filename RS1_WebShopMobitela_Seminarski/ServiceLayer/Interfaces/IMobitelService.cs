﻿using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;

namespace ServiceLayer.Interfaces
{
    public interface IMobitelService
    {
        IEnumerable<Mobiteli> GetMobiteli();

        

        IEnumerable<Mobiteli> GetMobiteliSorted(int page,bool priceDesc, string searchNaziv, string priceFromAndTo, int ? ProizvodjacId, int resultsPerPage, ref int TotalPages);
        Mobiteli GetMobitel(int id);

        int InsertMobitel(Mobiteli model);

        void InsertMobitel2(Mobiteli model);

        void saveChanges2();
        
        bool Delete(int id);

        void Edit(int id);
      
    }
}
