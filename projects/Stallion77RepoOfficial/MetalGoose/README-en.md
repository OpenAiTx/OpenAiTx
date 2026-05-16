<div align="center">
  <img src="https://raw.githubusercontent.com/Stallion77RepoOfficial/MetalGoose/main/Assets/logo.png" alt="MetalGoose Logo" width="128" height="128">
  
  # MetalGoose
  
  **GPU-accelerated upscaling and frame generation for macOS**
  
  [![macOS](https://img.shields.io/badge/macOS-26.0%2B-blue?logo=apple)](https://www.apple.com/macos/)
  [![Metal](https://img.shields.io/badge/Metal-4.0-orange?logo=apple)](https://developer.apple.com/metal/)
  [![License](https://img.shields.io/badge/License-GPL--3.0-green)](LICENSE)
  [![Swift](https://img.shields.io/badge/Swift-6.2-FA7343?logo=swift)](https://swift.org)
  
  [Features](#features) • [Installation](#installation) • [Usage](#usage) • [Requirements](#requirements) • [Building](#building) • [License](#license)
</div>

---

## Overview

MetalGoose is a native macOS application that provides real-time upscaling and frame generation for games and applications. Built entirely with Apple's Metal framework, it delivers a smooth, high-FPS experience similar to NVIDIA DLSS or AMD FSR, but designed specifically for macOS.

## Features

### MGUP-1 Upscaling
- **Performance Mode** — Fastest upscaling with minimal latency
- **Balanced Mode** — Optimal quality/performance ratio
- **Quality Mode** — Maximum visual fidelity
- Multiple render scales: Native, 75%, 67%, 50%, 33%
- Contrast-adaptive sharpening (CAS)

### MGFG-1 Frame Generation
- **2x, 3x, 4x** frame multipliers
- **Adaptive** or **Fixed** frame generation modes
- Motion-compensated interpolation
- Optical flow-based motion estimation
- Quality modes: Performance, Balanced, Quality

### Anti-Aliasing
- **FXAA** — Fast approximate anti-aliasing
- **SMAA** — Enhanced subpixel morphological AA
- **MSAA** — Multi-sample anti-aliasing  
- **TAA** — Temporal anti-aliasing with history  

### Performance Monitoring  
- Real-time HUD overlay  
- Capture/Output/Interpolated FPS tracking  
- GPU time and frame time metrics  
- VRAM usage monitoring  
- Frame statistics  

## Requirements  

| Component | Requirement |  
|-----------|-------------|  
| **macOS** | 26.0 (Tahoe) or later |  
| **Chip** | Apple Silicon (M1/M2/M3/M4)  
| **Xcode** | 26.0 or later |  
| **RAM** | 8 GB minimum, 16 GB recommended |  

## Installation  

### Download Release  
1. Download the latest release from [Releases](https://github.com/Stallion77RepoOfficial/MetalGoose/releases)  
2. Move `MetalGoose.app` to `/Applications`  
3. Grant Screen Recording and Accessibility permissions when prompted  

### Build from Source
```bash
git clone https://github.com/Stallion77RepoOfficial/MetalGoose
cd MetalGoose
open MetalGoose.xcodeproj
```

## Usage

1. **Launch MetalGoose**
2. **Select Target**
   - Choose a window or display to capture
3. **Configure Settings**
   - Enable upscaling (MGUP-1)
   - Enable frame generation (MGFG-1) 
   - Select anti-aliasing mode
4. **Start Scaling**
   - Click "Start" to begin processing

### Keyboard Shortcuts

| Shortcut | Action |
|----------|--------|
| `⌘ + T` | Toggle Scale |

# MetalGoose Error Codes

## UI (MG-UI)
- MG-UI-002: Frontmost app is MetalGoose; user must switch to target window.
- MG-UI-003: Target window not found for the selected app.
- MG-UI-004: No display found.
- MG-UI-005: Fullscreen window detected; virtual display requires windowed or borderless mode.
- MG-UI-006: Target window bounds unavailable.
- MG-UI-007: Display ID not found for target screen.
- MG-UI-008: Display refresh rate unavailable.

## Engine (MG-ENG)
- MG-ENG-001: Metal pipeline setup failed.
- MG-ENG-002: Metal device not available.
- MG-ENG-003: Metal command queue not available.
- MG-ENG-004: MetalFX Spatial Scaler creation failed.
- MG-ENG-005: Optical flow pipeline unavailable.
- MG-ENG-006: Frame interpolation failed.
- MG-ENG-007: Anti-aliasing pipeline unavailable.
- MG-ENG-008: Scale pipeline unavailable.
- MG-ENG-009: CAS pipeline unavailable.
- MG-ENG-010: IOSurface texture creation failed.
- MG-ENG-011: Optical flow pipeline unavailable.
- MG-ENG-012: Optical flow resources unavailable.
- MG-ENG-013: Frame generation pipeline unavailable.

## Virtual Display (MG-VD)
- MG-VD-001: CGVirtualDisplayDescriptor creation failed.
- MG-VD-002: CGVirtualDisplay creation failed.
- MG-VD-003: CGVirtualDisplayMode creation failed.
- MG-VD-004: CGVirtualDisplaySettings creation failed.
- MG-VD-005: Applying virtual display settings failed.
- MG-VD-006: No active virtual display.
- MG-VD-007: Virtual display not found in ScreenCaptureKit.
- MG-VD-008: ScreenCaptureKit start capture failed.
- MG-VD-009: ScreenCaptureKit stop capture failed.
- MG-VD-010: ScreenCaptureKit stream stopped with error.

## Accessibility / Window Migration (MG-AX)
- MG-AX-001: Accessibility permission not granted.
- MG-AX-002: Failed to read window list from AX API.
- MG-AX-003: No windows found for target PID.
- MG-AX-004: Failed to create AX position value.
- MG-AX-005: Failed to set AX window position.
- MG-AX-006: Fullscreen window cannot be moved to virtual display.
- MG-AX-007: Failed to create AX size value.
- MG-AX-008: Failed to set AX window size.
- MG-AX-009: Virtual display screen not found.
- MG-AX-010: Window ID not found for target PID.

## Overlay (MG-OV)
- MG-OV-001: Target screen missing for overlay creation.
- MG-OV-002: Window frame missing for overlay creation.
- MG-OV-003: Unsupported pixel format for overlay texture creation.

## Mouse Routing (MG-MO)
- MG-MO-001: Virtual display not configured for mouse routing.

## License

This project is licensed under the GNU General Public License v3.0 - see the [LICENSE](LICENSE) file for details.

## Acknowledgments

- Apple for the Metal framework and documentation
- The macOS gaming community for feedback and testing
- Contributors who helped improve the project

---

RESOURCES THAT USED FOR THIS PROJECT

https://developer.apple.com/documentation/metal
https://developer.apple.com/documentation/metalfx/
https://developer.apple.com/documentation/coreimage
https://developer.apple.com/documentation/screencapturekit/
https://developer.apple.com/documentation/appkit
https://developer.apple.com/documentation/metal/mtltexture
https://developer.apple.com/documentation/corevideo/cvpixelbuffer
https://developer.apple.com/documentation/metalperformanceshaders
https://developer.apple.com/documentation/metal/compute-passes
https://developer.apple.com/documentation/vision
https://developer.apple.com/documentation/vision/vngenerateopticalflowrequest
https://developer.apple.com/documentation/ScreenCaptureKit/capturing-screen-content-in-macos


<div align="center">
  <sub>Built with ❤️ using Metal for macOS</sub>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-16

---