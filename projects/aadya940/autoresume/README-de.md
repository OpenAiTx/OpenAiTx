<p align="center">
  <img src="https://raw.githubusercontent.com/aadya940/autoresume/main/main_app/frontend/public/autoresume-logo.png" alt="autoResume Logo" title="autoResume Logo" width="180"/>
</p>

<h1 align="center">autoResume</h1>

<p align="center">
  <b>Open-Source-Lebenslauf-Generator: Fügen Sie Ihre Links ein, bearbeiten Sie manuell und lassen Sie KI beim Polieren, Aktualisieren und Anpassen Ihres Lebenslaufs helfen.</b>
</p>

---

### Wie benutzt man das?

[Medium Blog Link](https://medium.com/@aadyachinubhai/autoresume-copy-and-paste-links-its-that-simple-8e50e6d155a1)

Der Blog ist veraltet in Bezug auf die Benutzeroberfläche und das verwendete Template.

## Funktionen

- <b>Einfache Link-Importfunktion:</b> Fügen Sie Links von Webseiten ein und erstellen Sie schnell einen PDF-Lebenslauf.
- <b>Manueller Editor inklusive:</b> Verfeinern oder erstellen Sie Ihren Lebenslauf von Grund auf mit einem eingebetteten Code-Editor.
- <b>Intelligente Vorschläge:</b> Geben Sie Feedback oder neue Links an, und Smartedits helfen dabei, Ihren Lebenslauf zu verfeinern und zu aktualisieren.
- <b>Joborientierte Anpassung:</b> Fügen Sie eine Stellenbeschreibung ein und erhalten Sie Empfehlungen zur Ausrichtung Ihres Lebenslaufs.
- <b>LaTeX-Qualität:</b> Alle Lebensläufe werden mit LaTeX für ein sauberes, professionelles Layout generiert.
- <b>Sofortige Vorschau:</b> Sehen Sie Ihren Lebenslauf in Echtzeit als PDF.
- <b>Einfache Rücksetzung:</b> Löschen und starten Sie Ihren Lebenslauf mit einem Klick neu.
- <b>Lokal:</b> Läuft vollständig auf Ihrem Rechner mit Docker.

---

## Erste Schritte

### Voraussetzungen
- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/)

### Einrichtung

1. Repository klonen:
   ```bash
   git clone https://github.com/aadya940/autoresume.git
   cd autoresume
   ```
2. App bauen und starten:
   ```bash
   docker compose up --build
   ```
3. Auf die Apps zugreifen:
   
   [_http://localhost:5173_](http://localhost:5173)
---

## Verwendung

1. Öffnen Sie autoResume in Ihrem Browser.
2. Klicken Sie auf das :gear: Symbol, fügen Sie Ihren [GOOGLE API KEY](https://aistudio.google.com/) und Ihre E-Mail-Adresse ein.
3. Fügen Sie Links zu Ihren beruflichen Informationen ein (z.B. Github, persönliche Webseite usw.).
4. Optional: Geben Sie Feedback oder einen Link zu einer Stellenanzeige für weitere Anpassungen ein.
5. Klicken Sie auf <b>Generate Resume</b> und lassen Sie die KI den Rest erledigen!

---

## Lizenz

Dieses Projekt ist unter der Apache 2.0 Lizenz lizenziert.

## Beitragshinweise

### Frontend
- Implementieren Sie React-Komponenten im Ordner `frontend/src/components/`
- Wir verwenden Chakra UI zur Umsetzung der Komponenten.
- Importieren und nutzen Sie Ihre Komponenten in `frontend/src/App.jsx`

### Backend
- Implementieren Sie API-Routen im Verzeichnis `backend/src/routes/`
- Fügen Sie KI-Funktionalität im Verzeichnis `backend/src/ai/` hinzu
- Wir verwenden den Code-Formatter `black` für Python-Code
- Halten Sie die Routen-Handler sauber und trennen Sie die Logik

### Allgemeine Richtlinien
- Erstellen Sie einen neuen Branch für Ihr Feature/Fix: `git checkout -b ihr-branch-name`
- Schreiben Sie klare Commit-Nachrichten
- Testen Sie Ihre Änderungen, bevor Sie einen PR einreichen

### Änderungen einreichen
1. Erstellen Sie eine Pull Request
2. Fügen Sie in Ihrer PR-Beschreibung Folgendes hinzu:
   - Welche Änderungen Sie vorgenommen haben
   - Warum Sie diese vorgenommen haben
   - Relevante Screenshots oder Testergebnisse
   - Eventuelle Breaking Changes oder notwendige Migrationsschritte

Wir schätzen Ihre Beiträge und werden Ihre PR so schnell wie möglich prüfen!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---