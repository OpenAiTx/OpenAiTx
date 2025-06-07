# GroceryApp स्टार्टर

सीधी-सादी खरीदारी के अनुभव के लिए सुव्यवस्थित ग्रोसरी ऐप टेम्प्लेट। 🛒✨

यदि आपको यह रेपोजिटरी उपयोगी लगे तो इसे स्टार ⭐ अवश्य दें।

## डिज़ाइन

**नीचे दी गई छवि पर क्लिक करके फिग्मा डिज़ाइन देखें:**

[![डिज़ाइन पूर्वावलोकन](https://github.com/ramiomarouayache/Flutter-GroceryApp/blob/main/screenshots/Cover.jpg)](https://www.figma.com/embed?embed_host=oembed&amp;url=https://www.figma.com/file/eyeYwe0hoEch31j6d3EXyE/GroceryApp-Starter-(Community)?type=design&amp;node-id=3-2&amp;mode=design&amp;t=LwLW2onM0GKLuFdU-0)

## ✨आवश्यकताएँ

1. **डेवलपमेंट एनवायरनमेंट:**
   - कोई भी IDE जिसमें Flutter SDK इंस्टॉल हो (जैसे, VSCode, Android Studio, IntelliJ...आदि)

2. **ज्ञान आधार:**
   - Dart और Flutter का बुनियादी से मध्यवर्ती ज्ञान
   - MVVM आर्किटेक्चर की समझ
   - API हैंडलिंग से परिचित
   - GetX के साथ स्टेट मैनेजमेंट की मूल बातें

## परीक्षण
* आप यहाँ से एंड्रॉइड डिवाइसेज़ के लिए प्री-रिलीज़ वर्शन डाउनलोड कर सकते हैं [releases](https://github.com/ramiomarouayache/Flutter-GroceryApp/releases/tag/v0.3.1)।
<video src="https://github.com/ramiomarouayache/Flutter-GroceryApp/assets/98425058/5ae355c9-39e0-478e-9b3e-870953b566ca"></video>

## सेटअप
* शुरुआत में अपने प्रोडक्ट एंडपॉइंट, क्रेडेंशियल्स, और पैरामीटर्स `lib\constants\AppConstants` में कॉन्फ़िगर करें।
* **वैकल्पिक रूप से**, सफल परीक्षण के लिए नीचे दिया गया फ्री एंडपॉइंट (शेयरिंग तिथि के अनुसार) उपयोग करें।
```dart
class AppConstants {
  // "YOUR_API_PREFIX" को अपनी खुद की API बेस URL से बदलें।
  static const String BASE_URL = "YOUR_API_PREFIX";
  static const String API_KEY = "YOUR_API_KEY"; //अगर हो तो

  // परीक्षण के लिए, रिलीज़ वर्शन से फ्री API बेस URL का उपयोग करें
  static const String BASE_URL = "https://world.openfoodfacts.org/api/v2";

  // प्रोजेक्ट ओनर का पूरा नाम।
  static const String projectOwnerName = "FULL_NAME";
}
```

## नोटिस
* अपनी खुद की API एंडपॉइंट्स के लिए, अपने API दस्तावेज़ के अनुसार MVVM आर्किटेक्चर गाइडलाइंस का पालन करते हुए लॉजिकल लेयर्स को कस्टमाइज़ करें।
* प्री-रिलीज़ वर्शन में कुछ चित्र कॉपीराइट प्रतिबंधों के कारण हटा दिए गए थे।

## योगदान

कृपया इस रेपोजिटरी को फोर्क करें और
[pull requests](https://github.com/ramiomarouayache/Flutter-GroceryApp/pulls) के माध्यम से योगदान करें।

कोई भी योगदान, छोटा या बड़ा, प्रमुख फीचर्स, बग फिक्सेस का स्वागत है और इसकी सराहना की जाएगी,
लेकिन पूरी तरह से समीक्षा की जाएगी।

## प्रारंभ करना
यह प्रोजेक्ट एक Flutter एप्लिकेशन के लिए प्रारंभिक बिंदु है।

यदि यह आपका पहला Flutter प्रोजेक्ट है तो शुरुआत करने के लिए कुछ संसाधन:

- [Lab: अपना पहला Flutter ऐप लिखें](https://flutter.io/docs/get-started/codelab)
- [Cookbook: उपयोगी Flutter उदाहरण](https://flutter.io/docs/cookbook)

## विज़िटर गणना

<img align="left" src = "https://profile-counter.glitch.me/GroceryApp/count.svg" alt ="लोड हो रहा है">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---