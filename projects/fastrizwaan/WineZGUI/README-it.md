
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=fastrizwaan&project=WineZGUI&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# WineZGUI

#### Interfaccia grafica di Wine tramite Zenity - Gioca e Condividi!

![](https://raw.githubusercontent.com/fastrizwaan/WineZGUI/main/assets/winezgui.svg) <a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Scarica su Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

![](https://github.com/fastrizwaan/WineZGUI/releases/download/0.97.12/winezgui-0.97.14.png)

## Cos'è WineZGUI

WineZGUI (si pronuncia Wine-Zee-Goo-Eee) è un frontend per Wine che permette di giocare facilmente a giochi Windows con Wine. È una raccolta di script Bash per la gestione dei prefissi Wine e l'integrazione con il desktop Linux, per un'esperienza di gioco più semplice tramite Zenity. Consente l'avvio rapido di applicazioni o giochi EXE Direct play (non installati) dal File Manager come Nautilus e permette la creazione di un prefisso Wine separato per ogni binario EXE di Windows.

## Perché WineZGUI?

1. Esegue giochi Windows o file exe dal file manager
2. Crea collegamenti applicativi per un accesso più semplice.
3. Si concentra sul gioco invece che sulla configurazione dei prefissi.
4. Effettua backup e ripristino dei prefissi per un utilizzo futuro.
5. Crea Game Bundle per la condivisione (prefisso+gioco)

## Come funziona

1. Quando un binario Windows o un exe viene aperto con WineZGUI,
2. Viene creato un nuovo prefisso (copia del template) e un collegamento sul desktop con il nome dell'EXE.
3. Quando l'utente avvia lo script, viene avviato l'exe.
4. Se è un setup, rileva l'exe installato e crea collegamenti nel menu Giochi.

## Come eseguire un gioco o programma su un altro drive o directory

Apri il Terminale e digita questo:

`flatpak override --user --filesystem=/percorso/al/tuo/drive io.github.fastrizwaan.WineZGUI`

### Installare WineZGUI

WineZGUI è disponibile come Flatpak su Flathub:

<a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Scarica su Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>


Flathub WineZGUI può accedere solo alle directory Desktop, Documenti, Download, Musica, Immagini, Video. Per accedere ai file da altre posizioni o altre partizioni o dischi montati, copiarli nelle directory sopra menzionate (Download ecc.) oppure occorre il permesso di lettura, che può essere concesso usando l’app Flatseal o il comando `flatpak --user override --filesystem=host:ro io.github.fastrizwaan.WineZGUI`

Consiglio vivamente di usare la versione flatpak, perché il wine basato su distro (wine-staging) viene aggiornato spesso e i giochi potrebbero smettere di funzionare ogni pochi giorni. Usare wine stable da flathub è meglio, oppure utilizzare wine stable 5.0 o 7.0 dai pacchetti della distro.

#### Installare WineZGUI flatpak su [distro Linux supportate](https://flatpak.org/setup/)

WineZGUI è incluso in flatpak-wine dallo stesso autore. [WineZGUI Flathub](https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI) il mio altro flatpak ora deprecato [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine)

### INSTALLAZIONE su un sistema Linux, vedi [Requisiti](https://github.com/fastrizwaan/WineZGUI#requirements)

L'installazione è immediata in quanto copia alcuni file in directory specifiche.

##### Versione 0.99.13

Scarica il sorgente [WineZGUI-0.99.13.tar.gz](https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz) oppure usa `git tag 0.99.13`

##### Utilizzo di tar.gz

```
wget https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz
tar -zxvf 0.99.13.tar.gz
cd WineZGUI-0.99.13
sudo ./setup --install ; #systemwide
```

##### git tag 0.99.13

```
git clone --depth 1 --branch 0.99.13 https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

##### Versione di sviluppo

```
git clone https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

### Disinstallare WineZGUI

##### Disinstallazione Flatpak

```
flatpak remove io.github.fastrizwaan.WineZGUI
```

##### Disinstallazione del sistema

Esegui `uninstall` dalla stessa directory della fonte di installazione

```
sudo ./setup --uninstall
```

## Requisiti

`wine` - programma principale

`winetricks` - script aggiuntivo indispensabile per wine

`perl‑image‑exiftool` - per estrarre il nome dell'applicazione/gioco

`icoutils` - per estrarre l'icona dal file exe

`gnome-terminal` - (opzionale) per accedere alla directory del prefix tramite shell

## Installazione dei Requisiti per Linux OS

### Distribuzioni Supportate Flatpak

Scarica [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine/releases) che include tutte le dipendenze. Utile per le distribuzioni che non includono wine nei pacchetti.

```
flatpak --user remote-add --if-not-exists flathub https://flathub.org/repo/flathub.flatpakrepo
flatpak --user -y install flathub org.winehq.Wine/x86_64/stable-24.08
```

## Dipendenze di Runtime:

### Fedora 36

`sudo dnf install zenity wine winetricks perl-Image-ExifTool icoutils gnome-terminal wget zstd samba-winbind-clients.x86_64 samba-winbind-clients.i686`

### Debian / Ubuntu / Linux Mint

```
sudo dpkg --add-architecture i386 && sudo apt update
sudo apt install zenity wine wine32 wine64 winetricks libimage-exiftool-perl icoutils gnome-terminal wget zstd winbind
```

### Solus

```
sudo eopkg it zenity wine wine-32bit winetricks perl-image-exiftool icoutils gnome-terminal wget zstd diffutils samba-devel
```

### Arch Linux / EndeavourOS

```
sudo pacman -Sy zenity wine winetricks perl-image-exiftool icoutils gnome-terminal wget \
                lib32-alsa-plugins lib32-libpulse lib32-openal zstd samba
```

#### Controller compatibili XBOX

compila e installa i driver del kernel per i controller compatibili xbox 360 da https://github.com/paroj/xpad


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---