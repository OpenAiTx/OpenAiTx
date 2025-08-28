<details align="right">
<summary>🌐 Sprache</summary>

[English](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=th) | [Français](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=de) | [Español](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=it) | [Русский](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ru) | [Português](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=BlackHatDevX&project=onionhoster&lang=as)
</details>

# OnionHoster v2.2

> **Das ultimative Hosting-Tool für Tor Hidden Services** – Stellen Sie Ihre Webprojekte in wenigen Minuten im Darknet bereit!
> 
[![Version](https://img.shields.io/badge/version-2.2-brightgreen.svg)](https://github.com/BlackHatDevX/onionhoster)
[![Platform](https://img.shields.io/badge/platform-Linux%20%7C%20macOS-blue.svg)](https://github.com/BlackHatDevX/onionhoster)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](https://github.com/BlackHatDevX/onionhoster)

<img width="1023" height="551" alt="ChatGPT Image Aug 27, 2025, 03_32_08 PM (1)-modified" src="https://github.com/user-attachments/assets/92b6e834-2d4f-4cc7-8f77-82b9bafba8a5" />


---

## 🚀 Was ist OnionHoster?

OnionHoster ist ein leistungsstarkes, plattformübergreifendes Bash-Skript, das jedes Webprojekt mit nur einem Befehl in einen Tor Hidden Service verwandelt. Egal ob Next.js-App, Flask-Backend oder statische Website – OnionHoster übernimmt die komplexe Tor-Konfiguration automatisch.

### ✨ Warum OnionHoster wählen?

- **🔧 Keine Konfiguration nötig** – Funktioniert sofort mit jedem Webprojekt
- **🌍 Plattformübergreifend** – Unterstützt Linux, macOS und alle wichtigen Distributionen
- **⚡ Ein-Klick-Einrichtung** – In weniger als 2 Minuten zum Hidden Service
- **🔄 Automatische Updates** – Eingebauter Update-Checker hält Sie aktuell
- **💾 Backup & Restore** – Verlieren Sie nie Ihre Onion-Adressen
- **🎯 Professionelle UI** – Schöne farbige Oberfläche mit intuitiven Menüs

---
## Vorschau

[![IMAGE ALT TEXT HERE](https://github.com/user-attachments/assets/4b35dfb0-0059-4cc5-99c7-a5b9467a385d)](https://www.youtube.com/watch?v=oPvhA54Tp8w)


# ⚠️ Warnung: OnionHoster ist KEIN magisches Anonymitäts-Tool — befolgen Sie Best Practices, sonst droht Deanonymisierung

**Systemhärtung**

* Führen Sie den Dienst in einer VM oder einem Container zur Isolierung aus.

* Halten Sie das Betriebssystem und die Pakete auf dem neuesten Stand.
* Deaktivieren Sie unnötige Dienste/Ports, sodass nur Tor-Verkehr ein- und ausgeht.

**OpSec-Praktiken**

* Verwenden Sie nicht denselben Rechner für persönliche Konten oder Aktivitäten.
* Vermeiden Sie die Offenlegung identifizierbarer Metadaten (Dateinamen, Header, Fehlermeldungen).
* Achten Sie auf Protokolle — was Sie protokollieren, wie lange Sie sie aufbewahren und ob sie Informationen preisgeben.

**Netzwerkhygiene**

* Verbinden Sie Ihren Hidden Service nicht mit Ihrer Clearnet-Identität oder -Domain.
* Verwenden Sie eine Firewall, um versehentliche Lecks außerhalb von Tor zu verhindern.
* Ziehen Sie Reverse Proxies für zusätzliche Isolation in Betracht.

**Testen & Überwachen**

* Verwenden Sie torsocks oder den Tor-Browser, um zu überprüfen, dass Ihr Dienst nur über seine `.onion`-Adresse erreichbar ist.
* Testen Sie regelmäßig auf Lecks (z. B. ob Ihre Anwendung versucht, aus dem Clearnet abzurufen).

**Bewusstsein für Anwendungsfälle**

* Für Hobby-/Test-/Bildungszwecke: Das oben Genannte ist in der Regel ausreichend.
* Für Hochrisiko, echte Anonymität (Journalisten, Whistleblower, Aktivisten): Es erfordert tiefere operative Sicherheit und Bedrohungsmodellierung, da ein einziger Fehler zur Deanonymisierung führen kann.


---
## 🎯 Perfekt für

- **Entwickler**, die ihre Apps auf Tor testen möchten
- **Datenschutzbefürworter**, die anonyme Dienste hosten (
- **Forscher**, die Dark-Web-Technologien untersuchen
- **Unternehmen**, die anonyme Hosting-Lösungen benötigen
- **Hobbyisten**, die das Tor-Netzwerk erkunden

---

## 🚀 Schnellstart

### Voraussetzungen
- Root-/sudo-Zugriff
- Internetverbindung
- Beliebiges Webprojekt (HTML, Next.js, Flask, usw.)

### Installation & Verwendung

```bash
# 1. Clone the repository
git clone https://github.com/BlackHatDevX/onionhoster.git

# 2. Navigate to the directory
cd onionhoster

# 3. Make the script executable
chmod +x onionhoster.sh

# 4. Run with sudo
sudo bash onionhoster.sh
```

**Das war's!** 🎉

Du erhältst das vollständige OnionHoster-Projekt inklusive:
- Dem Hauptskript `onionhoster.sh`
- Einer professionellen `index.html`-Vorlage zum Hosten
- Alle Dokumentationen und Beispiele

Das Skript übernimmt automatisch:
- Erkennung deines Betriebssystems
- Installation aller benötigten Abhängigkeiten (Tor, Apache, etc.)
- Konfiguration der Tor-Dienste
- Präsentation eines intuitiven Menüs

---

## 🎮 Funktionsübersicht

### 🌐 Hosting-Optionen
- **Statisches HTML** – Beliebige `index.html`-Datei hosten
- **Portweiterleitung** – Weiterleitung zu beliebigen lokalen Anwendungsports
- **Dynamische Apps** – Unterstützung für Next.js, Flask, Node.js und mehr

### 🛠️ Verwaltungstools
- **Service-Steuerung** – Hidden Service starten, stoppen und verwalten
- **Backup & Wiederherstellung** – Onion-Domains sicher sichern und wiederherstellen
- **URL-Aktualisierung** – Neue Onion-Adressen bei Bedarf generieren
- **Statusüberwachung** – Service-Gesundheit und Status prüfen

### 🔄 Smarte Updates
- **Auto-Erkennung** – Findet automatisch die neueste Version
- **Ein-Klick-Updates** – Mit einer Menüoption aktualisieren
- **Sichere Updates** – Kein Risiko, deine Konfiguration zu verlieren

---

## 📱 Unterstützte Betriebssysteme

| OS | Paketmanager | Status |
|----|--------------|--------|
| **Ubuntu/Debian** | `apt-get` | ✅ Vollständige Unterstützung |
| **CentOS/RHEL** | `yum` | ✅ Vollständige Unterstützung |
| **Fedora** | `dnf` | ✅ Vollständige Unterstützung |
| **Arch Linux** | `pacman` | ✅ Vollständige Unterstützung |
| **macOS** | `brew` | ✅ Vollständige Unterstützung |

---

## 🎯 Anwendungsfälle

### 🏠 Private Projekte
- Portfolio anonym hosten
- Webanwendungen privat testen
- Inhalte teilen, ohne Identität preiszugeben

### 🏢 Geschäftsanwendungen
- Anonyme Kundensupport-Portale
- Sichere interne Kommunikationssysteme
- Datenschutzorientierte Unternehmenswebsites

### 🔬 Forschung & Entwicklung
- Forschung zu Darknet-Technologien
- Entwicklung von Datenschutz-Tools
- Testen anonymer Dienste

---

## 📖 Detaillierte Nutzung

### Hauptmenüoptionen

1. **index.html hosten** – Eine statische HTML-Datei bereitstellen
2. **An Anwendung-Port weiterleiten** – Zu einem lokalen Dienst weiterleiten
3. **Tor-Domain sichern** – Onion-Konfiguration speichern
4. **Tor-Domain wiederherstellen** – Aus Backup wiederherstellen
5. **Aktuelle Tor-Domain anzeigen** – Aktuelle Onion-Adresse sehen
6. **Tor-Domain aktualisieren** – Neue Onion-Adresse generieren
7. **Nach Updates suchen** – Auf die neueste Version aktualisieren
8. **Webserver-Status** – Dienststatus überwachen
9. **Über OnionHoster** – Versions- und Feature-Informationen

### Beispiel-Workflow

```bash
# Start the service
sudo ./onionhoster.sh

# Choose option 1 to host index.html
# Your onion address will be displayed
# Access it via Tor Browser or similar
```

---

## 🔧 Erweiterte Konfiguration

### Benutzerdefiniertes Port-Forwarding
```bash
# Forward your Next.js app running on port 3000
# The script will handle all Tor configuration automatically
```

### Backup-Verwaltung
```bash
# Automatic backups are stored in ~/onion_backups/
# Each backup includes your onion keys and configuration
```

---

## 🛡️ Sicherheitsfunktionen

- **Automatische Tor-Konfiguration** - Sichere Voreinstellungen ab Werk
- **Korrekte Dateiberechtigungen** - Sichere Dateibesitz- und Zugriffsrechte
- **Dienstisolierung** - Jeder versteckte Dienst läuft unabhängig
- **Keine Datenprotokollierung** - Ihre Aktivitäten bleiben privat

---

## 🚨 Wichtige Hinweise

- **Root-Zugriff erforderlich** - Tor-Dienste benötigen Systemkonfiguration
- **Tor-Netzwerk** - Ihr Dienst ist über den Tor-Browser zugänglich
- **Onion-Adressen** - Jeder Dienst erhält eine eindeutige `.onion`-Adresse
- **Regelmäßig sichern** - Onion-Adressen ändern sich beim Aktualisieren

---

## 🤝 Beitrag leisten

Beiträge sind willkommen! Egal ob:
- 🐛 Fehlerberichte
- 💡 Funktionsvorschläge
- 📝 Verbesserungen der Dokumentation
- 🔧 Codebeiträge

**So starten Sie:**
1. Repository forken
2. Feature-Branch erstellen
3. Änderungen vornehmen
4. Pull Request einreichen

---

## 📄 Lizenz

Dieses Projekt steht unter der MIT-Lizenz – siehe die [LICENSE](LICENSE)-Datei für Details.

---

## 🙏 Danksagungen

- **Tor-Projekt** – Für das großartige Anonymitätsnetzwerk
- **Open-Source-Community** – Für stetige Verbesserungen
- **Nutzer & Mitwirkende** – Für Feedback und Vorschläge

---

## 🔗 Links

- **GitHub**: [https://github.com/BlackHatDevX/onionhoster](https://github.com/BlackHatDevX/onionhoster)
- **Probleme**: [https://github.com/BlackHatDevX/onionhoster/issues](https://github.com/BlackHatDevX/onionhoster/issues)
- **Diskussionen**: [https://github.com/BlackHatDevX/onionhoster/discussions](https://github.com/BlackHatDevX/onionhoster/discussions)

---

## ⭐ Dieses Projekt mit einem Stern markieren

Wenn OnionHoster Ihnen hilft, geben Sie ihm bitte einen Stern! Das motiviert uns, weiter zu verbessern und hilft anderen, dieses Tool zu entdecken.

---

**Bereit für Anonymität?** 🕵️‍♂️

```bash
git clone https://github.com/BlackHatDevX/onionhoster.git
cd onionhoster
sudo bash onionhoster.sh
```

*Ihre Reise zum anonymen Hosting beginnt jetzt!* 🚀


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-28

---