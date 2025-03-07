﻿using RepositoryLayer;
using ServiceLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceLayer.Classes
{
    public class NovostiService : INovostiService
    {
        private IRepository<Novosti> novostiRepository;
        public NovostiService(IRepository<Novosti> novostiRepository)
        {
            this.novostiRepository = novostiRepository;
        }

        public Novosti GetNovost(int Id)
        {
            return novostiRepository.Get(Id);
        }

        public IEnumerable<Novosti> GetNovosti()
        {
            return novostiRepository.GetAllQueryable().OrderByDescending(x => x.Datum).ToList();
        }

        public int InsertNovost(Novosti entitity)
        {
            return novostiRepository.InsertAndReturnEntityId(entitity);
        }


        public void InsertNovost2(Novosti entitity)
        {
             novostiRepository.Insert(entitity);
        }

        public void ObrisiNovost(Novosti entity)
        {
            novostiRepository.Delete(entity);
        }



        public void SaveChanges(Novosti entity)
        {
            novostiRepository.SaveChanges(entity);
        }
    }
}
