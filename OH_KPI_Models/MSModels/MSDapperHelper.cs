using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Microsoft.Data.Sqlite;
using MySql.Data.MySqlClient;
using Oracle.ManagedDataAccess.Client;
using WZ.Report.Common;

namespace OH_KPI_Models.MSModels
{
    public class MsDapperHelper
    {
        /// 数据库连接名
        private static string _connection = string.Empty;

        private  static int Type = 0;

        /// 获取连接名        
        private static string Connection
        {
            get { return _connection; }
            //set { _connection = value; }
        }

        /// 返回连接实例        
        private static IDbConnection _dbConnection = null;

        /// 静态变量保存类的实例        
        private static MsDapperHelper _uniqueInstance;

        /// 定义一个标识确保线程同步        
        private static readonly object Locker = new object();
        /// <summary>
        /// 私有构造方法，使外界不能创建该类的实例，以便实现单例模式
        /// </summary>
        private MsDapperHelper()
        {
            // 这里为了方便演示直接写的字符串，实例项目中可以将连接字符串放在配置文件中，再进行读取。
            _connection = Appsettings.app("Pexsql");
            Type = Appsettings.app("PexsqlType").ObjToInt();
        }

        /// <summary>
        /// 获取实例，这里为单例模式，保证只存在一个实例
        /// </summary>
        /// <returns></returns>
        public static MsDapperHelper GetInstance()
        {
            // 双重锁定实现单例模式，在外层加个判空条件主要是为了减少加锁、释放锁的不必要的损耗
            if (_uniqueInstance != null) return _uniqueInstance;
            lock (Locker)
            {
                _uniqueInstance ??= new MsDapperHelper();
            }
            return _uniqueInstance;
        }

        /// <summary>
        /// 创建数据库连接对象并打开链接
        /// </summary>
        /// <returns></returns>
        public static IDbConnection OpenCurrentDbConnection()
        {
            if (_dbConnection == null)
            {
                switch (Type)
                {
                    case 0:
                        new Exception("数据库参数错误");
                        break;
                    case 1:
                        _dbConnection = new MySqlConnection(Connection);
                        break;
                    case 2:
                        _dbConnection = new SqlConnection(Connection);
                        break;
                    case 3:
                        _dbConnection = new OracleConnection(Connection);
                        break;
                    case 4:
                        _dbConnection = new SqliteConnection(Connection);
                        break;
                }
            }
            //判断连接状态
            if (_dbConnection != null && _dbConnection.State == ConnectionState.Closed)
            {
                _dbConnection.Open();
            }
            return _dbConnection;
        }
    }
}
