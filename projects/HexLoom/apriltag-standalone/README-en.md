# AprilTag Standalone Detection Library

This is an AprilTag recognition toolkit based on the pupil-apriltags library for detecting and tracking AprilTags in camera images.

<!-- Keep these links. Translations will automatically update with the README. -->
[Deutsch](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=de) | 
[English](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=en) | 
[Español](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=es) | 
[français](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=fr) | 
[日本語](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ja) | 
[한국어](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ko) | 
[Português](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=pt) | 
[Русский](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ru) | 
[中文](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=zh)

## Dependencies

- Python 3.6+
- OpenCV
- NumPy
- pupil-apriltags

## Installation

1. Make sure Python is installed
2. Install the necessary dependencies:

```bash
pip install opencv-python numpy pupil-apriltags
```

## Usage

### Basic Usage

```python
import cv2
from apriltag import Detector, DetectorOptions

# Create detector
options = DetectorOptions(
    families="tag36h11",  # Tag family
    border=1,             # Tag border size
    nthreads=4,           # Number of threads
    quad_decimate=1.0,    # Image downsampling factor
    quad_blur=0.0,        # Gaussian blur factor
    refine_edges=True     # Refine edges or not
)
detector = Detector(options)

# Read image
img = cv2.imread("test_image.jpg")
gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

# Detect AprilTags
detections = detector.detect(gray)

# Show detection results
for detection in detections:
    print(f"Tag Family: {detection.tag_family}, ID: {detection.tag_id}")
    print(f"Center: {detection.center}")
    print(f"Corners: {detection.corners}")
```

### Drawing Detection Results

```python
import numpy as np
from apriltag import draw_detection_results

# Camera intrinsic matrix and distortion coefficients
K = np.array([[800, 0, 320], [0, 800, 240], [0, 0, 1]], dtype=np.float32)
D = np.zeros((4, 1), dtype=np.float32)

# Draw detection results
result_img = draw_detection_results(img, detections, K, D, tag_size=0.1)

# Show result
cv2.imshow("AprilTag Detection", result_img)
cv2.waitKey(0)
```

### Running the Test Script

A simple test script is provided to verify AprilTag detection functionality:

```bash
python test_apriltag.py
```

This will open the default computer camera and detect AprilTags in real time. Press "q" to exit.

## Supported Tag Families

The pupil-apriltags library supports the following tag families:
- tag36h11 (default)
- tag25h9
- tag16h5
- tagCircle21h7
- tagCircle49h12
- tagStandard41h12
- tagStandard52h13
- tagCustom48h12

## Notes

- For better performance, you can adjust the parameters in DetectorOptions
- For devices with limited computing resources, consider increasing the quad_decimate parameter to reduce computational complexity
- Make sure the size of the AprilTag marker used matches the tag_size parameter in the code
- Drawing 3D coordinate axes requires accurate camera parameters

## Features

- Real-time AprilTag detection with USB cameras
- Computes and displays tag 3D pose (position and orientation)
- Supports saving original and annotated images
- Customizable configuration and camera parameters
- Includes a complete camera calibration tool
- No ROS dependency, a pure Python standalone version of the original ROS package

## Installation Steps

### 1. Install AprilTag C Library

The AprilTag C library is required. Please install as follows:

#### Ubuntu/Debian:
```bash
sudo apt-get update
sudo apt-get install -y libapriltag-dev
```

#### Windows:
Windows users need to compile or download the precompiled binaries themselves, and ensure `apriltag.dll` is in the system PATH or the current directory.

### 2. Install Python Dependencies

```bash
pip install -r requirements.txt  -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
pip install pupil-apriltags -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
```

## User Guide

### Quick Start (Recommended)

The simplest way to use is to run the integrated tool, which provides an interactive menu to guide you through all steps:

```bash
python apriltag_tool.py
```

This tool provides menu options:
1. Generate chessboard calibration board
2. Camera calibration
3. AprilTag detection
4. View help documentation

Simply follow the menu prompts to complete the entire process.

### Camera Calibration

It is recommended to calibrate the camera before using AprilTag detection to obtain accurate camera parameters:

```bash
# First, generate the chessboard calibration board
python create_chessboard.py --size 9x6 --square 100 --output chessboard.png --dpi 300

# Print the chessboard and measure the actual square size, then calibrate
python camera_calibration.py --size 9x6 --square 0.025 --output config/camera/HSK_200W53_1080P.yaml
```

Parameter description:

**Chessboard Generation Tool (create_chessboard.py):**
- `--size`: Number of inner corners, width x height (default: 9x6)
- `--square`: Square size in pixels (default: 100)
- `--output`: Output file path (default: chessboard.png)
- `--dpi`: Output image DPI (default: 300), affects print size

**Camera Calibration Program (camera_calibration.py):**
- `--size`: Number of inner corners, width x height (default: 9x6)
- `--square`: Chessboard square size in meters (default: 0.025)
- `--output`: Output file path (default: config/camera/HSK_200W53_1080P.yaml)
- `--camera`: Camera device ID (default: 0)
- `--width`: Camera capture width (default: 1280)
- `--height`: Camera capture height (default: 720)
- `--samples`: Number of samples required for calibration (default: 20)
- `--preview`: Preview correction effect after calibration

Calibration process:
1. Generate and print the chessboard calibration board
2. Measure the actual square size (in meters)
3. Run the calibration program, place the chessboard in front of the camera, and collect samples from different angles
4. The program will automatically detect the chessboard and collect samples, or you can press the 's' key to manually save the current frame
5. After collecting enough samples, the program will automatically compute camera parameters and save them to the specified file

### AprilTag Detection

After calibration is complete, you can run the AprilTag detection program:
```bash
python apriltag_detector.py
```

### Advanced Usage

```bash
python apriltag_detector.py [config_file_path] --camera CAMERA_ID --width WIDTH --height HEIGHT --camera_info CAMERA_PARAMS_FILE
```

Parameter description:
- `config_file_path`: Path to the AprilTag configuration file (default: `config/vision/tags_36h11_all.json`)
- `--camera`: Camera device ID (default: 0)
- `--camera_info`: Path to camera intrinsic parameter file (default: `config/camera/HSK_200W53_1080P.yaml`)
- `--width`: Camera capture width (default: 1280)
- `--height`: Camera capture height (default: 720)

### Keyboard Controls

- `q`: Exit the program

## Configuration File Description

All system configurations can be set in the `config/vision/table_setup.json` file:

```json
{
    "AprilTagConfig": {
        "family": "tag36h11",      // Tag family
        "size": 0.05,              // Tag physical size (unit: meters)
        "threads": 2,              // Number of processing threads
        "max_hamming": 0,          // Maximum Hamming distance
        "z_up": true,              // Z-axis upward
        "decimate": 1.0,           // Image downsampling factor
        "blur": 0.8,               // Blur factor
        "refine_edges": 1,         // Whether to refine edges
        "debug": 0                 // Enable debugging
    },

    "Camera": {
        "device_id": 0,            // Camera device ID
        "width": 1280,             // Camera width resolution
        "height": 720,             // Camera height resolution
        "camera_info_path": "config/camera/HSK_200W53_1080P.yaml"  // Camera calibration parameter file
    },

    "Archive": {
        "enable": true,            // Enable data archiving
        "preview": true,           // Show preview window
        "save_raw": false,         // Save raw images
        "save_pred": false,        // Save predicted images
        "path": "./data/table_tracking"  // Data saving path
    },

    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // List of reference tag IDs
        "moving_tags": [4, 5, 6],            // List of moving tag IDs
        "require_initialization": true,       // Whether initialization is required
        "tag_positions": {                    // Preset tag positions (if any)
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

By modifying the configuration file, you can:
1. Configure AprilTag detector parameters
2. Set camera parameters (device ID, resolution, parameter file)
3. Configure data archive options
4. Customize reference tag and moving tag IDs
5. Control whether initialization is required (set `require_initialization` to `false` to skip initialization)
6. Preset tag position information

### Usage

Very simple, just use one command to start the system:

```
python table_tracking.py
```

If you need to use a custom configuration file:

```
python table_tracking.py --config CUSTOM_CONFIG_PATH
```

After the system is running, you can press the 'i' key at any time to manually trigger the initialization process.

## FAQ

1. **AprilTag library not found**
   
   Make sure the AprilTag library is installed correctly and the library files can be found by the system.

2. **Camera cannot be opened**
   
   Check if the camera device ID is correct and if the camera is not occupied by other programs.

3. **Detection results are inaccurate**
   
   Make sure your camera is properly calibrated and the tag size in the configuration file is correct.


## File Structure Description

```
apriltag_standalone/
├── apriltag.py              # Core code of the AprilTag detection library
├── apriltag_detector.py     # Main AprilTag detection program
├── apriltag_tool.py         # Integrated tool startup menu
├── camera_calibration.py    # Camera calibration program
├── create_chessboard.py     # Chessboard generation tool
├── configs.py               # Configuration file handler
├── config/                  # Configuration directory
│   ├── camera/              # Camera configuration
│   │   └── HSK_200W53_1080P.yaml  # Camera parameters
│   └── vision/              # Vision configuration
│       └── tags_36h11_all.json # AprilTag configuration
├── README.md                # Documentation
└── requirements.txt         # Python dependencies
```

## Technical Description

This project is an independent version ported from the ROS AprilTag detection package, with ROS dependencies removed and core functions retained.
It mainly uses the following technologies:

- OpenCV: image processing, camera calibration, and pose estimation
- AprilTag C library: tag detection
- SciPy: rotation matrix and quaternion conversion

## License

This project is licensed under the MIT License.

## New Features

### Multi-Tag Tracking and Occlusion Handling

This system now supports the following new features:

1. **Photo Initialization**: After system startup, it will automatically take a photo for initialization, recording the positional relationships of the tags, including:
   - Positions of fixed reference tags (IDs 0-3)
   - Relative positions among multiple moving tags (default IDs 4, 5, 6)

2. **Occlusion Handling**: After initialization, even if some tags are occluded:
   - If reference tags are occluded, the system can estimate the occluded tag's position using other visible reference tags
   - If moving tags are occluded, the system can estimate the occluded moving tag's position using other visible moving tags

3. **Multi-Tag Tracking**: Supports simultaneous tracking of multiple moving tags, default IDs 4, 5, 6
   - If the relative positions among moving tags are fixed, as long as one is visible, the positions of the others can be estimated
   - Moving tag IDs can be customized in the configuration file

### Configuration File Description

All system configurations can be set in the `config/vision/table_setup.json` file:

```json
{
    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // List of reference tag IDs
        "moving_tags": [4, 5, 6],            // List of moving tag IDs
        "require_initialization": true,       // Whether initialization is required
        "tag_positions": {                    // Preset tag positions (if any)
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

By modifying the configuration file, you can:
1. Customize reference tag and moving tag IDs
2. Control whether initialization is required (set `require_initialization` to `false` to skip initialization)
3. Preset tag position information

### Usage

1. Start the system with the default configuration:
   ```
   python table_tracking.py
   ```

2. Start the system with a custom configuration file:
   ```
   python table_tracking.py --config CUSTOM_CONFIG_PATH
   ```

3. Manual initialization: press the 'i' key while the system is running

### Running Requirements

Make sure all tags are visible during initialization. The system will record the relative positions among tags. After initialization, even if some tags are occluded, the system can still correctly estimate the positions of all tags.
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---