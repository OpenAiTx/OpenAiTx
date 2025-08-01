<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (coming soon)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (coming soon)</a> |
        | <a href="#" title="Coming soon">ไทย (coming soon)</a> |
        | <a href="#" title="Coming soon">Français (coming soon)</a>
        | <a href="#" title="Coming soon">Deutsch (coming soon)</a>
        | <a href="#" title="Coming soon">Español (coming soon)</a>
        | <a href="#" title="Coming soon">Italiano (coming soon)</a>
        | <a href="#" title="Coming soon">Русский (coming soon)</a>
        | <a href="#" title="Coming soon">Português (coming soon)</a>
        | <a href="#" title="Coming soon">Nederlands (coming soon)</a>
        | <a href="#" title="Coming soon">Polski (coming soon)</a>
        | <a href="#" title="Coming soon">العربية (coming soon)</a>
        | <a href="#" title="Coming soon">فارسی (coming soon)</a>
        | <a href="#" title="Coming soon">Türkçe (coming soon)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (coming soon)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (coming soon)</a>

      </div>
    </div>
  </details>
</div>

# टाइमकैप्सूल एलएलएम
एक एलएलएम जिसे केवल कुछ निश्चित समय अवधि के डेटा पर प्रशिक्षित किया गया है ताकि आधुनिक पूर्वाग्रह को कम किया जा सके।

कल्पना कीजिए अगर एक एआई मॉडल केवल ऐतिहासिक होने का दिखावा नहीं करता बल्कि वास्तव में ऐतिहासिक होता।

[Andrej Karpathy द्वारा nanoGPT](https://github.com/karpathy/nanoGPT) पर आधारित। मुख्य प्रशिक्षण स्क्रिप्ट्स और मॉडल आर्किटेक्चर उन्हीं का कार्य है।

# परियोजना के उद्देश्य

टाइमकैप्सूल एलएलएम एक प्रायोगिक परियोजना है जिसे केवल कुछ निश्चित ऐतिहासिक समय में लिखे गए ग्रंथों पर प्रशिक्षित किया जाएगा। इसका उद्देश्य विशिष्ट ऐतिहासिक युगों की विश्वदृष्टि और भाषा का अनुकरण करना है।

# क्यों फाइन-ट्यूनिंग पर्याप्त नहीं है

यदि आप केवल एक पूर्व-प्रशिक्षित मॉडल को फाइन-ट्यून करते हैं, तब भी आपका एलएलएम आधुनिक अवधारणाओं को जानता रहेगा। निश्चित रूप से शून्य आधुनिक पूर्वाग्रह प्राप्त करना कठिन है, लेकिन मैं इसके जितना निकट जा सकता हूं जाना चाहता हूं। बिल्कुल भी आधुनिक पूर्वाग्रह न होना तभी संभव है जब मॉडल को शुरू से प्रशिक्षित किया जाए।

# अपेक्षित परिणाम

आशा है कि जब यह मॉडल पूरा होगा, तब यह आधुनिक अवधारणाओं को नहीं जानेगा और जिस पर इसे प्रशिक्षित किया गया है, उसके आगे तर्क नहीं कर पाएगा। इसे आधुनिक शब्दावली/अवधारणाओं को नहीं पहचानना चाहिए और मुझे उम्मीद है कि यह आधुनिक ज्ञान की कल्पना नहीं करेगा।

# प्रगति अद्यतन

## 9 जुलाई, 2025

मैंने अपनी समयावधि 1800-1850 और क्षेत्र: लंदन निर्धारित कर दी है

मैंने ग्रंथों, पुस्तकों, दस्तावेजों की एक सूची एकत्रित की है

अब तक मैंने 50 टेक्स्ट फाइलें प्राप्त कर ली हैं और जल्द ही NanoGPT पर प्रशिक्षण शुरू करूंगा

जब तक प्रगति होती रहेगी, मैं इसे अपडेट करता रहूंगा

## 13 जुलाई, 2025

nanoGPT को 187MB ऐतिहासिक टेक्स्ट डेटा से प्रशिक्षित किया।

## 15 जुलाई, 2025

मैंने दूसरे प्रशिक्षण रन के लिए ग्रंथ डाउनलोड करने शुरू कर दिए हैं। मैं इंटरनेट आर्काइव से सब कुछ ले रहा हूं और समयावधि को 1800-1875 तक बढ़ा दिया है। विविध प्रकार के ग्रंथ प्राप्त करने के लिए आप इंटरनेट आर्काइव पर विषय और खोज फिल्टर का उपयोग कर सकते हैं, जैसे प्रकाशन स्थान, समयावधि और विषय।

![खोज फ़िल्टर](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 जुलाई, 2025

मैंने इंटरनेट आर्काइव से लगभग 500 टेक्स्ट फाइलें डाउनलोड कीं और उन्हें साफ करने (सिर्फ व्हाइटस्पेसेस, गुटेनबर्ग हेडर आदि हटाने) के बाद मेरे पास लगभग 500MB डेटा है। यह एक बहुत छोटा डेटासेट है लेकिन पिछली बार मैंने 187MB से प्रशिक्षण लिया था, तो इस बार मॉडल के आउटपुट में कम से कम कुछ स्पष्ट अंतर दिखना चाहिए। मुझे उम्मीद है कि यह मॉडल कम से कम अधिक सुसंगत वाक्य बना सकेगा जो किसी हद तक समझ में आएं। यह निश्चित नहीं है क्योंकि यह अब भी बहुत ही छोटा डेटासेट है, लेकिन पिछली बार से ज्यादा है।

यह मेरे अपने हार्डवेयर पर संभव है, यह अच्छा है क्योंकि मैं शायद बड़े डेटासेट पर जाने से पहले कुछ सुधार देख सकूं, जिसके लिए मुझे GPU किराए पर लेना पड़ेगा। लेकिन चिंता न करें मैं जल्द ही GPU किराए पर लेने की योजना बना रहा हूं, पर उससे पहले मैं चाहता हूं कि मेरा डेटासेट जितना संभव हो सके उतना क्यूरेटेड और साफ हो। मेरी एक समस्या है सफाई, इन टेक्स्ट फाइलों में काफी बकवास मिली-जुली होती है। सफाई के लिए जो स्क्रिप्ट्स इस्तेमाल की हैं वे काम करती हैं लेकिन 100% प्रभावी नहीं हैं।

मैं आज इस डेटासेट को प्रशिक्षित करूंगा और इसमें लगभग 4-5 घंटे लगने चाहिए। जब यह पूरा हो जाएगा और मैं इसका परीक्षण करूंगा, मैं अपडेट दूंगा। एक बार फिर धन्यवाद सभी को जो मेरी परियोजना देख रहे हैं, कुछ लोगों ने मुझे तो OCR संसाधनों के लिंक भी दिए हैं, इसलिए धन्यवाद! मुझे उम्मीद है और लोग भी इसे आजमाएं और अपने खुद के डेटासेट्स के साथ प्रयोग करें।


### प्रशिक्षण अद्यतन

मैंने 435MB (108 मिलियन टोकन) के कॉर्पस पर प्रशिक्षण शुरू किया, अभी तक यह काफी स्मूद चल रहा है। ट्रेन लॉस 10.9 से गिरकर पहले 2800 इटरेशनों में 4.9 हो गया। मुझे उम्मीद है कि पूरा होने में लगभग 8 या 9 घंटे लगेंगे। पूरा होने पर एक और अपडेट पोस्ट करूंगा।

## 17 जुलाई, 2025 2:13AM

दूसरे मॉडल का प्रशिक्षण पूरा हो गया है, मेरे 4060 GPU को इसमें लगभग 8 घंटे 40 मिनट (3,900 इटर्स/घंटा) लगे 33,000 इटरेशनों (5 इपॉक्स) के लिए। अंतिम ट्रेन लॉस 3.73 था। आउटपुट्स आश्चर्यजनक रूप से अच्छे थे, अब यह वास्तव में 19वीं सदी के अंदाज में सुसंगत वाक्य बना रहा है।

## 28 जुलाई, 2025

मैंने v0.5 को Hugging Face पर अपलोड कर दिया है, [यहां देखें](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) अगर आप चाहें। अब आप मेरी रेपो डाउनलोड कर सकते हैं और लोकली चला सकते हैं। दुर्भाग्यवश nanoGPT हगिंगफेस के साथ नेटिवली काम नहीं करता, तो आपको मॉडल डाउनलोड करके लोकली चलाना होगा।

साथ ही मैं अपने अगले प्रशिक्षण रन के लिए डेटा क्यूरेट करना शुरू करूंगा, मुझे लगता है कि तर्क क्षमताएं पाने के लिए शायद 5-10 गुना अधिक डेटा चाहिए।


# V0 मॉडल व्यवहार और सीमाएँ

प्रारंभिक प्रॉम्प्ट्स दिखाते हैं कि मॉडल 1800 के दशक की भाषा और व्यवहार में उत्तर दे रहा है। उदाहरण के लिए, मैंने इसे पूछा "Who art Henry?" और इसने जवाब दिया "I know that man, I have did not a black, the storm." और हां, उस वाक्य का कोई अर्थ नहीं बनता लेकिन एलएलएम समझ रहा है कि मैं किसी व्यक्ति के बारे में पूछ रहा हूं।

![TimeLockLLM नमूना आउटपुट](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

यहाँ आधुनिक अवधारणाओं का कोई उल्लेख नहीं है, आउटपुट में अधिकांश शब्द और वाक्य संरचना 1800 के दशक की है।

इसे अभी भी बहुत काम की जरूरत है, 187MB से प्रशिक्षण करने पर आपको ऐसा मॉडल नहीं मिलेगा जो जटिल तर्क के साथ पाठ उत्पन्न करे।

अभी यह ऐसे वाक्य बनाता है जिनमें पूर्ण वाक्य संरचना की कमी है और कुल मिलाकर कोई मतलब नहीं बनता, लेकिन यह प्रशिक्षण आकार के लिए सामान्य है।

# V0.5 मॉडल व्यवहार और सीमाएँ

यह पिछले मॉडल की तुलना में एक अच्छा सुधार है। लेखन शैली और शब्दावली विक्टोरियन है और लगभग हर वाक्य व्याकरणिक रूप से सही है और उचित विराम चिह्नों के साथ है। और फिर से, यह शुरू से प्रशिक्षित किया गया है इसलिए यह 1800 के दशक के विषयों तक ही सीमित रहता है।

![TimeLockLLM नमूना आउटपुट](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

यहाँ बहुत सारे तथ्यात्मक भ्रम हैं। बहुत सारे (लगभग 100%) विवरण (तिथियाँ, घटनाएँ, ऐतिहासिक व्यक्ति) मनगढ़ंत हैं। साथ ही वाक्य एक-दूसरे से सच में नहीं जुड़ते, कभी-कभी शायद 2 वाक्य आपस में संबंधित हों लेकिन उससे अधिक नहीं। एक और समस्या यह है कि कभी-कभी “Digitized by Google” फुटर आ जाता है, इसलिए अगली बार प्रशिक्षण में मुझे यह सुनिश्चित करना होगा कि पाठ्य सामग्री अच्छी तरह से साफ की जाए। कुल मिलाकर मैं परिणामों से बहुत खुश हूँ, यह अभी LLM नहीं है लेकिन निश्चित रूप से वाक्य उत्पन्न करने वाला है।

मैं बहुत कुछ सीख रहा हूँ और अगले कुछ हफ्तों में समझने की कोशिश करूँगा कि क्या बेहतर करना है। मैं जल्द ही फाइलें अपलोड करूँगा!

# आगामी योजनाएँ

(पूरा हो गया) मैं संस्करण 0.5 पर काम शुरू करूँगा, 50 पुस्तकों का उपयोग करने के बजाय, मैं आदर्श रूप से 500-600 का उपयोग करूँगा। अभी मैं 1800-1850 की पुस्तकों का उपयोग करके nanoGPT को प्रशिक्षित कर रहा हूँ, और विशेष रूप से लंदन से। कुछ चुनौतियाँ हैं, जैसे यह सुनिश्चित करना कि जो पुस्तकें मिल रही हैं वे अद्यतन नहीं हैं या उनमें आधुनिक व्याख्याएँ नहीं हैं, बल्कि मेरी चुनी गई समयावधि में प्रकाशित मूल पुस्तकें हैं।

मैं एक नया मॉडल (v1) एक बहुत बड़े कॉर्पस के साथ प्रशिक्षित करना चाहता हूँ, शायद v0.5 के मुकाबले 5-10 गुना बड़ा। मेरा लक्ष्य है देखना कि क्या केवल Selective Temporal Training से तर्क क्षमताएँ उभर सकती हैं, यह अधिक कठिन कार्य होगा और मैं पूरी तरह से निश्चित नहीं हूँ कि यह संभव है क्योंकि ऐतिहासिक डेटा की सीमाएँ हैं। आने वाले हफ्तों में मैं 5-10GB डेटा संग्रह करने की कोशिश करूँगा। मुझे विश्वास है कि यदि मुझे साफ और उच्च गुणवत्ता वाला डेटा मिल गया और एक GPU किराए पर ले लिया, तो प्रगति होगी।

# इस परियोजना का उपयोग कैसे करें

यह परियोजना मुख्य रूप से ऐतिहासिक डेटा संग्रह, प्रशिक्षण के लिए उसकी तैयारी और एक टोकनाइज़र बनाने पर केंद्रित है। मैं पूरी LLM प्रशिक्षण प्रक्रिया को कवर नहीं कर रहा, उसके लिए Andrej Karpathy की nanoGPT देखें।

# चरण 1: ऐतिहासिक ग्रंथ एकत्र करें और तैयार करें

अपने चुने हुए समय काल (जैसे, लंदन 1800-1850) से सार्वजनिक डोमेन की पुस्तकों, दस्तावेज़ों आदि की .txt फाइलें इकट्ठा करें।

यदि आपको आवश्यकता हो तो download_texts_improved.py का उपयोग करके पुस्तकें डाउनलोड कर सकते हैं।

पाठ्य फाइलों को स्क्रिप्ट से या मैन्युअली साफ करें, जैसे Project Gutenberg के हेडर/फुटर, आधुनिक एनोटेशन या OCR त्रुटियाँ हटाएँ।

prepare_dataset.py ठीक से काम करेगा।

# चरण 2: एक कस्टम टोकनाइज़र बनाएं

साफ किए गए डेटा पर train_tokenizer.py या train_tokenizer_hf.py चलाएँ।
यह आपको vocab.json और merges.txt देगा।

ये फाइलें आपके मॉडल के लिए शब्दावली और मर्ज नियम परिभाषित करती हैं।

# चरण 3: अपने मॉडल को प्रशिक्षित करें (nanoGPT)

प्रशिक्षण प्रक्रिया के लिए [Andrej Karpathy का nanoGPT](https://github.com/karpathy/nanoGPT) देखें।

यदि चाहें तो आप कोई अन्य LLM प्रशिक्षित कर सकते हैं, लेकिन मैंने nanoGPT का उपयोग किया।

# अक्सर पूछे जाने वाले प्रश्न (FAQ)

## Selective Temporal Training क्या है?

Selective Temporal Training (STT) एक मशीन लर्निंग पद्धति है जिसमें सभी प्रशिक्षण डेटा को विशेष रूप से एक विशिष्ट ऐतिहासिक कालखंड के भीतर चुना जाता है। इसका उद्देश्य उस युग की भाषा और ज्ञान का मॉडल तैयार करना है, आधुनिक अवधारणाओं के प्रभाव के बिना। उदाहरण के लिए, मेरे पास जो वर्तमान मॉडल है (v0.5) वह विशेष रूप से 1800-1875 के डेटा पर प्रशिक्षित है, यह फाइन ट्यून नहीं किया गया बल्कि शुरू से प्रशिक्षित किया गया है, जिससे आउटपुट उस समय की भाषाई शैली और ऐतिहासिक संदर्भ को दर्शाता है।

## बस फाइन-ट्यूनिंग या LoRA क्यों नहीं?

इस परियोजना के लिए मैं एक ऐसा भाषा मॉडल बनाना चाहता हूँ जो आधुनिक पक्षपात से मुक्त हो। यदि मैं GPT-2 जैसी किसी चीज को फाइन-ट्यून करता हूँ, तो वह पहले से प्रशिक्षित है और वह जानकारी हटाई नहीं जा सकती। यदि मैं शुरू से प्रशिक्षण करूँ तो भाषा मॉडल पुराने जैसा बनने का नाटक नहीं करेगा, वह सचमुच वैसा ही होगा। इस परियोजना का उद्देश्य फिलहाल यही है कि वह केवल 1800 से 1850 के बीच प्रकाशित लंदन की पुस्तकों के ज्ञान का उपयोग करके तर्क कर सके।

## आपने प्रशिक्षण के लिए किस प्रकार का डेटा उपयोग किया?

मैं 1800-1850 के लंदन की पुस्तकें, कानूनी दस्तावेज, समाचारपत्र और अन्य लेखन सामग्री उपयोग कर रहा हूँ। मैंने जो सूची लिंक की है उसमें लगभग 200 हैं, लेकिन पहली बार प्रशिक्षण के लिए मैंने केवल 50 फाइलें उपयोग कीं जिनका आकार लगभग ~187 MB था। आप दस्तावेजों की सूची यहाँ देख सकते हैं:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## संस्करण 0 मॉडल कितना बड़ा है?

यह मॉडल अभी बहुत छोटा है, मैं यह सिर्फ मजे के लिए कर रहा हूँ और एक सख्त प्रशिक्षण नियम का पालन कर रहा हूँ कि कोई आधुनिक स्रोत न हो। इसमें लगभग 16 मिलियन पैरामीटर हैं लेकिन मैं और पुराने ग्रंथ इकट्ठा कर रहा हूँ ताकि अगला मॉडल प्रशिक्षण शुरू कर सकूँ। जैसे-जैसे प्रगति होगी मैं अपडेट दूँगा।

## प्रशिक्षण विनिर्देश?

GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-02

---