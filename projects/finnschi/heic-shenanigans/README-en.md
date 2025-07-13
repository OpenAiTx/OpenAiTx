# 🖼️ HEIC Image Processing Tools

A collection of Python tools for processing HEIC (High Efficiency Image Container) files, with a focus on HDR content extraction and EXR conversion.

## 🛠️ Tools Overview

### 1. gain_map_extract.py
Extracts all components from HEIC files including:
- Base images
- HDR gain maps
- Depth maps
- Complete metadata (EXIF, XMP, ICC profiles)

### 2. heic_to_exr.py
Converts HEIC files to OpenEXR format:
- Combines base image and gain map into HDR EXR using Apple's method
- Preserves full dynamic range
- Maintains metadata where possible
- Supports batch processing
### 3. merge_to_exr.sh
Shell script for batch processing:
- Automates HEIC to EXR conversion
- Handles multiple files
- Provides progress feedback
- Maintains directory structure

## 🔧 Installation

### Prerequisites
- Python 3.8 or higher
- pip (Python package manager)
- Git (for cloning the repository)

### macOS
```bash
# Install Homebrew if not already installed
/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"

# Install Python and OpenEXR dependencies
brew install python3 openexr

# Clone the repository
git clone https://github.com/finnschi/heic-shenanigans.git
cd heic-shenanigans

# Create and activate virtual environment
python3 -m venv venv
source venv/bin/activate

# Install Python dependencies
pip install -r requirements.txt
```

### Linux (Ubuntu/Debian)
```bash
# Install system dependencies
sudo apt-get update
sudo apt-get install python3 python3-pip python3-venv openexr libopenexr-dev

# Clone the repository
git clone https://github.com/finnschi/heic-shenanigans.git
cd heic-shenanigans

# Create and activate virtual environment
python3 -m venv venv
source venv/bin/activate

# Install Python dependencies
pip install -r requirements.txt
```

### Windows
```powershell
# Install Python from https://www.python.org/downloads/
# Install Git from https://git-scm.com/download/win

# Clone the repository
git clone https://github.com/finnschi/heic-shenanigans.git
cd heic-shenanigans

# Create and activate virtual environment
python -m venv venv
.\venv\Scripts\activate

# Install Python dependencies
pip install -r requirements.txt
```

## 📋 Requirements
All required Python packages are listed in requirements.txt:
- Pillow: Image processing library
- pillow-heif: HEIC file support
- numpy: Numerical operations
- defusedxml: Safe XML parsing

System dependencies (installed via package manager):
- OpenEXR and OpenImageIO (oiiotool) for EXR file handling

## 💻 Usage
### Gain Map Extraction
```bash
python gain_map_extract.py input.heic [--output-dir OUTPUT_DIR]
```

### HEIC to EXR Conversion
```bash
python heic_to_exr.py input.heic [--output-dir OUTPUT_DIR]
```

### Batch Processing
```bash
./merge_to_exr.sh input_directory output_directory
```

## 📁 Output Files

### gain_map_extract.py outputs:
- Base image: `{filename}_base.tiff`
- Gain maps: `{filename}_gain_map_{id}.tiff`
- Depth maps: `{filename}_depth_{index}.tiff`
- Metadata: `{filename}_metadata.json`

### heic_to_exr.py outputs:
- HDR EXR file: `{filename}.exr`

## 🔍 Advanced Usage

### Metadata Handling
- Binary data is base64 encoded
- ICC profiles are maintained
- EXIF data is preserved where possible

### HDR Processing
- Gain maps are properly scaled
- Linear color space is maintained
- Full dynamic range is preserved in EXR output

## ⚠️ Known Limitations
- Some HEIC variants may not be fully supported
- Depth map extraction is limited to supported devices
- Windows OpenEXR support may require additional configuration
## 🤝 Contributing
Contributions are welcome! Please feel free to submit a Pull Request.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---