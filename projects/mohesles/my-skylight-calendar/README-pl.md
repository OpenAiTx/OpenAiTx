
<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Rodzinny Kalendarz Smart Home DIY (Kopia Skylight)

![Kalendarz Sklylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/main_view.jpeg)
![DIY Skylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/sky2.png)

## 📖 Wprowadzenie

Moja żona ostatnio była zasypywana w mediach społecznościowych reklamami inteligentnych kalendarzy domowych (Skylight, Cozyla, Hearth) i była gotowa wydać ponad 300 dolarów na jeden z nich. Zanim dałem jej zielone światło, poprosiłem o szansę, by je zbadać.
Zdałem sobie sprawę, że większość oferowanych urządzeń miała podobną funkcjonalność, ale znacząco różniła się ceną. Co najważniejsze, nie zauważyłem żadnej wyjątkowej funkcji, której nie mógłbym zaimplementować w **Home Assistant**.

**Cel:** Urządzenie z aprobatą WAF (Wife Acceptance Factor), przyjazny dla blatu ekran dotykowy z kalendarzem, głęboko zintegrowany z naszym inteligentnym domem, bez miesięcznych opłat.

## 💡 Dlaczego DIY?

Wybór rozwiązania DIY z Home Assistant przyniósł kilka korzyści w porównaniu do kupna wyświetlacza Skylight/Hearth:

* **Brak miesięcznych opłat:** Unikasz subskrypcji za „premium” funkcje.
* **Płynna integracja:** Komunikuje się z naszymi światłami, zadaniami (Grocy) i czujnikami obecności.
* **Stary sprzęt:** Przeznaczyłem ponownie Mini PC oraz standardowy monitor.
* **Prywatność:** Brak uzależnienia od dostawcy i ryzyka zamknięcia firmy.

## 🛠 Wybór sprzętu

Obecnie system jest zbudowany tak, by wyświetlać pulpit na dowolnym ekranie HD (1920x1080).

W moim przypadku wymogiem było, by „wyglądało jak” skylight, było dotykowe, stawiane na blacie, z możliwością przenoszenia w różne miejsca. Dlatego wybrałem sprzęt opisany poniżej.
Jednak Twój przypadek może być inny i wymagać dostosowania, np. jeśli chcesz wyświetlać to na tablecie lub innym urządzeniu.

Sprzęt, którego pierwotnie użyłem, wybrałem w oparciu o powyższe kryteria oraz z nadzieją na rozszerzenie funkcjonalności przy użyciu kamery, głośnika i mikrofonu. Obecnie z perspektywy czasu zbudowałbym to inaczej, ponieważ nie miałem czasu na realizację tych dodatkowych pomysłów.

* **Monitor:** [HP Engage 15-calowy ekran dotykowy](https://computers.woot.com/offers/hp-engage-16t-fhd-monitor). Wybrałem go zamiast typowych monitorów przenośnych, ponieważ ma wbudowane **głośnik, kamerę i mikrofon**, co pozwala na przyszłe sterowanie głosem lub rozmowy wideo.
* **Komputer:** Stary Mini PC (NUC/Tiny PC) z Windows/Linux w trybie Kiosk, lub Raspberry Pi 4.~~

## ✨ Funkcje

* **Widok rodzinny i indywidualny:** Przełączanie kalendarzy poszczególnych członków rodziny.
* **Dwukierunkowa synchronizacja:** Edytuj wydarzenia na ekranie lub na telefonach (Google Calendar).
* **Popup „Dodaj wydarzenie”:** Niestandardowy interfejs do dodawania wydarzeń bezpośrednio do wybranych kalendarzy z ekranu.
* **Pogoda i data:** Piękny, czytelny nagłówek.
* **Responsywność:** Automatyczne dostosowanie liczby dni do szerokości ekranu (Mobile vs Desktop).

---

## ⚙️ Przewodnik instalacji

*Uwaga: Ta konfiguracja używa **pakietu YAML**, który automatycznie utworzy wszystkie potrzebne pomocniki, skrypty i zmienne. Nie musisz ich tworzyć ręcznie.*



### 1. Wymagania wstępne (HACS)

Musisz mieć zainstalowany [HACS](https://hacs.xyz/). Proszę zainstalować następujące integracje **Frontend**:

* `week-planner-card`
* `bubble-card`
* `config-template-card`
* `card-mod`
* `better-moment-card`
* `weather-card`
* `browser_mod` (Wymagane do działania wyskakujących okienek)
* `layout-card` (Wymagane dla widoku Sekcji)
* `button-card` (Wymagane do wyskakującego okna dodawania wydarzenia)

### 2. Backend (Mózg systemu)

1. Otwórz plik `configuration.yaml` w Home Assistant.
2. Upewnij się, że masz dodaną tę linię pod `homeassistant:`, aby włączyć pakiety:

   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```
3. Utwórz folder o nazwie `packages` w katalogu konfiguracyjnym HA (jeśli jeszcze go nie masz).
4. Pobierz plik [packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml) z tego repozytorium.
5. Umieść plik w folderze `packages/`.
6. **Zrestartuj Home Assistant**.

### 3. Kalendarze

Możesz użyć **Kalendarzy Google** lub **Kalendarzy Lokalnych**.

#### Opcja A: Kalendarz Lokalny (Najłatwiejsze)

Uwaga: Nieprzetestowane, ponieważ używam wyłącznie Kalendarzy Google

1. Przejdź do **Ustawienia > Urządzenia i Usługi**.
2. Dodaj integrację **Kalendarz Lokalny**.
3. Utwórz kalendarze o dokładnych nazwach: `Alice`, `Bob`, `Charlie`, `Daisy`, `Family`.
    * *Jeśli użyjesz tych nazw, kod działa od razu!*

#### Opcja B: Kalendarz Google

1. Otwórz plik `packages/family_calendar.yaml`.
2. Przewiń do skryptu `add_google_calendar_event`.
3. Zaktualizuj `calendar_map`, aby wskazywał na Twoje rzeczywiste encje Google:


    ```yaml
    calendar_map:
      "Alice": "calendar.alice_gmail_com"
      "Bob": "calendar.bob_work_account"
    ```

#### Ustawianie Świąt

Od aktualizacji Home Assistant, święta dodaje się teraz przez interfejs użytkownika:

1. Przejdź do **Ustawienia > Urządzenia i Usługi > Dodaj Integrację > Holiday**.
2. Wybierz swój kraj.
3. Sprawdź identyfikator encji (np. `calendar.holidays`). Jeśli różni się od domyślnego, zaktualizuj go w dashboard YAML.

### 4. Dashboard (Wygląd)

1. Utwórz nowy Widok Dashboardu (Ustaw Typ Widoku na **Sekcje**).
2. Skopiuj kod z [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml).
3. **Dostosuj:**
   * **Znajdź i Zamień:** Zamień `person.alice` na rzeczywiste encje członków rodziny.
   * **Pogoda:** Zamień `weather.home` na dostawcę pogody.
   * **Tło:** Zaktualizuj adres URL obrazu na dole pliku yaml.

### Krok 5: Motyw (Opcjonalnie)

Aby uzyskać specyficzny wygląd czcionki (Ovo):

1. Upewnij się, że w pliku `configuration.yaml` znajduje się ta linia pod `frontend:`

   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```
2. Utwórz folder o nazwie `themes` w swoim katalogu konfiguracyjnym.
3. Pobierz [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml) i umieść go w tym folderze.
4. Zrestartuj Home Assistant.
5. Przejdź do swojego Profilu (ikona użytkownika w lewym dolnym rogu) i zmień **Motyw** na `Skylight`.
UWAGA: Motyw nie jest kompleksowy, miej to na uwadze

---

## 📐 Jak to działa (Pod maską)

### Logika filtrowania

`week-planner-card` nie obsługuje natywnie ukrywania konkretnych kalendarzy w locie. Aby to obejść, użyłem **Tekstów wejściowych** działających jako filtry Regex.

* Gdy klikniesz przycisk osoby, przełącza on jej filtr między `.*` (Pokaż wszystko) a `^$` (Nie pokazuj nic).
* `config-template-card` dynamicznie wstrzykuje te zmienne do karty kalendarza.

### Skrypt tworzenia wydarzenia

Popup "Dodaj wydarzenie" wykorzystuje jeden skrypt obsługujący logikę dla wielu osób i typów wydarzeń (całodniowe vs z określonym czasem).


```yaml
# Simplified Logic Example
target_calendar: "{{ calendar_map.get(states('input_select.calendar_select')) }}"

choose:
  - conditions: "All Day Event is ON"
    action: calendar.create_event (start_date, end_date)
  - conditions: "All Day Event is OFF"
    action: calendar.create_event (start_date_time, end_date_time)
```

## UWAGI

Mój oryginalny post miał na celu jedynie przedstawienie ogólnego zarysu jak to zrobić oraz umożliwienie użytkownikom dostosowania kodu do własnych, specyficznych scenariuszy.

Zrobiłem to w szczególności dlatego, że każdy wyświetlacz i potrzeba są inne. Nie mogę opracować rozwiązania dla wszystkich możliwych rozmiarów wyświetlaczy, pulpitów itp. Zostało to więc zbudowane tak, aby działało na wyświetlaczu, o którym wspomniałem, lub dowolnym innym (1920x1080), ale powinno być edytowalne dla pozostałych.

Jeśli chodzi o wyświetlacz, pierwotnie zaproponowałem właśnie ten, ponieważ był w promocji na Woot i był bardzo ekonomicznym sposobem na zdobycie ekranu dotykowego w tamtym czasie. Teraz może to już nie być aktualne, więc użyj dowolnego wyświetlacza, który Ci odpowiada. Tablet, ekran dotykowy, telefon, cokolwiek. Główną rzeczą, którą będziesz musiał edytować, jest dashboard.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-14

---