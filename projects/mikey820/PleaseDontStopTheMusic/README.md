# PleaseDontStopTheMusic

An iOS tweak that allows multiple audio sources to play simultaneously by preventing audio session interruptions.

## ❤️ Support the Project

If you find this project useful and would like to support development, donations are appreciated.

### Litecoin
**Network:** Litecoin (LTC)  
**Address:** `ltc1qaz2zqcc5usl4ueg7w5m8kqcmvrfqurpn6wqyfa`

Please double-check that you're sending on the **Litecoin** network.

Thank you for your support!

---

## Overview

**PleaseDontStopTheMusic** is a tweak that hooks into iOS's `AVAudioSession` to enable audio mixing. This allows your currently playing audio (music, podcasts, etc.) to continue uninterrupted when other apps request audio playback, instead of the usual behavior where the system pauses your audio and plays only the new source.

## Features

- **Continuous Playback** - Your audio keeps playing even when other apps want to play sound.
- **Audio Mixing** - Multiple audio sources blend together using the `MixWithOthers` option.
- **Universal Support** - Works with rootful, rootless, and jailed installations.
- **Lightweight** - Minimal overhead, purely hook-based implementation.

## How It Works

The tweak intercepts `AVAudioSession` configuration calls and, **only when another app is already playing audio** (`isOtherAudioPlaying`), applies the `AVAudioSessionCategoryOptionMixWithOthers` option to the incoming app's session. This tells iOS to mix the new audio with existing playback rather than interrupting it.

Crucially, it does **not** force mixing on whichever app is the primary music source. An app that opts into `MixWithOthers` is treated by iOS as a *secondary* source and loses its lock screen / Control Center "Now Playing" transport controls. By leaving the first/primary app untouched, that app keeps full lock-screen skip & pause controls, while later apps (TikTok, games, etc.) are forced to mix in quietly without interrupting it.

### Hooked Methods

- `setCategory:error:`
- `setCategory:mode:options:error:`
- `setCategory:mode:routeSharingPolicy:options:error:` *(the modern API used by TikTok and most current apps)*
- `setCategory:withOptions:error:`
- `setActive:error:`
- `setActive:withOptions:error:`

`SoloAmbient` sessions (which cannot mix) are transparently swapped to `Ambient` when another app is playing, so they no longer silence your music.

---

## Installation Guide

Choose the method below that applies to your device configuration.

### Method 1: Non-Jailbroken (Sideloading)
Use this method if your device is not jailbroken. You will need to inject the tweak `.dylib` from releases into your target application's IPA file.

1. **Prepare:** Ensure you have the `PleaseDontStopTheMusic.dylib` file.
2. **Select Tool:** Use a sideloading tool such as **Esign**, **Feather**, or **Sideloadly**.
3. **Inject:** Import your target application's (the app you want to listen to media on, eg if i want to listen to spotify while playing roblox i would inject it into roblox) IPA into the tool, select the `.dylib` for injection, and sign the app.
4. **Install:** Install the resulting modified IPA to your device.

### Method 2: Jailbroken
Use this method if your device is jailbroken.

1. **Add Repo:** Open https://repo.chariz.com/ and press the button to add it to your perferred package manager (this should be a defult repo but if you dont have it add it)
2. **Install:** Navigate to the repo on your list to grab it, or search for "PleaseDontStopTheMusic"
3. **Finalize:** Perform a **respring** of your device to apply the hooks. 

---

If you have any problems or questions, feel free to dm me on discord! dc: fuseegelee

```bash
make all
