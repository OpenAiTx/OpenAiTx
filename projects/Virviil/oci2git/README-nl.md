<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
<img src="https://raw.githubusercontent.com/Virviil/oci2git/main/assets/logo.png" width="140px" />

# OCI2Git

[![Documentatie](https://docs.rs/oci2git/badge.svg)][documentation]
[![Crates.io](https://img.shields.io/crates/v/oci2git.svg)](https://crates.io/crates/oci2git)
[![Licentie](https://img.shields.io/crates/l/oci2git.svg)](https://github.com/Virviil/oci2git/blob/master/LICENSE)

[![Downloads](https://img.shields.io/crates/d/oci2git.svg)](https://crates.io/crates/oci2git)

[//]: # (mock voor toekomstige test.yaml)
[//]: # ([![Test Status]&#40;https://img.shields.io/github/actions/workflow/status/Virviil/oci2git/rust.yml?branch=master&event=push&label=Test&#41;]&#40;https://github.com/Virviil/oci2git/actions&#41;)

<div align="left"> </div>  
</div>

Een Rust-applicatie die container images (Docker, enz.) converteert naar Git-repositories en een filesystem bill of materials (fsbom) in YAML genereert. Elke containerlaag wordt weergegeven als een Git-commit, waarbij de geschiedenis en structuur van het oorspronkelijke image behouden blijven.

![Demo van OCI2Git die het nginx-image converteert](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## Functies

- Analyseer Docker-images en extraheer laaginformatie
- Maak een Git-repository waarbij elke imagelaag als een commit wordt weergegeven
- Genereer een YAML filesystem bill of materials (fsbom) met bestandslijsten per laag
- Ondersteuning voor lege lagen (ENV, WORKDIR, enz.) als lege commits
- Volledige metadata-extractie naar Markdown-formaat
- Uitbreidbare architectuur voor ondersteuning van verschillende container-engines

## Gebruiksscenario's

### Laagverschillen vergelijken
Bij het oplossen van containerproblemen kun je de krachtige vergelijkingsmogelijkheden van Git gebruiken om exact te identificeren wat er tussen twee lagen is gewijzigd. Door `git diff` tussen commits uit te voeren, kunnen engineers precies zien welke bestanden zijn toegevoegd, gewijzigd of verwijderd. Dit maakt het veel eenvoudiger om het effect van elke Dockerfile-instructie te begrijpen en problematische wijzigingen te lokaliseren.
![Voorbeeld van laagverschil](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### Herkomstbepaling
Met `git blame` kunnen ontwikkelaars snel bepalen welke laag een specifiek bestand of regel code heeft geïntroduceerd. Dit is vooral waardevol bij het diagnosticeren van problemen met configuratiebestanden of afhankelijkheden. In plaats van elke laag handmatig te inspecteren, kun je direct de herkomst van een bestand terugtraceren naar de bronlaag en bijbehorende Dockerfile-instructie.

### Volgen van bestandsgeschiedenis
OCI2Git stelt je in staat de reis van een specifiek bestand door de geschiedenis van het containerimage te volgen. Je kunt zien wanneer een bestand voor het eerst is aangemaakt, hoe het is aangepast in verschillende lagen en of/wanneer het uiteindelijk is verwijderd. Dit complete overzicht helpt om de evolutie van een bestand te begrijpen zonder handmatig wijzigingen over tientallen lagen te hoeven volgen.

Om de geschiedenis van een bestand in je containerimage te volgen — inclusief wanneer het voor het eerst verscheen, werd gewijzigd of verwijderd — kun je na conversie deze Git-commando's gebruiken:

```bash
# Full history of a file (including renames)
git log --follow -- /rootfs/my/file/path

# First appearance (i.e. creation) - see which layer introduced the file
git log --diff-filter=A -- /rootfs/my/file/path

# All changes made to the file (with diffs)
git log -p --follow -- /rootfs/my/file/path

# When the file was deleted
git log --diff-filter=D -- /rootfs/my/file/path

# Show short commit info (concise layer history)
git log --follow --oneline -- /rootfs/my/file/path
```

Deze commando's maken het eenvoudig om de volledige geschiedenis van elk bestand over containerlagen te traceren zonder de complexiteit van handmatig laag-tarballs uitpakken en vergelijken.

### Analyse over Meerdere Lagen
Soms zijn de meest inzichtelijke vergelijkingen afkomstig van het onderzoeken van wijzigingen over meerdere niet-opeenvolgende lagen. Met OCI2Git kun je de vergelijkingstools van Git gebruiken om te analyseren hoe componenten zich hebben ontwikkeld over verschillende build-stadia, waardoor patronen zichtbaar worden die onzichtbaar blijven bij het bekijken van alleen aangrenzende lagen.

### Laagverkenning
Door `git checkout` te gebruiken om naar een specifieke commit te gaan, kun je het container-bestandssysteem exact bekijken zoals het op dat moment in die laag bestond. Dit stelt ontwikkelaars in staat om de precieze staat van bestanden en mappen te inspecteren op elk punt in het creatieproces van de image, wat onschatbare context biedt bij het debuggen of onderzoeken van containergedrag.
![Checkout naar vorige commit](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/checkout.png)

### Analyse van Meerdere Images

Bij het werken met meerdere containerimages die een gemeenschappelijke oorsprong delen, maakt OCI2Git intelligent alleen branches aan wanneer de images daadwerkelijk uiteenlopen. Hierdoor kun je meerdere gerelateerde images in één repository analyseren terwijl hun gedeelde geschiedenis behouden blijft.

```bash
# Convert first image to create the base repository
oci2git postgres:16.9-alpine3.21 -o alp

# Convert second image to the same output folder
oci2git nginx:1.28.0-alpine-slim -o alp
```
OCI2Git detecteert automatisch gedeelde lagen tussen afbeeldingen en creëert een vertakkingsstructuur die hun gemeenschappelijke basis weerspiegelt. De Git-geschiedenis toont:
- Een gemeenschappelijke stam met alle gedeelde lagen
- Afzonderlijke takken die pas afwijken wanneer de afbeeldingen daadwerkelijk verschillen
- Duidelijke visualisatie van waar afbeeldingen een gemeenschappelijke afkomst delen en waar ze uniek worden
- Slimme duplicaatverwerking: als exact dezelfde afbeelding twee keer wordt verwerkt, detecteert het algoritme dit vóór de definitieve metadata-commit en slaat het maken van een dubbele tak over

Deze aanpak is bijzonder waardevol voor:
- **Afbeeldingsfamilie-analyse**: Begrijpen hoe verschillende varianten van een afbeelding (verschillende versies, architecturen of configuraties) zich tot elkaar verhouden
- **Impact van basisafbeelding**: Precies zien hoe wijzigingen aan een basisafbeelding invloed hebben op meerdere afgeleide afbeeldingen
- **Optimalisatiemogelijkheden**: Identificeren van gedeelde componenten die beter benut kunnen worden tussen afbeeldingsvarianten

![Structuur van multi-image repository met gedeelde basis en vertakkende takken](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### Aanvullende gebruiksscenario’s

- **Beveiligingsaudit**: Precies identificeren wanneer kwetsbare pakketten of configuraties zijn geïntroduceerd en deze herleiden tot specifieke build-instructies.
- **Afbeeldingsoptimalisatie**: Analyseer laagstructuren om dubbele handelingen of grote bestanden te vinden die geconsolideerd kunnen worden, wat helpt om de afbeeldingsgrootte te verkleinen.
- **Afhankelijkheidsbeheer**: Monitoren wanneer afhankelijkheden zijn toegevoegd, bijgewerkt of verwijderd in de afbeeldingsgeschiedenis.
- **Verbetering van het bouwproces**: Onderzoek de samenstelling van lagen om Dockerfile-instructies te optimaliseren voor betere caching en een kleinere afbeeldingsgrootte.
- **Cross-image vergelijking**: Converteer meerdere gerelateerde afbeeldingen naar Git-repositories en gebruik de vergelijkingstools van Git om hun verschillen en overeenkomsten te analyseren.

## Installatie

### Pakketbeheerders

#### macOS / Linux (Homebrew)


```bash
brew tap virviil/oci2git
brew install oci2git
```

#### Debian / Ubuntu

Download en installeer het .deb-pakket van de [laatste release](https://github.com/virviil/oci2git/releases/latest):

```bash
# For amd64 (x86_64)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_amd64.deb
sudo dpkg -i oci2git_VERSION_amd64.deb

# For arm64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_arm64.deb
sudo dpkg -i oci2git_VERSION_arm64.deb
```

#### Arch Linux (AUR)

```bash
# Using yay
yay -S oci2git-bin

# Using paru
paru -S oci2git-bin

# Manual installation
git clone https://aur.archlinux.org/oci2git-bin.git
cd oci2git-bin
makepkg -si
```

### Vooraf gebouwde Binaries

Download het juiste binary voor jouw platform van de [laatste release](https://github.com/virviil/oci2git/releases/latest):

```bash
# Linux x86_64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-linux-x86_64.tar.gz
tar xzf oci2git-linux-x86_64.tar.gz
sudo mv oci2git-linux-x86_64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git

# macOS (Apple Silicon)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-darwin-aarch64.tar.gz
tar xzf oci2git-darwin-aarch64.tar.gz
sudo mv oci2git-darwin-aarch64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git
```

### Van Crates.io

```bash
cargo install oci2git
```

### Van bron

```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

## Gebruik

```
oci2git [OPTIONS] <IMAGE>
oci2git convert [OPTIONS] <IMAGE>
oci2git fsbom [OPTIONS] <IMAGE>
```

### `convert` — OCI-afbeelding → Git-repository

```bash
oci2git convert [OPTIONS] <IMAGE>
# or simply:
oci2git <IMAGE>
```
Opties:
  `-o, --output <OUTPUT>`  Uitvoermap voor Git-repository [standaard: ./container_repo]
  `-e, --engine <ENGINE>`  Te gebruiken container-engine (docker, nerdctl, tar) [standaard: docker]
  `-v, --verbose`          Uitgebreide modus (-v voor info, -vv voor debug, -vvv voor trace)

### `fsbom` — Bestandsysteemstuklijst


```bash
oci2git fsbom [OPTIONS] <IMAGE>
```
Opties:
  `-o, --output <UITVOER>`  Uitvoerpad voor het YAML BOM-bestand [standaard: ./fsbom.yml]
  `-e, --engine <ENGINE>`   Te gebruiken container-engine (docker, nerdctl, tar) [standaard: docker]
  `-v, --verbose`           Uitgebreide modus (-v voor info, -vv voor debug, -vvv voor trace)

Omgevingsvariabelen:
  `TMPDIR`  Stel deze omgevingsvariabele in om de standaardlocatie voor tussentijdse gegevensverwerking te wijzigen. Dit is platformafhankelijk (bijv. `TMPDIR` op Unix/macOS, `TEMP` of `TMP` op Windows).

## Voorbeelden

### Converteren

Gebruik van Docker-engine (standaard):

```bash
oci2git ubuntu:latest
# or explicitly:
oci2git convert ubuntu:latest -o ./ubuntu-repo
```

Een reeds gedownloade image-tarball gebruiken:
```bash
oci2git convert -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```

De tar-engine verwacht een geldig OCI-formaat tarball, die meestal wordt aangemaakt met `docker save`:
```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git convert -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

Dit maakt een Git-repository aan in `./ubuntu-repo` met:
- `Image.md` - Volledige metadata over het image in Markdown-indeling
- `rootfs/` - De bestandssysteeminhoud uit de container

De Git-geschiedenis weerspiegelt de laaggeschiedenis van de container:
- De eerste commit bevat alleen het bestand `Image.md` met volledige metadata
- Elke volgende commit vertegenwoordigt een laag uit het originele image
- Commits bevatten de Dockerfile-opdracht als commitbericht

### Filesystem Bill of Materials (fsbom)

Genereer een YAML-overzicht van elk bestand dat is toegevoegd of gewijzigd per laag:
```bash
oci2git fsbom ubuntu:latest -o ubuntu.yml
```

Een tarball gebruiken:
```bash
oci2git fsbom -e tar image.tar -o image-bom.yml
```

De uitvoer YAML somt elke laag op met zijn entries getagd op type (`file`, `hardlink`, `symlink`, `directory`) en status (`n:uid:gid` voor nieuw, `m:uid:gid` voor gewijzigd). Verwijderde bestanden (OCI whiteouts) worden uitgesloten.

```yaml
layers:
  - index: 0
    command: "ADD rootfs.tar.gz / # buildkit"
    digest: "sha256:45f3ea58..."
    entries:
      - type: file
        path: "bin/busybox"
        size: 919304
        mode: 493
        stat: "n:0:0"
      - type: hardlink
        path: "bin/sh"
        target: "bin/busybox"
        stat: "n:0:0"
      - type: symlink
        path: "lib64"
        target: "lib"
        stat: "n:0:0"
  - index: 1
    command: "RUN apk add --no-cache curl"
    digest: "sha256:..."
    entries:
      - type: file
        path: "usr/bin/curl"
        size: 204800
        mode: 493
        stat: "n:0:0"
      - type: file
        path: "etc/apk/world"
        size: 32
        mode: 420
        stat: "m:0:0"
```

## Repositorystructuur

```
repository/
├── .git/
├── Image.md     # Complete image metadata
└── rootfs/      # Filesystem content from the container
```
## Vereisten

- Rust 2021 editie
- Docker CLI (voor Docker-engine ondersteuning)
- Git

## Licentie

MIT

[documentatie]: https://docs.rs/oci2git/




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-02

---