﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI_ImageList
{
    public enum MoveType
    {
        LINE_TO_TOP_AND_LINE_TO_BOTTOM,
        LEFT_TO_RIGHT_AND_RIGHT_TO_LEFT,
        TOP_TO_LINE_AND_BOTTOM_TO_LINE,
        CHANGED
    }
    public class Status
    {
        public MoveType type { get; set; }
        public int Pos1 { get; set; }
        public int Pos2 { get; set; }
    }
}