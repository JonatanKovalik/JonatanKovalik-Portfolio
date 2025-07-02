#ifndef GAMEENGINE_H // Stop multiple inclusions. Smart.
#define GAMEENGINE_H

#include <SDL.h> // Need SDL for graphics magic.

class GameEngine { // Our game's brain.
public:
    GameEngine();  // Startup tasks.
    ~GameEngine(); // Shutdown cleanup.

    bool Initialize(); // Get SDL, window, renderer ready. Returns true if ok.
    void Run();        // The main loop: input, update, draw. Runs forever until told to stop.
    void Clean();      // Release all SDL resources. Keeps things tidy.

private:
    SDL_Window* m_window;     // Our game's display window.
    SDL_Renderer* m_renderer; // Our drawing tool for the window.
    bool m_isRunning;         // True if the game loop should keep running.

    // White rectangle's position. It's a member so its position persists.
    int m_rectX;
    int m_rectY;

    // NEW: Red rectangle's position and size. Also members, so *its* position persists too!
    int m_redRectX;
    int m_redRectY;
    int m_redRectWidth;
    int m_redRectHeight;
};

#endif // GAMEENGINE_H