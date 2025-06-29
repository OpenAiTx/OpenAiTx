# SinGAN

[प्रोजेक्ट](https://tamarott.github.io/SinGAN.htm) | [Arxiv](https://arxiv.org/pdf/1905.01164.pdf) | [CVF](http://openaccess.thecvf.com/content_ICCV_2019/papers/Shaham_SinGAN_Learning_a_Generative_Model_From_a_Single_Natural_Image_ICCV_2019_paper.pdf) | [पूरक सामग्री](https://openaccess.thecvf.com/content_ICCV_2019/supplemental/Shaham_SinGAN_Learning_a_ICCV_2019_supplemental.pdf) | [टॉक (ICCV`19)](https://youtu.be/mdAcPe74tZI?t=3191) 
### पेपर का आधिकारिक PyTorch इम्प्लीमेंटेशन: "SinGAN: Learning a Generative Model from a Single Natural Image"
#### ICCV 2019 सर्वश्रेष्ठ पेपर पुरस्कार (Marr पुरस्कार)


## *एक* इमेज से रैंडम सैंपल
SinGAN के साथ, आप एक ही प्राकृतिक छवि से एक जनरेटिव मॉडल को प्रशिक्षित कर सकते हैं, और फिर दी गई छवि से रैंडम सैंपल जेनरेट कर सकते हैं, उदाहरण के लिए:

![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/teaser.PNG)


## SinGAN के अनुप्रयोग
SinGAN का उपयोग छवि हेरफेर के विभिन्न कार्यों के लिए भी किया जा सकता है, उदाहरण के लिए:
 ![](https://raw.githubusercontent.com/tamarott/SinGAN/master/imgs/manipulation.PNG)
यह पहले से प्रशिक्षित मॉडल में एक छवि इंजेक्ट करके किया जाता है। अधिक विवरण के लिए हमारे [पेपर](https://arxiv.org/pdf/1905.01164.pdf) के अनुभाग 4 को देखें।


### उद्धरण
यदि आप अपने शोध में इस कोड का उपयोग करते हैं, तो कृपया हमारे पेपर का उद्धरण दें:

```
@inproceedings{rottshaham2019singan,
  title={SinGAN: Learning a Generative Model from a Single Natural Image},
  author={Rott Shaham, Tamar and Dekel, Tali and Michaeli, Tomer},
  booktitle={Computer Vision (ICCV), IEEE International Conference on},
  year={2019}
}
```

## कोड

### डिपेंडेंसी इंस्टॉल करें

```
python -m pip install -r requirements.txt
```

इस कोड का परीक्षण python 3.6, torch 1.4 के साथ किया गया था।

कृपया ध्यान दें: यह कोड वर्तमान में केवल torch 1.4 या इससे पहले के संस्करणों का समर्थन करता है, अनुकूलन योजना के कारण।

बाद के torch वर्शन के लिए, आप इस रिपॉजिटरी को आज़मा सकते हैं: https://github.com/kligvasser/SinGAN (परिणाम जरूरी नहीं कि आधिकारिक इम्प्लीमेंटेशन के समान हों।)


###  ट्रेनिंग
SinGAN मॉडल को अपनी खुद की इमेज पर ट्रेन करने के लिए, वांछित ट्रेनिंग इमेज को Input/Images के अंतर्गत डालें, और चलाएँ

```
python main_train.py --input_name <input_file_name>
```

यह प्रशिक्षित मॉडल का उपयोग करते हुए सबसे मोटे स्केल (n=0) से रैंडम सैंपल भी जेनरेट करेगा।

इस कोड को सीपीयू मशीन पर चलाने के लिए, `main_train.py` कॉल करते समय `--not_cuda` निर्दिष्ट करें।

###  रैंडम सैंपल
किसी भी आरंभिक जनरेशन स्केल से रैंडम सैंपल जेनरेट करने के लिए, कृपया पहले वांछित छवि पर SinGAN मॉडल ट्रेन करें (जैसा ऊपर वर्णित है), फिर चलाएँ 

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples --gen_start_scale <generation start scale number>
```

ध्यान दें: फुल मॉडल का उपयोग करने के लिए, जनरेशन स्टार्ट स्केल को 0 पर सेट करें, दूसरी स्केल से जनरेशन शुरू करने के लिए इसे 1 पर सेट करें, और इसी तरह आगे।

###  मनचाहे आकार के रैंडम सैंपल
मनचाहे आकार के रैंडम सैंपल जेनरेट करने के लिए, कृपया पहले वांछित छवि पर SinGAN मॉडल ट्रेन करें (जैसा ऊपर वर्णित है), फिर चलाएँ 

```
python random_samples.py --input_name <training_image_file_name> --mode random_samples_arbitrary_sizes --scale_h <horizontal scaling factor> --scale_v <vertical scaling factor>
```

###  एकल छवि से एनीमेशन

एकल छवि से शॉर्ट एनीमेशन जेनरेट करने के लिए, चलाएँ

```
python animation.py --input_name <input_file_name> 
```

यह स्वचालित रूप से नॉइज़ पैडिंग मोड के साथ एक नई ट्रेनिंग फेज शुरू करेगा।

###  हार्मोनाइजेशन

किसी छवि में पेस्ट किए गए ऑब्जेक्ट को हार्मोनाइज करने के लिए (उदाहरण के लिए Fig. 13 में देखें [हमारे पेपर](https://arxiv.org/pdf/1905.01164.pdf)), कृपया पहले वांछित बैकग्राउंड इमेज पर SinGAN मॉडल ट्रेन करें (जैसा ऊपर वर्णित है), फिर नॉन-हार्मोनाइज्ड रेफरेंस इमेज और उसकी बाइनरी मास्क को "Input/Harmonization" में सेव करें (उदाहरण के लिए सेव्ड इमेज देखें)। कमांड चलाएँ

```
python harmonization.py --input_name <training_image_file_name> --ref_name <naively_pasted_reference_image_file_name> --harmonization_start_scale <scale to inject>

```

कृपया ध्यान दें कि अलग-अलग इंजेक्शन स्केल अलग-अलग हार्मोनाइजेशन प्रभाव देंगे। सबसे मोटा इंजेक्शन स्केल 1 है।

###  एडिटिंग

किसी छवि को संपादित करने के लिए (Fig. 12 में उदाहरण देखें [हमारे पेपर](https://arxiv.org/pdf/1905.01164.pdf)), कृपया पहले वांछित नॉन-एडिटेड इमेज पर SinGAN मॉडल ट्रेन करें (जैसा ऊपर वर्णित है), फिर "Input/Editing" में रेफरेंस इमेज के रूप में नाइव एडिट सेव करें और उसकी संबंधित बाइनरी मैप भी सेव करें (उदाहरण के लिए सेव्ड इमेज देखें)। कमांड चलाएँ

```
python editing.py --input_name <training_image_file_name> --ref_name <edited_image_file_name> --editing_start_scale <scale to inject>
```
दोनों मास्क किए गए और अनमास्क किए गए आउटपुट सेव किए जाएंगे।
यहां भी, अलग-अलग इंजेक्शन स्केल अलग-अलग एडिटिंग इफेक्ट्स उत्पन्न करेंगे। सबसे मोटा इंजेक्शन स्केल 1 के बराबर है।

###  पेंट से इमेज

एक पेंटिंग को यथार्थवादी इमेज में बदलने के लिए (उदाहरण के लिए [हमारे पेपर](https://arxiv.org/pdf/1905.01164.pdf) के चित्र 11 में देखें), कृपया पहले वांछित इमेज पर SinGAN मॉडल को ट्रेन करें (जैसा कि ऊपर बताया गया है), फिर अपनी पेंटिंग को "Input/Paint" में सेव करें, और निम्नलिखित कमांड चलाएँ

```
python paint2image.py --input_name <training_image_file_name> --ref_name <paint_image_file_name> --paint_start_scale <scale to inject>
```
यहां भी, अलग-अलग इंजेक्शन स्केल अलग-अलग एडिटिंग इफेक्ट्स उत्पन्न करेंगे। सबसे मोटा इंजेक्शन स्केल 1 के बराबर है।

एडवांस्ड विकल्प: quantization_flag को True पर सेट करें, ताकि मॉडल के केवल इंजेक्शन लेवल को ही फिर से ट्रेन किया जाए, जिससे पिछले स्केल से अपसैंपल किए गए जेनरेटेड इमेज के कलर-क्वांटाइज्ड वर्शन पर परिणाम प्राप्त हो। कुछ इमेज के लिए, इससे अधिक यथार्थवादी परिणाम मिल सकते हैं।

### सुपर रेजोल्यूशन
किसी इमेज का सुपर रेजोल्यूशन करने के लिए, कृपया चलाएँ:
```
python SR.py --input_name <LR_image_file_name>
```
यह स्वचालित रूप से 4x अपसैंपलिंग फैक्टर के लिए एक SinGAN मॉडल ट्रेन करेगा (अगर पहले से मौजूद नहीं है)।
अलग-अलग SR फैक्टर के लिए, कृपया फंक्शन कॉल करते समय पैरामीटर `--sr_factor` का उपयोग करें।
BSD100 डेटासेट पर SinGAN के परिणाम 'Downloads' फोल्डर से डाउनलोड किए जा सकते हैं।

## अतिरिक्त डेटा और फंक्शन

### सिंगल इमेज फ्रेचेट इन्सेप्शन डिस्टेंस (SIFID स्कोर)
रियल इमेज और उनके संबंधित फेक सैंपल के बीच SIFID निकालने के लिए, कृपया चलाएँ:
```
python SIFID/sifid_score.py --path2real <real images path> --path2fake <fake images path> 
```  
सुनिश्चित करें कि प्रत्येक फेक इमेज की फाइल का नाम उसकी संबंधित रियल इमेज की फाइल के नाम के समान हो। इमेजेज़ `.jpg` फॉर्मेट में सेव होनी चाहिए।

### सुपर रेजोल्यूशन परिणाम
BSD100 डेटासेट पर SinGAN के SR परिणाम 'Downloads' फोल्डर से डाउनलोड किए जा सकते हैं।

### यूज़र स्टडी
यूज़र स्टडी में प्रयुक्त डेटा Downloads फोल्डर में पाया जा सकता है।

real फोल्डर: 50 रियल इमेज, जिन्हें [places database](http://places.csail.mit.edu/) से रैंडमली चुना गया है

fake_high_variance फोल्डर: प्रत्येक रियल इमेज के लिए n=N से शुरू होने वाले रैंडम सैंपल्स

fake_mid_variance फोल्डर: प्रत्येक रियल इमेज के लिए n=N-1 से शुरू होने वाले रैंडम सैंपल्स

अधिक विवरण के लिए कृपया हमारे [पेपर](https://arxiv.org/pdf/1905.01164.pdf) के सेक्शन 3.1 देखें
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---