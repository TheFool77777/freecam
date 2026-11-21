# freecam

> Move the camera freely in gogh.
> Expand the room boundary so you can zoom out and move your view without hitting the default limits in both solo and multiplayer rooms.

[![Latest Release](https://img.shields.io/github/v/release/TheFool77777/freecam?display_name=tag&style=flat-square)](https://github.com/TheFool77777/freecam/releases/latest)
[![Downloads](https://img.shields.io/github/downloads/TheFool77777/freecam/total?style=flat-square)](https://github.com/TheFool77777/freecam/releases)
[![License](https://img.shields.io/badge/license-MIT-6f42c1?style=flat-square)](LICENSE)

**[Download ZIP](https://github.com/TheFool77777/freecam/releases/latest/download/freecam.zip)　·　[View all releases](https://github.com/TheFool77777/freecam/releases/latest)**

[繁體中文](README.md) · [简体中文](README.zh-CN.md) · [English](README.en.md) · [日本語](README.ja.md)

## What is it?

freecam is a small camera-boundary mod for **gogh: Focus with Your Avatar**.

It expands the room bounding box so your camera can move much more freely in both solo and multiplayer rooms.

Install MelonLoader, place `freecam.dll` in `Mods`, and launch the game. That is all.

## Installation

### Step 1: Install MelonLoader

1. Open the [official MelonLoader Installer downloads](https://github.com/LavaGang/MelonLoader.Installer/releases).
2. Download and open the installer.
3. Select gogh's `gogh.exe`.
4. Keep the default settings and click **Install**.

### Step 2: Launch the game once

Launch gogh from Steam, wait for the main screen, then close the game.

This creates the `Mods` folder automatically.

### Step 3: Add the DLL

1. Open the [freecam Releases](https://github.com/TheFool77777/freecam/releases/latest) page and download `freecam.zip`.
2. Extract the ZIP.
3. Copy `freecam.dll` into gogh's `Mods` folder.
4. Launch the game again. Done.

Find the game folder from Steam:

**Library → right-click gogh → Manage → Browse local files**

The final path should look like this:

```text
gogh folder\Mods\freecam.dll
```

## Downloads

- [Download the latest ZIP](https://github.com/TheFool77777/freecam/releases/latest/download/freecam.zip)
- [Download the DLL](https://github.com/TheFool77777/freecam/releases/latest/download/freecam.dll)
- [Download MelonLoader Installer](https://github.com/LavaGang/MelonLoader.Installer/releases)

## Check that it works

Launch the game and enter a room. After about 2 seconds, you should be able to move the camera well beyond the original room boundary.

You can also open `MelonLoader\Logs` and search for:

```text
WholeRoomBoundingBox modified successfully!
```

## Troubleshooting

### I cannot find the Mods folder

Launch the game once with MelonLoader, reach the main screen, and close it. The folder will be created automatically.

### The mod does not work

Make sure the file is here:

```text
Mods\freecam.dll
```

Then launch the game again.

### It did not apply right after entering a room

The mod applies automatically about 2 seconds after the room scene loads, and retries once after another 2 seconds if needed.

## Uninstall

Close the game and delete this file:

```text
Mods\freecam.dll
```

## Author

**Yakou**

## License

[MIT License](LICENSE)
