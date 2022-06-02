﻿using Microsoft.EntityFrameworkCore;

namespace PunishmentOrg.Api.Core.Domain.Context
{
    public interface IUnitOfWork : IDisposable
    {
        DbSet<TEntity> Set<TEntity>() where TEntity : class;

        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new());
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new());
    }
}
