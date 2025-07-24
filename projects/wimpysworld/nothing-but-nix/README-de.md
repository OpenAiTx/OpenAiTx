
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Nothing but Nix

**Verwandle deinen GitHub Actions Runner in eine [Nix](https://zero-to-nix.com/concepts/nix/) ❄️-Power-Maschine, indem du vorinstallierten Ballast gnadenlos entfernst.**

GitHub Actions Runner bieten nur wenig Speicherplatz für Nix – gerade mal etwa ~20GB.
*Nothing but Nix* **entfernt kompromisslos** unnötige Software und verschafft dir **65GB bis 130GB** für deinen Nix-Store! 💪

## Verwendung 🔧

Füge diese Action **vor** der Nix-Installation in deinem Workflow hinzu:

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

- Unterstützt nur offizielle **Ubuntu** GitHub Actions Runner
- Muss **vor** der Installation von Nix ausgeführt werden

## Das Problem: Platz schaffen, damit Nix gedeihen kann 🌱

Standard-GitHub-Actions-Runner sind vollgestopft mit *"Bloatware"*, die du in einem Nix-Workflow nie brauchen wirst:

- 🌍 Webbrowser. Viele davon. Muss man einfach alle haben!
- 🐳 Docker-Images, die Gigabytes wertvollen Speicherplatz verbrauchen
- 💻 Überflüssige Laufzeitumgebungen (.NET, Ruby, PHP, Java...)
- 📦 Paketmanager, die digitalen Staub ansetzen
- 📚 Dokumentationen, die nie jemand lesen wird

Dieser Ballast lässt nur ~20GB für deinen Nix-Store übrig – kaum genug für ernsthafte Nix-Builds! 😞

## Die Lösung: Nichts als Nix ️❄️

**Nichts als Nix** setzt auf eine radikale Strategie bei GitHub-Actions-Runnern und holt erbarmungslos Speicherplatz mit einem zweiphasigen Ansatz zurück:

1. **Erster Schlag:** Erstellt sofort ein großes `/nix`-Volume (~65GB), indem freier Speicherplatz von `/mnt` beansprucht wird
2. **Hintergrund-Randale:** Während dein Workflow weiterläuft, eliminieren wir rücksichtslos überflüssige Software, um dein `/nix`-Volume auf bis zu ~130GB zu erweitern
   - Webbrowser? Nein ⛔
   - Docker-Images? Weg 🗑️
   - Laufzeitumgebungen? Ausgelöscht 💥
   - Paketmanager? Vernichtet 💣
   - Dokumentation? Verpufft ️👻

Die Säuberung des Dateisystems erfolgt mit `rmz` (aus dem [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc) Projekt) – einer Hochleistungs-Alternative zu `rm`, die das Freimachen von Speicherplatz blitzschnell macht! ⚡
   - Übertrifft das Standard-`rm` um Größenordnungen
   - Löscht parallel für maximale Effizienz
   - **Gibt Speicherplatz in Sekunden statt Minuten frei!** ️⏱️

Das Endergebnis? Ein GitHub-Actions-Runner mit **65GB bis 130GB** Nix-bereitem Speicherplatz! 😁

### Dynamisches Volumenwachstum

Im Gegensatz zu anderen Lösungen wächst **Nichts als Nix** dein `/nix`-Volume dynamisch:

1. **Initiale Volumenerstellung (1–10 Sekunden):** (*abhängig vom Hatchet-Protokoll*)
   - Erstellt ein Loop-Device aus freiem Speicherplatz auf `/mnt`
   - Richtet ein BTRFS-Dateisystem im RAID0-Modus ein
   - Mountet mit Kompression und Performance-Tuning
   - Stellt sofort ein 65GB-`/nix` bereit, noch bevor die Säuberung beginnt

2. **Hintergrund-Erweiterung (30–180 Sekunden):** (*abhängig vom Hatchet-Protokoll*)
   - Führt die Bereinigungsoperationen durch
   - Überwacht neu freigegebenen Speicherplatz, während Ballast entfernt wird
   - Fügt dem `/nix`-Volume dynamisch eine Erweiterungsdisk hinzu
   - Rebalanciert das Dateisystem, um neuen Speicher zu integrieren

Das `/nix`-Volume **wächst automatisch während der Workflow-Ausführung** 🎩🪄

### Wähle deine Waffe: Das Hatchet-Protokoll 🪓

Steuere den Grad der Vernichtung 💥 mit dem `hatchet-protocol` Input:

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

Wenn `nix-permission-edict` auf `true` gesetzt ist, führt die Aktion nach dem Einhängen von `/nix` den Befehl `sudo chown -R "$(id --user)":"$(id --group)" /nix` aus.

Jetzt geh und baue etwas Großartiges mit all dem herrlichen Speicherplatz im Nix-Store! ❄️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---