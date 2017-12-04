using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Be.Windows.Forms;

namespace sic_simulator
{
    public partial class HexViewer : Form
    {
        byte[] _mem;
        public HexViewer(byte[] memory)
        {
            InitializeComponent();
            _mem = memory;
            //const string FILE_PATH = @"C:\Users\alfredo\Documents\sum.obj";

            //hexBoxMem.ByteProvider = new DynamicFileByteProvider();
        }

        private void HexViewer_Load(object sender, EventArgs e)
        {
            hexBoxMem.ByteProvider = new DynamicByteProvider(_mem);
            hexBoxMem.BackColor = Color.FromArgb(0x27, 0x28, 0x22);
            hexBoxMem.SelectionBackColor = Color.FromArgb(0xA6, 0xE2, 0x2E);
            hexBoxMem.ForeColor = Color.FromArgb(0xF9, 0x26, 0x72);
            hexBoxMem.InfoForeColor = Color.FromArgb(0x66, 0xD9, 0xEF);
            hexBoxMem.SelectionForeColor = Color.Black;
            hexBoxMem.ShadowSelectionColor = Color.FromArgb(0xDD, 0xDD, 0xDD);
           
        }

        public void SelectLocation(UInt32 location, UInt32 len)
        {
            if (location > 0x7FFF || location + len > 0x7FFF)
                return;

            hexBoxMem.Select(location, len);
            
        }

        public void WriteLocation(UInt32 location, byte data)
        {
            if (location > 0x7FFF)
                return;

            hexBoxMem.ByteProvider.WriteByte(location, data);
            hexBoxMem.Invalidate();
        }

        public byte ReadLocation(UInt32 location)
        {
            if (location > 0x7FFF)
                return 0xFF;

            return hexBoxMem.ByteProvider.ReadByte(location);
        }
    }
}
