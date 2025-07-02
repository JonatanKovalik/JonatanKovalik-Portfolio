#include "GameEngine.h" // Get our GameEngine blueprint.
#include <iostream>     // For console messages (errors, debug).
#include <random>       // For generating random numbers.
#include <ctime>        // To make 'rand()' actually random each time we run.

// Constructor: Sets up initial values for everything.
GameEngine::GameEngine()
    : m_window(nullptr), m_renderer(nullptr), m_isRunning(false),
    m_rectX(250), m_rectY(200), // White rect start position.
    m_redRectX(100), m_redRectY(100), // NEW: Red rect start position.
    m_redRectWidth(200), m_redRectHeight(150) // NEW: Red rect size.
{
    std::srand(static_cast<unsigned int>(std::time(nullptr))); // Seed random once.
}

// Destructor: Just calls Clean() for proper shutdown.
GameEngine::~GameEngine() {
    Clean();
}

// Initialize(): Gets SDL, window, and renderer running.
bool GameEngine::Initialize() {
    if (SDL_Init(SDL_INIT_VIDEO) < 0) { /* Handle SDL init error */ return false; }
    m_window = SDL_CreateWindow("LumenCore Engine", SDL_WINDOWPOS_UNDEFINED, SDL_WINDOWPOS_UNDEFINED, 1920, 1080, SDL_WINDOW_SHOWN);
    if (m_window == nullptr) { /* Handle window error */ SDL_Quit(); return false; }
    m_renderer = SDL_CreateRenderer(m_window, -1, SDL_RENDERER_ACCELERATED);
    if (m_renderer == nullptr) { /* Handle renderer error */ SDL_DestroyWindow(m_window); SDL_Quit(); return false; }
    m_isRunning = true;
    std::cout << "Engine initialized successfully." << std::endl;
    return true;
}

// Run(): The core game loop. Input -> Update -> Draw.
void GameEngine::Run() {
    SDL_Event event;

    while (m_isRunning) { // Loop as long as the game is running.
        // Event Handling: Check for user input (keyboard, window close).
        while (SDL_PollEvent(&event)) {
            if (event.type == SDL_QUIT) { m_isRunning = false; } // Quit if window closed.
            else if (event.type == SDL_KEYDOWN) { // Handle key presses for white rect movement.
                switch (event.key.keysym.sym) {
                case SDLK_ESCAPE: m_isRunning = false; break;
                case SDLK_SPACE: m_rectY -= 10; break;
                case SDLK_a: m_rectX -= 5; break;
                case SDLK_d: m_rectX += 5; break;
                case SDLK_w: m_rectY -= 5; break;
                case SDLK_s: m_rectY += 5; break;
                }
            }
            // Add SDL_KEYUP handling if needed...
        }

        // Game State Update: Where the game logic happens.
        SDL_Rect whiteRect = { m_rectX, m_rectY, 300, 200 }; // Current white rect for collision.
        SDL_Rect redRect = { m_redRectX, m_redRectY, m_redRectWidth, m_redRectHeight }; // Current red rect for collision.

        if (SDL_HasIntersection(&whiteRect, &redRect)) { // Check if they hit each other.
            std::cout << "Collision!" << std::endl; // Log the hit.
            // NEW: Randomly move the RED rect by updating its *member variables*. This makes it stick!
            m_redRectX = std::rand() % (1920 - m_redRectWidth);
            m_redRectY = std::rand() % (1080 - m_redRectHeight);
            // Also move the white rect.
            m_rectX = std::rand() % (1920 - 300);
            m_rectY = std::rand() % (1080 - 200);
        }

        // Rendering: Draw everything to the screen.
        SDL_SetRenderDrawColor(m_renderer, 0, 0, 0, 255); // Set black.
        SDL_RenderClear(m_renderer);                      // Clear screen to black.

        SDL_SetRenderDrawColor(m_renderer, 255, 255, 255, 255); // Set white.
        SDL_RenderFillRect(m_renderer, &whiteRect);            // Draw white rect.

        SDL_SetRenderDrawColor(m_renderer, 255, 0, 0, 255);     // Set red.
        SDL_RenderFillRect(m_renderer, &redRect);              // Draw red rect.

        SDL_RenderPresent(m_renderer); // Show what we just drew! (Crucial step)
    }
}

// Clean(): Releases all SDL resources. Essential!
void GameEngine::Clean() {
    if (m_renderer) { SDL_DestroyRenderer(m_renderer); m_renderer = nullptr; }
    if (m_window) { SDL_DestroyWindow(m_window); m_window = nullptr; }
    SDL_Quit();
    std::cout << "Engine shut down gracefully." << std::endl;
}