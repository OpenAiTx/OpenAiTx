<h1 align="center">TexGaussian: توليد مواد PBR عالية الجودة عبر توزيع Gaussian ثلاثي الأبعاد قائم على شجرة ثمانية الفروع (Octree)</h1>
<p align="center"><a href="https://arxiv.org/abs/2411.19654"><img src='https://img.shields.io/badge/arXiv-Paper-red?logo=arxiv&logoColor=white' alt='arXiv'></a>
<a href='https://3d-aigc.github.io/TexGaussian/'><img src='https://img.shields.io/badge/Project_Page-Website-green?logo=googlechrome&logoColor=white' alt='Project Page'></a>
<p align="center"><img src="assets/teaser.png" width="100%"></p>

تلعب المواد ذات العرض الفيزيائي القائم (PBR) دورًا حاسمًا في الرسوميات الحديثة، إذ تتيح إنشاء عروض واقعية عبر خرائط بيئية متنوعة. يمكن أن يؤدي تطوير خوارزمية فعالة وفعّالة قادرة على توليد مواد PBR عالية الجودة تلقائيًا بدلاً من توليد نسيج RGB فقط لنماذج ثلاثية الأبعاد إلى تبسيط عملية إنشاء المحتوى ثلاثي الأبعاد بشكل كبير. تعتمد معظم الطرق الحالية على نماذج الانتشار ثنائية الأبعاد المدربة مسبقًا لتوليد صور متعددة الزوايا، مما يؤدي غالبًا إلى عدم تطابق شديد بين القوام الناتج والشكل ثلاثي الأبعاد المدخل. تقدم هذه الورقة TexGaussian، وهي طريقة جديدة تستخدم توزيع Gaussian ثلاثي الأبعاد المحاذي للأوكتانتات لتوليد مواد PBR بسرعة. على وجه التحديد، نقوم بوضع كل Gaussian ثلاثي الأبعاد على العقدة الورقية الأدق لشجرة Octree المبنية من النموذج ثلاثي الأبعاد المدخل لعرض الصور متعددة الزوايا ليس فقط لخريطة Albedo، بل أيضًا للخشونة (roughness) والمعدنية (metallic). علاوة على ذلك، يتم تدريب نموذجنا بطريقة الانحدار بدلاً من إزالة التشويش بالانتشار، وقادر على توليد مادة PBR لنموذج ثلاثي الأبعاد في عملية تمرير أمامي واحدة. تظهر التجارب الموسعة على معايير عامة أن طريقتنا تولد مواد PBR أكثر إرضاءً بصريًا وتعمل بسرعة أكبر من الطرق السابقة في كل من الحالات غير المشروطة والمعتمدة على النص، مع اتساق أفضل مع الهندسة المعطاة.

## 📦 التثبيت

```bash
conda create -n texgaussian python==3.10
pip3 install torch==2.1.0 torchvision==0.16.0 torchaudio==2.1.0 --index-url https://download.pytorch.org/whl/cu118

# توزيع Gaussian معدل (+ العمق، عرض ألفا)
git clone --recursive https://github.com/ashawkey/diff-gaussian-rasterization

pip3 install ./diff-gaussian-rasterization

pip3 install git+https://github.com/NVlabs/nvdiffrast

# تبعيات أخرى
pip3 install -r requirements.txt
```

## 🤖 النماذج المدربة مسبقاً

نوفر النماذج المدربة مسبقًا التالية:

| النموذج | الوصف | عدد المعاملات | التحميل |
| --- | --- | --- | --- |
| TexGaussian-bench | نموذج نسيج RGB غير مشروط مدرب على ShapeNet فئة bench | 70M | [تحميل](https://huggingface.co/ymxbj/TexGaussian/resolve/main/bench.safetensors?download=true) |
| TexGaussian-car | نموذج نسيج RGB غير مشروط مدرب على ShapeNet فئة car | 70M | [تحميل](https://huggingface.co/ymxbj/TexGaussian/resolve/main/car.safetensors?download=true) |
| TexGaussian-chair | نموذج نسيج RGB غير مشروط مدرب على ShapeNet فئة chair | 70M | [تحميل](https://huggingface.co/ymxbj/TexGaussian/resolve/main/chair.safetensors?download=true) |
| TexGaussian-table | نموذج نسيج RGB غير مشروط مدرب على ShapeNet فئة table | 70M | [تحميل](https://huggingface.co/ymxbj/TexGaussian/resolve/main/table.safetensors?download=true) |
| TexGaussian-PBR | نموذج مادة PBR مشروط بالنص ومدرب على Objaverse | 295M | [تحميل](https://huggingface.co/ymxbj/TexGaussian/resolve/main/PBR_model.safetensors?download=true) |

## 💡 الاستدلال

### مادة PBR
لتوليد مادة PBR مشروطة بالنص، نفّذ:
```bash
bash inference_for_PBR_material.sh
```
بعد الخبز للنسيج والمادة، ستحصل على خريطتين: واحدة لخريطة albedo وأخرى لخريطة مادة PBR. على وجه التحديد، تحتوي خريطة مادة PBR على ثلاث قنوات، حيث تمثل القناة الخضراء قيمة الخشونة والقناة الزرقاء قيمة المعدنية. لإجراء عرض PBR للنسيج والخرائط الناتجة، نوصي باستخدام [هذا السكربت للعرض](https://github.com/ymxbj/BlenderToolboxPBR) المكتوب بواسطة bpy.

بالإضافة إلى ذلك، نوصي الجميع بتقليد أسلوب نصوص مجموعة بيانات Cap3D وإنشاء مطالباتكم الخاصة للحصول على نتائج أفضل. يمكن تحميل مجموعة بيانات Cap3D من [هنا](https://huggingface.co/ymxbj/TexGaussian/resolve/main/Cap3D_automated_Objaverse_full.csv?download=true).

### نسيج RGB
لتوليد نسيج RGB غير مشروط، والذي يعمل فقط لأربع فئات محددة: bench, car, chair, table، نفذ:
```bash
bash inference_for_RGB_texture.sh
```
بعد خبز النسيج، ستحصل على خريطة albedo واحدة.

## 🏋️‍♂️ التدريب
لـ Objaverse:
```bash
bash train_for_objaverse.sh
```

لـ ShapeNet:
```bash
bash train_for_shapenet.sh
```

## 🚧 قيد التنفيذ
- [x] إطلاق كود التدريب والاستدلال
- [x] إطلاق نموذج مدرب مسبقًا غير مشروط (albedo فقط) على مجموعة بيانات ShapeNet
- [x] إطلاق نموذج مدرب مسبقًا لمادة PBR مشروطة بالنص على مجموعة بيانات Objaverse
- [ ] إطلاق مجموعة البيانات وأدواتها

## 📚 الشكر والتقدير

هذا العمل مبني على العديد من الأبحاث والمشاريع مفتوحة المصدر المذهلة، شكرًا جزيلًا لجميع المؤلفين على المشاركة!

- [gaussian-splatting](https://github.com/graphdeco-inria/gaussian-splatting) و [diff-gaussian-rasterization](https://github.com/graphdeco-inria/diff-gaussian-rasterization)
- [nvdiffrast](https://github.com/NVlabs/nvdiffrast)
- [LGM](https://github.com/3DTopia/LGM)
- [ocnn-pytorch](https://github.com/octree-nn/ocnn-pytorch)

<!-- Citation -->
## 📜 الاستشهاد

إذا وجدت هذا العمل مفيدًا، يرجى الاستشهاد بورقتنا:

1. نسخة arXiv
```bibtex
@article{xiong2024texgaussian,
  title={TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
  author={Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
  journal={arXiv preprint arXiv:2411.19654},
  year={2024}
}
```

2. نسخة CVPR
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