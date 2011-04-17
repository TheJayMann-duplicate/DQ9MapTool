using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;

namespace DQ9MapTool {
    public partial class OpenMapDialog : Form {
        public OpenMapDialog() {
            InitializeComponent();
            mapNameList.DataSource = Database.ViewSavedMaps();
        }

        public uint MapSeed { get; private set; }
        public uint MapRank { get; private set; }

        private void okButton_Click(object sender, EventArgs e) {
            var row = (RowView)mapNameList.SelectedItem;
            MapSeed = Convert.ToUInt32(row.UpdatableRecord["MapSeed"]);
            MapRank = Convert.ToUInt32(row.UpdatableRecord["MapRank"]);
        }
    }
}
