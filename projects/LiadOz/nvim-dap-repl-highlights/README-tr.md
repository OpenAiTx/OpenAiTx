
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
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
[nvim-dap](https://github.com/mfussenegger/nvim-dap) REPL tamponuna treesitter kullanarak sözdizimi vurgulama ekleyin.
| Önce                                                                                                            | Sonra                                                                                                          |
| --------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| ![before](https://user-images.githubusercontent.com/20954878/235993939-a3ad95eb-9dfa-41a4-b70e-3a4e890e2adf.png) | ![image](https://user-images.githubusercontent.com/20954878/235993604-642fe658-6cc9-40e0-846c-00df11d963e1.png)|

## Gereksinimler
* Neovim 0.9 veya üstü
* [nvim-treesitter](https://github.com/nvim-treesitter/nvim-treesitter)

## Kurulum
Eklentiyi ve gereksinimleri favori yönteminizle kurun. Kurulum tamamlandıktan sonra, treesitter [vurgulamasını](https://github.com/nvim-treesitter/nvim-treesitter#modules) yapılandırdığınızdan emin olun ve ardından aşağıdakileri lua yapılandırmanıza ekleyin.
```lua
require('nvim-dap-repl-highlights').setup()
```
Eklentiyi ilk kurduktan sonra dap_repl ayrıştırıcısının yüklenmesi gerekir, bu manuel olarak `:TSInstall dap_repl` komutu çalıştırılarak yapılabilir.

Ya da Treesitter yapılandırması üzerinden otomatik olarak yapılabilir:

**`ensure_installed` kullanarak (nvim-treesitter ana dalı)**
> ⚠️ **NOT:** Treesitter'dan önce nvim-dap-repl-highlights.setup() fonksiyonunu çağırmalısınız, aksi takdirde dap_repl ayrıştırıcısı bulunamaz.
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
**`nvim-treesitter.install` kullanımı (nvim-treesitter ana dalı)**
```lua
require('nvim-dap-repl-highlights').setup()
require('nvim-treesitter').install { 'dap_repl' }
```
> ⚠️ Eğer bu hiç çalışmazsa veya API değişirse, en son kurulum yöntemi için resmi Treesitter belgelerini kontrol edin:
> 👉 https://github.com/nvim-treesitter/nvim-treesitter

## Kullanım
Varsayılan olarak, eklenti REPL'de kullanılacak dili, dap'i başlatmak için kullanılan **filetype**'a bakarak algılar. Elbette, belirli bir dil için sözdizimi vurgulamasına sahip olmak istiyorsanız, o dil için bir treesitter ayrıştırıcısına ve ayrıca `dap_repl` ayrıştırıcısına ihtiyacınız olacaktır.
Bu, tüm kullanım senaryolarına uymayabilir.

Bunun yerine, mevcut repl tamponunda python vurgulamalarını ayarlayacak olan `:lua require('nvim-dap-repl-highlights').setup_highlights('python')` komutunu kullanabilirsiniz.
Alternatif olarak, fonksiyon dile özel belirtmeden çağrılabilir, bu durumda kullanıcıdan bir dil seçmesi istenir.

Ek olarak, **dap** yapılandırmasında kullanılacak repl dilini belirtebilirsiniz, örneğin python repl'inizin javascript vurgulamasına sahip olmasını isterseniz:
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
repl_lang seçeneği, dosya türüne öncelik verir.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-07

---