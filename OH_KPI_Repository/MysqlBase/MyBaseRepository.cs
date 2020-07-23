using Microsoft.EntityFrameworkCore;
using OH_KPI_IRepository.MyBaseRepository;
using OH_KPI_Models.MysqlModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Data;
using Dapper;

namespace OH_KPI_Repository.MysqlBase
{
    public class MyBaseRepository<TEntity> : IMyBaseRepository<TEntity> where TEntity : class, new()
    {

        public IDbConnection Db = nlp_adsContext.Db;


        /// <summary>
        /// 查出一条记录的实体
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sql"></param>
        /// <returns></returns>
        public TEntity QueryFirstOrDefault<TEntity>(string sql, object param = null)
        {
            return Db.QueryFirstOrDefault<TEntity>(sql, param);
        }

        public Task<TEntity> QueryFirstOrDefaultAsync<TEntity>(string sql, object param = null)
        {
            return Db.QueryFirstOrDefaultAsync<TEntity>(sql, param);
        }

        /// <summary>
        /// 查出多条记录的实体泛型集合
        /// </summary>
        /// <typeparam name="T">泛型T</typeparam>
        /// <returns></returns>
        public IEnumerable<TEntity> Query<TEntity>(string sql, object param = null, IDbTransaction transaction = null, bool buffered = true, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Db.Query<TEntity>(sql, param, transaction, buffered, commandTimeout, commandType);
        }

        public Task<IEnumerable<TEntity>> QueryAsync<TEntity>(string sql, object param = null, IDbTransaction transaction = null, int? commandTimeout = null, CommandType? commandType = null)
        {
            return Db.QueryAsync<TEntity>(sql, param, transaction, commandTimeout, commandType);
        }




    }
}
