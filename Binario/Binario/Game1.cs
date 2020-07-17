using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Binario
{
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Texture2D player_Sprite;
        Texture2D player_Sprite_Left;
        Texture2D player_Sprite_Run;
        Texture2D player_Sprite_Attack;
        Texture2D player_Sprite_Jump;
        Texture2D player_Sprite_Walk_Attack;
        Texture2D player_Sprite_Idle;


        Player.Player Player = new Player.Player();
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = 1280;
            graphics.PreferredBackBufferHeight = 720;
        }
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();

        }
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            player_Sprite = Content.Load<Texture2D>("Player/Dude_Monster");
            player_Sprite_Run = Content.Load<Texture2D>("Player/Dude_Monster_Run_6");
            

            Player.animations[0] = new AnimatedSprite(player_Sprite_Idle, 1, 4);
            Player.animations[1] = new AnimatedSprite(player_Sprite_Run, 1, 6);
            Player.animations[2] = new AnimatedSprite(player_Sprite_Attack, 1, 4);
            Player.animations[3] = new AnimatedSprite(player_Sprite_Jump, 1, 8);
            Player.animations[4] = new AnimatedSprite(player_Sprite_Walk_Attack, 1, 6);

        }
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            Player.Update(gameTime, spriteBatch);

            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            Player.Anim.Draw(spriteBatch, Player.Position);
            Player.Position.X++;
            spriteBatch.Begin();

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
