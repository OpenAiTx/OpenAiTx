# 3D Gaussian Splatting cho Kết Xuất Trường Bức Xạ Thời Gian Thực - Triển Khai C++ và CUDA

[![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/TbxJST2BbC)  
[![Website](https://img.shields.io/badge/Website-mrnerf.com-blue)](https://mrnerf.com)  
[![Papers](https://img.shields.io/badge/Papers-Awesome%203DGS-orange)](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)

Một triển khai C++ và CUDA hiệu suất cao của 3D Gaussian Splatting, xây dựng dựa trên backend rasterization [gsplat](https://github.com/nerfstudio-project/gsplat).

## Tin tức
- **[2025-06-10]**: Đã sửa một số lỗi. Chúng tôi đang thu hẹp khoảng cách với các chỉ số của gsplat. Tuy nhiên, vẫn còn một số sai lệch nhỏ.
- **[2025-06-04]**: Thêm chiến lược MCMC với tùy chọn dòng lệnh `--max-cap` để kiểm soát số lượng Gaussian tối đa.
- **[2025-06-03]**: Chuyển sang backend Gsplat và cập nhật giấy phép.
- **[2024-05-27]**: Cập nhật lên LibTorch 2.7.0 để tương thích và hiệu năng tốt hơn. Các thay đổi lớn trong quản lý trạng thái bộ tối ưu đã được giải quyết.
- **[2024-05-26]**: Mục tiêu hiện tại của repo này là hướng tới giấy phép cho phép. Công việc chính đã được thực hiện để thay thế rasterizer bằng triển khai gsplat.

## Chỉ số
Hiện tại triển khai chưa đạt kết quả tương đương với gsplat-mcmc, nhưng đang trong quá trình hoàn thiện.  
Chỉ còn là vấn đề thời gian để sửa lỗi. Rất hoan nghênh sự giúp đỡ :) Các chỉ số cho chiến lược mcmc như sau:

| Scene    | Iteration | PSNR          | SSIM         | LPIPS        | Time per Image | Num Gaussians |
| -------- | --------- | ------------- | ------------ | ------------ | -------------- | ------------- |
| garden   | 30000     | 27.112114     | 0.854833     | 0.157624     | 0.304765       | 1000000       |
| bicycle  | 30000     | 25.047745     | 0.767729     | 0.254825     | 0.293618       | 1000000       |
| stump    | 30000     | 26.554749     | 0.784203     | 0.263013     | 0.296536       | 1000000       |
| bonsai   | 30000     | 32.534199     | 0.948675     | 0.246924     | 0.436188       | 1000000       |
| counter  | 30000     | 29.187017     | 0.915823     | 0.242159     | 0.441259       | 1000000       |
| kitchen  | 30000     | 31.680832     | 0.933897     | 0.154965     | 0.449078       | 1000000       |
| room     | 30000     | 32.211632     | 0.930754     | 0.273719     | 0.413519       | 1000000       |
| **mean** | **30000** | **29.189755** | **0.876559** | **0.227604** | **0.376423**   | **1000000**   |

## Cộng đồng & Hỗ trợ

Tham gia cộng đồng ngày càng phát triển của chúng tôi để thảo luận, hỗ trợ và cập nhật:  
- 💬 **[Cộng đồng Discord](https://discord.gg/TbxJST2BbC)** - Nhận trợ giúp, chia sẻ kết quả và thảo luận phát triển  
- 🌐 **[mrnerf.com](https://mrnerf.com)** - Truy cập trang web của chúng tôi để có thêm tài nguyên  
- 📚 **[Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)** - Danh sách bài báo và tài nguyên toàn diện  
- 🐦 **[@janusch_patas](https://twitter.com/janusch_patas)** - Theo dõi để cập nhật mới nhất

## Hướng dẫn xây dựng và chạy

### Yêu cầu phần mềm
1. **Linux** (đã thử nghiệm với Ubuntu 22.04) - Hiện chưa hỗ trợ Windows  
2. **CMake** 3.24 trở lên  
3. **CUDA** 11.8 trở lên (có thể hoạt động với phiên bản thấp hơn với cấu hình thủ công)  
4. **Python** có các header phát triển  
5. **LibTorch 2.7.0** - Hướng dẫn cài đặt bên dưới  
6. Các phụ thuộc khác được CMake xử lý tự động

### Yêu cầu phần cứng
1. **GPU NVIDIA** hỗ trợ CUDA  
    - Đã thử nghiệm thành công: RTX 4090, RTX A5000, RTX 3090Ti, A100  
    - Vấn đề đã biết với RTX 3080Ti trên bộ dữ liệu lớn (xem #21)  
2. Khả năng tính toán tối thiểu: 8.0

> Nếu bạn chạy thành công trên phần cứng khác, vui lòng chia sẻ kinh nghiệm trong phần Thảo luận!

### Hướng dẫn xây dựng

```bash
# Sao chép kho chứa kèm submodules
git clone --recursive https://github.com/MrNeRF/gaussian-splatting-cuda
cd gaussian-splatting-cuda

# Tải và cài đặt LibTorch
wget https://raw.githubusercontent.com/MrNeRF/gaussian-splatting-cuda/master/libtorch-cxx11-abi-shared-with-deps-2.7.0%2Bcu118.zip  
unzip libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip -d external/
rm libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip

# Xây dựng dự án
cmake -B build -DCMAKE_BUILD_TYPE=Release
cmake --build build -- -j
```

## LibTorch 2.7.0

Dự án này sử dụng **LibTorch 2.7.0** để có hiệu năng và tương thích tối ưu:

- **Hiệu năng cải tiến**: Tối ưu hóa và quản lý bộ nhớ tốt hơn  
- **Ổn định API**: Phiên bản ổn định mới nhất của PyTorch C++ API  
- **Tương thích CUDA**: Tích hợp tốt hơn với CUDA 11.8+  
- **Sửa lỗi**: Giải quyết các vấn đề quản lý trạng thái bộ tối ưu

### Nâng cấp từ các phiên bản trước
1. Tải phiên bản LibTorch mới theo hướng dẫn xây dựng  
2. Xoá thư mục build cũ: `rm -rf build/`  
3. Xây dựng lại dự án

## Bộ dữ liệu

Tải bộ dữ liệu từ kho gốc:  
[Bộ dữ liệu Tanks & Trains](https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/datasets/input/tandt_db.zip)

Giải nén vào thư mục `data` trong thư mục gốc dự án.

## Tùy chọn dòng lệnh

### Tùy chọn cốt lõi

- **`-h, --help`**  
  Hiển thị menu trợ giúp

- **`-d, --data-path [PATH]`**  
  Đường dẫn đến dữ liệu huấn luyện (bắt buộc)

- **`-o, --output-path [PATH]`**  
  Đường dẫn lưu mô hình đã huấn luyện (mặc định: `./output`)

- **`-i, --iter [NUM]`**  
  Số vòng lặp huấn luyện (mặc định: 30000)  
    - Bài báo gợi ý 30k, nhưng 6k-7k thường cho kết quả sơ bộ tốt  
    - Kết quả được lưu mỗi 7k vòng lặp và khi hoàn thành

- **`-f, --force`**  
  Ghi đè thư mục output nếu đã tồn tại

- **`-r, --resolution [NUM]`**  
  Đặt độ phân giải cho ảnh huấn luyện

### Tùy chọn riêng cho MCMC

- **`--max-cap [NUM]`**  
  Số lượng Gaussian tối đa cho chiến lược MCMC (mặc định: 1000000)  
    - Kiểm soát giới hạn trên của Gaussian splats trong huấn luyện  
    - Hữu ích khi giới hạn bộ nhớ

### Ví dụ sử dụng

Huấn luyện cơ bản:  
```bash
./build/gaussian_splatting_cuda -d /path/to/data -o /path/to/output -i 10000
```

Huấn luyện MCMC với giới hạn Gaussian:  
```bash
./build/gaussian_splatting_cuda -d /path/to/data -o /path/to/output -i 10000 --max-cap 500000
```

## Hướng dẫn đóng góp

Chúng tôi hoan nghênh các đóng góp! Đây là cách bắt đầu:

1. **Bắt đầu**:  
    - Xem các issue được gắn nhãn **good first issues** cho các nhiệm vụ dễ dàng  
    - Với ý tưởng mới, mở thảo luận hoặc tham gia [Discord](https://discord.gg/TbxJST2BbC)

2. **Trước khi gửi PR**:  
    - Áp dụng `clang-format` để thống nhất phong cách code  
    - Sử dụng pre-commit hook: `cp tools/pre-commit .git/hooks/`  
    - Thảo luận về các phụ thuộc mới trong issue trước - chúng tôi muốn giảm thiểu phụ thuộc

## Lời cảm ơn

Triển khai này xây dựng dựa trên một số dự án quan trọng:

- **[gsplat](https://github.com/nerfstudio-project/gsplat)**: Chúng tôi sử dụng backend rasterization CUDA được tối ưu hóa cao của gsplat, mang lại cải tiến hiệu năng đáng kể và quản lý bộ nhớ tốt hơn.

- **3D Gaussian Splatting gốc**: Dựa trên công trình đột phá của Kerbl và cộng sự.

## Trích dẫn

Nếu bạn sử dụng phần mềm này trong nghiên cứu, vui lòng trích dẫn công trình gốc:

```bibtex
@article{kerbl3Dgaussians,
  author    = {Kerbl, Bernhard and Kopanas, Georgios and Leimkühler, Thomas and Drettakis, George},
  title     = {3D Gaussian Splatting for Real-Time Radiance Field Rendering},
  journal   = {ACM Transactions on Graphics},
  number    = {4},
  volume    = {42},
  month     = {July},
  year      = {2023},
  url       = {https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/}
}
```

## Giấy phép

Xem file LICENSE để biết chi tiết.

---

**Kết nối với chúng tôi:**  
- 🌐 Website: [mrnerf.com](https://mrnerf.com)  
- 📚 Bài báo: [Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)  
- 💬 Discord: [Tham gia cộng đồng](https://discord.gg/TbxJST2BbC)  
- 🐦 Twitter: Theo dõi [@janusch_patas](https://twitter.com/janusch_patas) để cập nhật phát triển

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---