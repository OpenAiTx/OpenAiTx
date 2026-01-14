
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ja">Japanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ko">Koreanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=th">Thailändisch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fr">Französisch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=es">Spanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=it">Italienisch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pt">Portugiesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=nl">Niederländisch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=pl">Polnisch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=fa">Persisch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=tr">Türkisch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=vi">Vietnamesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=mohesles&project=my-skylight-calendar&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# DIY Smart Home Familienkalender (Skylight-Klon)

![Skylight-Kalender](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/main_view.jpeg)
![DIY Skylight](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/assets/sky2.png)

## 📖 Einführung

Meine Frau wurde in letzter Zeit in den sozialen Medien mit Werbung für smarte Familienkalender (Skylight, Cozyla, Hearth) überhäuft und war bereit, über 300 $ dafür auszugeben. Bevor ich ihr grünes Licht gab, bat ich um die Chance, diese zu recherchieren.

Mir fiel auf, dass die meisten eine ähnliche Funktionalität boten, sich aber im Preis erheblich unterschieden. Am wichtigsten war, dass ich kein herausragendes Feature sah, das ich nicht selbst in **Home Assistant** umsetzen konnte.

**Das Ziel:** Ein WAF-zugelassener (Wife Acceptance Factor), arbeitsplattenfreundlicher Touchscreen-Kalender, der tief in unser Smart Home integriert ist und keine monatlichen Gebühren verursacht.

## 💡 Warum DIY?

Der DIY-Weg mit Home Assistant bot mehrere Vorteile gegenüber dem Kauf eines Skylight/Hearth-Displays:

* **Keine monatlichen Gebühren:** Vermeidet Abonnements für „Premium“-Funktionen.
* **Nahtlose Integration:** Kommuniziert mit unseren Lampen, Aufgaben (Grocy) und Präsenzsensoren.
* **Alte Hardware:** Ein Mini-PC und ein Standardmonitor wurden wiederverwendet.
* **Datenschutz:** Keine Anbieterbindung oder Risiko, dass das Unternehmen den Dienst einstellt.

## 🛠 Hardware-Auswahl

Dies ist derzeit so gebaut, dass das Dashboard auf jedem HD-Display (1920x1080) angezeigt werden kann.

In meinem Fall war die Anforderung, dass es „wie Skylight aussieht“, Touchscreen-fähig ist, auf der Arbeitsplatte steht und die Möglichkeit besteht, es an verschiedenen Orten zu nutzen. Daher habe ich mich für die unten beschriebene Hardware entschieden.
Nichtsdestotrotz kann dein Anwendungsfall anders sein und du musst es ggf. anpassen, zum Beispiel, wenn du es auf einem Tablet oder etwas anderem anzeigen möchtest.

Die ursprünglich verwendete Hardware habe ich nach den oben genannten Kriterien ausgewählt und in der Hoffnung, die Funktionalität mit Webcam, Lautsprecher und Mikrofon erweitern zu können. Im Nachhinein würde ich es jetzt wahrscheinlich anders bauen, da ich bisher keine Zeit hatte, diese zusätzlichen Hardware-Ideen umzusetzen.

* **Monitor:** [HP Engage 15-Zoll Touchscreen](https://computers.woot.com/offers/hp-engage-16t-fhd-monitor). Ich habe diesen einem generischen tragbaren Monitor vorgezogen, da er einen integrierten **Lautsprecher, eine Webcam und ein Mikrofon** besitzt, was zukünftige Sprachsteuerung oder Videoanrufe ermöglicht.
* **Computer:** Ein alter Mini-PC (NUC/Tiny PC) mit Windows/Linux im Kiosk-Modus oder ein Raspberry Pi 4.~~

## ✨ Funktionen

* **Familienweite & individuelle Ansichten:** Kalender einzelner Familienmitglieder ein-/ausblenden.
* **Bidirektionale Synchronisation:** Termine am Bildschirm oder am Handy bearbeiten (Google Kalender).
* **"Termin hinzufügen"-Popup:** Eine individuelle UI, um Termine direkt am Bildschirm in bestimmte Kalender einzutragen.
* **Wetter & Datum:** Schön gestalteter, übersichtlicher Kopfbereich.
* **Responsiv:** Passt die angezeigten Tage automatisch an die Bildschirmbreite an (Mobil vs. Desktop).

---

## ⚙️ Installationsanleitung

*Hinweis: Dieses Setup verwendet ein **YAML-Paket**, um automatisch alle benötigten Helfer, Skripte und Variablen für dich zu erstellen. Du musst diese nicht manuell anlegen.*


### 1. Voraussetzungen (HACS)

Sie müssen [HACS](https://hacs.xyz/) installiert haben. Bitte installieren Sie die folgenden **Frontend**-Integrationen:

* `week-planner-card`
* `bubble-card`
* `config-template-card`
* `card-mod`
* `better-moment-card`
* `weather-card`
* `browser_mod` (Erforderlich, damit die Popups funktionieren)
* `layout-card` (Erforderlich für die Sections-Ansicht)
* `button-card` (Erforderlich für das Hinzufügen von Terminen per Popup)

### 2. Das Backend (Das Gehirn)

1. Öffnen Sie Ihre Datei `configuration.yaml` in Home Assistant.
2. Stellen Sie sicher, dass Sie diese Zeile unter `homeassistant:` hinzugefügt haben, um Pakete zu aktivieren:

   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```
3. Erstellen Sie einen Ordner namens `packages` in Ihrem HA-Konfigurationsverzeichnis (falls Sie noch keinen haben).
4. Laden Sie [packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml) aus diesem Repository herunter.
5. Legen Sie die Datei in Ihren `packages/`-Ordner.
6. **Starten Sie Home Assistant neu**.

### 3. Die Kalender

Sie können **Google-Kalender** oder **Lokale Kalender** verwenden.

#### Option A: Lokaler Kalender (am einfachsten)

Beachten Sie, dass dies ungetestet ist, da ich ausschließlich Google-Kalender verwende

1. Gehen Sie zu **Einstellungen > Geräte & Dienste**.
2. Fügen Sie die Integration **Lokaler Kalender** hinzu.
3. Erstellen Sie Kalender mit genau diesen Namen: `Alice`, `Bob`, `Charlie`, `Daisy`, `Family`.
    * *Wenn Sie diese Namen verwenden, funktioniert der Code direkt!*

#### Option B: Google-Kalender

1. Öffnen Sie `packages/family_calendar.yaml`.
2. Scrollen Sie zum Skript `add_google_calendar_event`.
3. Aktualisieren Sie die `calendar_map`, sodass sie auf Ihre realen Google-Entitäten zeigt:


    ```yaml
    calendar_map:
      "Alice": "calendar.alice_gmail_com"
      "Bob": "calendar.bob_work_account"
    ```

#### Feiertage einrichten

Seit den Updates von Home Assistant werden Feiertage jetzt über die Benutzeroberfläche hinzugefügt:

1. Gehe zu **Einstellungen > Geräte & Dienste > Integration hinzufügen > Feiertag**.
2. Wähle dein Land aus.
3. Überprüfe die Entity-ID (z. B. `calendar.holidays`). Falls diese von der Standard-ID abweicht, aktualisiere sie im Dashboard-YAML.

### 4. Das Dashboard (Das Aussehen)

1. Erstelle eine neue Dashboard-Ansicht (Ansichtstyp auf **Abschnitte** setzen).
2. Kopiere den Code aus [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml).
3. **Anpassen:**
   * **Suchen & Ersetzen:** Ersetze `person.alice` durch deine tatsächlichen Familienmitglied-Entitäten.
   * **Wetter:** Ersetze `weather.home` durch deinen Wetteranbieter.
   * **Hintergrund:** Aktualisiere die Bild-URL am Ende der yaml.

### Schritt 5: Das Theme (Optional)

Um das spezielle Schriftbild (Ovo) zu erhalten:

1. Stelle sicher, dass deine `configuration.yaml` diese Zeile unter `frontend:` enthält.

   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```
2. Erstellen Sie einen Ordner namens `themes` in Ihrem Konfigurationsverzeichnis.
3. Laden Sie [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml) herunter und legen Sie diese Datei in diesem Ordner ab.
4. Starten Sie Home Assistant neu.
5. Gehen Sie zu Ihrem Profil (Benutzersymbol unten links) und ändern Sie das **Theme** auf `Skylight`.
HINWEIS: Das Theme ist nicht umfassend, behalten Sie dies im Hinterkopf.

---

## 📐 Funktionsweise (unter der Haube)

### Filter-Logik

Die `week-planner-card` unterstützt das Ausblenden bestimmter Kalender nicht nativ. Um dies zu lösen, habe ich **Input Texts** als Regex-Filter verwendet.

* Wenn Sie auf die Schaltfläche einer Person klicken, wird deren Filter zwischen `.*` (Alles anzeigen) und `^$` (Nichts anzeigen) umgeschaltet.
* Die `config-template-card` injiziert diese Variablen dynamisch in die Kalenderkarte.

### Ereigniserstellungs-Skript

Das "Add Event"-Popup verwendet ein einziges Skript, das die Logik für mehrere Personen und Ereignistypen (Ganztägig vs. zeitlich) übernimmt.


```yaml
# Simplified Logic Example
target_calendar: "{{ calendar_map.get(states('input_select.calendar_select')) }}"

choose:
  - conditions: "All Day Event is ON"
    action: calendar.create_event (start_date, end_date)
  - conditions: "All Day Event is OFF"
    action: calendar.create_event (start_date_time, end_date_time)
```

## HINWEISE

Mein ursprünglicher Beitrag sollte nur einen groben Überblick darüber geben, wie man es macht, und den Leuten ermöglichen, den Code an ihre spezifischen Szenarien anzupassen.

Insbesondere habe ich das gemacht, weil jedes Display und jeder Bedarf unterschiedlich ist. Ich kann nicht für alle potenziellen Displaygrößen, Dashboards usw. entwickeln. Es ist also dafür gebaut, mit dem erwähnten Display oder jedem anderen (1920x1080) zu funktionieren, sollte aber für andere editierbar sein.

Was das Display angeht, habe ich ursprünglich das vorgeschlagen, weil es damals bei Woot im Angebot war und eine sehr günstige Möglichkeit bot, ein Touchscreen-Display zu bekommen. Das muss jetzt aber nicht mehr der Fall sein, verwende also einfach das Display, das für dich funktioniert. Tablet, Touchscreen, Handy, was auch immer. Das Hauptsächliche, das du bearbeiten musst, ist das Dashboard.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-14

---