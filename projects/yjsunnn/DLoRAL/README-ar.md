<div align="center">
<h2>الانتشار بخطوة واحدة لتحسين دقة الفيديو مع تفاصيل غنية وتوافق زمني متسق</h2>

[Yujing Sun](https://yjsunnn.github.io/)<sup>1,2, *</sup> | 
[Lingchen Sun](https://scholar.google.com/citations?hl=zh-CN&tzom=-480&user=ZCDjTn8AAAAJ)<sup>1,2, *</sup> | 
[Shuaizheng Liu](https://scholar.google.com/citations?user=wzdCc-QAAAAJ&hl=en)<sup>1,2</sup> | 
[Rongyuan Wu](https://scholar.google.com/citations?user=A-U8zE8AAAAJ&hl=zh-CN)<sup>1,2</sup> | 
[Zhengqiang Zhang](https://scholar.google.com.tw/citations?user=UX26wSMAAAAJ&hl=en)<sup>1,2</sup> | 
[Lei Zhang](https://www4.comp.polyu.edu.hk/~cslzhang)<sup>1,2</sup>

<sup>1</sup>جامعة هونغ كونغ بوليتكنيك، <sup>2</sup>معهد أبحاث أوبو
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

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/visual_results.svg" alt="النتائج البصرية">

</p>
## ⏰ التحديث

- **2025.07.08**: تم توفير كود الاستدلال والأوزان المدربة مسبقًا.
- **2025.06.24**: صفحة المشروع متاحة، وتشمل فيديو شرح موجز لمدة دقيقتين، ونتائج بصرية إضافية وأبحاث ذات صلة.
- **2025.06.17**: تم إصدار المستودع.

:star: إذا كان DLoRAL مفيدًا لمقاطع الفيديو أو مشاريعك، يرجى دعمنا بوضع نجمة لهذا المستودع. شكرًا! :hugs:

😊 قد ترغب أيضًا في الاطلاع على أعمالنا ذات الصلة:

1. **OSEDiff (NIPS2024)** [ورقة بحثية](https://arxiv.org/abs/2406.08177) | [الكود](https://github.com/cswry/OSEDiff/)  

   خوارزمية تحسين الصور الفوريّة (SR) التي تم تطبيقها على سلسلة OPPO Find X8.

2. **PiSA-SR (CVPR2025)** [ورقة بحثية](https://arxiv.org/pdf/2412.03017) | [الكود](https://github.com/csslc/PiSA-SR) 

   استكشاف رائد لنموذج Dual-LoRA في تحسين الصور (SR).

3. **نماذج النشر الرائعة لتحسين دقة الفيديو** [المستودع](https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion)

   قائمة منسقة بالموارد الخاصة بتحسين دقة الفيديو (VSR) باستخدام نماذج النشر.
## 👀 المهام القادمة
- [x] إصدار كود الاستدلال.
- [ ] واجهة Colab وHuggingface لاختبار مريح (قريبًا!).
- [ ] إصدار كود التدريب.
- [ ] إصدار بيانات التدريب.

## 🌟 نظرة عامة على الإطار

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/pipeline.svg" alt="إطار عمل DLoRAL">

</p>

**التدريب**: يعتمد نظام التدريب المزدوج الديناميكي على التناوب بين تحسين التوافق الزمني (مرحلة الاتساق) وتحسين التفاصيل المكانية عالية التردد (مرحلة التعزيز) مع تدرج سلس لفقدان البيانات لضمان الاستقرار.

**الاستدلال**: أثناء الاستدلال، يتم دمج كل من C-LoRA و D-LoRA في شبكة UNet المجمدة الخاصة بالنشر الانتشاري، مما يتيح تعزيزًا فوريًا للمدخلات منخفضة الجودة وتحويلها إلى مخرجات عالية الجودة.
## 🔧 الاعتماديات والتثبيت

1. استنساخ المستودع
    ```bash
    git clone https://github.com/yjsunnn/DLoRAL.git
    cd DLoRAL
    ```

2. تثبيت الحزم المعتمدة
    ```bash
    conda create -n DLoRAL python=3.10 -y
    conda activate DLoRAL
    pip install -r requirements.txt
    ```

3. تحميل النماذج
#### النماذج المعتمدة
* [SD21 Base](https://huggingface.co/stabilityai/stable-diffusion-2-1-base) --> ضعها في **/path/to/DLoRAL/preset_models/stable-diffusion-2-1-base**
* [Bert-Base](https://huggingface.co/google-bert/bert-base-uncased) --> ضعها في **/path/to/DLoRAL/preset_models/bert-base-uncased**
* [RAM](https://huggingface.co/spaces/xinyu1205/recognize-anything/blob/main/ram_swin_large_14m.pth) --> ضعها في **/path/to/DLoRAL/preset/models/ram_swin_large_14m.pth**
* [DAPE](https://drive.google.com/file/d/1KIV6VewwO2eDC9g4Gcvgm-a0LDI7Lmwm/view?usp=drive_link) --> ضعها في **/path/to/DLoRAL/preset/models/DAPE.pth**
* [Pretrained Weights](https://drive.google.com/file/d/1vpcaySpRx_K-tXq2D2EBqFZ-03Foky8G/view?usp=sharing) --> ضعها في **/path/to/DLoRAL/preset/models/checkpoints/model.pkl**

يمكن تعديل كل مسار حسب المتطلبات الخاصة، ويجب أيضاً تطبيق التغييرات المقابلة على سطر الأوامر والكود.
## 🖼️ الاستدلال السريع
لتكبير الفيديو فائق الدقة في العالم الحقيقي:

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
### الاستشهادات
إذا ساعدك كودنا في بحثك أو عملك، يرجى النظر في الاستشهاد بورقتنا.
فيما يلي مراجع BibTeX:

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