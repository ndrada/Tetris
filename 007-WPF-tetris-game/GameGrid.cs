using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_WPF_tetris_game
{
    //this class holds a 2D rectangular array
    public class GameGrid
    {
        private readonly int[,] grid;
        public int Rows{ get; }
        public int Cols { get; }


        public int this[int r, int c]
        {
            get => grid[r, c];
            set => grid[r, c] = value;
        }


        //the constructor takes the number of rows and columns as parameters
        public GameGrid(int rows, int columns)
        {
            Rows = rows; //save the no of row
            Cols = columns; //save the no of cols
            grid = new int[rows, columns]; //initialize array
        }


        //CONVENIENCE METHODS
        public bool IsInside(int r, int c) //check if the row/column is inside the grid or not
        {
            return r > 0 && r < Rows && c >= 0 && c < Cols;
        }

        public bool IsEmpty(int r, int c) // check if a given cell is empty or not
        {
            return IsInside(r, c) && grid[r, c] == 0; //must be inside the array and the value at that entry in the array must be 0
        }

        public bool IsRowFull(int r)
        {
            for (int c = 0; c < Cols; c++)
            {
                if (grid[r, c] == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsRowEmpty(int r)
        {
            for (int c = 0; c < Cols; c++)
            {
                if (grid[r, c] != 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void ClearRow(int r)
        {
            for(int c= 0; c < Cols; c++)
            {
                grid[r, c] = 0;

            }
        }

        private void MoveRowDown(int r, int numRows)
        {
            for (int c = 0; c < Cols; c++)
            {
                grid[r + numRows, c] = grid[r, c];
                grid[r, c] = 0;
            }
        }

        public int ClearFullRows()
        {
            int cleared = 0;

            for (int r = Rows-1; r >= 0; r--) //start at the bottom and move up
            {
                if(IsRowFull(r))
                {
                    ClearRow(r);
                    cleared++;
                }
                else if (cleared > 0)
                {
                    MoveRowDown(r, cleared);
                }
            }
            return cleared;
        }
    }
}
