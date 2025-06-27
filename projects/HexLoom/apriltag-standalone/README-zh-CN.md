# AprilTag独立检测库

这是一个基于pupil-apriltags库的AprilTag识别工具包，用于摄像头中AprilTag的检测和跟踪。

<!-- 保留这些链接。翻译将自动与README同步更新。 -->
[Deutsch](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=de) | 
[English](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=en) | 
[Español](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=es) | 
[français](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=fr) | 
[日本語](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ja) | 
[한국어](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ko) | 
[Português](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=pt) | 
[Русский](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ru) | 
[中文](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=zh)

## 依赖库

- Python 3.6+
- OpenCV
- NumPy
- pupil-apriltags

## 安装

1. 确保已安装Python环境
2. 安装必要的依赖：

```bash
pip install opencv-python numpy pupil-apriltags
```

## 使用方法

### 基本用法

```python
import cv2
from apriltag import Detector, DetectorOptions

# 创建检测器
options = DetectorOptions(
    families="tag36h11",  # 标签家族
    border=1,             # 标签边框大小
    nthreads=4,           # 线程数量
    quad_decimate=1.0,    # 图像下采样系数
    quad_blur=0.0,        # 高斯模糊系数
    refine_edges=True     # 是否精细化边缘
)
detector = Detector(options)

# 读取图像
img = cv2.imread("test_image.jpg")
gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

# 检测AprilTag
detections = detector.detect(gray)

# 显示检测结果
for detection in detections:
    print(f"标签家族: {detection.tag_family}, ID: {detection.tag_id}")
    print(f"位置: {detection.center}")
    print(f"角点: {detection.corners}")
```

### 绘制检测结果

```python
import numpy as np
from apriltag import draw_detection_results

# 相机内参矩阵和畸变系数
K = np.array([[800, 0, 320], [0, 800, 240], [0, 0, 1]], dtype=np.float32)
D = np.zeros((4, 1), dtype=np.float32)

# 绘制检测结果
result_img = draw_detection_results(img, detections, K, D, tag_size=0.1)

# 显示结果
cv2.imshow("AprilTag检测", result_img)
cv2.waitKey(0)
```

### 运行测试脚本

提供了一个简单的测试脚本，可以用于验证AprilTag检测功能：

```bash
python test_apriltag.py
```

这将打开电脑默认摄像头并实时检测AprilTag。按"q"键退出。

## 支持的标签家族

pupil-apriltags库支持以下标签家族：
- tag36h11 (默认)
- tag25h9
- tag16h5
- tagCircle21h7
- tagCircle49h12
- tagStandard41h12
- tagStandard52h13
- tagCustom48h12

## 注意事项

- 为获得更好的性能，可以调整DetectorOptions中的参数
- 对于计算资源有限的设备，可以考虑增加quad_decimate参数来降低计算复杂度
- 确保使用的AprilTag标记的尺寸与代码中的tag_size参数匹配
- 绘制3D坐标轴需要准确的相机参数

## 功能特点

- 支持USB摄像头实时AprilTag检测
- 计算并显示标签的3D位姿(位置和方向)
- 支持保存原始和标记后的图像
- 可自定义配置和相机参数
- 包含完整的相机标定工具
- 不依赖ROS，是原ROS包的纯Python独立版本

## 安装步骤

### 1. 安装AprilTag C库

AprilTag的C库是必需的。请按照以下步骤安装：

#### Ubuntu/Debian:
```bash
sudo apt-get update
sudo apt-get install -y libapriltag-dev
```

#### Windows:
Windows用户需要自行编译或下载预编译的二进制文件，并确保`apriltag.dll`在系统PATH中或当前目录。

### 2. 安装Python依赖

```bash
pip install -r requirements.txt  -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
pip install pupil-apriltags -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
```

## 使用说明

### 快速开始 (推荐)

最简单的使用方式是运行集成工具，它提供了交互式菜单来引导您完成所有步骤：

```bash
python apriltag_tool.py
```

这个工具会提供菜单选项：
1. 生成棋盘格标定板
2. 相机标定
3. AprilTag检测
4. 查看帮助文档

只需按照菜单提示操作即可完成整个流程。

### 相机标定

在使用AprilTag检测前，建议先进行相机标定，获取准确的相机参数：

```bash
# 首先生成棋盘格标定板
python create_chessboard.py --size 9x6 --square 100 --output chessboard.png --dpi 300

# 打印棋盘格并测量实际方格大小，然后进行标定
python camera_calibration.py --size 9x6 --square 0.025 --output config/camera/HSK_200W53_1080P.yaml
```

参数说明:

**棋盘格生成工具 (create_chessboard.py):**
- `--size`: 棋盘格内角点数量，宽x高 (默认: 9x6)
- `--square`: 方格大小，像素 (默认: 100)
- `--output`: 输出文件路径 (默认: chessboard.png)
- `--dpi`: 输出图像的DPI (默认: 300)，影响打印尺寸

**相机标定程序 (camera_calibration.py):**
- `--size`: 棋盘格内角点数量，宽x高 (默认: 9x6)
- `--square`: 棋盘格方块大小，单位米 (默认: 0.025)
- `--output`: 输出文件路径 (默认: config/camera/HSK_200W53_1080P.yaml)
- `--camera`: 摄像头设备ID (默认: 0)
- `--width`: 摄像头捕获宽度 (默认: 1280)
- `--height`: 摄像头捕获高度 (默认: 720)
- `--samples`: 标定所需样本数量 (默认: 20)
- `--preview`: 标定完成后预览校正效果

标定过程：
1. 生成并打印棋盘格标定板
2. 测量实际方格大小（以米为单位）
3. 运行标定程序，将棋盘格放在相机前，从不同角度采集样本
4. 程序会自动检测棋盘格并收集样本，也可按's'键手动保存当前帧
5. 收集足够样本后，程序自动计算相机参数并保存到指定文件

### AprilTag检测

标定完成后，可以运行AprilTag检测程序：
```bash
python apriltag_detector.py
```

### 高级用法

```bash
python apriltag_detector.py [配置文件路径] --camera 相机ID --width 宽度 --height 高度 --camera_info 相机参数文件
```

参数说明：
- `配置文件路径`：AprilTag 配置文件路径（默认：`config/vision/tags_36h11_all.json`）
- `--camera`：摄像头设备ID（默认：0）
- `--camera_info`：相机内参文件路径（默认：`config/camera/HSK_200W53_1080P.yaml`）
- `--width`：摄像头捕获宽度（默认：1280）
- `--height`：摄像头捕获高度（默认：720）

### 按键控制

- `q`：退出程序

## 配置文件说明

系统的所有配置都可以在 `config/vision/table_setup.json` 文件中进行设置：

```json
{
    "AprilTagConfig": {
        "family": "tag36h11",      // 标签家族
        "size": 0.05,              // 标签物理尺寸（单位：米）
        "threads": 2,              // 处理线程数
        "max_hamming": 0,          // 最大汉明距离
        "z_up": true,              // Z轴朝上
        "decimate": 1.0,           // 图像下采样系数
        "blur": 0.8,               // 模糊系数
        "refine_edges": 1,         // 是否精细化边缘
        "debug": 0                 // 是否打开调试
    },

    "Camera": {
        "device_id": 0,            // 相机设备ID
        "width": 1280,             // 相机宽度分辨率
        "height": 720,             // 相机高度分辨率
        "camera_info_path": "config/camera/HSK_200W53_1080P.yaml"  // 相机标定参数文件
    },

    "Archive": {
        "enable": true,            // 是否启用数据存档
        "preview": true,           // 是否显示预览窗口
        "save_raw": false,         // 是否保存原始图像
        "save_pred": false,        // 是否保存预测图像
        "path": "./data/table_tracking"  // 数据保存路径
    },

    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // 参考标签ID列表
        "moving_tags": [4, 5, 6],            // 移动标签ID列表
        "require_initialization": true,       // 是否需要初始化
        "tag_positions": {                    // 预设标签位置（如果有）
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

通过修改配置文件，可以：
1. 配置 AprilTag 检测器参数
2. 设置相机参数（设备ID、分辨率、参数文件）
3. 配置数据存档选项
4. 自定义参考标签和移动标签的ID
5. 控制是否需要初始化（将 `require_initialization` 设置为 `false` 可跳过初始化步骤）
6. 预设标签的位置信息

### 使用方法

非常简单，只需一条命令即可启动系统：

```
python table_tracking.py
```

如需使用自定义配置文件：

```
python table_tracking.py --config 自定义配置文件路径
```

系统运行后，随时可以按 'i' 键手动触发初始化过程。

## 常见问题

1. **找不到 apriltag 库**
   
   请确保已正确安装 apriltag 库，并且库文件在系统中可以找到。

2. **相机无法打开**
   
   检查相机设备ID是否正确，以及相机是否被其他程序占用。

3. **检测结果不准确**
   
   请确保您的相机已经正确标定，并且配置文件中的标签尺寸正确。

## 文件结构说明

```
apriltag_standalone/
├── apriltag.py              # AprilTag 检测库核心代码
├── apriltag_detector.py     # AprilTag 检测主程序
├── apriltag_tool.py         # 集成工具启动菜单
├── camera_calibration.py    # 相机标定程序
├── create_chessboard.py     # 棋盘格生成工具
├── configs.py               # 配置文件处理
├── config/                  # 配置目录
│   ├── camera/              # 相机配置
│   │   └── HSK_200W53_1080P.yaml  # 相机参数
│   └── vision/              # 视觉配置
│       └── tags_36h11_all.json # AprilTag 配置
├── README.md                # 说明文档
└── requirements.txt         # Python 依赖
```

## 技术说明

本项目是从 ROS AprilTag 检测包移植的独立版本，移除了 ROS 依赖，保留了核心功能。
主要使用了以下技术：

- OpenCV：图像处理、相机标定和姿态估计
- AprilTag C库：标签检测
- SciPy：旋转矩阵和四元数转换

## 许可证

本项目基于 MIT 许可证

## 新功能说明

### 多标签跟踪与遮挡处理

本系统现已支持以下新功能：

1. **拍照初始化**：系统启动后会自动进行一次拍照初始化，记录标签的位置关系，包括：
   - 固定参考标签（ID 0-3）的位置
   - 多个移动标签（默认 ID 4,5,6）之间的相对位置关系

2. **遮挡处理**：初始化后，即使部分标签被遮挡：
   - 若参考标签被遮挡，系统可利用其它可见参考标签估计被遮挡标签的位置
   - 若移动标签被遮挡，系统可通过其它可见的移动标签估计被遮挡移动标签的位置

3. **多标签跟踪**：支持同时跟踪多个移动标签，默认支持 ID 4,5,6
   - 如果移动标签之间的相对位置固定，仅需有一个可见，即可估计其它标签位置
   - 可在配置文件中自定义移动标签ID

### 配置文件说明

系统的所有配置都可以在 `config/vision/table_setup.json` 文件中进行设置：

```json
{
    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // 参考标签ID列表
        "moving_tags": [4, 5, 6],            // 移动标签ID列表
        "require_initialization": true,       // 是否需要初始化
        "tag_positions": {                    // 预设标签位置（如果有）
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

通过修改配置文件，可以：
1. 自定义参考标签和移动标签的ID
2. 控制是否需要初始化（将 `require_initialization` 设置为 `false` 可跳过初始化步骤）
3. 预设标签的位置信息

### 使用方法

1. 使用默认配置启动系统：
   ```
   python table_tracking.py
   ```

2. 使用自定义配置文件启动系统：
   ```
   python table_tracking.py --config 自定义配置文件路径
   ```

3. 手动初始化：系统运行过程中按 'i' 键

### 运行要求

确保所有标签在初始化时均可见，系统会记录标签之间的相对位置关系。初始化后，即使部分标签被遮挡，系统也能正确估计所有标签的位置。
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---