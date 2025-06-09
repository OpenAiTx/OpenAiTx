# StyTr^2 : ट्रांसफॉर्मर के साथ इमेज स्टाइल ट्रांसफर (CVPR2022)
*लेखक: [Yingying Deng](https://diyiiyiii.github.io/), Fan Tang, XingjiaPan, Weiming Dong, Chongyang Ma, Changsheng Xu*

यह पेपर ट्रांसफॉर्मर मॉडल पर आधारित निष्पक्ष इमेज स्टाइल ट्रांसफर प्राप्त करने के लिए प्रस्तावित किया गया है। हम स्टेट-ऑफ-द-आर्ट तरीकों की तुलना में स्टाइलाइजेशन प्रभाव को बढ़ावा दे सकते हैं।
यह रिपोजिटरी [SyTr^2 : Image Style Transfer with Transformers](https://arxiv.org/abs/2105.14576) के आधिकारिक कार्यान्वयन के लिए है।

## परिणाम प्रस्तुति 
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/Unbiased.png" width="90%" height="90%">
</p>
कुछ स्टेट-ऑफ-द-आर्ट एल्गोरिदम की तुलना में, हमारी विधि में कंटेंट लीकेज से बचने की मजबूत क्षमता है और बेहतर फीचर प्रतिनिधित्व क्षमता है।  <br>

## फ्रेमवर्क
<p align="center">
<img src="https://github.com/diyiiyiii/StyTR-2/blob/main/Figure/network.png" width="100%" height="100%">
</p> 
हमारे StyTr^2 फ्रेमवर्क की समग्र पाइपलाइन। हम कंटेंट और स्टाइल इमेज को पैच में विभाजित करते हैं, और इमेज अनुक्रम प्राप्त करने के लिए एक रैखिक प्रक्षेपण का उपयोग करते हैं। फिर CAPE के साथ जोड़े गए कंटेंट अनुक्रम को कंटेंट ट्रांसफॉर्मर एन्कोडर में भेजा जाता है, जबकि स्टाइल अनुक्रम को स्टाइल ट्रांसफॉर्मर एन्कोडर में भेजा जाता है। इन दोनों ट्रांसफॉर्मर एन्कोडर्स के बाद, कंटेंट अनुक्रमों को स्टाइल अनुक्रमों के अनुसार स्टाइलाइज करने के लिए एक मल्टी-लेयर ट्रांसफॉर्मर डिकोडर अपनाया जाता है। अंत में, हम उच्च-रिज़ॉल्यूशन वाली स्टाइलाइज्ड इमेज प्राप्त करने के लिए एक प्रोग्रेसिव अपसैंपलिंग डिकोडर का उपयोग करते हैं।


## प्रयोग
### आवश्यकताएँ
* python 3.6
* pytorch 1.4.0
* PIL, numpy, scipy
* tqdm  <br> 

### परीक्षण 
प्री-ट्रेन्ड मॉडल: [vgg-model](https://drive.google.com/file/d/1BinnwM5AmIcVubr16tPTqxMjUCE8iu5M/view?usp=sharing),  [vit_embedding](https://drive.google.com/file/d/1C3xzTOWx8dUXXybxZwmjijZN8SrC3e4B/view?usp=sharing), [decoder](https://drive.google.com/file/d/1fIIVMTA_tPuaAAFtqizr6sd1XV7CX6F9/view?usp=sharing), [Transformer_module](https://drive.google.com/file/d/1dnobsaLeE889T_LncCkAA2RkqzwsfHYy/view?usp=sharing)   <br> 
कृपया इन्हें डाउनलोड करें और ./experiments/ फोल्डर में रखें  <br> 
```
python test.py  --content_dir input/content/ --style_dir input/style/    --output out
```
### प्रशिक्षण  
स्टाइल डेटासेट WikiArt है, जिसे [WIKIART](https://www.wikiart.org/) से संग्रहित किया गया है  <br>  
कंटेंट डेटासेट COCO2014 है  <br>  
```
python train.py --style_dir ../../datasets/Images/ --content_dir ../../datasets/train2014 --save_dir models/ --batch_size 8
```
### संदर्भ
यदि आप अपने शोध में हमारे कार्य को उपयोगी पाते हैं, तो कृपया हमारे पेपर को निम्नलिखित BibTeX एंट्री का उपयोग करके उद्धृत करें ~ धन्यवाद ^ . ^. पेपर लिंक [pdf](https://arxiv.org/abs/2105.14576)<br> 
```
@inproceedings{deng2021stytr2,
      title={StyTr^2: Image Style Transfer with Transformers}, 
      author={Yingying Deng and Fan Tang and Weiming Dong and Chongyang Ma and Xingjia Pan and Lei Wang and Changsheng Xu},
      booktitle={IEEE Conference on Computer Vision and Pattern Recognition (CVPR)},
      year={2022},
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---