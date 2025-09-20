<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Xbox_SMC
मूल Xbox से PIC16/Xyclops डम्प्स और IDA डेटाबेस जिसमें कुछ रिवर्स इंजीनियरिंग की गई है।

![मूल Xbox से PIC16LC63A की छवि](https://raw.githubusercontent.com/Prehistoricman/Xbox_SMC/master/pic16lc63a.jpg)

# Xyclops फ्लैशिंग (XycloMod)
[ Xyclops डायरेक्टरी और README ](/Xyclops) देखें


# डम्प्स
हर PIC डम्प के लिए .bin फ़ाइल में बाइट्स को IDA में सही लोडिंग के लिए स्वैप किया गया है। इसलिए PIC मेमोरी का पहला वर्ड byte_0 + byte_1 << 8 है।

.idb IDA डेटाबेस में वेरिएबल की जानकारी और डेटाबेस नोटपैड पर कुछ टिप्पणियाँ हैं।

SMC वर्शन के विभाजन के लिए इस विकी पेज को देखें: https://xboxdevwiki.net/Xboxen_Info

## B2A
DVT3 Xbox से डम्प किया गया। वही कॉन्फ़िग वर्ड है जैसा P01 में है। इसमें डिवाइस आईडी भी कॉन्फ़िग क्षेत्र में 0000 0000 000B 002A के रूप में जली हुई है, जो प्रोडक्शन PICs से अलग है।

इसमें बूट चैलेंज पूरी तरह से गायब है।

## D01
XDK BETA 2 Xbox से डम्प किया गया। बूट चैलेंज के अलावा P01 के समान है। अपेक्षित बूट चैलेंज रिस्पॉन्स की गणना करने वाला फंक्शन अभी भी है, लेकिन कभी कॉल नहीं होता।

## DXF
XDK D2 डिबग किट से डम्प किया गया। D01 के बहुत समान है लेकिन ट्रे लॉजिक, ओवरहीट लॉजिक और बूट लॉजिक में थोड़ा अंतर है। बूट चैलेंज D01 की तरह गायब है।

## D2E
Tuscany (v1.6) डेव किट से डम्प किया गया। Xyclops चिप X01202-001 के रूप में चिह्नित है, और उसमें वह A-A02 या A-B01 लाइन गायब है जो रिटेल यूनिट्स में होती है।

FC00 पर डिबग सीरियल कोड रिटेल P2L डम्प से मेल खाता है। 0x4000 से 0xFBFF तक डेटा का एक अजीब पैटर्न है।

## P01
v1.0 Xbox से डम्प किया गया। कॉन्फ़िग वर्ड 0x86 है:
- CP1:CP0 = 0 (पूरी मेमोरी के लिए कोड प्रोटेक्शन सक्षम)
- BODEN = 0 (ब्राउन-आउट रीसेट अक्षम)
- ~PWRTE = 0 (पावर-अप टाइमर सक्षम)
- WDTE = 1 (वॉचडॉग टाइमर सक्षम)
- FOSC1:FOSC0 = 2 (HS ऑस्सीलेटर)

SMC क्लोन्स के लिए 0x3FB6 का कॉन्फ़िग मान उपयुक्त है ताकि उनमें कोड प्रोटेक्शन सक्षम न हो।

## P11
v1.3 Xbox से डम्प किया गया। वही कॉन्फ़िग वर्ड है जैसा P01 में।

P11 में P01 की तुलना में कुछ छोटे बदलाव हैं जिनमें एक अतिरिक्त SMBus कमांड (write 0x22), अलग LED प्राथमिकताएँ, और बूट के लिए अधिक लचीले समय शामिल हैं।

मैंने v1.3 के scrambled डम्प्स को v1.4 से मिलाया और वे मेल खाते हैं। इसका मतलब है कि इनके पास वही प्रोग्राम होने की संभावना बहुत अधिक है।

## P2L
v1.6 Xbox से डंप किया गया। Xyclops संशोधन A-A02। इसमें Intel 8051 कोड है लेकिन इसमें कई विशेष फंक्शन रजिस्टर हैं जिनका कार्य अज्ञात है।

डिबग सीरियल FC00 पर कोड द्वारा संचालित होता है। यह एक साधारण डिबगर जैसा लगता है जो निष्पादन को रोक सकता है, डेटा डंप कर सकता है, और रजिस्टर/RAM में लिख सकता है।

# Xyclops डंपिंग

Xyclops चिप में 'डिबग' के लिए 3 पिन हैं: TXD (पिन 64), RXD (पिन 63), और DEBUG (पिन 29)। सीरियल पोर्ट को TX और RX पिन पर सक्षम करने के लिए DEBUG पिन को हाई सेट करें। सीरियल 9600 बाउड पर ऑपरेट करता है।

प्रोटोकॉल 4-बाइट कमांड पर आधारित है जो आमतौर पर इस प्रारूप में होते हैं `<cmd>` `<address MSByte>` `<address LSByte>` `<don't care>`

कमांड 0x14 एक बार में 64 बाइट BIOS डेटा डंप करता है और 0x15 एक बार में 64 बाइट SMC प्रोग्राम डेटा डंप करता है। Xyclops का एक डंप, P2L.bin, रिपॉजिटरी में शामिल है। [xyclops_dumper.py](/Xyclops/xyclops_dumper.py) भी शामिल है ताकि आप अपनी मशीन का डंप निकाल सकें।

# PIC डंपिंग कार्यप्रणाली
पूरा विवरण https://wiki.recessim.com/view/PIC_Burnout पर है

PIC में कोड सुरक्षा सक्षम है जिससे सभी डेटा 0000 के रूप में पढ़ता है। मैंने एक ट्रिक का इस्तेमाल किया जिससे स्क्रैम्बल्ड डेटा आउटपुट मिला, एक बलिदान चिप की मदद से स्क्रैम्बलिंग एल्गोरिदम खोजा, और फिर एक प्रकार के एक्सप्लॉइट का उपयोग किया जिससे ROM डेटा में कुछ बिट्स को ज्ञात मानों पर फिक्स किया जा सके। फिर मैं कई स्क्रैम्बल्ड डंप से आवश्यक जानकारी निकाल कर मूल डेटा को पुनः बना सकता हूँ।

# PICProgrammer
PICProgrammer RP2040 के लिए कुछ Arduino प्रोजेक्ट्स में से एक है जिसे मैंने अपने रिसर्च में इस्तेमाल किया। यह PIC पर ICSP (इन-सर्किट सीरियल प्रोग्रामिंग) ऑपरेशन निष्पादित करने के लिए एक साधारण कमांड-लाइन इंटरफेस प्रदान करता है। इसे विशेष रूप से PICkit जैसे प्रोग्रामर की बजाय इसकी लचीलापन और वे विकल्प जो निर्माता ने नहीं सोचे थे, के कारण प्राथमिकता दी जाती है।

इस्तेमाल करने से पहले आपको इलेक्ट्रॉनिक्स और प्रोग्रामिंग की अच्छी समझ होनी चाहिए, और कमांड्स को निष्पादित करने से पहले अच्छे से देख लें कि वे क्या करते हैं।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---