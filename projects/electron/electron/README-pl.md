[![Logo Electron](https://electronjs.org/images/electron-logo.svg)](https://electronjs.org)

[![Status kompilacji GitHub Actions](https://github.com/electron/electron/actions/workflows/build.yml/badge.svg)](https://github.com/electron/electron/actions/workflows/build.yml)
[![Zaproszenie na Discord Electron](https://img.shields.io/discord/745037351163527189?color=%237289DA&label=chat&logo=discord&logoColor=white)](https://discord.gg/electronjs)

:memo: Dostępne tłumaczenia: 🇨🇳 🇧🇷 🇪🇸 🇯🇵 🇷🇺 🇫🇷 🇺🇸 🇩🇪.
Przeglądaj tę dokumentację w innych językach na naszym projekcie [Crowdin](https://crowdin.com/project/electron).

Framework Electron umożliwia tworzenie wieloplatformowych aplikacji desktopowych
z wykorzystaniem JavaScript, HTML i CSS. Bazuje na [Node.js](https://nodejs.org/) oraz
[Chromium](https://www.chromium.org) i jest używany przez
[Visual Studio Code](https://github.com/Microsoft/vscode/) oraz wiele innych [aplikacji](https://electronjs.org/apps).

Obserwuj [@electronjs](https://twitter.com/electronjs) na Twitterze, aby otrzymywać ważne
ogłoszenia.

Projekt przestrzega Contributor Covenant
[kodeksu postępowania](https://github.com/electron/electron/tree/main/CODE_OF_CONDUCT.md).
Uczestnicząc, oczekujemy przestrzegania tego kodeksu. Nieakceptowalne zachowania prosimy zgłaszać na [coc@electronjs.org](mailto:coc@electronjs.org).

## Instalacja

Aby zainstalować prekompilowane pliki binarne Electron, użyj [`npm`](https://docs.npmjs.com/).
Zalecanym sposobem jest instalacja Electron jako zależności deweloperskiej w Twojej
aplikacji:

```sh
npm install electron --save-dev
```

Więcej opcji instalacji i wskazówki dotyczące rozwiązywania problemów znajdziesz w
[installation](docs/tutorial/installation.md). Informacje na temat zarządzania wersjami Electron w aplikacjach znajdziesz w
[Electron versioning](docs/tutorial/electron-versioning.md).

## Wsparcie platform

Każde wydanie Electron dostarcza pliki binarne dla systemów macOS, Windows i Linux.

* macOS (Big Sur i nowsze): Electron udostępnia 64-bitowe pliki binarne Intel oraz Apple Silicon / ARM dla macOS.
* Windows (Windows 10 i nowsze): Electron udostępnia pliki binarne `ia32` (`x86`), `x64` (`amd64`) oraz `arm64` dla Windows. Wsparcie dla Windows on ARM zostało dodane w Electron 5.0.8. Wsparcie dla Windows 7, 8 oraz 8.1 zostało [usunięte w Electron 23, zgodnie z polityką deprecjacji Windows przez Chromium](https://www.electronjs.org/blog/windows-7-to-8-1-deprecation-notice).
* Linux: Prekompilowane pliki binarne Electron są budowane na Ubuntu 20.04. Zweryfikowano również ich działanie na:
  * Ubuntu 18.04 i nowszych
  * Fedora 32 i nowszych
  * Debian 10 i nowszych

## Electron Fiddle

Użyj [`Electron Fiddle`](https://github.com/electron/fiddle),
aby budować, uruchamiać i pakować małe eksperymenty z Electronem, przeglądać przykłady kodu dla wszystkich API Electron oraz
testować różne wersje Electron. Narzędzie zaprojektowane, aby ułatwić rozpoczęcie pracy z
Electron.

## Zasoby do nauki Electron

* [electronjs.org/docs](https://electronjs.org/docs) - Pełna dokumentacja Electron
* [electron/fiddle](https://github.com/electron/fiddle) - Narzędzie do budowania, uruchamiania i pakowania małych eksperymentów z Electron
* [electronjs.org/community#boilerplates](https://electronjs.org/community#boilerplates) - Przykładowe aplikacje startowe tworzone przez społeczność

## Programistyczne użycie

Większość osób korzysta z Electron z poziomu linii poleceń, ale jeśli załadujesz `electron` w swojej
**aplikacji Node** (nie w aplikacji Electron), zwróci on ścieżkę do
pliku binarnego. Użyj tego, aby uruchamiać Electron ze skryptów Node:

```javascript
const electron = require('electron')
const proc = require('node:child_process')

// wyświetli coś podobnego do /Users/maf/.../Electron
console.log(electron)

// uruchom Electron
const child = proc.spawn(electron)
```

### Mirrory

* [Chiny](https://npmmirror.com/mirrors/electron/)

Zobacz [Zaawansowane instrukcje instalacji](https://www.electronjs.org/docs/latest/tutorial/installation#mirror), aby dowiedzieć się, jak używać niestandardowego mirrora.

## Tłumaczenia dokumentacji

Tłumaczenia naszej dokumentacji są realizowane społecznościowo przez [Crowdin](https://crowdin.com/project/electron).
Obecnie akceptujemy tłumaczenia na chiński (uproszczony), francuski, niemiecki, japoński, portugalski,
rosyjski i hiszpański.

## Współtworzenie

Jeśli jesteś zainteresowany zgłaszaniem/poprawianiem błędów lub bezpośrednim współtworzeniem kodu, zapoznaj się z [CONTRIBUTING.md](CONTRIBUTING.md), aby dowiedzieć się, czego oczekujemy i jak zacząć.

## Społeczność

Informacje o zgłaszaniu błędów, uzyskiwaniu pomocy, znajdowaniu narzędzi firm trzecich i przykładowych aplikacji
oraz więcej znajdziesz na [stronie Społeczność](https://www.electronjs.org/community).

## Licencja

[MIT](https://github.com/electron/electron/blob/main/LICENSE)

Korzystając z logotypów Electron, upewnij się, że przestrzegasz [Polityki znaków towarowych OpenJS Foundation](https://trademark-policy.openjsf.org/).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---