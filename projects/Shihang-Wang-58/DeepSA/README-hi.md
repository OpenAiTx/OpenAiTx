[![License: MIT](https://img.shields.io/badge/License-MIT-yellow)](https://github.com/Shihang-Wang-58/DeepSA)
[![PyPI](https://img.shields.io/badge/PyPI-cyan)](https://pypi.org/project/deepsa)

# DeepSA: यौगिक संश्लेषण सुलभता का एक डीप-लर्निंग आधारित भविष्यवक्ता

कृत्रिम बुद्धिमत्ता तकनीक के निरंतर विकास के साथ, अणु निर्माण के लिए अधिक से अधिक डीप-जनरेशन मॉडल उपयोग किए जा रहे हैं। हालांकि, जनरेशन मॉडल द्वारा उत्पन्न अधिकांश नए अणुओं को संश्लेषणीय सुलभता के मामले में अक्सर बड़ी चुनौतियों का सामना करना पड़ता है।

DeepSA यौगिकों की संश्लेषणीय सुलभता की भविष्यवाणी करने के लिए प्रस्तावित है, और संश्लेषण में कठिन अणुओं को पहचानने में इसकी प्रारंभिक समृद्धि दर कहीं अधिक है। यह उपयोगकर्ताओं को संश्लेषण के लिए कम महंगे अणुओं का चयन करने में सहायता करता है, जिससे दवा खोज और विकास का समय कम हो जाता है। आप DeepSA को वेब सर्वर पर https://bailab.siais.shanghaitech.edu.cn/deepsa पर उपयोग कर सकते हैं।<br/>

## आवश्यकताएँ
निम्नलिखित कमांड द्वारा निर्भरताएँ इंस्टॉल की जा सकती हैं:
```bash
conda create -n DeepSA python=3.12
conda activate DeepSA
# gpu संस्करण के लिए
pip3 install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu118
pip3 install autogluon==1.2
pip3 install rdkit
```
### समाचार 🔔 

* 2024-12, [AutoGluon ने अक्टूबर 2024 से python संस्करण 3.8 का समर्थन बंद कर दिया है](https://github.com/autogluon/autogluon/pull/4512)। अतः, हमने DeepSA को Python संस्करण 3.12 पर अपडेट किया है और प्रशिक्षण एवं पूर्वानुमान स्क्रिप्ट्स को नवीनतम AutoGluon संस्करण के अनुरूप संशोधित किया है। DeepSA में आपकी रुचि के लिए धन्यवाद!

* 2023-7, DeepSA_v1.0 जारी किया गया है, कृपया किसी भी मुद्दे पर प्रतिक्रिया देने के लिए स्वागत है!

## डेटा 
विस्तारित प्रशिक्षण एवं परीक्षण डेटासेट को आसानी से https://drive.google.com/drive/folders/1iup6T3Bqyy-uvpdFyP0Of_WQqn-9l62h?usp=sharing से डाउनलोड किया जा सकता है।
## शोधकर्ताओं के लिए उपयोग
यदि आप अपना खुद का मॉडल प्रशिक्षित करना चाहते हैं, तो आप इसे कमांड लाइन से चला सकते हैं,

चलाएँ:
```
    python DeepSA_training.py <dataset.csv/training.csv:test.csv> DeepSA_model ./data/test_set.list
```
यदि आप हमारे द्वारा प्रस्तावित मॉडल का उपयोग करना चाहते हैं,

चलाएँ:
```
    python DeepSA_predict.py <input_data.csv> DeepSA_model
```

## ऑनलाइन सर्वर

हमने एक पूर्व-प्रशिक्षित मॉडल एक समर्पित सर्वर पर तैनात किया है, जो सार्वजनिक रूप से https://bailab.siais.shanghaitech.edu.cn/deepsa पर उपलब्ध है, ताकि बायोमेडिकल शोधकर्ताओं के लिए DeepSA का अपने शोध कार्य में उपयोग करना आसान हो सके।

उपयोगकर्ता अपने SMILES या csv फाइलें सर्वर पर अपलोड कर सकते हैं, और फिर वे जल्दी से पूर्वानुमानित परिणाम प्राप्त कर सकते हैं।

## <span id="citelink">संदर्भ</span>
यदि आपको यह रिपॉजिटरी आपके शोध में उपयोगी लगे, तो कृपया हमारे पेपर को उद्धृत करने पर विचार करें: 

Wang, S., Wang, L., Li, F. et al. DeepSA: a deep-learning driven predictor of compound synthesis accessibility. J Cheminform 15, 103 (2023). https://doi.org/10.1186/s13321-023-00771-3

## संपर्क
यदि आपके कोई प्रश्न हैं, तो कृपया शिहांग वांग (ईमेल: wangshh12022@shanghaitech.edu.cn) या लिन वांग (ईमेल: wanglin3@shanghaitech.edu.cn) से संपर्क करने में संकोच न करें।

पुल रिक्वेस्ट का स्वागत है!

## आभार
हम शंघाईटेक विश्वविद्यालय के HPC प्लेटफॉर्म से मिले समर्थन के लिए आभारी हैं।<br/>
इस कार्य में आपकी रुचि के लिए सभी का धन्यवाद।

![Star History Chart](https://api.star-history.com/svg?repos=Shihang-Wang-58/DeepSA&type=Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---