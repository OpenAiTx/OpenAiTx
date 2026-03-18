
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=en">Englisch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fr">Französisch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=es">Spanisch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=it">Italienisch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pt">Portugiesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=nl">Niederländisch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pl">Polnisch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=tr">Türkisch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=vi">Vietnamesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=id">Indonesisch</a>
      </div>
    </div>
  </details>
</div>

# Nothing but Nix

**Verwandle deinen GitHub Actions Runner in eine [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ Power-Maschine, indem du vorinstallierten Ballast kompromisslos entfernst.**

GitHub Actions Runner bieten nur wenig Speicherplatz für Nix – lediglich ~20GB.
*Nothing but Nix* **säubert brutal** unnötige Software und verschafft dir **65GB bis 130GB** für deinen Nix-Store! 💪

## Verwendung 🔧

Fügen Sie diese Aktion **vor** der Installation von Nix in Ihrem Workflow hinzu:

```yaml
jobs:
  build:
    runs-on: ubuntu-latest
    permissions:
      contents: read
      id-token: write
    steps:
      - uses: actions/checkout@v4
      - uses: wimpysworld/nothing-but-nix@main
      - name: Install Nix
        uses: DeterminateSystems/nix-installer-action@main
      - name: Run Nix
        run: |
          nix --version
          # Your Nix-powered steps here...
```

### Anforderungen ️✔️

- Unterstützt ausschließlich offizielle **Ubuntu** GitHub Actions Runner
- Muss **vor** der Installation von Nix ausgeführt werden
- **macOS/Darwin Runner**: Diese Aktion überspringt den Vorgang mit einer Warnung, wenn sie auf macOS ausgeführt wird. macOS Runner bieten bereits genügend Platz für Nix und benötigen diese Aktion nicht
- **Windows Runner**: Diese Aktion überspringt den Vorgang mit einer Warnung, wenn sie auf Windows ausgeführt wird. Windows Runner haben andere Dateisystemlayouts und Einschränkungen

## Das Problem: Platz schaffen, damit Nix gedeiht 🌱

Standard GitHub Actions Runner sind vollgestopft mit *"Bloatware"*, die du in einem Nix-Workflow niemals nutzen wirst:

- 🌍 Webbrowser. Viele davon. Muss sie alle haben!
- 🐳 Docker-Images, die Gigabyte wertvollen Speicherplatz verbrauchen
- 💻 Unnötige Sprachlaufzeiten (.NET, Ruby, PHP, Java...)
- 📦 Paketmanager, die digitalen Staub ansammeln
- 📚 Dokumentation, die niemand jemals lesen wird

Dieser Ballast lässt nur ~20GB für deinen Nix Store übrig – kaum genug für ernsthafte Nix Builds! 😞

## Die Lösung: Nur Nix ️❄️

**Nur Nix** verfolgt einen kompromisslosen Ansatz für GitHub Actions Runner und holt erbarmungslos Speicherplatz zurück – mit einer zweistufigen Attacke:

1. **Initialer Schnitt:** Erstellt sofort ein großes `/nix` Volume (~65GB), indem freier Speicher von `/mnt` beansprucht wird
2. **Hintergrund-Rampage:** Während dein Workflow weiterläuft, entfernen wir unerbittlich unnötige Software, um dein `/nix` Volume auf bis zu ~130GB zu erweitern
   - Webbrowser? Nein ⛔
   - Docker-Images? Weg 🗑️
   - Sprachlaufzeiten? Vernichtet 💥
   - Paketmanager? Ausgelöscht 💣
   - Dokumentation? Vaporisiert ️👻

Die Dateisystembereinigung wird von `rmz` (aus dem [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc) Projekt) angetrieben – eine leistungsstarke Alternative zu `rm`, die die Speicherfreigabe blitzschnell macht! ⚡
   - Übertrifft das Standard-`rm` um ein Vielfaches
   - Löscht parallel für maximale Effizienz
   - **Gewinnt Speicherplatz in Sekunden statt Minuten zurück!** ️⏱️

Das Endergebnis? Ein GitHub Actions Runner mit **65GB bis 130GB** Nix-fertigem Speicherplatz! 😁

### Dynamisches Volumenwachstum

Im Gegensatz zu anderen Lösungen wächst **Nothing but Nix** Ihr `/nix`-Volume dynamisch:

1. **Initiale Volume-Erstellung (1-10 Sekunden):** (*abhängig vom Hatchet Protocol*)
   - Erstellt ein Loop-Gerät aus freiem Speicherplatz auf `/mnt`
   - Richtet ein BTRFS-Dateisystem in RAID0-Konfiguration ein
   - Mountet mit Kompression und Performance-Optimierung
   - Stellt sofort ein 65GB großes `/nix` bereit, noch bevor die Bereinigung beginnt

2. **Hintergrund-Erweiterung (30-180 Sekunden):** (*abhängig vom Hatchet Protocol*)
   - Führt Bereinigungsoperationen aus
   - Überwacht den neu freigegebenen Speicherplatz, während Ballast entfernt wird
   - Fügt dem `/nix`-Volume dynamisch eine Erweiterungsdisk hinzu
   - Balanciert das Dateisystem neu, um den neuen Speicherplatz einzubinden

Das `/nix`-Volume **wächst automatisch während der Workflow-Ausführung** 🎩🪄

### Wähle Deine Waffe: Das Hatchet Protocol 🪓

Steuere das Ausmaß der Vernichtung 💥 mit dem `hatchet-protocol`-Parameter:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'cleave'  # Options: holster, carve, cleave (default), rampage
```

#### Protokollvergleich ⚖️

| Protokoll | `/nix` | Beschreibung                                      | Apt bereinigen | Docker bereinigen | Snap bereinigen | Bereinigte Dateisysteme     |
|-----------|--------|---------------------------------------------------|----------------|-------------------|-----------------|-----------------------------|
| Holster   | ~65GB  | Die Axt bleibt in der Scheide, nutzt Platz von `/mnt` | Nein           | Nein              | Nein            | Keine                       |
| Carve     | ~85GB  | Kombiniert und gewinnt freien Speicher von `/` und `/mnt` | Nein           | Nein              | Nein            | Keine                       |
| Cleave    | ~115GB | Mächtige, entschlossene Schnitte bei großen Paketen   | Minimal        | Ja                | Ja              | `/opt` und `/usr/local`     |
| Rampage   | ~130GB | Unerbittliche, brutale Eliminierung allen Ballasts    | Aggressiv      | Ja                | Ja              | Muahahaha! 🔥🌎             |

Wähle mit Bedacht:
- **Holster**, wenn du die Tools des Runners vollständig funktionsfähig lassen musst
- **Carve**, um die Funktionalität der Runner-Tools zu bewahren, aber allen freien Platz für Nix zu beanspruchen
- **Cleave** (*Standard*) für einen guten Kompromiss zwischen Speicher und Funktionalität
- **Rampage**, wenn du maximalen Nix-Speicher brauchst und es dir egal ist, was kaputtgeht `#nix-is-life`

### Sieh das Gemetzel 🩸

Standardmäßig läuft der Bereinigungsprozess im Hintergrund still ab, während dein Workflow weiterläuft. Aber wenn du das Gemetzel in Echtzeit sehen möchtest:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    witness-carnage: true  # Default: false
```

### Sichere Zufluchtsorte anpassen 🛡️

Bestimmen Sie, wie viel Platz Sie für die Nix-Store-Landnahme freihalten möchten, mit benutzerdefinierten Größen für sichere Zufluchtsorte:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    root-safe-haven: '3072'   # Reserve 3GB on the / filesystem
    mnt-safe-haven: '2048'    # Reserve 2GB on the /mnt filesystem
```

Diese Schutzbereiche legen fest, wie viel Speicherplatz (in MB) bei der Speicherbereinigung gnädig verschont bleibt:
- Der Standardwert für `root-safe-haven` beträgt 2048MB (2GB)
- Der Standardwert für `mnt-safe-haven` beträgt 1024MB (1GB)

Erhöhen Sie diese Werte, wenn Sie mehr Luft auf Ihren Dateisystemen benötigen, oder verringern Sie sie, um keine Gnade zu zeigen! 😈

### Benutzerbesitz für /nix gewähren (Nix-Berechtigungsedikt) 🧑‍⚖️

Einige Nix-Installer oder -Konfigurationen erwarten, dass das Verzeichnis `/nix` vom aktuellen Benutzer beschreibbar ist. Standardmäßig gehört `/nix` root. Wenn Sie den Benutzerbesitz benötigen (z. B. für bestimmte Nix-Installer-Skripte, die nicht für alle Operationen innerhalb von `/nix` `sudo` verwenden), können Sie das `nix-permission-edict` aktivieren:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    nix-permission-edict: true  # Default: false
```

Wenn `nix-permission-edict` auf `true` gesetzt ist, führt die Aktion nach dem Einbinden von `/nix` den Befehl `sudo chown -R "$(id --user)":"$(id --group)" /nix` aus.

### Konfiguriere Nix zur Nutzung von /nix/build

Diese Aktion erstellt `/nix/build`, damit Nix-Derivate für Builds den zurückgewonnenen Speicherplatz nutzen können. Fügen Sie `build-dir` zu Ihrer Nix-Konfiguration hinzu:

```yaml
- uses: cachix/install-nix-action@v31
  with:
    extra_nix_config: |
      build-dir = /nix/build
```

Oder mit DeterminateSystems:

```yaml
- uses: DeterminateSystems/nix-installer-action@main
  with:
    extra-conf: |
      build-dir = /nix/build
```

Dies weist Nix an, Builds auf dem großen BTRFS-Volume auszuführen, anstatt im standardmäßigen temporären Verzeichnis des Systems.

## Fehlerbehebung 🔍

### "Kein Speicherplatz mehr auf dem Gerät" bei großen Builds

Wenn Ihr Build trotz der ausschließlichen Nutzung von Nix keinen Speicherplatz mehr hat, liegt das wahrscheinlich daran, dass das Hintergrundbereinigen nicht abgeschlossen wurde, bevor Ihr Build den verfügbaren Speicherplatz belegt hat. Dies betrifft häufig:

- NixOS-VM-Tests, die große Festplattenabbilder erstellen
- Builds mit vielen Abhängigkeiten, die nicht zwischengespeichert sind
- Rust-Toolchains und andere große Kompilierungen

**Lösung:** Verwenden Sie `witness-carnage: true`, um eine synchrone Bereinigung zu erzwingen. So wird sichergestellt, dass der gesamte Speicher *vor* Beginn Ihres Builds freigegeben wird:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'rampage'
    witness-carnage: true
```

Dies fügt Ihrem Workflow-Setup 30-180 Sekunden hinzu, garantiert jedoch, dass beim Start Ihres Builds maximaler Speicherplatz verfügbar ist.

Jetzt bauen Sie etwas Großartiges mit all dem herrlichen Nix-Store-Speicher! ❄️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-18

---