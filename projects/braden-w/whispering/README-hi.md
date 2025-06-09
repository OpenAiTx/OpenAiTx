<p align="center">
  <a href="https://whispering.bradenwong.com">
    <img width="180" src="https://raw.githubusercontent.com/braden-w/whispering/main/apps/app/src-tauri/recorder-state-icons/studio_microphone.png" alt="Whispering">
  </a>
  <h1 align="center">Whispering</h1>
  <p align="center">OpenAI के Whisper मॉडल द्वारा संचालित निर्बाध डिक्टेशन</p>
</p>

<p align="center">
  <!-- Latest Version Badge -->
  <img src="https://img.shields.io/github/v/release/braden-w/whispering?style=flat-square&label=Latest%20Version&color=brightgreen" />
  <!-- License Badge -->
  <a href="LICENSE" target="_blank">
    <img alt="MIT License" src="https://img.shields.io/github/license/braden-w/whispering.svg?style=flat-square" />
  </a>
  <!-- Badges for Technologies -->
  <img alt="TypeScript" src="https://img.shields.io/badge/-TypeScript-blue?style=flat-square&logo=typescript&logoColor=white" />
  <img alt="Rust" src="https://img.shields.io/badge/-Rust-orange?style=flat-square&logo=rust&logoColor=white" />
  <!-- Platform Support Badges -->
  <a href="https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo" target="_blank">
    <img alt="Chrome" src="https://img.shields.io/chrome-web-store/stars/oilbfihknpdbpfkcncojikmooipnlglo?color=blue&label=Chrome&style=flat-square&logo=google-chrome&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="macOS" src="https://img.shields.io/badge/-macOS-black?style=flat-square&logo=apple&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Windows" src="https://img.shields.io/badge/-Windows-blue?style=flat-square&logo=windows&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Linux" src="https://img.shields.io/badge/-Linux-yellow?style=flat-square&logo=linux&logoColor=white" />
  </a>
</p>


## परिचय

Whispering एक ओपन-सोर्स ट्रांसक्रिप्शन एप्लिकेशन है जो वैश्विक स्पीच-टू-टेक्स्ट कार्यक्षमता प्रदान करता है, जिसमें कीबोर्ड शॉर्टकट्स और स्वचालित कॉपी-पेस्ट जैसी सुविधाएँ शामिल हैं, जिससे डिक्टेशन को यथासंभव सहज बनाया जा सके।

इसके बैकएंड में OpenAI के Whisper मॉडल का उपयोग किया गया है, जिससे यह इनबिल्ट डिक्टेशन की तुलना में काफी अधिक सटीक है।

> **महत्वपूर्ण सूचना**: Whispering मुख्य रूप से एक ट्रांसक्रिप्शन टूल के रूप में डिज़ाइन किया गया है, रिकॉर्डिंग टूल के रूप में नहीं। लंबी रिकॉर्डिंग के लिए, जहाँ विश्वसनीयता महत्वपूर्ण है, मैं आपके फ़ोन या डिवाइस पर एक समर्पित रिकॉर्डिंग ऐप का उपयोग करने की सलाह देता हूँ जो नेटिव रिकॉर्डिंग API का उपयोग करता है। इससे ऑडियो गुणवत्ता और रिकॉर्डिंग स्थिरता सुनिश्चित होती है।

## डेमो

https://github.com/user-attachments/assets/eca93701-10a0-4d91-b38a-f715bd7e0357

https://github.com/user-attachments/assets/a7934f1f-d08b-4037-9bbc-aadd1b13501e

## प्रमुख विशेषताएँ

1. **वैश्विक ट्रांसक्रिप्शन**: ग्लोबल कीबोर्ड शॉर्टकट या दो बटन क्लिक के माध्यम से कहीं भी Whisper की स्पीच-टू-टेक्स्ट कार्यक्षमता प्राप्त करें।
2. **क्रॉस-प्लेटफ़ॉर्म अनुभव**:
   - डेस्कटॉप ऐप: सभी एप्लिकेशनों में वैश्विक ट्रांसक्रिप्शन सक्षम करता है।
   - ब्राउज़र एक्सटेंशन: वेब ऐप के साथ संवाद करके ब्राउज़र में वैश्विक ट्रांसक्रिप्शन प्रदान करता है।
3. **चैट एकीकरण**: ब्राउज़र एक्सटेंशन ChatGPT और Claude वेबसाइटों पर रिकॉर्डिंग बटन जोड़ता है, जिससे चैट इंटरफ़ेस में सीधे वॉइस इनपुट और ट्रांसक्रिप्शन किया जा सकता है।
4. **ट्रांसक्रिप्शन प्रबंधन**: Whispering ऐप के भीतर ट्रांसक्रिप्शन की समीक्षा और संपादन करें ताकि सटीकता और स्पष्टता सुनिश्चित की जा सके।
5. **स्वचालित क्लिपबोर्ड एकीकरण**: ट्रांसक्रिप्शन पूर्ण होने के बाद टेक्स्ट अपने आप क्लिपबोर्ड में कॉपी हो जाता है। स्वचालित पेस्टिंग का विकल्प भी उपलब्ध है।

## मेरा डेटा कैसे संग्रहीत होता है?

Whispering आपके डिवाइस पर यथासंभव अधिक डेटा स्थानीय रूप से संग्रहीत करता है, जिसमें रिकॉर्डिंग और टेक्स्ट ट्रांसक्रिप्शन शामिल हैं। यह तरीका अधिकतम गोपनीयता और डेटा सुरक्षा सुनिश्चित करता है। डेटा को कैसे हैंडल किया जाता है, इसका अवलोकन निम्नानुसार है:

1. **स्थानीय संग्रहण**: वॉइस रिकॉर्डिंग और ट्रांसक्रिप्शन IndexedDB में संग्रहीत होती हैं, जिसे ब्लॉब स्टोरेज और आपके सभी डेटा जैसे टेक्स्ट और ट्रांसक्रिप्शन संग्रहित करने के स्थान के रूप में उपयोग किया जाता है।

2. **ट्रांसक्रिप्शन सेवा**: केवल आपका रिकॉर्डिंग डेटा किसी बाहरी ट्रांसक्रिप्शन सेवा को भेजा जाता है—वह भी यदि आप चुनते हैं। आपके पास निम्नलिखित विकल्प हैं:
   - बाहरी सेवाएँ जैसे OpenAI या Groq
   - एक स्थानीय ट्रांसक्रिप्शन सेवा, जैसे `faster-whisper-server`, जो सब कुछ डिवाइस पर ही रखती है

3. **कॉन्फ़िगर करने योग्य सेटिंग्स**: आप सेटिंग्स में ट्रांसक्रिप्शन सेवा बदल सकते हैं ताकि अधिकतम स्थानीय कार्यक्षमता सुनिश्चित हो सके।


## स्थापना

### वेब ऐप

[whispering.bradenwong.com](https://whispering.bradenwong.com/) पर जाएँ, जहाँ `apps/app` फोल्डर का नवीनतम संस्करण Vercel पर होस्ट किया गया है।

### क्रोम एक्सटेंशन

क्रोम वेब स्टोर से Chrome Extension [यहाँ](https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo) से इंस्टॉल करें।

### डेस्कटॉप ऐप

Whispering डेस्कटॉप ऐप डाउनलोड और इंस्टॉल करने के लिए अपने ऑपरेटिंग सिस्टम के अनुसार निम्नलिखित चरणों का पालन करें:

#### Windows

1. [लेटेस्ट रिलीज़ पेज](https://github.com/braden-w/whispering/releases) से `.msi` में समाप्त होने वाला इंस्टॉलेशन पैकेज डाउनलोड करें।
2. डाउनलोड की गई `.msi` फाइल खोलें और इंस्टॉलर चलाएँ।
3. यदि असुरक्षित के रूप में चेतावनी मिले, तो `More Info` -> `Run Anyway` पर क्लिक करके इंस्टॉलेशन जारी रखें।
4. इंस्टॉलेशन पूरा करने के लिए ऑन-स्क्रीन निर्देशों का पालन करें।

#### macOS

macOS के लिए Whispering इंस्टॉल करने के लिए निम्नलिखित चरणों का पालन करें:

1. **इंस्टॉलेशन पैकेज डाउनलोड करें**:
   - [लेटेस्ट रिलीज़ पेज](https://github.com/braden-w/whispering/releases) पर जाएँ।
   - उपयुक्त पैकेज चुनें:
     - Apple Silicon के लिए: `Whispering_x.x.x_aarch64.dmg`
     - Intel के लिए: `Whispering_x.x.x_x64.dmg`

2. **एप्लिकेशन इंस्टॉल करें**:
   - डाउनलोड की गई `.dmg` फाइल खोलें।
   - Whispering ऐप को Applications फोल्डर में ड्रैग करें।

3. **Whispering लॉन्च करें**:
   - Applications फोल्डर से Whispering खोलें।
   - यदि अनवेरिफाइड डेवलपर के बारे में चेतावनी दिखाई दे:
     - `Cancel` पर क्लिक करें
     - Finder में ऐप पर राइट-क्लिक करें और `Open` चुनें

4. **समस्या निवारण** (केवल Apple Silicon):
   यदि आपको त्रुटि मिले `"Whispering" is damaged and can't be opened`:
   - टर्मिनल खोलें
   - निम्नलिखित कमांड चलाएँ:
     ```bash
     xattr -cr /Applications/Whispering.app
     ```
   - ऐप को फिर से खोलने का प्रयास करें

इन चरणों को पूरा करने के बाद Whispering आपके macOS सिस्टम पर उपयोग के लिए तैयार होना चाहिए।

#### Linux

Linux के लिए, कई इंस्टॉलेशन विकल्प उपलब्ध हैं। अपनी आवश्यकतानुसार विकल्प चुनें:

1. **AppImage**:

   - [लेटेस्ट रिलीज़ पेज](https://github.com/braden-w/whispering/releases) से `.AppImage` फाइल डाउनलोड करें।
   - फाइल को executable बनाएं:
     ```bash
     chmod +x whispering_x.x.x_amd64.AppImage
     ```
   - AppImage चलाएँ:
     ```bash
     ./whispering_x.x.x_amd64.AppImage
     ```

2. **DEB पैकेज (Debian/Ubuntu)**:
   - [लेटेस्ट रिलीज़ पेज](https://github.com/braden-w/whispering/releases) से `.deb` फाइल डाउनलोड करें।
   - `dpkg` का उपयोग करके पैकेज इंस्टॉल करें:
     ```bash
     sudo dpkg -i whispering_x.x.x_amd64.deb
     ```
   - किसी भी डिपेंडेंसी समस्या को हल करें:
     ```bash
     sudo apt-get install -f
     ```

इंस्टॉलेशन के बाद, ऐप उपयोग के लिए तैयार होगा।

## उपयोग

### क्रोम एक्सटेंशन

क्रोम एक्सटेंशन इंस्टॉल करने के बाद, आपको क्रोम एक्सटेंशन बार में Whispering का आइकन मिलेगा। इस आइकन पर क्लिक करें और एक्सटेंशन खोलें। अपनी आवाज़ रिकॉर्ड करने के लिए माइक्रोफोन बटन दबाएँ, और जब पूरा हो जाए तो स्क्वायर बटन दबाएँ। आपका ट्रांसक्रिप्शन नीचे के टेक्स्ट बॉक्स में दिखाई देगा।

ChatGPT या Claude फीचर का उपयोग करने के लिए, ChatGPT या Claude वेब पेज पर जाएँ। आपको चैट इंटरफ़ेस में एक नया रिकॉर्डिंग बटन दिखाई देगा। इस बटन पर क्लिक करें, रिकॉर्डिंग शुरू/बंद करें, और ट्रांसक्राइब किया गया टेक्स्ट स्वतः ही चैट इनपुट फील्ड में डाल दिया जाएगा।

शॉर्टकट फीचर का उपयोग करने के लिए, <kbd>Control</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> या <kbd>Command</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> (बाद में क्रोम एक्सटेंशन शॉर्टकट्स में कॉन्फ़िगर किया जा सकता है) दबाएँ, जिससे आप किसी भी वेबसाइट से रिकॉर्डिंग शुरू कर सकते हैं। ट्रांसक्रिप्शन अपने आप आपके क्लिपबोर्ड में कॉपी हो जाएगा और वर्तमान इनपुट फील्ड में चिपक जाएगा।

क्रोम एक्सटेंशन [whispering.bradenwong.com](https://whispering.bradenwong.com) से संवाद करता है, और यदि बैकग्राउंड में टैब नहीं मिलता है तो अपने आप एक टैब बनाने का प्रयास करता है। अधिकांश बग इसी संवाद में विफलता के कारण होते हैं, जैसे कि टैब का स्लीप मोड में चले जाना।

### वेब ऐप

वेब ऐप [whispering.bradenwong.com](https://whispering.bradenwong.com) के माध्यम से उपलब्ध है। अपनी आवाज़ रिकॉर्ड करने के लिए माइक्रोफोन बटन दबाएँ, और जब पूरा हो जाए तो स्क्वायर बटन दबाएँ। आपका ट्रांसक्रिप्शन टेक्स्ट बॉक्स में दिखाई देगा।

### डेस्कटॉप ऐप

Whispering डेस्कटॉप ऐप इंस्टॉल करने के बाद, कहीं से भी रिकॉर्डिंग शुरू करने के लिए <kbd>Control/Command</kbd> + <kbd>Shift</kbd> + <kbd>;</kbd> (सेटिंग्स में कॉन्फ़िगर किया जा सकता है) दबाएँ। ट्रांसक्रिप्शन अपने आप आपके क्लिपबोर्ड में कॉपी और पेस्ट हो जाएगा, हालांकि दोनों सुविधाएँ सेटिंग्स में टॉगल की जा सकती हैं।

## किससे निर्मित

#### वेब और डेस्कटॉप

Whispering ऐप निम्नलिखित तकनीकों और लाइब्रेरीज़ का उपयोग करके बनाया गया है:

- [Svelte 5](https://svelte.dev): पसंदीदा UI रिएक्टिविटी लाइब्रेरी।
- [SvelteKit](https://kit.svelte.dev/docs): राउटिंग और स्टैटिक साइट जनरेशन के लिए, वेबसाइट और Tauri ऐप के स्टैटिक फ्रंटएंड दोनों बनाने हेतु।
- [Tauri](https://tauri.studio/en/docs/intro/): डेस्कटॉप ऐप फ्रेमवर्क।
- [Effect-TS](https://github.com/Effect-TS/effect): कुछ फंक्शनल प्रोग्रामिंग जोड़ने और अत्यंत टाइप-सेफ फंक्शन्स लिखने के लिए, जहाँ फंक्शन सिग्नेचर के रिटर्न टाइप में एरर भी शामिल हैं।
- [Svelte Sonner](https://svelte-sonner.vercel.app/): Svelte एप्लिकेशन के लिए एक सरल, अनुकूलन योग्य टोस्ट लाइब्रेरी। Effect-TS के द्वारा ऊपर भेजे गए एरर को `renderAsToast` फंक्शन के माध्यम से दिखाने के लिए उपयोग की जाती है।
- [TanStack Table](https://tanstack.com/table): सभी डेटा टेबल्स को पावर देने के लिए।
- [IndexedDB](https://developer.mozilla.org/en-US/docs/Web/API/IndexedDB_API): ब्राउज़र में बड़ी मात्रा में संरचित डेटा संग्रहीत करने के लिए लो-लेवल API। Tanstack Table के साथ सिंक्रोनाइज़।
- [ShadCN-Svelte](https://github.com/huntabyte/shadcn-svelte): पसंदीदा UI कंपोनेंट लाइब्रेरी।
- [TailwindCSS](https://tailwindcss.com/docs): कस्टम यूजर इंटरफेस जल्दी बनाने के लिए यूटिलिटी-फर्स्ट CSS फ्रेमवर्क।
- [Turborepo](https://turborepo.org/): मोनोरिपो प्रबंधन के लिए, जिससे `apps/app` और `apps/extension` एक ही कोडबेस साझा कर सकें, कोड डुप्लीकेशन कम हो और एक सिंगल सोर्स ऑफ ट्रुथ बना रहे।
- [Rust](https://www.rust-lang.org): डेस्कटॉप ऐप फीचर्स को बढ़ाने के लिए, जैसे कि ऑटोमैटिक पेस्टिंग के लिए `enigo` क्रेट का उपयोग।
- [Vercel](https://vercel.com/): होस्टिंग जो शौकिया प्रोजेक्ट के लिए उपयुक्त है और Turborepo के साथ अच्छी इंटीग्रेशन प्रदान करता है।
- [Zapsplat.com](https://www.zapsplat.com/): रॉयल्टी-फ्री साउंड इफेक्ट्स लाइब्रेरी।

#### एक्सटेंशन

Whispering क्रोम एक्सटेंशन निम्नलिखित का उपयोग करके बनाया गया है:

- [Plasmo](https://docs.plasmo.com/): क्रोम एक्सटेंशन बनाने के लिए एक फ्रेमवर्क। हम [relay flow](https://docs.plasmo.com/framework/messaging#relay-flow) का उपयोग वेबसाइट से संवाद के लिए करते हैं।
- [Effect-TS](https://github.com/Effect-TS/effect): कुछ फंक्शनल प्रोग्रामिंग जोड़ने और अत्यंत टाइप-सेफ फंक्शन्स लिखने के लिए, जहाँ फंक्शन सिग्नेचर के रिटर्न टाइप में एरर भी शामिल हैं।
- [React](https://reactjs.org): क्रोम एक्सटेंशन के लिए UI रिएक्टिविटी लाइब्रेरी, क्योंकि दुर्भाग्यवश Plasmo Svelte 5 को सपोर्ट नहीं करता।
- [ShadCN](https://github.com/shadcn): क्रोम एक्सटेंशन के लिए UI कंपोनेंट लाइब्रेरी।
- [TailwindCSS](https://tailwindcss.com/docs): कस्टम यूजर इंटरफेस को तेजी से बनाने के लिए एक यूटिलिटी-फर्स्ट CSS फ्रेमवर्क।
- [Chrome API](https://developer.chrome.com/docs/extensions/reference/): क्रोम एक्सटेंशन API।
- [Zapsplat.com](https://www.zapsplat.com/): एक रॉयल्टी-फ्री साउंड इफेक्ट्स लाइब्रेरी।

## लोकल डेवलपमेंट मोड में Whispering चलाएं

अपने लोकल मशीन पर प्रोजेक्ट सेटअप करने के लिए निम्नलिखित चरणों का पालन करें:

1. रिपॉजिटरी क्लोन करें: `git clone https://github.com/braden-w/whispering.git`
2. प्रोजेक्ट डायरेक्टरी में जाएं: `cd whispering`
3. आवश्यक डिपेंडेंसी इंस्टॉल करें: `pnpm i`

Whispering डेस्कटॉप ऐप और वेबसाइट को डेवलपमेंट मोड में चलाने के लिए:

4. ऐप डायरेक्टरी में जाएं: `cd apps/app`
5. डेवलपमेंट सर्वर चलाएं: `pnpm tauri dev`

डेस्कटॉप ऐप लोकल डेवलपमेंट के लिए अपने-आप खुल जाना चाहिए। वेब ऐप को डेवलप करने के लिए, अपने ब्राउज़र में `http://localhost:5173` पर जाएं।

Whispering क्रोम एक्सटेंशन को डेवलपमेंट मोड में चलाने के लिए:

4. एक्सटेंशन डायरेक्टरी में जाएं: `cd apps/extension`
5. डेवलपमेंट सर्वर चलाएं: `pnpm dev --target=chrome-mv3`

क्रोम एक्सटेंशन को डेवलप करने के लिए, इसे क्रोम में लोड करें: `chrome://extensions` पर जाएं, डेवलपर मोड सक्षम करें, और `apps/extension/build/{platform}-{manifest-version}-dev` फोल्डर को अनपैक्ड एक्सटेंशन के रूप में लोड करें।

## स्वयं Executable बनाएं

यदि आपको इंस्टालर की विश्वसनीयता को लेकर कोई संदेह है या आप अधिक नियंत्रण चाहते हैं, तो आप हमेशा स्वयं ही executable बना सकते हैं। इसके लिए कुछ अतिरिक्त सेटअप की आवश्यकता होगी, लेकिन यह सुनिश्चित करता है कि आप वही कोड चला रहे हैं जिसकी आप अपेक्षा करते हैं। यही ओपन-सोर्स सॉफ़्टवेयर की खूबसूरती है!

### Chrome

1. एक्सटेंशन डायरेक्टरी में जाएं: `cd apps/extension`
2. आवश्यक डिपेंडेंसी इंस्टॉल करें: `pnpm i`
3. Plasmo बिल्ड चलाएं: `pnpm plasmo build --target=chrome-mv3`
4. आउटपुट `apps/extension/build/chrome-mv3-prod` में मिलेगा, जिसे क्रोम में अनपैक्ड एक्सटेंशन के रूप में लोड किया जा सकता है।
5. वैकल्पिक रूप से, आप क्रोम वेब स्टोर के लिए भी एक्सटेंशन बना सकते हैं: `pnpm plasmo build --target=chrome-mv3 --release`

### Firefox

1. एक्सटेंशन डायरेक्टरी में जाएं: `cd apps/extension`
2. आवश्यक डिपेंडेंसी इंस्टॉल करें: `pnpm i`
3. Plasmo बिल्ड चलाएं: `pnpm plasmo build --target=firefox-mv3`
4. आउटपुट `apps/extension/build/firefox-mv3-prod` में मिलेगा, जिसे क्रोम में अनपैक्ड एक्सटेंशन के रूप में लोड किया जा सकता है।
5. वैकल्पिक रूप से, आप क्रोम वेब स्टोर के लिए भी एक्सटेंशन बना सकते हैं: `pnpm plasmo build --target=firefox-mv3 --release`

### Desktop

1. ऐप डायरेक्टरी में जाएं: `cd apps/app`
2. आवश्यक डिपेंडेंसी इंस्टॉल करें: `pnpm i`
3. Tauri Build चलाएं: `pnpm tauri build`
4. आप executable को `apps/app/target/release` डायरेक्टरी में पाएंगे।

## योगदान

हम समुदाय से योगदान का स्वागत करते हैं! यदि आप Whispering में योगदान देना चाहते हैं, तो कृपया इन चरणों का पालन करें:

1. रिपॉजिटरी को फोर्क करें।
2. अपनी फीचर या बगफिक्स के लिए नई ब्रांच बनाएं: `git checkout -b feature/your-feature-name` या `git checkout -b fix/your-bugfix-name`
3. अपने बदलाव करें और उन्हें एक वर्णनात्मक संदेश के साथ कमिट करें।
4. अपनी ब्रांच को फोर्क किए गए रिपॉजिटरी पर पुश करें: `git push origin your-branch-name`
5. अपने फोर्क किए गए रिपॉजिटरी से ओरिजिनल रिपॉजिटरी पर पुल रिक्वेस्ट बनाएं।

कृपया सुनिश्चित करें कि आपका कोड स्थापित कन्वेंशन का पालन करता है और अच्छी तरह से डाक्यूमेंटेड है।

## लाइसेंस

Whispering को [MIT License](https://opensource.org/licenses/MIT) के अंतर्गत जारी किया गया है।

## प्रायोजक

इस प्रोजेक्ट को निम्नलिखित अद्भुत लोगों और संगठनों द्वारा समर्थित किया गया है:

<!-- sponsors --><a href="https://github.com/DavidGP"><img src="https://github.com/DavidGP.png" width="60px" alt="" /></a><a href="https://github.com/cgbur"><img src="https://github.com/cgbur.png" width="60px" alt="Chris Burgess" /></a><a href="https://github.com/Wstnn"><img src="https://github.com/Wstnn.png" width="60px" alt="" /></a><a href="https://github.com/rkhrkh"><img src="https://github.com/rkhrkh.png" width="60px" alt="" /></a><a href="https://github.com/doxgt"><img src="https://github.com/doxgt.png" width="60px" alt="" /></a><a href="https://github.com/worldoptimizer"><img src="https://github.com/worldoptimizer.png" width="60px" alt="Max Ziebell" /></a><a href="https://github.com/AlpSantoGlobalMomentumLLC"><img src="https://github.com/AlpSantoGlobalMomentumLLC.png" width="60px" alt="" /></a><!-- sponsors -->

## सहायता और फीडबैक

यदि आपको कोई समस्या आती है या आपके पास सुधार के लिए सुझाव हैं, तो कृपया [GitHub issues tab](https://github.com/braden-w/whispering/issues) पर एक इश्यू खोलें या मुझसे [whispering@bradenwong.com](mailto:whispering@bradenwong.com) के माध्यम से संपर्क करें। मैं आपके फीडबैक की सराहना करता हूँ!

Whispering का उपयोग करने के लिए धन्यवाद और आपको शुभ लेखन!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---