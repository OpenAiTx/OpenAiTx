# AprilTag獨立檢測庫

這是一個基於 pupil-apriltags 庫的 AprilTag 識別工具包，用於攝像頭中 AprilTag 的檢測和追蹤。

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

## 依賴庫

- Python 3.6+
- OpenCV
- NumPy
- pupil-apriltags

## 安裝

1. 確保已安裝 Python 環境
2. 安裝必要的依賴：

```bash
pip install opencv-python numpy pupil-apriltags
```

## 使用方法

### 基本用法

```python
import cv2
from apriltag import Detector, DetectorOptions

# 建立檢測器
options = DetectorOptions(
    families="tag36h11",  # 標籤家族
    border=1,             # 標籤邊框大小
    nthreads=4,           # 執行緒數量
    quad_decimate=1.0,    # 影像下採樣係數
    quad_blur=0.0,        # 高斯模糊係數
    refine_edges=True     # 是否精細化邊緣
)
detector = Detector(options)

# 讀取影像
img = cv2.imread("test_image.jpg")
gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

# 檢測 AprilTag
detections = detector.detect(gray)

# 顯示檢測結果
for detection in detections:
    print(f"標籤家族: {detection.tag_family}, ID: {detection.tag_id}")
    print(f"位置: {detection.center}")
    print(f"角點: {detection.corners}")
```

### 繪製檢測結果

```python
import numpy as np
from apriltag import draw_detection_results

# 相機內參矩陣與畸變係數
K = np.array([[800, 0, 320], [0, 800, 240], [0, 0, 1]], dtype=np.float32)
D = np.zeros((4, 1), dtype=np.float32)

# 繪製檢測結果
result_img = draw_detection_results(img, detections, K, D, tag_size=0.1)

# 顯示結果
cv2.imshow("AprilTag檢測", result_img)
cv2.waitKey(0)
```

### 執行測試腳本

提供了一個簡單的測試腳本，可用於驗證 AprilTag 檢測功能：

```bash
python test_apriltag.py
```

這將開啟電腦預設攝像頭並即時檢測 AprilTag。按 "q" 鍵退出。

## 支援的標籤家族

pupil-apriltags 庫支援下列標籤家族：
- tag36h11 (預設)
- tag25h9
- tag16h5
- tagCircle21h7
- tagCircle49h12
- tagStandard41h12
- tagStandard52h13
- tagCustom48h12

## 注意事項

- 為獲得更佳效能，可調整 DetectorOptions 中的參數
- 對於運算資源有限的設備，可考慮提高 quad_decimate 參數以降低計算複雜度
- 請確保所使用的 AprilTag 標記尺寸與程式中的 tag_size 參數一致
- 繪製 3D 座標軸需準確的相機參數

## 功能特點

- 支援 USB 攝像頭即時 AprilTag 檢測
- 計算並顯示標籤的 3D 姿態（位置與方向）
- 支援儲存原始與標記後影像
- 可自訂配置與相機參數
- 包含完整的相機校正工具
- 不依賴 ROS，為原 ROS 套件的純 Python 獨立版本

## 安裝步驟

### 1. 安裝 AprilTag C 庫

AprilTag 的 C 庫為必需元件。請依下列步驟安裝：

#### Ubuntu/Debian:
```bash
sudo apt-get update
sudo apt-get install -y libapriltag-dev
```

#### Windows:
Windows 使用者需自行編譯或下載預編譯二進位檔，並確保 `apriltag.dll` 位於系統 PATH 中或當前目錄。

### 2. 安裝 Python 依賴

```bash
pip install -r requirements.txt  -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
pip install pupil-apriltags -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
```

## 使用說明

### 快速開始 (推薦)

最簡單的使用方式為執行整合工具，該工具提供互動式選單來引導您完成所有步驟：

```bash
python apriltag_tool.py
```

此工具會提供選單選項：
1. 產生棋盤格校正板
2. 相機校正
3. AprilTag 檢測
4. 檢視說明文件

只需依照選單提示操作即可完成整個流程。

### 相機校正

於執行 AprilTag 檢測前，建議先進行相機校正，以獲得準確的相機參數：

```bash
# 首先產生棋盤格校正板
python create_chessboard.py --size 9x6 --square 100 --output chessboard.png --dpi 300

# 列印棋盤格並測量實際方格大小，然後進行校正
python camera_calibration.py --size 9x6 --square 0.025 --output config/camera/HSK_200W53_1080P.yaml
```

參數說明:

**棋盤格產生工具 (create_chessboard.py):**
- `--size`: 棋盤格內角點數量，寬x高（預設: 9x6）
- `--square`: 方格大小，像素（預設: 100）
- `--output`: 輸出檔案路徑（預設: chessboard.png）
- `--dpi`: 輸出影像 DPI（預設: 300），影響列印尺寸

**相機校正程式 (camera_calibration.py):**
- `--size`: 棋盤格內角點數量，寬x高（預設: 9x6）
- `--square`: 棋盤格方塊大小，單位公尺（預設: 0.025）
- `--output`: 輸出檔案路徑（預設: config/camera/HSK_200W53_1080P.yaml）
- `--camera`: 攝像頭裝置 ID（預設: 0）
- `--width`: 攝像頭擷取寬度（預設: 1280）
- `--height`: 攝像頭擷取高度（預設: 720）
- `--samples`: 校正所需樣本數（預設: 20）
- `--preview`: 校正完成後預覽校正效果

校正流程：
1. 產生並列印棋盤格校正板
2. 測量實際方格大小（以公尺為單位）
3. 執行校正程式，將棋盤格放於相機前，從不同角度擷取樣本
4. 程式會自動檢測棋盤格並收集樣本，也可按 's' 鍵手動儲存當前影格
5. 收集足夠樣本後，程式自動計算相機參數並儲存至指定檔案

### AprilTag 檢測

校正完成後，可執行 AprilTag 檢測程式：
```bash
python apriltag_detector.py
```

### 高級用法

```bash
python apriltag_detector.py [配置文件路徑] --camera 相機ID --width 寬度 --height 高度 --camera_info 相機參數文件
```

參數說明:
- `配置文件路徑`: AprilTag 配置文件路徑 (預設: `config/vision/tags_36h11_all.json`)
- `--camera`: 攝像頭設備ID (預設: 0)
- `--camera_info`: 相機內參文件路徑 (預設: `config/camera/HSK_200W53_1080P.yaml`)
- `--width`: 攝像頭捕獲寬度 (預設: 1280)
- `--height`: 攝像頭捕獲高度 (預設: 720)

### 按鍵控制

- `q`: 退出程式

## 配置文件說明

系統的所有配置都可以在 `config/vision/table_setup.json` 文件中進行設定：

```json
{
    "AprilTagConfig": {
        "family": "tag36h11",      // 標籤家族
        "size": 0.05,              // 標籤物理尺寸（單位：米）
        "threads": 2,              // 處理執行緒數
        "max_hamming": 0,          // 最大漢明距離
        "z_up": true,              // Z軸朝上
        "decimate": 1.0,           // 影像下採樣係數
        "blur": 0.8,               // 模糊係數
        "refine_edges": 1,         // 是否精細化邊緣
        "debug": 0                 // 是否開啟除錯
    },

    "Camera": {
        "device_id": 0,            // 相機設備ID
        "width": 1280,             // 相機寬度解析度
        "height": 720,             // 相機高度解析度
        "camera_info_path": "config/camera/HSK_200W53_1080P.yaml"  // 相機標定參數文件
    },

    "Archive": {
        "enable": true,            // 是否啟用資料歸檔
        "preview": true,           // 是否顯示預覽視窗
        "save_raw": false,         // 是否儲存原始影像
        "save_pred": false,        // 是否儲存預測影像
        "path": "./data/table_tracking"  // 資料儲存路徑
    },

    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // 參考標籤ID列表
        "moving_tags": [4, 5, 6],            // 移動標籤ID列表
        "require_initialization": true,       // 是否需要初始化
        "tag_positions": {                    // 預設標籤位置（如有）
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

透過修改配置文件，可以：
1. 配置 AprilTag 偵測器參數
2. 設定相機參數（設備ID、解析度、參數文件）
3. 配置資料歸檔選項
4. 自訂參考標籤與移動標籤的ID
5. 控制是否需要初始化（將 `require_initialization` 設為 `false` 可跳過初始化步驟）
6. 預設標籤的位置信息

### 使用方法

非常簡單，只需要一行指令即可啟動系統：

```
python table_tracking.py
```

如需使用自訂配置文件：

```
python table_tracking.py --config 自訂配置文件路徑
```

系統運行後，可隨時按 'i' 鍵手動觸發初始化流程。

## 常見問題

1. **找不到 apriltag 函式庫**
   
   請確認已正確安裝 apriltag 函式庫，且系統可找到該庫檔案。

2. **無法開啟相機**
   
   請檢查相機設備ID是否正確，且相機未被其他程式佔用。

3. **偵測結果不準確**
   
   請確認您的相機已正確標定，且配置文件中的標籤尺寸正確。

## 文件結構說明

```
apriltag_standalone/
├── apriltag.py              # AprilTag 偵測庫核心程式
├── apriltag_detector.py     # AprilTag 偵測主程式
├── apriltag_tool.py         # 集成工具啟動選單
├── camera_calibration.py    # 相機標定程式
├── create_chessboard.py     # 棋盤格生成工具
├── configs.py               # 配置文件處理
├── config/                  # 配置目錄
│   ├── camera/              # 相機配置
│   │   └── HSK_200W53_1080P.yaml  # 相機參數
│   └── vision/              # 視覺配置
│       └── tags_36h11_all.json # AprilTag 配置
├── README.md                # 說明文件
└── requirements.txt         # Python 相依套件
```

## 技術說明

本專案為從 ROS AprilTag 偵測包移植的獨立版本，去除了 ROS 依賴，保留核心功能。
主要使用以下技術：

- OpenCV：影像處理、相機標定與姿態估算
- AprilTag C 函式庫：標籤偵測
- SciPy：旋轉矩陣與四元數轉換

## 授權

本專案採用 MIT 授權 

## 新功能說明

### 多標籤追蹤與遮蔽處理

本系統現在支援以下新功能：

1. **拍照初始化**：系統啟動後會自動進行一次拍照初始化，記錄標籤之間的位置關係，包括：
   - 固定參考標籤（ID 0-3）的位置
   - 多個移動標籤（預設 ID 4,5,6）之間的相對位置關係

2. **遮蔽處理**：初始化後，即使部分標籤被遮蔽：
   - 若參考標籤被遮蔽，系統可利用其他可見參考標籤推估被遮蔽標籤的位置
   - 若移動標籤被遮蔽，系統可透過其他可見移動標籤推估被遮蔽移動標籤的位置

3. **多標籤追蹤**：支援同時追蹤多個移動標籤，預設支援 ID 4,5,6
   - 若移動標籤之間的相對位置為固定，只要有一個可見，即可推估其他標籤位置
   - 可於配置文件中自訂移動標籤ID

### 配置文件說明

系統的所有配置都可以在 `config/vision/table_setup.json` 文件中進行設定：

```json
{
    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // 參考標籤ID列表
        "moving_tags": [4, 5, 6],            // 移動標籤ID列表
        "require_initialization": true,       // 是否需要初始化
        "tag_positions": {                    // 預設標籤位置（如有）
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

透過修改配置文件，可以：
1. 自訂參考標籤與移動標籤的ID
2. 控制是否需要初始化（將 `require_initialization` 設為 `false` 可跳過初始化步驟）
3. 預設標籤的位置信息

### 使用方法

1. 使用預設配置啟動系統：
   ```
   python table_tracking.py
   ```

2. 使用自訂配置文件啟動系統：
   ```
   python table_tracking.py --config 自訂配置文件路徑
   ```

3. 手動初始化：系統運作時按 'i' 鍵

### 執行要求

請確保所有標籤於初始化時可見，系統會記錄標籤間的相對位置。初始化後，即使部分標籤被遮蔽，系統仍可正確推估所有標籤的位置。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---