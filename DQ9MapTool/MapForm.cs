using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DQ9_Cheat.GameData;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace DQ9MapTool {
    public partial class MapForm : Form {
        const byte Block = 0;
        const byte DownStairs = 1;
        const byte UpStairs = 2;
        const byte Path = 3;
        const byte Chest = 4;

        struct TileMap {
            public TileMap(byte[,] map, int x, int y) {
                M = map[x, y];
                T = BlockIfAnyBlock(map[x, y], map[x - 1, y]);
                B = BlockIfAnyBlock(map[x, y], map[x + 1, y]);
                L = BlockIfAnyBlock(map[x, y], map[x, y - 1]);
                R = BlockIfAnyBlock(map[x, y], map[x, y + 1]);
                TL = BlockIfAnyBlock(T, L);
                TR = BlockIfAnyBlock(T, R);
                BL = BlockIfAnyBlock(B, L);
                BR = BlockIfAnyBlock(B, R);
            }

            private static byte BlockIfAnyBlock(byte tile1, byte tile2) {
                return tile1 == Block || tile2 == Block ? Block : Path;
            }
            public byte TL;
            public byte T;
            public byte TR;
            public byte L;
            public byte M;
            public byte R;
            public byte BL;
            public byte B;
            public byte BR;
        }

        private void ConvertMap(byte[,] map, int level) {
            for (var x = map.GetLowerBound(0); x <= map.GetUpperBound(0); x++) {
                for (var y = map.GetLowerBound(1); y <= map.GetUpperBound(1); y++) {
                    map[x, y] = GetBlockType(map[x, y], x, y, level);
                }
            }
        }

        private static byte[] BaseRankTable = { 2, 56, 61, 76, 81, 101, 121, 141, 161, 181, 201, 221 };

        private TreasureMapDetailData mapData;
        private byte[] zsetr;

        public MapForm() {
            InitializeComponent();
            mapData = new TreasureMapDetailData();
            zsetr = Properties.Resources.zsetr;
            stopwatch = new Stopwatch();
        }

        private void NewMap_Clicked(object sender, EventArgs e) {
            using (var seedDialog = new MapSeedDialogBox()) {
                if (seedDialog.ShowDialog(this) == DialogResult.Cancel) return;
                CalculateMap(Convert.ToUInt16(seedDialog.MapSeed), BaseRankTable[seedDialog.Rank]);
            }
            saveToolStripButton.Enabled = true;
        }

        private void CalculateMap(ushort mapSeed, byte mapRank) {
            mapData.MapSeed = mapSeed;
            mapData.MapRank = mapRank;
            mapData.CalculateDetail(true/*, false*/);
            FloorLevelListBox.DataSource = Enumerable.Range(0, mapData.FloorCount).Select(item => new { Index = item, Name = (item + 1).ToString("00") }).ToList();
        }

        private void FloorLevelListBox_SelectedValueChanged(object sender, EventArgs e) {
            var mapLevel = (int)FloorLevelListBox.SelectedValue;
            var map = mapData.GetFloorMap(mapLevel);
            ConvertMap(map, mapLevel);
            var mapSize = new Size(mapData.GetFloorWidth(mapLevel) - 2, mapData.GetFloorHeight(mapLevel) - 2);
            var mapBitmap = new Bitmap(mapSize.Width * 48, mapSize.Height * 48, PixelFormat.Format24bppRgb);
            using (var mapGraphics = Graphics.FromImage(mapBitmap)) {
                for (var x = 1; x <= mapSize.Width; x++) {
                    for (var y = 1; y <= mapSize.Height; y++) {
                        // The map appears to be generated as a reflection across the line x=y, so
                        // swapping x and y seems to fix this
                        var tileMap = new TileMap(map, y,x);
                        var tile = GenerateTile(tileMap);
                        mapGraphics.DrawImageUnscaled(tile, (x - 1) * 48, (y - 1) * 48);
                    }
                }
            }

            FloorMapPictureBox.Image = mapBitmap;
            this.MinimumSize = this.Size + (mapBitmap.Size - FloorMapPictureBox.Size);
            var chestCount = mapData.GetTreasureBoxCountPerFloor(mapLevel);
            var datatable = new DataTable();
            //var testRow = new string[chestCount];
            if (chestCount > 0) {
                for (var a = 0; a < chestCount; a++) {
                    datatable.Columns.Add(string.Format("Rank {0}{1}", mapData.GetTreasureBoxRankPerFloor(mapLevel, a), new string(' ', a)));
                }
                var rows =
                    Enumerable.Range(7, 3600).Select(sec =>
                        Random.GetRandom((uint)(mapData.MapSeed + mapLevel + sec - 4))
                              .Take(chestCount)
                              .Select((rnd, index) => Data.GetItem(Data.GetIndex(mapData.GetTreasureBoxRankPerFloor(mapLevel, index) - 1, RandomToPercent(rnd))))
                              .ToArray()
                );
                foreach (var row in rows) datatable.Rows.Add(row);
                ChestTimerTable.DataSource = datatable;
                UpdateStopwatchUI(stopwatch.Elapsed);
                datatable = null;
            } else {
                ChestTimerTable.DataSource = null;
            }
            
        }

        private Bitmap GenerateTile(TileMap tileMap) {
            const int pL = 0, pT = 0;
            const int pM = 16;
            const int pR = 32, pB = 32;
            var rM = new Rectangle(pM, pM, 16, 16);
            var rL = new Rectangle(pL, pM, 16, 16);
            var rR = new Rectangle(pR, pM, 16, 16);
            var rT = new Rectangle(pM, pT, 16, 16);
            var rB = new Rectangle(pM, pB, 16, 16);
            var rTL = new Rectangle(pL, pT, 16, 16);
            var rTR = new Rectangle(pR, pT, 16, 16);
            var rBL = new Rectangle(pL, pB, 16, 16);
            var rBR = new Rectangle(pR, pB, 16, 16);


            var tile = new Bitmap(48, 48, PixelFormat.Format24bppRgb);

            PaintTile(tile, tileMap.TL, rTL);
            PaintTile(tile, tileMap.T, rT);
            PaintTile(tile, tileMap.TR, rTR);
            PaintTile(tile, tileMap.L, rL);
            PaintTile(tile, tileMap.M, rM);
            PaintTile(tile, tileMap.R, rR);
            PaintTile(tile, tileMap.BL, rBL);
            PaintTile(tile, tileMap.B, rB);
            PaintTile(tile, tileMap.BR, rBR);
            return tile;
        }

        private void PaintTile(Bitmap tile, int offset, Rectangle section) {
            var bdata = tile.LockBits(section, ImageLockMode.WriteOnly, PixelFormat.Format32bppRgb);
            Marshal.Copy(zsetr, offset * 1024, bdata.Scan0, 1024);
            tile.UnlockBits(bdata);
        }

        private byte GetBlockType(byte blockCode, int x, int y, int level) {
            switch (blockCode) {
                case 1:
                case 3: {
                    return Block;
                }
                case 0:
                case 2:
                case 8: {
                    return Path;
                }
                case 4: {
                    return mapData.IsUpStep(level, y, x) ? UpStairs : Path;
                }
                case 5: {
                    return DownStairs;
                }
                case 6: {
                    return (byte)(Chest + mapData.GetTreasureBoxIndex(level, y, x));
                }
            }
            throw new ArgumentOutOfRangeException("blockCode");
        }

        private void ChestTimerTable_CellPainting(object sender, DataGridViewCellPaintingEventArgs e) {
            if (e.ColumnIndex == -1) {
                if (e.RowIndex == -1) return;
                SetFormattedValue(e, FormatTime(TimeSpan.FromSeconds(e.RowIndex + 7)));
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All);
                e.Handled = true;
            } else if (e.RowIndex == -1) {
                var bitmap = new Bitmap(16, 16, PixelFormat.Format32bppRgb);
                PaintTile(bitmap, Chest + e.ColumnIndex, new Rectangle(0, 0, 16, 16));
                e.PaintBackground(e.CellBounds, false);

                e.Graphics.DrawImageUnscaledAndClipped(bitmap, new Rectangle(Math.Min(1, e.CellBounds.Width) + e.CellBounds.Left, Math.Max(e.CellBounds.Height / 2 - 8, 0) + e.CellBounds.Top, Math.Min(e.CellBounds.Width - 1, 16), Math.Min(e.CellBounds.Height, 16)));
                if (e.CellBounds.Width > 18) {
                    SetCellBounds(e, new Rectangle(e.CellBounds.Left + 18, e.CellBounds.Top, e.CellBounds.Width - 18, e.CellBounds.Height));
                    e.PaintContent(e.CellBounds);
                }
                e.Handled = true;
            }
        }

        private static void SetCellBounds(DataGridViewCellPaintingEventArgs e, Rectangle bounds) {
            // HACK: this works around the fact that PaintContent for column headers
            // ingore the clipbounds passed into it, instead using CellBounds, and the
            // fact that CellBounds is a readonly property.  It relies on the implementation
            // detail that CellBounds has a backing private field called cellBounds.  This may
            // break on future updates to the framework.
            
            typeof(DataGridViewCellPaintingEventArgs).InvokeMember("cellBounds", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetField, null, e, new object[]{bounds});
        }
        private static void SetFormattedValue(DataGridViewCellPaintingEventArgs e, string value) {
            typeof(DataGridViewCellPaintingEventArgs).InvokeMember("formattedValue", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.SetField, null, e, new object[] { value });
        }

        private static uint RandomToPercent(uint rnd) {
            return rnd == 0 ? 0 : (rnd - 1) * 100 / 0x7FFFU;
        }

        private static string FormatTime(TimeSpan ts) {
            return string.Format("{0:00}:{1:00}", Math.Floor(ts.TotalMinutes), ts.Seconds);
        }

        private void openToolStripButton_Click(object sender, EventArgs e) {
            using (var mapDialog = new OpenMapDialog()) {
                if (mapDialog.ShowDialog(this) == DialogResult.Cancel) return;
                CalculateMap(Convert.ToUInt16(mapDialog.MapSeed), BaseRankTable[mapDialog.MapRank]);
            }
            saveToolStripButton.Enabled = false;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e) {
            Database.SaveMap(mapData.MapSeed, Convert.ToUInt32(BaseRankTable.Select((rank, index) => new { rank, index }).First(item => item.rank > mapData.MapRank).index - 1));
            saveToolStripButton.Enabled = false;
        }

        private Stopwatch stopwatch;
        private bool timerUpdatesUI;

        private void PlayButton_Click(object sender, EventArgs e) {
            // The stopwatch logic can be in one of three possible
            // states, off, stopwatch only, and on.  The play button's
            // only functionality is to set the stopwatch logic to on.
            // The play button will only function in the off and 
            // stopwatch only mode, with it's purpose to set the on
            // mode.  If this event can be raised, the mode is either
            // off or stopwatch only.  If the stopwatch object is not
            // running, it's in the off mode, thus the stopwatch
            // object must be started.  The timer object must be
            // started.  With both running, the stopwatch logic is in
            // on mode, in which the play button must not be enabled,
            // and the stop button (available in stopwatch and on mode,
            // prohibited in off mode) must be enabled.  The pause
            // button is always enabled, and does not need to be
            // changed.

            // Switching to on mode, play has no defined behavior
            PlayButton.Enabled = false;
            // Switching of on mode, stop has a defined behavior
            StopButton.Enabled = true;
            
            // Even if in on mode, starting a stopwatch that's already
            // started does not affect the stopwatch or it's current
            // elapsed time.
            stopwatch.Start();
            StopwatchUpdateTimer.Start();
            timerUpdatesUI = true;
        }

        private void StopButton_Click(object sender, EventArgs e) {
            // The stopwatch logic can be in one of three states,
            // off (both stopwatch and timer off), stopwatch only
            // (stopwatch on, timer off), and on (both stopwatch
            // and timer on). The purpose of the stop button is to move
            // on mode or stopwatch only mode to the off mode. In the
            // off mode, stop is undefined and must be disabled,
            // while play is defined and must be enabled.  Pause is
            // always defined, always enabled, and need not be changed.

            StopButton.Enabled = false;
            PlayButton.Enabled = true;

            stopwatch.Stop();
            StopwatchUpdateTimer.Stop();
            timerUpdatesUI = false;
        }

        private void PauseButton_Click(object sender, EventArgs e) {
            // The stopwatch logic can be in one of three different
            // modes, off (both stopwatch and timer off), stopwatch
            // only (stopwatch on, timer off), and on (both stopwatch
            // and timer on).  The pause button has a more complicated
            // definition, and has a different definition for each
            // of the three stopwatch modes.

            if (stopwatch.IsRunning) {
                // If the stopwatch is currently running, the
                // stopwatch logic is either in stopwatch mode
                // or on mode.
                if (timerUpdatesUI) {
                    // If the timer update flag is set, then the
                    // stopwatch logic is in on mode.  When in on mode,
                    // the pause button is defined to switch to
                    // stopwatch mode. In stopwatch mode, both play
                    // and stop are defined, but only play is not
                    // defined in on mode, and is the only one that
                    // needs to be updated.  The timer object is not
                    // truly stopped in stopwatch mode, as it still
                    // needs to update the stopwatch display, thus
                    // a flag is set informing the stopwatch to not
                    // continue updating the UI.
                    PlayButton.Enabled = true;
                    timerUpdatesUI = false;
                } else {
                    // If the timer update flag is not set, then the
                    // stopwatch logic is in stopwatch only mode.
                    // In stopwatch only mode, the pause button
                    // does not change the stopwatch logic mode.
                    // Instead, it does a one time update of the UI
                    // based on the current elapsed time.
                    UpdateStopwatchUI(stopwatch.Elapsed);

                }
            } else {
                // If the stopwatch is not running, the stopwatch
                // logic is in off mode.  In off mode, the pause
                // button is defined to reset the the stopwatch
                // to zero.  It does not alter the state of the
                // stopwatch logic.
                stopwatch.Reset();
                StopwatchDisplayLabel.Text = "00:00:00";
                //UpdateStopwatchUI(TimeSpan.Zero);
            }
        }
        /// <summary>
        /// The UpdateStopwatchUI method updates the DataGridView
        /// control representing the possible treasure chest contents
        /// by selecting the line corresponding to the stopwatch
        /// as well as scrolling the DataGridView to be able to
        /// view the line as well as the 10 previous lines.
        /// </summary>
        /// <param name="timeSpan">
        /// The TimeSpan for which to highlight the corresponding
        /// treasures.
        /// </param>
        private void UpdateStopwatchUI(TimeSpan timeElapsed) {
            var rowIndex = (int)timeElapsed.TotalSeconds - 7;
            // If the derived row index is negative, it means not
            // enough time has elapsed to highlight a row of the
            // table yet, and thus is ignored.
            if (rowIndex < 0) return;
            // If the data source for the chest table is null, then
            // there is currently nothing to update, and attempting so
            // will throw an exception, and thus is ignored.
            if (ChestTimerTable.DataSource == null) return;
            // The timer updates up to 4 times each second in order to
            // increase timer resolution for a more precise
            // measurement.  This means more than half the calls to
            // this method will be repeats, and should be ignored in
            // order to reduce the possible penalty for unnecessarily
            // updating UI.
            if (ChestTimerTable.SelectedRows[0].Index != rowIndex) {
                ChestTimerTable.SuspendLayout();
                ChestTimerTable.ClearSelection();
                ChestTimerTable.Rows[rowIndex].Selected = true;
                ChestTimerTable.FirstDisplayedScrollingRowIndex = rowIndex > 10 ? rowIndex - 10 : 0;
                ChestTimerTable.ResumeLayout();
            }
        }

        private void StopwatchUpdateTimer_Tick(object sender, EventArgs e) {
            // The timer ticks up to 4 times every second, updating
            // the stopwatch display, and also updating the UI if
            // the stopwatch logic is currently in on mode.  The timer
            // will not tick in off mode.
            var timeElapsed = TimeSpan.FromSeconds(Math.Floor(stopwatch.Elapsed.TotalSeconds));
            if (timerUpdatesUI) UpdateStopwatchUI(timeElapsed);
            StopwatchDisplayLabel.Text = timeElapsed.ToString();
        }

    }
}