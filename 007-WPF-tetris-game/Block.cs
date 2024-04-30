using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_WPF_tetris_game
{
    //abstract class that contains the subclasses for each specific block
    public abstract class Block 
    {
        protected abstract Position[][] Tiles { get; } //2D array that contains the tile position and the 4 rotation states
        protected abstract Position StartOffset { get; } //decides where the blocks bond in the grid
        public abstract int Id { get; } //needed to distinguish the blocks

        private int rotationState;
        private Position offset;

        public Block() //constructor
        {
            offset = new Position(StartOffset.Row, StartOffset.Column);
        }

        public IEnumerable<Position> TilePositions()
        {
            foreach (Position p in Tiles[rotationState])
            {
                yield return new Position(p.Row + offset.Row, p.Column + offset.Column);
            }
        }

        public void RotateCW()
        {
            rotationState = (rotationState + 1) % Tiles.Length;
        }

        public void RotateCCW()
        {
            if (rotationState == 0)
            {
                rotationState = Tiles.Length - 1;
            }
            else
            {
                rotationState--;
            }
        }

        public void Move(int rows, int columns)
        {
            offset.Row += rows;
            offset.Column += columns;
        }

        /*public void Reset()
        {
            rotationState = 0;
            offset.Row = StartOffset.Row;
        }
        */

        public void Reset()
        {
            Console.WriteLine($"Resetting block {Id}");
            rotationState = 0;
            offset = new Position(StartOffset.Row, StartOffset.Column);
            Console.WriteLine($"New offset: {offset.Row}, {offset.Column}");
        }
    }

}
