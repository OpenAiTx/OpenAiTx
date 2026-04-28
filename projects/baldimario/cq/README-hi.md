<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=baldimario&project=cq&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# cq - CSV फ़ाइलों के लिए उच्च-प्रदर्शन SQL क्वेरी इंजन

 [![Cross-Build and Test (with zig build system)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml/badge.svg)](https://github.com/baldimario/cq/actions/workflows/build-zig-cross.yml)

एक हल्का, तेज़ SQL क्वेरी प्रोसेसर जो C में लिखा गया है और जो आपको बिना किसी डेटाबेस के सीधे CSV फ़ाइलों पर SQL क्वेरी निष्पादित करने में सक्षम बनाता है। पूर्ण दस्तावेज़ीकरण के लिए, /doc निर्देशिका देखें।

 ![cq का उपयोग करते हुए](https://raw.githubusercontent.com/baldimario/cq/main/assets/cq.png)


## दस्तावेज़ीकरण

- शुरुआत करना: `doc/GettingStarted.md`
- स्थापना: `doc/Installation.md`
- कमांड लाइन इंटरफेस: `doc/CLI.md`
- **TUI (टर्मिनल यूजर इंटरफेस)**: `doc/TUI.md`
- वास्तुकला: `doc/Architecture.md`
- परीक्षण: `doc/Testing.md`
- रोडमैप: `doc/Roadmap.md`
- योगदान: `doc/Contributing.md`

## त्वरित शुरुआत

निर्माण करें: `make`

### कमांड लाइन

एक नमूना क्वेरी चलाएँ:
`./build/cq -q "SELECT name, age FROM 'data.csv' WHERE age > 25" -p`

### टर्मिनल UI

इंटरएक्टिव TUI शुरू करें:
`./build/cqtui data/`

विशेषताएँ:
- CSV फ़ाइलों को टेबल के रूप में ब्राउज़ और खोलें
- SQL क्वेरी को इंटरएक्टिव रूप से निष्पादित करें
- कई टेबल के लिए मल्टी-टैब इंटरफेस
- कीबोर्ड से संचालित नेविगेशन
- कोई बाहरी निर्भरता नहीं

## उदाहरण SQL फ़ाइलें

रिपॉजिटरी में assets/ के अंतर्गत उदाहरण SQL फ़ाइलें शामिल हैं (example_between.sql, example_aggregation.sql, आदि)। विवरण के लिए assets/ देखें।

## डेटा और विशेषताओं का अवलोकन

- डेटा प्रकार, दिनांक प्रारूप, CSV प्रारूप और अन्य के विस्तृत अनुभागों के लिए /doc फ़ोल्डर देखें।

## लाइसेंस

MIT लाइसेंस। विवरण के लिए LICENSE फ़ाइल देखें।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-28

---