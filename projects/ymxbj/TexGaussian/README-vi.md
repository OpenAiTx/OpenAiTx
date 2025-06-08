<h1 align="center">TexGaussian: Tạo Vật Liệu PBR Chất Lượng Cao Bằng Phương Pháp Gaussian Splatting 3D Dựa Trên Octree</h1>
<p align="center"><a href="https://arxiv.org/abs/2411.19654"><img src='https://img.shields.io/badge/arXiv-Paper-red?logo=arxiv&logoColor=white' alt='arXiv'></a>
<a href='https://3d-aigc.github.io/TexGaussian/'><img src='https://img.shields.io/badge/Project_Page-Website-green?logo=googlechrome&logoColor=white' alt='Project Page'></a>
<p align="center"><img src="https://raw.githubusercontent.com/ymxbj/TexGaussian/main/assets/teaser.png" width="100%"></p>

Vật liệu Phối cảnh Vật lý (Physically Based Rendering - PBR) đóng vai trò quan trọng trong đồ họa hiện đại, cho phép hiển thị hình ảnh chân thực trên nhiều bản đồ môi trường khác nhau. Việc phát triển một thuật toán hiệu quả và tối ưu, có khả năng tự động tạo ra vật liệu PBR chất lượng cao thay vì chỉ tạo kết cấu RGB cho lưới 3D sẽ giúp đơn giản hóa đáng kể quy trình tạo nội dung 3D. Hầu hết các phương pháp hiện tại sử dụng mô hình khuếch tán 2D được huấn luyện trước để tổng hợp hình ảnh đa góc nhìn, điều này thường dẫn đến sự không nhất quán nghiêm trọng giữa kết cấu được tạo ra và lưới 3D đầu vào. Bài báo này giới thiệu TexGaussian, một phương pháp mới sử dụng Gaussian Splatting 3D căn chỉnh theo góc phần tư để tạo vật liệu PBR nhanh chóng. Cụ thể, chúng tôi đặt mỗi Gaussian 3D lên nút lá nhỏ nhất của cây bát phân (octree) được xây dựng từ lưới 3D đầu vào để hiển thị hình ảnh đa góc nhìn không chỉ cho bản đồ albedo mà còn cho bản đồ độ nhám và kim loại. Hơn nữa, mô hình của chúng tôi được huấn luyện theo phương pháp hồi quy thay vì khuếch tán khử nhiễu, cho phép tạo vật liệu PBR cho một lưới 3D chỉ trong một lần truyền tiến. Các thí nghiệm toàn diện trên các bộ dữ liệu công khai cho thấy phương pháp của chúng tôi tổng hợp vật liệu PBR đẹp mắt hơn và chạy nhanh hơn các phương pháp trước đó trong cả hai trường hợp không điều kiện và có điều kiện văn bản, đồng thời duy trì tính nhất quán tốt hơn với hình học đã cho.

## 📦 Cài đặt

```bash
conda create -n texgaussian python==3.10
pip3 install torch==2.1.0 torchvision==0.16.0 torchaudio==2.1.0 --index-url https://download.pytorch.org/whl/cu118

# Gaussian splatting đã chỉnh sửa (+ depth, alpha rendering)
git clone --recursive https://github.com/ashawkey/diff-gaussian-rasterization

pip3 install ./diff-gaussian-rasterization

pip3 install git+https://github.com/NVlabs/nvdiffrast

# Các phụ thuộc khác
pip3 install -r requirements.txt
```

## 🤖 Mô hình huấn luyện sẵn

Chúng tôi cung cấp các mô hình huấn luyện sẵn sau:

| Mô hình | Mô tả | Số tham số | Tải xuống |
| --- | --- | --- | --- |
| TexGaussian-bench | Mô hình kết cấu RGB không điều kiện huấn luyện trên ShapeNet bench | 70M | [Tải xuống](https://huggingface.co/ymxbj/TexGaussian/resolve/main/bench.safetensors?download=true) |
| TexGaussian-car | Mô hình kết cấu RGB không điều kiện huấn luyện trên ShapeNet car | 70M | [Tải xuống](https://huggingface.co/ymxbj/TexGaussian/resolve/main/car.safetensors?download=true) |
| TexGaussian-chair | Mô hình kết cấu RGB không điều kiện huấn luyện trên ShapeNet chair | 70M | [Tải xuống](https://huggingface.co/ymxbj/TexGaussian/resolve/main/chair.safetensors?download=true) |
| TexGaussian-table | Mô hình kết cấu RGB không điều kiện huấn luyện trên ShapeNet table | 70M | [Tải xuống](https://huggingface.co/ymxbj/TexGaussian/resolve/main/table.safetensors?download=true) |
| TexGaussian-PBR | Mô hình vật liệu PBR có điều kiện văn bản huấn luyện trên Objaverse | 295M | [Tải xuống](https://huggingface.co/ymxbj/TexGaussian/resolve/main/PBR_model.safetensors?download=true) |

## 💡 Suy luận

### Vật liệu PBR
Để tạo vật liệu PBR có điều kiện văn bản, chạy lệnh
```bash
bash inference_for_PBR_material.sh
```
Sau khi nướng kết cấu và vật liệu, bạn sẽ nhận được hai bản đồ, một là bản đồ albedo và một là bản đồ vật liệu PBR. Cụ thể, bản đồ vật liệu PBR có ba kênh, trong đó kênh màu xanh lá cây đại diện cho giá trị độ nhám và kênh màu xanh dương đại diện cho giá trị kim loại. Để hiển thị vật liệu PBR từ các bản đồ kết cấu và vật liệu đã tạo, chúng tôi khuyến nghị sử dụng [script render này](https://github.com/ymxbj/BlenderToolboxPBR) viết bằng bpy.

Ngoài ra, chúng tôi khuyến khích mọi người mô phỏng phong cách mô tả văn bản của bộ dữ liệu Cap3D và tự tạo prompt riêng để có kết quả tạo tốt hơn. Bộ dữ liệu Cap3D có thể được tải về tại [đây](https://huggingface.co/ymxbj/TexGaussian/resolve/main/Cap3D_automated_Objaverse_full.csv?download=true).

### Kết cấu RGB
Để tạo kết cấu RGB không điều kiện, chỉ áp dụng cho 4 loại: bench, car, chair, table, chạy lệnh
```bash
bash inference_for_RGB_texture.sh
```
Sau khi nướng kết cấu, bạn sẽ nhận được một bản đồ albedo.

## 🏋️‍♂️ Huấn luyện
Đối với Objaverse:
```bash
bash train_for_objaverse.sh
```

Đối với ShapeNet:
```bash
bash train_for_shapenet.sh
```

## 🚧 TODO
- [x] Phát hành mã huấn luyện và suy luận
- [x] Phát hành mô hình huấn luyện sẵn chỉ albedo không điều kiện trên bộ dữ liệu ShapeNet
- [x] Phát hành mô hình huấn luyện sẵn PBR có điều kiện văn bản trên bộ dữ liệu Objaverse
- [ ] Phát hành bộ dữ liệu và bộ công cụ xử lý dữ liệu

## 📚Lời cảm ơn

Công trình này được xây dựng dựa trên nhiều nghiên cứu tuyệt vời và các dự án mã nguồn mở, xin cảm ơn tất cả các tác giả đã chia sẻ!

- [gaussian-splatting](https://github.com/graphdeco-inria/gaussian-splatting) và [diff-gaussian-rasterization](https://github.com/graphdeco-inria/diff-gaussian-rasterization)
- [nvdiffrast](https://github.com/NVlabs/nvdiffrast)
- [LGM](https://github.com/3DTopia/LGM)
- [ocnn-pytorch](https://github.com/octree-nn/ocnn-pytorch)

<!-- Citation -->
## 📜 Trích dẫn

Nếu bạn thấy công trình này hữu ích, vui lòng trích dẫn bài báo của chúng tôi:

1. Phiên bản arXiv
```bibtex
@article{xiong2024texgaussian,
  title={TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
  author={Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
  journal={arXiv preprint arXiv:2411.19654},
  year={2024}
}
```

2. Phiên bản CVPR
```bibtex
@InProceedings{Xiong_2025_CVPR,
    author    = {Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
    title     = {TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
    booktitle = {Proceedings of the Computer Vision and Pattern Recognition Conference (CVPR)},
    month     = {June},
    year      = {2025},
    pages     = {551-561}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---