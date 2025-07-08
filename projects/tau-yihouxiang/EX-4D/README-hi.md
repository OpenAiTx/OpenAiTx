# EX-4D: डेप्थ वॉटरटाइट मेष के माध्यम से एक्स्ट्रीम व्यूपॉइंट 4D वीडियो सिंथेसिस

<div align="center">

<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/Logo.png" alt="EX-4D Logo" width="250">

[📄 पेपर](https://arxiv.org/abs/2506.05554)  |  [🎥 होमपेज](https://tau-yihouxiang.github.io/projects/EX-4D/EX-4D.html)  |  [💻 कोड](https://github.com/tau-yihouxiang/EX-4D)

</div>



## 🌟 मुख्य विशेषताएँ

- **🎯 एक्स्ट्रीम व्यूपॉइंट सिंथेसिस**: कैमरा मूवमेंट्स के साथ -90° से 90° तक की सीमा में उच्च गुणवत्ता वाले 4D वीडियो जनरेट करें
- **🔧 डेप्थ वॉटरटाइट मेष**: नवीन ज्यामितीय प्रतिनिधित्व जो दृश्यमान और अस्पष्ट (ओक्लूडेड) दोनों क्षेत्रों को मॉडल करता है
- **⚡ हल्का आर्किटेक्चर**: वीडियो डिफ्यूजन बैकबोन (14B) के केवल 1% ट्रेन करने योग्य पैरामीटर (140M)
- **🎭 मल्टी-व्यू ट्रेनिंग की आवश्यकता नहीं**: अभिनव मास्किंग रणनीति महंगे मल्टी-व्यू डेटासेट्स की आवश्यकता को समाप्त करती है
- **🏆 स्टेट-ऑफ-द-आर्ट प्रदर्शन**: मौजूदा तरीकों से बेहतर, विशेष रूप से अत्यधिक कैमरा कोणों पर

## 🎬 डेमो परिणाम

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/teaser.png" alt="EX-4D Demo Results" width="800">
</div>

*EX-4D एकल कैमरा (मोनोक्यूलर) वीडियो को कैमरा-कंट्रोल योग्य 4D अनुभवों में बदलता है, जो एक्स्ट्रीम व्यूपॉइंट्स पर भी भौतिक रूप से संगत परिणाम देता है।*

## 🏗️ फ्रेमवर्क अवलोकन

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/overview.png" alt="EX-4D Architecture">
</div>

हमारे फ्रेमवर्क में तीन प्रमुख घटक शामिल हैं:

1. **🔺 डेप्थ वॉटरटाइट मेष निर्माण**: एक मजबूत ज्यामितीय प्रायर बनाता है, जो स्पष्ट रूप से दृश्यमान और ओक्लूडेड दोनों क्षेत्रों को मॉडल करता है
2. **🎭 सिम्युलेटेड मास्किंग रणनीति**: मोनोक्यूलर वीडियो से प्रभावी ट्रेनिंग डेटा बनाता है, मल्टी-व्यू डेटासेट्स की आवश्यकता नहीं
3. **⚙️ हल्का LoRA एडैप्टर**: ज्यामितीय जानकारी को प्री-ट्रेंड वीडियो डिफ्यूजन मॉडल्स के साथ कुशलता से एकीकृत करता है

## 🚀 त्वरित प्रारंभ

### इंस्टॉलेशन

```bash
# रिपॉजिटरी क्लोन करें
git clone https://github.com/tau-yihouxiang/EX-4D.git
cd EX-4D

# कॉन्डा एनवायरनमेंट बनाएं
conda create -n ex4d python=3.10
conda activate ex4d
# PyTorch (2.x अनुशंसित) इंस्टॉल करें
pip install torch==2.4.1 torchvision==0.19.1 torchaudio==2.4.1 --index-url https://download.pytorch.org/whl/cu124
# Nvdiffrast इंस्टॉल करें
pip install git+https://github.com/NVlabs/nvdiffrast.git
# डिपेंडेंसीज़ और diffsynth इंस्टॉल करें
pip install -e .
# डेप्थ एस्टीमेशन के लिए depthcrafter इंस्टॉल करें। (चेकपॉइंट्स की तैयारी के लिए DepthCrafter की इंस्टॉलिंग निर्देशों का पालन करें।)
git clone https://github.com/Tencent/DepthCrafter.git
```

### प्रीट्रेंड मॉडल डाउनलोड करें
```bash
huggingface-cli download Wan-AI/Wan2.1-I2V-14B-480P --local-dir ./models/Wan-AI
huggingface-cli download yihouxiang/EX-4D --local-dir ./models/EX-4D
```

### उदाहरण उपयोग
#### 1. DW-Mesh पुनर्निर्माण
```bash
# --cam 180 (30 / 60 / 90 / zoom_in / zoom_out )
python recon.py --input_video examples/flower/input.mp4 --cam 180 --output_dir outputs/flower --save_mesh
```
#### 2. EX-4D जनरेशन (48GB VRAM आवश्यक)
```bash
python generate.py --color_video outputs/flower/color_180.mp4 --mask_video outputs/flower/mask_180.mp4 --output_video outputs/flower/output.mp4
```

<table>
<tr>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/input.gif" width="100%">
<br><b>इनपुट वीडियो</b>
</td>
<td align="center">
<div style="font-size: 2em; color: #4A90E2; padding: 0 0px;">
  ➜
</div>
</td>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/output.gif" width="100%">
<br><b>आउटपुट वीडियो</b>
</td>
</tr> 
</table>

<!-- ## 📊 Performance

### Quantitative Results
| विधि | FID (एक्सट्रीम) ↓ | FVD (एक्सट्रीम) ↓ | VBench स्कोर ↑ |
|--------|-----------------|-----------------|----------------|
| ReCamMaster | 64.68 | 943.45 | 0.434 |
| TrajectoryCrafter | 65.33 | 893.80 | 0.447 |
| TrajectoryAttention | 62.49 | 912.14 | 0.389 |
| **EX-4D (हमारा)** | **55.42** | **823.61** | **0.450** | -->

### उपयोगकर्ता अध्ययन परिणाम

- **70.7%** प्रतिभागियों ने बेसलाइन विधियों की तुलना में EX-4D को पसंद किया
- भौतिक संगति और चरम व्यूपॉइंट गुणवत्ता में श्रेष्ठ प्रदर्शन
- जैसे-जैसे कैमरा कोण अधिक चरम होते हैं, महत्वपूर्ण सुधार

## 🎯 अनुप्रयोग

- **🎮 गेमिंग**: 2D फुटेज से इमर्सिव 3D गेम सिनेमैटिक्स बनाएं
- **🎬 फिल्म निर्माण**: पोस्ट-प्रोडक्शन के लिए नए कैमरा एंगल्स उत्पन्न करें
- **🥽 VR/AR**: फ्री-व्यूपॉइंट वीडियो अनुभव बनाएं
- **📱 सोशल मीडिया**: कंटेंट क्रिएशन के लिए डायनामिक कैमरा मूवमेंट्स उत्पन्न करें
- **🏢 वास्तुकला**: कई व्यूपॉइंट्स से स्पेस का विज़ुअलाइज़ेशन करें

<!-- ## 📈 बेंचमार्क्स -->

<!-- ### व्यूपॉइंट रेंज मूल्यांकन

| रेंज | छोटा (0°→30°) | बड़ा (0°→60°) | एक्सट्रीम (0°→90°) | पूर्ण (-90°→90°) |
|-------|----------------|----------------|------------------|-----------------|
| FID स्कोर | 44.19 | 50.30 | 55.42 | - |
| प्रदर्शन अंतर | +9.1% बेहतर | +8.9% बेहतर | +11.3% बेहतर | +15.5% बेहतर | -->

<!-- *प्रत्येक श्रेणी में दूसरे सर्वश्रेष्ठ विधि की तुलना में प्रदर्शन अंतर।* -->

## ⚠️ सीमाएँ

- **गहराई निर्भरता**: प्रदर्शन मोनो큅्युलर डेप्थ एस्टीमेशन की गुणवत्ता पर निर्भर करता है
- **गणनात्मक लागत**: उच्च-रिज़ॉल्यूशन वीडियो के लिए पर्याप्त गणना की आवश्यकता होती है
- **परावर्तक सतहें**: परावर्तक या पारदर्शी सामग्रियों के साथ चुनौतियाँ

## 🔮 भविष्य का कार्य
- [ ] रीयल-टाइम इन्फरेंस अनुकूलन (3DGS / 4DGS)
- [ ] उच्च रिज़ॉल्यूशन (1K, 2K) के लिए समर्थन
- [ ] न्यूरल मेष परिष्करण तकनीकें

## 🙏 आभार

हम [DiffSynth-Studio v1.1.1](https://github.com/modelscope/DiffSynth-Studio/tree/v1.1.1) परियोजना को आधारभूत डिफ्यूजन फ्रेमवर्क प्रदान करने के लिए धन्यवाद देना चाहते हैं।

## 📚 संदर्भ

यदि आपको हमारा कार्य उपयोगी लगे, तो कृपया इसे उद्धृत करने पर विचार करें:

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