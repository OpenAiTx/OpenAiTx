# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~Kế hoạch sau này sẽ chuyển sang ente-io/ente, vì tôi cần s3 để lưu trữ ảnh~~
> 
> ente vẫn còn quá ít chức năng
> 
> Đã chuyển sang sử dụng juicedata/juicefs để mount s3

## Giới thiệu dự án

Dự án này là giải pháp tăng cường AI cho hệ thống quản lý ảnh [Immich](https://github.com/immich-app/immich). Chủ yếu mở rộng chức năng gốc của Immich thông qua các thành phần sau:

- **inference-gateway**: Dịch vụ gateway viết bằng Go, chịu trách nhiệm chuyển tiếp thông minh các yêu cầu học máy của Immich
- **mt-photos-ai**: Dịch vụ AI dựa trên Python và FastAPI, tích hợp RapidOCR và mô hình cn-clip
- Mở rộng chức năng của Immich, bao gồm nhận dạng văn bản OCR để tìm kiếm và xử lý lại dữ liệu AI cho từng phương tiện, trộn điểm xếp hạng bằng vector toàn văn OCR và vector CLIP
- Thêm phân tích từ tiếng Trung zhparser cho PostgreSQL

## Chức năng chính

### 1. Nhận diện văn bản OCR và tìm kiếm

- Sử dụng RapidOCR để nhận diện văn bản trong ảnh
- Hỗ trợ nhận diện văn bản pha trộn tiếng Trung và tiếng Anh
- Hiện thực tính năng tìm kiếm dựa trên nội dung chữ trong ảnh

### 2. Xử lý vector hình ảnh CLIP

- Sử dụng mô hình cn-clip để tăng độ chính xác ghép nối ảnh - văn bản tiếng Trung
- Hỗ trợ tìm kiếm theo ngữ nghĩa, nâng cao độ chính xác tìm kiếm

### 3. Xử lý lại dữ liệu AI cho từng phương tiện

- Hỗ trợ tạo lại dữ liệu OCR cho từng ảnh/video riêng lẻ
- Hỗ trợ tạo lại vector CLIP cho từng ảnh/video riêng lẻ
- Cung cấp khả năng làm mới thủ công khi kết quả nhận diện không chính xác

## Kiến trúc hệ thống

```
┌─────────────┐      ┌──────────────────┐      ┌───────────────┐
│             │      │                  │      │               │
│   Immich    │─────▶│ inference-gateway│─────▶│  Immich ML    │
│   Server    │      │    (Go网关)      │      │   Server      │
│             │      │                  │      │               │
└─────────────┘      └──────────────────┘      └───────────────┘
                              │
                              │ OCR/CLIP请求
                              ▼
                     ┌──────────────────┐
                     │                  │
                     │   mt-photos-ai   │
                     │  (Python服务)    │
                     │                  │
                     └──────────────────┘
```
## 组件详解

### inference-gateway

Dịch vụ gateway viết bằng Go, với các nhiệm vụ chính:
- Nhận các yêu cầu học máy từ Immich
- Chuyển tiếp các yêu cầu OCR và CLIP đến dịch vụ mt-photos-ai dựa trên loại yêu cầu
- Chuyển tiếp các yêu cầu học máy khác (như nhận diện khuôn mặt) đến dịch vụ học máy gốc của Immich
- Xử lý xác thực và chuyển đổi định dạng dữ liệu

### mt-photos-ai

Dịch vụ AI viết bằng Python và FastAPI, cung cấp:
- API nhận diện chữ OCR (dựa trên RapidOCR)
- API xử lý vector CLIP (dựa trên cn-clip)
- Hỗ trợ tăng tốc bằng GPU

## 部署说明

### 环境要求

- Docker và Docker Compose
- NVIDIA GPU (tùy chọn, nhưng khuyến nghị để tăng tốc xử lý)
- Đủ dung lượng lưu trữ

### 配置说明

1. **Cấu hình inference-gateway**

Các biến môi trường chính:

```
IMMICH_API=http://localhost:3003  # Immich API地址
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai服务地址
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API密钥
PORT=8080  # 网关监听端口
```
2. **Cấu hình mt-photos-ai**

Các biến môi trường chính:

```
CLIP_MODEL=ViT-B-16  # CLIP模型名称
CLIP_DOWNLOAD_ROOT=./models/clip  # 模型下载路径
DEVICE=cuda  # 或 cpu，推理设备
HTTP_PORT=8060  # 服务监听端口
```
### Các bước triển khai

1. Sao chép kho lưu trữ:

```bash
git clone https://github.com/你的用户名/immich-all-in-one.git
cd immich-all-in-one
```
2. Khởi động dịch vụ：

```bash
docker-compose up -d
```
## Hướng dẫn sử dụng

1. **Cấu hình Immich sử dụng dịch vụ ML tùy chỉnh**

Trong tệp cấu hình của Immich, hãy trỏ địa chỉ dịch vụ máy học đến inference-gateway:

```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```
2. **Sử dụng tìm kiếm OCR**

- Sử dụng tiền tố `ocr:` trong thanh tìm kiếm Immich để tìm kiếm OCR
- Ví dụ: `ocr:hoá đơn` sẽ tìm kiếm các ảnh có chứa từ "hoá đơn" trong hình

3. **Xử lý lại dữ liệu AI cho từng phương tiện**

- Tại trang chi tiết ảnh, nhấn vào tuỳ chọn trong menu
- Chọn "Tạo lại dữ liệu OCR" hoặc "Tạo lại vector CLIP"
- Hệ thống sẽ xử lý lại dữ liệu AI cho ảnh đó

## Hướng dẫn phát triển

### inference-gateway (Go)

Biên dịch và chạy:

```bash
cd inference-gateway
go build
./inference-gateway
```
### mt-photos-ai (Python)

Thiết lập môi trường phát triển:

```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```
## Giấy phép

Dự án này được phát hành mã nguồn mở dựa trên giấy phép MIT.

## Lời cảm ơn

- [Immich](https://github.com/immich-app/immich) - Giải pháp sao lưu ảnh và video tự lưu trữ mã nguồn mở
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - Thư viện OCR đa nền tảng dựa trên PaddleOCR
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - Mô hình tiền huấn luyện học so sánh đa mô hình cho tiếng Trung



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---