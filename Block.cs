using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public abstract class Block
    {
        protected abstract Position[][] Tiles { get; }
        protected abstract Position StartOffSet { get; }
        public abstract int Id { get; }

        private int rotationState;
        private Position offset;

        public Block()
        {
            offset = new Position(StartOffSet.Row, StartOffSet.Column);
        }

        public IEnumerable<Position> TilePositions()
        {
            foreach(Position pos in Tiles[rotationState])
            {
                yield return new Position(pos.Row + offset.Row, pos.Column + offset.Column);
            }
        }
    }
}
