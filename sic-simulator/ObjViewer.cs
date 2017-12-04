using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sic_simulator
{
    public partial class ObjViewer : Form
    {
        public ObjViewer(List<String> obj_lines)
        {
            InitializeComponent();
            cargaObj(obj_lines);
        }

        private int cargaObj(List<String> LineasObj)
        {
            int ret = 1;
            UInt32 start_addr = 0;
            UInt32 obj_start_addr = 0;
            int prog_size = 0;
            string prog_name = "";

            UInt32 reg_addr;
            Byte reg_size;
            String reg_data = "";
            Boolean is_first_line = true;
            for (int i = 0; i < LineasObj.Count; i++)
            {
                if (LineasObj[i] != "")
                    switch (LineasObj[i][0])
                    {
                        case 'H':
                            if (!is_first_line)
                                return 0; // error, solo la primera linea debe empezar con H.

                            if (LineasObj[i].Length != 19)
                                return 0; // error, el formato de la linea es invalido

                            prog_name = LineasObj[i].Substring(1, 6);
                            prog_name = prog_name.Replace('0', '\0');
                            obj_start_addr = uint.Parse(LineasObj[i].Substring(7, 6), System.Globalization.NumberStyles.HexNumber);
                            prog_size = int.Parse(LineasObj[i].Substring(13, 6), System.Globalization.NumberStyles.HexNumber);

                            textBox1.ForeColor = Color.OrangeRed;
                            textBox1.Text += LineasObj[i][0];
                            textBox1.ForeColor = Color.LightBlue;
                            textBox1.Text += LineasObj[i].Substring(1, 6);
                            textBox1.ForeColor = Color.Yellow;
                            textBox1.Text += LineasObj[i].Substring(7, 6);
                            textBox1.ForeColor = Color.Green;
                            textBox1.Text += LineasObj[i].Substring(13,6)+"\r\n";

                            is_first_line = false;
                            break;
                        case 'T':

                            if (LineasObj[i].Length < 11)
                                return 0; // error, el formato de la linea es invalido

                            reg_addr = uint.Parse(LineasObj[i].Substring(1, 6), System.Globalization.NumberStyles.HexNumber);
                            reg_size = Byte.Parse(LineasObj[i].Substring(7, 2), System.Globalization.NumberStyles.HexNumber);
                            reg_data = LineasObj[i].Substring(9);

                            if (reg_size != reg_data.Count() / 2)
                                return 0; // error, el formato de registro de datos es invalido.

                            textBox1.ForeColor = Color.OrangeRed;
                            textBox1.Text += LineasObj[i][0];
                            textBox1.ForeColor = Color.LightBlue;
                            textBox1.Text += LineasObj[i].Substring(1, 6);
                            textBox1.ForeColor = Color.Yellow;
                            textBox1.Text += LineasObj[i].Substring(7, 2);
                            textBox1.ForeColor = Color.Green;
                            textBox1.Text += LineasObj[i].Substring(9) + "\r\n";
                            is_first_line = false;
                            break;
                        case 'E':
                            if (LineasObj[i].Length != 7)
                                return 0; // error, formato del registo E no valido.

                            start_addr = uint.Parse(LineasObj[i].Substring(1, 6), System.Globalization.NumberStyles.HexNumber);
                            textBox1.ForeColor = Color.OrangeRed;
                            textBox1.Text += LineasObj[i][0];
                            textBox1.ForeColor = Color.LightBlue;
                            textBox1.Text += LineasObj[i].Substring(1, 6) + "\r\n";
                            is_first_line = false;
                            break;
                        default:
                            return 0; // Error, linea no valida para registro objeto
                    }
            }
                                       
            return ret;
        }
    }
}
