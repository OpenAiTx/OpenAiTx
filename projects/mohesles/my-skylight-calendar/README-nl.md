
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
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

# Doe-het-zelf Slimme Familie Kalender (Skylight Clone)

![Sklylight kalender](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/main_view.jpeg)
![DIY Skylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/sky2.png)

## 📖 Inleiding

Mijn vrouw werd de laatste tijd op sociale media overspoeld met advertenties voor slimme huis kalenders (Skylight, Cozyla, Hearth) en stond op het punt er meer dan $300 aan uit te geven. Voordat ik haar toestemming gaf, vroeg ik om de kans om ze te onderzoeken.

Ik realiseerde me dat de meeste vergelijkbare functionaliteit boden, maar aanzienlijk in prijs verschilden. Het belangrijkste: ik zag geen enkele opvallende functie die ik niet in **Home Assistant** kon implementeren.

**Het Doel:** Een WAF-goedgekeurde (Wife Acceptance Factor), aanrechtvriendelijke touchscreenkalender die diep integreert in ons slimme huis zonder maandelijkse kosten.

## 💡 Waarom DIY?

Kiezen voor de DIY-route met Home Assistant bood verschillende voordelen ten opzichte van het kopen van een Skylight/Hearth-display:

* **Geen maandelijkse kosten:** Voorkomt abonnementen voor "premium" functies.
* **Naadloze integratie:** Communiceert met onze verlichting, takenlijst (Grocy) en aanwezigheidssensoren.
* **Oude hardware:** Een Mini PC en een standaardmonitor hergebruikt.
* **Privacy:** Geen vendor lock-in of risico dat het bedrijf ermee stopt.

## 🛠 Hardwarekeuze

Dit is momenteel gebouwd om het dashboard weer te geven op elk HD (1920x1080) scherm.

In mijn geval was de eis dat het moest "lijken op" skylight, touchscreen zijn, op het aanrecht staan en de mogelijkheid hebben om het te verplaatsen naar verschillende locaties. Daarom koos ik voor de hieronder beschreven hardware.
Jouw situatie kan echter anders zijn en vereist mogelijk aanpassingen, bijvoorbeeld als je het op een tablet of iets anders wilt weergeven.

De hardware die ik oorspronkelijk gebruikte, koos ik op basis van bovengenoemde punten en met de hoop om in de toekomst functionaliteit uit te breiden met de webcam, speaker en microfoon. Met de kennis van nu zou ik het waarschijnlijk anders bouwen, omdat ik geen tijd heb gehad om deze extra hardware ideeën uit te werken.

* **Monitor:** [HP Engage 15-inch Touchscreen](https://computers.woot.com/offers/hp-engage-16t-fhd-monitor). Ik koos deze boven generieke draagbare monitoren omdat hij een ingebouwde **Speaker, Webcam en Microfoon** heeft, wat toekomstige spraakbesturing of videogesprekken mogelijk maakt.
* **Computer:** Een oude Mini PC (NUC/Tiny PC) met Windows/Linux in Kioskmodus, of een Raspberry Pi 4.~~

## ✨ Functies

* **Gezinsbreed & individuele weergaven:** Wissel per gezinslid kalenders aan/uit.
* **Tweerichtingssync:** Bewerk afspraken op het scherm of op onze telefoons (Google Calendar).
* **"Evenement toevoegen" Popup:** Een aangepaste UI om direct vanaf het scherm afspraken toe te voegen aan specifieke kalenders.
* **Weer & Datum:** Mooie, in één oogopslag te zien header.
* **Responsief:** Past automatisch het aantal dagen aan op basis van schermbreedte (Mobiel vs Desktop).

---

## ⚙️ Installatiehandleiding

*Opmerking: Deze setup gebruikt een **YAML Package** om automatisch alle benodigde helpers, scripts en variabelen voor je aan te maken. Je hoeft deze niet handmatig te creëren.*


### 1. Vereisten (HACS)

Je moet [HACS](https://hacs.xyz/) geïnstalleerd hebben. Installeer de volgende **Frontend** integraties:

* `week-planner-card`
* `bubble-card`
* `config-template-card`
* `card-mod`
* `better-moment-card`
* `weather-card`
* `browser_mod` (Vereist voor het functioneren van pop-ups)
* `layout-card` (Vereist voor de sectieweergave)
* `button-card` (Vereist voor de pop-up om een evenement toe te voegen)

### 2. De Backend (Het Brein)

1. Open je `configuration.yaml` bestand in Home Assistant.
2. Zorg ervoor dat je deze regel hebt toegevoegd onder `homeassistant:` om pakketten in te schakelen:

   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```
3. Maak een map genaamd `packages` aan in je HA-configuratiemap (als je die nog niet hebt).
4. Download [packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml) van deze repository.
5. Plaats het bestand in je `packages/` map.
6. **Herstart Home Assistant**.

### 3. De Kalenders

Je kunt **Google Kalenders** of **Lokale Kalenders** gebruiken.

#### Optie A: Lokale Kalender (Meest eenvoudig)

Let op: dit is niet getest, aangezien ik uitsluitend Google Kalenders gebruik

1. Ga naar **Instellingen > Apparaten & Diensten**.
2. Voeg de **Lokale Kalender** integratie toe.
3. Maak kalenders aan met exact de volgende namen: `Alice`, `Bob`, `Charlie`, `Daisy`, `Family`.
    * *Als je deze namen gebruikt, werkt de code direct uit de doos!*

#### Optie B: Google Kalender

1. Open `packages/family_calendar.yaml`.
2. Scroll naar het script `add_google_calendar_event`.
3. Werk de `calendar_map` bij zodat deze naar je echte Google-entiteiten verwijst:


    ```yaml
    calendar_map:
      "Alice": "calendar.alice_gmail_com"
      "Bob": "calendar.bob_work_account"
    ```

#### Feestdagen instellen

Sinds de updates van Home Assistant worden feestdagen nu via de UI toegevoegd:

1. Ga naar **Instellingen > Apparaten & Diensten > Integratie toevoegen > Holiday**.
2. Selecteer je land.
3. Controleer de entity-ID (bijv. `calendar.holidays`). Als deze afwijkt van de standaard, werk deze dan bij in de dashboard YAML.

### 4. Het Dashboard (Het Uiterlijk)

1. Maak een nieuw Dashboard View aan (Stel View Type in op **Secties**).
2. Kopieer de code uit [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml).
3. **Aanpassen:**
   * **Zoek & Vervang:** Vervang `person.alice` door je daadwerkelijke gezinsleden.
   * **Weer:** Vervang `weather.home` door je eigen weerprovider.
   * **Achtergrond:** Werk de afbeeldings-URL onderaan de yaml bij.

### Stap 5: Het Thema (Optioneel)

Om het specifieke lettertype (Ovo) te krijgen:

1. Zorg dat je `configuration.yaml` deze regel bevat onder `frontend:`

   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```
2. Maak een map genaamd `themes` in je configuratiemap.
3. Download [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml) en plaats deze in die map.
4. Herstart Home Assistant.
5. Ga naar je Profiel (Gebruikersicoon linksonder) en verander **Thema** naar `Skylight`.
OPMERKING: Het thema is niet allesomvattend, houd daar rekening mee

---

## 📐 Hoe het werkt (onder de motorkap)

### Filterlogica

De `week-planner-card` ondersteunt niet standaard het verbergen van specifieke agenda's op aanvraag. Om dit op te lossen heb ik **Input Texts** gebruikt die functioneren als Regex-filters.

* Wanneer je op de knop van een persoon klikt, schakelt deze hun filter tussen `.*` (Alles tonen) en `^$` (Niets tonen).
* `config-template-card` injecteert deze variabelen dynamisch in de kalenderkaart.

### Script voor het aanmaken van gebeurtenissen

De "Gebeurtenis toevoegen" popup gebruikt één script dat de logica afhandelt voor meerdere personen en gebeurtenistypes (Hele dag versus met tijd).


```yaml
# Simplified Logic Example
target_calendar: "{{ calendar_map.get(states('input_select.calendar_select')) }}"

choose:
  - conditions: "All Day Event is ON"
    action: calendar.create_event (start_date, end_date)
  - conditions: "All Day Event is OFF"
    action: calendar.create_event (start_date_time, end_date_time)
```

## OPMERKINGEN

Mijn oorspronkelijke bericht was bedoeld om een globaal overzicht te geven van hoe je dit kunt doen en mensen in staat te stellen de code aan te passen aan hun specifieke scenario.

Ik heb dit met name gedaan omdat elk scherm en elke behoefte anders is. Ik kan niet voor alle mogelijke schermgroottes, dashboards, enz. ontwikkelen. Het is dus gebouwd om te werken met het scherm dat ik noemde of elk ander (1920x1080), maar zou aanpasbaar moeten zijn voor andere.

Over het scherm gesproken, ik stelde oorspronkelijk dat scherm voor omdat het in de aanbieding was bij Woot en destijds een zeer voordelige manier was om een touchscreen-display te krijgen. Dit is nu misschien niet meer het geval, dus gebruik het scherm dat voor jou werkt. Tablet, touchscreen, telefoon, wat dan ook. Het belangrijkste dat je zult moeten aanpassen is het dashboard.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-14

---