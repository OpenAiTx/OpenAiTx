
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=id">Indonesisch</a>
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
      <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='Koop een koffie voor mij op ko-fi.com' />
  </a>
</p>

<br/>

<p align="center">
  Een eenvoudige bestandsverkenner die is ontstaan omdat ik de Rust-taal wilde leren.
  <br>
  Het is onafhankelijk van het besturingssysteem en geoptimaliseerd voor snelheid.
</p>

<br/><br/>

De prestaties worden bereikt door ["jwalk"](https://crates.io/crates/jwalk/versions) en ["Tauri"](https://tauri.app/).
<br/><br/>
CoDriver gebruikt geen padcaching om bestanden en mappen te openen; de prestaties zijn te danken aan Rust, de snelheid van de schijf en de kracht van de cpu.

⁉️ Houd er rekening mee dat deze software nog in ontwikkeling is en bugs kan bevatten!
<br/><br/>

# Links
- <a href="#basic-features">Basisfuncties</a>
- <a href="#advanced-features">Geavanceerde functies</a>
- <a href="#dependencies-if-not-working-instantly">Vereisten</a>
- <a href="#%EF%B8%8F-ftp-sftp-integration">FTP / SFTP integratie</a>
- <a href="#%EF%B8%8F-known-issues">Bekende problemen</a>
- <a href="#-todos">Te doen</a>
- <a href="#user-interface">Gebruikersinterface</a>

## Basisfuncties
- Navigeer door mappen zoals je gewend bent
- Kopieer & Plak, verwijder, maak en hernoem bestanden en mappen
- Wissel tussen raster-, lijst- en miller-kolommenmodus
- Sluit pop-ups met esc
- Ga direct naar een map met Ctrl / Cmd + G door een pad in te voeren
- Sorteer items in lijstmodus op grootte, naam of laatst gewijzigd

## Geavanceerde functies
- Comprimeer bestanden en mappen
  - zip
  - zstd
  - brotli
  - density (https://github.com/g1mv/density)
- Pak archieven uit
  - rar
  - zip
  - 7zip
  - tar (.gz, .bz2)
  - density
- Navigeer naar een map met de sneltoets LAlt + 1 / 2 / 3 | (macOS option + 1 / 2 / 3)
  - Stel de paden zelf in via de instellingen
- Maak een bestand aan met F6
- Maak een map aan met F7
- Dubbelvenster-weergave
  - Zoek naar bestanden met F8
  - Kopieer het geselecteerde element naar het andere venster met F5
  - Verplaats het geselecteerde element naar het andere venster met LShift + F5
- Sleep bestanden naar de verkenner om ze in de huidige map te kopiëren
- Hernoem meerdere geselecteerde items met Ctrl / Cmd + LShift + M
  - Voer multi-hernoemen uit met Ctrl / Cmd + Return
- Snelvoorbeeld bestand -> Selecteer mapitem en tik op de spatiebalk.
  - Ondersteunde bestanden: alle afbeeldingsbestanden (.jpg, .png, ...), .pdf, .mp4, .json, .txt, .html
  - Alle andere items tonen een kleine tegel met wat informatie erover. (pad, grootte, laatst gewijzigd)
- Direct navigeren -> Begin met typen en filter de mapelementen automatisch waardoor het soms <br/>
  veel sneller is om naar de gewenste locatie te navigeren

## Afhankelijkheden (Indien niet direct werkend)

<details>
<summary>Uitklappen om te tonen</summary>

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

#### Arch
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

## 🖥️ FTP / SFTP-integratie

CoDriver biedt volledig native, kant-en-klare ondersteuning voor FTP- en SFTP-verbindingen op afstand. Geen externe afhankelijkheden, FUSE-lagen of `sshfs`-koppelingen nodig! Verbind gewoon je externe servers direct in het zijbalkpaneel.

## 🏴‍☠️ Taalondersteuning
- Engels
  - Mogelijkheid om tussen talen te kiezen binnenkort beschikbaar ...

## ⚠️ Bekende problemen:
- Slepen en neerzetten buiten het venster werkt momenteel niet altijd op linux
- Op windows moet je mogelijk [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170) installeren
- Machtigingen op ms-windows zijn een beetje vreemd
  - Je moet het programma mogelijk als administrator uitvoeren als je problemen ondervindt met het kopiëren van elementen of iets dergelijks
- Er kan een probleem zijn dat je openssl1.1 moet installeren op linux-systemen, als het programma niet start

## 📝 Takenlijst:
- Meerdere talen
- Favorieten
- Toegang tot online opslagdiensten (Google drive, etc.)

## Gebruikersinterface
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 16" src="https://github.com/user-attachments/assets/fc408504-3000-4325-bc2a-638cdd01ea0a" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 40" src="https://github.com/user-attachments/assets/5f772d02-6bc2-470c-b999-6982043496c1" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 02" src="https://github.com/user-attachments/assets/7f2ec5ea-a669-4630-a1f8-413c7ced3f3b" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 07" src="https://github.com/user-attachments/assets/4ac9930d-7b50-4910-afb3-d47c562c3b44" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 28" src="https://github.com/user-attachments/assets/7dcfb0fa-c106-401a-b917-06e766021368" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 18" src="https://github.com/user-attachments/assets/4bac06d1-22df-47d4-95c9-1ccb50083506" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 39" src="https://github.com/user-attachments/assets/fdca23b0-9ed5-495b-9fec-18ecbfd4d5f2" />



## Hoe bij te dragen
Stel je computer in voor het ontwikkelen van tauri v1-applicaties: [Tauri-vereisten](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
Als dit is gedaan, voer dan gewoon ```git clone https://github.com/RickyDane/CoDriver``` of ```gh repo clone RickyDane/CoDriver``` uit op een locatie op je computer.
</br></br>
Je zou ```cargo tauri dev``` in de hoofdmap van dit project moeten kunnen uitvoeren om CoDriver te bouwen en te starten.
</br>
Zorg ervoor dat tauri-cli is geïnstalleerd: ```cargo install tauri-cli```
</br>

## Release ondertekenen

macOS release-artikelen moeten worden ondertekend en genotariseerd om te voorkomen dat Gatekeeper meldt dat de geïnstalleerde app beschadigd is. Zie [macOS ondertekening en notarizatie](https://raw.githubusercontent.com/RickyDane/CoDriver/master/docs/macos-signing-notarization.md) voor vereiste GitHub Actions secrets en verificatiecommando's.

## Stergeschiedenis

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="Stergeschiedenis grafiek" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### Overige software van derden
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-26

---