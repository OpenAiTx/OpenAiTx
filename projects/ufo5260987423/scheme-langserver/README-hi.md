![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

आप मेरा [पेपर](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf) पढ़ सकते हैं और इस तरह उद्धृत कर सकते हैं 
> WANG, Z. (2025, May 12). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

चूंकि GitHub चीनी IP पतों को ब्लॉक कर सकता है, मुझे इस रिपॉजिटरी को [यहाँ](https://codeberg.org/ufo5260987423/scheme-langserver) और [यहाँ](https://gitee.com/ufo5260987423/scheme-langserver) कॉपी करना पड़ा। मैं सभी रिपॉजिटरी को लगातार अपडेट करता रहूंगा लेकिन इसकी गारंटी नहीं दे सकता। मैं अब [XmacsLabs](https://github.com/XmacsLabs) के साथ भी सहयोग कर रहा हूँ, आप एक फोर्क [यहाँ](https://github.com/XmacsLabs/scheme-langserver) भी देख सकते हैं।

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**अब, VSCode scheme-langserver का उपयोग कर सकता है!** कृपया [यहाँ देखें](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)।

>नोट: scheme-langserver में बहुत सारी बग्स हैं। मैं इन्हें ठीक कर रहा हूँ और समुदाय से मदद की अपील कर रहा हूँ। कृपया धैर्य रखें।

>नोट: आप ऑटो जनरेटेड टाइप जानकारी [यहाँ](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result) देख सकते हैं। यह अब मुख्य रूप से अगले चरण के विकास (शायद AKKU सहित) और डिबगिंग के लिए उपयोग की जा रही है।

ऑटोकंप्लीट, गो टू डेफिनिशन, या होवर पर डाक्यूमेंटेशन जैसी सपोर्टिंग सुविधाओं को लागू करना प्रोग्रामिंग के लिए एक महत्वपूर्ण प्रयास है। हालांकि, जावा, पाइथन, जावास्क्रिप्ट और सी जैसी अन्य भाषाओं की तुलना में, लिस्प भाषाओं के लिए लैंग्वेज सर्वर प्रोटोकॉल का कार्यान्वयन शून्य में ही किया गया है। [Geiser](https://gitlab.com/emacs-geiser), [racket langserver](https://github.com/jeapostrophe/racket-langserver) और [swish-lint](https://github.com/becls/swish-lint) आदि, उनके सारे कार्य `repl` (Read-Eval-Print Loop) या कीवर्ड टोकनाइज़र पर आधारित हैं, प्रोग्रामिंग पर नहीं। उदाहरण के लिए, यदि कोई प्रोग्रामर अधूरा प्रोजेक्ट कोडिंग कर रहा है, जिसमें कोड पूरी तरह से निष्पादनीय नहीं है, तो [Geiser](https://gitlab.com/emacs-geiser) या अन्य केवल `environment-symbols` प्रक्रिया (Chez के लिए) द्वारा सूचीबद्ध टॉप-लेवल बाइंडिंग आइडेंटिफायर्स को ही पूरा करेंगे, या प्रतीकों को पूरा करेंगे ना कि पहचानकर्ताओं को। इसका मतलब है कि स्थानीय बाइंडिंग और अधूरे कोड के लिए, जबकि प्रोग्रामिंग का प्रयास महत्वपूर्ण माना जाता है, [Geiser](https://gitlab.com/emacs-geiser) और उसके समकक्ष पहचानकर्ता के वैध स्कोप को पहचानने में कोई सहायता नहीं करते। ऐसे ही मामले गो टू डेफिनिशन और कई अन्य कार्यक्षमताओं के साथ भी होते हैं।

मुख्य कारण यह है कि, scheme और अन्य लिस्प डायलैक्ट के लिए, उनके विशाल डेटा सेट और लचीले नियंत्रण संरचनाएं प्रोग्राम विश्लेषण को एक बड़ी चुनौती बना देती हैं। खासकर मैक्रो, ऐसा लगता है जैसे scheme मुख्य रूप से जीनियस और मेटा/मैक्रो प्रोग्रामिंग के लिए इस्तेमाल होती है। लेकिन मैं ऐसा नहीं मानता। Scheme बहुत सारी रोचक चीजें कर सकती है यदि एक बेहतर प्रोग्रामिंग वातावरण उपलब्ध कराया जाए। और अब आप [**यहाँ से शुरू करें**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)।

यह पैकेज एक लैंग्वेज सर्वर प्रोटोकॉल का कार्यान्वयन है जो scheme प्रोग्रामिंग में सहायता करता है। यह कंप्लीशन, डेफिनिशन और टाइप इंफरेंस प्रदान करता है। ये कार्यक्षमताएँ [r6rs मानक](http://www.r6rs.org/) और अधूरे कोड के लिए कुछ स्पष्ट नियमों के साथ स्थिर कोड विश्लेषण पर आधारित हैं। यह पैकेज स्वयं और संबंधित लाइब्रेरीज़ [Akku](https://akkuscm.org/) के साथ प्रकाशित की गई हैं या प्रकाशित की जा रही हैं, जो Scheme के लिए एक पैकेज मैनेजर है।

यह पैकेज [Chez Scheme](https://cisco.github.io/ChezScheme/) के वर्शन 9.4 और 9.5 के साथ भी टेस्ट किया गया है। वर्शन 10.0.0 पर विस्तृत परीक्षण मेरे लैपटॉप OS को नए वर्शन में अपग्रेड करने के बाद किया जाएगा।

मैं यह ओपन सोर्स कार्य केवल अपने खाली समय में करता हूँ और मैं scheme-langserver में डेटा फ्लो विश्लेषण जैसी कई शानदार आइडियाज समुदाय को दे सकता हूँ। और मैं लगातार अधिक दान या फंडिंग की मांग कर रहा हूँ। आप [इस Patreon पेज](https://www.patreon.com/PoorProgrammer/membership) या [爱发电](https://afdian.com/a/ufo5260987423) के साथ दान कर सकते हैं।


## संकलन, इंस्टॉलेशन और कॉन्फ़िगरेशन [यहाँ](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md) है

## हाल की स्थिति
मैं बग्स को ठीक करता रहूंगा, कोड का प्रोफाइलिंग करता रहूंगा, और अपने homemade टाइप इंफरेंस सिस्टम पर एक विशाल किताब के लिए जानकारी एकत्र करता रहूंगा। इसमें मुझे लगभग 1 साल लगेगा। आगे के विकास में एक [VScode](https://code.visualstudio.com/) प्लगइन और डेटा फ्लो विश्लेषण शामिल हैं। लेकिन वास्तव में, अब मैं इस ओपन सोर्स कार्य को पार्ट-टाइम जॉब की तरह कर रहा हूँ, और मैं समय-सारणी की गारंटी नहीं दे सकता।

## रिलीज़ 
1.2.9 अब, टाइप इंफरेंस का आनंद लें!

पिछली रिलीज़ के लिए कृपया [इस फ़ाइल](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md) को देखें।

### विशेषताएँ
1. टॉप-लेवल और स्थानीय पहचानकर्ता बाइंडिंग कंप्लीशन।
![Top-level and local identifiers binding](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. गो टू डेफिनिशन।
![Goto definition with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. पैकेज मैनेजर: Akku के साथ संगत।
4. फ़ाइल परिवर्तनों का सिंक्रोनाइज़ेशन और संबंधित सूचकांक परिवर्तन।
5. होवर।
6. रेफरेंस और डाक्यूमेंट हाइलाइट (डाक्यूमेंट-स्कोप्ड रेफरेंस)।
![Find references with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. डाक्यूमेंट सिंबल।
![Find document symbols with telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. *-syntax (define-syntax, let-syntax, आदि) आधारित स्थानीय पहचानकर्ता बाइंडिंग को पकड़ना।
9. क्रॉस-प्लेटफॉर्म पैरेलल इंडेक्सिंग।
10. .sps फ़ाइलों के साथ संगतता के लिए स्वयं बनाया स्रोत कोड एनोटेटर।
11. API अनुरोधों के लिए पीपहोल ऑप्टिमाइज़ेशन सस्पेंडेबल टास्क के साथ।
12. एक घरेलू DSL इंटरप्रेटर के साथ टाइप इंफरेंस (मैं इस पर बहुत गर्व करता हूँ!)। और अब यह ऑटो-कंप्लीशन में एम्बेड कर दिया गया है। जैसा कि निम्न चित्र में दिखाया गया है, "length-b" और "length-a" जिनका प्रकार "integer?" है, वे उन अनुशंसित विकल्पों के सामने हैं क्योंकि वे "<=" से आवश्यक पैरामीटर प्रकार से मेल खाते हैं।
![Autocompletion with type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
एक परीक्षण इसका परिणाम सिद्ध कर सकता है, बस `scheme --script tests/protocol/apis/test-completion.sps` चलाएँ और लॉग फ़ाइल `scheme-langserver.log` में इस तरह के परिणाम होंगे:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. विभिन्न फ़ाइल एक्सटेंशन जैसे scm, ss, sps, sls और sld में पहचानकर्ता पकड़ने के लिए एब्स्ट्रैक्ट इंटरप्रेटर।

### TODOs
14. रिनेमिंग। 
15. [r6rs मानक](http://www.r6rs.org/) के साथ पूरी तरह संगत।
16. चरण-दर-चरण मैक्रो एक्सपैंडर: ठीक है, मैंने वास्तव में एक लागू किया है और मैं इसे स्वयं-परिभाषित मैक्रो में पहचानकर्ता बाइंडिंग पकड़ने के लिए एक प्रमुख कदम बनाना चाहता था। अब, मुझे लगता है कि यह पकड़ना मेरी अपेक्षा से कहीं अधिक कठिन है, और एक्सपैंडर मुझे नहीं पता कि कहाँ काम कर सकता है।
17. कोड ईवाल।
18. कोड डायग्नोस्टिक।
19. क्रॉस-लैंग्वेज सेमांटिक सपोर्टिंग जोड़ना। क्या जावा, सी, पाइथन और कई अन्य भाषाओं का समर्थन AST ट्रांसफार्मर से किया जा सकता है?
20. एक्सप्रेशन/स्टेटमेंट्स को एक प्रक्रिया में निकालना।

## TODO: योगदान 

## डिबग

### कैसे डिबग करें
https://www.scheme.com/debug/debug.html#g1

### आउटपुट लॉग
[Building](#building), [Installation for Lunar Vim](#installation-for-lunarvim) और [Installation for VScode](#todo-installation-for-vscode) से संबंधित टिप्स के अनुसार, यदि कोई विकास करना चाहता है और कुछ लॉग करना चाहता है, तो `path-to-log-file` जोड़ना और फ़ाइल `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` को निम्नानुसार फिर से लिखना सुविधाजनक होगा:
```lua
local util = require 'lspconfig.util'
local bin_name = '{path-to-run}'
local cmd = { bin_name ,"path-to-log-file"}

return {
  default_config = {
    cmd = cmd,
    filetypes = { 'scheme' },
    root_dir = util.find_git_ancestor,
    single_file_support = true,
  },
  docs = {
    description = [[
https://github.com/ufo5260987423/scheme-langserver
`scheme-langserver`, a language server protocol implementation for scheme
]]   ,
  },
```
}
```
### लॉग के साथ पुनरावृत्ति 
ऊपर दिए गए [आउटपुट लॉग](#output-log) के साथ, आप `tests/log-debug.sps` का उपयोग पुनरावर्ती बग के लिए कर सकते हैं:
1. `{path-to-log}` (आमतौर पर `~/scheme-langserver.log`) का नाम बदलें और उसे `~/ready-for-analyse.log` रखें;
2. `scheme --script tests/log-debug.sps` चलाएँ। यदि आप मल्टी-थ्रेड वातावरण को फिर से बनाना चाहते हैं, तो `scheme --script tests/log-debug.sps` चलाना भी उपलब्ध है।

## परीक्षण
लगभग सभी मुख्य प्रक्रियाओं और एपीआई का परीक्षण किया गया है। मेरा काम बहुत ही सामान्य लेकिन उपयोगी है, शायद आप यह देखना चाहेंगे कि मैंने `tests` डायरेक्टरी में क्या किया है या निम्नलिखित कमांड को `{scheme-langserver-root-directory}` में चलाएँ:
``` bash
bash test.sh
```
>नोट  
थ्रेडेड वातावरण में परीक्षण करना कठिन है। इसलिए, वर्तमान परीक्षण एकल थ्रेड पर केंद्रित हैं।

## अन्य उद्देश्यों के लिए Scheme-langserver का उपयोग करें
### GIMP में Script-Fu
Script-Fu एक इंटरप्रेटेड भाषा Scheme पर आधारित है, और यह GIMP के आंतरिक कार्यों के साथ इंटरैक्ट करने वाले फ़ंक्शनों का उपयोग करता है। [इस पेज](https://dalelane.co.uk/blog/?p=628) की स्क्रिप्ट का उदाहरण लेते हुए, आप "SCM" एक्सटेंशन वाली स्कीम फ़ाइल के साथ scheme-langserver लागू कर सकते हैं।

### अन्य

खैर, मुझे [OMN (Opusmodus Notation)](https://opusmodus.com/) और AutoLisp में भी रुचि है। लेकिन अभी भी मुझे बहुत कुछ करना है।

## कोड गिनती
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## विस्तृत दस्तावेज़
1. [Scheme-langserver: Scheme कोड संपादन को प्रथम श्रेणी की चिंता के रूप में मानना](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf)।
2. [पहचानकर्ता बाइंडिंग पकड़ना](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [सिंक्रनाइज़ेशन](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [टाइप इनफेरेंस](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(अप्रचलित, और मैं इसके लिए एक चीनी किताब लिख रहा हूँ)
5. [API विश्लेषण](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## स्टार इतिहास

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## योगदानकर्ता

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---