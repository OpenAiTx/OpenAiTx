
<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Rosetta Stonks

- [Wprowadzenie](#introduction)
- [Instalacja](#install)
  - [Chrome](#chrome-based-browsers)
    - [Przewodnik wizualny](#chrome-based-browsers)
  - [Firefox](#firefox-based-browsers)
- [Jak używać](#how-to-use)
  - [Dodawanie czasu](#dodawanie-czasu)
    - [Podstawy](#dodawanie-czasu-w-podstawach)
    - [Budowanie płynności](#dodawanie-czasu-w-budowaniu-płynności)
  - [Weryfikacja lekcji](#weryfikacja-lekcji)
    - [Podstawy](#weryfikacja-lekcji-w-podstawach)
    - [Budowanie płynności](#weryfikacja-lekcji-w-budowaniu-płynności)

## Wprowadzenie

RosettaStonks to rozszerzenie przeglądarki umożliwiające dodawanie czasu i weryfikowanie
lekcji na platformie nauki języków Rosetta Stone.

> RosettaStonks, a Twój rosetta stone idzie w górę.

## Instalacja

### Przeglądarki oparte na Chrome

➡️ **Nowy w ręcznym instalowaniu rozszerzeń Chrome?** Zobacz [Przewodnik krok po kroku ze zdjęciami](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md) — zawiera pomocne zrzuty ekranu! 🖼️

#### 1. Korzystanie z wersji GitHub Release

Aby użyć rozszerzenia w przeglądarce opartej na Chrome, należy:

- pobrać plik `rosettastonks-chrome.tar.gz` z najnowszego wydania na
  swój komputer.
- utworzyć folder o nazwie `rosettastonks` w dowolnym miejscu na komputerze, aby przechowywać
  rozszerzenie
- uruchomić następujące polecenie w folderze `rosettastonks`.

```bash
$ tar xvzf /path/to/rosettastonks-chrome.tar.gz
```

2. Używanie menedżera pakietów nix

Zamiast poprzednich poleceń, jeśli korzystasz z systemu nix **obsługującego
flakes**, możesz wykonać poniższe polecenia, które zainstalują folder
pod ścieżką `/tmp/rosettastonks` ze wszystkimi plikami.

```bash
$ nix build --out-link "/tmp/rosettastonks" github:m1dugh/RosettaStonks#chrome
```

Folder został teraz zainstalowany w `/tmp/rosettastonks/`

**Ta część dotyczy wszystkich użytkowników, niezależnie od tego, czy korzystasz z metody github,
czy metody nix.**

W swojej przeglądarce:

- przejdź do `chrome://extensions`
- zaznacz przełącznik `Tryb deweloperski`
- kliknij `Wczytaj rozpakowane`
- wybierz swój folder `rosettastonks`

### Przeglądarki oparte na Firefox

- pobierz plik `rosettastonks.xpi` z najnowszego wydania.
- alternatywnie, jeśli używasz menedżera pakietów nix z obsługą flake, możesz uruchomić
  następujące polecenie.

```bash
$ nix build --out-link "/tmp/rosettatonks.xpi" github:m1dugh/RosettaStonks#mozilla
```
- przejdź do `about:debugging#/runtime/this-firefox` w swojej przeglądarce
- kliknij przycisk ustawień i przejdź do `Debuguj dodatki`.
- kliknij `Załaduj tymczasowy dodatek`
- wybierz plik `/tmp/rosettastonks.xpi` w oknie wyboru pliku.

_Uwaga: Ta metoda instaluje rozszerzenie tylko tymczasowo, co oznacza, że jeśli
zamkniesz przeglądarkę, dodatek zostanie odinstalowany. Wynika to z polityki
firefoxa, która nie pozwala na używanie niezweryfikowanych rozszerzeń._

## Jak używać

### Dodawanie czasu

#### Dodawanie czasu w Foundations

Aby dodać czas na produkcie `foundations`, należy przejść do swoich ćwiczeń i
kliknąć ignoruj lub rozwiąż przynajmniej jedno pytanie. Gdy to zostanie zrobione, pole czasu
powinno pojawić się na stronie rozszerzenia, gdzie można dodać swój czas.

#### Dodawanie czasu w Fluency builder

Aby dodać czas na produkcie `fluency builder`, należy przejść do swoich ćwiczeń i
rozwiązać przynajmniej jedno ćwiczenie. Jeśli pole dodawania czasu się nie pojawi, oznacza to,
że nie wychwycono żadnej prośby o czas, należy odświeżyć pytanie i odpowiedzieć na nie
jeszcze raz. Aby czas został dodany, trzeba ukończyć lekcję, w której użyto dodawania czasu.

_Uwaga: Jeśli nie widzisz pola dodawania czasu, oznacza to, że działania podjęte
na stronie Rosetta Stone nie prowadziły do dodania prawidłowego czasu, więc
musisz odpowiedzieć na inne pytania._

### Walidacja lekcji

#### Walidacja lekcji w Foundations

Aby zwalidować lekcję, należy rozpocząć lekcję i przejść przez wszystkie
pytania za pomocą przycisku `ignoruj` w prawym dolnym rogu. Gdy wszystkie
pytania zostaną obejrzane, kliknięcie przycisku `zwaliduj lekcję` powinno zwalidować
lekcję. Jeśli nie, wróć do strony głównej, kliknij tę samą lekcję, ona


powinien zapytać `Czy chcesz kontynuować czy zresetować?`, możesz wybrać obie opcje i
zweryfikować lekcję ponownie, aż zadziała. Powinno działać po maksymalnie 3/4 próbach.

#### Walidacja lekcji w Fluency builder

Obecnie funkcja walidacji lekcji nie jest dostępna w rosetta stonks.

## Budowanie aplikacji

### Budowanie workera

Worker może być spakowany za pomocą następującego polecenia

```
$ deno task build:worker
```

Który tworzy spakowany plik `/dist/worker.esm.js`, będący spakowanym
plikiem dla workera.

### Budowanie interfejsu frontend

Worker może zostać spakowany za pomocą następującego polecenia

```
$ deno task build:frontend
```

Który tworzy spakowany plik `/dist/frontend.esm.js`, będący plikiem pakietu
dla frontend-u.

## Pakietowanie rozszerzenia

### Chrome

Aby spakować rozszerzenie dla Chrome, można uruchomić następujące polecenie:

```
$ make chrome
```

### Firefox

Aby spakować rozszerzenie dla Firefoxa, można uruchomić następujące polecenie:

```
$ make firefox
```

Które wygeneruje plik `rosettastonks.xpi`, czyli plik rozszerzenia, który można
załadować w przeglądarce Firefox.

📸 Wolisz obrazy? Zobacz [Przewodnik instalacji Chrome ze zdjęciami](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-14

---