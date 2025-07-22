ת# 👻 Echoes of the Void - Unity Project Setup & Development Guide 🛠️

![GitHub Repo size](https://img.shields.io/github/repo-size/JonatanKovalik/Projects?style=flat)
![GitHub Top Language](https://img.shields.io/github/languages/top/JonatanKovalik/Projects?style=flat)
![Unity 3D Version](https://img.shields.io/badge/Unity-2022.3.62f1%20LTS-blue.svg?style=flat&logo=unity)
![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=csharp&logoColor=white)
![Genre](https://img.shields.io/badge/Genre-Psychological%20Horror%20%7C%20Survival-red.svg?style=flat)
![Status](https://img.shields.io/badge/Status-Early%20Prototype-orange.svg?style=flat)
![License](https://img.shields.io/github/license/JonatanKovalik/Projects?style=flat)
![Contributions Welcome](https://img.shields.io/badge/Contributions-Welcome-brightgreen.svg?style=flat)
![Looking for Collaborators](https://img.shields.io/badge/Looking%20for-Collaborators-blue.svg?style=flat)

---

## 🚀 Project Overview

Welcome to the Unity project for **Echoes of the Void**!

This is a first-person psychological horror and survival game, meticulously crafted to deliver a deeply unsettling experience through atmospheric tension, psychological degradation, and cosmic dread. Players will explore the reality-bending Blackwood Manor, searching for a lost loved one, while confronting manifestations of "The Void."

**Key Features (Concept):**
* **Immersive Psychological Horror:** Focus on dread, paranoia, and the protagonist's crumbling sanity.
* **Dynamic Sanity System:** Visual/auditory hallucinations intensify with declining sanity.
* **Environmental Storytelling:** Discover lore through hidden notes, journals, and objects.
* **Reality-Distorting Environments:** The manor actively changes, disorienting the player.
* **Stealth-Based Gameplay:** No combat; evade and hide from entities.
* **Resource Management:** Limited flashlight battery and sound recorder charge.
* **Interactive Sound Design:** Use a special recorder for clues and hidden phenomena.
* **Ambiguous Narrative:** A story designed for lasting unease and questions.

---

## 🛠️ Getting Started with the Unity Project

### Prerequisites

* **Unity Editor:** Version `2022.3.62f1 LTS` (or compatible LTS version).
    * **Installation:** Ensure you have the "Universal Windows Platform Build Support" module (or relevant platform modules for your target build) installed via Unity Hub.
* **Version Control:** Git client installed (e.g., Git Bash, GitHub Desktop).

### Project Setup

1.  **Clone the Repository:**
    If you haven't already, clone the main portfolio repository (which contains this Unity project folder).
    ```bash
    git clone [https://github.com/JonatanKovalik/Projects.git](https://github.com/JonatanKovalik/Projects.git)
    cd Projects/TheEditorUnity
    ```
    *(Note: Adjust the path if your Unity project is located elsewhere within your main Projects repo)*

2.  **Open in Unity Hub:**
    * Open Unity Hub.
    * Click "Add Project" (or "Open" if you have an older Hub version).
    * Navigate to the `TheEditorUnity` folder within your cloned repository and select it.
    * Unity Hub should detect the project and its required Editor version. Open the project.

3.  **Resolve Package Dependencies:**
    * Upon opening, Unity may prompt you to resolve package dependencies. Allow it to do so.
    * Check `Window > Package Manager` to ensure all necessary Unity packages are installed (e.g., Post Processing, UI Toolkit, Input System if used).

---

## 📂 Project Structure (Within Unity)

The Unity project adheres to a standard structure for clarity and maintainability.

* `Assets/`
    * `_Scenes/`: All game scenes (e.g., `MainMenu.unity`, `BlackwoodManor_Foyer.unity`).
    * `Scripts/`: All C# scripts. Organized into subfolders like `Player`, `Systems`, `Environment`, `AI`, `UI`, etc.
    * `Prefabs/`: Reusable game objects (e.g., `PlayerPrefab`, `FlashlightPrefab`, `DoorPrefab`).
    * `Models/`: 3D models (FBX, OBJ). Organized into `Characters`, `Props`, `Environment`.
    * `Materials/`: All materials used for models and other assets.
    * `Textures/`: All image textures (PNG, JPG, TGA).
    * `Audio/`: Sound effects (SFX) and music. Organized into `SFX`, `Music`, `VoiceLines`.
    * `Animations/`: Animation clips and Animator Controllers.
    * `UI/`: UI assets like sprites, UI prefabs, and UI scripts.
    * `Shaders/`: Custom shaders.
    * `ThirdParty/`: External assets/plugins from Asset Store or other sources.
    * `Resources/`: (Use sparingly) Assets loaded at runtime by name.

---

## 📝 Development Guidelines

* **Coding Standards:** Follow standard C# coding conventions (e.g., PascalCase for classes/methods, camelCase for variables). Add comments for complex logic.
* **Scene Management:** Each distinct area or major gameplay segment should ideally be its own scene.
* **Prefab Usage:** Prioritize prefabs for reusable objects to ensure consistency and efficient updates.
* **Version Control (Git):**
    * Commit frequently with descriptive messages.
    * Use feature branches for new features or significant changes (`git checkout -b feature/your-feature-name`).
    * Rebase onto `main` branch before merging (`git rebase main` then `git merge feature/your-feature-name` or use Pull Requests).
    * Avoid committing large binary files directly if possible; use Git LFS if absolutely necessary for assets (though this project aims to minimize large binary commits within the core Unity project for ease of use).
* **Performance:** Keep performance in mind. Optimize models, textures, and scripts. Profile regularly.
* **Documentation:** Update this README and add inline comments as the project evolves.

---

## 🔑 Key Systems & Components

* **Player Controller:** First-person character movement, camera look, interaction system.
* **Sanity System:** Script controlling sanity level, triggering visual/auditory hallucinations, and linking to UI elements.
* **Sound Recorder Mechanic:** Script handling audio recording, frequency manipulation, and clue detection.
* **Environmental Interaction:** Scripts for doors, drawers, collectibles (notes, journals), and puzzle elements.
* **AI (Void Echoes):** Basic AI for enemy detection, pathfinding (if applicable), and stealth evasion mechanics.
* **UI System:** Main Menu, HUD (Health/Sanity/Battery), Inventory, Pause Menu.

---

## 🗺️ Progress & Roadmap (Current Phase: Concept & Narrative Design)

This Unity project currently represents the *early implementation phase* of the "Echoes of the Void" concept.

**Current Focus:**
* Setting up core Unity project structure.
* Importing initial concept assets (placeholder models, basic textures).
* Implementing basic player movement and camera controls.
* Prototyping the Sanity System's visual/auditory effects.
* **Next Steps:**
    * Prototyping the Sound Recorder mechanic.
    * Blocking out the first few rooms of Blackwood Manor.
    * Integrating initial narrative elements (e.g., first journal entry pickups).

For the full detailed story and lore, please refer to the main repository's `Full_Story_and_Lore.md` file.

---

## 🤝 Contribution

Contributions are welcome! If you'd like to help develop this project (non-commercial), feel free to fork the repository, make your changes, and submit a Pull Request. Please refer to the main portfolio README for general collaboration interests.

---

## 📧 Contact

Jonatan Kovalik - jonatan.kovalik@gmail.com
GitHub: [https://github.com/JonatanKovalik/Projects](https://github.com/JonatanKovalik/Projects)

---