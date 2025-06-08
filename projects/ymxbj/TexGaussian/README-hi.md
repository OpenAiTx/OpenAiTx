<h1 align="center">TexGaussian: ऑक्ट्री-आधारित 3D गॉसियन स्प्लैटिंग के माध्यम से उच्च-गुणवत्ता वाले PBR मटेरियल का निर्माण</h1>
<p align="center"><a href="https://arxiv.org/abs/2411.19654"><img src='https://img.shields.io/badge/arXiv-Paper-red?logo=arxiv&logoColor=white' alt='arXiv'></a>
<a href='https://3d-aigc.github.io/TexGaussian/'><img src='https://img.shields.io/badge/Project_Page-Website-green?logo=googlechrome&logoColor=white' alt='Project Page'></a>
<p align="center"><img src="assets/teaser.png" width="100%"></p>

फिज़िकली बेस्ड रेंडरिंग (PBR) मटेरियल्स आधुनिक ग्राफिक्स में एक महत्वपूर्ण भूमिका निभाते हैं, जिससे विविध पर्यावरण मैप्स में फोटोरियलिस्टिक रेंडरिंग संभव होती है। एक प्रभावी और कुशल एल्गोरिदम विकसित करना, जो 3D मेशेस के लिए केवल RGB टेक्सचर के बजाय स्वचालित रूप से उच्च-गुणवत्ता वाले PBR मटेरियल्स जेनरेट कर सके, 3D कंटेंट निर्माण को काफी हद तक सरल बना सकता है। अधिकांश मौजूदा विधियाँ मल्टी-व्यू इमेज सिंथेसिस के लिए प्री-ट्रेंड 2D डिफ्यूजन मॉडल्स का उपयोग करती हैं, जिससे अक्सर जेनरेटेड टेक्सचर्स और इनपुट 3D मेशेस के बीच गंभीर असंगति हो जाती है। यह पेपर TexGaussian प्रस्तुत करता है, जो ऑक्टेंट-अलाइन 3D गॉसियन स्प्लैटिंग का उपयोग करके तीव्र PBR मटेरियल जेनरेशन के लिए एक नवीन विधि है। विशेष रूप से, हम प्रत्येक 3D गॉसियन को इनपुट 3D मेष से निर्मित ऑक्ट्री के सबसे सूक्ष्म लीफ नोड पर रखते हैं, ताकि न केवल एल्बीडो मैप बल्कि रफनेस और मेटैलिक के लिए भी मल्टी-व्यू इमेजेस रेंडर की जा सकें। इसके अलावा, हमारा मॉडल डिफ्यूजन डिनोइज़िंग के बजाय एक रेग्रेशन तरीके से प्रशिक्षित है, जो एकल फीड-फॉरवर्ड प्रोसेस में 3D मेष के लिए PBR मटेरियल जेनरेट करने में सक्षम है। सार्वजनिक रूप से उपलब्ध बेंचमार्क्स पर व्यापक प्रयोगों से पता चलता है कि हमारी विधि बिना शर्त और टेक्स्ट-शर्त दोनों परिदृश्यों में पिछले तरीकों की तुलना में अधिक आकर्षक PBR मटेरियल्स सिंथेसाइज़ करती है और तेज़ी से चलती है, जो दिए गए ज्योमेट्री के साथ बेहतर संगति प्रदर्शित करती है।

## 📦 इंस्टॉलेशन

```bash
conda create -n texgaussian python==3.10
pip3 install torch==2.1.0 torchvision==0.16.0 torchaudio==2.1.0 --index-url https://download.pytorch.org/whl/cu118

# एक संशोधित गॉसियन स्प्लैटिंग (+ डेप्थ, अल्फा रेंडरिंग)
git clone --recursive https://github.com/ashawkey/diff-gaussian-rasterization

pip3 install ./diff-gaussian-rasterization

pip3 install git+https://github.com/NVlabs/nvdiffrast

# अन्य डिपेंडेंसीज़
pip3 install -r requirements.txt
```

## 🤖 प्रीट्रेंड मॉडल्स

हम निम्नलिखित प्रीट्रेंड मॉडल्स प्रदान करते हैं:

| मॉडल | विवरण | पैरामीटर्स | डाउनलोड |
| --- | --- | --- | --- |
| TexGaussian-bench | ShapeNet बेंच पर प्रशिक्षित बिना शर्त RGB टेक्सचर मॉडल | 70M | [डाउनलोड करें](https://huggingface.co/ymxbj/TexGaussian/resolve/main/bench.safetensors?download=true) |
| TexGaussian-car | ShapeNet कार पर प्रशिक्षित बिना शर्त RGB टेक्सचर मॉडल | 70M | [डाउनलोड करें](https://huggingface.co/ymxbj/TexGaussian/resolve/main/car.safetensors?download=true) |
| TexGaussian-chair | ShapeNet चेयर पर प्रशिक्षित बिना शर्त RGB टेक्सचर मॉडल | 70M | [डाउनलोड करें](https://huggingface.co/ymxbj/TexGaussian/resolve/main/chair.safetensors?download=true) |
| TexGaussian-table | ShapeNet टेबल पर प्रशिक्षित बिना शर्त RGB टेक्सचर मॉडल | 70M | [डाउनलोड करें](https://huggingface.co/ymxbj/TexGaussian/resolve/main/table.safetensors?download=true) |
| TexGaussian-PBR | Objaverse पर प्रशिक्षित टेक्स्ट-शर्त PBR मटेरियल मॉडल | 295M | [डाउनलोड करें](https://huggingface.co/ymxbj/TexGaussian/resolve/main/PBR_model.safetensors?download=true) |

## 💡 इनफेरेंस

### PBR मटेरियल
टेक्स्ट-शर्त PBR मटेरियल निर्माण के लिए, चलाएँ
```bash
bash inference_for_PBR_material.sh
```
टेक्सचर और मटेरियल बेकिंग के बाद, आपको दो मैप्स मिलेंगे, एक एल्बीडो मैप और दूसरा PBR मटेरियल मैप। विशेष रूप से, PBR मटेरियल मैप में तीन चैनल होते हैं, जहाँ ग्रीन चैनल रफनेस वैल्यू और ब्लू चैनल मेटैलिक वैल्यू को दर्शाता है। जेनरेटेड टेक्सचर और मटेरियल मैप्स की PBR रेंडरिंग करने के लिए, हम bpy द्वारा लिखित [इस रेंडरिंग स्क्रिप्ट](https://github.com/ymxbj/BlenderToolboxPBR) का उपयोग करने की सलाह देते हैं।

साथ ही, हम सभी को Cap3D डेटासेट के टेक्स्ट की शैली की नकल करने और बेहतर निर्माण परिणामों के लिए अपने स्वयं के प्रॉम्प्ट्स बनाने की सलाह देते हैं। Cap3D डेटासेट [यहाँ](https://huggingface.co/ymxbj/TexGaussian/resolve/main/Cap3D_automated_Objaverse_full.csv?download=true) डाउनलोड किया जा सकता है।

### RGB टेक्सचर
बिना शर्त RGB टेक्सचर निर्माण के लिए, जो केवल विशेष 4 श्रेणियों: बेंच, कार, चेयर, टेबल के लिए काम करता है, चलाएँ
```bash
bash inference_for_RGB_texture.sh
```
टेक्सचर बेकिंग के बाद, आपको एक एल्बीडो मैप मिलेगा।

## 🏋️‍♂️ प्रशिक्षण
Objaverse के लिए:
```bash
bash train_for_objaverse.sh
```

ShapeNet के लिए:
```bash
bash train_for_shapenet.sh
```

## 🚧 TODO
- [x] प्रशिक्षण और इनफेरेंस कोड रिलीज़ करें
- [x] ShapeNet डेटासेट पर बिना शर्त केवल एल्बीडो प्री-ट्रेंड मॉडल रिलीज़ करें
- [x] Objaverse डेटासेट पर टेक्स्ट-शर्त PBR प्री-ट्रेंड मॉडल रिलीज़ करें
- [ ] डेटासेट और डेटासेट टूलकिट्स रिलीज़ करें

## 📚आभार

यह कार्य कई अद्भुत शोध कार्यों और ओपन-सोर्स परियोजनाओं पर आधारित है, सभी लेखकों का साझा करने के लिए बहुत-बहुत धन्यवाद!

- [gaussian-splatting](https://github.com/graphdeco-inria/gaussian-splatting) और [diff-gaussian-rasterization](https://github.com/graphdeco-inria/diff-gaussian-rasterization)
- [nvdiffrast](https://github.com/NVlabs/nvdiffrast)
- [LGM](https://github.com/3DTopia/LGM)
- [ocnn-pytorch](https://github.com/octree-nn/ocnn-pytorch)

<!-- Citation -->
## 📜 संदर्भ

यदि आपको यह कार्य उपयोगी लगे, तो कृपया हमारे पेपर का संदर्भ दें:

1. arXiv संस्करण
```bibtex
@article{xiong2024texgaussian,
  title={TexGaussian: Generating High-quality PBR Material via Octree-based 3D Gaussian Splatting},
  author={Xiong, Bojun and Liu, Jialun and Hu, Jiakui and Wu, Chenming and Wu, Jinbo and Liu, Xing and Zhao, Chen and Ding, Errui and Lian, Zhouhui},
  journal={arXiv preprint arXiv:2411.19654},
  year={2024}
}
```

2. CVPR संस्करण
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