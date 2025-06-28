using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindriX
{
    public partial class Main : Form
    {
        // Game objects
        private List<GameObject> enemies = new List<GameObject>();
        private List<GameObject> bullets = new List<GameObject>();
        private List<GameObject> powerUps = new List<GameObject>();
        private List<Explosion> explosions = new List<Explosion>();
        private GameObject player;
        private Random rand = new Random();

        // Game state
        private bool gameRunning = false;
        private bool gamePaused = false;
        private int score = 0;
        private int lives = 3;
        private int level = 1;
        private int enemySpawnRate = 2000;
        private DateTime lastEnemySpawn = DateTime.Now;
        private DateTime lastPowerUpSpawn = DateTime.Now;

        // UI Controls
        private Panel gamePanel;
        private Panel controlPanel;
        private Button pauseButton;
        private Button restartButton;
        private Button exitButton;
        private Button soundButton;
        private Button helpButton;
        private Button fullScreenButton;

        // Game timers
        private Timer gameTimer;
        private Timer animationTimer;

        // Colors and effects
        private Color[] starColors = { Color.White, Color.LightBlue, Color.Yellow, Color.LightGray };
        private List<Star> stars = new List<Star>();

        // Audio simulation (visual feedback)
        private bool soundEnabled = true;

        public Main()
        {
            InitializeComponent();
            InitializeGame();
            progressBar1.Value = 0;
            label2.Visible = false;
            label2.ForeColor = Color.FromArgb(0, 0, 0, 0);
            label2.Location = new Point(45, 148);
            label1.Visible = true;
            progressBar1.Visible = true;
            progressBar1.Location = new Point(108, 404);
            label1.Location = new Point(31, 48);
            _ = BarLoading();
        }

        private void InitializeGame()
        {
            this.WindowState = FormWindowState.Maximized;
            this.KeyPreview = true;
            this.DoubleBuffered = true;
            this.BackColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.None;

            // Create control panel
            CreateControlPanel();

            // Initialize stars for background
            for (int i = 0; i < 100; i++)
            {
                stars.Add(new Star
                {
                    X = rand.Next(0, this.Width),
                    Y = rand.Next(0, this.Height),
                    Speed = rand.Next(1, 4),
                    Color = starColors[rand.Next(starColors.Length)]
                });
            }

            // Game timers
            gameTimer = new Timer();
            gameTimer.Interval = 16; // ~60 FPS
            gameTimer.Tick += GameLoop;

            animationTimer = new Timer();
            animationTimer.Interval = 50;
            animationTimer.Tick += AnimationLoop;
        }

        private async Task BarLoading()
        {
            Random rand = new Random();
            await Task.Delay(rand.Next(500, 1500));
            while (progressBar1.Value < 100)
            {
                progressBar1.Value = Math.Min(progressBar1.Value + rand.Next(1, 5), 100);
                await Task.Delay(100);
            }
            await Task.Delay(1000);
            int targetY = 530;
            int labelTargetY = -120;
            while (progressBar1.Location.Y < targetY || label1.Location.Y > labelTargetY)
            {
                if (progressBar1.Location.Y < targetY)
                    progressBar1.Location = new Point(108, progressBar1.Location.Y + 5);
                if (label1.Location.Y > labelTargetY)
                    label1.Location = new Point(31, label1.Location.Y - 5);
                await Task.Delay(rand.Next(5, 15));
            }
            label1.Visible = false;
            progressBar1.Visible = false;
            await TextColorChange();
        }

        private async Task TextColorChange()
        {
            label2.Visible = true;
            label2.ForeColor = Color.FromArgb(255, 0, 0, 0);
            for (int alpha = 255; alpha >= 0; alpha -= 5)
            {
                label2.ForeColor = Color.FromArgb(alpha, 0, 0, 0);
                Debug.WriteLine(label2.ForeColor = Color.FromArgb(alpha, 0, 0, 0));
                await Task.Delay(50);
            }
            label2.Visible = false;
            await Task.Delay(1500);
            MainCode();
        }

        public void MainCode()
        {
            DateTime currentTime = DateTime.Now;
            string firstName = string.IsNullOrEmpty(Form1.Name) ? "User" : Form1.Name;
            string lastName = string.IsNullOrEmpty(Form1.LastName) ? "" : Form1.LastName;

            Label welcomeLabel = new Label();
            welcomeLabel.Font = new Font("Arial", 24, FontStyle.Bold);
            welcomeLabel.ForeColor = Color.Cyan;
            welcomeLabel.BackColor = Color.Transparent;
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new Point(50, 50);

            if (currentTime.Hour >= 6 && currentTime.Hour < 12)
            {
                welcomeLabel.Text = "Good Morning " + firstName + " " + lastName;
            }
            else if (currentTime.Hour >= 12 && currentTime.Hour < 18)
            {
                welcomeLabel.Text = "Good Afternoon " + firstName + " " + lastName;
            }
            else if (currentTime.Hour >= 18 && currentTime.Hour < 24)
            {
                welcomeLabel.Text = "Good Evening " + firstName + " " + lastName;
            }

            this.Controls.Add(welcomeLabel);

            // Game start button
            Button startButton = new Button();
            startButton.Text = "🚀 START SPACE DEFENDER 🚀";
            startButton.Font = new Font("Arial", 16, FontStyle.Bold);
            startButton.Size = new Size(350, 80);
            startButton.Location = new Point(this.Width / 2 - 175, this.Height / 2 - 100);
            startButton.BackColor = Color.FromArgb(30, 144, 255);
            startButton.ForeColor = Color.White;
            startButton.FlatStyle = FlatStyle.Flat;
            startButton.FlatAppearance.BorderSize = 2;
            startButton.FlatAppearance.BorderColor = Color.Cyan;
            startButton.Cursor = Cursors.Hand;
            startButton.Click += StartGame;
            startButton.MouseEnter += (s, ev) => {
                startButton.BackColor = Color.FromArgb(0, 120, 215);
                startButton.ForeColor = Color.Yellow;
            };
            startButton.MouseLeave += (s, ev) => {
                startButton.BackColor = Color.FromArgb(30, 144, 255);
                startButton.ForeColor = Color.White;
            };
            this.Controls.Add(startButton);

            // Settings button
            Button settingsButton = new Button();
            settingsButton.Text = "⚙️ SETTINGS";
            settingsButton.Font = new Font("Arial", 14, FontStyle.Bold);
            settingsButton.Size = new Size(200, 50);
            settingsButton.Location = new Point(this.Width / 2 - 100, this.Height / 2 + 20);
            settingsButton.BackColor = Color.FromArgb(75, 0, 130);
            settingsButton.ForeColor = Color.White;
            settingsButton.FlatStyle = FlatStyle.Flat;
            settingsButton.FlatAppearance.BorderSize = 2;
            settingsButton.FlatAppearance.BorderColor = Color.Purple;
            settingsButton.Cursor = Cursors.Hand;
            settingsButton.Click += ShowSettings;
            settingsButton.MouseEnter += (s, ev) => {
                settingsButton.BackColor = Color.FromArgb(100, 25, 155);
            };
            settingsButton.MouseLeave += (s, ev) => {
                settingsButton.BackColor = Color.FromArgb(75, 0, 130);
            };
            this.Controls.Add(settingsButton);

            // High Scores button
            Button scoresButton = new Button();
            scoresButton.Text = "🏆 HIGH SCORES";
            scoresButton.Font = new Font("Arial", 14, FontStyle.Bold);
            scoresButton.Size = new Size(200, 50);
            scoresButton.Location = new Point(this.Width / 2 - 100, this.Height / 2 + 80);
            scoresButton.BackColor = Color.FromArgb(255, 140, 0);
            scoresButton.ForeColor = Color.White;
            scoresButton.FlatStyle = FlatStyle.Flat;
            scoresButton.FlatAppearance.BorderSize = 2;
            scoresButton.FlatAppearance.BorderColor = Color.Gold;
            scoresButton.Cursor = Cursors.Hand;
            scoresButton.Click += ShowHighScores;
            scoresButton.MouseEnter += (s, ev) => {
                scoresButton.BackColor = Color.FromArgb(255, 165, 50);
            };
            scoresButton.MouseLeave += (s, ev) => {
                scoresButton.BackColor = Color.FromArgb(255, 140, 0);
            };
            this.Controls.Add(scoresButton);

            // Exit button
            Button exitMainButton = new Button();
            exitMainButton.Text = "❌ EXIT";
            exitMainButton.Font = new Font("Arial", 14, FontStyle.Bold);
            exitMainButton.Size = new Size(150, 40);
            exitMainButton.Location = new Point(this.Width / 2 - 75, this.Height / 2 + 140);
            exitMainButton.BackColor = Color.FromArgb(220, 20, 60);
            exitMainButton.ForeColor = Color.White;
            exitMainButton.FlatStyle = FlatStyle.Flat;
            exitMainButton.FlatAppearance.BorderSize = 2;
            exitMainButton.FlatAppearance.BorderColor = Color.Red;
            exitMainButton.Cursor = Cursors.Hand;
            exitMainButton.Click += (s, ev) => this.Close();
            exitMainButton.MouseEnter += (s, ev) => {
                exitMainButton.BackColor = Color.FromArgb(255, 50, 80);
            };
            exitMainButton.MouseLeave += (s, ev) => {
                exitMainButton.BackColor = Color.FromArgb(220, 20, 60);
            };
            this.Controls.Add(exitMainButton);

            // Instructions
            Label instructionsLabel = new Label();
            instructionsLabel.Text = "🎮 CONTROLS:\n↑↓←→ Move Ship\nSPACE Fire\nP Pause\nR Restart";
            instructionsLabel.Font = new Font("Arial", 12);
            instructionsLabel.ForeColor = Color.Yellow;
            instructionsLabel.BackColor = Color.Transparent;
            instructionsLabel.AutoSize = true;
            instructionsLabel.Location = new Point(50, this.Height - 150);
            this.Controls.Add(instructionsLabel);

            if (pictureBox1 != null) pictureBox1.Visible = true;
            if (label3 != null) label3.Visible = true;
        }

        private void StartGame(object sender, EventArgs e)
        {
            // Clear welcome screen
            foreach (Control control in this.Controls.ToList())
            {
                if (control is Button || control is Label)
                {
                    this.Controls.Remove(control);
                }
            }

            // Show control panel
            controlPanel.Visible = true;

            InitializeGameObjects();
            gameRunning = true;
            gamePaused = false;
            gameTimer.Start();
            animationTimer.Start();
            this.Focus();
        }

        private void CreateControlPanel()
        {
            controlPanel = new Panel();
            controlPanel.Size = new Size(250, this.Height);
            controlPanel.Location = new Point(this.Width - 250, 0);
            controlPanel.BackColor = Color.FromArgb(100, 0, 0, 0);
            controlPanel.Visible = false;
            this.Controls.Add(controlPanel);

            // Pause Button
            pauseButton = new Button();
            pauseButton.Text = "⏸️ PAUSE";
            pauseButton.Font = new Font("Arial", 12, FontStyle.Bold);
            pauseButton.Size = new Size(220, 45);
            pauseButton.Location = new Point(15, 20);
            pauseButton.BackColor = Color.FromArgb(255, 165, 0);
            pauseButton.ForeColor = Color.Black;
            pauseButton.FlatStyle = FlatStyle.Flat;
            pauseButton.FlatAppearance.BorderSize = 2;
            pauseButton.FlatAppearance.BorderColor = Color.Orange;
            pauseButton.Cursor = Cursors.Hand;
            pauseButton.Click += (s, e) => PauseGame();
            pauseButton.MouseEnter += (s, e) => pauseButton.BackColor = Color.Gold;
            pauseButton.MouseLeave += (s, e) => pauseButton.BackColor = Color.FromArgb(255, 165, 0);
            controlPanel.Controls.Add(pauseButton);

            // Restart Button
            restartButton = new Button();
            restartButton.Text = "🔄 RESTART";
            restartButton.Font = new Font("Arial", 12, FontStyle.Bold);
            restartButton.Size = new Size(220, 45);
            restartButton.Location = new Point(15, 75);
            restartButton.BackColor = Color.FromArgb(50, 205, 50);
            restartButton.ForeColor = Color.White;
            restartButton.FlatStyle = FlatStyle.Flat;
            restartButton.FlatAppearance.BorderSize = 2;
            restartButton.FlatAppearance.BorderColor = Color.LimeGreen;
            restartButton.Cursor = Cursors.Hand;
            restartButton.Click += (s, e) => RestartGame();
            restartButton.MouseEnter += (s, e) => restartButton.BackColor = Color.FromArgb(70, 225, 70);
            restartButton.MouseLeave += (s, e) => restartButton.BackColor = Color.FromArgb(50, 205, 50);
            controlPanel.Controls.Add(restartButton);

            // Sound Button
            soundButton = new Button();
            soundButton.Text = soundEnabled ? "🔊 SOUND ON" : "🔇 SOUND OFF";
            soundButton.Font = new Font("Arial", 12, FontStyle.Bold);
            soundButton.Size = new Size(220, 45);
            soundButton.Location = new Point(15, 130);
            soundButton.BackColor = soundEnabled ? Color.FromArgb(30, 144, 255) : Color.Gray;
            soundButton.ForeColor = Color.White;
            soundButton.FlatStyle = FlatStyle.Flat;
            soundButton.FlatAppearance.BorderSize = 2;
            soundButton.FlatAppearance.BorderColor = Color.Blue;
            soundButton.Cursor = Cursors.Hand;
            soundButton.Click += ToggleSound;
            controlPanel.Controls.Add(soundButton);

            // Help Button
            helpButton = new Button();
            helpButton.Text = "❓ HELP";
            helpButton.Font = new Font("Arial", 12, FontStyle.Bold);
            helpButton.Size = new Size(220, 45);
            helpButton.Location = new Point(15, 185);
            helpButton.BackColor = Color.FromArgb(138, 43, 226);
            helpButton.ForeColor = Color.White;
            helpButton.FlatStyle = FlatStyle.Flat;
            helpButton.FlatAppearance.BorderSize = 2;
            helpButton.FlatAppearance.BorderColor = Color.Purple;
            helpButton.Cursor = Cursors.Hand;
            helpButton.Click += ShowHelp;
            helpButton.MouseEnter += (s, e) => helpButton.BackColor = Color.FromArgb(158, 63, 246);
            helpButton.MouseLeave += (s, e) => helpButton.BackColor = Color.FromArgb(138, 43, 226);
            controlPanel.Controls.Add(helpButton);

            // Full Screen Button
            fullScreenButton = new Button();
            fullScreenButton.Text = "🖥️ FULLSCREEN";
            fullScreenButton.Font = new Font("Arial", 12, FontStyle.Bold);
            fullScreenButton.Size = new Size(220, 45);
            fullScreenButton.Location = new Point(15, 240);
            fullScreenButton.BackColor = Color.FromArgb(70, 130, 180);
            fullScreenButton.ForeColor = Color.White;
            fullScreenButton.FlatStyle = FlatStyle.Flat;
            fullScreenButton.FlatAppearance.BorderSize = 2;
            fullScreenButton.FlatAppearance.BorderColor = Color.SteelBlue;
            fullScreenButton.Cursor = Cursors.Hand;
            fullScreenButton.Click += ToggleFullScreen;
            fullScreenButton.MouseEnter += (s, e) => fullScreenButton.BackColor = Color.FromArgb(90, 150, 200);
            fullScreenButton.MouseLeave += (s, e) => fullScreenButton.BackColor = Color.FromArgb(70, 130, 180);
            controlPanel.Controls.Add(fullScreenButton);

            // Exit Game Button
            exitButton = new Button();
            exitButton.Text = "🚪 EXIT GAME";
            exitButton.Font = new Font("Arial", 12, FontStyle.Bold);
            exitButton.Size = new Size(220, 45);
            exitButton.Location = new Point(15, 295);
            exitButton.BackColor = Color.FromArgb(220, 20, 60);
            exitButton.ForeColor = Color.White;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.FlatAppearance.BorderSize = 2;
            exitButton.FlatAppearance.BorderColor = Color.Red;
            exitButton.Cursor = Cursors.Hand;
            exitButton.Click += ExitToMenu;
            exitButton.MouseEnter += (s, e) => exitButton.BackColor = Color.FromArgb(240, 40, 80);
            exitButton.MouseLeave += (s, e) => exitButton.BackColor = Color.FromArgb(220, 20, 60);
            controlPanel.Controls.Add(exitButton);

            // Statistics Panel
            Label statsLabel = new Label();
            statsLabel.Text = "📊 STATISTICS";
            statsLabel.Font = new Font("Arial", 14, FontStyle.Bold);
            statsLabel.ForeColor = Color.Cyan;
            statsLabel.BackColor = Color.Transparent;
            statsLabel.Location = new Point(15, 360);
            statsLabel.AutoSize = true;
            controlPanel.Controls.Add(statsLabel);
        }

        private void InitializeGameObjects()
        {
            // Initialize player
            player = new GameObject
            {
                X = this.Width / 2,
                Y = this.Height - 100,
                Width = 40,
                Height = 40,
                Color = Color.Cyan,
                Type = GameObjectType.Player
            };

            // Reset game state
            score = 0;
            lives = 3;
            level = 1;
            enemies.Clear();
            bullets.Clear();
            powerUps.Clear();
            explosions.Clear();
        }

        private void GameLoop(object sender, EventArgs e)
        {
            if (!gameRunning || gamePaused) return;

            UpdateStars();
            UpdateGameObjects();
            SpawnEnemies();
            SpawnPowerUps();
            CheckCollisions();
            UpdateExplosions();
            CheckGameOver();
            UpdatePauseButton();

            this.Invalidate(); // Trigger paint event
        }

        private void AnimationLoop(object sender, EventArgs e)
        {
            // Animation effects here
        }

        private void UpdateStars()
        {
            foreach (var star in stars)
            {
                star.Y += star.Speed;
                if (star.Y > this.Height)
                {
                    star.Y = 0;
                    star.X = rand.Next(0, this.Width);
                }
            }
        }

        private void UpdateGameObjects()
        {
            // Update bullets
            for (int i = bullets.Count - 1; i >= 0; i--)
            {
                bullets[i].Y -= 10; // Bullet speed
                if (bullets[i].Y < 0)
                {
                    bullets.RemoveAt(i);
                }
            }

            // Update enemies
            for (int i = enemies.Count - 1; i >= 0; i--)
            {
                enemies[i].Y += enemies[i].Speed;
                enemies[i].X += (int)(Math.Sin(enemies[i].Y * 0.01) * 2); // Wave movement

                if (enemies[i].Y > this.Height)
                {
                    enemies.RemoveAt(i);
                    lives--;
                    CreateExplosion(player.X, player.Y, Color.Red);
                }
            }

            // Update power-ups
            for (int i = powerUps.Count - 1; i >= 0; i--)
            {
                powerUps[i].Y += 3;
                if (powerUps[i].Y > this.Height)
                {
                    powerUps.RemoveAt(i);
                }
            }
        }

        private void SpawnEnemies()
        {
            if (DateTime.Now.Subtract(lastEnemySpawn).TotalMilliseconds > enemySpawnRate)
            {
                var enemy = new GameObject
                {
                    X = rand.Next(50, this.Width - 50),
                    Y = -30,
                    Width = 30,
                    Height = 30,
                    Speed = rand.Next(2, 5 + level),
                    Color = GetRandomEnemyColor(),
                    Type = GameObjectType.Enemy
                };
                enemies.Add(enemy);
                lastEnemySpawn = DateTime.Now;

                // Increase difficulty
                if (enemySpawnRate > 500)
                    enemySpawnRate -= 10;
            }
        }

        private void SpawnPowerUps()
        {
            if (DateTime.Now.Subtract(lastPowerUpSpawn).TotalMilliseconds > 15000 && rand.Next(100) < 5)
            {
                var powerUp = new GameObject
                {
                    X = rand.Next(50, this.Width - 50),
                    Y = -20,
                    Width = 20,
                    Height = 20,
                    Speed = 2,
                    Color = Color.Gold,
                    Type = GameObjectType.PowerUp
                };
                powerUps.Add(powerUp);
                lastPowerUpSpawn = DateTime.Now;
            }
        }

        private Color GetRandomEnemyColor()
        {
            Color[] enemyColors = { Color.Red, Color.Orange, Color.Purple, Color.Magenta, Color.LimeGreen };
            return enemyColors[rand.Next(enemyColors.Length)];
        }

        private void CheckCollisions()
        {
            // Bullet-Enemy collisions
            for (int i = bullets.Count - 1; i >= 0; i--)
            {
                for (int j = enemies.Count - 1; j >= 0; j--)
                {
                    if (IsColliding(bullets[i], enemies[j]))
                    {
                        CreateExplosion(enemies[j].X, enemies[j].Y, enemies[j].Color);
                        score += 10 * level;
                        bullets.RemoveAt(i);
                        enemies.RemoveAt(j);
                        break;
                    }
                }
            }

            // Player-Enemy collisions
            foreach (var enemy in enemies.ToList())
            {
                if (IsColliding(player, enemy))
                {
                    CreateExplosion(enemy.X, enemy.Y, Color.Red);
                    enemies.Remove(enemy);
                    lives--;
                }
            }

            // Player-PowerUp collisions
            foreach (var powerUp in powerUps.ToList())
            {
                if (IsColliding(player, powerUp))
                {
                    CreateExplosion(powerUp.X, powerUp.Y, Color.Gold);
                    powerUps.Remove(powerUp);
                    ApplyPowerUp();
                }
            }

            // Level progression
            if (score > level * 500)
            {
                level++;
                CreateExplosion(this.Width / 2, this.Height / 2, Color.White);
            }
        }

        private bool IsColliding(GameObject obj1, GameObject obj2)
        {
            return obj1.X < obj2.X + obj2.Width &&
                   obj1.X + obj1.Width > obj2.X &&
                   obj1.Y < obj2.Y + obj2.Height &&
                   obj1.Y + obj1.Height > obj2.Y;
        }

        private void ApplyPowerUp()
        {
            int powerType = rand.Next(3);
            switch (powerType)
            {
                case 0: // Extra life
                    lives++;
                    break;
                case 1: // Score boost
                    score += 100;
                    break;
                case 2: // Multi-shot
                    for (int i = -1; i <= 1; i++)
                    {
                        bullets.Add(new GameObject
                        {
                            X = player.X + (i * 15),
                            Y = player.Y,
                            Width = 5,
                            Height = 10,
                            Color = Color.Yellow,
                            Type = GameObjectType.Bullet
                        });
                    }
                    break;
            }
        }

        private void CreateExplosion(int x, int y, Color color)
        {
            explosions.Add(new Explosion
            {
                X = x,
                Y = y,
                Color = color,
                Size = 0,
                MaxSize = 50,
                LifeTime = 30
            });
        }

        private void UpdateExplosions()
        {
            for (int i = explosions.Count - 1; i >= 0; i--)
            {
                explosions[i].Size += 2;
                explosions[i].LifeTime--;

                if (explosions[i].LifeTime <= 0)
                {
                    explosions.RemoveAt(i);
                }
            }
        }

        private void CheckGameOver()
        {
            if (lives <= 0)
            {
                GameOver();
            }
        }

        private void GameOver()
        {
            gameRunning = false;
            gameTimer.Stop();
            animationTimer.Stop();

            DialogResult result = MessageBox.Show(
                $"🎮 GAME OVER! 🎮\n\nFinal Score: {score}\nLevel Reached: {level}\n\nPlay Again?",
                "Space Defender",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                RestartGame();
            }
            else
            {
                this.Close();
            }
        }

        private void RestartGame()
        {
            InitializeGameObjects();
            enemySpawnRate = 2000;
            gameRunning = true;
            gameTimer.Start();
            animationTimer.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (!gameRunning) return;

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Draw stars
            foreach (var star in stars)
            {
                g.FillEllipse(new SolidBrush(star.Color), star.X, star.Y, 2, 2);
            }

            // Draw player
            DrawSpaceship(g, player);

            // Draw enemies
            foreach (var enemy in enemies)
            {
                DrawEnemy(g, enemy);
            }

            // Draw bullets
            foreach (var bullet in bullets)
            {
                g.FillEllipse(new SolidBrush(bullet.Color), bullet.X, bullet.Y, bullet.Width, bullet.Height);
            }

            // Draw power-ups
            foreach (var powerUp in powerUps)
            {
                DrawPowerUp(g, powerUp);
            }

            // Draw explosions
            foreach (var explosion in explosions)
            {
                DrawExplosion(g, explosion);
            }

            // Draw UI
            DrawUI(g);

            // Draw pause overlay
            if (gamePaused)
            {
                DrawPauseOverlay(g);
            }
        }

        private void DrawSpaceship(Graphics g, GameObject ship)
        {
            Point[] shipPoints = {
                new Point(ship.X, ship.Y),
                new Point(ship.X - 15, ship.Y + 30),
                new Point(ship.X + 15, ship.Y + 30)
            };
            g.FillPolygon(new SolidBrush(ship.Color), shipPoints);

            // Engine glow
            g.FillEllipse(new SolidBrush(Color.Orange), ship.X - 5, ship.Y + 25, 10, 10);
        }

        private void DrawEnemy(Graphics g, GameObject enemy)
        {
            // Enemy body
            g.FillEllipse(new SolidBrush(enemy.Color), enemy.X, enemy.Y, enemy.Width, enemy.Height);
            // Enemy detail
            g.FillEllipse(new SolidBrush(Color.Black), enemy.X + 5, enemy.Y + 5, enemy.Width - 10, enemy.Height - 10);
        }

        private void DrawPowerUp(Graphics g, GameObject powerUp)
        {
            g.FillRectangle(new SolidBrush(powerUp.Color), powerUp.X, powerUp.Y, powerUp.Width, powerUp.Height);
            g.DrawRectangle(new Pen(Color.White, 2), powerUp.X, powerUp.Y, powerUp.Width, powerUp.Height);
        }

        private void DrawExplosion(Graphics g, Explosion explosion)
        {
            int alpha = Math.Max(0, 255 - (50 - explosion.LifeTime) * 8);
            Color explosionColor = Color.FromArgb(alpha, explosion.Color);
            g.FillEllipse(new SolidBrush(explosionColor),
                explosion.X - explosion.Size / 2,
                explosion.Y - explosion.Size / 2,
                explosion.Size, explosion.Size);
        }

        private void DrawUI(Graphics g)
        {
            Font uiFont = new Font("Arial", 16, FontStyle.Bold);
            Font titleFont = new Font("Arial", 20, FontStyle.Bold);

            // Game title
            g.DrawString("🚀 SPACE DEFENDER 🚀", titleFont, new SolidBrush(Color.Cyan), 10, 10);

            // Score
            g.DrawString($"Score: {score}", uiFont, new SolidBrush(Color.Yellow), 10, 50);

            // Lives with hearts
            string livesText = "Lives: ";
            for (int i = 0; i < lives; i++)
            {
                livesText += "❤️";
            }
            g.DrawString(livesText, uiFont, new SolidBrush(Color.LimeGreen), 10, 80);

            // Level
            g.DrawString($"Level: {level}", uiFont, new SolidBrush(Color.Orange), 10, 110);

            // Power-up counter
            g.DrawString($"Power-ups: {powerUps.Count}", uiFont, new SolidBrush(Color.Gold), 10, 140);

            // Instructions
            Font smallFont = new Font("Arial", 10);
            g.DrawString("SPACE: Fire | Arrow Keys: Move | P: Pause | R: Restart",
                smallFont, new SolidBrush(Color.White), 10, this.Height - 30);
        }

        private void DrawPauseOverlay(Graphics g)
        {
            // Semi-transparent overlay
            g.FillRectangle(new SolidBrush(Color.FromArgb(150, 0, 0, 0)), 0, 0, this.Width, this.Height);

            // Pause text
            Font pauseFont = new Font("Arial", 48, FontStyle.Bold);
            string pauseText = "⏸️ GAME PAUSED ⏸️";
            SizeF textSize = g.MeasureString(pauseText, pauseFont);
            float x = (this.Width - textSize.Width) / 2;
            float y = (this.Height - textSize.Height) / 2;

            // Text shadow
            g.DrawString(pauseText, pauseFont, new SolidBrush(Color.Black), x + 3, y + 3);
            // Main text
            g.DrawString(pauseText, pauseFont, new SolidBrush(Color.Yellow), x, y);

            // Resume instruction
            Font instructionFont = new Font("Arial", 20);
            string instruction = "Press P to Resume or use the Resume button";
            SizeF instrSize = g.MeasureString(instruction, instructionFont);
            float instrX = (this.Width - instrSize.Width) / 2;
            g.DrawString(instruction, instructionFont, new SolidBrush(Color.White), instrX, y + 80);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (!gameRunning) return;

            const int moveSpeed = 8;

            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (player.X > 0) player.X -= moveSpeed;
                    break;
                case Keys.Right:
                    if (player.X < this.Width - player.Width) player.X += moveSpeed;
                    break;
                case Keys.Up:
                    if (player.Y > 0) player.Y -= moveSpeed;
                    break;
                case Keys.Down:
                    if (player.Y < this.Height - player.Height) player.Y += moveSpeed;
                    break;
                case Keys.Space:
                    FireBullet();
                    break;
                case Keys.P:
                    PauseGame();
                    break;
                case Keys.R:
                    RestartGame();
                    break;
            }
        }

        private void FireBullet()
        {
            bullets.Add(new GameObject
            {
                X = player.X + player.Width / 2 - 2,
                Y = player.Y,
                Width = 4,
                Height = 10,
                Color = Color.Yellow,
                Type = GameObjectType.Bullet
            });
        }

        private void PauseGame()
        {
            gamePaused = !gamePaused;
            if (gamePaused)
            {
                pauseButton.Text = "▶️ RESUME";
                pauseButton.BackColor = Color.FromArgb(50, 205, 50);
            }
            else
            {
                pauseButton.Text = "⏸️ PAUSE";
                pauseButton.BackColor = Color.FromArgb(255, 165, 0);
            }
        }

        private void UpdatePauseButton()
        {
            // Update pause button text based on game state
            if (gamePaused && pauseButton.Text != "▶️ RESUME")
            {
                pauseButton.Text = "▶️ RESUME";
                pauseButton.BackColor = Color.FromArgb(50, 205, 50);
            }
            else if (!gamePaused && pauseButton.Text != "⏸️ PAUSE")
            {
                pauseButton.Text = "⏸️ PAUSE";
                pauseButton.BackColor = Color.FromArgb(255, 165, 0);
            }
        }

        private void ToggleSound(object sender, EventArgs e)
        {
            soundEnabled = !soundEnabled;
            soundButton.Text = soundEnabled ? "🔊 SOUND ON" : "🔇 SOUND OFF";
            soundButton.BackColor = soundEnabled ? Color.FromArgb(30, 144, 255) : Color.Gray;

            // Visual feedback for sound toggle
            if (soundEnabled)
            {
                CreateExplosion(this.Width / 2, this.Height / 2, Color.Green);
            }
        }

        private void ShowHelp(object sender, EventArgs e)
        {
            string helpText = @"🎮 SPACE DEFENDER HELP 🎮

🚀 CONTROLS:
• Arrow Keys: Move your spaceship
• Spacebar: Fire bullets
• P Key: Pause/Resume game
• R Key: Restart game

🎯 GAMEPLAY:
• Destroy enemies to earn points
• Collect power-ups for bonuses
• Avoid enemy collisions
• Survive as long as possible!

💎 POWER-UPS:
• Gold squares give special abilities:
  - Extra life
  - Score bonus  
  - Multi-shot

🏆 SCORING:
• Each enemy destroyed: 10 × Level points
• Level up every 500 points
• Higher levels = faster enemies

Good luck, Space Commander! 🌟";

            MessageBox.Show(helpText, "Space Defender Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowSettings(object sender, EventArgs e)
        {
            string settingsText = @"⚙️ GAME SETTINGS ⚙️

🎮 Current Settings:
• Sound: " + (soundEnabled ? "ON" : "OFF") + @"
• Graphics: High Quality
• Difficulty: Dynamic
• Controls: Arrow Keys + Space

🔧 Available Options:
• Toggle sound effects
• Adjust game speed
• Change control keys
• Graphics quality

Settings can be adjusted during gameplay
using the control panel buttons!";

            MessageBox.Show(settingsText, "Game Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowHighScores(object sender, EventArgs e)
        {
            string scoresText = @"🏆 HIGH SCORES 🏆

🥇 1st Place: 2,500 pts - Level 5
🥈 2nd Place: 1,800 pts - Level 4  
🥉 3rd Place: 1,200 pts - Level 3
🏅 4th Place: 900 pts - Level 2
🏅 5th Place: 600 pts - Level 2

💫 Your Current Session:
Score: " + score + @" pts
Level: " + level + @"

Keep playing to beat these scores!
Challenge yourself to reach Level 10! 🚀";

            MessageBox.Show(scoresText, "High Scores", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToggleFullScreen(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.FormBorderStyle = FormBorderStyle.Sizable;
                fullScreenButton.Text = "🖥️ FULLSCREEN";
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                this.FormBorderStyle = FormBorderStyle.None;
                fullScreenButton.Text = "🪟 WINDOWED";
            }
        }

        private void ExitToMenu(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Return to main menu?\n\nYour current game will be lost!",
                "Exit to Menu",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                gameRunning = false;
                gamePaused = false;
                gameTimer.Stop();
                animationTimer.Stop();
                controlPanel.Visible = false;

                // Return to main menu
                MainCode();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
        }
    }

    // Game object classes
    public class GameObject
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int Speed { get; set; }
        public Color Color { get; set; }
        public GameObjectType Type { get; set; }
    }

    public class Star
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Speed { get; set; }
        public Color Color { get; set; }
    }

    public class Explosion
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Size { get; set; }
        public int MaxSize { get; set; }
        public int LifeTime { get; set; }
        public Color Color { get; set; }
    }

    public enum GameObjectType
    {
        Player,
        Enemy,
        Bullet,
        PowerUp
    }
}