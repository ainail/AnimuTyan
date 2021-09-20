﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AnimuTyan.Core.Domain;

namespace AnimuTyan.Core.Abstractions.Repositories
{
    public interface IRepository<T> where T: BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(Guid id);
    }
}