using Microsoft.Xna.Framework;         // This lets us use basic game stuff like colors, 3D positions (vectors), and math helpers.
using Microsoft.Xna.Framework.Graphics; // This helps us draw things on the screen, like shapes and effects.
using Microsoft.Xna.Framework.Input;    // This allows us to get input from your keyboard, mouse, or game controller.

namespace PixelForge                               // This is like a folder for our code, keeping things organized.
{
    public class Game1 : Game                      // This is our main game class, where all the magic happens.
    {
        private GraphicsDeviceManager _graphics;   // Manages screen settings like window size.
        private SpriteBatch _spriteBatch;          // Used for drawing flat 2D images and text.

        private VertexPositionColor[] _vertices;   // This list holds all the "points" (vertices) of our 3D shapes, each with a color.
        private BasicEffect _effect;               // A simple built-in tool that helps us draw 3D stuff with basic lighting and colors.
        private float _rotationAngle;              // This number keeps track of how much our triangle has rotated.

        public Game1()                             // This is like the game's "setup" part, running once when the game starts.
        {
            _graphics = new GraphicsDeviceManager(this); // Gets the graphics manager ready.
            _graphics.PreferredBackBufferWidth = 1280;   // Sets the game window's width to 1280 pixels.
            _graphics.PreferredBackBufferHeight = 720;  // Sets the game window's height to 720 pixels.
            _graphics.ApplyChanges();                    // Makes the window size changes happen.

            Content.RootDirectory = "Content";           // Tells the game where to find extra files like images or models.
            IsMouseVisible = true;                       // Makes your mouse cursor visible in the game window.
        }

        protected override void Initialize()           // This runs once, right after the setup, to get things ready before drawing.
        {
            base.Initialize();                         // Does some basic setup for the game itself.

            _vertices = new VertexPositionColor[3];    // Creates space for 3 points (vertices) for our triangle.

            _vertices[0] = new VertexPositionColor(new Vector3(0, 1, 0), Color.Red);     // Point 1: At the top (Y=1), colored Red.
            _vertices[1] = new VertexPositionColor(new Vector3(-1, -1, 0), Color.Green); // Point 2: Bottom-left (X=-1, Y=-1), colored Green.
            _vertices[2] = new VertexPositionColor(new Vector3(1, -1, 0), Color.Blue);   // Point 3: Bottom-right (X=1, Y=-1), colored Blue.

            _effect = new BasicEffect(GraphicsDevice);   // Gets our drawing tool (BasicEffect) ready.
            _effect.VertexColorEnabled = true;           // Tells our drawing tool to use the colors we gave to our points.
        }

        protected override void LoadContent()          // This is where we load game assets like pictures or sounds. (Not used much here yet).
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice); // Gets the 2D drawing tool ready.
        }

        protected override void Update(GameTime gameTime) // This runs many times a second, where we handle game logic like movement.
        {
            // Checks if you press the 'Back' button on a controller or 'Escape' key to close the game.
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // Adds a small amount to our rotation angle based on how much time passed since the last frame.
            _rotationAngle += (float)gameTime.ElapsedGameTime.TotalSeconds * 1.0f;
            // Keeps the angle value within a full circle (0 to 2*Pi), so it doesn't get too big.
            _rotationAngle = _rotationAngle % MathHelper.TwoPi;

            base.Update(gameTime);                     // Does basic game updates.
        }

        protected override void Draw(GameTime gameTime)   // This runs many times a second, where we draw everything on the screen.
        {
            // World Matrix: Tells where our object is in the 3D world and how it's rotated.
            // We're telling it to rotate around the Y-axis by our current _rotationAngle.
            _effect.World = Matrix.CreateRotationY(_rotationAngle);

            // View Matrix: This is our "camera." It tells where we are looking from, and what we are looking at.
            _effect.View = Matrix.CreateLookAt(
                new Vector3(0, 0, 5),                    // Camera position: A little bit back on the Z-axis.
                Vector3.Zero,                            // Where the camera is looking: The center of the world.
                Vector3.Up);                             // The camera's "up" direction.
            // Projection Matrix: This makes the 3D world look correct on your flat 2D screen (like how things far away look smaller).
            _effect.Projection = Matrix.CreatePerspectiveFieldOfView(
                MathHelper.ToRadians(45f),               // How wide our view is (Field of View).
                GraphicsDevice.DisplayMode.AspectRatio,  // The screen's width-to-height ratio.
                0.1f,                                    // Closest distance things can be to still be seen.
                100f);                                   // Farthest distance things can be to still be seen.

            GraphicsDevice.Clear(new Color(52, 73, 94)); // Clears the screen with a specific dark blue-gray color.

            foreach (var pass in _effect.CurrentTechnique.Passes) // Goes through each part of our drawing tool's steps.
            {
                pass.Apply();                            // Applies the settings of our drawing tool (BasicEffect).
                GraphicsDevice.DrawUserPrimitives(       // Tells the computer to draw basic shapes.
                    PrimitiveType.TriangleList,          // We're drawing triangles (every 3 points make one triangle).
                    _vertices,                           // Here are the points we want to draw.
                    0,                                   // Start drawing from the very first point.
                    1);                                  // Draw only 1 triangle (since we have 3 points).
            }

            base.Draw(gameTime);                       // Does basic game drawing.
        }
    }
}