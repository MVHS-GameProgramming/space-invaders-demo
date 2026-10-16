# MVHS Game Programming — Unity Projects

This repository follows a structured Git workflow. All changes must go through
a Pull Request before being merged into `main`. Direct pushes to `main` are
not allowed.

---

## Branch Naming

Create a branch for each feature or task you are working on.

Use this format: `yourname/feature-description`

Examples:
- `alex/player-movement`
- `jordan/enemy-spawner`
- `alex/audio-menu-music`

---

## Daily Workflow

1. **Pull latest changes** from `main` before starting work
2. **Create or switch to your feature branch**
3. **Work in your own test scene** — do not edit the shared main scene
4. **Commit often** — small commits with clear messages are better than one giant commit
5. **Push your branch** to GitHub when you're done for the day or ready for review
6. **Open a Pull Request** when your feature is complete and tested

---

## Commit Messages

Write commit messages that describe *what changed and why*, not just *what you did*.

Good:
Add player jump with coyote time
Player can now jump for 0.1s after walking off a ledge.
Feels much better in playtesting.

Too vague:
fixed stuff
updated script
changes

---

## Pull Requests

When your feature is ready to merge:

1. Push your branch to GitHub
2. Go to the repository on GitHub
3. Click **Compare & pull request**
4. Write a short description of what your PR does
5. Submit the pull request
6. Review your own changes in the Files Changed tab — catch anything you missed
7. **Squash and merge** into `main`
8. Delete your branch after merging

---

## Asset Organization

All project assets must live inside `Assets/Project/` in the correct subfolder.
Use the **Asset Structure Validator** (`Tools > MVHS > Asset Structure Validator`)
to check your assets before committing.

| Asset Type | Folder |
|---|---|
| Scripts | `Assets/Project/Scripts/` |
| Art / Textures / Materials | `Assets/Project/Art/` |
| Audio | `Assets/Project/Audio/` |
| Prefabs | `Assets/Project/Prefabs/` |
| Scenes | `Assets/Project/Scenes/` |
| Animations | `Assets/Project/Animations/` |
| Models | `Assets/Project/Models/` |
| ScriptableObjects | `Assets/Project/ScriptableObjects/` |

---

## End of Semester

Before you are removed from this organization, **fork this repository to your
personal GitHub account**. Your fork is your portfolio copy and belongs to you
permanently.
