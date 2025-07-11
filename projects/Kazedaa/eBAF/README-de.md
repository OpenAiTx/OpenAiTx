# eBAF - eBPF-basierte Ad Firewall
<p align="center">
    <img src="https://raw.githubusercontent.com/Kazedaa/eBAF/main/assets/banner.png" alt="eBAF - eBPF Ad Firewall Banner" width="600"/>
</p>

## "Du würdest doch keine Werbung herunterladen"
### Aber du würdest sie blockieren!

Spotify hat ein Imperium auf einer einfachen Formel aufgebaut: Monetarisiere deine Aufmerksamkeit, bezahle die Künstler zu wenig und verkaufe dir deine eigene Zeit als Premium-Feature zurück.
In ihrer Welt gehört dir dein Hörerlebnis nicht. Es ist ein sorgfältig kuratierter Marktplatz – deine Ohren sind das Produkt, deine Geduld ist die Währung.

Sie nennen es gerne eine "kostenlose" Stufe.
Aber seien wir ehrlich: Es ist nicht kostenlos, wenn du mit deiner Zeit bezahlst.

Währenddessen verdienen die Künstler, die du liebst – die Menschen, deren Arbeit die Plattform am Leben hält – oft nur Bruchteile von Centbeträgen pro Stream. Spotify macht satte Gewinne, die Werbetreibenden bekommen ihre Aufmerksamkeit und die Kreativen? Sie bekommen die Reste.

Hier geht es nicht nur darum, ein paar nervige Werbespots zu überspringen.
Es geht darum, sich zu weigern, an einem System teilzunehmen, das von Ausbeutung, Ablenkung und der Kommerzialisierung deiner Aufmerksamkeit profitiert.

#### Was ist das?
Ein eleganter, kleiner Akt des digitalen Widerstands: ein sauberer, quelloffener Adblocker für Spotify, der den Lärm stoppt – im wahrsten Sinne des Wortes.

Keine dubiosen Mods, keine gehackten Clients, keine Malware, die sich als Freiheit tarnt. Nur ein Ziel: Die Musik soll spielen, ohne dass du von Werbung als Geisel gehalten wirst.

Spotify ist nicht kostenlos – du zahlst mit deiner Geduld.

Sie bombardieren dich immer wieder mit denselben nervigen Werbespots, bis du aufgibst und ein Abo abschließt. Nicht, weil du Premium liebst. Sondern weil du zermürbt wurdest. Das ist kein Freemium – das ist psychologische Kriegsführung mit einer Playlist.

Und die Künstler? Immer noch unterbezahlt.
Die Werbung? Lauter. Häufiger. Manchmal wortwörtlich lauter.
Du? Versuchst einfach, zu entspannen.

Sie profitieren von deiner Geduld und der Unterbezahlung der Kreativen, während sie so tun, als wäre das der einzige nachhaltige Weg. Spoiler: Ist es nicht. Sie hatten die Wahl – aber sie haben sich für Gewinnmargen statt für Menschen entschieden.

Spotify will dich glauben lassen, das sei der Preis für den Zugang.
Wir glauben, das ist eine Lüge.

Wir sind keine Piraten. Wir sind keine Kriminellen. Wir sind einfach Menschen, die finden, dass man irgendwann eine Grenze ziehen darf.

Bei diesem Projekt geht es nicht darum, ein paar Werbespots zu überspringen. Es geht darum, ein System abzulehnen, das sagt, dein Schweigen sei verkäuflich, dein Erlebnis dürfe unterbrochen werden und dein Wert beginne erst, wenn du deinen Geldbeutel öffnest.

Werbung zu blockieren ist kein Diebstahl.<br>
Deine Zeit zu stehlen schon.<br>
Wir sind nicht hier, um zu rauben. Wir sind hier, um abzulehnen.<br>
<br>
**Du würdest keine Werbung herunterladen. Aber du würdest eine blockieren.**
## Wie funktioniert eBAF?

eBAF (eBPF Ad Firewall) nutzt die Leistungsfähigkeit von eBPF (Extended Berkeley Packet Filter), um unerwünschte Werbung auf Kernel-Ebene zu blockieren. Hier ist ein Überblick auf hoher Ebene über seine Funktionsweise:

## Wie funktioniert eBAF?

eBAF (eBPF Ad Firewall) nutzt eBPF (Extended Berkeley Packet Filter), um Werbung effizient auf Kernel-Ebene zu blockieren. Hier eine vereinfachte Übersicht:

1. **Paketfilterung**:
   - Untersucht eingehende Netzwerkpakete und blockiert solche, die mit einer Blacklist von IP-Adressen übereinstimmen, mithilfe von XDP (eXpress Data Path).

2. **Dynamische Updates**:
   - Löst Domainnamen in IP-Adressen auf und aktualisiert die Blacklist dynamisch, um auch bei wechselnden Werbeservern wirksam zu bleiben.

3. **Web-Dashboard**:
   - Bietet Live-Statistiken und Überwachung über eine benutzerfreundliche Oberfläche.

4. **Hohe Leistung**:
   - Arbeitet direkt auf der Netzwerkschnittstellenebene und umgeht den Netzwerk-Stack des Kernels für schnellere Verarbeitung und minimalen Ressourcenverbrauch.

eBAF vereint Effizienz, Transparenz und Benutzerfreundlichkeit zu einer leistungsstarken Werbeblocker-Lösung.
## Einfache Installation (Empfohlen)
Stellen Sie sicher, dass git und curl installiert sind
```bash
git --version
curl --version
```
### Installation
#### Spotify-Integration aktivieren (Empfohlen)
```bash
EBAF_ENABLE_SPOTIFY=yes curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo -E bash
```
#### Explizit deaktivieren
```bash
EBAF_ENABLE_SPOTIFY=no curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo bash```
```

### Deinstallation
```bash
curl -sSL https://raw.githubusercontent.com/Kazedaa/eBAF/main/uninstall.sh | sudo bash
```
## Dev-Installation
Führen Sie die folgenden Befehle aus, um die erforderlichen Abhängigkeiten zu installieren:
### Ubuntu/Debian
```bash
sudo apt-get update
sudo apt-get install libbpf-dev clang llvm libelf-dev zlib1g-dev gcc make python3

sudo apt update
sudo apt install net-tools
```

### Fedora/CentOS/RHEL 8+
```bash
sudo dnf update
sudo dnf install -y libbpf-devel clang llvm elfutils-libelf-devel zlib-devel gcc make python3 net-tools bc
```

### Arch
```bash
sudo pacman -Syu
sudo pacman -S --needed libbpf clang llvm libelf zlib gcc make python net-tools bc
```

### Behebung des Fehlers asm/types.h beim Ausführen von eBPF-Code
Überprüfen Sie den aktuellen Link
`ls -l /usr/include/asm`
Finden Sie den korrekten Link
`find /usr/include -name "types.h" | grep asm`
Beheben Sie den symbolischen Link
```bash
sudo rm /usr/include/asm
sudo ln -s <aktueller_link> /usr/include/asm
```

### Projekt bauen

Um den eBPF Adblocker zu bauen, führen Sie die folgenden Schritte aus:

1. Klonen Sie das Repository:
   ```bash
   git clone <repository-url>
   cd eBAF
   ```
2. Projekt bauen:
   ```bash
   make
   ```

3. (Optional) Systemweit installieren:
   ```bash
   sudo make install
   ```

4. Weitere Installationsoptionen (Hilfe)
    ```bash
    make help
    ````
5. Deinstallation
    ```bash
    make uninstall
    ````

## Verwendung

### Ausführen des Adblockers
    Verwendet spotify-stable.txt als Standard-Blacklist.
    Verwendung: ebaf [OPTIONEN] [SCHNITTSTELLE...]
    OPTIONEN:
    -a, --all               Auf allen aktiven Schnittstellen ausführen
    -d, --default           Nur auf der Standard-Schnittstelle (mit Internetzugang) ausführen
    -i, --interface IFACE   Eine Schnittstelle angeben
    -D, --dash              Web-Dashboard starten (http://localhost:8080)
    -q, --quiet             Ausgabe unterdrücken (leiser Modus)
    -h, --help              Diese Hilfenachricht anzeigen


### Blacklist konfigurieren
Bearbeiten Sie die Listen, um Domains hinzuzufügen oder zu entfernen. Jede Domain sollte in einer eigenen Zeile stehen. Kommentare beginnen mit `#`.

## Danksagungen

Ein besonderer Dank an ❤️ <br>
1. [Isaaker's Spotify-AdsList](https://github.com/Isaaker/Spotify-AdsList/tree/main) <br>
2. [AnanthVivekanand's spotify-adblock](https://github.com/AnanthVivekanand/spotify-adblock)

für die Bereitstellung einer Spotify-Blockliste
## ⭐️ Unterstützen Sie das Projekt

Wenn Sie eBAF nützlich finden, erwägen Sie bitte, dem Repository auf GitHub einen Stern zu geben! Ihre Unterstützung hilft, die Sichtbarkeit zu erhöhen und fördert die weitere Entwicklung.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---