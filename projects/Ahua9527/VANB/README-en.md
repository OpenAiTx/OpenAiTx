# VANB (Video Audio Network Bridge)
# VANB (Video Assistant NDI Bridge)
# VANB (Wow!! NB)

VANB is a video/audio stream conversion tool based on GStreamer, supporting bidirectional conversion between NDI and RTMP protocols. It allows pushing NDI sources to an RTMP server, or converting RTMP streams to NDI output.

This project is open-sourced under the [GPL-3.0](https://www.gnu.org/licenses/gpl-3.0.html) license.

## Supported Platforms

Currently, the following platforms are mainly supported:
- macOS (Apple Silicon)

## Environment Requirements

### System Dependencies
- [GStreamer 1.24+](https://gstreamer.freedesktop.org)
- [NewTek NDI SDK](https://www.ndi.tv/sdk/)

### Installation Steps
1. Install [NewTek NDI SDK](https://www.ndi.tv/sdk/)

2. Install GStreamer via Homebrew
```bash
brew install --cask --zap gstreamer-development
```

3. Clone the project repository
```bash
git clone https://github.com/Ahua9527/VANB.git
cd VANB
```

4. Install Python dependencies
```bash
pip install -r requirements.txt
```

5. Configure environment variables (refer to the .env file)
```bash
# Configure NDI SDK path
export NDI_SDK_PATH=/Library/NDI SDK for Apple
# Configure GStreamer plugin path
export GST_PLUGIN_PATH=/opt/homebrew/lib/gstreamer-1.0:${NDI_SDK_PATH}/lib/macOS
export DYLD_LIBRARY_PATH=/opt/homebrew/lib:${NDI_SDK_PATH}/lib/macOS
export GI_TYPELIB_PATH=/opt/homebrew/lib/girepository-1.0:/usr/local/lib/girepository-1.0
```

## Usage

### NDI to RTMP (Transmitter)
```bash
python vanb_tx.py
```
The program will automatically scan for available NDI sources and prompt for the RTMP streaming address.

### RTMP to NDI (Receiver)
```bash
python vanb_rx.py
```
After entering the RTMP stream address, the program will automatically create a new NDI output.

## Development Status

### Features Implemented
- ✓ Conversion from NDI to RTMP
- ✓ Conversion from RTMP to NDI
- ✓ Automatic frame rate and resolution adaptation
- ✓ Audio and video synchronization
- ✓ Automatic NDI source scanning
- ✓ Automatic NDI output naming
- ✓ VideoToolbox hardware encoding/decoding

### Features To Be Implemented
- ⨯ Configuration file support (Profile/config.json)
  - Control input and output parameters via configuration file
  - Support for multiple transcoding preset configurations
  - Configurable buffer size and latency parameters
  - Support for transcoding quality and performance balance configurations
- ⨯ Multi-stream concurrent processing

## License Statement

⚠️ **Important Notice: Licensing and Compliance**

### Software License

This project is licensed under the [GNU General Public License v3.0](https://www.gnu.org/licenses/gpl-3.0.html).

Reasons for choosing the GPL-3.0 license:
1. This project uses several GStreamer plugins under the GPL license:
   - `x264`: H.264 video encoder (GPL)
   - `x265`: HEVC/H.265 video encoder (GPL)
   - `faad`: AAC audio decoder (GPL)
2. According to the copyleft clause of GPL, software using GPL components must also adopt the GPL license
3. Choosing GPL-3.0 ensures license compatibility with all dependent components

### License Requirements

When using this project, you must comply with the following requirements:
1. **Open Source Code**: If you modify the project's code or integrate it into your own project, you must open source your complete source code
2. **Retain License**: Your project must continue to use the GPL-3.0 license
3. **Copyright Notice**: You must retain the original copyright and license statements
4. **Prominent Notice**: If you modify the code, you must prominently note the changes you have made
5. **Patent Grant**: GPL-3.0 includes explicit patent grant terms

### GStreamer Component Licenses
1. This project is for development and testing purposes only
2. NDI® is a registered trademark of NewTek, Inc.
3. Use of this project requires compliance with the NewTek NDI® SDK license agreement
4. Before using in production environments, make sure all necessary licenses and authorizations are obtained

## Issue Reporting

If you encounter any issues, please:
1. Check if the environment variables are configured correctly
2. Confirm whether the GStreamer plugins are correctly installed
3. Check the log files for detailed error information
4. Report issues via Issues, and attach logs and environment information

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---