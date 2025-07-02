#include "GameEngine.h" // Include our custom GameEngine class header.
#include <iostream>     // For basic console output.

int main(int argc, char* argv[]) {
    GameEngine engine; // Create an instance (object) of our GameEngine.

    // Attempt to initialize the engine. If it fails, print error and exit.
    if (!engine.Initialize()) {
        std::cerr << "Failed to initialize game engine!" << std::endl;
        return 1; // Return non-zero to indicate an error.
    }

    // Run the main game loop. This function will block until the user closes the window.
    engine.Run();

    // The engine's destructor (~GameEngine()) will automatically call Clean() here,
    // ensuring all SDL resources are properly released.

    return 0; // Return 0 to indicate successful program execution.
}