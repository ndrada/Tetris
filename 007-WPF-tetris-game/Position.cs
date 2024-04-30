using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_WPF_tetris_game
{
    public class Position
    {
        //this class will store a row and a column
        public int Row {  get; set; }
        public int Column { get; set; }

        public Position(int row, int column) //constructor
        {
            Row = row;
            Column = column;
        }
    }
}
