<p align="center">
<h1 align="center"><strong>TrackVLA: التتبع البصري المجسد في البيئات الحقيقية</strong></h1>
  <p align="center">
    <!--   	<strong>CoRL 2025</strong><br> -->
    <a href='https://wsakobe.github.io/' target='_blank'>شاوآن وانغ</a>&emsp;
	<a href='https://jzhzhang.github.io/' target='_blank'>جيازهاو زانغ</a>&emsp;
    مينغهان لي&emsp;
    جياهانغ ليو&emsp;
    آنتشي لي&emsp; <br>
    كوي وو&emsp;
    <a href='https://fangweizhong.xyz/' target='_blank'>فانغوي تشونغ</a>&emsp;
    <a href='https://www.coe.pku.edu.cn/teaching/manufacturing/9993.html' target='_blank'>جونتشي يو</a>&emsp;
	<a href='https://scholar.google.com/citations?user=X7M0I8kAAAAJ&hl=zh-CN' target='_blank'>تشي تشنغ زانغ</a>&emsp;
  <a href='https://hughw19.github.io/' target='_blank'>هي وانغ</a>&emsp;
    <br>
    جامعة بكين&emsp; 
    جالبوت&emsp; <br>
    جامعة بيهانغ&emsp;
    جامعة بكين العادية&emsp;
    الأكاديمية الصينية للذكاء الاصطناعي في بكين&emsp;
    <br>
  </p>
</p>

<div id="top" align="center">

[![المشروع](https://img.shields.io/badge/Project-%239c403d?style=flat&logoColor=%23FA7F6F
)](https://pku-epic.github.io/TrackVLA-web/)
[![arXiv](https://img.shields.io/badge/Arxiv-%233b6291?style=flat&logoColor=%23FA7F6F
)](http://arxiv.org/abs/2505.23189)
[![الفيديو](https://img.shields.io/badge/Video-%23c97937?style=flat&logoColor=%23FA7F6F
)](https://youtu.be/v51U3Nk-SK4?si=foz3zbYD8hLHSybC)

</div>

## 🏡 حول
<strong><em>TrackVLA</em></strong> هو نموذج رؤية-لغة-حركة قادر على التعرف على الأشياء وتتبعها بصريًا في الوقت نفسه، تم تدريبه على مجموعة بيانات تحتوي على 1.7 مليون عينة. يُظهر قدرات قوية في التتبع، والتتبع طويل الأمد، والتعميم عبر المجالات في بيئات متنوعة وصعبة.
<div style="text-align: center;">
    <img src="https://raw.githubusercontent.com/wsakobe/TrackVLA/main/assets/teaser.png" alt="Dialogue_Teaser" width=100% >
</div>

## 📢 الأخبار

* [25/07/02]: أصبحت EVT-Bench متاحة الآن.

## 💡 التثبيت
1. **تحضير بيئة conda**

   أولاً، تحتاج إلى تثبيت [conda](https://docs.conda.io/projects/conda/en/latest/user-guide/install/). بعد تثبيت conda، قم بإنشاء بيئة جديدة:
   ```bash
   conda create -n evt_bench python=3.9 cmake=3.14.0
   conda activate evt_bench
   ```

2. **تثبيت habitat-sim عبر Conda**
   
   تحتاج إلى تثبيت habitat-sim بالإصدار 0.3.1
      ```
      conda install habitat-sim==0.3.1 withbullet -c conda-forge -c aihabitat
      ```

3. **تثبيت habitat-lab من المصدر**
      ```
      cd habitat-lab
      pip install -e habitat-lab
      ```

4. **تحضير مجموعات البيانات**

    قم بتنزيل مجموعة بيانات Habitat Matterport 3D (HM3D) من [هنا](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#habitat-matterport-3d-research-dataset-hm3d) وMatterport3D (MP3D) من [هنا](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#matterport3d-mp3d-dataset).

    ثم قم بنقل مجموعة البيانات إلى `data/scene_datasets`. هيكلية البيانات موضحة كما يلي:
    ```
    data/
     └── scene_datasets/
        ├── hm3d/
        │ ├── train/
        │ │   └── ...
        │ ├── val/
        │ │   └── ...
        │ └── minival
        │     └── ...
        └── mp3d/
          ├── 1LXtFkjw3qL
          │   └── ...
          └── ...
    ```

    بعد ذلك، قم بتشغيل الكود التالي للحصول على بيانات الأفاتار البشري:
      ```
      python download_humanoid_data.py
      ```


## 🧪 التقييم
  قم بتشغيل السكريبت باستخدام:

    bash eval.sh

  سيتم حفظ النتائج في SAVE_PATH المحدد، والذي سيحتوي على دليل للسجلات ودليل للفيديو. لمتابعة النتائج أثناء عملية التقييم، قم بتشغيل:
    watch -n 1 python analyze_results.py --path YOUR_RESULTS_PATH

  لإيقاف التقييم، استخدم:

    bash kill_eval.sh


## 📝 قائمة المهام TODO
- [x] نشر ورقة arXiv في مايو 2025.
- [x] إصدار EVT-Bench (معيار التتبع البصري المتجسد).
- [ ] إصدار مجموعة بيانات التتبع البصري المتجسد واسعة النطاق.
- [ ] إصدار نقطة التحقق والشيفرة الخاصة بـ TrackVLA.

## ✉️ تواصل معنا
لأي استفسارات، لا تتردد في إرسال بريد إلكتروني إلى wangshaoan@stu.pku.edu.cn. سنرد عليك في أقرب وقت ممكن.


## 🔗 الاقتباس
إذا وجدت عملنا مفيدًا، يرجى الاستشهاد به كما يلي:

```bibtex
@article{wang2025trackvla,
  title={Trackvla: Embodied visual tracking in the wild},
  author={Wang, Shaoan and Zhang, Jiazhao and Li, Minghan and Liu, Jiahang and Li, Anqi and Wu, Kui and Zhong, Fangwei and Yu, Junzhi and Zhang, Zhizheng and Wang, He},
  journal={arXiv preprint arXiv:2505.23189},
  year={2025}
}
```

## 📄 الرخصة
<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="رخصة المشاع الإبداعي" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/80x15.png" /></a>
<br />
هذا العمل مرخّص بموجب <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">رخصة المشاع الإبداعي النسبة-غير تجاري-المشاركة بالمثل 4.0 الدولية</a>.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---