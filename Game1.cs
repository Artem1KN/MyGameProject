using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SharpDX.Direct2D1;

namespace GameProject
{
    enum Status { SplashScreen, Game, Pause, Ending}
    public class Game1 : Game
    {
        GraphicsDeviceManager _graphics;
        Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch;
        Status _status= Status.SplashScreen;
        Player player;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 1920;
            _graphics.PreferredBackBufferHeight = 1080;
            _graphics.IsFullScreen = true;
            _graphics.ApplyChanges();

            _status = Status.SplashScreen;

            player = new Player(Content.Load<Texture2D>("amogus"), new Vector2(0,0));

            string map = "B\r\nB\r\nB\r\nB                     BBB  BBB\r\nB                 BBB\r\nB          BBBBBB\r\nB   P     BBBBBBB\r\nBBBBBBBBBBBBBBBBB              BBBBBBBB";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new Microsoft.Xna.Framework.Graphics.SpriteBatch(GraphicsDevice);
            // TODO: use this.Content to load your game content here
            SplashScreen.Bacground = Content.Load<Texture2D>("PLACEHOLDERBACKGROUND");
        }

        protected override void Update(GameTime gameTime)
        {
            switch (_status)
            {
                case Status.SplashScreen:
                    SplashScreen.Update();
                    if(Keyboard.GetState().IsKeyDown(Keys.Enter)) _status= Status.Game;
                    break;
                case Status.Game:
                    if (Keyboard.GetState().IsKeyDown(Keys.Escape)) _status = Status.Pause;
                    break;
            }
            
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            SplashScreen.Update();
            player.Update(gameTime);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            SplashScreen.Draw(spriteBatch);
            player.Draw(spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}

//spriteBatch.Draw(playerT, new Vector2(0, 0), Color.White);