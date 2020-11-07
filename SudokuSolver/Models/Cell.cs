﻿using System.Diagnostics;

using Sudoku.Common;

namespace Sudoku.Models
{

    [DebuggerDisplay("[{Index}] value = {Value}, origin = {Sudoku.Common.OriginsMapper.ToName(Origin)}")]
    internal sealed class Cell : CellBase
    {
        public Cell(int index) : base(index)
        {
        }

        public Cell(Cell source) : base(source)                        
        {
        }
    }
}
