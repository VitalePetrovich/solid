using System;
using System.Collections.Generic;
using System.Data;
using SolidWorkshop.Models;

namespace SolidWorkshop
{
    public class ConcreteService : Service<Entity>
    {
        public ConcreteService(IDbConnection connection) : base(connection)
        {
        }

        public override Entity Save(Entity entity)
        {
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    try
                    {
                        _connection.Open();
                        //perform Save
                        _connection.Close();
                        return entity;
                    }
                    catch
                    {
                        if (i == 2)
                            throw;
                    }
                }
                throw new Exception("Ex");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public override List<Entity> ReadAll()
        {
            _connection.Open();
            //perform Read
            _connection.Close();
            return new List<Entity>();
        }
    }
}
