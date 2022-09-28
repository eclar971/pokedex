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
            try
            {
                using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
                {
                    var output = cnn.Query<Pokemon>("select * from PokeDex", new DynamicParameters());
                    return output.ToList();
                }
            }
            catch (Exception exc)
            {
                var pokemon = new List<Pokemon>();
                var pokeBase = new Pokemon();
                pokeBase.Attack = 0;
                pokeBase.HP = 0;
                pokeBase.Defense = 0;
                pokeBase.SpecialDefense = 0;
                pokeBase.SpecialAttack = 0;
                pokeBase.Speed = 0;
                pokeBase.Num = 1;
                pokemon.Add(pokeBase);
                return pokemon;
            }
        }
        public static List<Data> LoadUserData()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<Data>("select * from caughtSeen", new DynamicParameters());
                return output.ToList();
            }
        }
        public static void SaveUserData(Data data)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"INSERT INTO \"main\".\"caughtSeen\"(\"where\",\"when\",\"nickname\",\"shiny\",\"pokemon\") VALUES (\"{data.where}\",\"{data.when}\",\"{data.nickname}\",\"{data.shiny}\",\"{data.pokemon}\");");
            }
        }
        public static void SavePokemon(Pokemon pokemon)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Pokemon (Name,Num,Type,Total,Hp,Attack,Defense,SpecialAttack,SpecialDefense,speed) values (@Name,@Num,@Type,@Total,@Hp,@Attack,@Defense,@SpecialAttack,@SpecialDefense,@speed)", pokemon);
            }
        }
        public static void DeletePokemon(Pokemon pokemon)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute($"DELETE FROM PokeDex where Name = \"{pokemon.Name}\"");
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            string conString = "Data Source=.\\PokeDex.db;Version=3";
            return conString;
        }
    }
    public class Data
    {
        public string nickname { get; set; }
        public string where { get; set; }
        public string shiny { get; set; }
        public string when { get; set; }
        public string pokemon { get; set; }
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

        public override string ToString()
        {
            return $"Name:{Name}\nNumber:{Num}\nType:{Type}";
        }
    }
}
