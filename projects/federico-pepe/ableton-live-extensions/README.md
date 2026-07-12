# Ableton Live Extensions Experiments

![Ableton Live Extensions](/images/Ableton-Extensions.png)

🖥️ [Watch my introductory video on YouTube](https://www.youtube.com/watch?v=_izRiBGngGI)

*Break what's expected. Make Live your own.* 

Extensions are a new way to enhance Live's capabilities with powerful tools that can speed up your workflow by automating repetitive tasks, sparkle or scramble new ideas and even more.

This repository is a collection of some of the extensions I've developed for you to try out, explore and edit. Most of them are just tests designed to check out the SDK's capabilities.

You can read more about Ableton Extensions here:

* [Ableton.com](https://www.ableton.com/en/live/extensions)
* [Extension SDK](https://ableton.github.io/extensions-sdk)
* [Join Ableton's Discord](https://discord.gg/ableton) to discuss about extensions

## Requirements

* Ableton Live Suite 12.4.5 beta

## Disclaimer

I built most of these extensions with the help of *Claude Code* handling most of the heavy lifting on the code side. If that makes you uneasy or you're not on board with that approach, no worries at all. Either way, thanks a lot for taking the time to check it out.

A big thank you to **Rain** and **Jackie** for helping me building the **Bird Game** extension and make it look so good. Thank you Glau [@glaurossi](https://github.com/glaurossi) for making **Doom** compatible with Windows. **Freesound Sampler** is developed in collaboration with feedback from Frederic Font Corbera [@ffont](https://github.com/ffont) the Freesound lead developer.

---

# Extensions

| Name | Version | Description | Download | Source |
|---|---|---|---|---|
| Arrangement Helper | 0.0.8 | Builds structured arrangements with named, colored sections on a MIDI track. *⚠️ Please read the current known limitations in the extension's README file.* | [⬇️ Download](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Arrangement-Helper-0.0.8.ablx) | [🏗️ Source](extensions/arrangement-helper) |
| Basic Pitch ✨ | 1.0.3 | Converts audio clips to MIDI using Spotify's Basic Pitch neural network, fully offline (macOS & Windows) | [⬇️ Download](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Basic-Pitch-1.0.3.ablx) | [🏗️ Source](extensions/spotify-basic-pitch) |
| Bird Game | 1.1.0 | A just-for-fun game inspired by Flappy Bird that turns your run into a MIDI clip (macOS & Windows) | [⬇️ Download](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/bird-game-1.1.0.ablx) | [🏗️ Source](extensions/bird-game) |
| Chord Progression Helper | 0.5.1 | Builds chord progressions from any key and writes them as a MIDI clip | [⬇️ Download](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Chord-Progression-Helper-0.5.1.ablx) | [🏗️ Source](extensions/chord-progression-helper) |
| Chord Voicing Helper | 1.0.2 | Detects chords in a MIDI clip and lets you apply and preview voicing strategies | [⬇️ Download](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Chord-Voicing-Helper-1.0.2.ablx) | [🏗️ Source](extensions/chord-voicings-helper) |
| ChromaFlux | 0.0.7 | Randomizes Instrument Rack parameters with configurable mode and intensity | [⬇️ Download](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/ChromaFlux-0.0.7.ablx) | [🏗️ Source](extensions/chroma-flux) |
| Doom | 1.0.0 | Runs the original DOOM Shareware (1993) fully offline inside Ableton Live (macOS & Windows) | [⬇️ Download](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Doom-1.0.0.ablx) | [🏗️ Source](extensions/doom) |
| Duplicate Track | 0.0.7 | Duplicates a track without copying its clips | [⬇️ Download](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Duplicate-Track-0.0.7.ablx) | [🏗️ Source](extensions/duplicate-track) |
| Freesound Sampler | 1.1.3 | Searches Freesound.org and downloads sounds directly into your tracks | [⬇️ Download](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Freesound-Sampler-1.1.3.ablx) | [🏗️ Source](extensions/freesound-sampler) |
| Session to Arrangement Bridge | 0.0.8 | Transfers all Session View clips into Arrangement View with full fidelity. *⚠️ Please read the current known limitations in the extension's README file.* | [⬇️ Download](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Session-to-Arrangement-Bridge-0.0.8.ablx) | [🏗️ Source](extensions/session-arrangement-bridge) |
| Snake | 0.0.7 | Play Snake inside Live and turn your gameplay into a MIDI clip | [⬇️ Download](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Snake-0.0.7.ablx) | [🏗️ Source](extensions/snake) |
| Track Creator | 0.0.6 | Creates multiple audio or MIDI tracks at once from a simple dialog | [⬇️ Download](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Track-Creator-0.0.6.ablx) | [🏗️ Source](extensions/track-creator) |
| Transpose Clips | 0.1.0 | Transposes every MIDI clip in the Live Set by a chosen number of semitones | [⬇️ Download](https://raw.githubusercontent.com/federico-pepe/ableton-live-extensions/main/download/Transpose-Clips-0.1.0.ablx) | [🏗️ Source](extensions/transposer) |

✨ *Most recently updated*

---

# Changelog

## June 28, 2026

### Basic Pitch 1.0.3
- **Indeterminate progress bar** — During transcription the progress bar now animates in indeterminate mode instead of freezing. TF.js CPU inference is synchronous and blocks Node's single thread, so a fixed percentage could not update until inference finished.

## June 15, 2026

### Freesound Sampler 1.1.3
- **Inspire Me** — Click **Inspire Me** to pick a random search term and instantly discover unexpected sounds
- **OAuth login** - Improved workflow. Removed API Key field.

## June 12, 2026

### Freesound Sampler 1.0.0
- **OAuth login** — Log in with your Freesound account directly from the extension; no manual API key needed
- **Original quality downloads** — When logged in, sounds are downloaded in their original format (WAV, FLAC, AIFF, …) instead of MP3 previews
- **Attribution helper** — The Attributions view lists imported sounds with a one-click copy for crediting creators
- **Advanced search filters** — Filter by timbre descriptors (brightness, warmth, roughness, etc.), key, BPM, duration, license, and more

## June 9, 2026

### Bird Game 1.1.0
- **Windows support** — Now runs on both macOS and Windows

### Doom 1.0.0
- **Windows support** — Now runs on both macOS and Windows (thanks to Glau [@glaurossi](https://github.com/glaurossi))
- **Fully offline** — All game assets bundled; no internet connection required

## June 7, 2026

### Basic Pitch 1.0.0
- **Windows support** — Full cross-platform support (macOS & Windows) thanks to [@jwfeniello](https://github.com/jwfeniello)
- **Bundled model** — ML model runs entirely locally; no data leaves your machine
- **Stability fixes** — Fixed host crash and handling of compressed audio samples

## June 1, 2026

### Initial public release
- **Bird Game 1.0.0** — Flappy Bird-inspired game that turns your run into a MIDI clip
- **Doom** — Original DOOM Shareware (1993) running inside Ableton Live, migrated to the new SDK
- **Arrangement Helper**, **Basic Pitch**, **Chord Progression Helper**, **Chord Voicing Helper**, **ChromaFlux**, **Duplicate Track**, **Freesound Sampler**, **Session to Arrangement Bridge**, **Snake**, **Track Creator**, **Transpose Clips** — first public versions