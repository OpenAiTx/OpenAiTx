# eBAF - eBPF Gebaseerde Ad Firewall
<p align="center">
    <img src="https://raw.githubusercontent.com/Kazedaa/eBAF/main/assets/banner.png" alt="eBAF - eBPF Ad Firewall Banner" width="600"/>
</p>

## "Je Zou Geen Advertentie Downloaden"
### Maar Je Zou Er Wel Een Blokkeren!
 
Spotify heeft een imperium opgebouwd op basis van een simpele formule: jouw aandacht gelde maken, artiesten onderbetalen, en je vervolgens je eigen tijd terugverkopen als premiumfunctie.
In hun wereld is jouw luisterervaring niet van jou. Het is een zorgvuldig samengestelde marktplaats — jouw oren zijn het product, jouw geduld is de valuta.

Ze noemen het graag een "gratis" tier.
Maar laten we eerlijk zijn: het is niet gratis als je betaalt met je tijd.

Ondertussen verdienen de artiesten van wie je houdt — de mensen wiens werk het platform draaiende houdt — vaak slechts fracties van centen per stream. Spotify maakt flinke winst, de adverteerders krijgen hun exposure, en de makers? Die krijgen de kruimels.

Dit gaat niet alleen over het overslaan van een paar irritante advertenties.
Het gaat erom dat je weigert mee te doen aan een systeem dat winst maakt uit uitbuiting, afleiding, en het verhandelen van jouw aandacht.

#### Wat is dit?
Een elegant klein stukje digitale weerstand: een schone, open-source adblocker voor Spotify die het lawaai stopt — letterlijk.

Geen dubieuze mods, geen gekraakte clients, geen malware vermomd als vrijheid. Slechts één doel: laat de muziek spelen zonder gegijzeld te worden door advertenties.

Spotify is niet gratis — je betaalt met je geduld.

Ze bestoken je met dezelfde irritante advertenties, keer op keer, totdat je het opgeeft en een abonnement neemt. Niet omdat je van Premium houdt. Maar omdat je bent uitgeput. Dat is geen freemium — dat is psychologische oorlogsvoering met een afspeellijst.

Ondertussen, de artiesten? Nog steeds onderbetaald.
De advertenties? Harder. Vaker. Soms letterlijk harder.
Jij? Probeert gewoon te genieten.

Zij profiteren van jouw geduld en hun onderbetaling van makers, terwijl ze doen alsof dit de enige duurzame manier is. Spoiler: dat is het niet. Ze hadden een keuze — maar ze kozen voor winst boven mensen.

Spotify wil dat je gelooft dat dit de prijs van toegang is.
Wij geloven dat dat een leugen is.

Wij zijn geen piraten. Wij zijn geen criminelen. Wij zijn gewoon mensen die vinden dat het oké is om een grens te trekken.

Dit project draait niet om het overslaan van een paar advertenties. Het gaat om het afwijzen van een systeem dat zegt dat jouw stilte verkocht kan worden, jouw ervaring onderbroken mag worden, en jouw waarde pas begint wanneer je je portemonnee trekt.

Advertenties blokkeren is geen diefstal.<br>
Je tijd stelen wel.<br>
We zijn niet hier om te pirateren. We zijn hier om ons af te melden.<br>
<br>
**Je zou geen advertentie downloaden. Maar je zou er wel één blokkeren.**
## Hoe werkt eBAF?

eBAF (eBPF Ad Firewall) maakt gebruik van de kracht van eBPF (Extended Berkeley Packet Filter) om ongewenste advertenties op kernel-niveau te blokkeren. Hier is een overzicht op hoog niveau van de functionaliteit:

## Hoe werkt eBAF?

eBAF (eBPF Ad Firewall) gebruikt eBPF (Extended Berkeley Packet Filter) om advertenties efficiënt op kernel-niveau te blokkeren. Hier is een vereenvoudigd overzicht:

1. **Packet Filtering**:
   - Inspecteert binnenkomende netwerkpakketten en blokkeert deze als ze overeenkomen met een blacklist van IP-adressen met behulp van XDP (eXpress Data Path).

2. **Dynamische Updates**:
   - Zet domeinnamen om naar IP-adressen en werkt de blacklist dynamisch bij om effectief te blijven tegen veranderende advertentie-servers.

3. **Webdashboard**:
   - Biedt live statistieken en monitoring via een gebruiksvriendelijke interface.

4. **Hoge Prestaties**:
   - Werkt direct op het netwerkinterfaceniveau en omzeilt de netwerkstack van de kernel voor snellere verwerking en minimaal gebruik van systeembronnen.

eBAF combineert efficiëntie, transparantie en gebruiksgemak tot een krachtige advertentieblokkeringsoplossing.
## Eenvoudige Installatie (Aanbevolen)
Zorg ervoor dat git en curl geïnstalleerd zijn
```bash
git --version
curl --version
```
### Installeren
#### Spotify-integratie inschakelen (Aanbevolen)
```bash
EBAF_ENABLE_SPOTIFY=yes curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo -E bash
```
#### Expliciet uitschakelen
```bash
EBAF_ENABLE_SPOTIFY=no curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo bash```
```

### Verwijderen
```bash
curl -sSL https://raw.githubusercontent.com/Kazedaa/eBAF/main/uninstall.sh | sudo bash
```
## Dev Install
Voer de volgende commando's uit om de vereiste afhankelijkheden te installeren:
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

### Los asm/types.h Fout op tijdens het uitvoeren van eBPF-code
Controleer de huidige link
`ls -l /usr/include/asm`
Vind de juiste link
`find /usr/include -name "types.h" | grep asm`
Herstel de symbolische link
```bash
sudo rm /usr/include/asm
sudo ln -s <huidige_link> /usr/include/asm
```

### Het Project Bouwen

Om de eBPF Adblocker te bouwen, volg deze stappen:

1. Clone de repository:
   ```bash
   git clone <repository-url>
   cd eBAF
   ```
2. Bouw het project:
   ```bash
   make
   ```

3. (Optioneel) Installeer systeemwijd:
   ```bash
   sudo make install
   ```

4. Andere installatie-opties (helpdesk)
    ```bash
    make help
    ````
5. Deïnstalleren
    ```bash
    make uninstall
    ````
## Gebruik

### De Adblocker uitvoeren
    Gebruikt spotify-stable.txt als standaardzwarte lijst.
    Gebruik: ebaf [OPTIES] [INTERFACE...]
    OPTIES:
    -a, --all               Draai op alle actieve interfaces
    -d, --default           Draai alleen op de standaardinterface (met internettoegang)
    -i, --interface IFACE   Specificeer een te gebruiken interface
    -D, --dash              Start het webdashboard (http://localhost:8080)
    -q, --quiet             Onderdruk uitvoer (stille modus)
    -h, --help              Toon dit helpbericht


### Zwarte lijst configureren
Bewerk de lijsten om domeinen toe te voegen of te verwijderen. Elk domein moet op een aparte regel staan. Commentaar begint met `#`.

## Dankbetuigingen

Een speciale dank aan ❤️ <br>
1. [Isaaker's Spotify-AdsList](https://github.com/Isaaker/Spotify-AdsList/tree/main) <br>
2. [AnanthVivekanand's spotify-adblock](https://github.com/AnanthVivekanand/spotify-adblock)

voor het leveren van een Spotify-blokkeerlijst
## ⭐️ Ondersteun het project

Als je eBAF nuttig vindt, overweeg dan om de repository te waarderen met een ster op GitHub! Jouw steun helpt de zichtbaarheid te vergroten en stimuleert verdere ontwikkeling.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---