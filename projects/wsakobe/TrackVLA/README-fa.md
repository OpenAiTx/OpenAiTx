<p align="center">
<h1 align="center"><strong>TrackVLA: ردیابی بصری تجسم‌یافته در محیط‌های واقعی</strong></h1>
  <p align="center">
    <!--   	<strong>CoRL 2025</strong><br> -->
    <a href='https://wsakobe.github.io/' target='_blank'>شائوان وانگ</a>&emsp;
	<a href='https://jzhzhang.github.io/' target='_blank'>جیاژائو ژانگ</a>&emsp;
    مینگهان لی&emsp;
    جیاهانگ لیو&emsp;
    آن‌چی لی&emsp; <br>
    کوی وو&emsp;
    <a href='https://fangweizhong.xyz/' target='_blank'>فانگ‌وی ژونگ</a>&emsp;
    <a href='https://www.coe.pku.edu.cn/teaching/manufacturing/9993.html' target='_blank'>جونژی یو</a>&emsp;
	<a href='https://scholar.google.com/citations?user=X7M0I8kAAAAJ&hl=zh-CN' target='_blank'>ژیزژنگ ژانگ</a>&emsp;
  <a href='https://hughw19.github.io/' target='_blank'>هه وانگ</a>&emsp;
    <br>
    دانشگاه پکن&emsp; 
    گالبوت&emsp; <br>
    دانشگاه بیهانگ&emsp;
    دانشگاه نرمال پکن&emsp;
    آکادمی هوش مصنوعی پکن&emsp;
    <br>
  </p>
</p>

<div id="top" align="center">

[![پروژه](https://img.shields.io/badge/Project-%239c403d?style=flat&logoColor=%23FA7F6F
)](https://pku-epic.github.io/TrackVLA-web/)
[![arXiv](https://img.shields.io/badge/Arxiv-%233b6291?style=flat&logoColor=%23FA7F6F
)](http://arxiv.org/abs/2505.23189)
[![ویدیو](https://img.shields.io/badge/Video-%23c97937?style=flat&logoColor=%23FA7F6F
)](https://youtu.be/v51U3Nk-SK4?si=foz3zbYD8hLHSybC)

</div>

## 🏡 درباره
<strong><em>TrackVLA</em></strong> یک مدل بینایی-زبان-عمل است که قادر به شناسایی همزمان اشیا و ردیابی بصری بوده و بر روی دیتاستی شامل ۱.۷ میلیون نمونه آموزش دیده است. این مدل ردیابی مقاوم، ردیابی بلندمدت و تعمیم میان حوزه‌ای را در محیط‌های متنوع و چالش‌برانگیز نشان می‌دهد.
<div style="text-align: center;">
    <img src="https://raw.githubusercontent.com/wsakobe/TrackVLA/main/assets/teaser.png" alt="Dialogue_Teaser" width=100% >
</div>

## 📢 اخبار

* [25/07/02]: EVT-Bench اکنون در دسترس است.

## 💡 نصب
1. **آماده‌سازی محیط Conda**

   ابتدا باید [conda](https://docs.conda.io/projects/conda/en/latest/user-guide/install/) را نصب کنید. پس از نصب conda، یک محیط جدید ایجاد کنید:
   ```bash
   conda create -n evt_bench python=3.9 cmake=3.14.0
   conda activate evt_bench
   ```

2. **نصب habitat-sim با conda**
   
   باید habitat-sim نسخه 0.3.1 را نصب کنید.
      ```
      conda install habitat-sim==0.3.1 withbullet -c conda-forge -c aihabitat
      ```

3. **نصب habitat-lab از سورس**
      ```
      cd habitat-lab
      pip install -e habitat-lab
      ```

4. **آماده‌سازی دیتاست‌ها**

    دیتاست Habitat Matterport 3D (HM3D) را از [اینجا](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#habitat-matterport-3d-research-dataset-hm3d) و Matterport3D (MP3D) را از [اینجا](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#matterport3d-mp3d-dataset) دانلود کنید.

    سپس دیتاست را به پوشه `data/scene_datasets` منتقل کنید. ساختار دیتاست به صورت زیر خواهد بود:
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

    سپس، کد زیر را برای دریافت داده‌های آواتارهای انسان‌نما اجرا کنید:
      ```
      python download_humanoid_data.py
      ```


## 🧪 ارزیابی
  اسکریپت را با دستور زیر اجرا کنید:

    bash eval.sh

  نتایج در مسیر مشخص شده SAVE_PATH ذخیره خواهند شد که شامل پوشه log و پوشه ویدیو خواهد بود. برای پایش نتایج در طول فرآیند ارزیابی، اجرا کنید:
    watch -n 1 python analyze_results.py --path YOUR_RESULTS_PATH

  برای توقف ارزیابی، از دستور زیر استفاده کنید:

    bash kill_eval.sh


## 📝 لیست کارهای TODO
- [x] انتشار مقاله arXiv در ماه می ۲۰۲۵.
- [x] انتشار EVT-Bench (معیار ردیابی بصری تجسم‌یافته).
- [ ] انتشار مجموعه داده ردیابی بصری تجسم‌یافته در مقیاس بزرگ.
- [ ] انتشار چک‌پوینت و کد TrackVLA.

## ✉️ تماس
در صورت داشتن هرگونه سؤال، لطفاً به wangshaoan@stu.pku.edu.cn ایمیل بزنید. ما در اسرع وقت پاسخ خواهیم داد.


## 🔗 استناد
اگر کار ما برای شما مفید بود، لطفاً به شکل زیر به آن استناد کنید:

```bibtex
@article{wang2025trackvla,
  title={Trackvla: Embodied visual tracking in the wild},
  author={Wang, Shaoan and Zhang, Jiazhao and Li, Minghan and Liu, Jiahang and Li, Anqi and Wu, Kui and Zhong, Fangwei and Yu, Junzhi and Zhang, Zhizheng and Wang, He},
  journal={arXiv preprint arXiv:2505.23189},
  year={2025}
}
```

## 📄 مجوز
<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/80x15.png" /></a>
<br />
این اثر تحت <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">مجوز Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License</a> قرار دارد.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---