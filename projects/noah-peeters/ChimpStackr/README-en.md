# ChimpStackr

![GitHub all releases](https://img.shields.io/github/downloads/noah-peeters/ChimpStackr/total) ![GitHub release (latest by date)](https://img.shields.io/github/downloads/noah-peeters/ChimpStackr/latest/total) ![GitHub](https://img.shields.io/github/license/noah-peeters/ChimpStackr) ![GitHub commits since latest release (by date)](https://img.shields.io/github/commits-since/noah-peeters/ChimpStackr/latest)

<p align="center">
  <img src="https://raw.githubusercontent.com/noah-peeters/ChimpStackr/master/packaging/icons/chimpstackr_icon.png" width="200"/>
</p>

Open-source focus stacking application for Windows, macOS, and Linux.

## Features

- **4 stacking algorithms:** Laplacian Pyramid, Weighted Average, Depth Map, Exposure Fusion (HDR)
- **Automatic alignment:** Translation-only or Rotation + Scale correction (focus breathing)
- **16-bit pipeline:** Full bit-depth preservation from RAW to output
- **Auto-crop:** Removes black edges from alignment shifts
- **Auto-tuning:** Parameters auto-detected from image resolution
- **GUI + CLI:** Full graphical interface and headless command-line tool
- **Cross-platform:** Native builds for Windows, macOS, Linux
- **Pause/resume/cancel:** Control long-running stacks
- **Before/after comparison:** Slider viewer for comparing input vs output
- **Drag & drop:** Drop image files or folders directly into the app

## Download

Pre-built packages are available on the [Releases](https://github.com/noah-peeters/ChimpStackr/releases) page:

| Platform | Download | Notes |
|---|---|---|
| **Windows** | `ChimpStackr-Windows.zip` | Extract and run `chimpstackr.exe` |
| **macOS** | `ChimpStackr-macOS.dmg` | Open DMG, drag to Applications |
| **Linux** | `ChimpStackr-Linux-x86_64.AppImage` | `chmod +x` and run |

## CLI Usage

The CLI allows headless focus stacking without a GUI:

```bash
# Basic stack
chimpstackr-cli --input images/*.jpg --output result.tif

# Align + stack with auto parameters
chimpstackr-cli -i images/*.jpg -o result.tif --align --auto --auto-crop

# Full options
chimpstackr-cli -i images/*.jpg -o result.png \
  --align \
  --method laplacian \
  --rotation-scale \
  --kernel-size 6 \
  --pyramid-levels 8 \
  --auto-crop \
  --quality-report
```

**Available methods:** `laplacian` (default), `weighted_average`, `depth_map`

## Stacking Algorithms

| Method | Best for | How it works |
|---|---|---|
| **Pyramid** | Fine detail (hairs, bristles, edges) | Laplacian pyramid decomposition, max-contrast selection per frequency band, local tone-mapping |
| **Weighted** | Smooth subjects, good color | Per-pixel contrast weighting with proper accumulation |
| **Depth Map** | Opaque surfaces, best color fidelity | Multi-scale sharpness with edge-aware bilateral smoothing |
| **HDR** | Varying exposure/lighting | Mertens exposure fusion (not for focus stacking) |

## Build from Source

Requires Python 3.9-3.13.

```bash
git clone https://github.com/noah-peeters/ChimpStackr.git
cd ChimpStackr
python -m venv .venv
source .venv/bin/activate  # or .venv\Scripts\activate on Windows
pip install -r requirements.txt

# Run GUI
python src/run.py

# Run CLI
python -m src.cli --help

# Run tests
pip install pytest
pytest tests/ -v
```

## Packaging

Builds use PyInstaller with platform-specific post-processing. You can only build for your current platform.

```bash
# Install build tools
pip install pyinstaller

# Build (creates dist/chimpstackr/ and dist/ChimpStackr.app on macOS)
pyinstaller chimpstackr.spec --noconfirm

# Or use the platform scripts:
./scripts/build_macos.sh        # macOS → .dmg
./scripts/build_linux.sh        # Linux → .AppImage
.\scripts\build_windows.ps1     # Windows → .zip or installer
```
CI/CD automatically builds all platforms on tagged releases via GitHub Actions.

## Gallery

The following stacks were taken at ~4x magnification on a slightly wobbly rig (~150 images each), stacked with ChimpStackr and post-processed in [darktable](https://www.darktable.org/).

![Bij_TranslationAlignment](https://user-images.githubusercontent.com/17707805/196990942-413ea35c-2abb-4bce-9807-3f3d6b3de3c5.jpg)
![Edited](https://user-images.githubusercontent.com/17707805/196991117-dc4f1c76-cc87-4ef1-92ee-9a7484c7ff07.jpg)
![Bewerkt](https://user-images.githubusercontent.com/17707805/196996295-9fb6c365-ef10-4ef5-b451-1a7269156e53.jpg)

## Sources

- Focus stacking algorithm based on: Wang, W., & Chang, F. (2011). A Multi-focus Image Fusion Method Based on Laplacian Pyramid. *Journal of Computers*, 6(12).
- DFT image alignment adapted from: [imreg_dft](https://github.com/matejak/imreg_dft)
- Mertens exposure fusion: Mertens, T., Kautz, J., & Van Reeth, F. (2007). Exposure Fusion.
- Sum Modified Laplacian focus measure: Nayar, S.K., & Nakagawa, Y. (1994).

## License

GPL-3.0 - see [LICENSE](LICENSE) for details.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-29

---