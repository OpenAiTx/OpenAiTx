
<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>


# 🎬 Narzędzie do masowego pobierania wideo yt-dlp (obsługa Windows / Linux)

> Jednoetapowy skrypt do pobierania wideo oparty na [yt-dlp](https://github.com/yt-dlp/yt-dlp), inspirowany [wpisem użytkownika NodeSeek](https://www.nodeseek.com/post-334093-2#15).
> Obsługuje pobieranie pojedynczych i wielu wideo, kompatybilny z Windows oraz głównymi dystrybucjami Linux (Debian / Ubuntu / Alpine / CentOS).

---

## ✨ Funkcje

* 📥 **Jedno kliknięcie uruchamia program**: Bez ręcznej konfiguracji, wystarczy podać dane według wskazówek, aby rozpocząć pobieranie
* 🍪 **Obsługa własnych ciasteczek Cookie**: Przydatne dla filmów wymagających logowania (⚠️ Funkcja nie została jeszcze zweryfikowana, mogą występować błędy)
* 📂 **Możliwość wyboru katalogu wyjściowego**: Łatwo zapisuj do wybranego folderu
* 📃 **Obsługa pobierania wsadowego**: Automatyczne czytanie linków z pliku `urls.txt` i pobieranie
* ⚙️ **Automatyczna instalacja zależności**: W środowisku Linux automatycznie instaluje `yt-dlp` i `ffmpeg`

---

## 🖼️ Podgląd ekranu

| Przykład 1                                                                   | Przykład 2                                                                   |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| ![Przykład 1](https://img.uutv.dpdns.org/file/1746720584399_1000193433.jpg) | ![Przykład 2](https://img.uutv.dpdns.org/file/1746720581006_1000193434.jpg) |
| ![Przykład 3](https://img.uutv.dpdns.org/file/1746720588978_1000193428.jpg) | ![Przykład 4](https://img.uutv.dpdns.org/file/1746720587272_1000193427.jpg) |

---

## 🪟 Instrukcja obsługi dla Windows

1. Pobierz następujące pliki:

   * [`yt-dlp.exe`](https://github.com/yt-dlp/yt-dlp)
   * [`ffmpeg` wersja na Windows](https://www.gyan.dev/ffmpeg/builds/ffmpeg-git-full.7z)

2. Po rozpakowaniu umieść następujące pliki w tym samym folderze (np. w folderze `yt-dlp`):

   * `yt-dlp.exe`
   * `ffmpeg.exe`
   * `ffprobe.exe`
   * `yt-dlp.bat` (plik skryptu)

3. Kliknij dwukrotnie `yt-dlp.bat`, postępuj zgodnie z instrukcjami, aby pobrać wideo.
4. Edytuj config/config.ini, aby zmienić ustawienia domyślne

---

## 🐧 Instrukcja obsługi dla Linux (Skrypt najnowszej wersji od technologicznego lion-a także zawiera te same funkcje)

**Systemy obsługiwane**: Debian / Ubuntu / Alpine / CentOS

Jedno kliknięcie do wdrożenia, aktualizacji i uruchomienia:

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/install.sh)"
```

Aby odinstalować:

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/uninstall.sh)"
```

---

## 📱 Rekomendacje dla użytkowników Androida

1. Skorzystaj z aplikacji [Seal](https://github.com/JunkFood02/Seal), aby korzystać z funkcji `yt-dlp` na Androidzie.
2. Instalacja Debiana przez termux również umożliwia pobieranie, ale nie ma takiej potrzeby, Seal jest bardzo wygodny.

---

## ⚠️ Uwagi

1. **Tryb pobierania wsadowego**: Skrypt automatycznie odczyta plik `config\urls.txt` w bieżącym katalogu, jeden link do wideo na linię. Jeśli plik nie istnieje, zostanie automatycznie utworzony.
2. **Wskazówka dotycząca zasobów**: Na urządzeniach z małą ilością pamięci RAM nie zaleca się pobierania wielu dużych filmów jednocześnie ani ustawiania zbyt dużej liczby wątków równoległych.
3. **Szczególna uwaga dla CentOS**: Ze względu na specyfikę środowiska nie został jeszcze w pełni przetestowany, zaleca się używanie w środowiskach nieprodukcyjnych. Pozostałe popularne systemy zostały przetestowane i działają poprawnie.
4. Mały bug w wersji Linux: Skrypt po wejściu na stronę główną sprawdza zależności, kierując się zasadą "działa, to nie ruszaj", nie chciało mi się poprawiać.
5. Mały bug w wersji Windows: Po powrocie z innych stron na stronę główną i ponownym wyborze opcja domyślna może nie działać, przez co następuje zapętlenie; nie udało się tego naprawić.
Dwa rozwiązania:
    1. Wyjdź i uruchom ponownie
    2. Nie wybieraj domyślnej opcji, tylko wybierz numer

---

## 📄 Licencja

Projekt jest objęty licencją [MIT License](https://opensource.org/licenses/MIT).

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-08

---