using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Data;

namespace DQ9MapTool {
    static class Database {
        private static SqlCeConnection _Connection;
        static Database() {
            _Connection = new SqlCeConnection(string.Format("Data Source = {0}", Properties.Settings.Default.DatabaseFile));
            _Connection.Open();
        }

        public static SqlCeResultSet ViewSavedMaps() {
            SqlCeResultSet resultSet;
            //_Connection.Open();
            using (var command = _Connection.CreateCommand()) {
                command.CommandType = CommandType.Text;
                command.CommandText = Properties.Resources.ViewSavedMapsSQL;
                resultSet = command.ExecuteResultSet(ResultSetOptions.Scrollable | ResultSetOptions.Insensitive);
            }
            //_Connection.Close();
            return resultSet;
        }
        public static void SaveMap(uint mapSeed, uint mapRank) {
            //_Connection.Open();
            using (var command = _Connection.CreateCommand()) {
                command.CommandType = CommandType.Text;
                command.CommandText = Properties.Resources.SaveMapSQL;
                command.Parameters.Add("@MapSeed", SqlDbType.SmallInt).Value = mapSeed;
                command.Parameters.Add("@MapRank", SqlDbType.SmallInt).Value = mapRank;
                command.ExecuteNonQuery();
            }
            //_Connection.Close();
        }

        public static void DeleteMap(uint mapSeed, uint mapRank) {
            //_Connection.Open();
            using (var command = _Connection.CreateCommand()) {
                command.CommandType = CommandType.Text;
                command.CommandText = Properties.Resources.DeleteMapSQL;
                command.Parameters.Add("@MapSeed", SqlDbType.SmallInt).Value = mapSeed;
                command.Parameters.Add("@MapRank", SqlDbType.SmallInt).Value = mapRank;
                command.ExecuteNonQuery();
            }
            //_Connection.Close();
        }

        public static SqlCeResultSet SearchForMap(byte materialTypeId, byte dungeonTypeId, byte difficultyTypeId, byte level) {
            SqlCeResultSet resultSet;
            //_Connection.Open();
            using (var command = _Connection.CreateCommand()) {
                command.CommandType = CommandType.Text;
                command.CommandText = Properties.Resources.SearchForMapSQL;
                command.Parameters.Add("@MaterialTypeId", SqlDbType.TinyInt).Value = materialTypeId;
                command.Parameters.Add("@DungeonTypeId", SqlDbType.TinyInt).Value = dungeonTypeId;
                command.Parameters.Add("@DifficultyTypeId", SqlDbType.TinyInt).Value = difficultyTypeId;
                command.Parameters.Add("@Level", SqlDbType.TinyInt).Value = level;
                resultSet = command.ExecuteResultSet(ResultSetOptions.Scrollable | ResultSetOptions.Insensitive);
            }
            //_Connection.Close();
            return resultSet;
        }

        public static SqlCeResultSet GetTable(string tableName) {
            using (var command = _Connection.CreateCommand()) {
                command.CommandType = CommandType.TableDirect;
                command.CommandText = tableName;
                return command.ExecuteResultSet(ResultSetOptions.Scrollable);
            }
            
        }



    }
}
