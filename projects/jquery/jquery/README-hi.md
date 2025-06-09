# [jQuery](https://jquery.com/) — न्यू वेव जावास्क्रिप्ट

बैठकें वर्तमान में [matrix.org प्लेटफार्म](https://matrix.to/#/#jquery_meeting:gitter.im) पर आयोजित की जाती हैं।

बैठकों के मिनट्स [meetings.jquery.org](https://meetings.jquery.org/category/core/) पर देखे जा सकते हैं।

jQuery का नवीनतम संस्करण [https://jquery.com/download/](https://jquery.com/download/) पर उपलब्ध है।

## संस्करण समर्थन

| संस्करण | ब्रांच       | स्थिति   |
| ------- | ----------- | -------- |
| 4.x     | मुख्य        | बीटा     |
| 3.x     | 3.x-स्थिर    | सक्रिय   |
| 2.x     | 2.x-स्थिर    | निष्क्रिय|
| 1.x     | 1.x-स्थिर    | निष्क्रिय|

एक बार 4.0.0 फाइनल जारी हो जाने के बाद, 3.x ब्रांच को सीमित समय के लिए अपडेट मिलते रहेंगे। 2.x और 1.x ब्रांच अब समर्थित नहीं हैं।

निष्क्रिय संस्करणों के लिए वाणिज्यिक समर्थन [HeroDevs](https://herodevs.com/nes) से उपलब्ध है।

हमारे [संस्करण समर्थन](https://jquery.com/support/) के बारे में अधिक जानें।

## योगदान गाइड

ओपन सोर्स सॉफ्टवेयर विकास की भावना में, jQuery हमेशा सामुदायिक कोड योगदान को प्रोत्साहित करता है। आरंभ करने में आपकी सहायता के लिए और कोड लिखना शुरू करने से पहले, कृपया इन महत्वपूर्ण योगदान दिशानिर्देशों को अच्छी तरह पढ़ें:

1. [शामिल हों](https://contribute.jquery.org/)
2. [कोर स्टाइल गाइड](https://contribute.jquery.org/style-guide/js/)
3. [jQuery प्रोजेक्ट्स के लिए कोड लेखन](https://contribute.jquery.org/code/)

### इश्यू/पीआर के संदर्भ

GitHub इश्यू/पीआर को आमतौर पर `gh-NUMBER` के रूप में संदर्भित किया जाता है, जहाँ `NUMBER` इश्यू/पीआर का संख्यात्मक आईडी है। आप ऐसा कोई इश्यू/पीआर `https://github.com/jquery/jquery/issues/NUMBER` पर देख सकते हैं।

jQuery ने पहले एक अलग बग ट्रैकर का उपयोग किया था - जो Trac पर आधारित था - जो [bugs.jquery.com](https://bugs.jquery.com/) पर उपलब्ध है। इसे केवल पढ़ने के मोड में रखा गया है ताकि पिछले चर्चाओं का संदर्भ दिया जा सके। जब jQuery स्रोत ऐसे किसी इश्यू का संदर्भ देता है, तो वह पैटर्न `trac-NUMBER` का उपयोग करता है, जहाँ `NUMBER` इश्यू का संख्यात्मक आईडी है। आप ऐसा कोई इश्यू `https://bugs.jquery.com/ticket/NUMBER` पर देख सकते हैं।

## वे वातावरण जिनमें jQuery का उपयोग किया जा सकता है

- [ब्राउज़र समर्थन](https://jquery.com/browser-support/)
- jQuery Node, ब्राउज़र एक्सटेंशन, और अन्य गैर-ब्राउज़र वातावरणों का भी समर्थन करता है।

## अपनी खुद की jQuery बनाने के लिए आपको क्या चाहिए

jQuery बनाने के लिए, आपके पास नवीनतम Node.js/npm और git 1.7 या इससे बाद का संस्करण होना चाहिए। इससे पुराने संस्करण भी काम कर सकते हैं, लेकिन वे समर्थित नहीं हैं।

Windows के लिए, आपको [git](https://git-scm.com/downloads) और [Node.js](https://nodejs.org/en/download/) डाउनलोड और इंस्टॉल करना होगा।

macOS उपयोगकर्ताओं को [Homebrew](https://brew.sh/) इंस्टॉल करना चाहिए। एक बार Homebrew इंस्टॉल हो जाने पर, git इंस्टॉल करने के लिए `brew install git` चलाएँ,
और Node.js इंस्टॉल करने के लिए `brew install node` चलाएँ।

Linux/BSD उपयोगकर्ताओं को अपने उपयुक्त पैकेज मैनेजर का उपयोग करके git और Node.js इंस्टॉल करना चाहिए, या स्रोत से बनाना चाहिए,
अगर आप ऐसा करना पसंद करते हैं। बहुत आसान।

## अपनी खुद की jQuery कैसे बनाएं

सबसे पहले, [jQuery git रिपोजिटरी क्लोन करें](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository)।

फिर, jquery डायरेक्टरी में जाएँ, डिपेंडेंसी इंस्टॉल करें, और बिल्ड स्क्रिप्ट चलाएँ:

```bash
cd jquery
npm install
npm run build
```

बनी हुई jQuery `dist/` डायरेक्टरी में रखी जाएगी, साथ ही मिनिफाइड कॉपी और संबंधित मैप फाइल के साथ।

## सभी jQuery रिलीज फाइलों का निर्माण करें

jQuery के सभी वेरिएंट्स बनाने के लिए, निम्नलिखित कमांड चलाएँ:

```bash
npm run build:all
```

यह सभी वेरिएंट्स बनाएगा जो jQuery एक रिलीज में शामिल करता है, जैसे कि `jquery.js`, `jquery.slim.js`, `jquery.module.js`, और `jquery.slim.module.js` उनके संबंधित मिनिफाइड फाइलों और सोर्समैप्स के साथ।

`jquery.module.js` और `jquery.slim.module.js` [ECMAScript मॉड्यूल्स](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Modules) हैं जो `jQuery` और `$` को नामित एक्सपोर्ट के रूप में निर्यात करते हैं और इन्हें `dist/` डायरेक्टरी के बजाय `dist-module/` डायरेक्टरी में रखा जाता है।

## कस्टम jQuery बनाना

बिल्ड स्क्रिप्ट का उपयोग करके आप अपनी जरूरत के केवल उन्हीं मॉड्यूल्स के साथ एक कस्टम jQuery वर्शन बना सकते हैं।

किसी भी मॉड्यूल को छोड़ा जा सकता है, सिवाय `core` के। जब `selector` को छोड़ते हैं, तो इसे हटाया नहीं जाता बल्कि ब्राउज़र के नेटिव `querySelectorAll` के चारों ओर एक छोटा रैपर लगा दिया जाता है (अधिक जानकारी के लिए नीचे देखें)।

### बिल्ड स्क्रिप्ट सहायता

बिल्ड स्क्रिप्ट के लिए उपलब्ध सभी विकल्पों की पूरी सूची देखने के लिए, निम्नलिखित चलाएँ:

```bash
npm run build -- --help
```

### मॉड्यूल्स

किसी मॉड्यूल को छोड़ने के लिए, उसके पथ को `src` फोल्डर के सापेक्ष (बिना `.js` एक्सटेंशन के) `--exclude` विकल्प में पास करें। जब `--include` विकल्प का उपयोग करते हैं, तो डिफ़ॉल्ट शामिल मॉड्यूल छोड़ दिए जाते हैं और केवल उन्हीं मॉड्यूल्स के साथ बिल्ड बनता है।

कुछ उदाहरण मॉड्यूल्स जिन्हें छोड़ा या शामिल किया जा सकता है:

- **ajax**: सभी AJAX कार्यक्षमताएँ: `$.ajax()`, `$.get()`, `$.post()`, `$.ajaxSetup()`, `.load()`, ट्रांसपोर्ट्स, और ajax इवेंट शॉर्टहैंड्स जैसे `.ajaxStart()`।
- **ajax/xhr**: केवल XMLHTTPRequest AJAX ट्रांसपोर्ट।
- **ajax/script**: केवल `<script>` AJAX ट्रांसपोर्ट; स्क्रिप्ट्स प्राप्त करने के लिए उपयोग किया जाता है।
- **ajax/jsonp**: केवल JSONP AJAX ट्रांसपोर्ट; यह ajax/script ट्रांसपोर्ट पर निर्भर करता है।
- **css**: `.css()` मेथड। साथ ही **css** पर निर्भर सभी मॉड्यूल्स (जैसे **effects**, **dimensions**, और **offset**) भी हटा दिए जाते हैं।
- **css/showHide**: नॉन-एनिमेटेड `.show()`, `.hide()` और `.toggle()`; अगर आप display प्रॉपर्टी सेट करने के लिए क्लास या स्पष्ट `.css()` कॉल्स का उपयोग करते हैं, तो इसे छोड़ा जा सकता है। साथ ही **effects** मॉड्यूल भी हट जाता है।
- **deprecated**: वे मेथड्स जो डिप्रिकेटेड हैं पर अभी तक हटाए नहीं गए हैं।
- **dimensions**: `.width()` और `.height()` मेथड्स, साथ ही `inner-` और `outer-` वैरिएशन।
- **effects**: `.animate()` मेथड और इसके शॉर्टहैंड्स जैसे `.slideUp()` या `.hide("slow")`।
- **event**: `.on()` और `.off()` मेथड्स और सभी इवेंट कार्यक्षमता।
- **event/trigger**: `.trigger()` और `.triggerHandler()` मेथड्स।
- **offset**: `.offset()`, `.position()`, `.offsetParent()`, `.scrollLeft()`, और `.scrollTop()` मेथड्स।
- **wrap**: `.wrap()`, `.wrapAll()`, `.wrapInner()`, और `.unwrap()` मेथड्स।
- **core/ready**: रेडी मॉड्यूल को छोड़ दें अगर आप अपनी स्क्रिप्ट्स बॉडी के अंत में रखते हैं। कोई भी रेडी कॉलबैक जो `jQuery()` से बाइंड होता है तुरंत कॉल हो जाएगा। हालांकि, `jQuery(document).ready()` एक फंक्शन नहीं होगा और `.on("ready", ...)` या समान कोई ट्रिगर नहीं होगा।
- **deferred**: jQuery.Deferred को छोड़ें। इससे वे सभी मॉड्यूल्स भी हट जाएंगे जो Deferred पर निर्भर हैं, जैसे **ajax**, **effects**, और **queue**, लेकिन **core/ready** को **core/ready-no-deferred** से बदल देता है।
- **exports/global**: विंडो पर ग्लोबल jQuery वेरिएबल्स ($ और jQuery) को अटैच करने को छोड़ें।
- **exports/amd**: AMD परिभाषा को छोड़ें।

- **selector**: पूरा jQuery सेलेक्टर इंजन। जब यह मॉड्यूल छोड़ा जाता है, तो इसे ब्राउज़र के `querySelectorAll` मेथड पर आधारित एक साधारण सेलेक्टर इंजन से बदल दिया जाता है, जो jQuery सेलेक्टर एक्सटेंशन या उन्नत अर्थों का समर्थन नहीं करता। विवरण के लिए देखें [selector-native.js](https://github.com/jquery/jquery/blob/main/src/selector-native.js) फाइल।

*नोट*: पूरे `selector` मॉड्यूल को छोड़ने से सभी jQuery सेलेक्टर एक्सटेंशन (जैसे `effects/animatedSelector` और `css/hiddenVisibleSelectors`) भी हट जाते हैं।

##### AMD नाम

आप jQuery के AMD परिभाषा के लिए मॉड्यूल नाम सेट कर सकते हैं। डिफ़ॉल्ट रूप से, यह "jquery" पर सेट है, जो प्लगइन्स और थर्ड पार्टी लाइब्रेरीज़ के साथ अच्छी तरह काम करता है, लेकिन कुछ मामलों में आप इसे बदलना चाह सकते हैं। इसे `--amd` पैरामीटर में पास करें:

```bash
npm run build -- --amd="custom-name"
```

या, अनाम रूप से परिभाषित करने के लिए, नाम को खाली छोड़ दें।

```bash
npm run build -- --amd
```

##### फाइल नाम और डायरेक्टरी

बनी हुई jQuery फाइल का डिफ़ॉल्ट नाम `jquery.js` है; इसे `dist/` डायरेक्टरी के तहत रखा जाता है। आप `--filename` से फाइल नाम और `--dir` से डायरेक्टरी बदल सकते हैं। `--dir` प्रोजेक्ट रूट के सापेक्ष है।

```bash
npm run build -- --slim --filename="jquery.slim.js" --dir="/tmp"
```

यह jQuery का स्लिम वर्शन बनाएगा और इसे `tmp/jquery.slim.js` में रखेगा।

##### ECMAScript मॉड्यूल (ESM) मोड

डिफ़ॉल्ट रूप से, jQuery एक रेगुलर स्क्रिप्ट जावास्क्रिप्ट फाइल बनाता है। आप `--esm` पैरामीटर का उपयोग करके एक ECMAScript मॉड्यूल भी बना सकते हैं, जो `jQuery` को डिफ़ॉल्ट एक्सपोर्ट के रूप में निर्यात करता है:

```bash
npm run build -- --filename=jquery.module.js --esm
```

##### फ़ैक्टरी मोड

डिफ़ॉल्ट रूप से, jQuery एक ग्लोबल `window` पर निर्भर करता है। उन वातावरणों के लिए जहाँ यह नहीं है, आप एक फैक्ट्री बिल्ड बना सकते हैं, जो एक ऐसी फ़ंक्शन को एक्सपोज़ करता है जिसमें आप एक्सटर्नली `window` पास कर सकते हैं (उपयोग निर्देशों के लिए देखें [प्रकाशित पैकेज का `README`](build/fixtures/README.md))। आप `--factory` पैरामीटर का उपयोग करके ऐसी फैक्ट्री बना सकते हैं:

```bash
npm run build -- --filename=jquery.factory.js --factory
```

यह विकल्प अन्य विकल्पों जैसे `--esm` या `--slim` के साथ मिलाया जा सकता है:

```bash
npm run build -- --filename=jquery.factory.slim.module.js --factory --esm --slim --dir="/dist-module"
```

#### कस्टम बिल्ड उदाहरण

`npm run build` का उपयोग करके मॉड्यूल्स की सूची देकर कस्टम बिल्ड बनाएं जिन्हें छोड़ना है। टॉप-लेवल मॉड्यूल छोड़ने से उसके संबंधित डायरेक्टरी के मॉड्यूल्स भी हट जाते हैं।

सभी **ajax** कार्यक्षमता छोड़ें:

```bash
npm run build -- --exclude=ajax
```

**css** छोड़ने से CSS पर निर्भर मॉड्यूल्स हट जाते हैं: **effects**, **offset**, **dimensions**।

```bash
npm run build -- --exclude=css
```

कई मॉड्यूल्स छोड़ें (`-e` `--exclude` का एलियास है):

```bash
npm run build -- -e ajax/jsonp -e css -e deprecated -e dimensions -e effects -e offset -e wrap
```

आधिकारिक jQuery Slim बिल्ड की तरह ही कॉन्फिगरेशन के साथ बिल्ड जनरेट करने के लिए एक विशेष एलियास है:

```bash
npm run build -- --filename=jquery.slim.js --slim
```

या, स्लिम बिल्ड को esm मॉड्यूल के रूप में बनाने के लिए:

```bash
npm run build -- --filename=jquery.slim.module.js --slim --esm
```
```

*ग़ैर-आधिकारिक कस्टम बिल्ड्स को नियमित रूप से टेस्ट नहीं किया जाता है। इन्हें अपने जोखिम पर उपयोग करें।*

## यूनिट टेस्ट चलाना

सुनिश्चित करें कि आपके पास आवश्यक डिपेंडेंसीज़ हैं:

```bash
npm install
```

`npm start` चालू करें ताकि जैसे-जैसे आप काम करें, jQuery ऑटो-बिल्ड होता रहे:

```bash
npm start
```

यूनिट टेस्ट को उस लोकल सर्वर पर चलाएँ जो PHP को सपोर्ट करता है। सुनिश्चित करें कि आप साइट को रूट डायरेक्टरी से चला रहे हैं, "test" डायरेक्टरी से नहीं। किसी डेटाबेस की आवश्यकता नहीं है। Windows और Mac के लिए प्री-कॉन्फ़िगर्ड php लोकल सर्वर उपलब्ध हैं। यहाँ कुछ विकल्प हैं:

- Windows: [WAMP डाउनलोड करें](https://www.wampserver.com/en/)
- Mac: [MAMP डाउनलोड करें](https://www.mamp.info/en/downloads/)
- Linux: [LAMP सेटअप करें](https://www.linux.com/training-tutorials/easy-lamp-server-installation/)
- [Mongoose (अधिकांश प्लेटफ़ॉर्म्स)](https://code.google.com/p/mongoose/)

## आवश्यक Git

चूंकि सोर्स कोड को Git वर्शन कंट्रोल सिस्टम द्वारा हैंडल किया जाता है, इसलिए इसके कुछ फ़ीचर्स को जानना उपयोगी है।

### क्लीनिंग

अगर आप अपनी वर्किंग डायरेक्टरी को वापस अपस्ट्रीम की स्थिति में लाना चाहते हैं, तो निम्नलिखित कमांड्स का उपयोग किया जा सकता है (ध्यान रखें कि इसके बाद आपकी सभी की गई चीजें चली जाएँगी):

```bash
git reset --hard upstream/main
git clean -fdx
```

### रीबेसिंग

फ़ीचर/टॉपिक ब्रांचेज़ के लिए, आपको हमेशा `git pull` के साथ `--rebase` फ्लैग का उपयोग करना चाहिए, या यदि आप आमतौर पर कई अस्थायी "गिटहब पुल रिक्वेस्ट में डालने के लिए" ब्रांचेज़ को हैंडल करते हैं, तो इसे ऑटोमेट करने के लिए निम्नलिखित चलाएँ:

```bash
git config branch.autosetuprebase local
```

(अधिक जानकारी के लिए `man git-config` देखें)

### मर्ज कॉन्फ्लिक्ट्स को हैंडल करना

अगर मर्ज करते समय आपको मर्ज कॉन्फ्लिक्ट्स मिल रहे हैं, तो कॉन्फ्लिक्टेड फाइल्स को मैन्युअली एडिट करने के बजाय, आप `git mergetool` फ़ीचर का उपयोग कर सकते हैं। भले ही डिफ़ॉल्ट टूल `xxdiff` पुराना/अजीब लगे, यह काफी उपयोगी है।

यहाँ कुछ कमांड्स दिए गए हैं जिन्हें वहाँ इस्तेमाल किया जा सकता है:

- `Ctrl + Alt + M` - जितना संभव हो ऑटोमर्ज करें
- `b` - अगले मर्ज कॉन्फ्लिक्ट पर जाएँ
- `s` - कॉन्फ्लिक्टेड लाइनों का ऑर्डर बदलें
- `u` - मर्ज को अनडू करें
- `left mouse button` - किसी ब्लॉक को विजेता मार्क करें
- `middle mouse button` - किसी लाइन को विजेता मार्क करें
- `Ctrl + S` - सेव करें
- `Ctrl + Q` - बाहर निकलें

## [QUnit](https://api.qunitjs.com) संदर्भ

### टेस्ट मेथड्स

```js
expect( numAssertions );
stop();
start();
```

*नोट*: QUnit में स्टॉप/स्टार्ट के लिए आर्गुमेंट जोड़ने की भविष्य की सुविधा को इस टेस्ट सूट में अनदेखा किया गया है ताकि स्टार्ट और स्टॉप को कॉलबैक के रूप में पास किया जा सके बिना उनके पैरामीटर्स की चिंता किए।

### टेस्ट असर्शन

```js
ok( value, [message] );
equal( actual, expected, [message] );
notEqual( actual, expected, [message] );
deepEqual( actual, expected, [message] );
notDeepEqual( actual, expected, [message] );
strictEqual( actual, expected, [message] );
notStrictEqual( actual, expected, [message] );
throws( block, [expected], [message] );
```

## टेस्ट सूट कन्वीनियंस मेथड्स संदर्भ

देखें [test/data/testinit.js](https://github.com/jquery/jquery/blob/main/test/data/testinit.js)।

### दिए गए IDs के साथ एलिमेंट्स की एक एरे लौटाता है

```js
q( ... );
```

उदाहरण:

```js
q( "main", "foo", "bar" );

=> [ div#main, span#foo, input#bar ]
```

### यह जाँचता है कि कोई चयन दिए गए IDs से मेल खाता है या नहीं

```js
t( testName, selector, [ "array", "of", "ids" ] );
```

उदाहरण:

```js
t("Check for something", "//[a]", ["foo", "bar"]);
```

### बिना jQuery के नेटिव DOM इवेंट फायर करता है

```js
fireNative( node, eventType );
```

उदाहरण:

```js
fireNative( jQuery( "#elem" )[ 0 ], "click" );
```

### कैशिंग रोकने के लिए url में रैंडम नंबर जोड़ें

```js
url( "some/url" );
```

उदाहरण:

```js
url( "index.html" );

=> "data/index.html?10538358428943"


url( "mock.php?foo=bar" );

=> "data/mock.php?foo=bar&10538358345554"
```

### iframe में टेस्ट चलाएँ

कुछ टेस्ट्स को मानक टेस्ट फ़िक्स्चर के अलावा किसी अन्य डॉक्यूमेंट की आवश्यकता हो सकती है, और इन्हें अलग iframe में चलाया जा सकता है। वास्तविक टेस्ट कोड और असर्शन jQuery के मुख्य टेस्ट फाइल्स में ही रहते हैं; केवल न्यूनतम टेस्ट फ़िक्स्चर मार्कअप और सेटअप कोड iframe फाइल में रखा जाना चाहिए।

```js
testIframe( testName, fileName,
  function testCallback(
      assert, jQuery, window, document,
	  [ additional args ] ) {
	...
  } );
```

यह एक पेज लोड करता है, जिसमें फाइलनेम के साथ url बनता है `"./data/" + fileName`।
iframe पेज तय करता है कि टेस्ट में कॉलबैक कब होगा, इसके लिए "/test/data/iframeTest.js" स्क्रिप्ट शामिल करें और जब उपयुक्त हो `startIframeTest( [ additional args ] )` कॉल करें। आमतौर पर यह या तो document ready या `window.onload` फायर होने के बाद होगा।

`testCallback` को QUnit का `assert` ऑब्जेक्ट मिलता है जो `testIframe` द्वारा इस टेस्ट के लिए बनाया गया है, इसके बाद iframe का ग्लोबल `jQuery`, `window`, और `document`। यदि iframe कोड `startIframeTest` को कोई आर्गुमेंट पास करता है, तो वे `document` आर्गुमेंट के बाद मिलते हैं।

## कोई सवाल?

अगर आपके कोई सवाल हैं, तो कृपया [Developing jQuery Core फोरम](https://forum.jquery.com/developing-jquery-core) या [libera](https://web.libera.chat/) के #jquery चैनल पर पूछ सकते हैं।
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---