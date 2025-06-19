# Gauntlet

[![Discord](https://discord.com/api/guilds/1205606511603359785/widget.png?style=shield)](https://discord.gg/gFTqYUkBrW)

<img align="right" width="100" height="100" src="https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/assets/linux/icon_256.png">

Launcher de aplicações multiplataforma com foco em web, com plugins baseados em React

> [!WARNING]
> O launcher está sendo desenvolvido por um único desenvolvedor em seu tempo livre.
> As mudanças podem ser lentas, mas constantes
>
> Provavelmente haverá mudanças incompatíveis, que serão documentadas no [changelog](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/CHANGELOG.md).

![image](https://github.com/user-attachments/assets/81339462-9cc3-469e-8cdc-ca74918bceab)

## Demo

Demo um pouco desatualizado

https://github.com/user-attachments/assets/19964ed6-9cd9-48d4-9835-6be04de14b66

## Funcionalidades

- Plugin-first
  - Plugins são escritos em TypeScript
  - API de plugins extensiva 
      - Criar visualizações de UI
      - Comandos de execução única
      - Fornecer dinamicamente uma lista de comandos de execução única
      - Renderizar conteúdo "inline" rapidamente diretamente abaixo da barra de pesquisa principal, com base no valor inserido
      - Obter conteúdo da Área de Transferência e adicionar nela
  - Plugins são distribuídos como branch separado em repositório Git, ou seja, a distribuição de plugins não precisa de nenhum servidor central
  - IDs dos plugins são apenas URLs de repositórios Git
  - Interface baseada em [React](https://github.com/facebook/react) para plugins
    - Implementado com React Reconciler personalizado (sem Electron)
  - [Deno JavaScript Runtime](https://github.com/denoland/deno)
    - O Deno permite sandbox do código de plugins JavaScript para maior segurança
    - Plugins precisam especificar explicitamente quais permissões precisam para funcionar
    - Node.js é usado para rodar ferramentas de plugin, mas, como desenvolvedor de plugin, você sempre escreverá código que roda no Deno
- Projetado para ser multiplataforma desde o início
- Comandos e Visualizações podem ser abertos/executados usando atalhos globais personalizados
- Alias de busca personalizado pode ser atribuído a Comandos ou Visualizações
- Suporte a temas personalizados
- Funcionalidades nativas fornecidas por plugins inclusos
  - Aplicativos: mostra aplicativos instalados no sistema nos resultados de busca
    - O plugin também rastreia janelas e a qual aplicativo elas pertencem, então ao abrir um aplicativo já aberto, por padrão, a janela já existente será exibida
      - Nem todos os sistemas são suportados no momento. Veja [suporte de funcionalidades](https://gauntlet.sh/docs/feature-support)
  - Calculadora: mostra o resultado de operações matemáticas diretamente abaixo da barra de pesquisa principal
    - Inclui conversão de moedas usando taxas de câmbio
    - Alimentado pelo [Numbat](https://github.com/sharkdp/numbat)
- Ordenação dos resultados de busca baseada em "frecency"
   - "Frecency" é uma combinação de frequência e recência
   - Quanto mais vezes o item for usado, mais alto ele aparecerá na lista de resultados, mas itens usados muito no passado serão classificados abaixo de itens usados a mesma quantidade de vezes recentemente
   - Resultados são comparados por palavra, por substring

##### Suporte a SO

##### Oficial
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux X11
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS M1

##### Best-effort
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/linux.svg" width="18" height="18" /> Linux Wayland
  - Gnome Wayland ainda não é suportado, veja [#40](https://github.com/project-gauntlet/gauntlet/issues/40)
- <img src="https://img.icons8.com/windows/32/windows-11.png" width="18" height="18" /> Windows
- <img src="https://cdn.jsdelivr.net/gh/simple-icons/simple-icons@develop/icons/apple.svg" width="18" height="18" /> macOS Intel

## Primeiros Passos

### Instale o Gauntlet

Veja [Instalação](https://gauntlet.sh/docs/installation)

### Atalho Global

A janela principal pode ser aberta usando um atalho global ou comando CLI:
- Atalho Global (pode ser alterado nas Configurações)
  - Windows: <kbd>ALT</kbd> + <kbd>Espaço</kbd>
  - Linux X11: <kbd>Super</kbd> + <kbd>Espaço</kbd>
  - Linux Wayland
    - O atalho global pode não ser suportado, veja [suporte de funcionalidades](https://gauntlet.sh/docs/feature-support)
    - Por favor, use o comando CLI e invoque-o conforme o método específico do seu gerenciador de janelas
  - macOS: <kbd>CMD</kbd> + <kbd>Espaço</kbd>
- Comando CLI
  - `gauntlet open`

### Instalar plugin

Plugins são instalados na interface de Configurações. Use a URL do repositório Git do plugin para instalar, por exemplo: `https://github.com/project-gauntlet/readme-demo-plugin.git`

![](https://raw.githubusercontent.com/project-gauntlet/gauntlet/main/docs/settings_ui.png)

### Crie seu próprio plugin

Veja [Primeiros passos no desenvolvimento de plugins](https://gauntlet.sh/docs/plugin-development/getting-started)

## Temas

Veja [Temas](https://gauntlet.sh/docs/theming)

## Compilando o Gauntlet

Você vai precisar de:
- NodeJS
- Rust
- Protobuf Compiler
- CMake (não é usado diretamente pelo projeto, mas é necessário por uma dependência)
- No Linux: `libxkbcommon-dev` (nota: o nome pode variar dependendo da distribuição)

### Dev

Para compilar em modo dev rode:
```bash
npm ci
npm run build
npm run build-dev-plugin
cargo build
```
No dev (sem o recurso "release") o aplicativo usará SOMENTE diretórios dentro do diretório do projeto para armazenar estado ou cache, evitando interferir em instalações globais

### Not-yet-packaged

Para compilar o binário de release ainda não empacotado, rode:
```bash
npm ci
npm run build
cargo build --release --features release
```

### Packaged
Para compilar o pacote específico de SO, rode um dos comandos abaixo:

macOS:
```bash
npm run build-macos-project --workspace @project-gauntlet/build
```

Windows:
```bash
npm run build-windows-project --workspace @project-gauntlet/build
```

Linux:
```bash
npm run build-linux-project --workspace @project-gauntlet/build
```

Mas a publicação da nova versão precisa ser feita via GitHub Actions

## Contribuindo

Se você quiser ajudar a construir o Gauntlet, pode fazê-lo de mais maneiras além de contribuir com código:
- Reportando um bug ou problema de UI/UX
- Criando um plugin

Para problemas simples, sinta-se à vontade para abrir uma issue ou PR e resolvê-la você mesmo. 
Para mudanças mais significativas, por favor, entre em contato com os criadores no Discord (link de convite no topo do README) e discuta primeiro.

Todas e quaisquer contribuições são bem-vindas.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---