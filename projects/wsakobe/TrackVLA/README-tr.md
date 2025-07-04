<p align="center">
<h1 align="center"><strong>TrackVLA: Doğada Vücutlu Görsel Takip</strong></h1>
  <p align="center">
    <!--   	<strong>CoRL 2025</strong><br> -->
    <a href='https://wsakobe.github.io/' target='_blank'>Shaoan Wang</a>&emsp;
	<a href='https://jzhzhang.github.io/' target='_blank'>Jiazhao Zhang</a>&emsp;
    Minghan Li&emsp;
    Jiahang Liu&emsp;
    Anqi Li&emsp; <br>
    Kui Wu&emsp;
    <a href='https://fangweizhong.xyz/' target='_blank'>Fangwei Zhong</a>&emsp;
    <a href='https://www.coe.pku.edu.cn/teaching/manufacturing/9993.html' target='_blank'>Junzhi Yu</a>&emsp;
	<a href='https://scholar.google.com/citations?user=X7M0I8kAAAAJ&hl=zh-CN' target='_blank'>Zhizheng Zhang</a>&emsp;
  <a href='https://hughw19.github.io/' target='_blank'>He Wang</a>&emsp;
    <br>
    Pekin Üniversitesi&emsp; 
    Galbot&emsp; <br>
    Beihang Üniversitesi&emsp;
    Beijing Normal Üniversitesi&emsp;
    Beijing Yapay Zeka Akademisi&emsp;
    <br>
  </p>
</p>

<div id="top" align="center">

[![Proje](https://img.shields.io/badge/Project-%239c403d?style=flat&logoColor=%23FA7F6F
)](https://pku-epic.github.io/TrackVLA-web/)
[![arXiv](https://img.shields.io/badge/Arxiv-%233b6291?style=flat&logoColor=%23FA7F6F
)](http://arxiv.org/abs/2505.23189)
[![Video](https://img.shields.io/badge/Video-%23c97937?style=flat&logoColor=%23FA7F6F
)](https://youtu.be/v51U3Nk-SK4?si=foz3zbYD8hLHSybC)

</div>

## 🏡 Hakkında
<strong><em>TrackVLA</em></strong>, 1.7 milyon örnekten oluşan bir veri kümesi üzerinde eğitilmiş, aynı anda nesne tanıma ve görsel takip yapabilen bir görsel-dil-eylem modelidir. Farklı zorlu ortamlarda sağlam takip, uzun vadeli takip ve alanlar arası genelleme yeteneği göstermektedir.
<div style="text-align: center;">
    <img src="https://raw.githubusercontent.com/wsakobe/TrackVLA/main/assets/teaser.png" alt="Dialogue_Teaser" width=100% >
</div>

## 📢 Haberler

* [25/07/02]: EVT-Bench artık kullanılabilir.

## 💡 Kurulum
1. **Conda ortamının hazırlanması**

   Öncelikle, [conda](https://docs.conda.io/projects/conda/en/latest/user-guide/install/) kurmanız gerekmektedir. Conda kurulduktan sonra yeni bir ortam oluşturun:
   ```bash
   conda create -n evt_bench python=3.9 cmake=3.14.0
   conda activate evt_bench
   ```

2. **Conda ile habitat-sim kurulumu**
   
   habitat-sim v0.3.1'i kurmanız gerekmektedir.
      ```
      conda install habitat-sim==0.3.1 withbullet -c conda-forge -c aihabitat
      ```

3. **habitat-lab'ı kaynaktan kurun**
      ```
      cd habitat-lab
      pip install -e habitat-lab
      ```

4. **Veri setlerini hazırlayın**

    Habitat Matterport 3D (HM3D) veri setini [buradan](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#habitat-matterport-3d-research-dataset-hm3d) ve Matterport3D (MP3D) veri setini [buradan](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#matterport3d-mp3d-dataset) indirin.

    Daha sonra veri setini `data/scene_datasets` klasörüne taşıyın. Veri setinin yapısı aşağıdaki gibi olmalıdır:
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

    Sonrasında, insansı avatarlar için verileri almak üzere aşağıdaki kodu çalıştırın:
      ```
      python download_humanoid_data.py
      ```


## 🧪 Değerlendirme
  Script'i şu şekilde çalıştırın:

    bash eval.sh

  Sonuçlar, belirtilen SAVE_PATH altında bir log dizini ve bir video dizini içerecek şekilde kaydedilecektir. Değerlendirme işlemi sırasında sonuçları izlemek için şunları çalıştırın:
    watch -n 1 python analyze_results.py --path YOUR_RESULTS_PATH

  Değerlendirmeyi durdurmak için şunu kullanın:

    bash kill_eval.sh


## 📝 YAPILACAKLAR Listesi
- [x] Mayıs 2025’te arXiv makalesini yayınla.
- [x] EVT-Bench (Embodied Visual Tracking Benchmark) yayınla.
- [ ] Büyük ölçekli embodied visual tracking veri setini yayınla.
- [ ] TrackVLA kontrol noktası ve kodunu yayınla.

## ✉️ İletişim
Herhangi bir sorunuz olursa, lütfen wangshaoan@stu.pku.edu.cn adresine e-posta göndermekten çekinmeyin. Size en kısa sürede yanıt vereceğiz.


## 🔗 Atıf
Çalışmamızın size faydalı olduğunu düşünüyorsanız, lütfen aşağıdaki şekilde atıfta bulunun:

```bibtex
@article{wang2025trackvla,
  title={Trackvla: Embodied visual tracking in the wild},
  author={Wang, Shaoan ve Zhang, Jiazhao ve Li, Minghan ve Liu, Jiahang ve Li, Anqi ve Wu, Kui ve Zhong, Fangwei ve Yu, Junzhi ve Zhang, Zhizheng ve Wang, He},
  journal={arXiv preprint arXiv:2505.23189},
  year={2025}
}
```

## 📄 Lisans
<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/80x15.png" /></a>
<br />
Bu çalışma <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Creative Commons Atıf-GayriTicari-AynıLisansla 4.0 Uluslararası Lisansı</a> altındadır.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---