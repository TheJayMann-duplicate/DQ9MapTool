using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace DQ9MapTool {
    public partial class MapSeedDialogBox : Form {
        struct Map {
            public uint MapSeed;
            public uint MapRank;
        }
        public uint MapSeed {
            get {
                if (DialogResult == DialogResult.Cancel) return 0;
                return ((Map)mapLocationListView.SelectedItems[0].Tag).MapSeed;
            }
        }

        public uint Rank {
            get {
                if (DialogResult == DialogResult.Cancel) return 0;
                return ((Map)mapLocationListView.SelectedItems[0].Tag).MapRank;
            }
        }


        public MapSeedDialogBox() {
            InitializeComponent();
            materialTypeCombo.DataSource = DataEnumerations.MaterialTypes;
            dungeonTypeCombo.DataSource = DataEnumerations.DungeonTypes;
            difficultyTypeCombo.DataSource = DataEnumerations.DifficultyTypes;
            
        }

        private void searchButton_Click(object sender, EventArgs e) {
            mapLocationListView.Clear();
            var resultset = Database.SearchForMap((byte)materialTypeCombo.SelectedValue, (byte)dungeonTypeCombo.SelectedValue, (byte)difficultyTypeCombo.SelectedValue, byte.Parse(levelTextBox.Text));
            foreach (SqlCeUpdatableRecord result in resultset) {
                var seed = Convert.ToUInt32( result["MapSeed"]);
                var rank = Convert.ToUInt32(result["MapRank"]);
                var location = Convert.ToInt32(result["Location"]);
                mapLocationListView.Items.Add(location.ToString("X"), location - 1).Tag = new Map() { MapSeed = seed, MapRank = rank };
            }
        }

        private void mapLocationListView_DoubleClick(object sender, EventArgs e) {
            AcceptButton.PerformClick();
        }

        private void mapLocationListView_SelectedIndexChanged(object sender, EventArgs e) {
            confirmButton.Enabled = mapLocationListView.SelectedItems.Count > 0;
        }

        private void levelTextBox_Validating(object sender, CancelEventArgs e) {
            int level;
            // Simple level check.  If the textbox does not contain a valid
            // number, cancel.  If the textbox contains a number less than
            // 1, cancel.  If the textbox contains a number greater than
            // 100, cancel.
            if (!int.TryParse(levelTextBox.Text, out level) || level < 1 || level > 100) e.Cancel = true;
        }

  


        
    }
}
