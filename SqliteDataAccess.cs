using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace pokedex
{
    public class SqliteDataAccess
    {
        public static List<Pokemon> LoadPokemon()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Pokemon>("select * from PokeDex", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SavePokemon(Pokemon pokemon)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Pokemon (Name,Num,Type,Total,Hp,Attack,Defense,SpecialAttack,SpecialDefense,speed) values (@Name,@Num,@Type,@Total,@Hp,@Attack,@Defense,@SpecialAttack,@SpecialDefense,@speed)", pokemon);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
    public class Pokemon
    {
        public string Name { get; set; }
        public int Num { get; set; }
        public string Type  { get; set; }
        public int Total { get; set; }
        public int HP { get; set; }
        public int Attack { get; set; }
        public int Defense  { get; set; }

        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set; }
        public int Speed { get; set; }

    }
}
