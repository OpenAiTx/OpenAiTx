# lsfg-vk
यह प्रोजेक्ट [Lossless Scaling's Frame Generation](https://store.steampowered.com/app/993090/Lossless_Scaling/) को Linux पर लाता है!
>[!NOTE]
> यह अभी निर्माणाधीन है। हालांकि कुछ गेम्स में फ़्रेम जेनरेशन काम कर चुकी है, लेकिन अभी लंबा रास्ता तय करना बाकी है। कृपया सहायता के लिए विकी देखें (विकी अभी नहीं लिखी गई है)

## बिल्डिंग, इंस्टॉलिंग और रनिंग

>[!CAUTION]
> बिल्ड निर्देश हाल ही में बदले गए हैं। कृपया इन्हें ध्यान से पढ़ें।

LSFG को संकलित (compile) करने के लिए, सुनिश्चित करें कि आपके सिस्टम पर निम्नलिखित कंपोनेंट्स इंस्टॉल हों:
- पारंपरिक बिल्ड टूल्स (+ sed, git)
- Clang कंपाइलर (यह प्रोजेक्ट GCC के साथ आसानी से कंपाइल नहीं होता)
- Vulkan हेडर फाइल्स
- CMake बिल्ड सिस्टम
- Meson बिल्ड सिस्टम (DXVK के लिए)
- Ninja बिल्ड सिस्टम (CMake के लिए backend)

lsfg-vk को संकलित करना अपेक्षाकृत सीधा है, क्योंकि सब कुछ CMake में अच्छे से इंटीग्रेटेड है:
```bash
$ cmake -B build -G Ninja \
    -DCMAKE_BUILD_TYPE=Release \
    -DCMAKE_INSTALL_PREFIX=~/.local \
    -DCMAKE_INTERPROCEDURAL_OPTIMIZATION=ON \
    -DCMAKE_CXX_CLANG_TIDY=""
$ cmake --build build
$ cmake --install build
```
यह lsfg-vk को ~/.local/lib और ~/.local/share/vulkan में इंस्टॉल करेगा।

इसके बाद, आपको Steam से Lossless Scaling डाउनलोड करना होगा। `legacy_2.13` ब्रांच पर स्विच करें या संबंधित डिपो डाउनलोड करें।
गेम फाइल्स से "Lossless.dll" का रास्ता कॉपी करें या नोट करें।

अंत में, आइए किसी प्रोग्राम को फ्रेम जेनरेशन के साथ शुरू करें। इस उदाहरण के लिए मैं `vkcube` का उपयोग कर रहा हूँ:
```bash
VK_INSTANCE_LAYERS="VK_LAYER_LS_frame_generation" LSFG_DLL_PATH="/home/pancake/games/Lossless Scaling/Lossless.dll" LSFG_MULTIPLIER=4 vkcube
```
सुनिश्चित करें कि आप रास्तों (paths) को सही से एडजस्ट करें। आइए प्रत्येक को देखें:
- `LVK_INSTANCE_LAYERS`: यहाँ `VK_LAYER_LS_frame_generation` निर्दिष्ट करें। यह किसी भी Vulkan ऐप को lsfg-vk लेयर लोड करने के लिए बाध्य करता है।
- `LSFG_DLL_PATH`: यहाँ वह Lossless.dll निर्दिष्ट करें जो आपने Steam से डाउनलोड की थी। lsfg-vk यहाँ से शेडर्स एक्सट्रैक्ट और ट्रांसलेट करेगा।
- `LSFG_MULTIPLIER`: यह वह मल्टीप्लायर है जिससे आप परिचित हैं। फ्रेमरेट डबल करने के लिए `2` निर्दिष्ट करें, आदि।
- `VK_LAYER_PATH`: यदि आपने `~/.local` या `/usr` में इंस्टॉल नहीं किया है, तो यहाँ `explicit_layer.d` फोल्डर निर्दिष्ट करना होगा।

>[!WARNING]
> Windows के विपरीत, LSFG_MULTIPLIER यहाँ (इस समय!) काफी सीमित है। अगर आपका हार्डवेयर 8 swapchain इमेज बना सकता है, तो LSFG_MULTIPLIER को 4 पर सेट करने से उनमें से 4 उपयोग हो जाएंगी, और गेम के लिए केवल 4 बचेंगी। यदि गेम ने 5 या उससे अधिक की मांग की, तो यह क्रैश हो जाएगा।

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---