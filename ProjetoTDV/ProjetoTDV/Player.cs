using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTDV
{
    public class Player
    {
        private Point position;
        
        public Point Position => position;
         
        public Player(int x,int y) 
        {
            position = new Point(x,y);
        }
    }
}
