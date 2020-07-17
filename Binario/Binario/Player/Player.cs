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
    class Player
    {
        public Direction Dir = Direction.Right;
        
        public Vector2 Position = new Vector2(10, 10);
        private int health;
        PlayerInput InputP = new PlayerInput();
        public AnimatedSprite Anim;

        public AnimatedSprite[] animations = new AnimatedSprite[5];

        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        public void Update(GameTime gameTime, SpriteBatch spriteBatch)
        {
            Dir = InputP.Move(Dir);
            switch (Dir)
            {
                case Direction.Right:
                    Anim = animations[0];
                    break;
            }
            Anim.Update(gameTime);
        }
    }
}
