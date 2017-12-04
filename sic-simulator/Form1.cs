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
using System.IO;
using System.Collections;

namespace sic_simulator
{
    public partial class Form1 : Form
    {

        private byte[] _sic_memory = Enumerable.Repeat((byte)0xFF, 0x8000).ToArray();
        private HexViewer hv;
        private ObjViewer objv;
        string _obj_file_path;
        List<String> lineas_obj;
        private MaquinaSic _sic_machine;
        private Hashtable _opcodes;

        public Form1(string obj_file=null)
        {
            InitializeComponent();
            _obj_file_path = obj_file;
            hv = new HexViewer(_sic_memory);
            _sic_machine = new MaquinaSic();
            _opcodes = new Hashtable();
            _opcodes.Add(0x18, "ADD");
            _opcodes.Add(0x40, "AND");
            _opcodes.Add(0x28, "COMP");
            _opcodes.Add(0x24, "DIV");
            _opcodes.Add(0x3C, "J");
            _opcodes.Add(0x30, "JEQ");
            _opcodes.Add(0x34, "JGT");
            _opcodes.Add(0x38, "JLT");
            _opcodes.Add(0x48, "JSUB");
            _opcodes.Add(0x00, "LDA");
            _opcodes.Add(0x50, "LDCH");
            _opcodes.Add(0x08, "LDL");
            _opcodes.Add(0x04, "LDX");
            _opcodes.Add(0x20, "MUL");
            _opcodes.Add(0x44, "OR");
            _opcodes.Add(0xD8, "RD");
            _opcodes.Add(0x4C, "RSUB");
            _opcodes.Add(0x0C, "STA");
            _opcodes.Add(0x54, "STCH");
            _opcodes.Add(0x14, "STL");
            _opcodes.Add(0xE8, "STSW");
            _opcodes.Add(0x10, "STX");
            _opcodes.Add(0x1C, "SUB");
            _opcodes.Add(0xE0, "TD");
            _opcodes.Add(0x2C, "TIX");
            _opcodes.Add(0xDC, "WD");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(_obj_file_path != null && _obj_file_path != "")
                MessageBox.Show("Archivo de entrada: " + _obj_file_path);

            toolStrip1.Enabled = false;
            programaObjetoToolStripMenuItem.Enabled = false;

        }
        
        private int CargaArchivoObjeto(string filepath)
        {
            StreamReader file = new StreamReader(filepath);

            if (file == null)
                return 0;

            file.Close();
            lineas_obj = File.ReadLines(filepath).ToList();
            _obj_file_path = filepath;
            CargadorSic cargador = new CargadorSic();
            if(cargador.CargaProgramaObjeto(lineas_obj, _sic_machine) == 1)
            {
                MessageBox.Show("Programa cargado correctamente");
                _sic_machine.Reset();
                textBox_PNAME.Text = _sic_machine.ProgName;
                textBox_PSIZE.Text = _sic_machine.ProgSize.ToString() + " bytes";
                ActualizaRegistros();
                toolStrip1.Enabled = true;
                programaObjetoToolStripMenuItem.Enabled = true;
                objv = new ObjViewer(lineas_obj);

                if (hv.Visible)
                {
                    hv.Close();
                } 

                
                hv = new HexViewer(_sic_machine.Memory);
                hv.StartPosition = FormStartPosition.Manual;
                hv.Location = new Point(this.Location.X + this.Size.Width, this.Location.Y);
                hv.Show();
                hv.SelectLocation(_sic_machine.PC, 3);

                

            }
            else
            {
                MessageBox.Show("No se pudo cargar el programa objeto, verifique el que arlchivo tenga un formato correcto.");
                return 0;
            }

            return 1;
            
        }

        private void mapaDeMemoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hv.Visible)
            {
                hv.Select();
            }
            else
            {
                hv = new HexViewer(_sic_machine.Memory);
                hv.StartPosition = FormStartPosition.Manual;
                hv.Location = new Point(this.Location.X+this.Size.Width, this.Location.Y);
                hv.Show();

            }
        }

        private void cargarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
           if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                CargaArchivoObjeto(openFileDialog1.FileName);
                btn_step.Enabled = true;
                btn_run.Enabled = true;
                btn_stop.Enabled = true;
                btn_pause.Enabled = true;
            }
        }

        private void btn_step_Click(object sender, EventArgs e)
        {

            if (_sic_machine.Tick() == 0)
            {
                btn_step.Enabled = false;
                btn_run.Enabled = false;
                btn_stop.Enabled = false;
                btn_pause.Enabled = false;
                timerExec.Stop();
                MessageBox.Show("Error al ejecutar la instrucción, instrucción no valida!");
                return;
            }
            ActualizaRegistros();

            int modif = _sic_machine.GetModifiedAddresList.Count;

            if (modif != 0)
                for (int i = 0; i < modif; i++)
                {
                    ushort addr = _sic_machine.GetModifiedAddresList[i];
                    byte data = _sic_machine.Memory[addr];
                    hv.WriteLocation(addr, data);
                }

            if (hv.Visible)
            {
                hv.SelectLocation(_sic_machine.PC, 3);
               
            }

        }

        private void ActualizaRegistros()
        {
            textBox_PC.Text = (_sic_machine.PC & 0xFFFFFF).ToString("X6");
            textBox_L.Text = (_sic_machine.L & 0xFFFFFF).ToString("X6");
            textBox_X.Text = (_sic_machine.X & 0xFFFFFF).ToString("X6");
            textBox_A.Text = (_sic_machine.A & 0xFFFFFF).ToString("X6");
            textBox_SW.Text = (_sic_machine.SW & 0xFFFFFF).ToString("X6");
            textBox_COP.Text = _sic_machine.CurretInstruction.ToString("X6");
            Desensambla(_sic_machine.CurretInstruction);

        }

        private void Desensambla(UInt32 inst)
        {
            string asm_inst = "";
            MaquinaSic.Instruccion ins= _sic_machine.DecodificaInstruccion(inst);
            textBox_CODE.Text = ins.opcode.ToString("X2");
            textBox_ADDR.Text = ins.direccion.ToString("X4");
            if (ins.modo == 0)
            {
                int num = ins.opcode;
                string s = (string)_opcodes[num];
                asm_inst =  s + "  " + ins.direccion.ToString("X4");
                textBox_XFLAG.Text = "0";
            }
            else
            {
                int num = ins.opcode;
                string s = (string)_opcodes[num];
                asm_inst = s + "  " + ins.direccion.ToString("X4") + " ,X";
                textBox_XFLAG.Text = "1";
            }

            textBox_INST.Text = asm_inst;

        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            btn_step.Enabled = true;
            btn_run.Enabled = true;
            btn_stop.Enabled = true;
            btn_pause.Enabled = true;
            CargaArchivoObjeto(_obj_file_path);
            _sic_machine.Reset();
            ActualizaRegistros();
        }

        private void programaObjetoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (objv.Visible)
            {
                objv.Select();
            }
            else
            {
                objv = new ObjViewer(lineas_obj);
                objv.StartPosition = FormStartPosition.Manual;
                objv.Location = new Point(this.Location.X - this.Size.Width, this.Location.Y);
                objv.Show();

            }
        }

        private void btn_run_Click(object sender, EventArgs e)
        {
            if (!timerExec.Enabled)
                timerExec.Start();

            btn_stop.Enabled = true;
            btn_pause.Enabled = true;
            btn_run.Enabled = false;
            btn_step.Enabled = false;
        }

        private void timerExec_Tick(object sender, EventArgs e)
        {
            btn_step_Click(null, null);
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            if (!timerExec.Enabled)
                timerExec.Start();
            else
                timerExec.Stop();
        }
    }
}
