using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using MySql.Data.MySqlClient;

namespace Progect_Manegment
{
    public class MigrationConfig:DbMigrationsConfiguration<DBcontextModel>
    {
        public MigrationConfig()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
