# Dana wallet

Dana एक फ्लटर ऐप है जिसका उपयोग बिटकॉइन दान स्वीकार करने के लिए किया जाता है। यह साइलेंट पेमेंट्स का उपयोग करता है, एक नया स्थिर भुगतान प्रोटोकॉल, जो ऑन-चेन गोपनीयता बनाए रखते हुए दान प्राप्त करता है।

## Dana wallet आज़माएं

**Dana wallet वर्तमान में अभी भी एक प्रयोगात्मक चरण में है। हम टेस्टनेट/सिगनेट पर बने रहने की सलाह देते हैं। यदि आप वाकई में मेननेट पर वॉलेट का परीक्षण करना चाहते हैं, तो केवल वे फंड्स उपयोग करें जिन्हें खोने के लिए आप तैयार हों। हम खोए हुए फंड्स के लिए जिम्मेदारी नहीं लेते।**

हम ऐप के अधिक स्थिर होने पर लोकप्रिय ऐप स्टोर्स पर Dana wallet जारी करने पर विचार कर रहे हैं।

इस बीच, Dana wallet आज़माने के दो तरीके हैं:

- [रिलीज़ पेज](https://github.com/cygnet3/danawallet/releases) से नवीनतम Dana wallet APK डाउनलोड करें  
- हमारे [स्वयं-होस्टेड F-Droid रिपॉजिटरी](https://fdroid.silentpayments.dev/fdroid/repo) का उपयोग करके Dana wallet डाउनलोड करें

### F-Droid का उपयोग करके डाउनलोड करें

हम F-Droid विकल्प की सिफारिश करते हैं, क्योंकि इसमें स्वचालित अपडेट का समर्थन है, और केवल एक बार सेटअप की आवश्यकता होती है।

- अपने एंड्रॉइड फोन पर F-Droid खोलें  
- 'Settings' पर जाएं  
- 'My Apps' सेक्शन में, 'Repositories' पर क्लिक करें  
- '+' आइकन पर क्लिक करके नया रिपॉजिटरी जोड़ें  
- इस पेज पर पाया गया QR कोड स्कैन करें: https://fdroid.silentpayments.dev/fdroid/repo  

अब आपने हमारा स्वयं-होस्टेड रिपॉजिटरी जोड़ लिया है। ऐप डाउनलोड करने के लिए, F-Droid ऐप स्टोर सेक्शन में 'Dana Wallet' खोजें (आपको पहले ऐप सूची को रिफ्रेश करने की आवश्यकता हो सकती है, इसके लिए F-Droid स्टोर स्क्रीन पर नीचे स्वाइप करें)।

## स्रोत से Dana wallet बनाना

नीचे स्रोत से Dana wallet बनाने के लिए कुछ निर्देश दिए गए हैं। यह केवल तब अनुशंसित है जब आप Dana wallet के विकास में मदद करना चाहते हैं।

### लिनक्स (डेस्कटॉप) के लिए निर्माण

लिनक्स के लिए निर्माण में कोई अतिरिक्त प्रयास की आवश्यकता नहीं होनी चाहिए, बस निम्नलिखित कमांड चलाएं

```
flutter run
```

यह अन्य प्लेटफॉर्म (macOS, Windows) पर भी काम कर सकता है, लेकिन हमने इसे परीक्षण नहीं किया है।

### एंड्रॉइड के लिए निर्माण

एंड्रॉइड डिवाइस के लिए निर्माण के लिए कुछ तैयारी करनी होती है, ताकि इस आर्किटेक्चर के लिए बाइनरी बनाई जा सके।

सबसे पहले, आपको `cargo-ndk` चाहिए। आपको अपने इच्छित टूलचेन भी जोड़ने पड़ सकते हैं:

```
cargo install cargo-ndk
rustup target add \
    aarch64-linux-android \
    armv7-linux-androideabi \
    x86_64-linux-android \
    i686-linux-android
```

इन्हें स्थापित करने के बाद, rust डायरेक्टरी में जाएं और `just build-android` चलाएं।

```
cd rust
just build-android
```

यदि आपके पास `just` स्थापित नहीं है, तो आप `justfile` में पाए गए कमांड भी कॉपी कर सकते हैं। यह बाइनरी जनरेट करेगा।

इसके बाद, अपने फोन को कनेक्ट करें और डिबगिंग मोड सक्षम करें।  
चेक करें कि आपका फोन कनेक्टेड है या नहीं, निम्न कमांड चलाकर

```
flutter devices
```

अंत में, अपने एंड्रॉइड डिवाइस के लिए ऐप बनाने और इंस्टॉल करने के लिए:

```
flutter run
```

## Dana को दान करें

आप हमारे पते का उपयोग करके Dana wallet को दान कर सकते हैं:

> ₿donate@danawallet.app

या आप निम्न साइलेंट पेमेंट-एड्रेस का उपयोग कर सकते हैं:

> sp1qq0cygnetgn3rz2kla5cp05nj5uetlsrzez0l4p8g7wehf7ldr93lcqadw65upymwzvp5ed38l8ur2rznd6934xh95msevwrdwtrpk372hyz4vr6g

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---