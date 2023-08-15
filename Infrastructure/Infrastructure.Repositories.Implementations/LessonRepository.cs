﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Services.Repositories.Abstractions;
using Domain.Entities;
using Infrastructure.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories.Implementations
{
    /// <summary>
    /// Репозиторий работы с уроками.
    /// </summary>
    public class LessonRepository: Repository<Lesson, int>, ILessonRepository 
    {
        public LessonRepository(DatabaseContext context): base(context)
        {
        }
        
        /// <summary>
        /// Получить сущность по ID.
        /// </summary>
        /// <param name="id"> Id сущности. </param>
        /// <returns> Курс. </returns>
        public override Task<Lesson> GetAsync(int id)
        {
            var query = Context.Set<Lesson>().AsQueryable();
            query = query
                .Where(l => l.Id == id && !l.Deleted);

            return query.SingleOrDefaultAsync();
        }
        
        public async Task<List<Lesson>> GetPagedAsync(int page, int itemsPerPage)
        {
            var query = GetAll();
            return await query
                .Skip((page - 1) * itemsPerPage)
                .Take(itemsPerPage)
                .ToListAsync();
        }
    }
}
