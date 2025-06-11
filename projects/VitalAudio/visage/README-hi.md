# Visage: UI लाइब्रेरी मिलती है क्रिएटिव कोडिंग से

**Visage** एक GPU-त्वरित, क्रॉस-प्लेटफ़ॉर्म C++ लाइब्रेरी है जो नेटिव UI और 2D ग्राफिक्स के लिए है। यह UI फ्रेमवर्क की संरचना को क्रिएटिव ग्राफिक्स लाइब्रेरी की विशेषताओं के साथ मिलाता है।

## पूर्ण मूल उदाहरण
```cpp
#include <https://raw.githubusercontent.com/VitalAudio/visage/main/visage_app/application_window.h>

int main() {
  visage::ApplicationWindow app;

  app.onDraw() = [&app](visage::Canvas& canvas) {
    canvas.setColor(0xffff00ff);
    canvas.fill(0, 0, app.width(), app.height());
  };

  app.show(800, 600); // 800 x 600 पिक्सेल विंडो के रूप में खुलता है
  app.runEventLoop(); // विंडो इवेंट्स चलाता है। विंडो बंद होने पर लौटता है।
  return 0;
}
```

## डेमो
- [शोकेस](https://visage.dev/examples/Showcase/)
- [ब्लेंड मोड्स](https://visage.dev/examples/BlendModes/)
- [ब्लूम](https://visage.dev/examples/Bloom/)
- [ग्रेडिएंट्स](https://visage.dev/examples/Gradients/)
- [पोस्ट शेडर इफेक्ट्स](https://visage.dev/examples/PostEffects/)
- [लाइव शेडर एडिटिंग](https://visage.dev/examples/LiveShaderEditing/)
- [लेआउट फ्लेक्सिंग](https://visage.dev/examples/Layout/)

## UI फीचर्स

- **इवेंट सामान्यीकरण**  
&nbsp;&nbsp;&nbsp;कीबोर्ड और माउस इनपुट सामान्यीकरण के लिए क्रॉस-प्लेटफ़ॉर्म सपोर्ट।

- **विंडो सामान्यीकरण**  
&nbsp;&nbsp;&nbsp;विंडोज़ खोलने और हैंडल करने के लिए क्रॉस-प्लेटफ़ॉर्म सपोर्ट।

- **टेक्स्ट एंट्री**  
&nbsp;&nbsp;&nbsp;मल्टी लाइन टेक्स्ट एडिटिंग के साथ यूनिकोड टेक्स्ट एंट्री।

- **✨ इमोजी ✨**  
&nbsp;&nbsp;&nbsp;अगर आप इस तरह की चीज़ों में रुचि रखते हैं 🤷

- **आंशिक रेंडरिंग**  
&nbsp;&nbsp;&nbsp;उत्तम प्रदर्शन के लिए केवल गंदे क्षेत्रों को पुनः ड्रॉ करता है।

## ग्राफिक्स फीचर्स

- **द्रव गतिशीलता**  
&nbsp;&nbsp;&nbsp;नए फ्रेम मॉनिटर के रिफ्रेश रेट पर प्रदर्शित होते हैं और एनीमेशन स्मूथ होते हैं।

- **स्वचालित शेप बैचिंग**  
&nbsp;&nbsp;&nbsp;GPU रेंडरिंग के लिए शेप्स को स्वचालित रूप से समूहित करता है।

- **ब्लेंड मोड्स**  
&nbsp;&nbsp;&nbsp;ऐडिटिव, सबट्रैक्टिव या UI को पास करने के लिए कस्टम मास्क ड्रॉ करके लेयर्स को ब्लेंड करने का समर्थन करता है।

- **शेडर्स**  
&nbsp;&nbsp;&nbsp;एक बार शेडर लिखें और उन्हें Direct3D, Metal और OpenGL के लिए ट्रांसपाइल करें।

- **शामिल इफेक्ट्स**  
&nbsp;&nbsp;&nbsp;रियल-टाइम इफेक्ट्स जैसे बड़े ब्लर और ब्लूम।

- **पिक्सेल सटीकता**  
&nbsp;&nbsp;&nbsp;डिवाइस पिक्सेल साइज़ तक पहुंच सुनिश्चित करता है कि रेंडरिंग बिना धुंधलाए सटीक हो।

## समर्थित प्लेटफ़ॉर्म
- **Windows**: Direct3D11
- **MacOS**: Metal  
- **Linux**: Vulkan
- **Web/Emscripten**: WebGL

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---