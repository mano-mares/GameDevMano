using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Binario.Player
{
    class PlayerInput
    {
        public Direction Move(Direction Dir)
        {
            KeyboardState kState = Keyboard.GetState();
            if(kState.IsKeyDown(Keys.D) || kState.IsKeyDown(Keys.Right))
            {
                return Direction.Right;
            }
            if(kState.IsKeyDown(Keys.Q) || kState.IsKeyDown(Keys.Left))
            {
                return Direction.Left;
            }
            else
            {
                return Dir;
            }
        }
    }
}
