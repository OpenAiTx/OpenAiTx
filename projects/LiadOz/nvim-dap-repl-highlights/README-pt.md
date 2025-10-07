
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
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
Adicione destaque de sintaxe ao buffer REPL do [nvim-dap](https://github.com/mfussenegger/nvim-dap) usando o treesitter.
| Antes                                                                                                           | Depois                                                                                                         |
| --------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------- |
| ![before](https://user-images.githubusercontent.com/20954878/235993939-a3ad95eb-9dfa-41a4-b70e-3a4e890e2adf.png) | ![image](https://user-images.githubusercontent.com/20954878/235993604-642fe658-6cc9-40e0-846c-00df11d963e1.png)|

## Requisitos
* Neovim 0.9 ou superior
* [nvim-treesitter](https://github.com/nvim-treesitter/nvim-treesitter)

## Configuração
Instale o plugin e os requisitos usando seu método favorito. Depois de instalado, certifique-se de que você configurou a [realce](https://github.com/nvim-treesitter/nvim-treesitter#modules) do treesitter e então adicione o seguinte ao seu arquivo de configuração lua
```lua
require('nvim-dap-repl-highlights').setup()
```
Após a configuração inicial do plugin, o analisador dap_repl precisa ser instalado, isso pode ser feito manualmente executando `:TSInstall dap_repl`.

Ou automaticamente através da configuração do Treesitter:

**Usando `ensure_installed` (ramo master do nvim-treesitter)**
> ⚠️ **NOTA:** Você deve chamar nvim-dap-repl-highlights.setup() antes do Treesitter, ou o analisador dap_repl não será encontrado.
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
**Usando `nvim-treesitter.install` (ramo principal do nvim-treesitter)**
```lua
require('nvim-dap-repl-highlights').setup()
require('nvim-treesitter').install { 'dap_repl' }
```
> ⚠️ Se isso parar de funcionar ou a API mudar, consulte a documentação oficial do Treesitter para o método de instalação mais recente:
> 👉 https://github.com/nvim-treesitter/nvim-treesitter

## Uso
Por padrão, o plugin detecta a linguagem a ser usada no REPL verificando o **filetype** usado para iniciar o dap. Obviamente, para ter realce de sintaxe para determinada linguagem, você precisará ter um analisador treesitter para essa linguagem, juntamente com o analisador `dap_repl`.
Isso pode não atender a todos os casos de uso.

Você pode usar o comando `:lua require('nvim-dap-repl-highlights').setup_highlights('python')`, que irá definir o realce de python no buffer repl atual.
Alternativamente, a função pode ser chamada sem especificar a linguagem, o que irá solicitar ao usuário uma linguagem.

Além disso, você pode especificar na configuração do **dap** a linguagem do repl a ser usada; por exemplo, se você quiser que seu repl python tenha realce de javascript:
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
A opção repl_lang tem precedência sobre o tipo de arquivo.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-07

---