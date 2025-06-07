<p align="center"><img src="https://ohmyzsh.s3.amazonaws.com/omz-ansi-github.png" alt="Oh My Zsh"></p>

Oh My Zsh to otwartoźródłowy, napędzany przez społeczność framework do zarządzania konfiguracją [zsh](https://www.zsh.org/).

Brzmi nudno. Spróbujmy jeszcze raz.

**Oh My Zsh nie uczyni Cię deweloperem 10x... ale możesz się tak poczuć.**

Po zainstalowaniu Twoja powłoka terminala stanie się tematem rozmów w mieście _albo zwrot pieniędzy!_ Każde naciśnięcie klawisza w Twoim terminalu pozwoli Ci korzystać z setek potężnych wtyczek i pięknych motywów. Nieznajomi będą podchodzić do Ciebie w kawiarniach i pytać, _"to niesamowite! jesteś jakimś geniuszem?"_

Wreszcie zaczniesz otrzymywać uwagę, na którą zawsze zasługiwałeś. ...albo wykorzystasz zaoszczędzony czas, by częściej nitkować zęby. 😬

Aby dowiedzieć się więcej, odwiedź [ohmyz.sh](https://ohmyz.sh), śledź [@ohmyzsh](https://x.com/ohmyzsh) na X (dawniej Twitter), i dołącz do nas na [Discordzie](https://discord.gg/ohmyzsh).

[![CI](https://github.com/ohmyzsh/ohmyzsh/workflows/CI/badge.svg)](https://github.com/ohmyzsh/ohmyzsh/actions?query=workflow%3ACI)
[![X (formerly Twitter) Follow](https://img.shields.io/twitter/follow/ohmyzsh?label=%40ohmyzsh&logo=x&style=flat)](https://twitter.com/intent/follow?screen_name=ohmyzsh)
[![Mastodon Follow](https://img.shields.io/mastodon/follow/111169632522566717?label=%40ohmyzsh&domain=https%3A%2F%2Fmstdn.social&logo=mastodon&style=flat)](https://mstdn.social/@ohmyzsh)
[![Discord server](https://img.shields.io/discord/642496866407284746)](https://discord.gg/ohmyzsh)
[![Gitpod ready](https://img.shields.io/badge/Gitpod-ready-blue?logo=gitpod)](https://gitpod.io/#https://github.com/ohmyzsh/ohmyzsh)

<details>
<summary>Spis treści</summary>

- [Pierwsze kroki](#getting-started)
  - [Kompatybilność systemów operacyjnych](#operating-system-compatibility)
  - [Wymagania wstępne](#prerequisites)
  - [Podstawowa instalacja](#basic-installation)
    - [Ręczna inspekcja](#manual-inspection)
- [Korzystanie z Oh My Zsh](#using-oh-my-zsh)
  - [Wtyczki](#plugins)
    - [Włączanie wtyczek](#enabling-plugins)
    - [Korzystanie z wtyczek](#using-plugins)
  - [Motywy](#themes)
    - [Wybór motywu](#selecting-a-theme)
  - [FAQ](#faq)
- [Zaawansowane tematy](#advanced-topics)
  - [Zaawansowana instalacja](#advanced-installation)
    - [Własny katalog](#custom-directory)
    - [Instalacja bezobsługowa](#unattended-install)
    - [Instalacja z forka](#installing-from-a-forked-repository)
    - [Instalacja ręczna](#manual-installation)
  - [Problemy z instalacją](#installation-problems)
  - [Własne wtyczki i motywy](#custom-plugins-and-themes)
  - [Włączenie GNU ls w systemach macOS i freeBSD](#enable-gnu-ls-in-macos-and-freebsd-systems)
  - [Pomijanie aliasów](#skip-aliases)
  - [Asynchroniczny prompt git](#async-git-prompt)
- [Aktualizacje](#getting-updates)
  - [Szczegółowość aktualizacji](#updates-verbosity)
  - [Ręczne aktualizacje](#manual-updates)
- [Odinstalowywanie Oh My Zsh](#uninstalling-oh-my-zsh)
- [Jak mogę przyczynić się do Oh My Zsh?](#how-do-i-contribute-to-oh-my-zsh)
  - [Nie wysyłaj nam motywów](#do-not-send-us-themes)
- [Współtwórcy](#contributors)
- [Śledź nas](#follow-us)
- [Gadżety](#merchandise)
- [Licencja](#license)
- [O Planet Argon](#about-planet-argon)

</details>

## Pierwsze kroki

### Kompatybilność systemów operacyjnych

| System O/S     | Status |
| :------------- | :----: |
| Android        |   ✅   |
| freeBSD        |   ✅   |
| LCARS          |   🛸   |
| Linux          |   ✅   |
| macOS          |   ✅   |
| OS/2 Warp      |   ❌   |
| Windows (WSL2) |   ✅   |

### Wymagania wstępne

- Powinien być zainstalowany [Zsh](https://www.zsh.org) (wystarczy v4.3.9 lub nowszy, ale preferujemy 5.0.8 lub nowszy). Jeśli nie jest zainstalowany (sprawdź poleceniem `zsh --version`), zobacz instrukcje na wiki: [Installing ZSH](https://github.com/ohmyzsh/ohmyzsh/wiki/Installing-ZSH)
- Powinien być zainstalowany `curl` lub `wget`
- Powinien być zainstalowany `git` (zalecane v2.4.11 lub nowszy)

### Podstawowa instalacja

Oh My Zsh instaluje się poprzez uruchomienie jednego z poniższych poleceń w terminalu. Możesz zainstalować poprzez linię poleceń używając `curl`, `wget` lub podobnego narzędzia.

| Metoda    | Polecenie                                                                                           |
| :-------- | :-------------------------------------------------------------------------------------------------- |
| **curl**  | `sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`   |
| **wget**  | `sh -c "$(wget -O- https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`     |
| **fetch** | `sh -c "$(fetch -o - https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`   |

Alternatywnie, instalator jest także mirrorowany poza GitHub. Użycie tego URL może być wymagane, jeśli jesteś w kraju takim jak Chiny lub Indie (dla niektórych ISP), gdzie `raw.githubusercontent.com` jest zablokowane:

| Metoda    | Polecenie                                         |
| :-------- | :------------------------------------------------ |
| **curl**  | `sh -c "$(curl -fsSL https://install.ohmyz.sh/)"` |
| **wget**  | `sh -c "$(wget -O- https://install.ohmyz.sh/)"`   |
| **fetch** | `sh -c "$(fetch -o - https://install.ohmyz.sh/)"` |

_Uwaga: każde poprzednie `.zshrc` zostanie przemianowane na `.zshrc.pre-oh-my-zsh`. Po instalacji możesz przenieść konfigurację, którą chcesz zachować, do nowego `.zshrc`._

#### Ręczna inspekcja

Warto przejrzeć skrypt instalacyjny z projektów, których jeszcze nie znasz. Możesz to zrobić, pobierając najpierw skrypt instalacyjny, przeglądając go, a następnie uruchamiając:

```sh
wget https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh
sh install.sh
```

Jeśli powyższy URL się nie ładuje lub zawodzi, możesz zamienić go na `https://install.ohmyz.sh`, aby pobrać skrypt.

## Korzystanie z Oh My Zsh

### Wtyczki

Oh My Zsh zawiera ogromną ilość wtyczek do Twojej dyspozycji. Możesz zajrzeć do katalogu [plugins](https://github.com/ohmyzsh/ohmyzsh/tree/master/plugins) i/lub na [wiki](https://github.com/ohmyzsh/ohmyzsh/wiki/Plugins), by zobaczyć, co jest obecnie dostępne.

#### Włączanie wtyczek

Po wybraniu wtyczki (lub kilku), które chcesz używać z Oh My Zsh, musisz je włączyć w pliku `.zshrc`. Plik zshrc znajdziesz w katalogu `$HOME`. Otwórz go ulubionym edytorem tekstu i znajdziesz miejsce, gdzie można wpisać wszystkie wtyczki, które chcesz załadować.

```sh
vi ~/.zshrc
```

Na przykład, może to wyglądać tak:

```sh
plugins=(
  git
  bundler
  dotenv
  macos
  rake
  rbenv
  ruby
)
```

_Uwaga: wtyczki oddzielone są spacjami, tabulatorami, nowymi liniami... **Nie** używaj przecinków między nimi, bo to spowoduje błąd._

#### Korzystanie z wtyczek

Każda wbudowana wtyczka zawiera plik **README** z jej dokumentacją. README powinien pokazywać aliasy (jeśli wtyczka je dodaje) i dodatkowe funkcje dostępne w danej wtyczce.

### Motywy

Przyznajemy. Na początku świata Oh My Zsh trochę przesadziliśmy z motywami. Teraz mamy ponad sto pięćdziesiąt motywów. Większość z nich ma [zrzuty ekranu](https://github.com/ohmyzsh/ohmyzsh/wiki/Themes) na wiki (Pracujemy nad aktualizacją!). Sprawdź je!

#### Wybór motywu

_Motyw Robby'ego jest domyślny. Nie jest najbardziej efektowny. Nie jest najprostszy. Jest po prostu odpowiedni (dla niego)._

Po znalezieniu motywu, który chcesz używać, musisz edytować plik `~/.zshrc`. Znajdziesz tam zmienną środowiskową (wielkimi literami), która wygląda tak:

```sh
ZSH_THEME="robbyrussell"
```

Aby użyć innego motywu, po prostu zmień wartość na nazwę wybranego motywu. Przykład:

```sh
ZSH_THEME="agnoster" # (to jeden z tych efektownych)
# zobacz https://github.com/ohmyzsh/ohmyzsh/wiki/Themes#agnoster
```

<!-- prettier-ignore-start -->
> [!NOTE]
> Często zobaczysz zrzuty ekranu motywu zsh, wypróbujesz go i okaże się, że nie wygląda u Ciebie tak samo.
>
> To dlatego, że wiele motywów wymaga zainstalowania [Powerline Font](https://github.com/powerline/fonts) lub [Nerd Font](https://github.com/ryanoasis/nerd-fonts), aby poprawnie się wyświetlać. Bez nich motywy wyświetlają dziwne symbole promptu. Zajrzyj do [FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#i-have-a-weird-character-in-my-prompt), aby dowiedzieć się więcej.
>
> Uwaga: motywy kontrolują tylko wygląd promptu, czyli tekstu przed lub po kursorze, gdzie wpisujesz polecenia. Motywy nie kontrolują kolorów okna terminala (tzw. _schemat kolorów_) ani czcionki terminala. Te ustawienia możesz zmienić w emulatorze terminala. Więcej informacji: [co to jest motyw zsh](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#what-is-a-zsh-theme).
<!-- prettier-ignore-end -->

Otwórz nowe okno terminala, a Twój prompt powinien wyglądać mniej więcej tak:

![Motyw Agnoster](https://cloud.githubusercontent.com/assets/2618447/6316862/70f58fb6-ba03-11e4-82c9-c083bf9a6574.png)

Jeśli nie znalazłeś odpowiedniego motywu, sprawdź wiki z [innymi motywami](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes).

Jeśli masz ochotę na trochę losowości, możesz pozwolić komputerowi wybierać motyw losowo przy każdym uruchomieniu terminala.

```sh
ZSH_THEME="random" # (...oby to był pie... oby był jakiś pie..)
```

A jeśli chcesz losować motyw spośród ulubionych:

```sh
ZSH_THEME_RANDOM_CANDIDATES=(
  "robbyrussell"
  "agnoster"
)
```

Jeśli wiesz tylko, których motywów nie lubisz, możesz dodać je do listy ignorowanych:

```sh
ZSH_THEME_RANDOM_IGNORED=(pygmalion tjkirch_mod)
```

### FAQ

Jeśli masz więcej pytań lub problemów, rozwiązanie możesz znaleźć w naszym [FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ).

## Zaawansowane tematy

Jeśli lubisz grzebać w szczegółach, te sekcje są dla Ciebie.

### Zaawansowana instalacja

Niektórzy użytkownicy mogą chcieć ręcznie zainstalować Oh My Zsh lub zmienić domyślną ścieżkę albo inne ustawienia akceptowane przez instalator (opisane również na początku skryptu instalacyjnego).

#### Własny katalog

Domyślna lokalizacja to `~/.oh-my-zsh` (ukryta w katalogu domowym, dostęp przez `cd ~/.oh-my-zsh`).

Aby zmienić katalog instalacji, ustaw zmienną środowiskową `ZSH` przed instalacją, np.:

```sh
ZSH="$HOME/.dotfiles/oh-my-zsh" sh install.sh
```

#### Instalacja bezobsługowa

Jeśli uruchamiasz instalator Oh My Zsh jako część zautomatyzowanej instalacji, możesz przekazać flagę `--unattended` do skryptu `install.sh`. Dzięki temu domyślna powłoka nie zostanie zmieniona, i nie zostanie uruchomiony `zsh` po zakończeniu instalacji.

```sh
sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)" "" --unattended
```

Jeśli jesteś w Chinach, Indiach lub innym kraju blokującym `raw.githubusercontent.com`, zamień adres na `https://install.ohmyz.sh`.

#### Instalacja z forka

Skrypt instalacyjny akceptuje poniższe zmienne, umożliwiając instalację z innego repozytorium:

- `REPO` (domyślnie: `ohmyzsh/ohmyzsh`): w formacie `owner/repository`. Instalator pobierze repozytorium z `https://github.com/{owner}/{repository}`.
- `REMOTE` (domyślnie: `https://github.com/${REPO}.git`): pełny URL do repozytorium git. Użyj tej opcji, jeśli chcesz zainstalować z forka spoza GitHub (GitLab, Bitbucket...) lub przez SSH (`git@github.com:user/project.git`).

  _UWAGA: nie jest kompatybilne z ustawieniem zmiennej `REPO`. Ta opcja ma wyższy priorytet._

- `BRANCH` (domyślnie: `master`): użyj, jeśli chcesz zmienić domyślną gałąź przy klonowaniu repozytorium. Może być przydatne do testowania Pull Requesta lub gdy chcesz użyć innej gałęzi niż `master`.

Przykład:

```sh
REPO=apjanke/oh-my-zsh BRANCH=edge sh install.sh
```

#### Instalacja ręczna

##### 1. Sklonuj repozytorium <!-- omit in toc -->

```sh
git clone https://github.com/ohmyzsh/ohmyzsh.git ~/.oh-my-zsh
```

##### 2. _Opcjonalnie_, zrób kopię zapasową istniejącego pliku `~/.zshrc` <!-- omit in toc -->

```sh
cp ~/.zshrc ~/.zshrc.orig
```

##### 3. Utwórz nowy plik konfiguracyjny zsh <!-- omit in toc -->

Możesz utworzyć nowy plik konfiguracyjny zsz, kopiując szablon, który przygotowaliśmy.

```sh
cp ~/.oh-my-zsh/templates/zshrc.zsh-template ~/.zshrc
```

##### 4. Zmień domyślną powłokę <!-- omit in toc -->

```sh
chsh -s $(which zsh)
```

Aby zobaczyć zmianę, musisz się wylogować i ponownie zalogować.

##### 5. Zainicjuj nową konfigurację zsh <!-- omit in toc -->

Po otwarciu nowego okna terminala powinien załadować się zsh z konfiguracją Oh My Zsh.

### Problemy z instalacją

Jeśli pojawią się problemy podczas instalacji, oto kilka typowych rozwiązań.

- Być może będziesz musiał zmodyfikować swoją zmienną `PATH` w `~/.zshrc`, jeśli po przejściu na oh-my-zsh nie znajdujesz pewnych poleceń.
- Jeśli instalowałeś ręcznie lub zmieniłeś ścieżkę instalacji, sprawdź zmienną środowiskową `ZSH` w `~/.zshrc`.

### Własne wtyczki i motywy

Aby nadpisać domyślne zachowania, dodaj nowy plik (kończący się na `.zsh`) w katalogu `custom/`.

Jeśli masz wiele funkcji, które dobrze ze sobą współpracują, umieść je w pliku `XYZ.plugin.zsh` w katalogu `custom/plugins/` i włącz tę wtyczkę.

Aby nadpisać funkcjonalność wtyczki dystrybuowanej z Oh My Zsh, utwórz wtyczkę o tej samej nazwie w `custom/plugins/`, a zostanie załadowana zamiast tej z `plugins/`.

### Włączenie GNU ls w systemach macOS i freeBSD

<a name="enable-gnu-ls"></a>

Domyślne zachowanie Oh My Zsh to używanie BSD `ls` na systemach macOS i FreeBSD. Jeśli zainstalowano GNU `ls` (jako polecenie `gls`), możesz wybrać jego użycie. W tym celu przed załadowaniem `oh-my-zsh.sh` ustaw:

```zsh
zstyle ':omz:lib:theme-and-appearance' gnu-ls yes
```

_Uwaga: nie jest kompatybilne z `DISABLE_LS_COLORS=true`_

### Pomijanie aliasów

<a name="remove-directories-aliases"></a>

Aby pominąć domyślne aliasy Oh My Zsh (zdefiniowane w plikach `lib/*`) lub aliasy wtyczek, możesz użyć poniższych ustawień w swoim pliku `~/.zshrc`, **przed załadowaniem Oh My Zsh**. Jest wiele sposobów pomijania aliasów, w zależności od potrzeb.

```sh
# Pomiń wszystkie aliasy, zarówno z plików lib, jak i włączonych wtyczek
zstyle ':omz:*' aliases no

# Pomiń wszystkie aliasy z plików lib
zstyle ':omz:lib:*' aliases no
# Pomiń tylko aliasy zdefiniowane w pliku lib directories.zsh
zstyle ':omz:lib:directories' aliases no

# Pomiń wszystkie aliasy wtyczek
zstyle ':omz:plugins:*' aliases no
# Pomiń tylko aliasy z wtyczki git
zstyle ':omz:plugins:git' aliases no
```

Możesz łączyć te ustawienia, pamiętając, że bardziej szczegółowy zakres ma priorytet:

```sh
# Pomiń wszystkie aliasy wtyczek, z wyjątkiem wtyczki git
zstyle ':omz:plugins:*' aliases no
zstyle ':omz:plugins:git' aliases yes
```

Poprzednia wersja tej funkcji używała poniższego ustawienia, które zostało usunięte:

```sh
zstyle ':omz:directories' aliases no
```

Zamiast tego użyj poniższego:

```sh
zstyle ':omz:lib:directories' aliases no
```

#### Uwaga <!-- omit in toc -->

> Ta funkcjonalność jest obecnie w fazie testów i może ulec zmianie w przyszłości. Nie jest też obecnie kompatybilna z menedżerami wtyczek takimi jak zpm czy zinit, które nie ładują skryptu inicjującego (`oh-my-zsh.sh`), gdzie ta funkcja jest zaimplementowana.

> Nie rozpoznaje także aliasów zdefiniowanych jako funkcje, np. `gccd`, `ggf`, czy `ggl` z wtyczki git.

### Asynchroniczny prompt git

Asynchroniczne funkcje prompt są funkcją eksperymentalną (dodane 3 kwietnia 2024), która pozwala Oh My Zsh renderować informacje o promptcie asynchronicznie. Może to poprawić wydajność renderowania promptu, ale może nie działać z niektórymi konfiguracjami. Jeśli pojawią się problemy z tą funkcją, możesz ją wyłączyć ustawiając przed załadowaniem Oh My Zsh w pliku .zshrc:

```sh
zstyle ':omz:alpha:lib:git' async-prompt no
```

Jeśli problem polega na tym, że prompt git przestał się pojawiać, spróbuj wymusić go ustawiając poniższą konfigurację przed załadowaniem `oh-my-zsh.sh`. Jeśli nadal nie działa, zgłoś problem z opisem swojego przypadku.

```sh
zstyle ':omz:alpha:lib:git' async-prompt force
```

## Aktualizacje

Domyślnie co 2 tygodnie zostaniesz zapytany o sprawdzenie aktualizacji. Możesz wybrać inny tryb aktualizacji, dodając linię do pliku `~/.zshrc` **przed załadowaniem Oh My Zsh**:

1. Automatyczna aktualizacja bez potwierdzenia:

   ```sh
   zstyle ':omz:update' mode auto
   ```

2. Przypomnienie co kilka dni, jeśli są dostępne aktualizacje:

   ```sh
   zstyle ':omz:update' mode reminder
   ```

3. Całkowite wyłączenie automatycznych aktualizacji:

   ```sh
   zstyle ':omz:update' mode disabled
   ```

UWAGA: możesz kontrolować, jak często Oh My Zsh sprawdza aktualizacje, tym ustawieniem:

```sh
# Sprawdza aktualizacje co 7 dni
zstyle ':omz:update' frequency 7
# Sprawdza aktualizacje przy każdym uruchomieniu terminala (niezalecane)
zstyle ':omz:update' frequency 0
```

### Szczegółowość aktualizacji

Możesz ograniczyć szczegółowość aktualizacji następującymi ustawieniami:

```sh
zstyle ':omz:update' verbose default # domyślny prompt aktualizacji

zstyle ':omz:update' verbose minimal # tylko kilka linii

zstyle ':omz:update' verbose silent # tylko błędy
```

### Ręczne aktualizacje

Jeśli chcesz zaktualizować ręcznie (np. ktoś właśnie wydał nową wtyczkę i nie chcesz czekać tydzień?), po prostu uruchom:

```sh
omz update
```

> [!NOTE]
> Jeśli chcesz zautomatyzować ten proces w skrypcie, wywołaj bezpośrednio skrypt `upgrade`, tak:
>
> ```sh
> $ZSH/tools/upgrade.sh
> ```
>
> Więcej opcji w [FAQ: Jak zaktualizować Oh My Zsh?](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#how-do-i-update-oh-my-zsh).
>
> **UŻYCIE `omz update --unattended` ZOSTAŁO USUNIĘTE, ZE WZGLĘDU NA SKUTKI UBOCZNE**.

Magia! 🎉

## Odinstalowywanie Oh My Zsh

Oh My Zsh nie jest dla każdego. Będzie nam Ciebie brakować, ale chcemy, by rozstanie było łatwe.

Aby odinstalować `oh-my-zsh`, po prostu uruchom `uninstall_oh_my_zsh` w terminalu. Usunie się sam i przywróci poprzednią konfigurację `bash` lub `zsh`.

## Jak mogę przyczynić się do Oh My Zsh?

Zanim dołączysz do naszej wspaniałej społeczności, przeczytaj [kodeks postępowania](CODE_OF_CONDUCT.md).

Nie jestem [Zsh](https://www.zsh.org/) ekspertem i podejrzewam, że jest wiele sposobów na ulepszenie – jeśli masz pomysły, jak uprościć lub przyspieszyć konfigurację, nie wahaj się zrobić forka i wysłać pull requesta!

Potrzebujemy też osób testujących pull requesty. Sprawdź [otwarte zgłoszenia](https://github.com/ohmyzsh/ohmyzsh/issues) i pomóż, gdzie możesz.

Więcej szczegółów w [Contributing](CONTRIBUTING.md).

### Nie wysyłaj nam motywów

Motywów mamy (więcej niż) wystarczająco. Dodaj swój motyw do strony wiki [external themes](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes).

## Współtwórcy

Oh My Zsh to żywa społeczność zadowolonych użytkowników i twórczych kontrybutorów. Bez ich czasu i pomocy projekt nie byłby tak świetny.

Dziękujemy!

<a href="https://github.com/ohmyzsh/ohmyzsh/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ohmyzsh/ohmyzsh" width="100%"/>
</a>

## Śledź nas

Jesteśmy w mediach społecznościowych:

- [@ohmyzsh](https://x.com/ohmyzsh) na X (dawniej Twitter). Warto śledzić.
- [Facebook](https://www.facebook.com/Oh-My-Zsh-296616263819290/) – zaczep nas.
- [Instagram](https://www.instagram.com/_ohmyzsh/) – oznacz nas na swoim zdjęciu z Oh My Zsh!
- [Discord](https://discord.gg/ohmyzsh) – pogadaj z nami!

## Gadżety

Mamy [naklejki, koszulki i kubki](https://shop.planetargon.com/collections/oh-my-zsh?utm_source=github), byś mógł pokazać swoją miłość do Oh My Zsh. Znów będziesz tematem rozmów w mieście!

## Licencja

Oh My Zsh jest wydany na licencji [MIT](LICENSE.txt).

## O Planet Argon

![Planet Argon](https://pa-github-assets.s3.amazonaws.com/PARGON_logo_digital_COL-small.jpg)

Oh My Zsh został stworzony przez zespół [Planet Argon](https://www.planetargon.com/?utm_source=github), [agencji programistycznej Ruby on Rails](https://www.planetargon.com/services/ruby-on-rails-development?utm_source=github). Zobacz nasze [inne projekty open source](https://www.planetargon.com/open-source?utm_source=github).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---