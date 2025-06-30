/* --- Information about the code --- \\
      Creater of this code is Jonatan Kovalik
      The code wirtter from 29/06/2025 - 30/06/2025
*/

// --- Imports ---
#include <SFML/Graphics.hpp>
#include <iostream>
#include <SFML/System.hpp>
#include <SFML/Audio.hpp>

int runGameScreen(sf::Font& font)
{
    // --- Window Settings ---
    sf::RenderWindow gameWindow(sf::VideoMode::getDesktopMode(), "Game Screen", sf::Style::Fullscreen);
    gameWindow.setFramerateLimit(60);

    // --- Clock ---
    sf::Clock TimeForBuble; // Clock for measuring time for bubbles and events

    // --- Bool Flags ---
    bool hasBubbleMoved = false; // Used for the 14-second auto-hide of bubble 1
    bool timeleft = false; // Controls drawing of Next button
    bool soundOnePlayed = false; // Ensures bubble 1 audio plays once
    bool hasInitialBubbleAppeared = false; // Controls initial 2-second delay for bubble 1
    bool next = false; // Controls if Next button is active for click detection
    bool soundTwoPlayed = false; // Ensures bubble 2 audio plays once
    bool soundThreePlayed = false; // Ensures bubble 3 audio plays once

    // --- Int Flags ---
    int numbernextclick = 0; // 0: Bubble 1, 1: Bubble 2, 2: Bubble 3, 3: Dialogue Finished

    // --- BackgroundImageSettings ---
    sf::Texture backgroundtextre;
    bool backgroundLoaded = backgroundtextre.loadFromFile("Assets/Images/BackgroundGame.jpg");
    if (!backgroundLoaded) {
        std::cerr << "Error loading background image for game screen! Make sure 'Assets/Images/BackgroundGame.jpg' is in the correct path.\n";
    }
    sf::Sprite BackgroundImage;
    if (backgroundLoaded) {
        BackgroundImage.setTexture(backgroundtextre);
        float scaleX = static_cast<float>(gameWindow.getSize().x) / backgroundtextre.getSize().x;
        float scaleY = static_cast<float>(gameWindow.getSize().y) / backgroundtextre.getSize().y;
        BackgroundImage.setScale(scaleX, scaleY);
    }

    // --- ButtonNextImage ---
    sf::Texture buttonnexttxture;
    bool buttonload = buttonnexttxture.loadFromFile("Assets/Images/NextButtonImage.png");
    if (!buttonload) {
        std::cerr << "Error loading Next button image! Make sure 'Assets/Images/NextButtonImage.png' is in the correct path.\n";
    }
    sf::Sprite ButtonNextTexture;
    if (buttonload) {
        ButtonNextTexture.setTexture(buttonnexttxture);
        float imageMargin = 600.f; // Moved to 600.f as requested
        float imageX = static_cast<float>(gameWindow.getSize().x) - ButtonNextTexture.getGlobalBounds().width - imageMargin;
        float imageY = static_cast<float>(gameWindow.getSize().y) - ButtonNextTexture.getGlobalBounds().height - imageMargin;
        ButtonNextTexture.setPosition(imageX, imageY);
    }

    // --- CharacterImage ---
    sf::Texture Charactertexture;
    bool characterLoaded = Charactertexture.loadFromFile("Assets/Images/CubeKingBlackBackground.png");
    if (!characterLoaded) {
        std::cerr << "Error loading character image! Make sure 'Assets/Images/CubeKingBlackBackground.png' is in the correct path.\n";
    }
    sf::Sprite CharacterImage;
    if (characterLoaded) {
        CharacterImage.setTexture(Charactertexture);
        float imageMargin = 120.f;
        float imageX = static_cast<float>(gameWindow.getSize().x) - CharacterImage.getGlobalBounds().width - imageMargin;
        float imageY = static_cast<float>(gameWindow.getSize().y) - CharacterImage.getGlobalBounds().height - imageMargin;
        CharacterImage.setScale(1.3f, 1.3f);
        CharacterImage.setPosition(imageX, imageY);
    }

    // --- First Bubble Assets (Image, Text, Audio) ---
    sf::Texture FirstBuble;
    bool bubbleLoaded = FirstBuble.loadFromFile("Assets/Images/BubbleTexts/FirstMassage.png");
    if (!bubbleLoaded) {
        std::cerr << "Error loading speech bubble 1 image! Make sure 'Assets/Images/BubbleTexts/FirstMassage.png' is in the correct path.\n";
    }
    sf::Sprite FirstBubbleImage;
    if (bubbleLoaded) {
        FirstBubbleImage.setTexture(FirstBuble);
        float imageXBubles = static_cast<float>(gameWindow.getSize().x) - FirstBubbleImage.getGlobalBounds().width - 120.f;
        float imageYBubles = static_cast<float>(gameWindow.getSize().y) - FirstBubbleImage.getGlobalBounds().height - 120.f;
        FirstBubbleImage.setPosition(imageXBubles, imageYBubles);
    }

    // This text is now for the first bubble, as requested
    sf::Text bubble1Text("", font, 30);
    bubble1Text.setFillColor(sf::Color::Black);
    bubble1Text.setOrigin(bubble1Text.getLocalBounds().left + bubble1Text.getLocalBounds().width / 2.0f,
        bubble1Text.getLocalBounds().top + bubble1Text.getLocalBounds().height / 2.0f);
    bubble1Text.setPosition(FirstBubbleImage.getPosition().x + FirstBubbleImage.getGlobalBounds().width / 2.0f,
        FirstBubbleImage.getPosition().y + FirstBubbleImage.getGlobalBounds().height / 2.0f);

    sf::SoundBuffer FirstAudioMessageBuffer;
    bool audioLoaded = FirstAudioMessageBuffer.loadFromFile("Assets/Audio/FirstBubbleText.mp3");
    if (!audioLoaded) {
        std::cerr << "Error loading audio file for bubble 1! Make sure 'Assets/Audio/FirstBubbleText.mp3' is in the correct path.\n";
    }
    sf::Sound FirstAudioMessageSound;
    if (audioLoaded) {
        FirstAudioMessageSound.setBuffer(FirstAudioMessageBuffer);
    }

    // --- Bubble 2 Assets (Image, Text, Audio) ---
    sf::Texture bubletwotexture;
    bool bubble2load = bubletwotexture.loadFromFile("Assets/Images/BubbleTexts/FirstMassage.png"); // Using same image for now
    if (!bubble2load) {
        std::cerr << "Error loading speech bubble 2 image! Make sure 'Assets/Images/BubbleTexts/FirstMassage.png' is in the correct path.\n";
    }
    sf::Sprite bubbleImage;
    if (bubble2load) {
        bubbleImage.setTexture(bubletwotexture);
        float imageXBubles = static_cast<float>(gameWindow.getSize().x) - bubbleImage.getGlobalBounds().width - 120.f;
        float imageYBubles = static_cast<float>(gameWindow.getSize().y) - bubbleImage.getGlobalBounds().height - 120.f;
        bubbleImage.setPosition(imageXBubles, imageYBubles);
    }

    sf::Text bubble2Text("Aethelgard, our geometric realm, was once perfect, powered by the Grand Cipher. But Discord shattered it, scattering the Cipher's fragments across twisted dimensions. Our world now crumbles, awaiting a hero.", font, 30);
    bubble2Text.setFillColor(sf::Color::Black);
    bubble2Text.setOrigin(bubble2Text.getLocalBounds().left + bubble2Text.getLocalBounds().width / 2.0f,
        bubble2Text.getLocalBounds().top + bubble2Text.getLocalBounds().height / 2.0f);
    bubble2Text.setPosition(bubbleImage.getPosition().x + bubbleImage.getGlobalBounds().width / 2.0f,
        bubbleImage.getPosition().y + bubbleImage.getGlobalBounds().height / 2.0f);

    sf::SoundBuffer audiomessagebuffer2;
    bool audioLoaded2 = audiomessagebuffer2.loadFromFile("Assets/Audio/Bubble2Text.mp3"); // Make sure this file exists
    if (!audioLoaded2) {
        std::cerr << "Error loading audio file for bubble 2! Make sure 'Assets/Audio/Bubble2Text.mp3' is in the correct path.\n";
    }
    sf::Sound FirstAudioMessageSound2;
    if (audioLoaded2) {
        FirstAudioMessageSound2.setBuffer(audiomessagebuffer2);
    }

    // --- Bubble 3 Assets (Image, Text, Audio) ---
    sf::Texture bubletwotexture3;
    bool bubble3load = bubletwotexture3.loadFromFile("Assets/Images/BubbleTexts/FirstMassage.png"); // Using same image for now
    if (!bubble3load) {
        std::cerr << "Error loading speech bubble 3 image! Check the file path.\n";
    }
    sf::Sprite bubbleImage3;
    if (bubble3load) {
        bubbleImage3.setTexture(bubletwotexture3);
        float imageXBubles3 = static_cast<float>(gameWindow.getSize().x) - bubbleImage3.getGlobalBounds().width - 120.f;
        float imageYBubles3 = static_cast<float>(gameWindow.getSize().y) - bubbleImage3.getGlobalBounds().height - 120.f;
        bubbleImage3.setPosition(imageXBubles3, imageYBubles3);
    }

    sf::Text bubble3Text("That hero is you. Your quest: gather the scattered Cipher fragments hidden within these labyrinthine puzzles. Reassemble the Cipher, restore Aethelgard, and banish the Discord. Your adventure begins now!", font, 30);
    bubble3Text.setFillColor(sf::Color::Black);
    bubble3Text.setOrigin(bubble3Text.getLocalBounds().left + bubble3Text.getLocalBounds().width / 2.0f,
        bubble3Text.getLocalBounds().top + bubble3Text.getLocalBounds().height / 2.0f);
    bubble3Text.setPosition(bubbleImage3.getPosition().x + bubbleImage3.getGlobalBounds().width / 2.0f,
        bubbleImage3.getPosition().y + bubbleImage3.getGlobalBounds().height / 2.0f);

    sf::SoundBuffer audiomessagebuffer3;
    bool audioLoaded3 = audiomessagebuffer3.loadFromFile("Assets/Audio/Bubble3Text.mp3"); // Make sure this file exists
    if (!audioLoaded3) {
        std::cerr << "Error loading audio file for bubble 3! Make sure 'Assets/Audio/Bubble3Text.mp3' is in the correct path.\n";
    }
    sf::Sound FirstAudioMessageSound3;
    if (audioLoaded3) {
        FirstAudioMessageSound3.setBuffer(audiomessagebuffer3);
    }

    // --- Window Play ---
    while (gameWindow.isOpen())
    {
        sf::Event event;
        while (gameWindow.pollEvent(event))
        {
            if (event.type == sf::Event::Closed)
                gameWindow.close();

            if (event.type == sf::Event::MouseButtonPressed)
            {
                if (event.mouseButton.button == sf::Mouse::Left)
                {
                    sf::Vector2f mousePos(static_cast<float>(event.mouseButton.x),
                        static_cast<float>(event.mouseButton.y));
                    // Only allow clicking "Next" if it's active and the button is clicked
                    if (ButtonNextTexture.getGlobalBounds().contains(mousePos) && next == true)
                    {
                        // Stop current sound before advancing
                        if (FirstAudioMessageSound.getStatus() == sf::Sound::Playing) FirstAudioMessageSound.stop();
                        if (FirstAudioMessageSound2.getStatus() == sf::Sound::Playing) FirstAudioMessageSound2.stop();
                        if (FirstAudioMessageSound3.getStatus() == sf::Sound::Playing) FirstAudioMessageSound3.stop();

                        numbernextclick++; // Advance to the next bubble state
                        next = false; // Deactivate next button until new bubble appears
                        timeleft = false; // Reset timeleft flag
                        TimeForBuble.restart(); // Restart timer for the new bubble's duration/delay
                    }
                }
            }
        }

        gameWindow.clear(sf::Color::Black);

        if (backgroundLoaded) {
            gameWindow.draw(BackgroundImage);
        }
        if (characterLoaded) {
            gameWindow.draw(CharacterImage);
        }

        // Logic for Bubble 1 (Initial delay, display, play sound, auto-advance or wait for click)
        if (numbernextclick == 0) {
            if (!hasInitialBubbleAppeared && TimeForBuble.getElapsedTime().asSeconds() >= 2.0f) {
                hasInitialBubbleAppeared = true;
                next = true; // Activate next button
                timeleft = true; // Indicate time has passed for drawing next button
                if (audioLoaded && FirstAudioMessageSound.getStatus() != sf::Sound::Playing) {
                    FirstAudioMessageSound.play();
                }
            }

            if (hasInitialBubbleAppeared) {
                if (bubbleLoaded) {
                    gameWindow.draw(FirstBubbleImage);
                    gameWindow.draw(bubble1Text);
                }
            }

            // Auto-advance Bubble 1 after 14 seconds if not clicked
            if (TimeForBuble.getElapsedTime().asSeconds() >= 14.0f && hasInitialBubbleAppeared) {
                std::cerr << "14sec left! Auto-advancing from Bubble 1.\n";
                numbernextclick = 1; // Move to Bubble 2
                next = false;
                timeleft = false;
                TimeForBuble.restart();
                if (FirstAudioMessageSound.getStatus() == sf::Sound::Playing) FirstAudioMessageSound.stop();
            }
        }

        // Logic for Bubble 2 (Display, play sound, auto-advance or wait for click)
        if (numbernextclick == 1) {
            if (bubble2load) {
                gameWindow.draw(bubbleImage);
                gameWindow.draw(bubble2Text);
                if (audioLoaded2 && FirstAudioMessageSound2.getStatus() != sf::Sound::Playing) {
                    FirstAudioMessageSound2.play();
                }
            }
            next = true; // Activate next button for Bubble 2
            timeleft = true; // Indicate time has passed for drawing next button

            // Auto-advance Bubble 2 after a duration (e.g., 10 seconds from its appearance)
            if (TimeForBuble.getElapsedTime().asSeconds() >= 10.0f) {
                std::cerr << "Auto-advancing from Bubble 2.\n";
                numbernextclick = 2; // Move to Bubble 3
                next = false;
                timeleft = false;
                TimeForBuble.restart();
                if (FirstAudioMessageSound2.getStatus() == sf::Sound::Playing) FirstAudioMessageSound2.stop();
            }
        }

        // Logic for Bubble 3 (Display, play sound, wait for click)
        if (numbernextclick == 2) {
            if (bubble3load) {
                gameWindow.draw(bubbleImage3);
                gameWindow.draw(bubble3Text);
                if (audioLoaded3 && FirstAudioMessageSound3.getStatus() != sf::Sound::Playing) {
                    FirstAudioMessageSound3.play();
                }
            }
            next = true; // Activate next button for Bubble 3
            timeleft = true; // Indicate time has passed for drawing next button

            // --- CONTINUE HERE ---
            // You can add auto-advance logic for Bubble 3 here if needed,
            // or transition to actual gameplay, or another screen.
            // Example for auto-advance:
            // if (TimeForBuble.getElapsedTime().asSeconds() >= 12.0f) {
            //     std::cerr << "Auto-advancing from Bubble 3. Dialogue complete.\n";
            //     numbernextclick = 3; // Mark dialogue as finished
            //     next = false;
            //     timeleft = false;
            //     if (FirstAudioMessageSound3.getStatus() == sf::Sound::Playing) FirstAudioMessageSound3.stop();
            // }
        }

        // Logic for Dialogue Finished state
        if (numbernextclick == 3) {
            // No bubbles or next button drawn.
            // This is where you would transition to the main game loop or next level.
            // For example:
            // return 1; // Or call another game function
        }

        // Draw the Next button only if it's active and not in the "DialogueFinished" state
        if (next && numbernextclick < 3) {
            gameWindow.draw(ButtonNextTexture);
        }

        gameWindow.display();
    }
    return 0;
}


int main()
{
    // --- Window Settings ---
    sf::RenderWindow window(sf::VideoMode::getDesktopMode(), "Menu", sf::Style::Fullscreen);

    // --- Font Loading ---
    sf::Font font;
    if (!font.loadFromFile("Assets/Fonts/Fredoka.ttf")) {
        std::cerr << "Error loading font file!\n";
        return -1;
    }

    // --- Images ---
    sf::Texture texture1;
    if (!texture1.loadFromFile("Assets/Images/CubeKingBlackBackground.png")) {
        std::cerr << "Error loading image file:(!\n";
        return -1;
    }
    sf::Sprite image1;
    image1.setTexture(texture1);
    float imageMargin = 120.f;
    float imageX = static_cast<float>(window.getSize().x) - image1.getGlobalBounds().width - imageMargin;
    float imageY = static_cast<float>(window.getSize().y) - image1.getGlobalBounds().height - imageMargin;
    image1.setScale(1.3f, 1.3f);
    image1.setPosition(imageX, imageY);


    // --- Buttons ---
    sf::RectangleShape PlayButton(sf::Vector2f(580.f, 120.f));
    PlayButton.setFillColor(sf::Color::White);
    float buttonMargin = 300.f;
    float buttonX = buttonMargin;
    float buttonY = buttonMargin + 450;
    PlayButton.setPosition(buttonX, buttonY);

    // --- Text for the PlayButton ---
    sf::Text playButtonText("Start Play!", font, 50);
    playButtonText.setFillColor(sf::Color::Black);
    playButtonText.setOrigin(playButtonText.getLocalBounds().left + playButtonText.getLocalBounds().width / 2.0f,
        playButtonText.getLocalBounds().top + playButtonText.getLocalBounds().height / 2.0f);
    playButtonText.setPosition(PlayButton.getPosition().x + PlayButton.getSize().x / 2.0f,
        PlayButton.getPosition().y + PlayButton.getSize().y / 2.0f);

    // --- Window Play ---
    while (window.isOpen())
    {
        sf::Event event;
        while (window.pollEvent(event))
        {
            if (event.type == sf::Event::Closed)
                window.close();
        }
        // --- ButtonPlayClickFunction ---
        if (event.type == sf::Event::MouseButtonPressed)
        {
            if (event.mouseButton.button == sf::Mouse::Left)
            {
                sf::Vector2f mousePos(static_cast<float>(event.mouseButton.x), static_cast<float>(event.mouseButton.y));

                if (PlayButton.getGlobalBounds().contains(mousePos)) {
                    std::cout << "Play button clicked! Opening new window...\n";
                    window.close();
                    return runGameScreen(font);
                }
            }
        }
        window.clear(sf::Color::Black);
        window.draw(PlayButton);
        window.draw(playButtonText);
        window.draw(image1);
        window.display();
    }
    return 0;
}
