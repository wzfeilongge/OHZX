﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace OH_KPI_IRepository.MSBaseRepository
{
    public interface IMSBaseRepository<T> where T : class
    {
        TEntity QueryFirstOrDefault<TEntity>(string sql, object param = null);

        Task<TEntity> QueryFirstOrDefaultAsync<TEntity>(string sql, object param = null);

        IEnumerable<TEntity> Query<TEntity>(string sql, object param = null, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null);

        Task<IEnumerable<T>> QueryAsync<T>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null);


    }
}
