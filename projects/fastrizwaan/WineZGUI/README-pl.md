
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

#### Graficzny interfejs Wine z Zenity - Graj i Udostępniaj!

![](https://raw.githubusercontent.com/fastrizwaan/WineZGUI/main/assets/winezgui.svg) <a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Pobierz z Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>

![](https://github.com/fastrizwaan/WineZGUI/releases/download/0.97.12/winezgui-0.97.14.png)

## Czym jest WineZGUI

WineZGUI (wymawiane Wine-Zee-Goo-Eee) to frontend do Wine umożliwiający łatwe uruchamianie gier Windows za pomocą Wine. Jest to zbiór skryptów Bash do zarządzania prefixami Wine oraz integracji z pulpitem Linuksa dla wygodniejszego grania przez Wine z użyciem Zenity. Pozwala na szybkie uruchamianie plików EXE (bez instalacji) bezpośrednio z menedżera plików, takiego jak Nautilus, oraz umożliwia tworzenie oddzielnych prefixów Wine dla każdego binarnego pliku EXE Windows.

## Dlaczego WineZGUI?

1. Uruchamia gry lub pliki exe Windows z menedżera plików
2. Tworzy skrót aplikacji dla łatwiejszego dostępu.
3. Skupia się na graniu, a nie na konfiguracji prefixów.
4. Umożliwia tworzenie kopii zapasowych i przywracanie prefixów do późniejszego wykorzystania.
5. Tworzy paczki gier do udostępniania (prefix+gra)

## Jak to działa

1. Po otwarciu binarnego pliku Windows lub exe przez WineZGUI,
2. Tworzy nowy prefix (kopiuje szablon) i skrót na pulpicie z nazwą pliku EXE.
3. Po uruchomieniu skryptu przez użytkownika, plik exe zostaje uruchomiony.
4. Jeśli to instalator, wykryje zainstalowane exe i utworzy skróty w kategorii menu Gry.

## Jak uruchomić grę lub program na innej partycji lub katalogu

Otwórz terminal i wpisz:

`flatpak override --user --filesystem=/sciezka/do/twojego/dysku io.github.fastrizwaan.WineZGUI`

### Instalacja WineZGUI

WineZGUI jest dostępny jako Flatpak na Flathub:

<a href="https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI"><img width='240' alt='Download on Flathub' src='https://dl.flathub.org/assets/badges/flathub-badge-en.png'/></a>


WineZGUI z Flathub ma dostęp jedynie do katalogów Pulpit, Dokumenty, Pobrane, Muzyka, Obrazy, Wideo. Aby uzyskać dostęp do plików z innych lokalizacji lub zamontowanych partycji/dysków, należy je skopiować do wymienionych katalogów (Pobrane itp.) lub nadać odpowiednie uprawnienia odczytu, co można zrobić przez aplikację Flatseal lub poleceniem `flatpak --user override --filesystem=host:ro io.github.fastrizwaan.WineZGUI`

Zdecydowanie zalecam użycie wersji flatpak, ponieważ wine z repozytorium (wine-staging) jest ciągle aktualizowane i gry mogą przestać działać co kilka dni. Lepiej używać stabilnej wersji Wine z Flathub lub stabilnej wersji 5.0/7.0 z pakietów dystrybucji.

#### Instalacja WineZGUI flatpak na [obsługiwanych dystrybucjach Linuksa](https://flatpak.org/setup/)

WineZGUI jest spakowany w flatpak-wine przeze mnie. [WineZGUI Flathub](https://flathub.org/apps/details/io.github.fastrizwaan.WineZGUI) oraz mój inny flatpak, obecnie nieaktualny [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine)

### INSTALACJA na systemie Linux, zobacz [Wymagania](https://github.com/fastrizwaan/WineZGUI#requirements)

Instalacja jest natychmiastowa, ponieważ polega na skopiowaniu kilku plików do określonych katalogów.

##### Wersja 0.99.13

Pobierz źródła [WineZGUI-0.99.13.tar.gz](https://github.com/fastrizwaan/WineZGUI/archive/refs/tags/0.99.13.tar.gz) lub użyj `git tag 0.99.13`

##### Użycie tar.gz

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

##### Wersja rozwojowa

```
git clone https://github.com/fastrizwaan/WineZGUI.git
cd WineZGUI
sudo ./setup --install ; #systemwide
```

### Odinstaluj WineZGUI

##### Odinstalowanie Flatpak

```
flatpak remove io.github.fastrizwaan.WineZGUI
```

##### Odinstalowanie systemu

Uruchom `uninstall` z tego samego katalogu źródłowego instalacji

```
sudo ./setup --uninstall
```

## Wymagania

`wine` - główny program

`winetricks` - konieczny skrypt dodatków do wine

`perl‑image‑exiftool` - do wyodrębniania nazwy aplikacji/gry

`icoutils` - do wyodrębniania ikony z pliku exe

`gnome-terminal` - (opcjonalnie) do dostępu do katalogu prefixu w powłoce

## Instalacja wymagań dla systemu Linux

### Dystrybucje wspierające Flatpak

Pobierz [flatpak-wine](https://github.com/fastrizwaan/flatpak-wine/releases), który zawiera wszystkie zależności. Przydatne dla dystrybucji, które nie pakują wine.

```
flatpak --user remote-add --if-not-exists flathub https://flathub.org/repo/flathub.flatpakrepo
flatpak --user -y install flathub org.winehq.Wine/x86_64/stable-24.08
```

## Wymagania dotyczące środowiska uruchomieniowego:

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

#### Kontrolery kompatybilne z XBOX

zbuduj i zainstaluj sterowniki jądra dla kontrolerów kompatybilnych z xbox 360 z https://github.com/paroj/xpad


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-28

---