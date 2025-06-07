**यह GitHub रिपॉजिटरी (<https://github.com/Genymobile/scrcpy>) परियोजना का एकमात्र आधिकारिक स्रोत है। यादृच्छिक वेबसाइटों से रिलीज़ डाउनलोड न करें, भले ही उनके नाम में `scrcpy` हो।**

# scrcpy (v3.2)

<img src="app/data/icon.svg" width="128" height="128" alt="scrcpy" align="right" />

_उच्चारण "**scr**een **c**o**py**"_

यह एप्लिकेशन USB या [TCP/IP](doc/connection.md#tcpip-wireless) के माध्यम से जुड़े Android डिवाइस (वीडियो और ऑडियो) को मिरर करता है और कंप्यूटर के कीबोर्ड और माउस का उपयोग करके नियंत्रण की अनुमति देता है। यह डिवाइस पर _root_ एक्सेस या कोई ऐप इंस्टॉल करने की आवश्यकता नहीं रखता। यह _Linux_, _Windows_, और _macOS_ पर कार्य करता है।

![screenshot](assets/screenshot-debian-600.jpg)

इसका मुख्य उद्देश्य है:

 - **हल्कापन**: नेटिव, केवल डिवाइस स्क्रीन दिखाता है
 - **प्रदर्शन**: 30~120fps, डिवाइस के अनुसार
 - **गुणवत्ता**: 1920×1080 या अधिक
 - **कम विलंबता**: [35~70ms][lowlatency]
 - **कम स्टार्टअप समय**: पहली छवि दिखाने में लगभग 1 सेकंड
 - **गैर-दखलंदाजी**: Android डिवाइस पर कुछ भी इंस्टॉल नहीं छोड़ा जाता
 - **उपयोगकर्ता लाभ**: कोई खाता, कोई विज्ञापन, कोई इंटरनेट आवश्यकता नहीं
 - **स्वतंत्रता**: मुक्त और ओपन सोर्स सॉफ्टवेयर

[lowlatency]: https://github.com/Genymobile/scrcpy/pull/646

इसकी विशेषताएँ शामिल हैं:
 - [ऑडियो फॉरवर्डिंग](doc/audio.md) (Android 11+)
 - [रिकॉर्डिंग](doc/recording.md)
 - [वर्चुअल डिस्प्ले](doc/virtual_display.md)
 - [Android डिवाइस स्क्रीन बंद](doc/device.md#turn-screen-off) के साथ मिररिंग
 - दोनों दिशाओं में [कॉपी-पेस्ट](doc/control.md#copy-paste)
 - [कॉन्फ़िगर करने योग्य गुणवत्ता](doc/video.md)
 - [कैमरा मिररिंग](doc/camera.md) (Android 12+)
 - [वेबकैम के रूप में मिररिंग (V4L2)](doc/v4l2.md) (केवल Linux)
 - भौतिक [कीबोर्ड][hid-keyboard] और [माउस][hid-mouse] सिमुलेशन (HID)
 - [गेमपैड](doc/gamepad.md) समर्थन
 - [OTG मोड](doc/otg.md)
 - और भी बहुत कुछ…

[hid-keyboard]: doc/keyboard.md#physical-keyboard-simulation
[hid-mouse]: doc/mouse.md#physical-mouse-simulation

## आवश्यकताएँ

Android डिवाइस के लिए कम से कम API 21 (Android 5.0) आवश्यक है।

[ऑडियो फॉरवर्डिंग](doc/audio.md) API >= 30 (Android 11+) के लिए समर्थित है।

सुनिश्चित करें कि आपने अपने डिवाइस(डिवाइसों) पर [USB डिबगिंग सक्षम][enable-adb] किया है।

[enable-adb]: https://developer.android.com/studio/debug/dev-options#enable

कुछ डिवाइसों (विशेष रूप से Xiaomi) पर आपको निम्न त्रुटि मिल सकती है:

```
java.lang.SecurityException: Injecting input events requires the caller (or the source of the instrumentation, if any) to have the INJECT_EVENTS permission.
```

ऐसे में, आपको नियंत्रण के लिए [एक अतिरिक्त विकल्प][control] `USB डिबगिंग (सिक्योरिटी सेटिंग्स)` (यह `USB डिबगिंग` से अलग विकल्प है) सक्षम करना होगा ताकि आप कीबोर्ड और माउस से नियंत्रण कर सकें। इस विकल्प को सेट करने के बाद डिवाइस को पुनः चालू करना आवश्यक है।

[control]: https://github.com/Genymobile/scrcpy/issues/70#issuecomment-373286323

ध्यान दें कि [OTG मोड](doc/otg.md) में scrcpy चलाने के लिए USB डिबगिंग आवश्यक नहीं है।

## ऐप प्राप्त करें

 - [Linux](doc/linux.md)
 - [Windows](doc/windows.md) ([कैसे चलाएँ पढ़ें](doc/windows.md#run))
 - [macOS](doc/macos.md)

## जानने योग्य महत्वपूर्ण सुझाव

 - [रिज़ॉल्यूशन कम करना](doc/video.md#size) प्रदर्शन को काफी हद तक सुधार सकता है
   (`scrcpy -m1024`)
 - [_राइट-क्लिक_](doc/mouse.md#mouse-bindings) `BACK` ट्रिगर करता है
 - [_मिडिल-क्लिक_](doc/mouse.md#mouse-bindings) `HOME` ट्रिगर करता है
 - <kbd>Alt</kbd>+<kbd>f</kbd> [फुलस्क्रीन](doc/window.md#fullscreen) टॉगल करता है
 - कई अन्य [शॉर्टकट्स](doc/shortcuts.md) उपलब्ध हैं

## उपयोग के उदाहरण

कई विकल्प उपलब्ध हैं, जो अलग-अलग पृष्ठों में [दस्तावेजीकृत](#user-documentation) हैं।
यहाँ कुछ सामान्य उदाहरण दिए गए हैं।

 - स्क्रीन को H.265 (बेहतर गुणवत्ता), अधिकतम आकार 1920, फ्रेम रेट 60fps, ऑडियो अक्षम, और भौतिक कीबोर्ड सिमुलेशन द्वारा डिवाइस को नियंत्रित करें:

    ```bash
    scrcpy --video-codec=h265 --max-size=1920 --max-fps=60 --no-audio --keyboard=uhid
    scrcpy --video-codec=h265 -m1920 --max-fps=60 --no-audio -K  # संक्षिप्त संस्करण
    ```

 - नए वर्चुअल डिस्प्ले (डिवाइस डिस्प्ले से अलग) में VLC प्रारंभ करें:

    ```bash
    scrcpy --new-display=1920x1080 --start-app=org.videolan.vlc
    ```

 - डिवाइस कैमरा को H.265 में 1920x1080 (और माइक्रोफोन) के साथ MP4 फ़ाइल में रिकॉर्ड करें:

    ```bash
    scrcpy --video-source=camera --video-codec=h265 --camera-size=1920x1080 --record=file.mp4
    ```

 - डिवाइस फ्रंट कैमरा कैप्चर करें और कंप्यूटर पर वेबकैम के रूप में एक्सपोज़ करें (Linux पर):

    ```bash
    scrcpy --video-source=camera --camera-size=1920x1080 --camera-facing=front --v4l2-sink=/dev/video2 --no-playback
    ```

 - मिररिंग किए बिना भौतिक कीबोर्ड और माउस सिमुलेशन द्वारा डिवाइस को नियंत्रित करें (USB डिबगिंग आवश्यक नहीं):

    ```bash
    scrcpy --otg
    ```

 - कंप्यूटर में जुड़े गेमपैड कंट्रोलर का उपयोग करके डिवाइस को नियंत्रित करें:

    ```bash
    scrcpy --gamepad=uhid
    scrcpy -G  # संक्षिप्त संस्करण
    ```

## उपयोगकर्ता प्रलेखन

एप्लिकेशन कई सुविधाएँ और विन्यास विकल्प प्रदान करता है। इन्हें निम्नलिखित पृष्ठों में दस्तावेजीकृत किया गया है:

 - [कनेक्शन](doc/connection.md)
 - [वीडियो](doc/video.md)
 - [ऑडियो](doc/audio.md)
 - [नियंत्रण](doc/control.md)
 - [कीबोर्ड](doc/keyboard.md)
 - [माउस](doc/mouse.md)
 - [गेमपैड](doc/gamepad.md)
 - [डिवाइस](doc/device.md)
 - [विंडो](doc/window.md)
 - [रिकॉर्डिंग](doc/recording.md)
 - [वर्चुअल डिस्प्ले](doc/virtual_display.md)
 - [टनल्स](doc/tunnels.md)
 - [OTG](doc/otg.md)
 - [कैमरा](doc/camera.md)
 - [Video4Linux](doc/v4l2.md)
 - [शॉर्टकट्स](doc/shortcuts.md)

## संसाधन

 - [FAQ](FAQ.md)
 - [अनुवाद][wiki] (आवश्यक नहीं कि अद्यतित हों)
 - [बिल्ड निर्देश](doc/build.md)
 - [डेवलपर्स](doc/develop.md)

[wiki]: https://github.com/Genymobile/scrcpy/wiki

## लेख

- [scrcpy का परिचय][article-intro]
- [scrcpy अब वायरलेस काम करता है][article-tcpip]
- [scrcpy 2.0, ऑडियो के साथ][article-scrcpy2]

[article-intro]: https://blog.rom1v.com/2018/03/introducing-scrcpy/
[article-tcpip]: https://www.genymotion.com/blog/open-source-project-scrcpy-now-works-wirelessly/
[article-scrcpy2]: https://blog.rom1v.com/2023/03/scrcpy-2-0-with-audio/

## संपर्क करें

बग रिपोर्ट, फीचर अनुरोध या सामान्य प्रश्नों के लिए आप [issue] खोल सकते हैं।

बग रिपोर्ट के लिए, कृपया पहले [FAQ](FAQ.md) पढ़ें, आपको शायद तुरंत समाधान मिल जाए।

[issue]: https://github.com/Genymobile/scrcpy/issues

आप इसका भी उपयोग कर सकते हैं:

 - Reddit: [`r/scrcpy`](https://www.reddit.com/r/scrcpy)
 - BlueSky: [`@scrcpy.bsky.social`](https://bsky.app/profile/scrcpy.bsky.social)
 - Twitter: [`@scrcpy_app`](https://twitter.com/scrcpy_app)

## दान करें

मैं [@rom1v](https://github.com/rom1v) हूँ, _scrcpy_ का लेखक और अनुरक्षक।

यदि आप इस एप्लिकेशन की सराहना करते हैं, तो आप मेरे [ओपन सोर्स कार्य][donate] का समर्थन कर सकते हैं:
 - [GitHub Sponsors](https://github.com/sponsors/rom1v)
 - [Liberapay](https://liberapay.com/rom1v/)
 - [PayPal](https://paypal.me/rom2v)

[donate]: https://blog.rom1v.com/about/#support-my-open-source-work

## लाइसेंस

    Copyright (C) 2018 Genymobile
    Copyright (C) 2018-2025 Romain Vimont

    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at

        http://www.apache.org/licenses/LICENSE-2.0

    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---