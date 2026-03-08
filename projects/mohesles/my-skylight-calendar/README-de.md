
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
* `browser_mod` (Erforderlich für die Popups)
* `layout-card` (Erforderlich für die Sections-Ansicht)
* `button-card` (Erforderlich für das Popup zum Hinzufügen eines Ereignisses)

*Hinweis: Unter Einstellungen → Geräte & Dienste stellen Sie sicher, dass Browser Mod als Integration (Kachel) erscheint und nicht nur unter HACS. 
Falls dies nicht der Fall ist, klicken Sie auf Integration hinzufügen → Browser Mod und schließen Sie den Vorgang ab, danach starten Sie HA neu.
Die Installation über HACS lädt nur Dateien herunter; Sie müssen die Integration hinzufügen, damit HA deren Aktionen/Entitäten registriert.

### 2. Das Backend (Das Gehirn)

1. Öffnen Sie Ihre `configuration.yaml`-Datei in Home Assistant.
2. Stellen Sie sicher, dass Sie diese Zeile unter `homeassistant:` hinzugefügt haben, um Pakete zu aktivieren:

   ```yaml
   homeassistant:
     packages: !include_dir_named packages
   ```

3. Erstellen Sie einen Ordner namens `packages` in Ihrem HA-Konfigurationsverzeichnis (falls Sie keinen haben).
4. Laden Sie [packages/family_calendar.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/packages/family_calendar.yaml) aus diesem Repository herunter.
5. Suchen Sie nach dem String [ #<--- UPDATE THIS ENTITY] und aktualisieren Sie die Kalender-Entity-ID, damit sie Ihrer Umgebung entspricht. Weitere Details finden Sie in Abschnitt 3.
6. Legen Sie die Datei in Ihren `packages/`-Ordner.
7. **Starten Sie Home Assistant neu**.

### 3. Die Kalender

Sie können **Google-Kalender** oder **lokale Kalender** verwenden.

#### Option A: Kalendernamen wiederverwenden (am einfachsten)


1. Gehen Sie zu **Einstellungen > Geräte & Dienste**.
2. Fügen Sie die **Local Calendar**-Integration hinzu.
3. Erstellen Sie Kalender mit exakt folgenden Namen: `calendar1`, `calendar2`, `calendar3`, `calendar4`, `Family`.
    * *Wenn Sie diese Namen verwenden, funktioniert der Code direkt!*

#### Option B: Benutzerdefinierter Kalender

1. Gehen Sie zu **Einstellungen > Geräte & Dienste**.
2. Fügen Sie die **Local Calendar**-Integration oder **Google Calendar** hinzu.
3. Navigieren Sie zu **Konfiguration > Integrationen > Local Calendar** oder **Google Calendar** und wählen Sie "Eintrag hinzufügen".
4. Für jeden erstellten Eintrag erhalten Sie die Entity-ID, um die dashboard.yaml-Datei zu aktualisieren.
5. Öffnen Sie `dashboard.yaml`.
6. Suchen Sie nach `# <--- UPDATE THIS ENTITY`.
7. Aktualisieren Sie die Entity-ID entsprechend Ihrer Umgebung.


#### Feiertage einrichten

Seit den Updates von Home Assistant werden Feiertage jetzt über die Benutzeroberfläche hinzugefügt:

1. Gehen Sie zu **Einstellungen > Geräte & Dienste > Integration hinzufügen > Holiday**.
2. Wählen Sie Ihr Land aus.
3. Prüfen Sie die Entity-ID (z.B. `calendar.holidays`). Wenn diese von der Standard-ID abweicht, aktualisieren Sie sie in der Dashboard-YAML.

### 4. Das Dashboard (Das Aussehen)

1. Gehe zu **Einstellungen > Dashboard**
2. Klicke auf **Dashboard hinzufügen** (Wähle die Option "Neues Dashboard von Grund auf" und stelle sicher, dass "Zur Seitenleiste hinzufügen" ausgewählt ist).
3. Wähle im linken Menü das neu erstellte Dashboard aus und klicke auf das Stiftsymbol, um es zu bearbeiten.
5. Wähle das Dreipunkt-Symbol und dann "Roher Konfigurator-Editor".
6. Kopiere und füge den Code aus [dashboard.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/dashboard.yaml) ein.

### Schritt 5: Das Theme (Optional)

Um das spezielle Schriftbild (Ovo) zu erhalten:

1. Stelle sicher, dass deine `configuration.yaml` diese Zeile unter `frontend:` enthält:

   ```yaml
   frontend:
     themes: !include_dir_merge_named themes
   ```
2. Erstellen Sie einen Ordner namens `themes` in Ihrem Konfigurationsverzeichnis.
3. Laden Sie [themes/skylight.yaml](https://raw.githubusercontent.com/mohesles/my-skylight-calendar/main/themes/skylight.yaml) herunter und legen Sie diese Datei in diesem Ordner ab.
4. Verwenden Sie den Dateieditor und laden Sie calbackgrd.png in den /www/ Ordner hoch, dieser wird intern als /local im Dashboard übersetzt.
5. Starten Sie Home Assistant neu.
6. Gehen Sie zu Ihrem Profil (Benutzersymbol unten links) und ändern Sie das **Theme** zu `Skylight`.
HINWEIS: Das Theme ist nicht umfassend, behalten Sie das im Hinterkopf.

---

## 📐 Wie es funktioniert (unter der Haube)

### Filter-Logik

Die `week-planner-card` unterstützt das Ausblenden bestimmter Kalender nicht nativ. Um das zu lösen, habe ich **Input Texts** als Regex-Filter verwendet.

* Wenn Sie auf den Button einer Person klicken, wird deren Filter zwischen `.*` (Alles anzeigen) und `^$` (Nichts anzeigen) umgeschaltet.
* Die `config-template-card` injiziert diese Variablen dynamisch in die Kalenderkarte.

### Ereigniserstellungs-Skript

Das "Ereignis hinzufügen"-Popup verwendet ein einziges Skript, das die Logik für mehrere Personen und Ereignistypen (Ganztägig vs. Zeitlich) verwaltet.


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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-08

---