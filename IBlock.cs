using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris
{
    public class IBlock : Block
    {
        private readonly Position[][] tiles = new Position[][]
        {
            new Position[]{ new(1,0), new(1,1), new(1,2), new(1,3)}
        }
    }
}
