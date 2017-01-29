﻿using System;

namespace Spect.Net.Z80Emu.Core
{
    public partial class Z80
    {
        /// <summary>
        /// Indexed bit (0xDDCB or 0xFDCB-prefixed) operations jump table
        /// </summary>
        private Action<byte, ushort>[] _indexedBitOperations;

        /// <summary>
        /// Initializes the indexed bit operation execution tables
        /// </summary>
        private void InitializeIndexedBitOpsExecutionTable()
        {
            _indexedBitOperations = new Action<byte, ushort>[]
            {
                XRLC_R,   XRLC_R,   XRLC_R,   XRLC_R,   XRLC_R,   XRLC_R,   XRLC,     XRLC_R,   // 00..07
                XRRC_R,   XRRC_R,   XRRC_R,   XRRC_R,   XRRC_R,   XRRC_R,   XRRC,     XRRC_R,   // 08..0F
                XRL_R,    XRL_R,    XRL_R,    XRL_R,    XRL_R,    XRL_R,    XRL,      XRL_R,    // 10..17
                XRR_R,    XRR_R,    XRR_R,    XRR_R,    XRR_R,    XRR_R,    XRR,      XRR_R,    // 18..1F
                XSLA_R,   XSLA_R,   XSLA_R,   XSLA_R,   XSLA_R,   XSLA_R,   XSLA,     XSLA_R,   // 20..27
                XSRA_R,   XSRA_R,   XSRA_R,   XSRA_R,   XSRA_R,   XSRA_R,   XSRA,     XSRA_R,   // 28..2F
                XSLL_R,   XSLL_R,   XSLL_R,   XSLL_R,   XSLL_R,   XSLL_R,   XSLL,     XSLL_R,   // 30..37
                XSRL_R,   XSRL_R,   XSRL_R,   XSRL_R,   XSRL_R,   XSRL_R,   XSRL,     XSRL_R,   // 38..3F

                XBITN_R,  XBITN_R,  XBITN_R,  XBITN_R,  XBITN_R,  XBITN_R,  XBITN,    XBITN_R,  // 40..47
                XBITN_R,  XBITN_R,  XBITN_R,  XBITN_R,  XBITN_R,  XBITN_R,  XBITN,    XBITN_R,  // 48..4F
                XBITN_R,  XBITN_R,  XBITN_R,  XBITN_R,  XBITN_R,  XBITN_R,  XBITN,    XBITN_R,  // 50..57
                XBITN_R,  XBITN_R,  XBITN_R,  XBITN_R,  XBITN_R,  XBITN_R,  XBITN,    XBITN_R,  // 58..5F
                XBITN_R,  XBITN_R,  XBITN_R,  XBITN_R,  XBITN_R,  XBITN_R,  XBITN,    XBITN_R,  // 60..67
                XBITN_R,  XBITN_R,  XBITN_R,  XBITN_R,  XBITN_R,  XBITN_R,  XBITN,    XBITN_R,  // 68..6F
                XBITN_R,  XBITN_R,  XBITN_R,  XBITN_R,  XBITN_R,  XBITN_R,  XBITN,    XBITN_R,  // 70..77
                XBITN_R,  XBITN_R,  XBITN_R,  XBITN_R,  XBITN_R,  XBITN_R,  XBITN,    XBITN_R,  // 70..7F

                XRES_R,   XRES_R,   XRES_R,   XRES_R,   XRES_R,   XRES_R,   XRES,     XRES_R,   // 80..87
                XRES_R,   XRES_R,   XRES_R,   XRES_R,   XRES_R,   XRES_R,   XRES,     XRES_R,   // 88..8F
                XRES_R,   XRES_R,   XRES_R,   XRES_R,   XRES_R,   XRES_R,   XRES,     XRES_R,   // 90..97
                XRES_R,   XRES_R,   XRES_R,   XRES_R,   XRES_R,   XRES_R,   XRES,     XRES_R,   // 98..9F
                XRES_R,   XRES_R,   XRES_R,   XRES_R,   XRES_R,   XRES_R,   XRES,     XRES_R,   // A0..A7
                XRES_R,   XRES_R,   XRES_R,   XRES_R,   XRES_R,   XRES_R,   XRES,     XRES_R,   // A8..AF
                XRES_R,   XRES_R,   XRES_R,   XRES_R,   XRES_R,   XRES_R,   XRES,     XRES_R,   // B0..B7
                XRES_R,   XRES_R,   XRES_R,   XRES_R,   XRES_R,   XRES_R,   XRES,     XRES_R,   // B8..BF

                XSET_R,   XSET_R,   XSET_R,   XSET_R,   XSET_R,   XSET_R,   XSET,     XSET_R,   // C0..C7
                XSET_R,   XSET_R,   XSET_R,   XSET_R,   XSET_R,   XSET_R,   XSET,     XSET_R,   // C8..CF
                XSET_R,   XSET_R,   XSET_R,   XSET_R,   XSET_R,   XSET_R,   XSET,     XSET_R,   // D0..D7
                XSET_R,   XSET_R,   XSET_R,   XSET_R,   XSET_R,   XSET_R,   XSET,     XSET_R,   // D8..DF
                XSET_R,   XSET_R,   XSET_R,   XSET_R,   XSET_R,   XSET_R,   XSET,     XSET_R,   // E0..E7
                XSET_R,   XSET_R,   XSET_R,   XSET_R,   XSET_R,   XSET_R,   XSET,     XSET_R,   // E8..EF
                XSET_R,   XSET_R,   XSET_R,   XSET_R,   XSET_R,   XSET_R,   XSET,     XSET_R,   // F0..F7
                XSET_R,   XSET_R,   XSET_R,   XSET_R,   XSET_R,   XSET_R,   XSET,     XSET_R,   // F8..FF
            };
        }

        private void XSET(byte arg1, ushort arg2)
        {
            throw new NotImplementedException();
        }

        private void XSET_R(byte arg1, ushort arg2)
        {
            throw new NotImplementedException();
        }

        private void XRES(byte arg1, ushort arg2)
        {
            throw new NotImplementedException();
        }

        private void XRES_R(byte arg1, ushort arg2)
        {
            throw new NotImplementedException();
        }

        private void XBITN(byte arg1, ushort arg2)
        {
            throw new NotImplementedException();
        }

        private void XBITN_R(byte arg1, ushort arg2)
        {
            throw new NotImplementedException();
        }

        private void XSRL(byte arg1, ushort arg2)
        {
            throw new NotImplementedException();
        }

        private void XSRL_R(byte arg1, ushort arg2)
        {
            throw new NotImplementedException();
        }

        private void XSLL(byte arg1, ushort arg2)
        {
            throw new NotImplementedException();
        }

        private void XSLL_R(byte arg1, ushort arg2)
        {
            throw new NotImplementedException();
        }

        private void XSRA(byte arg1, ushort arg2)
        {
            throw new NotImplementedException();
        }

        private void XSRA_R(byte arg1, ushort arg2)
        {
            throw new NotImplementedException();
        }

        private void XSLA(byte arg1, ushort arg2)
        {
            throw new NotImplementedException();
        }

        private void XSLA_R(byte arg1, ushort arg2)
        {
            throw new NotImplementedException();
        }

        private void XRR(byte arg1, ushort arg2)
        {
            throw new NotImplementedException();
        }

        private void XRR_R(byte arg1, ushort arg2)
        {
            throw new NotImplementedException();
        }

        private void XRL(byte arg1, ushort arg2)
        {
            throw new NotImplementedException();
        }

        private void XRL_R(byte arg1, ushort arg2)
        {
            throw new NotImplementedException();
        }

        private void XRRC(byte arg1, ushort arg2)
        {
            throw new NotImplementedException();
        }

        private void XRRC_R(byte arg1, ushort arg2)
        {
            throw new NotImplementedException();
        }

        private void XRLC(byte arg1, ushort arg2)
        {
            throw new NotImplementedException();
        }

        private void XRLC_R(byte arg1, ushort arg2)
        {
            throw new NotImplementedException();
        }
    }
}