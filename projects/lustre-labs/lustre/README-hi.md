<h1 align="center">Lustre</h1>

<div align="center">
  ✨ <strong>अपने फ्रंटएंड को चमकदार बनाएं</strong> ✨
</div>

<div align="center">
  Gleam में वेब ऐप्स बनाने के लिए एक फ्रेमवर्क!
</div>

<br />

<div align="center">
  <a href="https://hex.pm/packages/lustre">
    <img src="https://img.shields.io/hexpm/v/lustre"
      alt="Hex पर उपलब्ध" />
  </a>
  <a href="https://hexdocs.pm/lustre">
    <img src="https://img.shields.io/badge/hex-docs-ffaff3"
      alt="डॉक्यूमेंटेशन" />
  </a>
</div>

<div align="center">
  <h3>
    <!--
    <a href="https://lustre.build">
      वेबसाइट
    </a>
    <span> | </span>
    -->
    <a href="https://hexdocs.pm/lustre/guide/01-quickstart.html">
      क्विकस्टार्ट
    </a>
    <span> | </span>
    <a href="https://hexdocs.pm/lustre">
      रेफरेंस
    </a>
    <span> | </span>
    <a href="https://discord.gg/Fm8Pwmy">
      डिस्कॉर्ड
    </a>
  </h3>
</div>

<div align="center">
  <sub>❤︎ के साथ निर्मित
  <a href="https://twitter.com/hayleighdotdev">Hayleigh Thompson</a> द्वारा और
  <a href="https://github.com/lustre-labs/lustre/graphs/contributors">
    योगदानकर्ताओं
  </a>
</div>

---

## विषय सूची

- [विशेषताएँ](#features)
- [उदाहरण](#example)
- [दर्शन](#philosophy)
- [इंस्टॉलेशन](#installation)
- [आगे क्या करें](#where-next)
- [सहायता](#support)

## विशेषताएँ {#features}

- HTML बनाने के लिए एक **डिक्लेरेटिव**, फंक्शनल API। कोई टेम्प्लेट नहीं, कोई मैक्रो नहीं,
  सिर्फ Gleam।

- **स्टेट प्रबंधन** के लिए Erlang और Elm से प्रेरित आर्किटेक्चर।

- पूर्वानुमानित, टेस्टेबल कोड के लिए **मैनेज्ड साइड इफेक्ट्स**।

- यूनिवर्सल कंपोनेंट्स। **एक बार लिखें, कहीं भी चलाएँ**। Elm से Phoenix LiveView तक।

- **बैटरियाँ-समेत CLI** जो ऐप्स बनाना और स्कैफोल्डिंग बेहद आसान बनाता है।

- स्थैतिक HTML टेम्प्लेटिंग के लिए **सर्वर-साइड रेंडरिंग**।

## उदाहरण {#example}

Lustre के साथ [20 से अधिक उदाहरण](https://hexdocs.pm/lustre/reference/examples.html) आते हैं!
यहाँ इसका एक उदाहरण है:

```gleam
import gleam/int
import lustre
import lustre/element.{text}
import lustre/element/html.{div, button, p}
import lustre/event.{on_click}

pub fn main() {
  let app = lustre.simple(init, update, view)
  let assert Ok(_) = lustre.start(app, "#app", Nil)

  Nil
}

fn init(_flags) {
  0
}

type Msg {
  Incr
  Decr
}

fn update(model, msg) {
  case msg {
    Incr -> model + 1
    Decr -> model - 1
  }
}

fn view(model) {
  let count = int.to_string(model)

  div([], [
    button([on_click(Incr)], [text(" + ")]),
    p([], [text(count)]),
    button([on_click(Decr)], [text(" - ")])
  ])
}
```

## दर्शन {#philosophy}

Lustre छोटे से मध्यम आकार के वेब एप्लिकेशन बनाने के लिए एक _मताधारित_ फ्रेमवर्क है। आधुनिक फ्रंटएंड विकास कठिन और जटिल है। इसमें से कुछ जटिलता आवश्यक है, लेकिन बहुत कुछ आकस्मिक या विकल्पों की अधिकता के कारण है। Lustre की डिजाइन फिलॉसफी Gleam जैसी है: जहाँ संभव हो, चीजें करने का सिर्फ एक तरीका होना चाहिए।

इसका अर्थ है कि बॉक्स से बाहर एक ही स्टेट प्रबंधन प्रणाली के साथ आना, जो Elm और Erlang/OTP के बाद मॉडलिंग की गई है। कोई भी Lustre एप्लिकेशन खोलें और आपको घर जैसा महसूस होना चाहिए।

इसका यह भी मतलब है कि हम जटिल तरीकों की बजाय सरल दृष्टिकोणों को अपनाने के लिए प्रोत्साहित करते हैं। Lustre में एनकैप्सुलेटेड स्टेटफुल कंपोनेंट्स बनाने का एक तरीका _है_ (जो हमें Elm में बहुत याद आया), लेकिन यह डिफॉल्ट नहीं होना चाहिए। स्टेटफुल कंपोनेंट्स की बजाय सरल फंक्शनों को प्राथमिकता दें।

जहाँ कंपोनेंट्स _आवश्यक_ हैं, वहाँ इस बात पर जोर दें कि Lustre कंपोनेंट्स _कहीं भी_ चल सकते हैं। Lustre आपको ऐसे टूल्स देता है जिससे आप कंपोनेंट्स बना सकते हैं जो मौजूदा Lustre ऐप्लिकेशन के अंदर चल सकते हैं, उन्हें एक स्टैंडअलोन वेब कंपोनेंट के रूप में एक्सपोर्ट कर सकते हैं, या उन्हें मिनिमल रनटाइम के साथ सर्वर पर चला सकते हैं ताकि DOM को पैच किया जा सके। Lustre इन्हें **यूनिवर्सल कंपोनेंट्स** कहता है और इन्हें Gleam के मल्टीपल टार्गेट्स को ध्यान में रखते हुए लिखा गया है।

## इंस्टॉलेशन {#installation}

Lustre [Hex](https://hex.pm/packages/lustre) पर प्रकाशित है! आप इसे अपने Gleam प्रोजेक्ट्स में कमांड लाइन से जोड़ सकते हैं:

```sh
gleam add lustre
```

Lustre के साथ एक साथी पैकेज भी है जिसमें डेवलपमेंट टूलिंग शामिल है, जिसे आप इंस्टॉल करना चाहेंगे:

> **नोट:** lustre_dev_tools डेवलपमेंट सर्वर आपकी फाइल सिस्टम में आपके gleam कोड में बदलाव देखता है और ब्राउज़र को अपने आप रीलोड कर सकता है। लिनक्स उपयोगकर्ताओं के लिए इसके लिए [inotify-tools]() इंस्टॉल होना आवश्यक है

```sh
gleam add --dev lustre_dev_tools
```

## आगे क्या करें {#where-next}

Lustre के साथ जल्दी शुरू करने के लिए [क्विकस्टार्ट गाइड](https://hexdocs.pm/lustre/guide/01-quickstart.html) देखें।
यदि आप कोड देखना पसंद करते हैं, तो [examples](https://github.com/lustre-labs/lustre/tree/main/examples)
डायरेक्टरी में कुछ छोटे ऐप्लिकेशन हैं जो फ्रेमवर्क के विभिन्न पहलुओं को दर्शाते हैं।

आप [HexDocs](https://hexdocs.pm/lustre) पर डॉक्यूमेंटेशन और API रेफरेंस भी पढ़ सकते हैं।

## सहायता {#support}

Lustre ज्यादातर मेरे द्वारा, [Hayleigh](https://github.com/hayleigh-dot-dev) द्वारा, दो नौकरियों के बीच बनाया गया है। यदि आप मेरे कार्य का समर्थन करना चाहते हैं, तो आप मुझे [GitHub पर स्पॉन्सर](https://github.com/sponsors/hayleigh-dot-dev) कर सकते हैं।

योगदान भी बहुत स्वागत योग्य हैं! यदि आपने कोई बग देखा है, या कोई फीचर सुझाना चाहते हैं, तो कृपया कोई इश्यू या पुल रिक्वेस्ट खोलें।

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---