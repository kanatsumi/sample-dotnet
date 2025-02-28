﻿using ClinicBookingSystem_DataAccessObject.IBaseDAO;
using ClinicBookingSystem_DataAcessObject.DBContext;
using Microsoft.EntityFrameworkCore;

namespace ClinicBookingSystem_DataAccessObject.BaseDAO;

public class BaseDAO<T> : IBaseDAO<T> where T : class
{
    private readonly DbContext _dbContext;
    public BaseDAO(DbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task<T> GetByIdAsync(int id)
    {
        return await _dbContext.Set<T>().FindAsync(id);
    }
    public async Task<T> AddAsync(T entity)
    {
        await _dbContext.Set<T>().AddAsync(entity);
        return entity;
    }
    public async Task<T> UpdateAsync(T entity)
    {
        _dbContext.Entry(entity).State = EntityState.Modified;
        return entity;
    }
    public async Task<T> DeleteAsync(T entity)
    {
        _dbContext.Set<T>().Remove(entity);
        return entity;
    }
    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbContext.Set<T>().ToListAsync();
    }
}