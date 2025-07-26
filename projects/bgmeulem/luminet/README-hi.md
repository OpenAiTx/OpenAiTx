<div align="center">
  
# ल्यूमिनेट
![ci-badge](https://img.shields.io/appveyor/build/bgmeulem/luminet?label=ci&style=flat-square) [![PyPI-badge](https://img.shields.io/pypi/v/luminet?pypiBaseUrl=https%3A%2F%2Fpypi.org&style=flat-square&logo=pypi&logoColor=white&link=https%3A%2F%2Fpypi.org%2Fproject%2Fluminet%2F)](https://pypi.org/project/luminet) [![Documentation Status](https://readthedocs.org/projects/luminet/badge/?version=latest&style=flat-square)](https://luminet.readthedocs.io/en/latest/?badge=latest) ![coverage](https://img.shields.io/codecov/c/github/bgmeulem/Luminet?style=flat-square) ![stars-badge](https://img.shields.io/github/stars/bgmeulem/Luminet?style=flat-square) ![license](https://img.shields.io/github/license/bgmeulem/Luminet?style=flat-square) [![Pixi Badge](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/prefix-dev/pixi/main/assets/badge/v0.json&style=flat-square)](https://pixi.sh)

ल्यूमिनेट (1979) में वर्णित विधियों के आधार पर श्वार्ज़चाइल्ड ब्लैक होल्स का अनुकरण और दृश्यांकन करें।

![ब्लैक होल का उदाहरण प्लॉट](https://raw.githubusercontent.com/bgmeulem/luminet/master/assets/bh_plot.png)
</div>

## ⚡ इंस्टॉल करें
`luminet` PyPI से उपलब्ध है:

```shell
pip install luminet
```

## 📖 [प्रलेखन](https://luminet.readthedocs.io/en/latest/index.html)

## 🔩 उपयोग

इस रिपॉजिटरी में सभी चर प्राकृतिक इकाइयों में हैं: $G=c=1$

```python
from luminet.black_hole import BlackHole
bh = BlackHole(
    mass=1,
    incl=1.5,           # inclination in radians
    acc=1,              # accretion rate
    outer_edge=40
)
```
एक छवि बनाने के लिए:
```python
ax = bh.plot()          # Create image like above
```
अक्रेशन डिस्क पर फोटॉनों का सैंपल लेने के लिए:

```python
bh.sample_photons(100)
bh.photons
```
```
radius  alpha   impact_parameter    z_factor    flux_o
10.2146 5.1946  1.8935              1.1290      1.8596e-05
... (99 more)
```
ध्यान दें कि सैंपलिंग ब्लैक होल के केंद्र की ओर अधिक है, क्योंकि अधिकांश चमक वहीं से आती है।

## 📝 पृष्ठभूमि
श्वार्ज़चिल्ड ब्लैक होल का सबसे भीतरी स्थिर कक्षा $6M$ पर होती है, और एक फोटॉन स्फीयर $3M$ पर होता है। इसका अर्थ है कि
ब्लैक होल के चारों ओर घूमता हुआ एक्रीशन डिस्क $r>6M$ त्रिज्या पर फोटॉनों का उत्सर्जन करता है। जब तक वक्रित अंतरिक्ष में फोटॉन की पेरिजी $3M$ (जिसे फोटॉन स्फीयर भी कहते हैं) से बड़ी बनी रहती है, फोटॉन ब्लैक होल द्वारा पकड़ा नहीं जाता और सैद्धांतिक रूप से किसी प्रेक्षक फ्रेम $(b, \alpha)$ से देखा जा सकता है। स्पेसटाइम का वक्रण सबसे आसानी से एक लेंसिंग प्रभाव के रूप में समझा जा सकता है, जो ब्लैक होल फ्रेम $(r, \alpha)$ और प्रेक्षक फ्रेम $(b, \alpha)$ के बीच होता है। पहले वाले 2D ध्रुवीय निर्देशांक होते हैं जो एक्रीशन डिस्क क्षेत्र को घेरते हैं, और दूसरे 2D ध्रुवीय निर्देशांक होते हैं जो प्रेक्षक फ्रेम की "फोटोग्राफिक प्लेट" को घेरते हैं। बाद वाले को वास्तविक CCD कैमरा मान सकते हैं। फोटॉन कक्षा की पेरिजी और प्रेक्षक फ्रेम में त्रिज्या $b$ सीधे जुड़े हैं:

$$b^2 = \frac{P^3}{P-2M}$$

इससे कई समीकरण काफी सीधे हो जाते हैं।
आप देख सकते हैं कि इस समीकरण के बाईं ओर वर्ग है, जबकि Luminet (1979) में ऐसा नहीं था। मूल पांडुलिपि में कुछ संकेत त्रुटियाँ हैं। मैंने लेखक से इस बारे में संपर्क किया, जिस पर उन्होंने विनम्रता से उत्तर दिया:

> "[...] à l’époque je n'avais pas encore l’expérience de relire très soigneusement les épreuves. Mais mes calculs avaient  heureusement été faits avec les bonnes formules, sinon le résultat visuel n’aurait pas été correct!" 
>
>"उस समय मुझे प्रमाणिकरण को सावधानीपूर्वक दोबारा पढ़ने की आदत नहीं थी। सौभाग्य से, मैंने सही सूत्रों से गणना की थी, नहीं तो चित्र सही नहीं बनता!".

सिर्फ आपको बताने के लिए। मैंने कोशिश की है कि यह कोड कहाँ-कहाँ पेपर से अलग है, नोट करता चलूँ। 

दोनों निर्देशांक प्रणालियों के कोणों के बीच संबंध सरल है, लेकिन दोनों संदर्भ फ्रेमों में त्रिज्या के बीच संबंध भयानक समीकरण 13 द्वारा दिया गया है:

$$\frac{1}{r} = - \frac{Q - P + 2M}{4MP} + \frac{Q-P+6M}{4MP}{sn}^2\left( \frac{\gamma}{2}\sqrt{\frac{Q}{P}} + F(\zeta_\infty, k) \right)$$

यहाँ, $F$ एक अपूर्ण जैकोबियन एलिप्टिक इंटीग्रल है प्रथम प्रकार का, $k$ और $Q$ पेरिजी $P$ के फ़ंक्शन हैं, $\zeta$ $P$ के त्रिकोणमितीय फ़ंक्शन हैं, और $\gamma$ संतुष्ट करता है:

$$\cos(\gamma) = \frac{\cos(\alpha)}{\sqrt{\cos^2\alpha + \cot^2\theta_0}}$$

वक्रित स्पेसटाइम में, आमतौर पर कई फोटॉन कक्षाएँ होती हैं जो एक ही निर्देशांक से निकलती हैं और प्रेक्षक फ्रेम में प्रक्षिप्त होती हैं (जैसे गुरुत्वाकर्षण लेंसिंग और आइंस्टीन क्रॉस देखें)। फोटॉन कक्षाएँ जो ब्लैक होल के चारों ओर मुड़कर प्रेक्षक फ्रेम तक पहुँचती हैं, "हायर ऑर्डर" इमेज या "घोस्ट" इमेज कहलाती हैं। इस मामले में, $\gamma$ संतुष्ट करता है:

$$2n\pi - \gamma = 2\sqrt{\frac{Q}{P}} \left( 2K(k) - F(\zeta_\infty, k) - F(\zeta_r, k)  \right)$$

ये घोस्ट फोटॉन वही हैं, जिन्हें ऊपर दी गई छवि के निचले भाग में देखा जा सकता है, साथ ही वह हल्का सा घेरा जो फोटॉन स्फीयर के चारों ओर पतला सा लिपटा रहता है। जब झुकाव कम एज-ऑन होता है, तब यह घोस्ट इमेज कम स्पष्ट होती है। 

यह रिपॉजिटरी इन समीकरणों को हल करने के लिए `scipy.optimize.brentq` का उपयोग करता है, और Luminet (1979) में प्रस्तुत अवधारणाओं के लिए सुविधाजनक API देता है। `BlackHole` क्लास सबसे स्पष्ट है, लेकिन `Isoradial` क्लास के साथ भी खेलना शैक्षिक है: प्रेक्षक फ्रेम में वे रेखाएँ जो ब्लैक होल फ्रेम में एक ही त्रिज्या से उत्सर्जित फोटॉनों का वर्णन करती हैं। `Isoredshift` क्लास प्रेक्षक फ्रेम में समान रेडशिफ्ट की रेखाएँ देता है।

## 📕 ग्रंथसूची
[1] लुमिने, जे.-पी., [“Image of a spherical black hole with thin accretion disk.”](https://ui.adsabs.harvard.edu/abs/1979A%26A....75..228L/abstract), <i>Astronomy and Astrophysics</i>, vol. 75, pp. 228–235, 1979.

[2] जे.-पी. लुमिने, [“An Illustrated History of Black Hole Imaging : Personal Recollections (1972-2002).”](https://arxiv.org/abs/1902.11196) arXiv, 2019. doi: 10.48550/ARXIV.1902.11196. 




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---