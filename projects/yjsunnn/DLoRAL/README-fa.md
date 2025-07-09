<div align="center">
<h2>انتشار یک‌مرحله‌ای برای افزایش وضوح ویدیو با جزئیات غنی و سازگاری زمانی</h2>

[Yujing Sun](https://yjsunnn.github.io/)<sup>1,2, *</sup> | 
[Lingchen Sun](https://scholar.google.com/citations?hl=zh-CN&tzom=-480&user=ZCDjTn8AAAAJ)<sup>1,2, *</sup> | 
[Shuaizheng Liu](https://scholar.google.com/citations?user=wzdCc-QAAAAJ&hl=en)<sup>1,2</sup> | 
[Rongyuan Wu](https://scholar.google.com/citations?user=A-U8zE8AAAAJ&hl=zh-CN)<sup>1,2</sup> | 
[Zhengqiang Zhang](https://scholar.google.com.tw/citations?user=UX26wSMAAAAJ&hl=en)<sup>1,2</sup> | 
[Lei Zhang](https://www4.comp.polyu.edu.hk/~cslzhang)<sup>1,2</sup>

<sup>1</sup>دانشگاه پلی‌تکنیک هنگ‌کنگ، <sup>2</sup>مؤسسه تحقیقات OPPO
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

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/visual_results.svg" alt="نتایج بصری">

</p>
## ⏰ به‌روزرسانی

- **۲۰۲۵.۰۷.۰۸**: کد استنتاج و وزن‌های پیش‌آموزش‌یافته منتشر شدند.
- **۲۰۲۵.۰۶.۲۴**: صفحه پروژه در دسترس قرار گرفت که شامل یک ویدیوی توضیحی ۲ دقیقه‌ای، نتایج بصری بیشتر و پژوهش‌های مرتبط است.
- **۲۰۲۵.۰۶.۱۷**: مخزن منتشر شد.

:star: اگر DLoRAL برای ویدیوها یا پروژه‌های شما مفید بود، لطفاً به این مخزن ستاره بدهید. سپاسگزاریم! :hugs:

😊 همچنین ممکن است بخواهید آثار مرتبط ما را مشاهده کنید:

1. **OSEDiff (NIPS2024)** [مقاله](https://arxiv.org/abs/2406.08177) | [کد](https://github.com/cswry/OSEDiff/)  

   الگوریتم بزرگ‌نمایی تصویر بلادرنگ که در سری OPPO Find X8 به کار رفته است.

2. **PiSA-SR (CVPR2025)** [مقاله](https://arxiv.org/pdf/2412.03017) | [کد](https://github.com/csslc/PiSA-SR) 

   پیشگام در کاوش پارادایم Dual-LoRA در بزرگ‌نمایی تصویر.

3. **مدل‌های انتشار شگفت‌انگیز برای بزرگ‌نمایی ویدیویی** [مخزن](https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion)

   فهرست منتخب منابع برای بزرگ‌نمایی ویدیویی (VSR) با استفاده از مدل‌های انتشار.
## 👀 برنامه‌های آینده
- [x] انتشار کد استنتاج.
- [ ] رابط کاربری Colab و Huggingface برای تست آسان (به‌زودی!).
- [ ] انتشار کد آموزش.
- [ ] انتشار داده‌های آموزشی.


## 🌟 چارچوب کلی

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/pipeline.svg" alt="DLoRAL Framework">

</p>

**آموزش**: یک طرح آموزش دو مرحله‌ای پویا به‌طور متناوب بین بهینه‌سازی انسجام زمانی (مرحله‌ی سازگاری) و بهبود جزئیات مکانی با فرکانس بالا (مرحله‌ی ارتقاء) با درون‌یابی روان ضرر برای اطمینان از پایداری جابجا می‌شود.

**استنتاج**: در مرحله استنتاج، هر دو C-LoRA و D-LoRA در مدل UNet انتشار منجمد ادغام می‌شوند و ارتقاء یک‌مرحله‌ای ورودی‌های کم‌کیفیت به خروجی‌های با کیفیت بالا را ممکن می‌سازند.
## 🔧 وابستگی‌ها و نصب

1. کلون کردن مخزن
    ```bash
    git clone https://github.com/yjsunnn/DLoRAL.git
    cd DLoRAL
    ```

2. نصب بسته‌های وابسته
    ```bash
    conda create -n DLoRAL python=3.10 -y
    conda activate DLoRAL
    pip install -r requirements.txt
    ```

3. دانلود مدل‌ها 
#### مدل‌های وابسته
* [SD21 Base](https://huggingface.co/stabilityai/stable-diffusion-2-1-base) --> در مسیر **/path/to/DLoRAL/preset_models/stable-diffusion-2-1-base** قرار دهید
* [Bert-Base](https://huggingface.co/google-bert/bert-base-uncased) --> در مسیر **/path/to/DLoRAL/preset_models/bert-base-uncased** قرار دهید
* [RAM](https://huggingface.co/spaces/xinyu1205/recognize-anything/blob/main/ram_swin_large_14m.pth) --> در مسیر **/path/to/DLoRAL/preset/models/ram_swin_large_14m.pth** قرار دهید
* [DAPE](https://drive.google.com/file/d/1KIV6VewwO2eDC9g4Gcvgm-a0LDI7Lmwm/view?usp=drive_link) --> در مسیر **/path/to/DLoRAL/preset/models/DAPE.pth** قرار دهید
* [Pretrained Weights](https://drive.google.com/file/d/1vpcaySpRx_K-tXq2D2EBqFZ-03Foky8G/view?usp=sharing) --> در مسیر **/path/to/DLoRAL/preset/models/checkpoints/model.pkl** قرار دهید

هر مسیر را می‌توان مطابق نیاز خود تغییر داد و تغییرات مربوطه باید در خط فرمان و کد نیز اعمال شود.
## 🖼️ استنتاج سریع
برای افزایش وضوح ویدئوی دنیای واقعی:

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

### ارجاعات
اگر کد ما به پژوهش یا کار شما کمک کرده است، لطفاً مقاله ما را ارجاع دهید.
ارجاعات BibTeX به شرح زیر است:

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