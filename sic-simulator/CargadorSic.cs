using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace sic_simulator
{
    class CargadorSic
    {

        public CargadorSic()
        {

        }

        public int CargaProgramaObjeto(List<string> LineasObj, MaquinaSic maquina)
        {
            int ret = 1;
            UInt32 start_addr = 0;
            UInt32 obj_start_addr = 0;
            int prog_size=0;
            string prog_name = "";

            UInt32 reg_addr;
            Byte reg_size;
            String reg_data="";
            Boolean is_first_line = true;
            for (int i = 0; i < LineasObj.Count; i++)
            {
                if(LineasObj[i] != "")
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

                            if (obj_start_addr + prog_size >= MaquinaSic.MEMORY_SIZE)
                                return 0;   // error, el programa no cabe en memoria

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

                            List<string> groups = new List<string>();
                            for (int j = 0; j < reg_data.Length; j++)
                            {
                                string s = "" + reg_data[j];
                                j++;
                                s += reg_data[j];
                                groups.Add(s);
                            }


                            foreach(string b in groups)
                            {
                                maquina.Memory[reg_addr] = Byte.Parse(b, System.Globalization.NumberStyles.HexNumber);
                                reg_addr++;
                            }
                            is_first_line = false;
                        break;
                    case 'E':
                            if (LineasObj[i].Length != 7)
                                return 0; // error, formato del registo E no valido.

                            start_addr = uint.Parse(LineasObj[i].Substring(1, 6), System.Globalization.NumberStyles.HexNumber);
                            is_first_line = false;
                        break;
                    default:
                        return 0; // Error, linea no valida para registro objeto
                }
            }

            maquina.Load(maquina.Memory, start_addr);
            maquina.ProgName = prog_name;
            maquina.ProgSize = prog_size;
            return ret;
        }
    }
}
