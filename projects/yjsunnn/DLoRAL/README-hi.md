<div align="center">
<h2>डिटेल-रिच और टेम्पोरली कंसिस्टेंट वीडियो सुपर-रिज़ॉल्यूशन के लिए वन-स्टेप डिफ्यूजन</h2>

[Yujing Sun](https://yjsunnn.github.io/)<sup>1,2, *</sup> | 
[Lingchen Sun](https://scholar.google.com/citations?hl=zh-CN&tzom=-480&user=ZCDjTn8AAAAJ)<sup>1,2, *</sup> | 
[Shuaizheng Liu](https://scholar.google.com/citations?user=wzdCc-QAAAAJ&hl=en)<sup>1,2</sup> | 
[Rongyuan Wu](https://scholar.google.com/citations?user=A-U8zE8AAAAJ&hl=zh-CN)<sup>1,2</sup> | 
[Zhengqiang Zhang](https://scholar.google.com.tw/citations?user=UX26wSMAAAAJ&hl=en)<sup>1,2</sup> | 
[Lei Zhang](https://www4.comp.polyu.edu.hk/~cslzhang)<sup>1,2</sup>

<sup>1</sup>द हॉन्ग कॉन्ग पॉलिटेक्निक यूनिवर्सिटी, <sup>2</sup>ओप्पो रिसर्च इंस्टीट्यूट
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

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/visual_results.svg" alt="विज़ुअल रिजल्ट्स">

</p>
## ⏰ अपडेट

- **2025.07.08**: इनफेरेंस कोड और प्री-ट्रेंड वेट्स उपलब्ध हैं।
- **2025.06.24**: प्रोजेक्ट पेज उपलब्ध है, जिसमें एक संक्षिप्त 2-मिनट का व्याख्यात्मक वीडियो, अधिक विजुअल परिणाम और संबंधित शोध शामिल हैं।
- **2025.06.17**: रिपॉजिटरी जारी कर दी गई है।

:star: यदि DLoRAL आपके वीडियो या प्रोजेक्ट्स के लिए उपयोगी है, तो कृपया इस रिपो को स्टार करें। धन्यवाद! :hugs:

😊 आप हमारे संबंधित कार्य भी देख सकते हैं:

1. **OSEDiff (NIPS2024)** [पेपर](https://arxiv.org/abs/2406.08177) | [कोड](https://github.com/cswry/OSEDiff/)  

   रियल-टाइम इमेज एसआर एल्गोरिदम जिसे OPPO Find X8 सीरीज में लागू किया गया है।

2. **PiSA-SR (CVPR2025)** [पेपर](https://arxiv.org/pdf/2412.03017) | [कोड](https://github.com/csslc/PiSA-SR) 

   इमेज एसआर में ड्यूल-लोरा पैरेडाइम की अग्रणी खोज।

3. **Awesome Diffusion Models for Video Super-Resolution** [रिपो](https://github.com/yjsunnn/Awesome-video-super-resolution-diffusion)

   डिफ्यूजन मॉडल्स का उपयोग करके वीडियो सुपर-रिज़ॉल्यूशन (VSR) के लिए संसाधनों की एक क्यूरेटेड सूची।
## 👀 TODO
- [x] इनफेरेंस कोड जारी करें।
- [ ] सुविधाजनक परीक्षण के लिए कोलैब और हगिंगफेस UI (जल्द आ रहा है!).
- [ ] प्रशिक्षण कोड जारी करें।
- [ ] प्रशिक्षण डेटा जारी करें।


## 🌟 अवलोकन फ्रेमवर्क

<p align="center">

<img src="https://raw.githubusercontent.com/yjsunnn/DLoRAL/main/assets/pipeline.svg" alt="DLoRAL Framework">

</p>

**प्रशिक्षण**: एक डायनेमिक ड्यूल-स्टेज प्रशिक्षण योजना, टेम्पोरल कोहेरेंस (कंसिस्टेंसी स्टेज) को ऑप्टिमाइज़ करने और उच्च-आवृत्ति स्पैटियल डिटेल्स (एनहांसमेंट स्टेज) को परिष्कृत करने के बीच बारी-बारी से काम करती है, जिससे स्थिरता सुनिश्चित करने के लिए स्मूथ लॉस इंटरपोलेशन होता है।

**इनफेरेंस**: इनफेरेंस के दौरान, C-LoRA और D-LoRA दोनों को फ्रीज़ किए गए डिफ्यूजन UNet में मर्ज कर दिया जाता है, जिससे कम गुणवत्ता वाले इनपुट्स को उच्च गुणवत्ता वाले आउटपुट्स में एक ही चरण में सुधारा जा सकता है।
## 🔧 डिपेंडेंसीज़ और इंस्टॉलेशन

1. रेपो क्लोन करें
    ```bash
    git clone https://github.com/yjsunnn/DLoRAL.git
    cd DLoRAL
    ```

2. डिपेंडेंट पैकेज इंस्टॉल करें
    ```bash
    conda create -n DLoRAL python=3.10 -y
    conda activate DLoRAL
    pip install -r requirements.txt
    ```

3. मॉडल डाउनलोड करें 
#### डिपेंडेंट मॉडल्स
* [SD21 Base](https://huggingface.co/stabilityai/stable-diffusion-2-1-base) --> **/path/to/DLoRAL/preset_models/stable-diffusion-2-1-base** में रखें
* [Bert-Base](https://huggingface.co/google-bert/bert-base-uncased) --> **/path/to/DLoRAL/preset_models/bert-base-uncased** में रखें
* [RAM](https://huggingface.co/spaces/xinyu1205/recognize-anything/blob/main/ram_swin_large_14m.pth) --> **/path/to/DLoRAL/preset/models/ram_swin_large_14m.pth** में रखें
* [DAPE](https://drive.google.com/file/d/1KIV6VewwO2eDC9g4Gcvgm-a0LDI7Lmwm/view?usp=drive_link) --> **/path/to/DLoRAL/preset/models/DAPE.pth** में रखें
* [Pretrained Weights](https://drive.google.com/file/d/1vpcaySpRx_K-tXq2D2EBqFZ-03Foky8G/view?usp=sharing) --> **/path/to/DLoRAL/preset/models/checkpoints/model.pkl** में रखें

प्रत्येक पथ को अपनी आवश्यकताओं के अनुसार बदला जा सकता है, और कमांड लाइन तथा कोड में भी उपयुक्त परिवर्तन किए जाने चाहिए।
## 🖼️ त्वरित अनुकरण
वास्तविक दुनिया के वीडियो सुपर-रिज़ॉल्यूशन के लिए:

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
### उद्धरण
यदि हमारा कोड आपके शोध या कार्य में सहायक है, तो कृपया हमारे पेपर का उल्लेख करें।
निम्नलिखित BibTeX संदर्भ हैं:

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