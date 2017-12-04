using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sic_simulator
{
    class MaquinaSic
    {

        public struct Instruccion
        {
            public Byte opcode;
            public Byte modo;
            public UInt16 direccion;
        }

        public enum Opcode
        {
            ADD = 0x18,
            AND = 0x40,
            COMP = 0x28,
            DIV = 0x24,
            J = 0x3C,
            JEQ = 0x30,
            JGT = 0x34,
            JLT = 0x38,
            JSUB = 0x48,
            LDA = 0x00,
            LDCH = 0x50,
            LDL = 0x08,
            LDX = 0x04,
            MUL = 0x20,
            OR = 0x44,
            RD = 0xD8,
            RSUB = 0x4C,
            STA = 0x0C,
            STCH = 0x54,
            STL = 0x14,
            STSW = 0xE8,
            STX = 0x10,
            SUB = 0x1C,
            TD = 0xE0,
            TIX = 0x2C,
            WD = 0xDC
        }

        public const int MEMORY_SIZE = 0x7FFF;
        private Byte[] _memory;
        private UInt32 _REG_PC;
        private UInt32 _REG_A;
        private UInt32 _REG_X;
        private UInt32 _REG_L;
        private UInt32 _REG_SW;
        private Byte _cc_flag;

        private UInt32 _start_addr;
        private string _program_name;
        private int _program_size;

        private int _contador_instrucciones;
        UInt32 inst_mem;
        List<UInt16> mem_modif;

        public MaquinaSic()
        {
            _memory = Enumerable.Repeat((byte)0xFF, 0x8000).ToArray();
            _program_name = "";
            _program_size = 0;
            _REG_A = 0;
            _REG_L = 0;
            _REG_PC = 0;
            _REG_SW = 0;
            _REG_X = 0;
            _start_addr = 0;
            _cc_flag = 0;

        } 

        public void Load(Byte[] memory, UInt32 startAddr)
        {
            _start_addr = startAddr;
            _memory = memory;
        }
        public int Tick()
        {
            int ret;
            Instruccion inst;
                                  
            mem_modif = new List<ushort>();
            inst_mem = IrPortInstruccion();
            inst = DecodificaInstruccion(inst_mem);
            ret = EjecutaInstruccion(inst);

            return ret;
        }
        public void Reset()
        {
            _REG_A = 0;
            _REG_L = 0;
            _REG_PC = _start_addr;
            _REG_SW = 0;
            _REG_X = 0;
            _contador_instrucciones = 0;
            _cc_flag = 0;

        }
        public UInt32 IrPortInstruccion()
        {
            UInt32 instr = 0;
            instr = ((UInt32)_memory[_REG_PC]) << 16;
            instr |= ((UInt32)_memory[_REG_PC+1]) << 8;
            instr |= (UInt32)_memory[_REG_PC+2];
            return instr;
        }

        public Instruccion DecodificaInstruccion(UInt32 instruccion)
        {
            Instruccion inst = new Instruccion();
            inst.opcode = (byte)(instruccion >> 16);
            inst.direccion = (UInt16)(instruccion & 0xFFFF);
            inst.modo = 0;

            if ((inst.direccion & 0x8000) != 0)
            {
                inst.direccion = (UInt16)(inst.direccion & 0x7FFF);
                inst.modo = 1;
            }

            return inst;
        }

        public int EjecutaInstruccion(Instruccion inst)
        {
            int ret = 1;
            Boolean inc_pc = true;
            int bytes_changed = 0;
            UInt32 addr;
            UInt32 operando = 0;
            addr = inst.direccion;

            if (inst.modo == 1)
            {
                addr += _REG_X;
                if (addr > MEMORY_SIZE)
                    return 0;
            }                 

            string addr_hex = addr.ToString("X4");
            operando = ((UInt32)_memory[addr]) << 16;
            operando |= ((UInt32)_memory[addr + 1]) << 8;
            operando |= (UInt32)_memory[addr + 2];


            

            

            switch (inst.opcode)
            {
                case (Byte)Opcode.ADD:

                    _REG_A += operando;
                    break;
                case (Byte)Opcode.AND:

                    _REG_A &= operando;
                    break;
                case (Byte)Opcode.COMP:

                    if (_REG_A == operando)  // si es igual
                        _cc_flag = 0;
                    else
                    if (_REG_A < operando) // si es menor
                        _cc_flag = 1;
                    else
                        _cc_flag = 2;

                    break;
                case (Byte)Opcode.DIV:

                    _REG_A /= operando;
                    break;
                case (Byte)Opcode.J:
                    _REG_PC = addr;
                    inc_pc = false;
                    break;
                case (Byte)Opcode.JEQ:
                    if (_cc_flag == 0)
                    {
                        _REG_PC = addr;
                        inc_pc = false;
                    }
                    break;
                case (Byte)Opcode.JGT:
                    if (_cc_flag == 2)
                    {
                        _REG_PC = addr;
                        inc_pc = false;
                    }
                    break;
                case (Byte)Opcode.JLT:
                    if (_cc_flag == 1)
                    {
                        _REG_PC = addr;
                        inc_pc = false;
                    }
                    break;
                case (Byte)Opcode.JSUB:

                    _REG_L = _REG_PC;
                    _REG_PC = addr;
                    inc_pc = false;
                    break;
                case (Byte)Opcode.LDA:

                    _REG_A = operando;
                    break;
                case (Byte)Opcode.LDCH:

                    operando = ((UInt32)_memory[addr]);

                    _REG_A = (_REG_A & 0xFFFFFF00) |( operando & 0x000000FF);
                    break;
                case (Byte)Opcode.LDL:

                    _REG_L = operando;
                    break;
                case (Byte)Opcode.LDX:

                    _REG_X = operando;
                    break;
                case (Byte)Opcode.MUL:

                    _REG_A *= operando;
                    break;
                case (Byte)Opcode.OR:

                    _REG_A *= operando;
                    break;
                case (Byte)Opcode.RD:

                    // Lee del dispositivo
                    operando = ((UInt32)_memory[addr]);

                    _REG_A = (_REG_A & 0xFFFFFF00) | (operando & 0x000000FF);
                    break;
                case (Byte)Opcode.RSUB:
                    _REG_PC = _REG_L;
                    inc_pc = false;
                    break;
                case (Byte)Opcode.STA:
                    _memory[addr] = (Byte)(_REG_A >> 16);
                    _memory[addr+1] = (Byte)(_REG_A >> 8);
                    _memory[addr+2] = (Byte)(_REG_A);
                    bytes_changed = 3;
                    break;
                case (Byte)Opcode.STCH:
                    _memory[addr] = (Byte)(_REG_A);
                    bytes_changed = 1;
                    break;
                case (Byte)Opcode.STL:
                    _memory[addr] = (Byte)(_REG_L >> 16);
                    _memory[addr + 1] = (Byte)(_REG_L >> 8);
                    _memory[addr + 2] = (Byte)(_REG_L);
                    bytes_changed = 3;
                    break;
                case (Byte)Opcode.STSW:
                    _memory[addr] = (Byte)(_REG_SW >> 16);
                    _memory[addr + 1] = (Byte)(_REG_SW >> 8);
                    _memory[addr + 2] = (Byte)(_REG_SW);
                    bytes_changed = 3;
                    break;
                case (Byte)Opcode.STX:
                    _memory[addr] = (Byte)(_REG_X >> 16);
                    _memory[addr + 1] = (Byte)(_REG_X >> 8);
                    _memory[addr + 2] = (Byte)(_REG_X);
                    bytes_changed = 3;
                    break;
                case (Byte)Opcode.SUB:
                    _REG_A -= operando;
                    break;
                case (Byte)Opcode.TD:
                    // prueba el dispositivo
                    operando = 0xFF;

                    // Cambia la bandera de condición
                    _cc_flag = 0;
                    break;
                case (Byte)Opcode.TIX:
                    _REG_X++;

                    if (_REG_X == operando)  // si es igual
                        _cc_flag = 0;
                    else
                   if (_REG_X < operando) // si es menor
                        _cc_flag = 1;
                    else
                        _cc_flag = 2;

                    break;
                case (Byte)Opcode.WD:
                    
                    Byte b = 0x99;
                    /* escribe en el dispositivo */
                    b = (Byte)(_REG_A);
                    break;
                default:
                    return 0;
            }

            if (inc_pc)
                _REG_PC += 3;

            if(bytes_changed !=0)
                for (int i = 0; i < bytes_changed; i++)
                {
                    mem_modif.Add((ushort)(addr + i));
                }

            return ret;
        }

        public UInt32 CurretInstruction
        {
            get { return inst_mem; }
        }

        public Byte[] Memory
        {
            get { return _memory; }
            set { _memory = value; }
        }
        public UInt32 PC
        {
            get { return _REG_PC; }
            set { _REG_PC = value; }
        }
        public UInt32 X
        {
            get { return _REG_X; }
            set { _REG_X = value; }
        }
        public UInt32 L
        {
            get { return _REG_L; }
            set { _REG_L = value; }
        }
        public UInt32 A
        {
            get { return _REG_A; }
            set { _REG_A = value; }
        }
        public UInt32 SW
        {
            get { return _REG_SW; }
            set { _REG_SW = value; }
        }
        public String ProgName
        {
            get { return _program_name; }
            set { _program_name = value; }
        }
        public int ProgSize
        {
            get { return _program_size; }
            set { _program_size = value; }
        }
        public int ContadorInstrucciones
        {
            get { return _contador_instrucciones; }
        }
        public List<ushort> GetModifiedAddresList
        {
            get { return mem_modif; }
        }
    }

}
