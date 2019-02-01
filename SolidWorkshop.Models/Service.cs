using System;
using System.Data;
using System.Collections.Generic;

namespace SolidWorkshop.Models
{
    public abstract class Service<TEntity>
    {
        protected readonly IDbConnection _connection;

        protected Service(IDbConnection connection)
        {
            _connection = connection ?? throw new ArgumentNullException(nameof(connection));
        }

        public abstract TEntity Save(TEntity entity);
        
        public abstract List<TEntity> ReadAll();
    }
}
