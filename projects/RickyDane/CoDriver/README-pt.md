
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<br/>
<p align="center"><img width="500" height="auto" alt="codriver_banner" src="https://github.com/user-attachments/assets/1957b950-db16-4ebd-b514-4f9b4f4abfd9" /></p>

<br/>

<a href="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml"><p align="center"><img src="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml/badge.svg?branch=master"></p></a>

<p align="center">
  <img src="https://img.shields.io/badge/Windows-blue" />
  <img src="https://img.shields.io/badge/ macOS-white" />
  <img src="https://img.shields.io/badge/Linux-red" />
</p>

<p align="center">
  <a href="https://discord.gg/zSE27rjdzp">
      <img src="https://dcbadge.limes.pink/api/server/https://discord.gg/zSE27rjdzp" />
  </a>
</p>

<p align="center">
  <a href='https://ko-fi.com/rickydane'>
      <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='Compre-me um Café no ko-fi.com' />
  </a>
</p>

<br/>

<p align="center">
  Um explorador de arquivos simples que nasceu porque eu queria aprender a linguagem Rust.
  <br>
  É independente do sistema operacional e foi ajustado para otimização.
</p>

<br/><br/>

O desempenho é alcançado por ["jwalk"](https://crates.io/crates/jwalk/versions) e ["Tauri"](https://tauri.app/).
<br/><br/>
CoDriver não usa cache de caminhos para acessar arquivos e pastas, portanto, o desempenho é obtido pelo Rust, pela velocidade do disco e pelo poder do cpu.

⁉️ Tenha em mente que este software ainda está em desenvolvimento e pode conter bugs!
<br/><br/>

# Links
- <a href="#basic-features">Recursos básicos</a>
- <a href="#advanced-features">Recursos avançados</a>
- <a href="#dependencies-if-not-working-instantly">Dependências</a>
- <a href="#%EF%B8%8F-ftp-integration-sshfs">Implementação FTP (SSHFS)</a>
- <a href="#%EF%B8%8F-known-issues">Problemas conhecidos</a>
- <a href="#-todos">Todos</a>
- <a href="#user-interface">Interface do usuário</a>

## Funcionalidades básicas
- Navegue por diretórios como você já conhece
- Copie e cole, exclua, crie e renomeie arquivos e pastas
- Alterne entre os modos de grade, lista e colunas Miller
- Feche pop-ups com esc
- Pule diretamente para um diretório com Ctrl / Cmd + G inserindo um caminho
- Ordene itens no modo lista por tamanho, nome ou última modificação

## Funcionalidades avançadas
- Compactar arquivos e pastas
  - zip
  - zstd
  - brotli
  - density (https://github.com/g1mv/density)
- Descompactar arquivos
  - rar
  - zip
  - 7zip
  - tar (.gz, .bz2)
  - density
- Navegue para um diretório usando o atalho LAlt + 1 / 2 / 3 | (macOS option + 1 / 2 / 3)
  - Configure os caminhos você mesmo nas configurações
- Criar arquivo com F6
- Criar pasta com F7
- Visualização em dois painéis
  - Pesquise arquivos com F8
  - Copie o elemento selecionado para o outro painel com F5
  - Mova o elemento selecionado para o outro painel com LShift + F5
- Arraste e solte arquivos no explorador para copiá-los para o diretório atual
- Renomeie múltiplos itens selecionados com Ctrl / Cmd + LShift + M
  - Execute a renomeação múltipla com Ctrl / Cmd + Return
- Pré-visualização rápida de arquivos -> Selecione uma entrada de diretório e pressione a barra de espaço.
  - Arquivos suportados: todos os arquivos de imagem (.jpg, .png, ...), .pdf, .mp4, .json, .txt, .html
  - Todos os outros itens mostrarão uma pequena miniatura com algumas informações sobre ele. (caminho, tamanho, última modificação)
- Navegação instantânea -> Comece a digitar e filtre automaticamente as entradas do diretório, tornando às vezes <br/>
  muito mais rápido navegar até o local desejado

## Dependências (Se não funcionar instantaneamente)

<details>
<summary>Expandir para mostrar</summary>

### Linux

- openssl1.1

#### Debian / Ubuntu
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### Arquitetura
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### Fedora
```
sudo dnf check-update
sudo dnf install openssl1.1 \
    webkit2gtk4.0-devel \
    openssl-devel \
    curl \
    wget \
    file \
    libappindicator-gtk3-devel \
    librsvg2-devel
sudo dnf group install "C Development Tools and Libraries"
```
</details>

## 🖥️ Integração FTP (sshfs)
<details>
  <summary>Expandir para mostrar</summary>
  <br/>
  Dependências (Precisam ser instaladas separadamente):
  <br/>

  | macOS | Linux | Windows |
  | ----- | ----- | ------- |
  | fuse-t <br/> fuse-t-sshfs | libfuse | Ainda não suportado **_ainda_** |

  ### Instalação:
  #### macOS
  ```
  brew tap macos-fuse-t/homebrew-cask
  brew install fuse-t
  brew install fuse-t-sshfs
  ```
  #### Linux
  ```
  sudo apt-get install sshfs
  ```

## 🏴‍☠️ Suporte de Idiomas
- Inglês
  - Opção para escolher entre idiomas em breve ...
</details>

## ⚠️ Problemas conhecidos:
- Arrastar e soltar para fora da janela atualmente nem sempre funciona no Linux
- No Windows pode ser necessário instalar o [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170)
- Permissões no MS-Windows são um pouco estranhas
  - Você pode ter que executar o programa como administrador se encontrar problemas ao copiar elementos ou algo semelhante
- Pode haver um problema em que é necessário instalar openssl1.1 em sistemas Linux, quando o programa não inicia

## 📝 Tarefas:
- Múltiplos idiomas
- Favoritos
- Acesso a serviços de armazenamento online (Google Drive, etc.)

## Interface do usuário

### Estilo de lista
<img width="1119" height="673" alt="Screenshot 2025-11-16 at 13 53 53" src="https://github.com/user-attachments/assets/cfe15e6f-9936-4e29-9ca5-0f83f366c9dc" />

### Estilo de grade
<img width="1121" height="674" alt="Screenshot 2025-11-16 at 13 53 46" src="https://github.com/user-attachments/assets/69dbeee0-b53c-4566-b90e-e85ab97e0033" />

### Visualização em colunas Miller
<img width="1112" height="664" alt="Screenshot 2025-11-16 at 13 54 29" src="https://github.com/user-attachments/assets/1f540880-2097-423b-8522-1ef466aee1bd" />

### Visualização em painel duplo
<img width="1119" height="667" alt="Screenshot 2025-11-16 at 13 55 16" src="https://github.com/user-attachments/assets/80706079-a048-4e9e-93f0-54fa270f30ac" />

## Como contribuir
Configure sua máquina para desenvolver aplicações tauri v1: [Pré-requisitos do Tauri](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
Quando isto estiver feito, basta executar ```git clone https://github.com/RickyDane/CoDriver``` ou ```gh repo clone RickyDane/CoDriver``` em um local da sua máquina.
</br></br>
Você deve conseguir executar ```cargo tauri dev``` no diretório raiz deste projeto para começar a compilar e rodar o CoDriver.
</br>
Certifique-se de ter o tauri-cli instalado: ```cargo install tauri-cli```
</br>

## Assinatura de lançamento

Os artefatos de lançamento para macOS devem ser assinados e notarizados para evitar que o Gatekeeper reporte que o aplicativo instalado está corrompido. Veja [Assinatura e notarização no macOS](https://raw.githubusercontent.com/RickyDane/CoDriver/master/docs/macos-signing-notarization.md) para os segredos necessários no GitHub Actions e comandos de verificação.

## Histórico de estrelas

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="Gráfico do Histórico de Estrelas" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### Outros softwares de terceiros
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-24

---