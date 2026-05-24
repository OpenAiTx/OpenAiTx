
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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
      <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='Comprami un caffè su ko-fi.com' />
  </a>
</p>

<br/>

<p align="center">
  Un semplice esploratore di file nato dal desiderio di imparare il linguaggio Rust.
  <br>
  È indipendente dal sistema operativo ed è ottimizzato per la massima efficienza.
</p>

<br/><br/>

Le prestazioni sono garantite da ["jwalk"](https://crates.io/crates/jwalk/versions) e ["Tauri"](https://tauri.app/).
<br/><br/>
CoDriver non utilizza la cache dei percorsi per accedere a file e cartelle, quindi le prestazioni sono dovute a Rust, alla velocità del disco e alla potenza della CPU.

⁉️ Ricorda che questo software è ancora in fase di sviluppo e potrebbe contenere bug!
<br/><br/>

# Link
- <a href="#basic-features">Funzionalità di base</a>
- <a href="#advanced-features">Funzionalità avanzate</a>
- <a href="#dependencies-if-not-working-instantly">Dipendenze</a>
- <a href="#%EF%B8%8F-ftp-integration-sshfs">Implementazione FTP (SSHFS)</a>
- <a href="#%EF%B8%8F-known-issues">Problemi noti</a>
- <a href="#-todos">Todo</a>
- <a href="#user-interface">Interfaccia utente</a>

## Funzionalità di base
- Naviga tra le directory come sei abituato
- Copia & Incolla, elimina, crea e rinomina file e cartelle
- Passa tra modalità griglia, elenco e colonne miller
- Chiudi i popup con esc
- Vai direttamente a una directory con Ctrl / Cmd + G inserendo un percorso
- Ordina gli elementi in modalità elenco per dimensione, nome o ultima modifica

## Funzionalità avanzate
- Comprimi file e cartelle
  - zip
  - zstd
  - brotli
  - density (https://github.com/g1mv/density)
- Estrai archivi
  - rar
  - zip
  - 7zip
  - tar (.gz, .bz2)
  - density
- Vai a una directory usando la scorciatoia LAlt + 1 / 2 / 3 | (macOS option + 1 / 2 / 3)
  - Configura tu stesso i percorsi nelle impostazioni
- Crea file con F6
- Crea cartella con F7
- Visuale a doppio pannello
  - Cerca file con F8
  - Copia l'elemento selezionato nel pannello opposto con F5
  - Sposta l'elemento selezionato nel pannello opposto con LShift + F5
- Trascina e rilascia file nell'esploratore per copiarli nella directory corrente
- Rinomina in massa la selezione con Ctrl / Cmd + LShift + M
  - Esegui la rinomina in massa con Ctrl / Cmd + Return
- Anteprima rapida dei file -> Seleziona una voce di directory e premi la barra spaziatrice.
  - File supportati: tutti i file immagine (.jpg, .png, ...), .pdf, .mp4, .json, .txt, .html
  - Tutti gli altri elementi mostreranno una piccola tessera con alcune informazioni. (percorso, dimensione, ultima modifica)
- Navigazione istantanea -> Inizia a digitare e filtra automaticamente le voci della directory rendendo <br/>
  spesso molto più veloce raggiungere la posizione desiderata

## Dipendenze (Se non funziona immediatamente)

<details>
<summary>Espandi per mostrare</summary>

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

#### Architettura
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

## 🖥️ Integrazione FTP (sshfs)
<details>
  <summary>Espandi per visualizzare</summary>
  <br/>
  Dipendenze (da installare separatamente):
  <br/>

  | macOS | Linux | Windows |
  | ----- | ----- | ------- |
  | fuse-t <br/> fuse-t-sshfs | libfuse | Non supportato **_ancora_** |

  ### Installazione:
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

## 🏴‍☠️ Supporto Lingua
- Inglese
  - Opzione per scegliere tra le lingue in arrivo ...
</details>

## ⚠️ Problemi noti:
- Il trascinamento fuori dalla finestra attualmente non funziona sempre su linux
- Su windows potrebbe essere necessario installare [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170)
- I permessi su ms-windows sono un po' strani
  - Potresti dover eseguire il programma come amministratore se incontri problemi nel copiare elementi o simili
- Potrebbe essere necessario installare openssl1.1 su sistemi linux, se il programma non si avvia

## 📝 Da fare:
- Lingue multiple
- Preferiti
- Accesso a servizi di archiviazione online (Google drive, ecc.)

## Interfaccia utente

### Stile elenco
<img width="1119" height="673" alt="Screenshot 2025-11-16 at 13 53 53" src="https://github.com/user-attachments/assets/cfe15e6f-9936-4e29-9ca5-0f83f366c9dc" />

### Stile griglia
<img width="1121" height="674" alt="Screenshot 2025-11-16 at 13 53 46" src="https://github.com/user-attachments/assets/69dbeee0-b53c-4566-b90e-e85ab97e0033" />

### Vista colonne Miller
<img width="1112" height="664" alt="Screenshot 2025-11-16 at 13 54 29" src="https://github.com/user-attachments/assets/1f540880-2097-423b-8522-1ef466aee1bd" />

### Vista doppio pannello
<img width="1119" height="667" alt="Screenshot 2025-11-16 at 13 55 16" src="https://github.com/user-attachments/assets/80706079-a048-4e9e-93f0-54fa270f30ac" />

## Come contribuire
Configura la tua macchina per sviluppare applicazioni tauri v1: [Prerequisiti Tauri](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
Quando hai terminato, esegui semplicemente ```git clone https://github.com/RickyDane/CoDriver``` oppure ```gh repo clone RickyDane/CoDriver``` in una posizione sulla tua macchina.
</br></br>
Dovresti poter eseguire ```cargo tauri dev``` nella directory principale di questo progetto per iniziare a costruire ed eseguire CoDriver.
</br>
Assicurati di avere installato tauri-cli: ```cargo install tauri-cli```
</br>

## Firma della release

Gli artefatti delle release per macOS devono essere firmati e notarizzati per evitare che Gatekeeper segnali che l'app installata è danneggiata. Consulta [Firma e notarizzazione su macOS](https://raw.githubusercontent.com/RickyDane/CoDriver/master/docs/macos-signing-notarization.md) per i secret richiesti da GitHub Actions e i comandi di verifica.

## Cronologia delle stelle

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="Grafico della Cronologia delle Stelle" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### Altri software di terze parti
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-24

---