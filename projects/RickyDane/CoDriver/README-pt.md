
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
      <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='Compre-me um café em ko-fi.com' />
  </a>
</p>

<br/>

<p align="center">
  Um explorador de arquivos simples que nasceu porque eu queria aprender a linguagem Rust.
  <br>
  Ele é independente de sistema operacional e otimizado para performance.
</p>

<br/><br/>

O desempenho é alcançado por meio de ["jwalk"](https://crates.io/crates/jwalk/versions) e ["Tauri"](https://tauri.app/).
<br/><br/>
O CoDriver não utiliza cache de caminhos para acessar arquivos e pastas, então o desempenho é obtido pelo Rust, pela velocidade do disco e pelo poder da cpu.

⁉️ Lembre-se de que este software ainda está em desenvolvimento e pode conter bugs!
<br/><br/>

# Links
- <a href="#basic-features">Recursos básicos</a>
- <a href="#advanced-features">Recursos avançados</a>
- <a href="#dependencies-if-not-working-instantly">Dependências</a>
- <a href="#%EF%B8%8F-ftp-sftp-integration">Integração FTP / SFTP</a>
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

## 🖥️ Integração FTP / SFTP

O CoDriver oferece suporte totalmente nativo e pronto para uso para conexões remotas FTP e SFTP. Nenhuma dependência externa, camadas FUSE ou montagens `sshfs` são necessárias! Basta conectar seus servidores remotos diretamente no painel lateral.

## 🏴‍☠️ Suporte a Idiomas
- Inglês
  - Opção para escolher entre idiomas em breve ...

## ⚠️ Problemas conhecidos:
- Arrastar e soltar para fora da janela atualmente nem sempre funciona no Linux
- No Windows, pode ser necessário instalar o [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170)
- Permissões no ms-windows são um pouco estranhas
  - Pode ser necessário executar o programa como administrador se encontrar problemas para copiar elementos ou algo semelhante
- Pode haver um problema em que é preciso instalar o openssl1.1 em sistemas Linux, caso o programa não inicie

## 📝 Tarefas:
- Vários idiomas
- Favoritos
- Acesso a serviços de armazenamento online (Google Drive, etc.)

## Interface do usuário
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 16" src="https://github.com/user-attachments/assets/fc408504-3000-4325-bc2a-638cdd01ea0a" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 40" src="https://github.com/user-attachments/assets/5f772d02-6bc2-470c-b999-6982043496c1" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 02" src="https://github.com/user-attachments/assets/7f2ec5ea-a669-4630-a1f8-413c7ced3f3b" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 07" src="https://github.com/user-attachments/assets/4ac9930d-7b50-4910-afb3-d47c562c3b44" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 28" src="https://github.com/user-attachments/assets/7dcfb0fa-c106-401a-b917-06e766021368" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 18" src="https://github.com/user-attachments/assets/4bac06d1-22df-47d4-95c9-1ccb50083506" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 39" src="https://github.com/user-attachments/assets/fdca23b0-9ed5-495b-9fec-18ecbfd4d5f2" />



## Como contribuir
Prepare sua máquina para desenvolver aplicações tauri v1: [Pré-requisitos do Tauri](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
Quando terminar, basta executar ```git clone https://github.com/RickyDane/CoDriver``` ou ```gh repo clone RickyDane/CoDriver``` em um local na sua máquina.
</br></br>
Você deve conseguir rodar ```cargo tauri dev``` no diretório raiz deste projeto para começar a construir e executar o CoDriver.
</br>
Certifique-se de ter o tauri-cli instalado: ```cargo install tauri-cli```
</br>

## Assinatura de lançamento

Os artefatos de lançamento do macOS devem ser assinados e notarizados para evitar que o Gatekeeper reporte que o aplicativo instalado está danificado. Veja [Assinatura e notarização no macOS](https://raw.githubusercontent.com/RickyDane/CoDriver/master/docs/macos-signing-notarization.md) para os segredos necessários do GitHub Actions e comandos de verificação.

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-26

---