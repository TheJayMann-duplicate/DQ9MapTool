using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DQ9MapTool {
    static class DataEnumerations {
        private static object _MaterialTypes;
        private static object _DungeonTypes;
        private static object _DifficultyTypes;
        private static object _EnvironmentTypes;
        private static object _Bosses;

        public static object MaterialTypes {
            get {
                return _MaterialTypes ?? (_MaterialTypes = Database.GetTable("MaterialTypes"));
            }
        }

        public static object DungeonTypes {
            get {
                return _DungeonTypes ?? (_DungeonTypes = Database.GetTable("DungeonTypes"));
            }
        }
        public static object DifficultyTypes {
            get {
                return _DifficultyTypes ?? (_DifficultyTypes = Database.GetTable("DifficultyTypes"));
            }
        }
        public static object EnvironmentTypes {
            get {
                return _EnvironmentTypes ?? (_EnvironmentTypes = Database.GetTable("EnvironmentTypes"));
            }
        }
        public static object Bosses {
            get {
                return _Bosses ?? (_Bosses = Database.GetTable("Bosses"));
            }
        }
    }
}
