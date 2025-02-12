﻿using System.Windows.Forms;

namespace PIDFinder
{
    public partial class TrainerID : UserControl
    {

        private uint _sid, _tid;
        public TrainerID()
        {
            InitializeComponent();

            _sid = 0;
            _tid = 999_999;
        }

        public ITrainerID GetSIDTID()
        {
            return new TSVID { _SID = _sid, _TID = _tid };
        }

        private void SID_TXT_TextChanged(object sender, System.EventArgs e)
        {
            if (!uint.TryParse(SID_TXT.Text, out var sid))
                sid = 0;
            if (sid > 4294)
            {
                sid = 4294;
                SID_TXT.Text = "4294";
            }
            _sid = sid;
        }

        private void TID_TXT_TextChanged(object sender, System.EventArgs e)
        {
            if (!uint.TryParse(TID_TXT.Text, out var tid))
                tid = 0;

            if (tid > 999_999)
            {
                tid = 999_999;
                TID_TXT.Text = "999999";
            }
            _tid = tid;
        }
    }

    public record TSVID : ITrainerID
    {
        int _fid
        {
            get
            {
                return (int)(_SID * 1000000 + _TID);
            }
        }
        public uint _SID { get; init; }
        public uint _TID { get; init; }

        public int TID
        {
            set
            {

            }
            get
            {
                return _fid % 65536;
            }
        }

        public int SID
        {
            set
            {

            }
            get
            {
                return _fid / 65536;
            }
        }
    }
}
