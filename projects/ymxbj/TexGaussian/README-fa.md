<h1 align="center">TexGaussian: تولید مواد PBR با کیفیت بالا با استفاده از پاشش گوسی سه‌بعدی مبتنی بر Octree</h1>
<p align="center"><a href="https://arxiv.org/abs/2411.19654"><img src='https://img.shields.io/badge/arXiv-Paper-red?logo=arxiv&logoColor=white' alt='arXiv'></a>
<a href='https://3d-aigc.github.io/TexGaussian/'><img src='https://img.shields.io/badge/Project_Page-Website-green?logo=googlechrome&logoColor=white' alt='Project Page'></a>
<p align="center"><img src="https://raw.githubusercontent.com/ymxbj/TexGaussian/main/assets/teaser.png" width="100%"></p>

مواد رندرینگ مبتنی بر فیزیک (PBR) نقش حیاتی در گرافیک مدرن ایفا می‌کنند و امکان رندر واقع‌گرایانه در محیط‌های متنوع را فراهم می‌سازند. توسعه یک الگوریتم مؤثر و کارآمد که قادر به تولید خودکار مواد PBR با کیفیت بالا به جای تکسچر RGB برای مش‌های سه‌بعدی باشد، می‌تواند فرآیند تولید محتوای سه‌بعدی را به طور قابل توجهی تسهیل کند. بیشتر روش‌های موجود از مدل‌های دیفیوژن دوبعدی آموزش‌دیده برای سنتز تصویر چندنمایی بهره می‌برند که اغلب منجر به ناسازگاری شدید بین تکسچرهای تولیدشده و مش سه‌بعدی ورودی می‌شود. این مقاله TexGaussian را معرفی می‌کند؛ روشی نوین که از پاشش گوسی سه‌بعدی هم‌راستا با اکتان برای تولید سریع مواد PBR استفاده می‌کند. به طور خاص، هر گوسین سه‌بعدی را روی ریزترین گره برگ اکتری ساخته‌شده از مش سه‌بعدی ورودی قرار می‌دهیم تا تصاویر چندنما را نه فقط برای نقشه albedo بلکه برای roughness و metallic نیز رندر کنیم. افزون بر این، مدل ما به صورت رگرسیونی آموزش می‌بیند نه دیفیوژن، و قادر است ماده PBR را برای یک مش سه‌بعدی در یک فرآیند feed-forward تولید کند. آزمایشات گسترده بر روی بنچمارک‌های عمومی نشان می‌دهند که روش ما مواد PBR بصری جذاب‌تری سنتز کرده و نسبت به روش‌های قبلی در هر دو سناریوی بدون شرط و مبتنی بر متن سریع‌تر عمل می‌کند و سازگاری بهتری با هندسه ارائه‌شده دارد.

## 📦 نصب

```bash
conda create -n texgaussian python==3.10
pip3 install torch==2.1.0 torchvision==0.16.0 torchaudio==2.1.0 --index-url https://download.pytorch.org/whl/cu118

# پاشش گوسی اصلاح‌شده (+ رندرینگ عمق، آلفا)
git clone --recursive https://github.com/ashawkey/diff-gaussian-rasterization

pip3 install ./diff-gaussian-rasterization

pip3 install git+https://github.com/NVlabs/nvdiffrast

# سایر وابستگی‌ها
pip3 install -r requirements.txt
```

## 🤖 مدل‌های آموزش‌دیده

ما مدل‌های آموزش‌دیده زیر را ارائه می‌دهیم:

| مدل | توضیحات | پارامترها | دانلود |
| --- | --- | --- | --- |
| TexGaussian-bench | مدل تکسچر RGB بدون شرط آموزش‌دیده روی ShapeNet bench | 70M | [دانلود](https://huggingface.co/ymxbj/TexGaussian/resolve/main/bench.safetensors?download=true) |
| TexGaussian-car | مدل تکسچر RGB بدون شرط آموزش‌دیده روی ShapeNet car | 70M | [دانلود](https://huggingface.co/ymxbj/TexGaussian/resolve/main/car.safetensors?download=true) |
| TexGaussian-chair | مدل تکسچر RGB بدون شرط آموزش‌دیده روی ShapeNet chair | 70M | [دانلود](https://huggingface.co/ymxbj/TexGaussian/resolve/main/chair.safetensors?download=true) |
| TexGaussian-table | مدل تکسچر RGB بدون شرط آموزش‌دیده روی ShapeNet table | 70M | [دانلود](https://huggingface.co/ymxbj/TexGaussian/resolve/main/table.safetensors?download=true) |
| TexGaussian-PBR | مدل ماده PBR مبتنی بر متن آموزش‌دیده روی Objaverse | 295M | [دانلود](https://huggingface.co/ymxbj/TexGaussian/resolve/main/PBR_model.safetensors?download=true) |

## 💡 استنتاج

### ماده PBR
برای تولید ماده PBR مبتنی بر متن، اجرا کنید
```bash
bash inference_for_PBR_material.sh
```
پس از بیکینگ تکسچر و ماده، دو نقشه دریافت خواهید کرد، یکی نقشه albedo و دیگری نقشه ماده PBR است. به طور خاص، نقشه ماده PBR شامل سه کانال است که کانال سبز نمایانگر مقدار roughness و کانال آبی نمایانگر مقدار metallic می‌باشد. برای رندرینگ PBR نقشه‌های تکسچر و ماده تولیدشده، توصیه می‌کنیم از [این اسکریپت رندرینگ](https://github.com/ymxbj/BlenderToolboxPBR) نوشته‌شده با bpy استفاده کنید.

همچنین، توصیه می‌کنیم همه سبک متن مجموعه داده Cap3D را تقلید کرده و پرامپت‌های خود را برای نتایج بهتر بسازید. مجموعه داده Cap3D را می‌توانید از [اینجا](https://huggingface.co/ymxbj/TexGaussian/resolve/main/Cap3D_automated_Objaverse_full.csv?download=true) دانلود کنید.

### تکسچر RGB
برای تولید تکسچر RGB بدون شرط، که فقط برای ۴ دسته خاص bench، car، chair، table کار می‌کند، اجرا کنید
```bash
bash inference_for_RGB_texture.sh
```
پس از بیکینگ تکسچر، یک نقشه albedo دریافت خواهید کرد.

## 🏋️‍♂️ آموزش
برای Objaverse:
```bash
bash train_for_objaverse.sh
```

برای ShapeNet:
```bash
bash train_for_shapenet.sh
```

## 🚧 برنامه‌های آینده
- [x] انتشار کد آموزش و استنتاج
- [x] انتشار مدل پیش‌آموزش‌دیده فقط albedo روی مجموعه داده ShapeNet
- [x] انتشار مدل پیش‌آموزش‌دیده PBR مبتنی بر متن روی مجموعه داده Objaverse
- [ ] انتشار مجموعه داده و ابزارهای مربوط به آن

## 📚قدردانی

این کار بر پایه پژوهش‌ها و پروژه‌های متن‌باز فوق‌العاده‌ای ساخته شده است. از همه نویسندگان بابت به‌اشتراک‌گذاری سپاسگزاریم!

- [gaussian-splatting](https://github.com/graphdeco-inria/gaussian-splatting) و [diff-gaussian-rasterization](https://github.com/graphdeco-inria/diff-gaussian-rasterization)
- [nvdiffrast](https://github.com/NVlabs/nvdiffrast)
- [LGM](https://github.com/3DTopia/LGM)
- [ocnn-pytorch](https://github.com/octree-nn/ocnn-pytorch)

<!-- Citation -->
## 📜 استناد

اگر این کار برای شما مفید بود، لطفاً مقاله ما را استناد کنید:

1. نسخه arXiv
```bibtex
@article{xiong2024texgaussian,
  title={TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
  author={Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
  journal={arXiv preprint arXiv:2411.19654},
  year={2024}
}
```

2. نسخه CVPR
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