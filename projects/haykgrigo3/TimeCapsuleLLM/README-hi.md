<div align="right">
  <details>
<summary>🌐 भाषा</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)
</details>
</div>


# टाइमकैप्सूल LLM

*एक भाषा मॉडल जिसे **शुरुआत से** विशेष स्थानों और समय अवधियों के डेटा पर प्रशिक्षित किया गया है ताकि आधुनिक पक्षपात को कम किया जा सके और उस युग की आवाज़, शब्दावली और दृष्टिकोण का अनुकरण किया जा सके।*

कल्पना कीजिए कि एक एआई मॉडल केवल ऐतिहासिक बनने का नाटक नहीं करता, बल्कि वास्तव में होता है।

v0 और v0.5 [Andrej Karpathy के nanoGPT](https://github.com/karpathy/nanoGPT) पर आधारित हैं। मुख्य प्रशिक्षण स्क्रिप्ट और मॉडल आर्किटेक्चर उनका कार्य है।

v1 [Microsoft के Phi 1.5](https://huggingface.co/microsoft/phi-1_5) पर आधारित है।

v2 llamaforcausallm पर आधारित है

[Hugging Face लिंक](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## अनुसंधान स्थिति
यह परियोजना स्वतंत्र रूप से प्रारंभ की गई और विकसित की गई थी।

वर्तमान में इसे शैक्षणिक पर्यवेक्षण में, Muhlenberg College में एक संबद्ध अनुसंधान सहयोग के साथ संचालित किया जा रहा है।

## संदर्भ

यदि आप इस डेटा सेट या मॉडल का शैक्षणिक कार्य में उपयोग करते हैं, तो कृपया इसका उल्लेख करें:


```bibtex
@misc{london_llm_1800,
  author = {Grigorian, Hayk and Yaghoobian, Hamed},
  title = {Historic London English (1800–1875)},
  year = {2025},
  publisher = {Hugging Face},
  howpublished = {\url{https://huggingface.co/datasets/postgrammar/london-llm-1800}}
}
```
## विंटेज LLM डिस्कॉर्ड में शामिल हों

अगर आप **ऐतिहासिक भाषा मॉडल**, **समय-विशिष्ट डेटासेट**, या **TimeCapsuleLLM**, **Violet-1.4B**, **Mr. Chatterbox** जैसे प्रोजेक्ट्स के भविष्य में रुचि रखते हैं, तो हमारे समुदाय से जुड़ें।

हम इस सर्वर का उपयोग विचारों पर चर्चा करने, प्रगति साझा करने, और इस क्षेत्र में काम कर रहे अन्य लोगों से जुड़ने के लिए करते हैं।

[डिस्कॉर्ड में शामिल हों](https://discord.gg/JeWkk4z5)

## मॉडल व्यवहार एवं सीमाएँ

### **v0**  

प्रारंभिक प्रम्प्ट्स में मॉडल 1800 के दशक की भाषा और व्यवहार में उत्तर देता है।
उदाहरण: प्रम्प्ट: "Who art Henry?" और जवाब था "I know that man, I have did not a black, the storm."

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- आधुनिक अवधारणाओं का कोई उल्लेख नहीं
- अधिकांशतः युग के अनुरूप शब्दावली
- वाक्य अधिकतर असंगत (लगभग ~187MB ट्रेनिंग डाटा के लिए अपेक्षित)

### **v0.5-london** 

v0 की तुलना में महत्वपूर्ण सुधार।
- विक्टोरियन लेखन शैली, उचित विराम चिन्ह, अधिकतर व्याकरणिक वाक्य
- अभी भी उच्च तथ्यात्मक भ्रम दर
- OCR शोर (“Digitized by Google”) अभी भी आउटपुट में मौजूद

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1-london**

पहला मॉडल जो डेटासेट से किसी वास्तविक ऐतिहासिक घटना को किसी वास्तविक व्यक्ति से जोड़ता है।

उदाहरण: प्रम्प्ट: "It was the year of our Lord 1834"

आउटपुट: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity"

पहले मैंने सोचा कि उसी वर्ष कोई विरोध संयोगवश हुआ होगा, लेकिन इस पर नजर डालें: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)


### **v2mini-eval1-london**

v2 के 90GB डेटासेट में से 15GB सैंपल का उपयोग करके प्रशिक्षित किया गया।
मॉडल केवल 10K स्टेप्स तक प्रशिक्षित किया गया।

टोकनाइज़ेशन में एक समस्या थी जिससे आउटपुट इस तरह दिखता है:

प्रॉम्प्ट:
चार्ल्स डिकेंस कौन हैं?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
सुधारित:

"चार्ल्स डिकेंस कौन हैं? क्या वह अपने उत्कृष्ट प्रेरक कार्यों, अपने नाटकों, ग्रेट कंपनी के फार्म में अधिक करते हैं? मुझे जैक पिकेट से क्या उद्धृत करना है? क्या आप नहीं जानते कि वे दौड़ते हुए या अपनी छाती को काटते हुए, या उस समय क्या किया जाना था जब जैक्सन खिड़की पर देख रहा था, की एक प्रजाति थे? एक अंग्रेज की सफलता क्या है, और जिसे उसका पुत्र मुझसे खोज नहीं पाया है, जिससे इतनी भारी उपलब्धि पूरी की जा सके? क्या आपने कभी पुराने रास्ते में प्रवेश किया है, या हमारे नाव के पैर में एंकर-ब्रीज पर, जिसे आपको छोड़ना होगा? तथ्य यह है कि चाहे शनिवार रात या दोपहर में, या उत्तर की ओर, या अन्यथा, मैदान से हवा उठेगी या नहीं, हमें एक मजबूत बाधा का वर्णन करना पड़ेगा, उसी प्रभाव के साथ जैसा वर्तमान में है। इस स्थिति में, कम से कम, यह कहना ज्यादा नहीं है कि हमने वह कमरा छोड़ दिया है। मुझे विश्वास है कि 'फाइव हंड्रेड-फोल्ड' में तीन प्रतियाँ हैं, जिनका संदर्भ लिया जा सकता है, जैसे हमारे पाठकों की पहली संख्या जो चाहती है [कि]..."

### **v2mini-eval2-london**

उसी 15GB नमूने का उपयोग करके प्रशिक्षित किया गया, जिसका उपयोग eval1 के प्रशिक्षण में किया गया था।
मॉडल फिर से केवल 10K चरणों तक प्रशिक्षित किया गया।

प्रॉम्प्ट: चार्ल्स डार्विन

चार्ल्स डार्विन ECCEMACY. महोदय, — निम्नलिखित मामला मेरे लिए दिलचस्प है : — मैं लंदन में पंद्रह दिन रहा, और मुझे गठिया का हमला बहुत प्रभावित कर गया। पहला गठिया का हमला आपके देखने से एक सप्ताह पहले हुआ था, दूसरा जब मैंने आपको देखा, और तीसरा जब मैंने आपको देखा, और तीसरा उसी समय हुआ। हालांकि, दूसरा गाउट का हमला किसी भी बुखार के लक्षणों के साथ नहीं था, लेकिन पेशाब के प्रवाह में वृद्धि और अधिक मात्रा में पेशाब के साथ था। तीसरा हमला एक घंटे बाद हुआ जब मैंने आपको देखा, और इसके बाद गाउट के दौरे की वापसी हुई, और गाउट की तेजी से वापसी हुई। चौथा हमला भी बुखार के साथ था, लेकिन हमेशा किसी भी बुखार के लक्षणों के साथ नहीं था। गाउट का तीसरा हमला आपके बीमार होने के पंद्रह दिन बाद था, और चौथा गाउट के दौरे के बाद हुआ। चौथा हमला आपके हमला होने के पंद्रह दिन बाद हुआ, और इसके साथ एक भावना थी

### **v2-london**

90GB (112GB टोकनाइज़्ड) डेटासेट का उपयोग करके प्रशिक्षित
182K चरणों तक प्रशिक्षित 

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

### **आगे क्या?**

- TimeCapsuleLLM v3 पर विकास शुरू हो चुका है
- डेटासेट आकार और भौगोलिक कवरेज का विस्तार
- लंदन के अलावा अन्य शहरों तक विस्तार

यह कार्य यूनिवर्सिटी कॉलेज लंदन (UCL) के शोधकर्ताओं के सहयोग से किया जा रहा है और अतिरिक्त संस्थागत भागीदारी पर चर्चा चल रही है। 


##  डेटासेट्स

### **v2**

- 90GB (कच्चे) 1800-1875 लंदन ग्रंथों का संग्रह
- 136,344 दस्तावेज़
- पूरा टोकनाइज़्ड डेटासेट अब यहाँ उपलब्ध है: https://huggingface.co/datasets/postgrammar/london-llm-1800


### पक्षपात आँकड़े
![सर्वनाम पक्षपात](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

![भौगोलिक पक्षपात](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

![कालिक पक्षपात](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

अधिक जानकारी के लिए [v2 पक्षपात रिपोर्ट](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) देखें।


- 


## उपयोग कैसे करें

यह परियोजना मुख्य रूप से ऐतिहासिक डेटा को संकलित करने, प्रशिक्षण के लिए तैयार करने और टोकनाइज़र बनाने पर केंद्रित है। मैं पूर्ण LLM प्रशिक्षण प्रक्रिया को कवर नहीं कर रहा हूँ, इसके लिए Andrej Karpathy का nanoGPT देखें।

### चरण 1: ऐतिहासिक ग्रंथों को इकट्ठा और तैयार करें

- अपनी चुनी हुई समय अवधि (जैसे, लंदन 1800-1875) से सार्वजनिक डोमेन पुस्तकों, दस्तावेज़ों आदि की .txt फाइलें इकट्ठा करें
- इन्हें अपनी चुनी हुई समय/स्थान सीमा के भीतर रखें  
- एक स्क्रिप्ट का उपयोग कर या मैन्युअली Project Gutenberg के हेडर/फुटर, आधुनिक टिप्पणियाँ या OCR त्रुटियों जैसी चीजों को हटाकर टेक्स्ट फाइलों को साफ करें।

### चरण 2: कस्टम टोकनाइज़र बनाएं

- साफ किए गए डेटा पर train_tokenizer.py या train_tokenizer_hf.py चलाएं।
- इससे आपको vocab.json और merges.txt मिलेंगे
- ये फाइलें आपके मॉडल के लिए शब्दावली और विलय नियमों को परिभाषित करती हैं

### चरण 3: अपना मॉडल प्रशिक्षित करें

- प्रशिक्षण प्रक्रिया के लिए [Andrej Karpathy का nanoGPT](https://github.com/karpathy/nanoGPT) या अपनी चुनी हुई आर्किटेक्चर के दस्तावेज़ देखें।

# अक्सर पूछे जाने वाले प्रश्न

## चयनात्मक कालिक प्रशिक्षण क्या है?

चयनात्मक कालिक प्रशिक्षण (STT) एक मशीन लर्निंग पद्धति है जिसमें सभी प्रशिक्षण डेटा को विशेष रूप से एक ऐतिहासिक समय अवधि के भीतर रखा जाता है। इसे उस युग की भाषा और ज्ञान को आधुनिक अवधारणाओं के प्रभाव के बिना मॉडल करने के लिए किया जाता है। उदाहरण के लिए, वर्तमान मॉडल (v0.5) केवल 1800-1875 के डेटा पर प्रशिक्षित है, इसे फाइन ट्यून नहीं किया गया बल्कि शुरू से प्रशिक्षित किया गया जिससे आउटपुट उस समय की भाषिक शैली और ऐतिहासिक संदर्भ को दर्शाता है।

## बस फाइन-ट्यूनिंग या LoRA का उपयोग क्यों नहीं करते?
इस परियोजना के लिए मैं एक ऐसा भाषा मॉडल बनाने की कोशिश कर रहा हूँ जो आधुनिक पक्षपात से मुक्त हो। अगर मैं GPT-2 जैसा कुछ फाइन-ट्यून करता हूँ, तो वह पहले से ही प्री-ट्रेंड होता है और वह जानकारी हटाई नहीं जा सकती। अगर मैं मॉडल को शुरू से ट्रेन करता हूँ तो वह पुराना होने का नाटक नहीं करेगा, बल्कि वास्तव में पुराना होगा। इस परियोजना का लक्ष्य फिलहाल ऐसा कुछ बनाना है जो केवल 1800 से 1875 के बीच लंदन में प्रकाशित पुस्तकों के ज्ञान का उपयोग करके तर्क कर सके।

## आपने प्रशिक्षण के लिए किस प्रकार का डेटा उपयोग किया?

मैं 1800–1875 लंदन की किताबें, कानूनी दस्तावेज़, समाचार-पत्र और अन्य लेखन का उपयोग कर रहा हूँ। जो सूची मैंने लिंक की है (v0 के लिए) उसमें लगभग 200 हैं लेकिन पहले प्रशिक्षण के लिए मैंने केवल 50 फाइलें लगभग ~187 MB उपयोग की हैं। आप दस्तावेजों की सूची देख सकते हैं:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

डेटासेट आकार:
- v0: ~187MB
- v0.5: ~435MB 
- v1: ~6.25GB 
- v2mini-eval1: 15GB (v2 के 90GB का सैंपल)
- v2: 90GB

## मॉडल कितने बड़े हैं?

v0: 16M पैरामीटर्स

v0.5: 123M पैरामीटर्स

v1: 700M पैरामीटर्स

v2mini-eval1: 300M पैरामीटर्स

v2mini-eval2: 200M पैरामीटर्स

v2: 1.2B पैरामीटर्स

## प्रशिक्षण विनिर्देश? 

### v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
रैम: 16GB DDR5.

### v1
GPU: A100 SXM किराए पर लिया गया

### v2mini-eval1/eval2

GPU: A100 SXM किराए पर ली गई

### v2
GPU: H100 SXM किराए पर ली गई

## संबंधित कार्य

- **[talkie-1930-13b](https://talkie-lm.com/introducing-talkie)**
  -  13B पैरामीटर LLM जिसे 1930 से पहले के 260B टोकन टेक्स्ट पर Q&A के साथ प्रशिक्षित किया गया है। इसका एक [base](https://huggingface.co/talkie-lm/talkie-1930-13b-base) संस्करण भी है।
 
- **[Violet 1.4B](https://huggingface.co/zakarth/violet-1b4-chat)**
  -  1.4B पैरामीटर LLM जिसे 1800-1899 के टेक्स्ट्स पर Q&A के साथ प्रशिक्षित किया गया है। इसका एक [160M](https://huggingface.co/zakarth/violet-160m-chat) संस्करण भी है।
 
- **[Mr. Chatterbox](https://huggingface.co/tventurella/mr_chatterbox_model)**
  -  340M पैरामीटर LLM जिसे 1837-1899 के बीच के 28,000 से अधिक टेक्स्ट्स पर Q&A के साथ प्रशिक्षित किया गया है।

- **[Ranke-4B](https://github.com/DGoettlich/history-llms/blob/main/ranke-4b/prerelease_notes.md)** 
  - Qwen3 आर्किटेक्चर पर आधारित 4B पैरामीटर LLMs का एक परिवार, जिसे 80B टोकन के ऐतिहासिक डेटा पर 1913,1929,1933,1939,1946 तक के नॉलेज-कटऑफ के लिए स्क्रैच से प्रशिक्षित किया गया है।

- **[MondadGPT](https://huggingface.co/Pclanglais/MonadGPT)** 
  - MonadGPT, Mistral-Hermes 2 का फाइनट्यून है, जो अंग्रेज़ी, फ्रेंच और लैटिन में 11,000 प्रारंभिक आधुनिक टेक्स्ट्स पर प्रशिक्षित किया गया है, जिनमें से अधिकांश EEBO और Gallica से आए हैं।

## आभार

मैं [डॉ. हामेद याघूबियन](https://hamedyaghoobian.com) का अकादमिक पर्यवेक्षण, अनुसंधान फ्रेमिंग और मूल्यांकन में मार्गदर्शन, और v2 रिलीज़ के लिए टोकनाइज़र प्रशिक्षण और डेटासेट तैयारी में सहायता के लिए धन्यवाद देना चाहता हूँ। उनकी प्रतिक्रिया और अनुभव ने इस कार्य की प्रस्तुति को परिष्कृत करने में महत्वपूर्ण भूमिका निभाई।










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---