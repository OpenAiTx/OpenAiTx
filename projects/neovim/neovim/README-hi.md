<h1 align="center">
  <img src="https://raw.githubusercontent.com/neovim/neovim.github.io/master/logos/neovim-logo-300x87.png" alt="Neovim">

  <a href="https://neovim.io/doc/">प्रलेखन</a> |
  <a href="https://app.element.io/#/room/#neovim:matrix.org">चैट</a>
</h1>

[![Coverity Scan विश्लेषण](https://scan.coverity.com/projects/2227/badge.svg)](https://scan.coverity.com/projects/2227)
[![पैकेजेस](https://repology.org/badge/tiny-repos/neovim.svg)](https://repology.org/metapackage/neovim)
[![Debian CI](https://badges.debian.net/badges/debian/testing/neovim/version.svg)](https://buildd.debian.org/neovim)
[![डाउनलोड्स](https://img.shields.io/github/downloads/neovim/neovim/total.svg?maxAge=2592001)](https://github.com/neovim/neovim/releases/)

Neovim एक प्रोजेक्ट है जो [Vim](https://www.vim.org/) का आक्रामक पुनर्संयोजन करने का प्रयास करता है ताकि:

- रखरखाव को सरल बनाया जा सके और [योगदानों](CONTRIBUTING.md) को प्रोत्साहित किया जा सके
- कार्य को कई डेवलपर्स में बाँटा जा सके
- कोर में संशोधन किए बिना [उन्नत UI] सक्षम किए जा सकें
- [विस्तारणीयता](https://neovim.io/doc/user/ui.html) को अधिकतम किया जा सके

अधिक जानकारी के लिए [परिचय](https://github.com/neovim/neovim/wiki/Introduction) विकि पृष्ठ और [रोडमैप] देखें।

विशेषताएँ
--------

- आधुनिक [GUI](https://github.com/neovim/neovim/wiki/Related-projects#gui)
- [API एक्सेस](https://github.com/neovim/neovim/wiki/Related-projects#api-clients)
  किसी भी भाषा से, जैसे कि C/C++, C#, Clojure, D, Elixir, Go, Haskell, Java/Kotlin,
  JavaScript/Node.js, Julia, Lisp, Lua, Perl, Python, Racket, Ruby, Rust
- इनबिल्ट, स्क्रिप्टेबल [टर्मिनल एमुलेटर](https://neovim.io/doc/user/terminal.html)
- असिंक्रोनस [जॉब कंट्रोल](https://github.com/neovim/neovim/pull/2247)
- कई संपादक इंस्टेंस के बीच [शेयर्ड डेटा (shada)](https://github.com/neovim/neovim/pull/2506)
- [XDG बेस डाइरेक्टरीज़](https://github.com/neovim/neovim/pull/3470) का समर्थन
- अधिकांश Vim प्लगइन्स के साथ संगत, जिनमें Ruby और Python प्लगइन भी शामिल हैं

पूरी सूची के लिए देखें [`:help nvim-features`][nvim-features], और नवीनतम संस्करण में उल्लेखनीय परिवर्तनों के लिए देखें [`:help news`][nvim-news]!

पैकेज से इंस्टॉल करें
--------------------

Windows, macOS, और Linux के लिए प्री-बिल्ट पैकेज
[रिलीज़](https://github.com/neovim/neovim/releases/) पृष्ठ पर उपलब्ध हैं।

[प्रबंधित पैकेजेस] [Homebrew], [Debian], [Ubuntu], [Fedora], [Arch Linux], [Void Linux], [Gentoo], आदि में उपलब्ध हैं!

स्रोत से इंस्टॉल करें
-------------------

विवरण के लिए देखें [BUILD.md](./BUILD.md) और [समर्थित प्लेटफॉर्म्स](https://neovim.io/doc/user/support.html#supported-platforms)।

बिल्ड CMake-आधारित है, लेकिन सुविधा के लिए Makefile भी दिया गया है।
डिपेंडेंसीज़ स्थापित करने के बाद, निम्नलिखित कमांड चलाएँ।

    make CMAKE_BUILD_TYPE=RelWithDebInfo
    sudo make install

गैर-डिफ़ॉल्ट लोकेशन में इंस्टॉल करने के लिए:

    make CMAKE_BUILD_TYPE=RelWithDebInfo CMAKE_INSTALL_PREFIX=/full/path/
    make install

बिल्ड का निरीक्षण करने के लिए CMake टिप्स:

- `cmake --build build --target help` सभी बिल्ड टार्गेट्स दिखाता है।
- `build/CMakeCache.txt` (या `cmake -LAH build/`) सभी CMake वेरिएबल्स के रिज़ॉल्व्ड मान दिखाता है।
- `build/compile_commands.json` प्रत्येक ट्रांसलेशन यूनिट के लिए पूरी कंपाइलर इनवोकेशन दिखाता है।

Vim से ट्रांज़िशन करना
--------------------

निर्देशों के लिए देखें [`:help nvim-from-vim`](https://neovim.io/doc/user/nvim.html#nvim-from-vim)।

प्रोजेक्ट का लेआउट
--------------

    ├─ cmake/           CMake यूटिल्स
    ├─ cmake.config/    CMake डिफाइन्स
    ├─ cmake.deps/      डिपेंडेंसीज़ को फ़ेच और बिल्ड करने के लिए सबप्रोजेक्ट (वैकल्पिक)
    ├─ runtime/         प्लगइन्स और डॉक्युमेंटेशन
    ├─ src/nvim/        एप्लिकेशन सोर्स कोड (देखें src/nvim/README.md)
    │  ├─ api/          API सबसिस्टम
    │  ├─ eval/         Vimscript सबसिस्टम
    │  ├─ event/        इवेंट-लूप सबसिस्टम
    │  ├─ generators/   कोड जनरेशन (प्री-कम्पाइलेशन)
    │  ├─ lib/          सामान्य डेटा स्ट्रक्चर
    │  ├─ lua/          Lua सबसिस्टम
    │  ├─ msgpack_rpc/  RPC सबसिस्टम
    │  ├─ os/           लो-लेवल प्लेटफॉर्म कोड
    │  └─ tui/          इनबिल्ट UI
    └─ test/            टेस्ट्स (देखें test/README.md)

लाइसेंस
-------

[b17d96][license-commit] के बाद के Neovim योगदान
Apache 2.0 लाइसेंस के अंतर्गत लाइसेंस प्राप्त हैं, सिवाय उन योगदानों के जो Vim से कॉपी किए गए हैं (जिन्हें `vim-patch` टोकन से पहचाना जाता है)। विवरण के लिए LICENSE देखें।

    Vim एक चैरिटीवेयर है।  आप इसे जितना चाहें उपयोग और कॉपी कर सकते हैं, लेकिन आपसे अनुरोध है कि युगांडा के ज़रूरतमंद बच्चों के लिए दान करें।  कृपया vim डॉक्युमेंटेशन के kcc अनुभाग को देखें या ICCF वेबसाइट पर जाएँ, जो इन URL पर उपलब्ध है:

            https://iccf-holland.org/
            https://www.vim.org/iccf/
            https://www.iccf.nl/

    आप Vim के विकास को भी प्रायोजित कर सकते हैं।  Vim प्रायोजक फीचर्स के लिए वोट कर सकते हैं।  धनराशि अंततः युगांडा को ही जाती है।

[license-commit]: https://github.com/neovim/neovim/commit/b17d9691a24099c9210289f16afb1a498a89d803
[nvim-features]: https://neovim.io/doc/user/vim_diff.html#nvim-features
[nvim-news]: https://neovim.io/doc/user/news.html
[Roadmap]: https://neovim.io/roadmap/
[advanced UIs]: https://github.com/neovim/neovim/wiki/Related-projects#gui
[प्रबंधित पैकेजेस]: ./INSTALL.md#install-from-package
[Debian]: https://packages.debian.org/testing/neovim
[Ubuntu]: https://packages.ubuntu.com/search?keywords=neovim
[Fedora]: https://packages.fedoraproject.org/pkgs/neovim/neovim/
[Arch Linux]: https://www.archlinux.org/packages/?q=neovim
[Void Linux]: https://voidlinux.org/packages/?arch=x86_64&q=neovim
[Gentoo]: https://packages.gentoo.org/packages/app-editors/neovim
[Homebrew]: https://formulae.brew.sh/formula/neovim

<!-- vim: set tw=80: -->

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---