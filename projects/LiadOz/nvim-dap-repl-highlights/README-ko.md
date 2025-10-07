
<div align="right">
  <details>
    <summary >🌐 언어</summary>
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
[ nvim-dap ](https://github.com/mfussenegger/nvim-dap) REPL 버퍼에 treesitter를 사용하여 구문 하이라이팅을 추가합니다.
| 적용 전                                                                                                          | 적용 후                                                                                                          |
| --------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| ![before](https://user-images.githubusercontent.com/20954878/235993939-a3ad95eb-9dfa-41a4-b70e-3a4e890e2adf.png) | ![image](https://user-images.githubusercontent.com/20954878/235993604-642fe658-6cc9-40e0-846c-00df11d963e1.png)|

## 요구 사항
* Neovim 0.9 이상
* [nvim-treesitter](https://github.com/nvim-treesitter/nvim-treesitter)

## 설정
선호하는 방법을 사용하여 플러그인과 요구 사항을 설치하세요. 설치가 완료되면, treesitter [하이라이팅](https://github.com/nvim-treesitter/nvim-treesitter#modules)을 설정한 뒤 아래 내용을 lua 설정 파일에 추가하세요.
```lua
require('nvim-dap-repl-highlights').setup()
```
플러그인을 처음 설정한 후에는 dap_repl 파서를 설치해야 합니다. 이는 `:TSInstall dap_repl` 명령을 실행하여 수동으로 할 수 있습니다.

또는 Treesitter 설정을 통해 자동으로 할 수 있습니다:

**`ensure_installed` 사용하기 (nvim-treesitter 마스터 브랜치)**
> ⚠️ **참고:** nvim-dap-repl-highlights.setup()을 Treesitter보다 먼저 호출해야 하며, 그렇지 않으면 dap_repl 파서를 찾을 수 없습니다.
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
**`nvim-treesitter.install` 사용하기 (nvim-treesitter 메인 브랜치)**
```lua
require('nvim-dap-repl-highlights').setup()
require('nvim-treesitter').install { 'dap_repl' }
```
> ⚠️ 이 기능이 작동을 멈추거나 API가 변경될 경우, 최신 설치 방법은 공식 Treesitter 문서를 확인하세요:
> 👉 https://github.com/nvim-treesitter/nvim-treesitter

## 사용법
기본적으로, 이 플러그인은 dap를 실행할 때 사용된 **filetype**을 보고 REPL에서 사용할 언어를 감지합니다. 특정 언어에 대한 구문 강조를 위해서는 해당 언어에 대한 treesitter 파서와 함께 `dap_repl` 파서가 필요합니다.
이 방법이 모든 사용 사례에 적합하지 않을 수 있습니다.

대신 `:lua require('nvim-dap-repl-highlights').setup_highlights('python')` 명령을 사용하여 현재 repl 버퍼에 파이썬 하이라이트를 설정할 수 있습니다.
또는 함수 호출 시 언어를 지정하지 않으면, 사용자에게 언어를 선택하도록 요청합니다.

추가로, **dap** 설정에서 사용할 repl 언어를 지정할 수 있습니다. 예를 들어 파이썬 repl에 자바스크립트 하이라이트를 적용하려면:
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
repl_lang 옵션이 filetype보다 우선합니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-07

---