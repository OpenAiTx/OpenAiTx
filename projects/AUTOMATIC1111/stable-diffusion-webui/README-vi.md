# Stable Diffusion web UI
Một giao diện web cho Stable Diffusion, được triển khai bằng thư viện Gradio.

![](screenshot.png)

## Tính năng
[Trình diễn chi tiết các tính năng kèm hình ảnh](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features):
- Chế độ txt2img và img2img gốc
- Script cài đặt và chạy chỉ với một cú nhấp chuột (nhưng bạn vẫn phải cài đặt python và git)
- Outpainting (mở rộng hình ảnh)
- Inpainting (vẽ lại phần hình ảnh)
- Color Sketch (phác thảo màu)
- Prompt Matrix (ma trận prompt)
- Stable Diffusion Upscale (phóng to hình ảnh)
- Attention, chỉ định phần văn bản mà mô hình nên chú ý hơn
    - a man in a `((tuxedo))` - chú ý nhiều hơn đến tuxedo
    - a man in a `(tuxedo:1.21)` - cú pháp thay thế
    - chọn văn bản và nhấn `Ctrl+Up` hoặc `Ctrl+Down` (hoặc `Command+Up` hoặc `Command+Down` nếu bạn dùng MacOS) để tự động điều chỉnh attention cho văn bản được chọn (mã do người dùng ẩn danh đóng góp)
- Loopback, chạy xử lý img2img nhiều lần liên tiếp
- X/Y/Z plot, vẽ biểu đồ ba chiều các hình ảnh với các tham số khác nhau
- Textual Inversion
    - có bao nhiêu embedding tùy ý và đặt tên bất kỳ
    - sử dụng nhiều embedding với số lượng vector trên mỗi token khác nhau
    - hoạt động với số thực dấu phẩy động nửa chính xác (half precision)
    - huấn luyện embedding trên 8GB (có báo cáo hoạt động trên 6GB)
- Tab Extras với:
    - GFPGAN, mạng nơ-ron sửa khuôn mặt
    - CodeFormer, công cụ phục hồi khuôn mặt thay thế cho GFPGAN
    - RealESRGAN, mạng nơ-ron phóng to hình ảnh
    - ESRGAN, mạng nơ-ron phóng to hình ảnh với nhiều mô hình bên thứ ba
    - SwinIR và Swin2SR ([xem tại đây](https://github.com/AUTOMATIC1111/stable-diffusion-webui/pull/2092)), mạng nơ-ron phóng to hình ảnh
    - LDSR, phóng to độ phân giải siêu khuếch tán tiềm ẩn
- Tuỳ chọn tỉ lệ khung hình khi thay đổi kích thước
- Lựa chọn phương pháp lấy mẫu (sampling)
    - Điều chỉnh giá trị eta của sampler (hệ số nhiễu)
    - Tuỳ chọn cài đặt nhiễu nâng cao hơn
- Có thể dừng xử lý bất cứ lúc nào
- Hỗ trợ card đồ họa 4GB (có báo cáo hoạt động trên 2GB)
- Đúng seed cho các batch
- Kiểm tra độ dài token prompt trực tiếp
- Thông số tạo ảnh
     - các thông số dùng để tạo hình ảnh sẽ được lưu cùng hình ảnh đó
     - trong chunk PNG đối với PNG, trong EXIF đối với JPEG
     - có thể kéo hình ảnh vào tab PNG info để khôi phục tham số tạo và tự động sao chép vào UI
     - có thể tắt trong cài đặt
     - kéo thả hình ảnh/văn bản-tham số vào hộp prompt
- Nút Đọc Tham Số Tạo, tải tham số trong promptbox vào UI
- Trang Cài đặt
- Chạy mã python bất kỳ từ UI (phải chạy với `--allow-code` để bật tính năng này)
- Gợi ý khi di chuột cho hầu hết các thành phần UI
- Có thể thay đổi giá trị mặc định/mix/max/step cho các thành phần UI qua text config
- Hỗ trợ Tiling, checkbox tạo hình ảnh có thể lát như texture
- Thanh tiến trình và xem trước hình ảnh đang tạo trực tiếp
    - Có thể dùng mạng nơ-ron riêng để tạo xem trước mà gần như không tốn VRAM hay tài nguyên tính toán
- Negative prompt, trường văn bản bổ sung cho phép liệt kê những gì bạn không muốn xuất hiện trong hình ảnh tạo ra
- Styles, lưu một phần prompt và dễ dàng áp dụng lại qua menu thả xuống
- Variations, tạo cùng hình ảnh nhưng có những khác biệt nhỏ
- Seed resizing, tạo cùng hình ảnh nhưng với độ phân giải hơi khác nhau
- CLIP interrogator, nút thử đoán prompt từ một hình ảnh
- Prompt Editing, thay đổi prompt giữa quá trình tạo, ví dụ bắt đầu làm dưa hấu rồi chuyển sang anime girl giữa chừng
- Xử lý hàng loạt, xử lý nhóm tệp bằng img2img
- Img2img Alternative, phương pháp đảo ngược Euler kiểm soát cross attention
- Highres Fix, tuỳ chọn tiện lợi để tạo ảnh độ phân giải cao chỉ với một cú nhấp mà không bị méo như thường lệ
- Tải lại checkpoint ngay trong quá trình chạy
- Checkpoint Merger, tab cho phép gộp tối đa 3 checkpoint thành một
- [Script tuỳ chỉnh](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Custom-Scripts) với nhiều extension từ cộng đồng
- [Composable-Diffusion](https://energy-based-model.github.io/Compositional-Visual-Generation-with-Composable-Diffusion-Models/), sử dụng nhiều prompt cùng lúc
     - tách prompt bằng `AND` viết hoa
     - hỗ trợ trọng số cho prompt: `a cat :1.2 AND a dog AND a penguin :2.2`
- Không giới hạn số token cho prompt (Stable Diffusion gốc chỉ cho 75 token)
- Tích hợp DeepDanbooru, tạo tag kiểu danbooru cho prompt anime
- [xformers](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Xformers), tăng tốc lớn cho một số card: (thêm `--xformers` vào tham số dòng lệnh)
- qua extension: [History tab](https://github.com/yfszzx/stable-diffusion-webui-images-browser): xem, điều hướng và xoá ảnh ngay trên UI
- Tuỳ chọn tạo ảnh liên tục (generate forever)
- Tab Training
     - các tuỳ chọn hypernetworks và embedding
     - Xử lý trước ảnh: crop, lật, gắn thẻ tự động bằng BLIP hoặc deepdanbooru (cho anime)
- Clip skip
- Hypernetworks
- Loras (giống Hypernetworks nhưng đẹp hơn)
- UI riêng biệt để bạn chọn, có xem trước, embedding, hypernetworks hoặc lora cần thêm vào prompt
- Có thể chọn tải VAE khác từ màn hình cài đặt
- Ước tính thời gian hoàn thành trên thanh tiến trình
- API
- Hỗ trợ [mô hình inpainting chuyên dụng](https://github.com/runwayml/stable-diffusion#inpainting-with-stable-diffusion) của RunwayML
- qua extension: [Aesthetic Gradients](https://github.com/AUTOMATIC1111/stable-diffusion-webui-aesthetic-gradients), tạo hình ảnh với thẩm mỹ riêng bằng embed ảnh clip (cài đặt từ [https://github.com/vicgalle/stable-diffusion-aesthetic-gradients](https://github.com/vicgalle/stable-diffusion-aesthetic-gradients))
- Hỗ trợ [Stable Diffusion 2.0](https://github.com/Stability-AI/stablediffusion) - xem [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#stable-diffusion-20) để biết hướng dẫn
- Hỗ trợ [Alt-Diffusion](https://arxiv.org/abs/2211.06679) - xem [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#alt-diffusion) để biết hướng dẫn
- Không còn ký tự xấu!
- Hỗ trợ tải checkpoint định dạng safetensors
- Nới lỏng giới hạn độ phân giải: chiều hình ảnh tạo ra chỉ cần chia hết cho 8 thay vì 64
- Đã có license!
- Sắp xếp lại thành phần UI từ màn hình cài đặt
- Hỗ trợ [Segmind Stable Diffusion](https://huggingface.co/segmind/SSD-1B)

## Cài đặt và Chạy
Đảm bảo đã đáp ứng đủ các [phụ thuộc](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Dependencies) và làm theo hướng dẫn dành cho:
- [NVidia](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs) (khuyên dùng)
- GPU [AMD](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-AMD-GPUs)
- [Intel CPU, Intel GPU (tích hợp và rời)](https://github.com/openvinotoolkit/stable-diffusion-webui/wiki/Installation-on-Intel-Silicon) (wiki bên ngoài)
- [Ascend NPU](https://github.com/wangshuai09/stable-diffusion-webui/wiki/Install-and-run-on-Ascend-NPUs) (wiki bên ngoài)

Hoặc dùng các dịch vụ trực tuyến (như Google Colab):

- [Danh sách dịch vụ trực tuyến](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Online-Services)

### Cài đặt trên Windows 10/11 với NVidia-GPU bằng gói release
1. Tải `sd.webui.zip` từ [v1.0.0-pre](https://github.com/AUTOMATIC1111/stable-diffusion-webui/releases/tag/v1.0.0-pre) và giải nén nội dung.
2. Chạy `update.bat`.
3. Chạy `run.bat`.
> Để biết chi tiết, xem [Install-and-Run-on-NVidia-GPUs](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs)

### Cài đặt tự động trên Windows
1. Cài [Python 3.10.6](https://www.python.org/downloads/release/python-3106/) (Phiên bản Python mới hơn không hỗ trợ torch), chọn "Add Python to PATH".
2. Cài [git](https://git-scm.com/download/win).
3. Tải kho stable-diffusion-webui, ví dụ bằng cách chạy `git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui.git`.
4. Chạy `webui-user.bat` từ Windows Explorer với quyền người dùng thông thường (không phải admin).

### Cài đặt tự động trên Linux
1. Cài các phụ thuộc:
```bash
# Dựa trên Debian:
sudo apt install wget git python3 python3-venv libgl1 libglib2.0-0
# Dựa trên Red Hat:
sudo dnf install wget git python3 gperftools-libs libglvnd-glx
# Dựa trên openSUSE:
sudo zypper install wget git python3 libtcmalloc4 libglvnd
# Dựa trên Arch:
sudo pacman -S wget git python3
```
Nếu hệ thống của bạn rất mới, cần cài python3.11 hoặc python3.10:
```bash
# Ubuntu 24.04
sudo add-apt-repository ppa:deadsnakes/ppa
sudo apt update
sudo apt install python3.11

# Manjaro/Arch
sudo pacman -S yay
yay -S python311 # không nhầm lẫn với python3.11 package

# Chỉ cho 3.11
# Sau đó thiết lập biến môi trường trong script launch
export python_cmd="python3.11"
# hoặc trong webui-user.sh
python_cmd="python3.11"
```
2. Điều hướng tới thư mục bạn muốn cài webui và thực thi lệnh sau:
```bash
wget -q https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/webui.sh
```
Hoặc chỉ cần clone repo ở bất kỳ đâu:
```bash
git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui
```

3. Chạy `webui.sh`.
4. Kiểm tra `webui-user.sh` để biết thêm tuỳ chọn.
### Cài đặt trên Apple Silicon

Tìm hướng dẫn [tại đây](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Installation-on-Apple-Silicon).

## Đóng góp
Cách thêm mã vào repo này: [Contributing](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Contributing)

## Tài liệu

Tài liệu đã được chuyển từ README này sang [wiki của dự án](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki).

Để Google và các công cụ tìm kiếm khác có thể thu thập wiki, đây là liên kết (không dành cho người dùng bình thường) [crawlable wiki](https://github-wiki-see.page/m/AUTOMATIC1111/stable-diffusion-webui/wiki).

## Ghi nhận
Giấy phép cho mã mượn có thể được tìm thấy trong màn hình `Settings -> Licenses`, và cả trong file `html/licenses.html`.

- Stable Diffusion - https://github.com/Stability-AI/stablediffusion, https://github.com/CompVis/taming-transformers, https://github.com/mcmonkey4eva/sd3-ref
- k-diffusion - https://github.com/crowsonkb/k-diffusion.git
- Spandrel - https://github.com/chaiNNer-org/spandrel triển khai
  - GFPGAN - https://github.com/TencentARC/GFPGAN.git
  - CodeFormer - https://github.com/sczhou/CodeFormer
  - ESRGAN - https://github.com/xinntao/ESRGAN
  - SwinIR - https://github.com/JingyunLiang/SwinIR
  - Swin2SR - https://github.com/mv-lab/swin2sr
- LDSR - https://github.com/Hafiidz/latent-diffusion
- MiDaS - https://github.com/isl-org/MiDaS
- Ý tưởng tối ưu hóa - https://github.com/basujindal/stable-diffusion
- Tối ưu hóa lớp Cross Attention - Doggettx - https://github.com/Doggettx/stable-diffusion, ý tưởng gốc cho chỉnh sửa prompt.
- Tối ưu hóa lớp Cross Attention - InvokeAI, lstein - https://github.com/invoke-ai/InvokeAI (gốc: http://github.com/lstein/stable-diffusion)
- Tối ưu hóa Cross Attention dưới bậc hai - Alex Birch (https://github.com/Birch-san/diffusers/pull/1), Amin Rezaei (https://github.com/AminRezaei0x443/memory-efficient-attention)
- Textual Inversion - Rinon Gal - https://github.com/rinongal/textual_inversion (không dùng code, chỉ dùng ý tưởng)
- Ý tưởng cho SD upscale - https://github.com/jquesnelle/txt2imghd
- Sinh nhiễu cho outpainting mk2 - https://github.com/parlance-zz/g-diffuser-bot
- Ý tưởng và mượn một số code cho CLIP interrogator - https://github.com/pharmapsychotic/clip-interrogator
- Ý tưởng cho Composable Diffusion - https://github.com/energy-based-model/Compositional-Visual-Generation-with-Composable-Diffusion-Models-PyTorch
- xformers - https://github.com/facebookresearch/xformers
- DeepDanbooru - interrogator cho anime diffusers https://github.com/KichangKim/DeepDanbooru
- Sampling với độ chính xác float32 từ UNet float16 - marunine (ý tưởng), Birch-san (ví dụ Diffusers implementation https://github.com/Birch-san/diffusers-play/tree/92feee6)
- Instruct pix2pix - Tim Brooks (star), Aleksander Holynski (star), Alexei A. Efros (no star) - https://github.com/timothybrooks/instruct-pix2pix
- Tư vấn bảo mật - RyotaK
- UniPC sampler - Wenliang Zhao - https://github.com/wl-zhao/UniPC
- TAESD - Ollin Boer Bohan - https://github.com/madebyollin/taesd
- LyCORIS - KohakuBlueleaf
- Restart sampling - lambertae - https://github.com/Newbeeer/diffusion_restart_sampling
- Hypertile - tfernd - https://github.com/tfernd/HyperTile
- Script Gradio ban đầu - đăng trên 4chan bởi người dùng ẩn danh. Xin cảm ơn người dùng ẩn danh.
- (Bạn)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---