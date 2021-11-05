using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame_Lession_1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D dinoTexture;
        Texture2D rockTexture;
        Texture2D jungleTexture;



        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            // Make The Window 800 x 500
            _graphics.PreferredBackBufferWidth = 1000;
            _graphics.PreferredBackBufferHeight = 1000;
            _graphics.ApplyChanges();

            this.Window.Title = "My First Monogame Project";


            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            dinoTexture = Content.Load<Texture2D>("Dino");
            rockTexture = Content.Load<Texture2D>("RockRock");
            jungleTexture = Content.Load<Texture2D>("Jungle");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(jungleTexture, new Vector2(0, 0), Color.White);
            _spriteBatch.Draw(rockTexture, new Vector2(100, 600), Color.White);
            _spriteBatch.Draw(dinoTexture, new Vector2(550, 570), Color.White);
            _spriteBatch.Draw(dinoTexture, new Vector2(300, 550), Color.White);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
