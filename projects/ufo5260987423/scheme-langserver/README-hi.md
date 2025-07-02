<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

आप मेरा [पेपर](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf) पढ़ सकते हैं और इस प्रकार उद्धृत कर सकते हैं 
> WANG, Z. (2025, मई 12). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

चूंकि GitHub चीनी आईपी एड्रेस को ब्लॉक कर सकता है, मुझे इस रिपॉजिटरी को [यहाँ](https://codeberg.org/ufo5260987423/scheme-langserver) और [यहाँ](https://gitee.com/ufo5260987423/scheme-langserver) कॉपी करना पड़ा। मैं सभी रिपॉजिटरी को लगातार अपडेट करता रहूंगा लेकिन मैं गारंटी नहीं दे सकता। मैं अब [XmacsLabs](https://github.com/XmacsLabs) के साथ भी सहयोग कर रहा हूं, आप एक fork [यहाँ](https://github.com/XmacsLabs/scheme-langserver) भी पा सकते हैं।

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**अब, VSCode scheme-langserver का उपयोग कर सकता है!** कृपया [यहाँ देखें](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)।

>नोट: scheme-langserver में बहुत सारी बग्स हैं। मैं इन्हें ठीक कर रहा हूँ और समुदाय से मदद की अपील कर रहा हूँ। कृपया धैर्य रखें।

>नोट: आप ऑटो जनरेटेड टाइप जानकारी [यहाँ](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result) पा सकते हैं। यह अब मुख्य रूप से अगले स्टेज के विकास (शायद AKKU सहित) और डीबगिंग के लिए उपयोग में है।

ऑटोकम्प्लीट, गोटो डिफिनिशन या होवर पर डॉक्यूमेंटेशन जैसे सपोर्ट को लागू करना प्रोग्रामिंग के लिए एक महत्वपूर्ण प्रयास है। हालांकि, अन्य भाषाओं जैसे जावा, पायथन, जावास्क्रिप्ट और सी की तुलना में, लिस्प भाषाओं के लिए लैंग्वेज सर्वर प्रोटोकॉल का कार्यान्वयन लगभग एक वैक्यूम में किया गया है। [Geiser](https://gitlab.com/emacs-geiser), [racket langserver](https://github.com/jeapostrophe/racket-langserver) और [swish-lint](https://github.com/becls/swish-lint) आदि, इन सभी का कार्य `repl` (Read-Eval-Print Loop) या कीवर्ड टोकनाइज़र पर आधारित है, न कि वास्तविक प्रोग्रामिंग पर। उदाहरण के लिए, यदि कोई प्रोग्रामर किसी अधूरे प्रोजेक्ट पर कोडिंग कर रहा है, जिसमें कोड पूरी तरह से निष्पादन योग्य नहीं हैं, तो [Geiser](https://gitlab.com/emacs-geiser) या अन्य केवल टॉप-लेवल बाइंडिंग आइडेंटिफायर को ही पूरा करेंगे, जिन्हें `environment-symbols` प्रक्रिया (जैसे [Chez](https://cisco.github.io/ChezScheme/) के लिए) द्वारा सूचीबद्ध किया गया है, या केवल सिंबल्स को पूरा करेंगे, न कि आइडेंटिफायर्स को। इसका अर्थ है कि स्थानीय बाइंडिंग्स और अधूरे कोड्स के लिए, हालांकि प्रोग्रामिंग के लिए प्रयास करना सबसे महत्वपूर्ण माना जाता है, [Geiser](https://gitlab.com/emacs-geiser) और उसके समकक्ष पहचानकर्ता के वैध स्कोप को पहचानने में कोई सहायता नहीं करते। इसी तरह की स्थिति गोटो डिफिनिशन और कई अन्य फंक्शनैलिटीज़ के साथ भी होती है।

एक मुख्य कारण यह है कि, स्कीम और अन्य लिस्प डायलेक्ट्स के लिए, उनके विशाल डेटा सेट और लचीली कंट्रोल संरचनाएं प्रोग्राम एनालिसिस को एक बड़ी चुनौती बना देती हैं। खासकर मैक्रो के कारण, ऐसा लगता है कि स्कीम मुख्य रूप से जीनियस और मेटा/मैक्रो प्रोग्रामिंग के लिए उपयोग होता है। लेकिन मैं ऐसा नहीं मानता। यदि एक बेहतर प्रोग्रामिंग वातावरण प्रदान किया जाए तो स्कीम कई रोचक चीजें कर सकता है। और अब आप [**यहाँ से शुरू करें**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)।

यह पैकेज एक लैंग्वेज सर्वर प्रोटोकॉल इम्प्लीमेंटेशन है जो स्कीम प्रोग्रामिंग में सहायता करता है। यह कम्प्लीशन, डिफिनिशन और टाइप इंफेरेंस प्रदान करता है। ये फंक्शनैलिटीज [r6rs मानक](http://www.r6rs.org/) और अधूरे कोड्स के लिए कुछ स्पष्ट नियमों के साथ स्टैटिक कोड एनालिसिस पर आधारित हैं। यह पैकेज स्वयं और संबंधित लाइब्रेरीज़ [Akku](https://akkuscm.org/) के साथ प्रकाशित की गई हैं या की जाएंगी, जो कि स्कीम के लिए एक पैकेज मैनेजर है। 

यह पैकेज [Chez Scheme](https://cisco.github.io/ChezScheme/) वर्शन 9.4 और 9.5 के साथ भी टेस्ट किया गया है। वर्शन 10.0.0 पर विस्तृत परीक्षण तब किया जाएगा जब मैं अपने लैपटॉप का OS एक नए वर्शन पर अपग्रेड करूंगा।

मैं यह ओपन सोर्स कार्य केवल अपने खाली समय में करता हूँ और मैं समुदाय को कई शानदार विचार दे सकता हूँ, जैसे कि scheme-langserver में डाटा फ्लो एनालिसिस को एम्बेड करना या बहुत कुछ। और मैं लगातार अधिक दान या फंडिंग की मांग कर रहा हूँ। आप [इस Patreon पेज](https://www.patreon.com/PoorProgrammer/membership) या [爱发电](https://afdian.com/a/ufo5260987423) के माध्यम से दान कर सकते हैं।


## संकलन, इंस्टॉलेशन और कॉन्फ़िगरेशन [यहाँ](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md) है

## हाल की स्थिति
मैं बग्स को ठीक करने, कोड का प्रोफाइलिंग करने, और अपने होममेड टाइप इंफेरेंस सिस्टम पर विशाल पुस्तक के लिए जानकारी इकट्ठा करने का काम करता रहूंगा। इसमें मुझे लगभग 1 साल लगेंगे। आगे के विकास में [VScode](https://code.visualstudio.com/) प्लगइन और डाटा फ्लो एनालिसिस शामिल हैं। लेकिन वास्तव में, अब मैं इस ओपन सोर्स कार्य को एक पार्ट-टाइम जॉब बना रहा हूँ, और मैं समय-सीमा की गारंटी नहीं दे सकता।

## रिलीज़ 
1.2.9 अब, टाइप इंफेरेंस का आनंद लें!

पूर्व रिलीज़ के लिए कृपया [इस फ़ाइल](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md) को देखें।

### विशेषताएँ
1. टॉप-लेवल और लोकल आइडेंटिफायर बाइंडिंग कम्प्लीशन।
![टॉप-लेवल और लोकल आइडेंटिफायर बाइंडिंग](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. गोटो डिफिनिशन।
![टेलिस्कोप.nvim के साथ गोटो डिफिनिशन](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. पैकेज मैनेजर: Akku के साथ संगत।
4. फ़ाइल परिवर्तनों का सिंक्रोनाइज़ेशन और संबंधित इंडेक्स परिवर्तन।
5. होवर।
6. रेफरेंस और डॉक्युमेंट हाइलाइट (डॉक्युमेंट-स्कोप्ड रेफरेंस)।
![टेलिस्कोप.nvim के साथ रेफरेंस खोजें](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. डॉक्युमेंट सिंबल।
![टेलिस्कोप.nvim के साथ डॉक्युमेंट सिंबल खोजें](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. *-syntax (define-syntax, let-syntax आदि) आधारित लोकल आइडेंटिफायर बाइंडिंग को पकड़ना। 
9. क्रॉस-प्लेटफॉर्म पैरेलल इंडेक्सिंग।
10. .sps फ़ाइलों के साथ संगतता के लिए स्वयं-निर्मित सोर्स कोड एनोटेटर।
11. सस्पेंडेबल टास्क के साथ API रिक्वेस्ट के लिए पीपहोल ऑप्टिमाइज़ेशन।
12. होममेड DSL इंटरप्रेटर के साथ टाइप इंफेरेंस (मुझे इस पर बहुत गर्व है!)। और अब यह ऑटो-कम्प्लीशन में एम्बेड किया गया है। जैसा कि निम्न चित्र में दिखाया गया है, "length-b" और "length-a" जिनका "integer?" प्रकार है, वे उन अनुशंसित विकल्पों के सामने हैं क्योंकि वे "<=" से अपेक्षित पैरामीटर टाइप से मेल खाते हैं।
![टाइप इंफेरेंस के साथ ऑटोकम्प्लीशन](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
एक टेस्ट से इस परिणाम की पुष्टि हो सकती है, बस `scheme --script tests/protocol/apis/test-completion.sps` चलाएं और लॉग फ़ाइल `scheme-langserver.log` में इस तरह के परिणाम होंगे:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. विभिन्न फ़ाइल एक्सटेंशन जैसे scm, ss, sps, sls और sld के बीच आइडेंटिफायर पकड़ने के लिए एब्सट्रैक्ट इंटरप्रेटर।

### TODOs
14. रिनेमिंग।
15. [r6rs मानक](http://www.r6rs.org/) के साथ पूरी तरह संगत।
16. स्टेप-बाय-स्टेप मैक्रो एक्सपैंडर: दरअसल, मैंने एक बना भी लिया है और मैं चाहता था कि यह स्वयं-परिभाषित मैक्रो में आइडेंटिफायर बाइंडिंग पकड़ने का एक मुख्य कदम बने। अब, मुझे लगता है कि यह पकड़ना मेरी सोच से कहीं ज्यादा कठिन है, और एक्सपैंडर कहाँ काम कर सकता है, मुझे नहीं पता।
17. कोड ईवाल।
18. कोड डायग्नोस्टिक।
19. क्रॉस-लैंग्वेज सेमांटिक सपोर्टिंग जोड़ें। क्या जावा, सी, पायथन और कई अन्य भाषाओं को AST ट्रांसफार्मर के साथ सपोर्ट किया जा सकता है?
20. एक्सप्रेशन/स्टेटमेंट्स को एक प्रोसीजर में एक्सट्रैक्ट करें।

## TODO: योगदान

## डिबग

### कैसे डिबग करें
https://www.scheme.com/debug/debug.html#g1

### आउटपुट लॉग
[Building](#building), [Installation for Lunar Vim](#installation-for-lunarvim) और [Installation for VScode](#todo-installation-for-vscode) के टिप्स को फॉलो करते हुए, यदि कोई डेवलपर कुछ डेवलपमेंट करना चाहता है और कुछ लॉग करना चाहता है, तो `path-to-log-file` जोड़ना और फाइल `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` को निम्नानुसार फिर से लिखना सुविधाजनक रहेगा:
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
`scheme-langserver`, एक लैंग्वेज सर्वर प्रोटोकॉल इम्प्लीमेंटेशन फॉर स्कीम
]]   ,
  },
}
```
### लॉग के साथ पुनरावृत्ति 
ऊपर दिए गए [आउटपुट लॉग](#output-log) के साथ, आप `tests/log-debug.sps` का उपयोग करके बग्स की पुनरावृत्ति कर सकते हैं:
1. `{path-to-log}` (आमतौर पर `~/scheme-langserver.log`) का नाम बदलकर `~/ready-for-analyse.log` रखें;
2. `scheme --script tests/log-debug.sps` चलाएं। यदि आप मल्टी-थ्रेड एनवायरनमेंट को फिर से प्रोड्यूस करना चाहते हैं, तो `scheme --script tests/log-debug.sps` चलाना भी संभव है।

## टेस्ट
लगभग सभी प्रमुख प्रोसीजर और API का परीक्षण किया गया है। मेरा काम बहुत रफ लेकिन उपयोगी है, शायद आप `tests` डायरेक्टरी में देखना चाहेंगे या `{scheme-langserver-root-directory}` में निम्नलिखित कमांड चलाएं:
``` bash
bash test.sh
```
>नोट
थ्रेडेड एनवायरनमेंट के साथ टेस्ट करना कठिन है। इसलिए, वर्तमान टेस्ट सिंगल थ्रेड पर केंद्रित हैं।

## अन्य उद्देश्यों के लिए Scheme-langserver का उपयोग करें
### GIMP में Script-Fu
Script-Fu एक इंटरप्रेटेड भाषा स्कीम पर आधारित है, और GIMP के आंतरिक फंक्शनों के साथ इंटरैक्ट करने वाले फंक्शनों का उपयोग करके काम करता है। [इस पेज](https://dalelane.co.uk/blog/?p=628) के स्क्रिप्ट को उदाहरण के रूप में लेते हुए, आप "SCM" एक्सटेंशन वाली स्क्रिप्ट फाइल के साथ scheme-langserver का उपयोग कर सकते हैं।

### अन्य

मैं [OMN (Opusmodus Notation)](https://opusmodus.com/) और AutoLisp में भी रुचि रखता हूँ। लेकिन मुझे अभी भी बहुत कुछ करना है।

## कोड काउंट
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## विस्तृत दस्तावेज़
1. [Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf)।
2. [Catching identifier bindings](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [Synchronizing](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [Type inference](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md),~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(डिप्रिकेटेड, और मैं इसके लिए एक चीनी किताब लिख रहा हूँ)
5. [API Analysis](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## स्टार हिस्ट्री

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## योगदानकर्ता

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---