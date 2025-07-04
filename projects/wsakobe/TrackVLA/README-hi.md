<p align="center">
<h1 align="center"><strong>TrackVLA: जंगली परिवेश में इम्बॉडिड विजुअल ट्रैकिंग</strong></h1>
  <p align="center">
    <!--   	<strong>CoRL 2025</strong><br> -->
    <a href='https://wsakobe.github.io/' target='_blank'>शाओआन वांग</a>&emsp;
	<a href='https://jzhzhang.github.io/' target='_blank'>जियाझाओ झांग</a>&emsp;
    मिंगहान ली&emsp;
    जियाहांग लियू&emsp;
    अनकी ली&emsp; <br>
    कुई वू&emsp;
    <a href='https://fangweizhong.xyz/' target='_blank'>फांगवेई झोंग</a>&emsp;
    <a href='https://www.coe.pku.edu.cn/teaching/manufacturing/9993.html' target='_blank'>जुनझी यू</a>&emsp;
	<a href='https://scholar.google.com/citations?user=X7M0I8kAAAAJ&hl=zh-CN' target='_blank'>झिज़्हेंग झांग</a>&emsp;
  <a href='https://hughw19.github.io/' target='_blank'>हे वांग</a>&emsp;
    <br>
    पेकिंग विश्वविद्यालय&emsp; 
    गैलबोट&emsp; <br>
    बेहांग विश्वविद्यालय&emsp;
    बीजिंग नार्मल विश्वविद्यालय&emsp;
    बीजिंग अकादमी ऑफ आर्टिफिशियल इंटेलिजेंस&emsp;
    <br>
  </p>
</p>

<div id="top" align="center">

[![Project](https://img.shields.io/badge/Project-%239c403d?style=flat&logoColor=%23FA7F6F
)](https://pku-epic.github.io/TrackVLA-web/)
[![arXiv](https://img.shields.io/badge/Arxiv-%233b6291?style=flat&logoColor=%23FA7F6F
)](http://arxiv.org/abs/2505.23189)
[![Video](https://img.shields.io/badge/Video-%23c97937?style=flat&logoColor=%23FA7F6F
)](https://youtu.be/v51U3Nk-SK4?si=foz3zbYD8hLHSybC)

</div>

## 🏡 परिचय
<strong><em>TrackVLA</em></strong> एक विज़न-लैंग्वेज-एक्शन मॉडल है जो एक साथ ऑब्जेक्ट की पहचान और विज़ुअल ट्रैकिंग में सक्षम है, जिसे 1.7 मिलियन सैंपल्स के डाटासेट पर प्रशिक्षित किया गया है। यह विविध और चुनौतीपूर्ण परिवेशों में मजबूत ट्रैकिंग, दीर्घकालिक ट्रैकिंग, और क्रॉस-डोमेन जेनेरलाइजेशन का प्रदर्शन करता है।
<div style="text-align: center;">
    <img src="https://raw.githubusercontent.com/wsakobe/TrackVLA/main/assets/teaser.png" alt="Dialogue_Teaser" width=100% >
</div>

## 📢 समाचार

* [25/07/02]: EVT-बेंच अब उपलब्ध है।

## 💡 इंस्टॉलेशन
1. **conda पर्यावरण तैयार करना**

   सबसे पहले, आपको [conda](https://docs.conda.io/projects/conda/en/latest/user-guide/install/) इंस्टॉल करना होगा। एक बार conda इंस्टॉल हो जाए, तो एक नया पर्यावरण बनाएं:
   ```bash
   conda create -n evt_bench python=3.9 cmake=3.14.0
   conda activate evt_bench
   ```

2. **conda द्वारा habitat-sim इंस्टॉल करें**
   
   आपको habitat-sim v0.3.1 इंस्टॉल करना होगा
      ```
      conda install habitat-sim==0.3.1 withbullet -c conda-forge -c aihabitat
      ```

3. **सोर्स से habitat-lab इंस्टॉल करें**
      ```
      cd habitat-lab
      pip install -e habitat-lab
      ```

4. **डाटासेट तैयार करें**

    [यहाँ](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#habitat-matterport-3d-research-dataset-hm3d) से Habitat Matterport 3D (HM3D) डाटासेट और [यहाँ](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#matterport3d-mp3d-dataset) से Matterport3D (MP3D) डाटासेट डाउनलोड करें।

    फिर डाटासेट को `data/scene_datasets` में स्थानांतरित करें। डाटासेट की संरचना इस प्रकार है:
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

    अगला, निम्नलिखित कोड चलाकर ह्यूमनोइड अवतारों के लिए डाटा प्राप्त करें:
      ```
      python download_humanoid_data.py
      ```


## 🧪 मूल्यांकन
  स्क्रिप्ट को निम्नलिखित के साथ चलाएँ:

    bash eval.sh

  परिणाम निर्दिष्ट SAVE_PATH में सेव होंगे, जिसमें एक लॉग डायरेक्टरी और एक वीडियो डायरेक्टरी शामिल होगी। मूल्यांकन प्रक्रिया के दौरान परिणामों की निगरानी के लिए, चलाएँ:
    watch -n 1 python analyze_results.py --path YOUR_RESULTS_PATH

  मूल्यांकन रोकने के लिए, उपयोग करें:

    bash kill_eval.sh


## 📝 TODO सूची
- [x] मई, 2025 में arXiv पेपर जारी करें।
- [x] EVT-Bench (Embodied Visual Tracking Benchmark) जारी करें।
- [ ] बड़े पैमाने पर embodied visual tracking डेटासेट जारी करें।
- [ ] TrackVLA का चेकपॉइंट और कोड जारी करें।

## ✉️ संपर्क
यदि आपके कोई प्रश्न हैं, तो कृपया बेझिझक wangshaoan@stu.pku.edu.cn पर ईमेल करें। हम जल्द से जल्द इसका उत्तर देंगे।


## 🔗 उद्धरण
यदि आपको हमारा कार्य उपयोगी लगे, तो कृपया इसे निम्न प्रकार से उद्धृत करने पर विचार करें:

```bibtex
@article{wang2025trackvla,
  title={Trackvla: Embodied visual tracking in the wild},
  author={Wang, Shaoan and Zhang, Jiazhao and Li, Minghan and Liu, Jiahang and Li, Anqi and Wu, Kui and Zhong, Fangwei and Yu, Junzhi and Zhang, Zhizheng and Wang, He},
  journal={arXiv preprint arXiv:2505.23189},
  year={2025}
}
```

## 📄 लाइसेंस
<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/80x15.png" /></a>
<br />
यह कार्य <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License</a> के अंतर्गत है।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---