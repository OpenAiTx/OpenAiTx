
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ja">Japanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ko">Koreanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=th">Thailändisch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fr">Französisch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=es">Spanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=it">Italienisch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pt">Portugiesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=nl">Niederländisch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=pl">Polnisch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=fa">Persisch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=tr">Türkisch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=vi">Vietnamesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=nodeloc666&project=yt-dlp-script&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>


# 🎬 yt-dlp Video-Massen-Download-Tool (Unterstützung für Windows / Linux)

> Ein One-Click-Video-Download-Skript basierend auf [yt-dlp](https://github.com/yt-dlp/yt-dlp), inspiriert von [NodeSeek's Beitrag](https://www.nodeseek.com/post-334093-2#15).
> Unterstützt Einzel- und Massendownloads, kompatibel mit Windows und den gängigen Linux-Distributionen (Debian / Ubuntu / Alpine / CentOS).

---

## ✨ Funktionsmerkmale

* 📥 **Ein-Klick-Ausführung**: Keine manuelle Konfiguration erforderlich, einfach den Anweisungen folgen und mit dem Download beginnen
* 🍪 **Unterstützt benutzerdefinierte Cookies**: Geeignet für Videos, die einen Login zum Download erfordern (⚠️ Diese Funktion ist noch nicht verifiziert, möglicherweise gibt es Bugs)
* 📂 **Unterstützt benutzerdefiniertes Ausgabeverzeichnis**: Einfaches Speichern im gewünschten Ordner
* 📃 **Unterstützt Batch-Download**: Automatisches Einlesen der Links aus der Datei `urls.txt` zum Download
* ⚙️ **Automatische Installation von Abhängigkeiten**: Unter Linux werden `yt-dlp` und `ffmpeg` automatisch installiert

---

## 🖼️ Screenshot-Vorschau

| Beispiel 1                                                                   | Beispiel 2                                                                   |
| ---------------------------------------------------------------------- | ---------------------------------------------------------------------- |
| ![Beispiel 1](https://img.uutv.dpdns.org/file/1746720584399_1000193433.jpg) | ![Beispiel 2](https://img.uutv.dpdns.org/file/1746720581006_1000193434.jpg) |
| ![Beispiel 3](https://img.uutv.dpdns.org/file/1746720588978_1000193428.jpg) | ![Beispiel 4](https://img.uutv.dpdns.org/file/1746720587272_1000193427.jpg) |

---

## 🪟 Anleitung für Windows

1. Folgende Dateien herunterladen:

   * [`yt-dlp.exe`](https://github.com/yt-dlp/yt-dlp)
   * [`ffmpeg` Windows Version](https://www.gyan.dev/ffmpeg/builds/ffmpeg-git-full.7z)

2. Nach dem Entpacken die folgenden Dateien in denselben Ordner (z.B. `yt-dlp` Ordner) legen:

   * `yt-dlp.exe`
   * `ffmpeg.exe`
   * `ffprobe.exe`
   * `yt-dlp.bat` (Skriptdatei)

3. Doppelklick auf `yt-dlp.bat` und den Anweisungen zum Download des Videos folgen.
4. Bearbeite config/config.ini, um die Standardkonfiguration zu ändern

---

## 🐧 Anleitung für Linux (Das neueste Skript von Technologie-Lion enthält ebenfalls ein entsprechendes Funktionsskript)

**Unterstützte Systeme**: Debian / Ubuntu / Alpine / CentOS

Ein-Klick-Bereitstellung oder Aktualisierung und Ausführung:

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/install.sh)"
```

Zum Deinstallieren:

```bash
bash -c "$(curl -fsSL https://raw.githubusercontent.com/nodeloc666/yt-dlp-script/main/uninstall.sh)"
```

---

## 📱 Android Nutzungsempfehlung

1. Verwenden Sie die [Seal](https://github.com/JunkFood02/Seal) App, um die `yt-dlp`-Funktionalität auf Android zu erleben.
2. Die Installation von Debian über termux ermöglicht auch Downloads, aber das ist nicht nötig, Seal ist sehr benutzerfreundlich.

---

## ⚠️ Hinweise

1. **Batch-Download-Modus**: Das Skript liest automatisch die Datei `config\urls.txt` im aktuellen Verzeichnis aus, wobei jede Zeile einen Videolink enthält. Wenn die Datei nicht existiert, wird sie automatisch erstellt.
2. **Hinweis zur Ressourcennutzung**: Geräte mit wenig Arbeitsspeicher sollten vermeiden, mehrere große Videos gleichzeitig herunterzuladen oder zu viele Threads parallel zu setzen.
3. **Besonderer Hinweis für CentOS**: Aufgrund der speziellen Umgebung wurde noch keine vollständige Kompatibilitätsprüfung durchgeführt. Die Nutzung in Nicht-Produktivumgebungen wird empfohlen. Alle anderen gängigen Systeme sind getestet und funktionsfähig.
4. Kleiner Bug in der Linux-Version: Das Skript prüft die Abhängigkeiten bei jedem Start auf der Startseite. Nach dem Motto "Hauptsache, es läuft" wurde das aus Faulheit nicht geändert.
5. Kleiner Bug in der Windows-Version: Wenn man von einer anderen Seite zurück zur Startseite geht und dann eine Auswahl trifft, kann die Standardauswahl fehlschlagen und in einer Endlosschleife hängen. Leider konnte ich das noch nicht beheben.
Zwei Lösungsmöglichkeiten:
    1. Beenden und neu starten
    2. Keine Standardauswahl, einfach die Zahl direkt eingeben

---

## 📄 Lizenz

Dieses Projekt steht unter der [MIT License](https://opensource.org/licenses/MIT).

---


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-08

---