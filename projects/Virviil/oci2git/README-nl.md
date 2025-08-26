
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
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# OCI2Git

Een Rust-applicatie die containerafbeeldingen (Docker, enz.) converteert naar Git-repositories. Elke containerlaag wordt weergegeven als een Git-commit, waarbij de geschiedenis en structuur van de originele afbeelding behouden blijven.

![Demo van OCI2Git die het nginx-image converteert](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## Functies

- Analyseer Docker-images en extraheer laaginformatie
- Maak een Git-repository waarbij elke imagelaag wordt weergegeven als een commit
- Ondersteuning voor lege lagen (ENV, WORKDIR, enz.) als lege commits
- Volledige metadata-extractie naar Markdown-formaat
- Uitbreidbare architectuur voor ondersteuning van verschillende container-engines

## Gebruiksscenario's

### Laagverschillen
Bij het oplossen van problemen met containers kun je gebruikmaken van de krachtige diff-mogelijkheden van Git om precies te identificeren wat er is veranderd tussen twee lagen. Door `git diff` uit te voeren tussen commits, kunnen engineers exact zien welke bestanden zijn toegevoegd, gewijzigd of verwijderd, waardoor het veel eenvoudiger wordt om de impact van elke Dockerfile-instructie te begrijpen en problematische wijzigingen te lokaliseren.
![Voorbeeld van laagverschil](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### Oorsprongsherkomst
Met behulp van `git blame` kunnen ontwikkelaars snel bepalen welke laag een specifiek bestand of regel code heeft geïntroduceerd. Dit is bijzonder waardevol bij het diagnosticeren van problemen met configuratiebestanden of afhankelijkheden. In plaats van handmatig elke laag te inspecteren, kun je direct de oorsprong van elk bestand traceren naar de bronlaag en bijbehorende Dockerfile-instructie.

### Bestandslevenscyclus volgen
OCI2Git stelt je in staat om het traject van een specifiek bestand door de geschiedenis van de container-image te volgen. Je kunt zien wanneer een bestand oorspronkelijk is aangemaakt, hoe het is gewijzigd in verschillende lagen, en of/wanneer het uiteindelijk is verwijderd. Dit volledige overzicht helpt om de evolutie van bestanden te begrijpen zonder handmatig wijzigingen te hoeven volgen over mogelijk tientallen lagen.

Om de geschiedenis van een bestand in je container-image te volgen — inclusief wanneer het voor het eerst verscheen, werd gewijzigd of verwijderd — kun je deze Git-commando's gebruiken na conversie:

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

OCI2Git detecteert automatisch gedeelde lagen tussen images en creëert een vertakkingsstructuur die hun gemeenschappelijke basis weerspiegelt. De Git-geschiedenis toont:
- Een gemeenschappelijke stam die alle gedeelde lagen bevat
- Afzonderlijke takken die alleen afwijken wanneer de images daadwerkelijk verschillen
- Duidelijke visualisatie van waar images gemeenschappelijke oorsprong delen versus waar ze uniek worden
- Slimme duplicaatafhandeling: als exact dezelfde image tweemaal wordt verwerkt, detecteert het algoritme dit vóór de definitieve metadata-commit en slaat het aanmaken van een duplicaat-tak over

Deze aanpak is bijzonder waardevol voor:
- **Analyse van Image-families**: Begrijpen hoe verschillende varianten van een image (verschillende versies, architecturen of configuraties) zich tot elkaar verhouden
- **Impact van Basisimages**: Precies zien hoe wijzigingen aan een basisimage meerdere afgeleide images beïnvloeden
- **Optimalisatiemogelijkheden**: Identificeren van gedeelde componenten die beter benut kunnen worden tussen image-varianten

![Structuur van een multi-image repository met gedeelde basis en uiteenlopende takken](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### Aanvullende Gebruikstoepassingen

- **Security Auditing**: Identificeer precies wanneer kwetsbare pakketten of configuraties zijn geïntroduceerd en herleid ze naar specifieke build-instructies.
- **Image-optimalisatie**: Analyseer laagstructuren om dubbele handelingen of grote bestanden te vinden die kunnen worden samengevoegd, wat helpt om de image-grootte te verkleinen.
- **Dependency Management**: Houd bij wanneer afhankelijkheden zijn toegevoegd, geüpgraded of verwijderd gedurende de image-geschiedenis.
- **Verbetering van het Buildproces**: Onderzoek laagcompositie om Dockerfile-instructies te optimaliseren voor betere caching en kleinere image-grootte.
- **Vergelijking tussen Images**: Zet meerdere gerelateerde images om naar Git-repositories en gebruik Git's vergelijkingstools om hun verschillen en overeenkomsten te analyseren.

## Installatie

### Vanuit Broncode

```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

### Van Crates.io

```bash
cargo install oci2git
```

## Gebruik

```bash
oci2git [OPTIONS] <IMAGE>
```

Argumenten:
  `<IMAGE>`  Naam van het te converteren image (bijv. 'ubuntu:latest') of pad naar tarball bij gebruik van de tar-engine

Opties:
  `-o, --output <o>`  Uitvoermap voor Git-repository [standaard: ./container_repo]
  `-e, --engine <ENGINE>`  Te gebruiken container-engine (docker, nerdctl, tar) [standaard: docker]
  `-h, --help`            Print help-informatie
  `-V, --version`         Print versie-informatie

Omgevingsvariabelen:
  `TMPDIR`  Stel deze omgevingsvariabele in om de standaardlocatie voor tussentijdse gegevensverwerking te wijzigen. Dit is platformafhankelijk (bijv. `TMPDIR` op Unix/macOS, `TEMP` of `TMP` op Windows).

## Voorbeelden

Gebruik van Docker-engine (standaard):
```bash
oci2git -o ./ubuntu-repo ubuntu:latest
```

Een reeds gedownloade image-tarball gebruiken:
```bash
oci2git -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```

De tar-engine verwacht een geldig OCI-formaat tarball, die meestal wordt aangemaakt met `docker save`:
```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git -e tar -o ./ubuntu-repo ubuntu-latest.tar
```
Dit maakt een Git-repository aan in `./ubuntu-repo` met de volgende inhoud:
- `Image.md` - Complete metadata over het image in Markdown-formaat
- `rootfs/` - De bestandssysteeminhoud van de container

De Git-geschiedenis weerspiegelt de laaggeschiedenis van de container:
- De eerste commit bevat alleen het `Image.md`-bestand met volledige metadata
- Elke volgende commit vertegenwoordigt een laag van het originele image
- Commits bevatten het Dockerfile-commando als commitbericht

## Repositorystructuur


```
repository/
├── .git/
├── Image.md     # Complete image metadata
└── rootfs/      # Filesystem content from the container
```


## Vereisten

- Rust 2021-editie
- Docker CLI (voor ondersteuning van Docker-engine)
- Git

## Licentie

MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---