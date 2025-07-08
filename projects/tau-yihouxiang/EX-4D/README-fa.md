# EX-4D: سنتز ویدیو ۴D با دیدگاه‌های بسیار گسترده با استفاده از مش ضدآب عمق

<div align="center">

<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/Logo.png" alt="EX-4D Logo" width="250">

[📄 مقاله](https://arxiv.org/abs/2506.05554)  |  [🎥 صفحه اصلی](https://tau-yihouxiang.github.io/projects/EX-4D/EX-4D.html)  |  [💻 کد](https://github.com/tau-yihouxiang/EX-4D)

</div>



## 🌟 نکات برجسته

- **🎯 سنتز دیدگاه‌های بسیار گسترده**: تولید ویدیوهای ۴D با کیفیت بالا با حرکت دوربین از ۹۰- تا ۹۰+ درجه
- **🔧 مش ضدآب عمق**: نمایش هندسی نوآورانه که هم مناطق قابل مشاهده و هم مناطق پنهان را مدل‌سازی می‌کند
- **⚡ معماری سبک‌وزن**: تنها ۱٪ پارامترهای قابل آموزش (۱۴۰ میلیون) نسبت به هسته ۱۴ میلیاردی انتشار ویدیویی
- **🎭 بدون آموزش چنددیدگاهی**: استراتژی ماسک‌گذاری نوآورانه نیاز به داده‌های چنددیدگاهی گران‌قیمت را حذف می‌کند
- **🏆 عملکرد پیشرفته**: فراتر از روش‌های موجود، به ویژه در زوایای شدید دوربین

## 🎬 نتایج دمو

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/teaser.png" alt="EX-4D Demo Results" width="800">
</div>

*EX-4D ویدیوهای تک‌دوربینی را به تجربه‌های ۴D قابل کنترل با دوربین و نتایج فیزیکی سازگار در زوایای دید بسیار گسترده تبدیل می‌کند.*

## 🏗️ نمای کلی چارچوب

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/overview.png" alt="EX-4D Architecture">
</div>

چارچوب ما از سه بخش کلیدی تشکیل شده است:

1. **🔺 ساخت مش ضدآب عمق**: ایجاد پیش‌زمینه هندسی قوی که به وضوح مناطق قابل مشاهده و پنهان را مدل‌سازی می‌کند
2. **🎭 استراتژی ماسک‌گذاری شبیه‌سازی‌شده**: تولید داده‌های آموزشی مؤثر از ویدیوهای تک‌دوربینی بدون نیاز به داده‌های چنددیدگاهی
3. **⚙️ آداپتور سبک‌وزن LoRA**: ادغام کارآمد اطلاعات هندسی با مدل‌های از پیش آموزش‌دیده انتشار ویدیویی

## 🚀 شروع سریع

### نصب

```bash
# کلون کردن مخزن
git clone https://github.com/tau-yihouxiang/EX-4D.git
cd EX-4D

# ایجاد محیط conda
conda create -n ex4d python=3.10
conda activate ex4d
# نصب PyTorch (نسخه ۲.x توصیه می‌شود)
pip install torch==2.4.1 torchvision==0.19.1 torchaudio==2.4.1 --index-url https://download.pytorch.org/whl/cu124
# نصب Nvdiffrast
pip install git+https://github.com/NVlabs/nvdiffrast.git
# نصب وابستگی‌ها و diffsynth
pip install -e .
# نصب depthcrafter برای تخمین عمق. (برای آماده‌سازی چک‌پوینت‌ها دستورالعمل نصب DepthCrafter را دنبال کنید.)
git clone https://github.com/Tencent/DepthCrafter.git
```

### دانلود مدل آموزش‌دیده
```bash
huggingface-cli download Wan-AI/Wan2.1-I2V-14B-480P --local-dir ./models/Wan-AI
huggingface-cli download yihouxiang/EX-4D --local-dir ./models/EX-4D
```

### مثال استفاده
#### ۱. بازسازی مش DW
```bash
# --cam 180 (30 / 60 / 90 / zoom_in / zoom_out )
python recon.py --input_video examples/flower/input.mp4 --cam 180 --output_dir outputs/flower --save_mesh
```
#### ۲. تولید EX-4D (نیاز به ۴۸ گیگابایت VRAM)
```bash
python generate.py --color_video outputs/flower/color_180.mp4 --mask_video outputs/flower/mask_180.mp4 --output_video outputs/flower/output.mp4
```

<table>
<tr>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/input.gif" width="100%">
<br><b>ویدیوی ورودی</b>
</td>
<td align="center">
<div style="font-size: 2em; color: #4A90E2; padding: 0 0px;">
  ➜
</div>
</td>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/output.gif" width="100%">
<br><b>ویدیوی خروجی</b>
</td>
</tr> 
</table>

<!-- ## 📊 Performance

### Quantitative Results
| روش | FID (اکستریم) ↓ | FVD (اکستریم) ↓ | امتیاز VBench ↑ |
|--------|-----------------|-----------------|----------------|
| ReCamMaster | ۶۴.۶۸ | ۹۴۳.۴۵ | ۰.۴۳۴ |
| TrajectoryCrafter | ۶۵.۳۳ | ۸۹۳.۸۰ | ۰.۴۴۷ |
| TrajectoryAttention | ۶۲.۴۹ | ۹۱۲.۱۴ | ۰.۳۸۹ |
| **EX-4D (مال ما)** | **۵۵.۴۲** | **۸۲۳.۶۱** | **۰.۴۵۰** | -->

### نتایج مطالعه کاربری

- **۷۰.۷٪** از شرکت‌کنندگان EX-4D را نسبت به روش‌های پایه ترجیح دادند
- عملکرد برتر در سازگاری فیزیکی و کیفیت نماهای دید افراطی
- بهبود قابل توجه با افراطی‌تر شدن زوایای دوربین


## 🎯 کاربردها

- **🎮 بازی‌سازی**: ساخت سینماتیک‌های سه‌بعدی جذاب از ویدئوهای دوبعدی
- **🎬 تولید فیلم**: تولید زوایای جدید دوربین برای پس‌تولید
- **🥽 واقعیت مجازی/افزوده**: ایجاد تجربه ویدئویی با زاویه دید آزاد
- **📱 شبکه‌های اجتماعی**: تولید حرکات پویا برای ساخت محتوا
- **🏢 معماری**: نمایش فضاها از دیدگاه‌های مختلف

<!-- ## 📈 بنچمارک‌ها -->

<!-- ### ارزیابی بازه زاویه دید

| بازه | کوچک (۰°→۳۰°) | بزرگ (۰°→۶۰°) | اکستریم (۰°→۹۰°) | کامل (-۹۰°→۹۰°) |
|-------|----------------|----------------|------------------|-----------------|
| امتیاز FID | ۴۴.۱۹ | ۵۰.۳۰ | ۵۵.۴۲ | - |
| فاصله عملکرد | +۹.۱٪ بهتر | +۸.۹٪ بهتر | +۱۱.۳٪ بهتر | +۱۵.۵٪ بهتر | -->

<!-- *فاصله عملکرد نسبت به دومین روش برتر در هر دسته.* -->

## ⚠️ محدودیت‌ها

- **وابستگی به عمق**: عملکرد وابسته به کیفیت برآورد عمق تک‌چشمی است
- **هزینه محاسباتی**: نیازمند محاسبات قابل توجه برای ویدئوهای با وضوح بالا
- **سطوح بازتابنده**: چالش در مواد بازتابنده یا شفاف

## 🔮 کارهای آینده
- [ ] بهینه‌سازی استنتاج بلادرنگ (۳DGS / 4DGS)
- [ ] پشتیبانی از وضوح‌های بالاتر (۱K، ۲K)
- [ ] تکنیک‌های بهبود مش عصبی

## 🙏 تقدیر و تشکر

از پروژه [DiffSynth-Studio v1.1.1](https://github.com/modelscope/DiffSynth-Studio/tree/v1.1.1) بابت فراهم کردن چارچوب دیفیوژن پایه سپاسگزاریم.

## 📚 ارجاع

اگر این پژوهش برای شما مفید بود، لطفاً استناد نمایید:

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