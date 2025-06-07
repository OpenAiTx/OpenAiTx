![PyTorch Logo](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/pytorch-logo-dark.png)

--------------------------------------------------------------------------------

PyTorch एक Python पैकेज है जो दो उच्च-स्तरीय विशेषताएँ प्रदान करता है:
- टेन्सर गणना (जैसे NumPy) के साथ मजबूत GPU त्वरण
- टेप-आधारित ऑटोग्रैड सिस्टम पर निर्मित गहरे न्यूरल नेटवर्क

आप अपनी पसंदीदा Python पैकेज जैसे NumPy, SciPy, और Cython का उपयोग PyTorch को आवश्यकता अनुसार बढ़ाने के लिए कर सकते हैं।

हमारे ट्रंक स्वास्थ्य (सतत एकीकरण संकेत) [hud.pytorch.org](https://hud.pytorch.org/ci/pytorch/pytorch/main) पर पाए जा सकते हैं।

<!-- toc -->

- [PyTorch के बारे में और अधिक](#more-about-pytorch)
  - [एक GPU-तैयार टेन्सर लाइब्रेरी](#a-gpu-ready-tensor-library)
  - [डायनामिक न्यूरल नेटवर्क: टेप-आधारित ऑटोग्रैड](#dynamic-neural-networks-tape-based-autograd)
  - [Python पहले](#python-first)
  - [अनिवार्य अनुभव](#imperative-experiences)
  - [तेज़ और हल्का](#fast-and-lean)
  - [बिना दर्द के एक्सटेंशन](#extensions-without-pain)
- [इंस्टॉलेशन](#installation)
  - [बाइनरीज़](#binaries)
    - [NVIDIA Jetson प्लेटफॉर्म्स](#nvidia-jetson-platforms)
  - [स्रोत से](#from-source)
    - [पूर्वापेक्षाएँ](#prerequisites)
      - [NVIDIA CUDA सपोर्ट](#nvidia-cuda-support)
      - [AMD ROCm सपोर्ट](#amd-rocm-support)
      - [Intel GPU सपोर्ट](#intel-gpu-support)
    - [PyTorch स्रोत प्राप्त करें](#get-the-pytorch-source)
    - [डिपेंडेंसीज़ इंस्टॉल करें](#install-dependencies)
    - [PyTorch इंस्टॉल करें](#install-pytorch)
      - [बिल्ड विकल्प समायोजित करें (वैकल्पिक)](#adjust-build-options-optional)
  - [डॉकर इमेज](#docker-image)
    - [पूर्व-निर्मित इमेजेस का उपयोग करना](#using-pre-built-images)
    - [इमेज को स्वयं बनाना](#building-the-image-yourself)
  - [डॉक्यूमेंटेशन बनाना](#building-the-documentation)
    - [PDF बनाना](#building-a-pdf)
  - [पिछले संस्करण](#previous-versions)
- [शुरुआत करना](#getting-started)
- [संसाधन](#resources)
- [संचार](#communication)
- [रिलीज़ और योगदान](#releases-and-contributing)
- [टीम](#the-team)
- [लाइसेंस](#license)

<!-- tocstop -->

## PyTorch के बारे में और अधिक

[PyTorch के मूल बातें सीखें](https://pytorch.org/tutorials/beginner/basics/intro.html)

सूक्ष्म स्तर पर, PyTorch एक लाइब्रेरी है जिसमें निम्नलिखित घटक होते हैं:

| घटक | विवरण |
| ---- | --- |
| [**torch**](https://pytorch.org/docs/stable/torch.html) | NumPy जैसी एक टेन्सर लाइब्रेरी, मजबूत GPU सपोर्ट के साथ |
| [**torch.autograd**](https://pytorch.org/docs/stable/autograd.html) | टेप-आधारित स्वचालित डिफरेंशिएशन लाइब्रेरी, जो torch में सभी डिफरेंशिएबल टेन्सर ऑपरेशन्स को सपोर्ट करती है |
| [**torch.jit**](https://pytorch.org/docs/stable/jit.html) | एक संकलन स्टैक (TorchScript) जो PyTorch कोड से सीरियलाइजेबल और ऑप्टिमाइजेबल मॉडल बनाता है  |
| [**torch.nn**](https://pytorch.org/docs/stable/nn.html) | एक न्यूरल नेटवर्क लाइब्रेरी, ऑटोग्रैड के साथ गहराई से एकीकृत, अधिकतम लचीलापन के लिए डिज़ाइन की गई |
| [**torch.multiprocessing**](https://pytorch.org/docs/stable/multiprocessing.html) | Python मल्टीप्रोसेसिंग, लेकिन torch टेन्सर की प्रक्रियाओं के बीच मैजिकल मेमोरी साझा करने के साथ। डेटा लोडिंग और Hogwild ट्रेनिंग के लिए उपयोगी |
| [**torch.utils**](https://pytorch.org/docs/stable/data.html) | सुविधा के लिए DataLoader और अन्य यूटिलिटी फंक्शन |

आम तौर पर, PyTorch का उपयोग या तो:

- GPU की शक्ति का उपयोग करने के लिए NumPy के विकल्प के रूप में।
- एक डीप लर्निंग रिसर्च प्लेटफॉर्म के रूप में, जो अधिकतम लचीलापन और गति प्रदान करता है।

आगे विस्तार से:

### एक GPU-तैयार टेन्सर लाइब्रेरी

यदि आप NumPy का उपयोग करते हैं, तो आपने टेन्सर (a.k.a. ndarray) का उपयोग किया है।

![Tensor illustration](./docs/source/_static/img/tensor_illustration.png)

PyTorch ऐसे टेन्सर प्रदान करता है जो या तो CPU या GPU पर रह सकते हैं और गणना को
बहुत अधिक गति से तेज करते हैं।

हम विविध प्रकार की टेन्सर रूटीन प्रदान करते हैं, जो आपकी वैज्ञानिक गणना की जरूरतों को तेज और उपयुक्त बनाते हैं,
जैसे slicing, indexing, गणितीय ऑपरेशन, रेखीय बीजगणित, reductions।
और ये तेज हैं!

### डायनामिक न्यूरल नेटवर्क: टेप-आधारित ऑटोग्रैड

PyTorch के पास न्यूरल नेटवर्क बनाने का एक अनोखा तरीका है: टेप रिकॉर्डर का उपयोग और पुनः चलाना।

अधिकतर फ्रेमवर्क जैसे TensorFlow, Theano, Caffe, और CNTK विश्व को स्थैतिक रूप में देखते हैं।
एक बार न्यूरल नेटवर्क बनाना होता है और बार-बार उसी संरचना का पुनः उपयोग करना होता है।
नेटवर्क के व्यवहार को बदलना है तो शून्य से शुरू करना पड़ता है।

PyTorch के साथ, हम एक तकनीक का उपयोग करते हैं जिसे रिवर्स-मोड ऑटो-डिफरेंशिएशन कहा जाता है, जो आपको
आपके नेटवर्क के व्यवहार को मनचाहे ढंग से बिना किसी विलंब या ओवरहेड के बदलने की अनुमति देती है। हमारी प्रेरणा इस विषय पर कई शोध पत्रों और
[torch-autograd](https://github.com/twitter/torch-autograd),
[autograd](https://github.com/HIPS/autograd),
[Chainer](https://chainer.org) आदि कार्यों से मिलती है।

जबकि यह तकनीक केवल PyTorch तक सीमित नहीं है, यह इसकी सबसे तेज़ इम्प्लीमेंटेशन में से एक है।
आपको गति और लचीलापन दोनों का सर्वोत्तम संयोजन मिलता है।

![Dynamic graph](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/dynamic_graph.gif)

### Python पहले

PyTorch कोई मोनोलिथिक C++ फ्रेमवर्क में Python बाइंडिंग नहीं है।
इसे Python में गहराई से एकीकृत किया गया है।
आप इसे वैसे ही स्वाभाविक रूप से उपयोग कर सकते हैं जैसे [NumPy](https://www.numpy.org/) / [SciPy](https://www.scipy.org/) / [scikit-learn](https://scikit-learn.org) आदि का करते हैं।
आप अपने नए न्यूरल नेटवर्क लेयर्स Python में ही लिख सकते हैं, अपनी पसंदीदा लाइब्रेरीज
और पैकेज जैसे [Cython](https://cython.org/) और [Numba](http://numba.pydata.org/) का उपयोग करके।
हमारा लक्ष्य है कि जहाँ उचित हो वहाँ पहिया पुनः न बनाएं।

### अनिवार्य अनुभव

PyTorch को सहज, रैखिक सोच में और उपयोग में आसान होने के लिए डिज़ाइन किया गया है।
जब आप कोड की एक लाइन निष्पादित करते हैं, तो वह निष्पादित होती है। यहाँ कोई असिंक्रोनस दृश्य नहीं है।
जब आप डिबगर में जाते हैं या एरर मैसेज और स्टैक ट्रेस प्राप्त करते हैं, तो उन्हें समझना आसान है।
स्टैक ट्रेस ठीक उसी स्थान की ओर इशारा करता है जहाँ आपका कोड परिभाषित है।
हम आशा करते हैं कि आप कभी भी खराब स्टैक ट्रेस या असिंक्रोनस और अपारदर्शी निष्पादन इंजनों के कारण घंटों कोड डिबग करने में न बिताएं।

### तेज़ और हल्का

PyTorch में न्यूनतम फ्रेमवर्क ओवरहेड है। हम त्वरण लाइब्रेरीज को एकीकृत करते हैं
जैसे [Intel MKL](https://software.intel.com/mkl) और NVIDIA ([cuDNN](https://developer.nvidia.com/cudnn), [NCCL](https://developer.nvidia.com/nccl)) अधिकतम गति के लिए।
मुख्य रूप से, इसके CPU और GPU टेन्सर और न्यूरल नेटवर्क बैकएंड्स
परिपक्व हैं और वर्षों से परीक्षण किए गए हैं।

इसलिए, PyTorch काफी तेज़ है — चाहे आप छोटे या बड़े न्यूरल नेटवर्क चलाएं।

PyTorch में मेमोरी उपयोग अत्यंत कुशल है, Torch या कुछ अन्य विकल्पों की तुलना में।
हमने GPU के लिए कस्टम मेमोरी एलोकेटर्स लिखे हैं ताकि
आपके डीप लर्निंग मॉडल अधिकतम मेमोरी कुशल बन सकें।
यह आपको पहले से बड़े डीप लर्निंग मॉडल ट्रेन करने में सक्षम बनाता है।

### बिना दर्द के एक्सटेंशन

नए न्यूरल नेटवर्क मॉड्यूल लिखना, या PyTorch के टेन्सर API से इंटरफेस करना,
सीधा और न्यूनतम एब्स्ट्रैक्शंस के साथ डिज़ाइन किया गया है।

आप torch API का उपयोग करके नए न्यूरल नेटवर्क लेयर Python में लिख सकते हैं
[या अपनी पसंदीदा NumPy-आधारित लाइब्रेरी जैसे SciPy](https://pytorch.org/tutorials/advanced/numpy_extensions_tutorial.html) का उपयोग करके भी कर सकते हैं।

यदि आप अपने लेयर C/C++ में लिखना चाहते हैं, तो हम एक सुविधाजनक एक्सटेंशन API प्रदान करते हैं जो कुशल और न्यूनतम बोइलरप्लेट के साथ है।
कोई रैपर कोड लिखने की आवश्यकता नहीं है। आप [यहाँ एक ट्यूटोरियल देख सकते हैं](https://pytorch.org/tutorials/advanced/cpp_extension.html) और [यहाँ एक उदाहरण](https://github.com/pytorch/extension-cpp)।

## इंस्टॉलेशन

### बाइनरीज़
Conda या pip व्हील्स के माध्यम से बाइनरीज़ इंस्टॉल करने के लिए कमांड्स हमारी वेबसाइट पर हैं: [https://pytorch.org/get-started/locally/](https://pytorch.org/get-started/locally/)

#### NVIDIA Jetson प्लेटफॉर्म्स

NVIDIA के Jetson Nano, Jetson TX1/TX2, Jetson Xavier NX/AGX, और Jetson AGX Orin के लिए Python व्हील्स [यहाँ](https://forums.developer.nvidia.com/t/pytorch-for-jetson-version-1-10-now-available/72048) उपलब्ध हैं और L4T कंटेनर [यहाँ](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/l4t-pytorch) प्रकाशित है।

इनके लिए JetPack 4.2 या उससे ऊपर की आवश्यकता है, और [@dusty-nv](https://github.com/dusty-nv) तथा [@ptrblck](https://github.com/ptrblck) इन्हें बनाए रख रहे हैं।

### स्रोत से

#### पूर्वापेक्षाएँ
यदि आप स्रोत से इंस्टॉल कर रहे हैं, तो आपको चाहिए:
- Python 3.9 या उसके बाद का संस्करण
- एक कंपाइलर जो C++17 को पूरी तरह सपोर्ट करता हो, जैसे clang या gcc (Linux पर gcc 9.4.0 या नया आवश्यक है)
- Visual Studio या Visual Studio Build Tool (केवल Windows के लिए)

\* PyTorch CI Visual C++ BuildTools का उपयोग करता है, जो Visual Studio Enterprise, Professional, या Community Editions के साथ आते हैं। आप इन्हें https://visualstudio.microsoft.com/visual-cpp-build-tools/ से भी इंस्टॉल कर सकते हैं। ये बिल्ड टूल्स डिफ़ॉल्ट रूप से Visual Studio Code के साथ नहीं आते।

पर्यावरण सेटअप का एक उदाहरण नीचे दिखाया गया है:

* Linux:

```bash
$ source <CONDA_INSTALL_DIR>/bin/activate
$ conda create -y -n <CONDA_NAME>
$ conda activate <CONDA_NAME>
```

* Windows:

```bash
$ source <CONDA_INSTALL_DIR>\Scripts\activate.bat
$ conda create -y -n <CONDA_NAME>
$ conda activate <CONDA_NAME>
$ call "C:\Program Files\Microsoft Visual Studio\<VERSION>\Community\VC\Auxiliary\Build\vcvarsall.bat" x64
```

##### NVIDIA CUDA सपोर्ट
यदि आप CUDA सपोर्ट के साथ कंपाइल करना चाहते हैं, तो [हमारे सपोर्ट मैट्रिक्स से CUDA का सपोर्टेड वर्शन चुनें](https://pytorch.org/get-started/locally/), फिर निम्नलिखित इंस्टॉल करें:
- [NVIDIA CUDA](https://developer.nvidia.com/cuda-downloads)
- [NVIDIA cuDNN](https://developer.nvidia.com/cudnn) v8.5 या ऊपर
- [Compiler](https://gist.github.com/ax3l/9489132) जो CUDA के साथ संगत हो

नोट: आप [cuDNN Support Matrix](https://docs.nvidia.com/deeplearning/cudnn/backend/latest/reference/support-matrix.html) में विभिन्न CUDA, CUDA ड्राइवर और NVIDIA हार्डवेयर के साथ cuDNN के वर्शन देख सकते हैं।

यदि आप CUDA सपोर्ट को निष्क्रिय करना चाहते हैं, तो पर्यावरण वेरिएबल `USE_CUDA=0` एक्सपोर्ट करें।
अन्य उपयोगी पर्यावरण वेरिएबल्स `setup.py` में पाए जा सकते हैं।

यदि आप NVIDIA के Jetson प्लेटफॉर्म्स (Jetson Nano, TX1, TX2, AGX Xavier) के लिए बना रहे हैं, तो Jetson Nano के लिए PyTorch इंस्टॉल करने के निर्देश [यहाँ उपलब्ध हैं](https://devtalk.nvidia.com/default/topic/1049071/jetson-nano/pytorch-for-jetson-nano/)

##### AMD ROCm सपोर्ट
यदि आप ROCm सपोर्ट के साथ कंपाइल करना चाहते हैं, तो इंस्टॉल करें
- [AMD ROCm](https://rocm.docs.amd.com/en/latest/deploy/linux/quick_start.html) 4.0 और ऊपर
- ROCm फिलहाल केवल Linux सिस्टम के लिए सपोर्टेड है।

डिफ़ॉल्ट रूप से बिल्ड सिस्टम `/opt/rocm` में ROCm की अपेक्षा करता है। यदि ROCm किसी अन्य डायरेक्टरी में इंस्टॉल है, तो `ROCM_PATH` पर्यावरण वेरिएबल को ROCm इंस्टॉलेशन डायरेक्टरी पर सेट करना होगा। बिल्ड सिस्टम स्वचालित रूप से AMD GPU आर्किटेक्चर का पता लगाता है। वैकल्पिक रूप से, AMD GPU आर्किटेक्चर को `PYTORCH_ROCM_ARCH` पर्यावरण वेरिएबल से स्पष्ट रूप से सेट किया जा सकता है [AMD GPU आर्किटेक्चर](https://rocm.docs.amd.com/projects/install-on-linux/en/latest/reference/system-requirements.html#supported-gpus)

यदि आप ROCm सपोर्ट को निष्क्रिय करना चाहते हैं, तो पर्यावरण वेरिएबल `USE_ROCM=0` एक्सपोर्ट करें।
अन्य उपयोगी पर्यावरण वेरिएबल्स `setup.py` में पाए जा सकते हैं।

##### Intel GPU सपोर्ट
यदि आप Intel GPU सपोर्ट के साथ कंपाइल करना चाहते हैं, तो
- [PyTorch Prerequisites for Intel GPUs](https://www.intel.com/content/www/us/en/developer/articles/tool/pytorch-prerequisites-for-intel-gpus.html) के निर्देशों का पालन करें।
- Intel GPU Linux और Windows के लिए सपोर्टेड है।

यदि आप Intel GPU सपोर्ट को निष्क्रिय करना चाहते हैं, तो पर्यावरण वेरिएबल `USE_XPU=0` एक्सपोर्ट करें।
अन्य उपयोगी पर्यावरण वेरिएबल्स `setup.py` में पाए जा सकते हैं।

#### PyTorch स्रोत प्राप्त करें
```bash
git clone https://github.com/pytorch/pytorch
cd pytorch
# यदि आप मौजूदा चेकआउट अपडेट कर रहे हैं
git submodule sync
git submodule update --init --recursive
```

#### डिपेंडेंसीज़ इंस्टॉल करें

**सामान्य**

```bash
conda install cmake ninja
# नीचे दिए "PyTorch स्रोत प्राप्त करें" अनुभाग का उपयोग करके सोर्स कोड क्लोन करने के बाद, इस कमांड को PyTorch डायरेक्टरी से चलाएँ
pip install -r requirements.txt
```

**Linux पर**

```bash
pip install mkl-static mkl-include
# केवल CUDA: यदि आवश्यकता हो तो GPU के लिए LAPACK सपोर्ट जोड़ें
# magma इंस्टॉलेशन: एक्टिव conda एनवायरनमेंट के साथ चलाएँ। इंस्टॉल करने के लिए CUDA वर्शन निर्दिष्ट करें
.ci/docker/common/install_magma_conda.sh 12.4

# (वैकल्पिक) यदि torch.compile का उपयोग inductor/triton के साथ कर रहे हैं, तो मेल खाती triton वर्शन इंस्टॉल करें
# क्लोन करने के बाद pytorch डायरेक्टरी से चलाएँ
# Intel GPU सपोर्ट के लिए, कृपया कमांड चलाने से पहले स्पष्ट रूप से `export USE_XPU=1` करें।
make triton
```

**MacOS पर**

```bash
# केवल Intel x86 प्रोसेसर मशीनों पर इस पैकेज को जोड़ें
pip install mkl-static mkl-include
# यदि torch.distributed की आवश्यकता है तो ये पैकेज जोड़ें
conda install pkg-config libuv
```

**Windows पर**

```bash
pip install mkl-static mkl-include
# यदि torch.distributed की आवश्यकता है तो ये पैकेज जोड़ें।
# Windows पर Distributed पैकेज सपोर्ट प्रोटोटाइप फीचर है और परिवर्तन के अधीन है।
conda install -c conda-forge libuv=1.39
```

#### PyTorch इंस्टॉल करें
**Linux पर**

यदि आप AMD ROCm के लिए कंपाइल कर रहे हैं तो पहले यह कमांड चलाएँ:
```bash
# केवल ROCm के लिए कंपाइल कर रहे हैं तो चलाएँ
python tools/amd_build/build_amd.py
```

PyTorch इंस्टॉल करें
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py develop
```

**macOS पर**

```bash
python3 setup.py develop
```

**Windows पर**

यदि आप पुराने python कोड के लिए बिल्ड करना चाहते हैं, तो कृपया [Building on legacy code and CUDA](https://github.com/pytorch/pytorch/blob/main/CONTRIBUTING.md#building-on-legacy-code-and-cuda) देखें

**केवल CPU-बिल्ड**

इस मोड में PyTorch की गणनाएँ आपके CPU पर चलेंगी, GPU पर नहीं।

```cmd
python setup.py develop
```

OpenMP नोट: वांछित OpenMP इम्प्लीमेंटेशन Intel OpenMP (iomp) है। iomp के खिलाफ लिंक करने के लिए, आपको लाइब्रेरी को मैन्युअली डाउनलोड करना और बिल्डिंग एनवायरनमेंट सेटअप करना होगा, `CMAKE_INCLUDE_PATH` और `LIB` को समायोजित करके। [यहाँ](https://github.com/pytorch/pytorch/blob/main/docs/source/notes/windows.rst#building-from-source) एक उदाहरण है। CMake के लिए इन कॉन्फ़िगरेशन के बिना, Microsoft Visual C OpenMP रनटाइम (vcomp) का उपयोग होगा।

**CUDA आधारित बिल्ड**

इस मोड में PyTorch की गणनाएँ आपके GPU का उपयोग CUDA के माध्यम से तेज़ी से करेंगी

[NVTX](https://docs.nvidia.com/gameworks/content/gameworkslibrary/nvtx/nvidia_tools_extension_library_nvtx.htm) आवश्यक है।
NVTX, CUDA डिस्ट्रीब्यूशन का हिस्सा है, जहाँ इसे "Nsight Compute" कहा जाता है। इंस्टॉल करने के लिए, CUDA इंस्टॉलेशन को फिर से चलाएँ और उपयुक्त चेकबॉक्स चुनें।
सुनिश्चित करें कि Nsight Compute के साथ CUDA Visual Studio के बाद इंस्टॉल हो।

फिलहाल, VS 2017/2019, और Ninja CMake के जेनरेटर के रूप में सपोर्टेड हैं। यदि `ninja.exe` `PATH` में है, तो Ninja डिफ़ॉल्ट जेनरेटर होगा, अन्यथा VS 2017/2019।
<br/> यदि Ninja चुना जाता है, तो नवीनतम MSVC टूलचेन चुना जाएगा।

अतिरिक्त लाइब्रेरीज़ जैसे
[Magma](https://developer.nvidia.com/magma), [oneDNN, जिसे MKLDNN या DNNL भी कहते हैं](https://github.com/oneapi-src/oneDNN), और [Sccache](https://github.com/mozilla/sccache) अक्सर जरूरी होती हैं। कृपया [installation-helper](https://github.com/pytorch/pytorch/tree/main/.ci/pytorch/win-test-helpers/installation-helpers) देखें।

आप कुछ अन्य पर्यावरण वेरिएबल्स कॉन्फ़िगरेशन के लिए [build_pytorch.bat](https://github.com/pytorch/pytorch/blob/main/.ci/pytorch/win-test-helpers/build_pytorch.bat) स्क्रिप्ट भी देख सकते हैं।

```cmd
cmd

:: mkl पैकेज डाउनलोड और अनज़िप करने के बाद पर्यावरण वेरिएबल्स सेट करें,
:: अन्यथा CMake `Could NOT find OpenMP` त्रुटि देगा।
set CMAKE_INCLUDE_PATH={Your directory}\mkl\include
set LIB={Your directory}\mkl\lib;%LIB%

:: पिछले अनुभाग की सामग्री ध्यान से पढ़ें।
:: [वैकल्पिक] यदि आप Ninja और Visual Studio के साथ CUDA के लिए टूलसेट ओवरराइड करना चाहते हैं, तो निम्नलिखित स्क्रिप्ट ब्लॉक चलाएँ।
:: "Visual Studio 2019 Developer Command Prompt" स्वतः चलाया जाएगा।
:: Visual Studio जेनरेटर का उपयोग करते समय सुनिश्चित करें कि आपके पास CMake >= 3.12 है।
set CMAKE_GENERATOR_TOOLSET_VERSION=14.27
set DISTUTILS_USE_SDK=1
for /f "usebackq tokens=*" %i in (`"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" -version [15^,17^) -products * -latest -property installationPath`) do call "%i\VC\Auxiliary\Build\vcvarsall.bat" x64 -vcvars_ver=%CMAKE_GENERATOR_TOOLSET_VERSION%

:: [वैकल्पिक] यदि आप CUDA होस्ट कंपाइलर ओवरराइड करना चाहते हैं
set CUDAHOSTCXX=C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.27.29110\bin\HostX64\x64\cl.exe

python setup.py develop

```

**Intel GPU बिल्ड्स**

इस मोड में Intel GPU सपोर्ट के साथ PyTorch बनेगा।

कृपया सुनिश्चित करें कि [आम पूर्वापेक्षाएँ](#prerequisites) और [Intel GPU के लिए पूर्वापेक्षाएँ](#intel-gpu-support) ठीक से इंस्टॉल हैं और पर्यावरण वेरिएबल्स कॉन्फ़िगर किए गए हैं। बिल्ड टूल सपोर्ट के लिए, `Visual Studio 2022` आवश्यक है।

फिर PyTorch निम्न कमांड से बनाया जा सकता है:

```cmd
:: CMD Commands:
:: संबंधित पैकेज खोजने में सहायता के लिए CMAKE_PREFIX_PATH सेट करें
:: %CONDA_PREFIX% केवल `conda activate custom_env` के बाद काम करता है

if defined CMAKE_PREFIX_PATH (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library;%CMAKE_PREFIX_PATH%"
) else (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library"
)

python setup.py develop
```

##### बिल्ड विकल्प समायोजित करें (वैकल्पिक)

आप cmake वेरिएबल्स की कॉन्फ़िगरेशन को वैकल्पिक रूप से (पहले बनाए बिना) समायोजित कर सकते हैं। उदाहरण के लिए, CuDNN या BLAS के पूर्व-निर्धारित डिरेक्ट्रीज को समायोजित करना इस तरह किया जा सकता है।

Linux पर
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py build --cmake-only
ccmake build  # या cmake-gui build
```

macOS पर
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
MACOSX_DEPLOYMENT_TARGET=10.9 CC=clang CXX=clang++ python setup.py build --cmake-only
ccmake build  # या cmake-gui build
```

### डॉकर इमेज

#### पूर्व-निर्मित इमेजेस का उपयोग करना

आप Docker Hub से पूर्व-निर्मित डॉकर इमेज भी खींच सकते हैं और docker v19.03+ के साथ चला सकते हैं

```bash
docker run --gpus all --rm -ti --ipc=host pytorch/pytorch:latest
```

कृपया ध्यान दें कि PyTorch डेटा साझा करने के लिए साझा मेमोरी का उपयोग करता है, इसलिए यदि torch मल्टीप्रोसेसिंग का उपयोग किया जाता है (जैसे मल्टीथ्रेडेड डेटा लोडर्स के लिए) तो कंटेनर के साथ चलने वाला डिफ़ॉल्ट साझा मेमोरी खंड आकार पर्याप्त नहीं है, और आपको साझा मेमोरी आकार या तो `--ipc=host` या `--shm-size` कमांड लाइन विकल्पों के साथ बढ़ाना चाहिए।

#### इमेज को स्वयं बनाना

**नोट:** डॉकर वर्शन > 18.06 के साथ बनाना आवश्यक है

`Dockerfile` CUDA 11.1 सपोर्ट और cuDNN v8 के साथ इमेज बनाने के लिए दिया गया है।
आप `PYTHON_VERSION=x.y` make वेरिएबल पास कर सकते हैं, जिससे Miniconda द्वारा उपयोग किए जाने वाले Python वर्शन को निर्दिष्ट किया जा सकता है, या डिफ़ॉल्ट वर्शन का उपयोग किया जा सकता है।

```bash
make -f docker.Makefile
# images टैग किए जाते हैं docker.io/${your_docker_username}/pytorch के रूप में
```

आप `CMAKE_VARS="..."` पर्यावरण वेरिएबल भी पास कर सकते हैं, जिससे बिल्ड के दौरान CMake को अतिरिक्त वेरिएबल्स भेजी जा सकती हैं।
[setup.py](./setup.py) में उपलब्ध वेरिएबल्स की सूची देखें।

```bash
make -f docker.Makefile
```

### डॉक्यूमेंटेशन बनाना

विभिन्न स्वरूपों में डॉक्यूमेंटेशन बनाने के लिए, आपको [Sphinx](http://www.sphinx-doc.org)
और pytorch_sphinx_theme2 की आवश्यकता होगी।

स्थानीय रूप से डॉक्यूमेंटेशन बनाने से पहले, सुनिश्चित करें कि आपके पर्यावरण में `torch`
इंस्टॉल है। छोटे फिक्सेस के लिए, आप [Getting Started](https://pytorch.org/get-started/locally/) में वर्णित nightly वर्शन इंस्टॉल कर सकते हैं।

अधिक जटिल फिक्सेस के लिए, जैसे एक नया मॉड्यूल और उसके लिए docstrings जोड़ना, आपको torch [स्रोत से](#from-source) इंस्टॉल करना पड़ सकता है।
[Docstring Guidelines](https://github.com/pytorch/pytorch/wiki/Docstring-Guidelines)
भी देखें।

```bash
cd docs/
pip install -r requirements.txt
make html
make serve
```

सभी उपलब्ध आउटपुट स्वरूपों की सूची के लिए `make` चलाएँ।

यदि आपको katex त्रुटि मिले तो `npm install katex` चलाएँ। यदि समस्या बनी रहती है, तो
`npm install -g katex` आज़माएँ

> [!NOTE]
> यदि आपने `nodejs` किसी अन्य पैकेज मैनेजर (जैसे,
> `conda`) से इंस्टॉल किया है, तो `npm` संभवतः `katex` का ऐसा वर्शन इंस्टॉल करेगा जो आपके nodejs वर्शन के अनुकूल नहीं है और डॉक्यूमेंटेशन बिल्ड विफल हो जाएगा।
> एक ज्ञात कार्यशील वर्शन संयोजन है `node@6.13.1` और
> `katex@0.13.18`। बाद वाले को `npm` से इंस्टॉल करने के लिए
> ```npm install -g katex@0.13.18```

> [!NOTE]
> यदि आपको numpy असंगति त्रुटि मिले, तो चलाएँ:
> ```
> pip install 'numpy<2'
> ```

जब आप CI द्वारा चलाए जाने वाली डिपेंडेंसीज़ बदलें, `.ci/docker/requirements-docs.txt` फ़ाइल संपादित करें।

#### PDF बनाना

सभी PyTorch डॉक्यूमेंटेशन का PDF बनाने के लिए, सुनिश्चित करें कि आपके पास
`texlive` और LaTeX इंस्टॉल है। macOS पर, आप इन्हें इस प्रकार इंस्टॉल कर सकते हैं:

```
brew install --cask mactex
```

PDF बनाने के लिए:

1. चलाएँ:

   ```
   make latexpdf
   ```

   इससे `build/latex` डिरेक्टरी में आवश्यक फाइलें बनेंगी।

2. इस डिरेक्टरी में जाएँ और चलाएँ:

   ```
   make LATEXOPTS="-interaction=nonstopmode"
   ```

   इससे वांछित सामग्री के साथ `pytorch.pdf` बनेगा। सही table of contents और index के लिए यह कमांड एक बार और चलाएँ।

> [!NOTE]
> Table of Contents देखने के लिए, अपने PDF viewer में **Table of Contents**
> दृश्य पर जाएँ।

### पिछले संस्करण

पिछले PyTorch संस्करणों के इंस्टॉलेशन निर्देश और बाइनरीज़
[हमारी वेबसाइट](https://pytorch.org/get-started/previous-versions) पर मिल सकते हैं।

## शुरुआत करना

शुरुआत के लिए तीन सूत्र:
- [ट्यूटोरियल: PyTorch को समझने और उपयोग करने के लिए](https://pytorch.org/tutorials/)
- [उदाहरण: सभी डोमेन के लिए आसान PyTorch कोड](https://github.com/pytorch/examples)
- [API संदर्भ](https://pytorch.org/docs/)
- [शब्दावली](https://github.com/pytorch/pytorch/blob/main/GLOSSARY.md)

## संसाधन

* [PyTorch.org](https://pytorch.org/)
* [PyTorch ट्यूटोरियल्स](https://pytorch.org/tutorials/)
* [PyTorch उदाहरण](https://github.com/pytorch/examples)
* [PyTorch मॉडल](https://pytorch.org/hub/)
* [Udacity से PyTorch के साथ डीप लर्निंग का परिचय](https://www.udacity.com/course/deep-learning-pytorch--ud188)
* [Udacity से PyTorch के साथ मशीन लर्निंग का परिचय](https://www.udacity.com/course/intro-to-machine-learning-nanodegree--nd229)
* [Coursera से PyTorch के साथ डीप न्यूरल नेटवर्क्स](https://www.coursera.org/learn/deep-neural-networks-with-pytorch)
* [PyTorch Twitter](https://twitter.com/PyTorch)
* [PyTorch ब्लॉग](https://pytorch.org/blog/)
* [PyTorch YouTube](https://www.youtube.com/channel/UCWXI5YeOsh03QvJ59PMaXFw)

## संचार
* फोरम: कार्यान्वयन, शोध आदि पर चर्चा करें। https://discuss.pytorch.org
* GitHub Issues: बग रिपोर्ट, फीचर अनुरोध, इंस्टॉल समस्याएँ, RFCs, विचार आदि।
* Slack: [PyTorch Slack](https://pytorch.slack.com/) मुख्य रूप से मध्यम से अनुभवी PyTorch उपयोगकर्ताओं और डेवलपर्स के लिए सामान्य चैट, ऑनलाइन चर्चाएँ, सहयोग आदि के लिए है। यदि आप शुरुआती हैं, तो [PyTorch Forums](https://discuss.pytorch.org) प्राथमिक माध्यम है। यदि आपको Slack निमंत्रण चाहिए, तो कृपया यह फॉर्म भरें: https://goo.gl/forms/PP1AGvNHpSaJP8to1
* न्यूज़लेटर: बिना शोर-शराबे के, एकतरफा ईमेल न्यूज़लेटर जिसमें PyTorch के बारे में महत्वपूर्ण घोषणाएँ होती हैं। आप यहाँ साइन-अप कर सकते हैं: https://eepurl.com/cbG0rv
* Facebook पेज: PyTorch के बारे में महत्वपूर्ण घोषणाएँ। https://www.facebook.com/pytorch
* ब्रांड गाइडलाइंस के लिए, कृपया हमारी वेबसाइट देखें [pytorch.org](https://pytorch.org/)

## रिलीज़ और योगदान

आम तौर पर, PyTorch का साल में तीन बार माइनर रिलीज़ होता है। यदि आपको कोई बग मिलता है तो कृपया [issue दर्ज करें](https://github.com/pytorch/pytorch/issues)।

हम सभी योगदानों की सराहना करते हैं। यदि आप बग-फिक्सेस वापस योगदान करना चाहते हैं, तो कृपया बिना किसी अतिरिक्त चर्चा के ऐसा करें।

यदि आप नई विशेषताएँ, यूटिलिटी फंक्शन या कोर के लिए एक्सटेंशन योगदान करना चाहते हैं, तो पहले एक issue खोलें और हमारे साथ चर्चा करें।
बिना चर्चा के PR भेजना अस्वीकार किए गए PR में बदल सकता है क्योंकि हो सकता है कि हम कोर को उस दिशा में न ले जा रहे हों, जिसकी आपको जानकारी न हो।

PyTorch में योगदान के बारे में अधिक जानने के लिए, कृपया हमारा [Contribution page](CONTRIBUTING.md) देखें। PyTorch रिलीज़ के बारे में अधिक जानकारी के लिए [Release page](RELEASE.md) देखें।

## टीम

PyTorch एक समुदाय-आधारित प्रोजेक्ट है जिसमें कई कुशल इंजीनियर और शोधकर्ता योगदान देते हैं।

PyTorch वर्तमान में [Soumith Chintala](http://soumith.ch), [Gregory Chanan](https://github.com/gchanan), [Dmytro Dzhulgakov](https://github.com/dzhulgakov), [Edward Yang](https://github.com/ezyang), और [Nikita Shulga](https://github.com/malfet) द्वारा मेंटेन किया जाता है, और सैकड़ों प्रतिभाशाली व्यक्तियों से प्रमुख योगदान आते हैं।
एक अपूर्ण लेकिन बढ़ती सूची में उल्लेखनीय हैं: [Trevor Killeen](https://github.com/killeent), [Sasank Chilamkurthy](https://github.com/chsasank), [Sergey Zagoruyko](https://github.com/szagoruyko), [Adam Lerer](https://github.com/adamlerer), [Francisco Massa](https://github.com/fmassa), [Alykhan Tejani](https://github.com/alykhantejani), [Luca Antiga](https://github.com/lantiga), [Alban Desmaison](https://github.com/albanD), [Andreas Koepf](https://github.com/andreaskoepf), [James Bradbury](https://github.com/jekbradbury), [Zeming Lin](https://github.com/ebetica), [Yuandong Tian](https://github.com/yuandong-tian), [Guillaume Lample](https://github.com/glample), [Marat Dukhan](https://github.com/Maratyszcza), [Natalia Gimelshein](https://github.com/ngimel), [Christian Sarofeen](https://github.com/csarofeen), [Martin Raison](https://github.com/martinraison), [Edward Yang](https://github.com/ezyang), [Zachary Devito](https://github.com/zdevito)।

नोट: यह प्रोजेक्ट [hughperkins/pytorch](https://github.com/hughperkins/pytorch) से असंबंधित है, जिसका नाम वही है। Hugh Torch समुदाय के एक मूल्यवान योगदानकर्ता हैं और उन्होंने Torch और PyTorch के लिए कई चीजों में मदद की है।

## लाइसेंस

PyTorch में BSD-शैली का लाइसेंस है, जैसा कि [LICENSE](LICENSE) फ़ाइल में पाया गया है।


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---