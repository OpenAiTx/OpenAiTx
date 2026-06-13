warbleR: जैवध्वनिक विश्लेषण को सरल बनाएं
================

🌐 **भाषाएँ:**  
[English](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=en) |
[Español](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=es) |
[Français](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fr) |
[Deutsch](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=de) |
[Português](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pt) |
[Italiano](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=it) |
[Русский](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ru) |
[中文 (简体)](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-CN) |
[中文 (繁體)](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-TW) |
[日本語](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ja) |
[한국어](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ko) |
[हिन्दी](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=hi) |
[ไทย](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=th) |
[Nederlands](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=nl) |
[Polski](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pl) |
[العربية](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ar) |
[فارسی](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fa) |
[Türkçe](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=tr) |
[Tiếng Việt](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=vi) |
[Bahasa Indonesia](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=id) |
[অসমীয়া](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=as)

<!-- README.md README.Rmd से उत्पन्न होता है। कृपया उस फाइल को संपादित करें -->
<!-- badges: start -->

[![lifecycle](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![status](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![Project Status: Active परियोजना एक स्थिर, उपयोगी अवस्था तक पहुँच गई है
और सक्रिय रूप से
विकसित की जा रही है।](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![License: GPL
v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![CRAN_Status_Badge](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![Total
Downloads](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Codecov test
coverage](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- badges: end -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="warbleR logo" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR) का उद्देश्य
R में पशु ध्वनिक संकेतों की संरचना के विश्लेषण को आसान बनाना है।
उपयोगकर्ता खुली पहुँच वाली पक्षी रिकॉर्डिंग एकत्र कर सकते हैं या अपने स्वयं के
डेटा को एक वर्कफ़्लो में डाल सकते हैं जो स्पेक्ट्रोग्राफिक विज़ुअलाइज़ेशन और
ध्वनिक पैरामीटर के मापन को आसान बनाता है।
[warbleR](https://cran.r-project.org/package=warbleR) seewave पैकेज के
मौलिक ध्वनि विश्लेषण टूल्स का उपयोग करता है, और ध्वनिक संरचना विश्लेषण के लिए नए
उपकरण प्रदान करता है। ये टूल्स ध्वनिक संकेतों के बैच विश्लेषण के लिए उपलब्ध हैं।

पैकेज की मुख्य विशेषताएँ हैं:

- ध्वनिक संरचना मापने के लिए विविध उपकरण
- चयन तालिका में संदर्भित ध्वनिक संकेतों के माध्यम से कार्यों को लागू करने के लिए लूप्स का उपयोग
- कार्यशील निर्देशिका में स्पेक्ट्रोग्राम्स के साथ छवियों का उत्पादन
  जिससे उपयोगकर्ता डेटा व्यवस्थित कर सकें और ध्वनिक विश्लेषण सत्यापित कर सकें

पैकेज निम्नलिखित कार्य प्रदान करता है:

- [Xeno‐Canto](https://xeno-canto.org/) रिकॉर्डिंग का अन्वेषण और डाउनलोड
- कई ध्वनि फ़ाइलों का अन्वेषण, व्यवस्थित और हेरफेर करना
- संकेतों का स्वचालित पता लगाना (आवृत्ति और समय में) (लेकिन अधिक व्यापक और अनुकूल कार्यान्वयन के लिए R पैकेज [ohun](https://docs.ropensci.org/ohun/) देखें)
- संपूर्ण रिकॉर्डिंग या व्यक्तिगत संकेतों के स्पेक्ट्रोग्राम बनाना
- ध्वनिक संकेत संरचना के विभिन्न माप चलाना
- मापन विधियों के प्रदर्शन का मूल्यांकन करना
- संकेतों को सूचीबद्ध करना
- ध्वनिक संकेतों में विभिन्न संरचनात्मक स्तरों का विशेषण करना
- युगल समन्वय का सांख्यिकीय विश्लेषण
- डेटाबेस और एनोटेशन तालिकाओं का एकीकरण

अधिकांश कार्यों में कार्यों का समानांतरकरण करने की सुविधा है, जो कई प्रोसेसरों में कार्यों का वितरण कर कंप्यूटेशनल





दक्षता। विश्लेषण के प्रत्येक चरण पर प्रदर्शन का मूल्यांकन करने के लिए उपकरण भी उपलब्ध हैं।

## स्थापना

पैकेज को CRAN से निम्न प्रकार स्थापित/लोड करें:


``` r
install.packages("warbleR")

# load package
library(warbleR)
```
नवीनतम विकासात्मक संस्करण को स्थापित करने के लिए
[github](https://github.com/) से आपको R पैकेज
[remotes](https://cran.r-project.org/package=remotes) की आवश्यकता होगी:


``` r
remotes::install_github("maRce10/warbleR")

# load package
library(warbleR)
```

## उपयोग

पैकेज में कई विग्नेट्स शामिल हैं जो इसकी मुख्य विशेषताओं को समझाते हैं।  
[warbleR का परिचय](https://marce10.github.io/warbleR/articles/warbleR.html)  
पैकेज की कार्यक्षमताओं का अवलोकन प्रदान करता है। विग्नेट  
[एनोटेशन डेटा प्रारूप](https://marce10.github.io/warbleR/articles/annotation_data_format.html)  
इनपुट एनोटेशन के लिए आवश्यक प्रारूप का विस्तृत विवरण देता है। वहाँ तीन अतिरिक्त [पैकेज विग्नेट्स](https://marce10.github.io/warbleR/articles/) भी हैं जिनमें  
ध्वनिक विश्लेषण कार्यप्रवाह में कार्यों को व्यवस्थित करने के उदाहरण दिए गए हैं।  

पैकेज का पूरा विवरण (हालांकि थोड़ा पुराना है)  
इस [जर्नल लेख](https://besjournals.onlinelibrary.wiley.com/doi/10.1111/2041-210X.12624) में पाया जा सकता है।  

## अन्य पैकेज

[seewave](https://cran.r-project.org/package=seewave) और  
[tuneR](https://cran.r-project.org/package=seewave) पैकेज  
ध्वनिक विश्लेषण और हेरफेर के लिए कई प्रकार के फ़ंक्शन प्रदान करते हैं। ये अधिकांशतः  
R वातावरण में पहले से आयात किए गए वेव ऑब्जेक्ट्स पर काम करते हैं।  
[baRulho](https://cran.r-project.org/package=baRulho) पैकेज  
ध्वनिक संकेतों की आवास-प्रेरित ह्रास को मापने पर केंद्रित है, जिसमें डेटा इनपुट और आउटपुट  
[warbleR](https://cran.r-project.org/package=warbleR) के समान हैं।  
[Rraven](https://cran.r-project.org/package=Rraven) पैकेज  
R और [Raven साउंड विश्लेषण सॉफ़्टवेयर](https://www.ravensoundsoftware.com/) ([कॉर्नेल लैब ऑफ़ ऑर्निथोलॉजी](https://www.birds.cornell.edu/home)) के बीच  
डेटा के आदान-प्रदान को सरल बनाता है और R में ध्वनिक विश्लेषण कार्यप्रवाह में Raven को  
एनोटेटिंग टूल के रूप में शामिल करने के लिए बहुत उपयोगी हो सकता है।  
[ohun](https://docs.ropensci.org/ohun/) पैकेज  
स्वचालित ध्वनि घटना पहचान पर काम करता है, पहचान प्रक्रियाओं का निदान और  
अनुकूलन करने के लिए फ़ंक्शन प्रदान करता है। [dynaSpec](https://cran.r-project.org/package=seewave)  
डायनामिक स्पेक्ट्रोग्राम (यानी स्पेक्ट्रोग्राम वीडियो) बनाने की अनुमति देता है।  

## उद्धरण








कृपया [warbleR](https://cran.r-project.org/package=warbleR) का उल्लेख निम्नलिखित रूप में करें:

Araya-Salas, M. और Smith-Vidaurre, G. (2017), *warbleR: एक r पैकेज जो पशु ध्वनिक संकेतों के विश्लेषण को सुव्यवस्थित करता है*। Methods Ecol Evol. 8,
184-191।

नोट: कृपया
[tuneR](https://cran.r-project.org/package=tuneR) और
[seewave](https://cran.r-project.org/package=seewave) पैकेजों का भी उल्लेख करें यदि आप
कोई भी स्पेक्ट्रोग्राम-निर्माण या ध्वनिक-मापने के फंक्शन का उपयोग करते हैं





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---