<div align="center">
<h2>Khuếch Tán Một Bước cho Siêu Phân Giải Video Giàu Chi Tiết và Ổn Định Theo Thời Gian</h2>

[Yujing Sun](https://yjsunnn.github.io/)<sup>1,2, *</sup> | 
[Lingchen Sun](https://scholar.google.com/citations?hl=zh-CN&tzom=-480&user=ZCDjTn8AAAAJ)<sup>1,2, *</sup> | 
[Shuaizheng Liu](https://scholar.google.com/citations?user=wzdCc-QAAAAJ&hl=en)<sup>1,2</sup> | 
[Rongyuan Wu](https://scholar.google.com/citations?user=A-U8zE8AAAAJ&hl=zh-CN)<sup>1,2</sup> | 
[Zhengqiang Zhang](https://scholar.google.com.tw/citations?user=UX26wSMAAAAJ&hl=en)<sup>1,2</sup> | 
[Lei Zhang](https://www4.comp.polyu.edu.hk/~cslzhang)<sup>1,2</sup>

<sup>1</sup>Đại học Bách khoa Hồng Kông, <sup>2</sup>Viện Nghiên cứu OPPO
</div>

<div>
    <h4 align="center">
        <a href="https://yjsunnn.github.io/DLoRAL-project/" target='_blank'>
        <img src="https://img.shields.io/badge/💡-Project%20Page-gold">
        </a>
        <a href="https://arxiv.org/pdf/2506.15591" target='_blank'>
        <img src="https://img.shields.io/badge/arXiv-2312.06640-b31b1b.svg">
        </a>
        <a href="https://www.youtube.com/embed/Jsk8zSE3U-w?si=jz1Isdzxt_NqqDFL&vq=hd1080" target='_blank'>
        <img src="https://img.shields.io/badge/Demo%20Video-%23FF0000.svg?logo=YouTube&logoColor=white">
        </a>
        <a href="https://www.youtube.com/embed/xzZL8X10_KU?si=vOB3chIa7Zo0l54v" target="_blank">
        <img src="https://img.shields.io/badge/2--Min%20Explainer-brightgreen?logo=YouTube&logoColor=white">
        </a>
        </a>
        <a href="https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion" target="_blank">
        <img src="https://img.shields.io/badge/GitHub-Awesome--VSR--Diffusion-181717.svg?logo=github&logoColor=white">
        </a>
<!--         <a href="https://www.youtube.com/embed/Jsk8zSE3U-w?si=jz1Isdzxt_NqqDFL&vq=hd1080" target='_blank'>
        <img src="https://img.shields.io/badge/1--Min%20Algorithm%20Explainer-%23FF0000.svg?logo=YouTube&logoColor=white">
        </a> -->
        <a href="https://github.com/yjsunnn/DLoRAL" target='_blank' style="text-decoration: none;"><img src="https://visitor-badge.laobi.icu/badge?page_id=yjsunnn/DLoRAL"></a>
    </h4>
</div>

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/visual_results.svg" alt="Kết quả trực quan">

</p>
## ⏰ Cập nhật

- **2025.07.08**: Mã suy luận và trọng số đã huấn luyện sẵn đã được phát hành.
- **2025.06.24**: Trang dự án đã khả dụng, bao gồm video giải thích ngắn 2 phút, nhiều kết quả trực quan hơn và các nghiên cứu liên quan.
- **2025.06.17**: Repo đã được phát hành.

:star: Nếu DLoRAL hữu ích cho video hoặc dự án của bạn, vui lòng giúp đánh dấu sao repo này. Cảm ơn! :hugs:

😊 Bạn cũng có thể muốn xem các công trình liên quan của chúng tôi:

1. **OSEDiff (NIPS2024)** [Bài báo](https://arxiv.org/abs/2406.08177) | [Mã nguồn](https://github.com/cswry/OSEDiff/)  

   Thuật toán nâng cao chất lượng ảnh thời gian thực đã được áp dụng cho dòng sản phẩm OPPO Find X8.

2. **PiSA-SR (CVPR2025)** [Bài báo](https://arxiv.org/pdf/2412.03017) | [Mã nguồn](https://github.com/csslc/PiSA-SR) 

   Khám phá tiên phong về mô hình Dual-LoRA trong nâng cao chất lượng ảnh.

3. **Awesome Diffusion Models for Video Super-Resolution** [Repo](https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion)

   Danh sách tổng hợp các tài nguyên về nâng cao chất lượng video (VSR) sử dụng Mô hình Khuếch tán.
## 👀 VIỆC CẦN LÀM
- [x] Phát hành mã suy luận.
- [ ] Colab và giao diện Huggingface để kiểm tra thuận tiện (Sắp có!).
- [ ] Phát hành mã huấn luyện.
- [ ] Phát hành dữ liệu huấn luyện.


## 🌟 Khung Tổng Quan

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/pipeline.svg" alt="Khung DLoRAL">

</p>

**Huấn luyện**: Một sơ đồ huấn luyện hai giai đoạn động luân phiên tối ưu hóa tính nhất quán theo thời gian (giai đoạn nhất quán) và cải thiện chi tiết không gian tần số cao (giai đoạn tăng cường) với phép nội suy mất mát mượt mà nhằm đảm bảo sự ổn định.

**Suy luận**: Trong quá trình suy luận, cả C-LoRA và D-LoRA đều được hợp nhất vào mạng UNet khuếch tán đóng băng, cho phép tăng cường đầu vào chất lượng thấp thành đầu ra chất lượng cao chỉ trong một bước.
## 🔧 Phụ thuộc và Cài đặt

1. Sao chép kho lưu trữ
    ```bash
    git clone https://github.com/yjsunnn/DLoRAL.git
    cd DLoRAL
    ```

2. Cài đặt các gói phụ thuộc
    ```bash
    conda create -n DLoRAL python=3.10 -y
    conda activate DLoRAL
    pip install -r requirements.txt
    ```

3. Tải về các mô hình
#### Các mô hình phụ thuộc
* [SD21 Base](https://huggingface.co/stabilityai/stable-diffusion-2-1-base) --> đặt vào **/path/to/DLoRAL/preset_models/stable-diffusion-2-1-base**
* [Bert-Base](https://huggingface.co/google-bert/bert-base-uncased) --> đặt vào **/path/to/DLoRAL/preset_models/bert-base-uncased**
* [RAM](https://huggingface.co/spaces/xinyu1205/recognize-anything/blob/main/ram_swin_large_14m.pth) --> đặt vào **/path/to/DLoRAL/preset/models/ram_swin_large_14m.pth**
* [DAPE](https://drive.google.com/file/d/1KIV6VewwO2eDC9g4Gcvgm-a0LDI7Lmwm/view?usp=drive_link) --> đặt vào **/path/to/DLoRAL/preset/models/DAPE.pth**
* [Pretrained Weights](https://drive.google.com/file/d/1vpcaySpRx_K-tXq2D2EBqFZ-03Foky8G/view?usp=sharing) --> đặt vào **/path/to/DLoRAL/preset/models/checkpoints/model.pkl**

Mỗi đường dẫn có thể được thay đổi tùy theo nhu cầu của bạn, và các thay đổi tương ứng cũng cần được áp dụng vào dòng lệnh cũng như mã nguồn.
## 🖼️ Suy luận Nhanh
Đối với Siêu phân giải Video Thế giới Thực:

```
python src/test_DLoRAL.py     \
--pretrained_model_path /path/to/stable-diffusion-2-1-base     \
--ram_ft_path /path/to/DAPE.pth     \
--ram_path '/path/to/ram_swin_large_14m.pth'     \
--merge_and_unload_lora False     \
--process_size 512     \
--pretrained_model_name_or_path '/path/to/stable-diffusion-2-1-base'     \
--vae_encoder_tiled_size 4096     \
--load_cfr     \
--pretrained_path /path/to/model_checkpoint.pkl     \
--stages 1     \
-i /path/to/input_videos/     \
-o /path/to/results
```
### Trích dẫn
Nếu mã nguồn của chúng tôi hỗ trợ cho nghiên cứu hoặc công việc của bạn, vui lòng trích dẫn bài báo của chúng tôi.
Dưới đây là các tham chiếu BibTeX:

```
@misc{sun2025onestepdiffusiondetailrichtemporally,
      title={One-Step Diffusion for Detail-Rich and Temporally Consistent Video Super-Resolution}, 
      author={Yujing Sun and Lingchen Sun and Shuaizheng Liu and Rongyuan Wu and Zhengqiang Zhang and Lei Zhang},
      year={2025},
      eprint={2506.15591},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.15591}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---