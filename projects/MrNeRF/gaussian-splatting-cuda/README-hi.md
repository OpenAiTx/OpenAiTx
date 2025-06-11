# रियल-टाइम रेडियंस फील्ड रेंडरिंग के लिए 3D Gaussian Splatting - C++ और CUDA इम्प्लीमेंटेशन

[![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/TbxJST2BbC)  
[![Website](https://img.shields.io/badge/Website-mrnerf.com-blue)](https://mrnerf.com)  
[![Papers](https://img.shields.io/badge/Papers-Awesome%203DGS-orange)](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)

3D Gaussian Splatting का एक उच्च-प्रदर्शन C++ और CUDA इम्प्लीमेंटेशन, जो [gsplat](https://github.com/nerfstudio-project/gsplat) रैस्टराइज़ेशन बैकएंड पर आधारित है।

## समाचार
- **[2025-06-10]**: कुछ समस्याओं को ठीक किया गया। हम gsplat मेट्रिक्स के करीब आ रहे हैं। हालांकि, अभी भी थोड़ा अंतर है।
- **[2025-06-04]**: `--max-cap` कमांड लाइन विकल्प के साथ MCMC रणनीति जोड़ी गई है, जो अधिकतम Gaussian की संख्या नियंत्रित करता है।
- **[2025-06-03]**: Gsplat बैकएंड पर स्विच किया गया और लाइसेंस अपडेट किया गया।
- **[2024-05-27]**: बेहतर संगतता और प्रदर्शन के लिए LibTorch 2.7.0 में अपडेट किया गया। ऑप्टिमाइज़र स्टेट प्रबंधन में ब्रेकिंग चेंजेस को ठीक किया गया।
- **[2024-05-26]**: इस रिपॉजिटरी का वर्तमान लक्ष्य एक परमिसिव लाइसेंस की ओर बढ़ना है। रैस्टराइज़र को gsplat इम्प्लीमेंटेशन से बदलने के लिए महत्वपूर्ण कार्य किया गया है।

## मेट्रिक्स
वर्तमान में यह इम्प्लीमेंटेशन gsplat-mcmc के बराबर परिणाम नहीं देता, लेकिन यह विकासाधीन है।  
यह बस एक बग को ठीक करने का समय है। सहायता का स्वागत है :) MCMC रणनीति के लिए मेट्रिक्स निम्नलिखित हैं:

| सीन      | इटरेशन  | PSNR          | SSIM         | LPIPS        | प्रति छवि समय | Gaussian की संख्या |
| -------- | -------- | ------------- | ------------ | ------------ | -------------- | ----------------- |
| garden   | 30000    | 27.112114     | 0.854833     | 0.157624     | 0.304765       | 1000000           |
| bicycle  | 30000    | 25.047745     | 0.767729     | 0.254825     | 0.293618       | 1000000           |
| stump    | 30000    | 26.554749     | 0.784203     | 0.263013     | 0.296536       | 1000000           |
| bonsai   | 30000    | 32.534199     | 0.948675     | 0.246924     | 0.436188       | 1000000           |
| counter  | 30000    | 29.187017     | 0.915823     | 0.242159     | 0.441259       | 1000000           |
| kitchen  | 30000    | 31.680832     | 0.933897     | 0.154965     | 0.449078       | 1000000           |
| room     | 30000    | 32.211632     | 0.930754     | 0.273719     | 0.413519       | 1000000           |
| **औसत** | **30000**| **29.189755** | **0.876559** | **0.227604** | **0.376423**   | **1000000**       |

## समुदाय और समर्थन

हमारे बढ़ते समुदाय में शामिल हों चर्चा, समर्थन, और अपडेट के लिए:  
- 💬 **[Discord Community](https://discord.gg/TbxJST2BbC)** - सहायता प्राप्त करें, परिणाम साझा करें, और विकास पर चर्चा करें  
- 🌐 **[mrnerf.com](https://mrnerf.com)** - अधिक संसाधनों के लिए हमारी वेबसाइट देखें  
- 📚 **[Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)** - व्यापक पेपर सूची और संसाधन  
- 🐦 **[@janusch_patas](https://twitter.com/janusch_patas)** - नवीनतम अपडेट के लिए फ़ॉलो करें  

## बिल्ड और निष्पादन निर्देश

### सॉफ़्टवेयर आवश्यकताएँ
1. **Linux** (Ubuntu 22.04 पर परीक्षण किया गया) - वर्तमान में Windows समर्थित नहीं है  
2. **CMake** 3.24 या उच्चतर  
3. **CUDA** 11.8 या उच्चतर (कम संस्करणों पर मैनुअल कॉन्फ़िगरेशन के साथ काम कर सकता है)  
4. **Python** विकास हेडर के साथ  
5. **LibTorch 2.7.0** - सेटअप निर्देश नीचे दिए गए हैं  
6. अन्य निर्भरताएँ CMake द्वारा स्वचालित रूप से संभाली जाती हैं  

### हार्डवेयर आवश्यकताएँ
1. **NVIDIA GPU** CUDA समर्थन के साथ  
    - सफलतापूर्वक परीक्षण किया गया: RTX 4090, RTX A5000, RTX 3090Ti, A100  
    - बड़े डेटासेट पर RTX 3080Ti के साथ ज्ञात समस्या (देखें #21)  
2. न्यूनतम कंप्यूट क्षमता: 8.0  

> यदि आप अन्य हार्डवेयर पर सफलतापूर्वक चला पाते हैं, तो कृपया अपने अनुभव को Discussions सेक्शन में साझा करें!

### बिल्ड निर्देश

```bash
# सबमॉड्यूल के साथ रिपॉजिटरी क्लोन करें
git clone --recursive https://github.com/MrNeRF/gaussian-splatting-cuda
cd gaussian-splatting-cuda

# LibTorch डाउनलोड और सेटअप करें
wget https://raw.githubusercontent.com/MrNeRF/gaussian-splatting-cuda/master/libtorch-cxx11-abi-shared-with-deps-2.7.0%2Bcu118.zip  
unzip libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip -d external/
rm libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip

# प्रोजेक्ट बिल्ड करें
cmake -B build -DCMAKE_BUILD_TYPE=Release
cmake --build build -- -j
```

## LibTorch 2.7.0

यह प्रोजेक्ट बेहतर प्रदर्शन और संगतता के लिए **LibTorch 2.7.0** का उपयोग करता है:

- **बेहतर प्रदर्शन**: ऑप्टिमाइजेशन और मेमोरी प्रबंधन में सुधार  
- **API स्थिरता**: नवीनतम स्थिर PyTorch C++ API  
- **CUDA संगतता**: CUDA 11.8+ के साथ बेहतर इंटीग्रेशन  
- **बग फिक्स**: ऑप्टिमाइज़र स्टेट प्रबंधन की समस्याएं हल की गईं  

### पिछले संस्करण से अपग्रेड करना
1. बिल्ड निर्देशों का उपयोग कर नया LibTorch संस्करण डाउनलोड करें  
2. अपनी बिल्ड डायरेक्टरी साफ़ करें: `rm -rf build/`  
3. प्रोजेक्ट को पुनः बिल्ड करें  

## डेटासेट

मूल रिपॉजिटरी से डेटासेट डाउनलोड करें:  
[Tanks & Trains Dataset](https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/datasets/input/tandt_db.zip)  

इसे प्रोजेक्ट रूट में `data` फ़ोल्डर में एक्सट्रैक्ट करें।

## कमांड-लाइन विकल्प

### मुख्य विकल्प

- **`-h, --help`**  
  हेल्प मेनू दिखाएं  

- **`-d, --data-path [PATH]`**  
  प्रशिक्षण डेटा का पथ (अनिवार्य)  

- **`-o, --output-path [PATH]`**  
  प्रशिक्षित मॉडल को सेव करने का पथ (डिफ़ॉल्ट: `./output`)  

- **`-i, --iter [NUM]`**  
  प्रशिक्षण इटरेशन की संख्या (डिफ़ॉल्ट: 30000)  
    - पेपर में 30k सुझाया गया है, लेकिन 6k-7k अक्सर अच्छे प्रारंभिक परिणाम देते हैं  
    - आउटपुट हर 7k इटरेशन पर और समाप्ति पर सेव होते हैं  

- **`-f, --force`**  
  मौजूदा आउटपुट फ़ोल्डर को जबरदस्ती ओवरराइट करें  

- **`-r, --resolution [NUM]`**  
  प्रशिक्षण छवियों के लिए रिज़ॉल्यूशन सेट करें  

### MCMC-विशिष्ट विकल्प

- **`--max-cap [NUM]`**  
  MCMC रणनीति के लिए अधिकतम Gaussian की संख्या (डिफ़ॉल्ट: 1000000)  
    - प्रशिक्षण के दौरान Gaussian splats की अधिकतम सीमा नियंत्रित करता है  
    - मेमोरी सीमित वातावरण के लिए उपयोगी  

### उदाहरण उपयोग

मूल प्रशिक्षण:  
```bash
./build/gaussian_splatting_cuda -d /path/to/data -o /path/to/output -i 10000
```

सीमित Gaussian के साथ MCMC प्रशिक्षण:  
```bash
./build/gaussian_splatting_cuda -d /path/to/data -o /path/to/output -i 10000 --max-cap 500000
```

## योगदान दिशा-निर्देश

हम योगदान का स्वागत करते हैं! शुरुआत कैसे करें:

1. **शुरुआत करें**:  
    - शुरुआती के लिए उपयुक्त कार्यों के लिए **good first issues** लेबल वाली इश्यू देखें  
    - नए विचारों के लिए, एक चर्चा खोलें या हमारे [Discord](https://discord.gg/TbxJST2BbC) से जुड़ें  

2. **PR जमा करने से पहले**:  
    - सुसंगत कोड स्टाइल के लिए `clang-format` लागू करें  
    - प्री-कमिट हुक का उपयोग करें: `cp tools/pre-commit .git/hooks/`  
    - नई निर्भरताओं पर चर्चा पहले एक इश्यू में करें - हम निर्भरताओं को कम रखने का प्रयास करते हैं  

## आभार

यह इम्प्लीमेंटेशन कई प्रमुख परियोजनाओं पर आधारित है:

- **[gsplat](https://github.com/nerfstudio-project/gsplat)**: हम gsplat के अत्यधिक अनुकूलित CUDA रैस्टराइज़ेशन बैकएंड का उपयोग करते हैं, जो प्रदर्शन सुधार और बेहतर मेमोरी दक्षता प्रदान करता है।  
- **मूल 3D Gaussian Splatting**: Kerbl et al. के क्रांतिकारी कार्य पर आधारित।  

## उद्धरण

यदि आप इस सॉफ़्टवेयर का उपयोग अपने शोध में करते हैं, तो कृपया मूल कार्य का संदर्भ दें:

```bibtex
@article{kerbl3Dgaussians,
  author    = {Kerbl, Bernhard and Kopanas, Georgios and Leimkühler, Thomas and Drettakis, George},
  title     = {3D Gaussian Splatting for Real-Time Radiance Field Rendering},
  journal   = {ACM Transactions on Graphics},
  number    = {4},
  volume    = {42},
  month     = {July},
  year      = {2023},
  url       = {https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/}
}
```

## लाइसेंस

विवरण के लिए LICENSE फ़ाइल देखें।

---

**हमसे जुड़ें:**  
- 🌐 वेबसाइट: [mrnerf.com](https://mrnerf.com)  
- 📚 पेपर्स: [Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)  
- 💬 Discord: [हमारे समुदाय में शामिल हों](https://discord.gg/TbxJST2BbC)  
- 🐦 ट्विटर: विकास अपडेट के लिए [@janusch_patas](https://twitter.com/janusch_patas) को फ़ॉलो करें  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---