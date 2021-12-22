﻿using PKHeX.Core;
using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace PKHeX_Roaming8b_Plugin
{
    internal class Plugin : IPlugin
    {
        private const string ParentMenuParent = "Menu_Tools";

        public string Name => "猎游者";

        public int Priority => 1;

        public ISaveFileProvider SaveFileEditor { get; private set; } = null!;
        protected IPKMView PKMEditor { get; private set; } = null!;

        private ToolStripMenuItem? Hunter;

        public void Initialize(params object[] args)
        {
            Debug.WriteLine($"[{Name}] Loading...");
            SaveFileEditor = (ISaveFileProvider)Array.Find(args, z => z is ISaveFileProvider);
            PKMEditor = (IPKMView)Array.Find(args, z => z is IPKMView);
            var menu = (ToolStrip)Array.Find(args, z => z is ToolStrip);
            LoadMenuStrip(menu);

            NotifySaveLoaded();
        }

        private void LoadMenuStrip(ToolStrip menuStrip)
        {
            var items = menuStrip.Items;
            if (items.Find(ParentMenuParent, false)[0] is not ToolStripDropDownItem tools)
                return;
            Hunter = new ToolStripMenuItem(Name) { Visible = false }; // only visible for BD/SP
            Hunter.Click += (s, e) => Open();
            tools.DropDownItems.Add(Hunter);
        }

        private void Open()
        {
            var sav = SaveFileEditor.SAV;
            var game = (GameVersion)sav.Game;
            if (game != GameVersion.BD && game != GameVersion.SP)
                return;
            var frm = new Searcher(SaveFileEditor, PKMEditor);
            frm.Show();
        }

        public void NotifySaveLoaded()
        {
            Console.WriteLine($"{Name} was notified that a Save File was just loaded.");
            if (Hunter == null)
                return;
            var sav = SaveFileEditor.SAV;
            Hunter.Visible = sav is SAV8BS;
        }

        public bool TryLoadFile(string filePath)
        {
            return false;
        }
    }
}
