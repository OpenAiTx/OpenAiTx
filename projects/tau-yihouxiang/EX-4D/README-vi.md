# EX-4D: Tổng hợp Video 4D Góc Nhìn Cực Đại thông qua Lưới Kín Nước Độ Sâu

<div align="center">

<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/Logo.png" alt="EX-4D Logo" width="250">

[📄 Bài báo](https://arxiv.org/abs/2506.05554)  |  [🎥 Trang chủ](https://tau-yihouxiang.github.io/projects/EX-4D/EX-4D.html)  |  [💻 Mã nguồn](https://github.com/tau-yihouxiang/EX-4D)

</div>



## 🌟 Điểm Nổi Bật

- **🎯 Tổng hợp Góc Nhìn Cực Đại**: Tạo video 4D chất lượng cao với chuyển động camera từ -90° đến 90°
- **🔧 Lưới Kín Nước Độ Sâu**: Đại diện hình học mới mô hình hóa cả vùng nhìn thấy và vùng bị che khuất
- **⚡ Kiến trúc Nhẹ**: Chỉ sử dụng 1% tham số có thể huấn luyện (140M) so với backbone khuếch tán video 14B
- **🎭 Không Cần Huấn Luyện Đa Góc Nhìn**: Chiến lược masking sáng tạo loại bỏ nhu cầu về tập dữ liệu đa góc nhìn tốn kém
- **🏆 Hiệu Năng Hàng Đầu**: Vượt trội hơn các phương pháp hiện tại, đặc biệt ở các góc camera cực đại

## 🎬 Kết Quả Demo

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/teaser.png" alt="EX-4D Demo Results" width="800">
</div>

*EX-4D chuyển đổi video đơn mắt thành trải nghiệm 4D có thể điều khiển camera, đảm bảo tính nhất quán vật lý ở các góc nhìn cực đại.*

## 🏗️ Tổng Quan Khung Hệ Thống

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/overview.png" alt="EX-4D Architecture">
</div>

Khung hệ thống của chúng tôi bao gồm ba thành phần chính:

1. **🔺 Xây dựng Lưới Kín Nước Độ Sâu**: Tạo ra tiên nghiệm hình học mạnh mẽ, mô hình hóa rõ ràng cả vùng nhìn thấy và bị che khuất
2. **🎭 Chiến lược Masking Mô Phỏng**: Tạo dữ liệu huấn luyện hiệu quả từ video đơn mắt mà không cần tập dữ liệu đa góc nhìn
3. **⚙️ Bộ chuyển đổi LoRA Nhẹ**: Tích hợp thông tin hình học một cách hiệu quả với các mô hình khuếch tán video đã được huấn luyện trước

## 🚀 Bắt Đầu Nhanh

### Cài đặt

```bash
# Sao chép kho mã nguồn
git clone https://github.com/tau-yihouxiang/EX-4D.git
cd EX-4D

# Tạo môi trường conda
conda create -n ex4d python=3.10
conda activate ex4d
# Cài đặt PyTorch (khuyến nghị phiên bản 2.x)
pip install torch==2.4.1 torchvision==0.19.1 torchaudio==2.4.1 --index-url https://download.pytorch.org/whl/cu124
# Cài đặt Nvdiffrast
pip install git+https://github.com/NVlabs/nvdiffrast.git
# Cài đặt các phụ thuộc và diffsynth
pip install -e .
# Cài đặt depthcrafter để ước lượng độ sâu. (Làm theo hướng dẫn cài đặt DepthCrafter để chuẩn bị checkpoint.)
git clone https://github.com/Tencent/DepthCrafter.git
```

### Tải Mô Hình Huấn Luyện Sẵn
```bash
huggingface-cli download Wan-AI/Wan2.1-I2V-14B-480P --local-dir ./models/Wan-AI
huggingface-cli download yihouxiang/EX-4D --local-dir ./models/EX-4D
```

### Ví dụ Sử Dụng
#### 1. Tái tạo DW-Mesh
```bash
# --cam 180 (30 / 60 / 90 / zoom_in / zoom_out )
python recon.py --input_video examples/flower/input.mp4 --cam 180 --output_dir outputs/flower --save_mesh
```
#### 2. Sinh Video EX-4D (yêu cầu 48GB VRAM)
```bash
python generate.py --color_video outputs/flower/color_180.mp4 --mask_video outputs/flower/mask_180.mp4 --output_video outputs/flower/output.mp4
```

<table>
<tr>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/input.gif" width="100%">
<br><b>Video Đầu Vào</b>
</td>
<td align="center">
<div style="font-size: 2em; color: #4A90E2; padding: 0 0px;">
  ➜
</div>
</td>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/output.gif" width="100%">
<br><b>Video Đầu Ra</b>
</td>
</tr> 
</table>

<!-- ## 📊 Performance

### Quantitative Results
| Phương pháp | FID (Cực đại) ↓ | FVD (Cực đại) ↓ | Điểm VBench ↑ |
|-------------|------------------|------------------|---------------|
| ReCamMaster | 64.68 | 943.45 | 0.434 |
| TrajectoryCrafter | 65.33 | 893.80 | 0.447 |
| TrajectoryAttention | 62.49 | 912.14 | 0.389 |
| **EX-4D (Của chúng tôi)** | **55.42** | **823.61** | **0.450** | -->

### Kết quả khảo sát người dùng

- **70.7%** người tham gia ưu tiên EX-4D so với các phương pháp nền tảng
- Hiệu suất vượt trội về tính nhất quán vật lý và chất lượng góc nhìn cực đại
- Cải thiện đáng kể khi các góc máy trở nên cực đoan hơn


## 🎯 Ứng dụng

- **🎮 Game**: Tạo các cảnh điện ảnh 3D sống động từ video 2D
- **🎬 Sản xuất phim**: Tạo ra các góc máy mới cho hậu kỳ
- **🥽 VR/AR**: Tạo trải nghiệm video tự do góc nhìn
- **📱 Mạng xã hội**: Tạo chuyển động camera động cho nội dung sáng tạo
- **🏢 Kiến trúc**: Hình dung không gian từ nhiều góc nhìn khác nhau

<!-- ## 📈 Đánh giá chuẩn -->

<!-- ### Đánh giá dải góc nhìn

| Dải | Nhỏ (0°→30°) | Lớn (0°→60°) | Cực đại (0°→90°) | Toàn phần (-90°→90°) |
|------|---------------|---------------|-------------------|----------------------|
| Điểm FID | 44.19 | 50.30 | 55.42 | - |
| Khoảng cách hiệu suất | +9.1% tốt hơn | +8.9% tốt hơn | +11.3% tốt hơn | +15.5% tốt hơn | -->

<!-- *Khoảng cách hiệu suất so với phương pháp đứng thứ hai trong từng hạng mục.* -->

## ⚠️ Hạn chế

- **Phụ thuộc vào độ sâu**: Hiệu suất phụ thuộc vào chất lượng ước lượng độ sâu đơn ảnh
- **Chi phí tính toán**: Yêu cầu tính toán lớn cho video độ phân giải cao
- **Bề mặt phản chiếu**: Gặp khó khăn với vật liệu phản chiếu hoặc trong suốt

## 🔮 Hướng phát triển tương lai
- [ ] Tối ưu hóa suy luận thời gian thực (3DGS / 4DGS)
- [ ] Hỗ trợ độ phân giải cao hơn (1K, 2K)
- [ ] Kỹ thuật tinh chỉnh lưới thần kinh

## 🙏 Lời cảm ơn

Chúng tôi xin cảm ơn dự án [DiffSynth-Studio v1.1.1](https://github.com/modelscope/DiffSynth-Studio/tree/v1.1.1) đã cung cấp nền tảng framework khuếch tán.

## 📚 Trích dẫn

Nếu bạn thấy công trình của chúng tôi hữu ích, xin hãy trích dẫn:

```bibtex
@misc{hu2025ex4dextremeviewpoint4d,
      title={EX-4D: EXtreme Viewpoint 4D Video Synthesis via Depth Watertight Mesh}, 
      author={Tao Hu and Haoyang Peng and Xiao Liu and Yuewen Ma},
      year={2025},
      eprint={2506.05554},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.05554}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---