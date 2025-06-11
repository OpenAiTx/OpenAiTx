<h1 align="center">ModernZ - Uma OSC Elegante Alternativa para mpv</h1>

Uma OSC elegante e moderna para [mpv](https://mpv.io/), este projeto é um fork do ModernX projetado para aprimorar a funcionalidade adicionando mais recursos, tudo isso preservando os padrões principais da OSC do mpv.

![ModernZ-OSC](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/f6854de6-1d57-4b2f-848e-7197933b71aa)

<p align="center">
    <a href="#installation"><strong>Instalação »</strong></a>
  <br>
  <a href="#configuration">Configuração</a>
  ·
  <a href="#controls">Controles</a>
  ·
  <a href="#interactive-menus">Menus Interativos</a>
  ·
  <a href="#translations">Idioma da OSC</a>
  ·
  <a href="#extras">Scripts Extras</a>
</p>

## Recursos

- 🎨 Interface moderna e personalizável [[opções](#configuration)]
- 📷 Modo Visualizador de Imagens com controles de zoom [[detalhes](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/IMAGE_VIEWER.md)]
- 🎛️ Botões: download, playlist, controle de velocidade, captura de tela, fixar, loop, cache e mais. [[detalhes](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/CONTROLS.md)]
- 📄 Menus interativos para playlist, legendas, capítulos, faixas de áudio e dispositivos de áudio [[detalhes](#interactive-menus)]
- 🌐 Suporte multilíngue com integração JSON [locale](#translations)
- ⌨️ Controles configuráveis [[detalhes](#controls)]
- 🖼️ Visualizações em miniatura do vídeo com [thumbfast](https://github.com/po5/thumbfast)

## Personalização

Você pode alterar o tema do ícone para `fluent` ou `material` para combinar com seu gosto e estilo usando a opção `icon_theme` no seu `modernz.conf`

![modernz_fluent](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/3aafac8c-a13f-4840-8119-739523eb7a8e)

![modernz_material](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/e5ad6d06-f071-42ef-9210-296d95906d94)

Não gosta de botões e texto brancos? Você tem controle total para personalizar cores e layouts de botões para refletir perfeitamente seu estilo.

![modernz_osc_controls_top](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/9e3df3af-d3ea-41bb-8c9a-9bf64c1d895a)

![modernz_osc_controls_bottom](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/d4e56bf5-ce7b-44e9-90a3-e27e922dd6bd)

Consulte a seção [Personalização de Cores](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md#colors-and-style) no guia de configuração para detalhes sobre como personalizar cores e botões.

## Menus Interativos

ModernZ suporta o console/select embutido do mpv ([v0.40+](https://github.com/mpv-player/mpv/releases/tag/v0.40.0)) para playlist, legendas, navegação por capítulos e mais.

[![preview_menus](https://raw.githubusercontent.com/Samillion/ModernZ/main/assets/4b7a3139-81f1-409b-98f5-f090a81d5ee6)](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/INTERACTIVE_MENUS.md)

## Instalação

1. **Desative a OSC padrão**

   - Adicione `osc=no` no seu `mpv.conf`

2. **Copie os Arquivos**

   - Coloque `modernz.lua` no diretório de scripts do mpv
   - Coloque `fluent-system-icons.ttf` e `material-design-icons.ttf` no diretório de fontes do mpv
   - (OPCIONAL) Coloque `thumbfast.lua` no diretório de scripts do mpv

3. **Locais**

   ```
   Linux:   ~/.config/mpv/
   Windows: C:/Users/%username%/AppData/Roaming/mpv/
   macOS:   ~/Library/Application Support/mpv/
   ```

4. **Estrutura de Pastas** [[manual do mpv](https://mpv.io/manual/master/#files)]
   ```
   mpv/
   ├── fonts/
   │   ├── fluent-system-icons.ttf
   │   └── material-design-icons.ttf
   ├── script-opts/
   │   └── modernz.conf
   └── scripts/
   	   ├── modernz.lua
   	   └── thumbfast.lua (opcional)
   ```

## Configuração

1. Crie `modernz.conf` na pasta `/script-opts` para personalizar configurações

   - [Baixar modernz.conf padrão](https://raw.githubusercontent.com/Samillion/ModernZ/main/modernz.conf)

2. Exemplo de configuração curta:

   ```EditorConfig
   # Cor da barra de busca (formato hex)
   seekbarfg_color=#B7410E

   # Opções da interface
   playlist_button=no
   title=${media-title}
   scalewindowed=1.0
   window_top_bar=auto
   ```

Para uma lista completa de opções, [veja a lista detalhada aqui](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md).

## Controles

### Interações com Botões

- Clique esquerdo: Ação primária
- Clique direito: Ação secundária
- Clique do meio/Shift+Clique esquerdo: Ação alternativa

> [!NOTA]
> O clique do meio realiza a mesma função que `Shift+botão esquerdo do mouse`, permitindo uso com uma mão

Para uma lista completa de interações, consulte o [Guia de Interações com Botões](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/CONTROLS.md).

### Atalhos de Teclado

ModernZ não define atalhos por padrão para evitar interferir na sua configuração atual. Você pode adicionar atalhos no `input.conf` se preferir:

```
w   script-binding modernz/progress-toggle           # Alternar barra de progresso
x   script-message-to modernz osc-show               # Mostrar OSC
y   script-message-to modernz osc-visibility cycle   # Ciclar modos de visibilidade
z   script-message-to modernz osc-idlescreen         # Alternar tela ociosa
```

## Traduções

ModernZ está disponível atualmente em inglês, mas você pode facilmente mudá-lo para seu idioma preferido! Veja como:

1. **Baixe o pacote de locale:**

Pegue o arquivo [modernz-locale.json](https://raw.githubusercontent.com/Samillion/ModernZ/main/extras/locale/modernz-locale.json) deste repositório. Este arquivo contém traduções para vários idiomas.

2. **Adicione os locales ao mpv:**

Copie o arquivo `modernz-locale.json` baixado para a pasta `/script-opts` do seu mpv.

3. **Escolha seu idioma:**

Há duas formas de definir seu idioma preferido:

- **Recomendado:** Use o arquivo `modernz.conf`

  ```ini
  # Exemplo de configuração em modernz.conf
  # Definir idioma para Chinês Simplificado
  language=zh
  ```

- **Alternativo:** Edite o script `modernz.lua`

  Abra o `modernz.lua` e localize a seção `user_opts` perto do início. Altere o valor `language` para o código do idioma desejado:

  ```lua
  local user_opts = {
      -- Geral
      language = "en",  -- Altere para o código do idioma preferido
      ...
  }
  ```

**Precisa de mais informações?**

Para uma lista completa de idiomas disponíveis, diretrizes de contribuição e documentação detalhada sobre traduções, acesse o [TRANSLATIONS.md](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/TRANSLATIONS.md).

## Extras

Os seguintes scripts são criados e mantidos por mim, sinta-se à vontade para usá-los se forem úteis para você.

- [Pause-Indicator-Lite](https://raw.githubusercontent.com/Samillion/ModernZ/main/extras/pause-indicator-lite) - Um script simples que exibe um indicador na pausa

- [ytdlAutoFormat](https://github.com/Samillion/mpv-ytdlautoformat) - Um script simples para mpv que altera automaticamente o `ytdl-format` (yt-dlp) para domínios especificados.

- [BoxtoWide](https://github.com/Samillion/mpv-boxtowide) - Um script simples para mpv que altera automaticamente a proporção 4:3 de arquivos/streams de vídeo para 16:9.

Para ainda mais scripts úteis, confira o [mpv User Scripts Wiki](https://github.com/mpv-player/mpv/wiki/User-Scripts). Ele oferece uma ampla gama de scripts contribuídos pela comunidade para melhorar sua experiência com o mpv.

## Histórico

- [Samillion/ModernZ](https://github.com/Samillion/ModernZ)
  - fork do [dexeonify/ModernX](https://github.com/dexeonify/mpv-config/blob/main/scripts/modernx.lua)
    - fork do [cyl0/ModernX](https://github.com/cyl0/ModernX)
    - fork do [maoiscat/mpv-osc-modern](https://github.com/maoiscat/mpv-osc-modern)

**Por que mais um fork?**

- Para adicionar muitos recursos em: [Personalização de Cores](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md#colors-and-style), [Opções](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/USER_OPTS.md) e [Integração de Locale](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/TRANSLATIONS.md)
- Para integrar console e select na osc, o que inspirou o mpv a aplicar isso na osc padrão. [ref [#1](https://github.com/mpv-player/mpv/pull/15016), [#2](https://github.com/mpv-player/mpv/pull/15031)]
- Para adicionar um layout dedicado para imagens. [[detalhes](https://raw.githubusercontent.com/Samillion/ModernZ/main/docs/IMAGE_VIEWER.md)]
- Para refazer o projeto completamente para corresponder aos padrões da osc padrão do mpv, garantindo compatibilidade
- Para eliminar bugs antigos e redundâncias no código
    - O que permite que outros forks `Modern` usem o ModernZ como base, como [zydezu/ModernX](https://github.com/zydezu/ModernX). [[Referência](https://github.com/zydezu/ModernX/releases/tag/0.3.9)]

Essencialmente, para manter e reviver a origem do `modern-osc`.
Dito isso, o ModernZ ainda utiliza partes do código antigo, e todos os autores e colaboradores dos forks anteriores e atuais merecem crédito (incluindo o osc padrão do mpv), por isso eles são mencionados em detalhes.

#### Créditos:

- Fonte: UI Fluent System Icons [[detalhes](https://github.com/microsoft/fluentui-system-icons)] [[arquivo da fonte](https://raw.githubusercontent.com/Samillion/ModernZ/main/fluent-system-icons.ttf)]
- Fonte modificada por [Xurdejl](https://github.com/Xurdejl) para uso no osc do ModernZ
- [mpv](https://github.com/mpv-player/mpv) e seu [osc.lua](https://github.com/mpv-player/mpv/blob/master/player/lua/osc.lua), pois o osc do ModernZ foi rebaseado nos padrões do osc padrão e aplica atualizações dele
- Toda a origem do osc moderno e seus forks conforme mencionado na [história](#history)
- Todos os [colaboradores](https://github.com/Samillion/ModernZ/graphs/contributors), testadores e usuários que ajudaram direta ou indiretamente com o osc do ModernZ ❤️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---