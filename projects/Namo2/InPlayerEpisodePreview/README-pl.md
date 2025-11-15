<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <p>Poniższe tłumaczenia zostały wygenerowane automatycznie przez AI. Proszę pamiętać, że mogą zawierać niedokładności lub odnosić się do starszych wersji tego pliku readme.</p>
        <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Namo2&project=InPlayerEpisodePreview&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

Podgląd Odcinków w Odtwarzaczu
====================
## 📄 O projekcie
Ten plugin dodaje listę odcinków do odtwarzacza wideo, co pozwala na podgląd każdego odcinka serialu bez opuszczania odtwarzacza.

Ta modyfikacja wspiera następujących klientów:
* [Jellyfin Web Client](https://github.com/jellyfin/jellyfin-web)
* [Jellyfin Media Player](https://github.com/jellyfin/jellyfin-media-player) (JMP) Klient Desktopowy

## ✨ Funkcje
* Wyświetlanie wszystkich odcinków sezonu
* Przełączanie między sezonami
* Pokazuje tytuł odcinka, opis, miniaturę i postęp odtwarzania
* Pokazuje szczegóły odcinka, takie jak ocena społeczności
* Oznaczanie odcinków jako obejrzane lub ulubione
* Rozpoczęcie nowego odcinka
* Powinno działać z niestandardowymi motywami

## 📸 Podgląd
<img src="https://github.com/Namo2/InPlayerEpisodePreview/blob/master/Images/preview.gif" width="550" height="450">

Użyty motyw: (SkinManager) Kaleidochromic
<br>
Ten podgląd nie zawiera nowych przycisków do oznaczania odcinka jako ukończonego lub ulubionego.

## 🔧 Instalacja

### Jellyfin Web Client (Serwer)

> [!UWAGA]
> Zaleca się zainstalowanie [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation) w wersji co najmniej v2.2.1.0. Pomaga to uniknąć problemów z uprawnieniami podczas modyfikowania pliku index.html przy dowolnej instalacji!
<details open>
<summary> Zobacz instrukcje... </summary>

1. Dodaj manifest `https://raw.githubusercontent.com/Namo2/InPlayerEpisodePreview/master/manifest.json` jako repozytorium wtyczek Jellyfin do swojego serwera.
2. Zainstaluj wtyczkę `InPlayerEpisodePreview` z repozytorium.
3. Uruchom ponownie serwer Jellyfin.
</details>

### Jellyfin Media Player (JMP) Klient Desktopowy (Przestarzały)
<details>
<summary> Zobacz instrukcje... </summary>

**Przestarzałe wraz z wersją JMP [1.11.0](https://github.com/jellyfin/jellyfin-media-player/releases/tag/v1.11.0)**

Ponieważ nowy klient JMP używa obecnego odtwarzacza internetowego z samego serwera, nie jest już konieczna bezpośrednia modyfikacja kodu klienta.

To zalecany sposób instalacji skryptu na kliencie desktopowym.
Jeśli nie czujesz się komfortowo z samodzielną edycją pliku nativeshell.js (kroki od 3 do 6), możesz zamiast tego pobrać pełną wersję, która zawiera już dodany skrypt w pliku nativeshell.js.
Nie jest jeszcze jasne, czy mogą wystąpić potencjalne problemy przy zastępowaniu pliku nativeshell.js tym z wydania, dlatego zaleca się wykonanie wszystkich poniższych kroków.

1. Pobierz najnowszą wersję [JMP](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp.zip) lub [JMP-full](https://github.com/Namo2/InPlayerEpisodePreview/releases/download/v1.1.0.0/inPlayerEpisodePreview-1.1.0.0-jmp-full.zip) (zawiera już skrypt dodany do pliku nativeshell.js)
2. Wypakuj plik zip do katalogu Jellyfin (np. C:\Program Files\Jellyfin\Jellyfin Media Player)
3. W katalogu Jellyfin przejdź do folderu "web-client\extension"
4. Otwórz plik "nativeshell.js" w edytorze tekstu.
5. Wewnątrz pliku znajdź sekcję `const plugins = [];`. Dodaj nową linię na początku listy i wklej `'inPlayerEpisodePreviewPlugin',`. Sekcja powinna teraz wyglądać podobnie do tego:
```javascript
const plugins = [
    'inPlayerEpisodePreviewPlugin',
    'mpvVideoPlayer',
    'mpvAudioPlayer',
    'jmpInputPlugin',
    'jmpUpdatePlugin',
    'jellyscrubPlugin',
    'skipIntroPlugin'
];
```
6. Zapisz plik i zrestartuj klienta JMP.
</details>

## 💡 Rozwiązywanie problemów

### 1. Przycisk podglądu nie jest widoczny
Najprawdopodobniej jest to związane z nieprawidłowymi uprawnieniami do pliku `index.html`.

<details>
<summary> Zobacz listę możliwych rozwiązań... </summary>

#### 1.1 Uniknij tego problemu, korzystając z wtyczki [file-transformation](https://github.com/IAmParadox27/jellyfin-plugin-file-transformation).

#### 1.2 Zmień właściciela wewnątrz kontenera docker
Jeśli uruchamiasz jellyfin w kontenerze docker, możesz zmienić właściciela za pomocą poniższego polecenia
(zastąp jellyfin nazwą swojego kontenera, user i group użytkownikiem i grupą twojego kontenera):
```
docker exec -it --user root jellyfin chown user:group /jellyfin/jellyfin-web/index.html && docker restart jellyfin
```
Możesz uruchomić to jako zadanie cron podczas uruchamiania systemu.
(Dziękuję [muisje](https://github.com/muisje) za pomoc przy [tym](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issue-2825745530) rozwiązaniu)

#### 1.3 Zmiana właściciela na instalacji Windows
1. Przejdź do: `C:\Program Files\Jellyfin\Server\jellyfin-web\`
2. Kliknij prawym przyciskiem na `index.html` → `Właściwości` → zakładka `Zabezpieczenia` → Kliknij `Edytuj`
3. Wybierz swojego użytkownika z listy i zaznacz pole uprawnień `Zapis`.
4. Uruchom ponownie zarówno serwer, jak i klienta.
   (Dziękuję [xeuc](https://github.com/xeuc) za [to](https://github.com/Namo2/InPlayerEpisodePreview/issues/49#issuecomment-2746136069) rozwiązanie)

Jeśli żadna z powyższych metod nie działa, sprawdź wcześniejsze zgłoszenia. Np. [tutaj](https://github.com/Namo2/InPlayerEpisodePreview/issues/10) lub [tutaj](https://github.com/Namo2/InPlayerEpisodePreview/issues/49).
</details>

<br/>
<br/>
Jeśli napotkasz błąd, którego nie możesz samodzielnie rozwiązać, śmiało otwórz nowe zgłoszenie.
<br/>Pamiętaj, że każdy system jest inny, co może prowadzić do nieoczekiwanego zachowania, więc podaj jak najwięcej informacji.
<br/>Logi Jellyfin oraz logi konsoli z przeglądarki (z prefiksem [InPlayerEpisodePreview]) są zawsze pomocne.

## Podziękowania
Struktura wtyczki została oparta i zainspirowana przez wtyczkę [Jellyscrub](https://github.com/nicknsy/jellyscrub) autorstwa [NickNSY](https://github.com/nicknsy).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---