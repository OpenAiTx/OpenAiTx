<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=LiadOz&project=nvim-dap-repl-highlights&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# nvim-dap-repl-highlights
[nvim-dap](https://github.com/mfussenegger/nvim-dap) REPL बफ़र में ट्रीसिटर का उपयोग करके सिंटैक्स हाइलाइटिंग जोड़ें।
| पहले                                                                                                             | बाद                                                                                                            |
| --------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| ![before](https://user-images.githubusercontent.com/20954878/235993939-a3ad95eb-9dfa-41a4-b70e-3a4e890e2adf.png) | ![image](https://user-images.githubusercontent.com/20954878/235993604-642fe658-6cc9-40e0-846c-00df11d963e1.png)|

## आवश्यकताएँ
* Neovim 0.9 या बाद का संस्करण

* [nvim-treesitter](https://github.com/nvim-treesitter/nvim-treesitter)

## सेटअप
अपने पसंदीदा तरीके से प्लगइन और आवश्यकताओं को इंस्टॉल करें। इंस्टॉल करने के बाद, सुनिश्चित करें कि आपने treesitter [हाइलाइटिंग](https://github.com/nvim-treesitter/nvim-treesitter#modules) को कॉन्फ़िगर किया है, फिर अपने lua कॉन्फ़िग में निम्नलिखित जोड़ें।
```lua
require('nvim-dap-repl-highlights').setup()
```
प्लगइन को शुरू में सेटअप करने के बाद dap_repl पार्सर को इंस्टॉल करना आवश्यक है, इसे मैन्युअली `:TSInstall dap_repl` चलाकर किया जा सकता है।

या फिर Treesitter कॉन्फ़िगरेशन के माध्यम से स्वचालित रूप से:

**`ensure_installed` का उपयोग करते हुए (nvim-treesitter मास्टर शाखा)**
> ⚠️ **नोट:** आपको Treesitter से पहले nvim-dap-repl-highlights.setup() कॉल करना होगा, अन्यथा dap_repl पार्सर नहीं मिलेगा।
```lua
require('nvim-dap-repl-highlights').setup()
require('nvim-treesitter.configs').setup {
  highlight = {
    enable = true,
  },
  ensure_installed = { 'dap_repl', ... },
  ...
}
```
**`nvim-treesitter.install` का उपयोग करना (nvim-treesitter मुख्य शाखा)**
```lua
require('nvim-dap-repl-highlights').setup()
require('nvim-treesitter').install { 'dap_repl' }
```
> ⚠️ यदि यह कभी काम करना बंद कर दे या API बदल जाए, तो नवीनतम इंस्टॉल विधि के लिए आधिकारिक Treesitter दस्तावेज़ देखें:
> 👉 https://github.com/nvim-treesitter/nvim-treesitter

## उपयोग
डिफ़ॉल्ट रूप से, प्लगइन REPL में उपयोग की जाने वाली भाषा का पता **filetype** देखकर लगाता है जिसका उपयोग dap लॉन्च करने के लिए किया गया था। स्पष्ट रूप से, किसी विशेष भाषा के लिए सिंटैक्स हाईलाइटिंग प्राप्त करने हेतु आपको उस भाषा के लिए एक treesitter पार्सर, साथ ही `dap_repl` पार्सर होना चाहिए।
यह सभी उपयोग मामलों के लिए उपयुक्त नहीं हो सकता।

आप इसके बजाय कमांड `:lua require('nvim-dap-repl-highlights').setup_highlights('python')` का उपयोग कर सकते हैं, जो वर्तमान REPL बफ़र में python हाईलाइट्स सेट कर देगा।
वैकल्पिक रूप से, फ़ंक्शन को भाषा निर्दिष्ट किए बिना भी कॉल किया जा सकता है, जिससे उपयोगकर्ता से भाषा पूछी जाएगी।

इसके अतिरिक्त आप **dap** कॉन्फ़िगरेशन में REPL में उपयोग की जाने वाली भाषा निर्दिष्ट कर सकते हैं, उदाहरण के लिए यदि आप चाहते हैं कि आपका python REPL में javascript हाईलाइटिंग हो:
```lua
local dap = require('dap')
dap.configurations.python = {
  {
    name = "Python with javascript repl because I like to watch the world burn 🔥🔥🔥",
    type = "python",
    request = "launch",
    program = "${file}",
    repl_lang = "javascript"
  },
}
```
repl_lang विकल्प filetype से अधिक महत्व रखता है।


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-07

---