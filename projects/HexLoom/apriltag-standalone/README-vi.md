# AprilTag独立检测库

Đây là một bộ công cụ nhận diện AprilTag dựa trên thư viện pupil-apriltags, dùng để phát hiện và theo dõi AprilTag trong camera.

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

## Thư viện phụ thuộc

- Python 3.6+
- OpenCV
- NumPy
- pupil-apriltags

## Cài đặt

1. Đảm bảo đã cài đặt môi trường Python
2. Cài đặt các thư viện phụ thuộc cần thiết:

```bash
pip install opencv-python numpy pupil-apriltags
```

## Hướng dẫn sử dụng

### Cách sử dụng cơ bản

```python
import cv2
from apriltag import Detector, DetectorOptions

# Tạo bộ phát hiện
options = DetectorOptions(
    families="tag36h11",  # Loại tag
    border=1,             # Kích thước viền tag
    nthreads=4,           # Số lượng luồng
    quad_decimate=1.0,    # Hệ số giảm mẫu ảnh
    quad_blur=0.0,        # Hệ số làm mờ Gaussian
    refine_edges=True     # Có tinh chỉnh biên hay không
)
detector = Detector(options)

# Đọc ảnh
img = cv2.imread("test_image.jpg")
gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

# Phát hiện AprilTag
detections = detector.detect(gray)

# Hiển thị kết quả phát hiện
for detection in detections:
    print(f"Loại tag: {detection.tag_family}, ID: {detection.tag_id}")
    print(f"Vị trí: {detection.center}")
    print(f"Các góc: {detection.corners}")
```

### Vẽ kết quả phát hiện

```python
import numpy as np
from apriltag import draw_detection_results

# Ma trận nội tại camera và hệ số biến dạng
K = np.array([[800, 0, 320], [0, 800, 240], [0, 0, 1]], dtype=np.float32)
D = np.zeros((4, 1), dtype=np.float32)

# Vẽ kết quả phát hiện
result_img = draw_detection_results(img, detections, K, D, tag_size=0.1)

# Hiển thị kết quả
cv2.imshow("Phát hiện AprilTag", result_img)
cv2.waitKey(0)
```

### Chạy script kiểm tra

Có sẵn một script kiểm tra đơn giản để xác minh chức năng phát hiện AprilTag:

```bash
python test_apriltag.py
```

Lệnh này sẽ mở camera mặc định của máy tính và phát hiện AprilTag theo thời gian thực. Nhấn phím "q" để thoát.

## Các loại tag được hỗ trợ

Thư viện pupil-apriltags hỗ trợ các loại tag sau:
- tag36h11 (mặc định)
- tag25h9
- tag16h5
- tagCircle21h7
- tagCircle49h12
- tagStandard41h12
- tagStandard52h13
- tagCustom48h12

## Lưu ý

- Để có hiệu năng tốt hơn, có thể điều chỉnh các tham số trong DetectorOptions
- Đối với thiết bị có tài nguyên hạn chế, có thể tăng tham số quad_decimate để giảm độ phức tạp tính toán
- Đảm bảo kích thước AprilTag in ra phù hợp với tham số tag_size trong code
- Vẽ trục tọa độ 3D yêu cầu tham số camera chính xác

## Tính năng

- Hỗ trợ phát hiện AprilTag thời gian thực qua camera USB
- Tính toán và hiển thị tư thế 3D (vị trí và hướng) của tag
- Hỗ trợ lưu ảnh gốc và ảnh có đánh dấu
- Có thể tùy chỉnh cấu hình và tham số camera
- Bao gồm công cụ hiệu chuẩn camera đầy đủ
- Không phụ thuộc ROS, là phiên bản độc lập thuần Python từ ROS

## Các bước cài đặt

### 1. Cài đặt thư viện C AprilTag

Thư viện C của AprilTag là bắt buộc. Vui lòng làm theo các bước sau để cài đặt:

#### Ubuntu/Debian:
```bash
sudo apt-get update
sudo apt-get install -y libapriltag-dev
```

#### Windows:
Người dùng Windows cần tự biên dịch hoặc tải file nhị phân đã biên dịch sẵn, đồng thời đảm bảo `apriltag.dll` nằm trong PATH hệ thống hoặc cùng thư mục chạy chương trình.

### 2. Cài đặt các phụ thuộc Python

```bash
pip install -r requirements.txt  -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
pip install pupil-apriltags -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
```

## Hướng dẫn sử dụng

### Bắt đầu nhanh (Khuyến nghị)

Cách sử dụng đơn giản nhất là chạy công cụ tích hợp, cung cấp menu tương tác hướng dẫn bạn qua tất cả các bước:

```bash
python apriltag_tool.py
```

Công cụ này sẽ cung cấp các tùy chọn menu:
1. Tạo bảng hiệu chuẩn dạng bàn cờ
2. Hiệu chuẩn camera
3. Phát hiện AprilTag
4. Xem tài liệu trợ giúp

Chỉ cần làm theo hướng dẫn trên menu để hoàn thành toàn bộ quy trình.

### Hiệu chuẩn camera

Trước khi sử dụng phát hiện AprilTag, nên hiệu chuẩn camera để lấy tham số chính xác:

```bash
# Trước tiên tạo bảng hiệu chuẩn dạng bàn cờ
python create_chessboard.py --size 9x6 --square 100 --output chessboard.png --dpi 300

# In bảng cờ và đo kích thước thực tế từng ô, sau đó hiệu chuẩn
python camera_calibration.py --size 9x6 --square 0.025 --output config/camera/HSK_200W53_1080P.yaml
```

Giải thích tham số:

**Công cụ tạo bảng cờ (create_chessboard.py):**
- `--size`: Số lượng điểm góc trong bảng cờ, chiều rộng x chiều cao (mặc định: 9x6)
- `--square`: Kích thước một ô vuông, tính bằng pixel (mặc định: 100)
- `--output`: Đường dẫn file xuất ra (mặc định: chessboard.png)
- `--dpi`: DPI của ảnh xuất (mặc định: 300), ảnh hưởng đến kích thước in

**Chương trình hiệu chuẩn camera (camera_calibration.py):**
- `--size`: Số lượng điểm góc trong bảng cờ, chiều rộng x chiều cao (mặc định: 9x6)
- `--square`: Kích thước ô vuông bàn cờ, đơn vị mét (mặc định: 0.025)
- `--output`: Đường dẫn file xuất ra (mặc định: config/camera/HSK_200W53_1080P.yaml)
- `--camera`: ID thiết bị camera (mặc định: 0)
- `--width`: Chiều rộng ảnh thu từ camera (mặc định: 1280)
- `--height`: Chiều cao ảnh thu từ camera (mặc định: 720)
- `--samples`: Số mẫu cần thu thập để hiệu chuẩn (mặc định: 20)
- `--preview`: Xem trước kết quả sau khi hiệu chuẩn

Quy trình hiệu chuẩn:
1. Tạo và in bảng hiệu chuẩn dạng bàn cờ
2. Đo kích thước thực tế từng ô (tính bằng mét)
3. Chạy chương trình hiệu chuẩn, đặt bảng cờ trước camera, thu thập mẫu từ nhiều góc khác nhau
4. Chương trình sẽ tự động phát hiện bảng cờ và thu thập mẫu, có thể nhấn phím 's' để lưu ảnh hiện tại thủ công
5. Thu thập đủ số mẫu, chương trình sẽ tự động tính toán tham số camera và lưu vào file chỉ định

### Phát hiện AprilTag

Sau khi hiệu chuẩn xong, có thể chạy chương trình phát hiện AprilTag:
```bash
python apriltag_detector.py
```

### Sử dụng nâng cao

```bash
python apriltag_detector.py [đường_dẫn_tệp_cấu_hình] --camera camera_ID --width chiều_rộng --height chiều_cao --camera_info tệp_tham_số_camera
```

Giải thích tham số:
- `đường_dẫn_tệp_cấu_hình`: Đường dẫn tới tệp cấu hình AprilTag (mặc định: `config/vision/tags_36h11_all.json`)
- `--camera`: ID thiết bị camera (mặc định: 0)
- `--camera_info`: Đường dẫn tới tệp nội tham số camera (mặc định: `config/camera/HSK_200W53_1080P.yaml`)
- `--width`: Chiều rộng ảnh thu từ camera (mặc định: 1280)
- `--height`: Chiều cao ảnh thu từ camera (mặc định: 720)

### Điều khiển bằng phím

- `q`: Thoát chương trình

## Giải thích tệp cấu hình

Tất cả các cấu hình của hệ thống đều có thể chỉnh sửa trong tệp `config/vision/table_setup.json`:

```json
{
    "AprilTagConfig": {
        "family": "tag36h11",      // Bộ thẻ AprilTag
        "size": 0.05,              // Kích thước vật lý của thẻ (đơn vị: mét)
        "threads": 2,              // Số luồng xử lý
        "max_hamming": 0,          // Khoảng cách Hamming tối đa
        "z_up": true,              // Trục Z hướng lên trên
        "decimate": 1.0,           // Hệ số giảm mẫu ảnh
        "blur": 0.8,               // Hệ số làm mờ
        "refine_edges": 1,         // Có tinh chỉnh cạnh hay không
        "debug": 0                 // Bật chế độ debug
    },

    "Camera": {
        "device_id": 0,            // ID thiết bị camera
        "width": 1280,             // Độ phân giải chiều rộng camera
        "height": 720,             // Độ phân giải chiều cao camera
        "camera_info_path": "config/camera/HSK_200W53_1080P.yaml"  // Tệp tham số hiệu chỉnh camera
    },

    "Archive": {
        "enable": true,            // Bật lưu trữ dữ liệu
        "preview": true,           // Hiển thị cửa sổ xem trước
        "save_raw": false,         // Lưu ảnh gốc
        "save_pred": false,        // Lưu ảnh dự đoán
        "path": "./data/table_tracking"  // Đường dẫn lưu dữ liệu
    },

    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // Danh sách ID thẻ tham chiếu
        "moving_tags": [4, 5, 6],            // Danh sách ID thẻ di động
        "require_initialization": true,       // Có cần khởi tạo hay không
        "tag_positions": {                    // Vị trí thẻ định trước (nếu có)
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

Bằng cách chỉnh sửa tệp cấu hình, bạn có thể:
1. Cấu hình các tham số bộ phát hiện AprilTag
2. Thiết lập tham số camera (ID thiết bị, độ phân giải, tệp nội tham số)
3. Cấu hình các tùy chọn lưu trữ dữ liệu
4. Tùy chỉnh ID thẻ tham chiếu và thẻ di động
5. Kiểm soát việc có cần khởi tạo hay không (đặt `require_initialization` thành `false` để bỏ qua bước khởi tạo)
6. Định trước thông tin vị trí các thẻ

### Cách sử dụng

Rất đơn giản, chỉ cần một lệnh để khởi động hệ thống:

```
python table_tracking.py
```

Nếu cần sử dụng tệp cấu hình tùy chỉnh:

```
python table_tracking.py --config ĐƯỜNG_DẪN_TỚI_TỆP_CẤU_HÌNH
```

Sau khi hệ thống chạy, có thể nhấn phím 'i' bất cứ lúc nào để khởi tạo lại thủ công.

## Câu hỏi thường gặp

1. **Không tìm thấy thư viện apriltag**
   
   Đảm bảo đã cài đặt đúng thư viện apriltag và thư viện này có thể được hệ thống nhận diện.

2. **Không thể mở camera**
   
   Kiểm tra ID thiết bị camera đã đúng chưa, và camera có bị chương trình khác chiếm dụng không.

3. **Kết quả phát hiện không chính xác**
   
   Đảm bảo camera của bạn đã được hiệu chỉnh chính xác và kích thước thẻ trong tệp cấu hình là đúng.

## Giải thích cấu trúc tệp

```
apriltag_standalone/
├── apriltag.py              # Mã lõi thư viện phát hiện AprilTag
├── apriltag_detector.py     # Chương trình chính phát hiện AprilTag
├── apriltag_tool.py         # Menu khởi động công cụ tích hợp
├── camera_calibration.py    # Chương trình hiệu chỉnh camera
├── create_chessboard.py     # Công cụ tạo bàn cờ hiệu chỉnh
├── configs.py               # Xử lý tệp cấu hình
├── config/                  # Thư mục cấu hình
│   ├── camera/              # Cấu hình camera
│   │   └── HSK_200W53_1080P.yaml  # Tham số camera
│   └── vision/              # Cấu hình thị giác
│       └── tags_36h11_all.json # Cấu hình AprilTag
├── README.md                # Tài liệu hướng dẫn
└── requirements.txt         # Phụ thuộc Python
```

## Thuyết minh kỹ thuật

Dự án này là phiên bản độc lập được chuyển từ gói phát hiện AprilTag của ROS, đã loại bỏ các phụ thuộc ROS, giữ lại các chức năng cốt lõi.
Chủ yếu sử dụng các công nghệ sau:

- OpenCV: Xử lý ảnh, hiệu chỉnh camera và ước lượng tư thế
- Thư viện AprilTag C: Phát hiện thẻ
- SciPy: Chuyển đổi ma trận quay và quaternion

## Giấy phép

Dự án này sử dụng giấy phép MIT

## Giới thiệu tính năng mới

### Theo dõi nhiều thẻ và xử lý che khuất

Hệ thống hiện hỗ trợ các tính năng mới sau:

1. **Khởi tạo bằng chụp ảnh**: Sau khi khởi động, hệ thống sẽ tự động chụp ảnh để khởi tạo, ghi lại mối quan hệ vị trí các thẻ, bao gồm:
   - Vị trí các thẻ tham chiếu cố định (ID 0-3)
   - Quan hệ vị trí tương đối giữa nhiều thẻ di động (mặc định ID 4,5,6)

2. **Xử lý che khuất**: Sau khi khởi tạo, kể cả khi một số thẻ bị che khuất:
   - Nếu thẻ tham chiếu bị che khuất, hệ thống có thể dùng các thẻ tham chiếu còn lại để ước lượng vị trí thẻ bị che khuất
   - Nếu thẻ di động bị che khuất, hệ thống có thể dùng các thẻ di động còn lại để ước lượng vị trí thẻ di động bị che khuất

3. **Theo dõi nhiều thẻ**: Hỗ trợ theo dõi đồng thời nhiều thẻ di động, mặc định hỗ trợ ID 4,5,6
   - Nếu vị trí tương đối giữa các thẻ di động là cố định, chỉ cần một thẻ di động được nhìn thấy là có thể ước lượng vị trí các thẻ còn lại
   - Có thể tùy chỉnh ID thẻ di động trong tệp cấu hình

### Giải thích tệp cấu hình

Tất cả các cấu hình của hệ thống đều có thể chỉnh sửa trong tệp `config/vision/table_setup.json`:

```json
{
    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // Danh sách ID thẻ tham chiếu
        "moving_tags": [4, 5, 6],            // Danh sách ID thẻ di động
        "require_initialization": true,       // Có cần khởi tạo hay không
        "tag_positions": {                    // Vị trí thẻ định trước (nếu có)
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

Bằng cách chỉnh sửa tệp cấu hình, bạn có thể:
1. Tùy chỉnh ID thẻ tham chiếu và thẻ di động
2. Kiểm soát việc có cần khởi tạo hay không (đặt `require_initialization` thành `false` để bỏ qua bước khởi tạo)
3. Định trước thông tin vị trí các thẻ

### Cách sử dụng

1. Khởi động hệ thống với cấu hình mặc định:
   ```
   python table_tracking.py
   ```

2. Khởi động hệ thống với tệp cấu hình tùy chỉnh:
   ```
   python table_tracking.py --config ĐƯỜNG_DẪN_TỚI_TỆP_CẤU_HÌNH
   ```

3. Khởi tạo thủ công: Nhấn phím 'i' trong quá trình hệ thống đang chạy

### Yêu cầu khi chạy

Đảm bảo tất cả thẻ đều được nhìn thấy khi khởi tạo, hệ thống sẽ ghi nhận mối quan hệ vị trí giữa các thẻ. Sau khi khởi tạo, dù một phần thẻ bị che khuất, hệ thống vẫn có thể ước lượng chính xác vị trí của tất cả các thẻ.
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---