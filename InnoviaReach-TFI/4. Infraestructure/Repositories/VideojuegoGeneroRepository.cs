﻿using Core.Contracts.Repositories;
using Core.Domain.Models;
using Infrastructure.Data.Repositories;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Infraestructure.Repositories
{
    public class VideojuegoGeneroRepository : GenericRepository<VideojuegoGeneroModel>, IVideojuegoGeneroRepository
    {
        public VideojuegoGeneroRepository(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext)
        {

        }
    }
}
