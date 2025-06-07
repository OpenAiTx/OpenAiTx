# स्टेबल डिफ्यूजन वेब UI

स्टेबल डिफ्यूजन के लिए एक वेब इंटरफेस, जो Gradio लाइब्रेरी का उपयोग करके इम्प्लीमेंट किया गया है।

![](screenshot.png)

## विशेषताएँ

[चित्रों सहित विस्तृत फीचर प्रदर्शन](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features):

- मूल txt2img और img2img मोड्स
- एक-क्लिक इंस्टॉल और रन स्क्रिप्ट (लेकिन आपको python और git इंस्टॉल करना आवश्यक है)
- आउटपेंटिंग
- इनपेंटिंग
- कलर स्केच
- प्रॉम्प्ट मैट्रिक्स
- स्टेबल डिफ्यूजन अपस्केल
- ध्यान, उस टेक्स्ट के भाग को निर्दिष्ट करें जिस पर मॉडल को अधिक ध्यान देना चाहिए
    - a man in a `((tuxedo))` - टक्सीडो पर अधिक ध्यान देगा
    - a man in a `(tuxedo:1.21)` - वैकल्पिक सिंटैक्स
    - टेक्स्ट सेलेक्ट करें और `Ctrl+Up` या `Ctrl+Down` (या MacOS पर `Command+Up` या `Command+Down`) दबाएँ, चुने गए टेक्स्ट पर ध्यान अपने आप एडजस्ट करने के लिए (कोड गुमनाम उपयोगकर्ता द्वारा योगदानित)
- लूपबैक, img2img प्रोसेसिंग को कई बार चलाएँ
- X/Y/Z प्लॉट, विभिन्न पैरामीटर्स के साथ छवियों का 3 डायमेंशनल प्लॉट बनाने का तरीका
- टेक्स्टुअल इनवर्शन
    - जितने चाहें उतने एम्बेडिंग्स रखें और उनके लिए कोई भी नाम रखें
    - एक से अधिक एम्बेडिंग्स का उपयोग करें, प्रति टोकन विभिन्न वेक्टर संख्या के साथ
    - हाफ प्रिसीजन फ्लोटिंग पॉइंट नंबर के साथ कार्य करता है
    - 8GB पर एम्बेडिंग्स ट्रेन करें (6GB पर भी सफल रिपोर्ट)
- एक्स्ट्रा टैब में:
    - GFPGAN, चेहरा सुधारने वाला न्यूरल नेटवर्क
    - CodeFormer, GFPGAN के विकल्प के रूप में फेस रिस्टोरेशन टूल
    - RealESRGAN, न्यूरल नेटवर्क अपस्केलर
    - ESRGAN, कई थर्ड पार्टी मॉडल्स के साथ न्यूरल नेटवर्क अपस्केलर
    - SwinIR और Swin2SR ([यहाँ देखें](https://github.com/AUTOMATIC1111/stable-diffusion-webui/pull/2092)), न्यूरल नेटवर्क अपस्केलर्स
    - LDSR, लेटेंट डिफ्यूजन सुपर रेजोल्यूशन अपस्केलिंग
- रीसाइज़िंग अस्पेक्ट रेश्यो विकल्प
- सैंपलिंग मेथड चयन
    - सैंपलर ईटा वैल्यू (शोर गुणक) समायोजित करें
    - अधिक एडवांस्ड शोर सेटिंग विकल्प
- कभी भी प्रोसेसिंग को इंटरप्ट करें
- 4GB वीडियो कार्ड सपोर्ट (2GB पर भी सफल रिपोर्ट)
- बैचेस के लिए सही सीड्स
- लाइव प्रॉम्प्ट टोकन लंबाई वैलिडेशन
- जनरेशन पैरामीटर्स
     - आपके द्वारा चित्र उत्पन्न करने के लिए उपयोग किए गए पैरामीटर्स उस चित्र के साथ सेव होते हैं
     - PNG के लिए PNG चंक्स में, JPEG के लिए EXIF में
     - चित्र को PNG info टैब पर ड्रैग करें, जनरेशन पैरामीटर्स बहाल करने और स्वचालित रूप से UI में कॉपी करने के लिए
     - सेटिंग्स में इसे अक्षम किया जा सकता है
     - चित्र/टेक्स्ट-पैरामीटर्स को प्रॉम्प्टबॉक्स में ड्रैग और ड्रॉप करें
- Read Generation Parameters बटन, प्रॉम्प्टबॉक्स में पैरामीटर्स को UI में लोड करता है
- सेटिंग्स पृष्ठ
- UI से मनमाना python कोड चलाएँ (`--allow-code` के साथ रन करें)
- अधिकांश UI तत्वों के लिए माउसओवर hints
- टेक्स्ट कॉन्फ़िग के माध्यम से UI तत्वों के लिए डिफॉल्ट/मिन/मैक्स/स्टेप वैल्यू बदलना संभव
- टाइलिंग सपोर्ट, टेक्सचर की तरह टाइल की जा सकने वाली छवियाँ बनाने के लिए एक चेकबॉक्स
- प्रोग्रेस बार और लाइव चित्र जेनरेशन प्रीव्यू
    - लगभग शून्य VRAM या कंप्यूट आवश्यकता के साथ प्रीव्यू उत्पन्न करने के लिए एक अलग न्यूरल नेटवर्क का उपयोग कर सकते हैं
- नेगेटिव प्रॉम्प्ट, एक अतिरिक्त टेक्स्ट फील्ड जिसमें आप सूचीबद्ध कर सकते हैं कि किसे उत्पन्न चित्र में नहीं देखना है
- स्टाइल्स, प्रॉम्प्ट का भाग सेव करने और बाद में ड्रॉपडाउन से आसानी से लागू करने का तरीका
- वेरिएशन्स, एक ही चित्र को थोड़े अंतर के साथ उत्पन्न करने का तरीका
- सीड रीसाइज़िंग, एक ही चित्र को थोड़े अलग रिज़ोल्यूशन पर उत्पन्न करने का तरीका
- CLIP interrogator, एक बटन जो चित्र से प्रॉम्प्ट का अनुमान लगाने की कोशिश करता है
- प्रॉम्प्ट एडिटिंग, जेनरेशन के दौरान प्रॉम्प्ट बदलने का तरीका, जैसे शुरुआत में तरबूज बनाना और बीच में एनीमे गर्ल पर स्विच करना
- बैच प्रोसेसिंग, img2img का उपयोग करके फ़ाइलों के समूह को प्रोसेस करें
- Img2img अल्टरनेटिव, क्रॉस अटेंशन कंट्रोल के लिए रिवर्स ऑयलर विधि
- हाईरेस फिक्स, उच्च रिज़ोल्यूशन चित्र एक क्लिक में बिना आमतौर पर आने वाले डिस्टॉर्शन के उत्पन्न करने के लिए सुविधा विकल्प
- रन टाइम पर चेकपॉइंट्स फिर से लोड करना
- चेकपॉइंट मर्जर, एक टैब जिससे आप 3 तक चेकपॉइंट्स को एक में मर्ज कर सकते हैं
- [कस्टम स्क्रिप्ट्स](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Custom-Scripts), समुदाय द्वारा कई एक्सटेंशन के साथ
- [कम्पोजेबल-डिफ्यूजन](https://energy-based-model.github.io/Compositional-Visual-Generation-with-Composable-Diffusion-Models/), एक साथ कई प्रॉम्प्ट्स उपयोग करने का तरीका
     - प्रॉम्प्ट्स को अपरकेस `AND` से अलग करें
     - प्रॉम्प्ट्स के लिए वेट्स भी सपोर्ट करता है: `a cat :1.2 AND a dog AND a penguin :2.2`
- प्रॉम्प्ट्स के लिए कोई टोकन सीमा नहीं (मूल स्टेबल डिफ्यूजन में 75 टोकन की सीमा होती है)
- डीपडानबूरू इंटीग्रेशन, एनीमे प्रॉम्प्ट्स के लिए डानबूरू शैली टैग्स बनाता है
- [xformers](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Xformers), चुनिंदा कार्ड्स के लिए प्रमुख स्पीड इन्क्रीज (`--xformers` कमांडलाइन आर्ग के साथ)
- एक्सटेंशन के माध्यम से: [History टैब](https://github.com/yfszzx/stable-diffusion-webui-images-browser): UI के भीतर ही छवियों को देखना, डायरेक्ट करना और हटाना
- जनरेट फॉरएवर विकल्प
- ट्रेनिंग टैब
     - हाइपरनेटवर्क्स और एम्बेडिंग्स विकल्प
     - चित्रों की प्रीप्रोसेसिंग: क्रॉपिंग, मिररिंग, BLIP या डीपडानबूरू (एनीमे के लिए) का उपयोग कर ऑटोटैगिंग
- क्लिप स्किप
- हाइपरनेटवर्क्स
- लोरा (हाइपरनेटवर्क्स के समान लेकिन अधिक सुंदर)
- एक अलग UI जिसमें आप पूर्वावलोकन के साथ चुन सकते हैं कि कौन से एम्बेडिंग्स, हाइपरनेटवर्क्स या लोरा को अपने प्रॉम्प्ट में जोड़ना है
- सेटिंग्स स्क्रीन से अलग VAE लोड करने का चयन कर सकते हैं
- प्रोग्रेस बार में अनुमानित पूर्णता समय
- API
- RunwayML द्वारा समर्पित [इनपेंटिंग मॉडल](https://github.com/runwayml/stable-diffusion#inpainting-with-stable-diffusion) के लिए समर्थन
- एक्सटेंशन के माध्यम से: [Aesthetic Gradients](https://github.com/AUTOMATIC1111/stable-diffusion-webui-aesthetic-gradients), क्लिप इमेज एम्बेड्स का उपयोग कर विशिष्ट सौंदर्य वाली छवियाँ उत्पन्न करने का तरीका ([कार्यान्वयन](https://github.com/vicgalle/stable-diffusion-aesthetic-gradients))
- [Stable Diffusion 2.0](https://github.com/Stability-AI/stablediffusion) समर्थन - निर्देशों के लिए [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#stable-diffusion-20) देखें
- [Alt-Diffusion](https://arxiv.org/abs/2211.06679) समर्थन - निर्देशों के लिए [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#alt-diffusion) देखें
- अब बिना किसी खराब अक्षर के!
- safetensors फॉर्मेट में चेकपॉइंट्स लोड करें
- आसान रिज़ोल्यूशन प्रतिबंध: उत्पन्न छवि का डाइमेंशन अब 8 का गुणज होना चाहिए (पहले 64 का था)
- अब लाइसेंस के साथ!
- सेटिंग्स स्क्रीन से UI में तत्वों का क्रम बदलें
- [Segmind Stable Diffusion](https://huggingface.co/segmind/SSD-1B) समर्थन

## इंस्टॉलेशन और रनिंग

सुनिश्चित करें कि आवश्यक [डिपेंडेंसीज़](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Dependencies) पूरी हैं और निम्नलिखित के लिए उपलब्ध निर्देशों का पालन करें:
- [NVidia](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs) (अनुशंसित)
- [AMD](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-AMD-GPUs) GPUs।
- [Intel CPUs, Intel GPUs (दोनों इंटीग्रेटेड और डिस्क्रीट)](https://github.com/openvinotoolkit/stable-diffusion-webui/wiki/Installation-on-Intel-Silicon) (बाहरी विकी पृष्ठ)
- [Ascend NPUs](https://github.com/wangshuai09/stable-diffusion-webui/wiki/Install-and-run-on-Ascend-NPUs) (बाहरी विकी पृष्ठ)

वैकल्पिक रूप से, ऑनलाइन सेवाओं (जैसे Google Colab) का उपयोग करें:

- [ऑनलाइन सेवाओं की सूची](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Online-Services)

### Windows 10/11 पर NVidia-GPUs के साथ रिलीज़ पैकेज का उपयोग करके इंस्टॉलेशन

1. [v1.0.0-pre](https://github.com/AUTOMATIC1111/stable-diffusion-webui/releases/tag/v1.0.0-pre) से `sd.webui.zip` डाउनलोड करें और इसकी सामग्री एक्सट्रैक्ट करें।
2. `update.bat` चलाएँ।
3. `run.bat` चलाएँ।

> अधिक विवरण के लिए देखें: [Install-and-Run-on-NVidia-GPUs](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs)

### Windows पर स्वचालित इंस्टॉलेशन

1. [Python 3.10.6](https://www.python.org/downloads/release/python-3106/) इंस्टॉल करें ("Add Python to PATH" चेक करें; torch के लिए नया वर्शन सपोर्टेड नहीं है)।
2. [git](https://git-scm.com/download/win) इंस्टॉल करें।
3. stable-diffusion-webui रिपोजिटरी डाउनलोड करें, उदाहरण के लिए:  
   `git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui.git`
4. Windows Explorer से सामान्य, नॉन-एडमिनिस्ट्रेटर यूजर के रूप में `webui-user.bat` चलाएँ।

### Linux पर स्वचालित इंस्टॉलेशन

1. डिपेंडेंसीज़ इंस्टॉल करें:
```bash
# डेबियन-आधारित:
sudo apt install wget git python3 python3-venv libgl1 libglib2.0-0
# रेडहैट-आधारित:
sudo dnf install wget git python3 gperftools-libs libglvnd-glx
# openSUSE-आधारित:
sudo zypper install wget git python3 libtcmalloc4 libglvnd
# Arch-आधारित:
sudo pacman -S wget git python3
```
अगर आपका सिस्टम बहुत नया है, तो python3.11 या python3.10 इंस्टॉल करें:
```bash
# Ubuntu 24.04
sudo add-apt-repository ppa:deadsnakes/ppa
sudo apt update
sudo apt install python3.11

# Manjaro/Arch
sudo pacman -S yay
yay -S python311 # python3.11 पैकेज से भ्रमित न हों

# केवल 3.11 के लिए
# फिर लॉन्च स्क्रिप्ट में env वेरिएबल सेट करें
export python_cmd="python3.11"
# या webui-user.sh में
python_cmd="python3.11"
```
2. उस डायरेक्टरी में जाएँ जहाँ आप वेबयूआई इंस्टॉल करना चाहते हैं और निम्नलिखित कमांड चलाएँ:
```bash
wget -q https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/webui.sh
```
या रेपो को कहीं भी क्लोन करें:
```bash
git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui
```

3. `webui.sh` चलाएँ।
4. विकल्पों के लिए `webui-user.sh` देखें।

### Apple Silicon पर इंस्टॉलेशन

निर्देश [यहाँ](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Installation-on-Apple-Silicon) देखें।

## योगदान

इस रिपोजिटरी में कोड जोड़ने का तरीका: [Contributing](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Contributing)

## दस्तावेज़ीकरण

दस्तावेज़ीकरण को इस README से प्रोजेक्ट के [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki) में स्थानांतरित किया गया है।

Google और अन्य सर्च इंजन द्वारा विकी को क्रॉल कराने के उद्देश्य से, (मानवों के लिए नहीं) [क्रॉल करने योग्य विकी](https://github-wiki-see.page/m/AUTOMATIC1111/stable-diffusion-webui/wiki) का लिंक यहाँ है।

## श्रेय

किराए के कोड के लाइसेंस `Settings -> Licenses` स्क्रीन और `html/licenses.html` फ़ाइल में पाए जा सकते हैं।

- Stable Diffusion - https://github.com/Stability-AI/stablediffusion, https://github.com/CompVis/taming-transformers, https://github.com/mcmonkey4eva/sd3-ref
- k-diffusion - https://github.com/crowsonkb/k-diffusion.git
- Spandrel - https://github.com/chaiNNer-org/spandrel implementing
  - GFPGAN - https://github.com/TencentARC/GFPGAN.git
  - CodeFormer - https://github.com/sczhou/CodeFormer
  - ESRGAN - https://github.com/xinntao/ESRGAN
  - SwinIR - https://github.com/JingyunLiang/SwinIR
  - Swin2SR - https://github.com/mv-lab/swin2sr
- LDSR - https://github.com/Hafiidz/latent-diffusion
- MiDaS - https://github.com/isl-org/MiDaS
- अनुकूलन के लिए विचार - https://github.com/basujindal/stable-diffusion
- क्रॉस अटेंशन लेयर ऑप्टिमाइज़ेशन - Doggettx - https://github.com/Doggettx/stable-diffusion, प्रॉम्प्ट एडिटिंग के लिए मूल विचार।
- क्रॉस अटेंशन लेयर ऑप्टिमाइज़ेशन - InvokeAI, lstein - https://github.com/invoke-ai/InvokeAI (मूल रूप से http://github.com/lstein/stable-diffusion)
- सब-क्वाड्रेटिक क्रॉस अटेंशन लेयर ऑप्टिमाइज़ेशन - Alex Birch (https://github.com/Birch-san/diffusers/pull/1), Amin Rezaei (https://github.com/AminRezaei0x443/memory-efficient-attention)
- टेक्स्टुअल इनवर्शन - Rinon Gal - https://github.com/rinongal/textual_inversion (हम उनका कोड नहीं, लेकिन उनके विचारों का उपयोग कर रहे हैं)।
- SD अपस्केल के लिए विचार - https://github.com/jquesnelle/txt2imghd
- आउटपेंटिंग mk2 के लिए शोर जनरेशन - https://github.com/parlance-zz/g-diffuser-bot
- CLIP interrogator का विचार और कुछ कोड लिया गया - https://github.com/pharmapsychotic/clip-interrogator
- कम्पोजेबल डिफ्यूजन के लिए विचार - https://github.com/energy-based-model/Compositional-Visual-Generation-with-Composable-Diffusion-Models-PyTorch
- xformers - https://github.com/facebookresearch/xformers
- DeepDanbooru - एनीमे डिफ्यूजर्स के लिए interrogator https://github.com/KichangKim/DeepDanbooru
- float16 UNet से float32 प्रिसीजन में सैंपलिंग - marunine के लिए विचार, Birch-san के लिए Diffusers इम्प्लीमेंटेशन उदाहरण (https://github.com/Birch-san/diffusers-play/tree/92feee6)
- Instruct pix2pix - Tim Brooks (star), Aleksander Holynski (star), Alexei A. Efros (no star) - https://github.com/timothybrooks/instruct-pix2pix
- सुरक्षा सलाह - RyotaK
- UniPC सैंपलर - Wenliang Zhao - https://github.com/wl-zhao/UniPC
- TAESD - Ollin Boer Bohan - https://github.com/madebyollin/taesd
- LyCORIS - KohakuBlueleaf
- रीस्टार्ट सैंपलिंग - lambertae - https://github.com/Newbeeer/diffusion_restart_sampling
- Hypertile - tfernd - https://github.com/tfernd/HyperTile
- प्रारंभिक Gradio स्क्रिप्ट - 4chan पर एक Anonymous उपयोगकर्ता द्वारा पोस्ट की गई। धन्यवाद Anonymous उपयोगकर्ता।
- (आप)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---