<p align="center"><img src="https://ohmyzsh.s3.amazonaws.com/omz-ansi-github.png" alt="Oh My Zsh"></p>

Oh My Zsh is een open source, door de community aangedreven framework voor het beheren van je [zsh](https://www.zsh.org/)
configuratie.

Klinkt saai. Laten we het nog eens proberen.

**Oh My Zsh maakt je geen 10x ontwikkelaar... maar je zult je er misschien wel één voelen.**

Na installatie wordt je terminal shell het gesprek van de dag _of je krijgt je geld terug!_ Met elke toetsaanslag
in je command prompt profiteer je van honderden krachtige plugins en prachtige thema's.
Vreemden komen naar je toe in cafés en vragen je: _"dat is geweldig! ben jij een soort genie?"_

Eindelijk krijg je de aandacht die je altijd al verdiende. ...of misschien gebruik je de tijd die je bespaart om vaker te flossen. 😬

Meer weten? Bezoek [ohmyz.sh](https://ohmyz.sh), volg [@ohmyzsh](https://x.com/ohmyzsh) op X (voorheen Twitter), en sluit je aan bij ons op [Discord](https://discord.gg/ohmyzsh).

[![CI](https://github.com/ohmyzsh/ohmyzsh/workflows/CI/badge.svg)](https://github.com/ohmyzsh/ohmyzsh/actions?query=workflow%3ACI)
[![X (formerly Twitter) Follow](https://img.shields.io/twitter/follow/ohmyzsh?label=%40ohmyzsh&logo=x&style=flat)](https://twitter.com/intent/follow?screen_name=ohmyzsh)
[![Mastodon Follow](https://img.shields.io/mastodon/follow/111169632522566717?label=%40ohmyzsh&domain=https%3A%2F%2Fmstdn.social&logo=mastodon&style=flat)](https://mstdn.social/@ohmyzsh)
[![Discord server](https://img.shields.io/discord/642496866407284746)](https://discord.gg/ohmyzsh)
[![Gitpod ready](https://img.shields.io/badge/Gitpod-ready-blue?logo=gitpod)](https://gitpod.io/#https://github.com/ohmyzsh/ohmyzsh)

<details>
<summary>Inhoudsopgave</summary>

- [Aan de slag](#getting-started)
  - [Compatibiliteit besturingssysteem](#operating-system-compatibility)
  - [Vereisten](#prerequisites)
  - [Basisinstallatie](#basic-installation)
    - [Handmatige inspectie](#manual-inspection)
- [Oh My Zsh gebruiken](#using-oh-my-zsh)
  - [Plugins](#plugins)
    - [Plugins inschakelen](#enabling-plugins)
    - [Plugins gebruiken](#using-plugins)
  - [Thema's](#themes)
    - [Een thema kiezen](#selecting-a-theme)
  - [FAQ](#faq)
- [Geavanceerde onderwerpen](#advanced-topics)
  - [Geavanceerde installatie](#advanced-installation)
    - [Aangepaste map](#custom-directory)
    - [Onbeheerde installatie](#unattended-install)
    - [Installeren vanuit een geforkte repository](#installing-from-a-forked-repository)
    - [Handmatige installatie](#manual-installation)
  - [Installatieproblemen](#installation-problems)
  - [Aangepaste plugins en thema's](#custom-plugins-and-themes)
  - [GNU ls inschakelen op macOS en freeBSD-systemen](#enable-gnu-ls-in-macos-and-freebsd-systems)
  - [Aliases overslaan](#skip-aliases)
  - [Async git prompt](#async-git-prompt)
- [Updaten](#getting-updates)
  - [Update-verbositeit](#updates-verbosity)
  - [Handmatig updaten](#manual-updates)
- [Oh My Zsh verwijderen](#uninstalling-oh-my-zsh)
- [Hoe draag ik bij aan Oh My Zsh?](#how-do-i-contribute-to-oh-my-zsh)
  - [Stuur ons geen thema's](#do-not-send-us-themes)
- [Bijdragers](#contributors)
- [Volg ons](#follow-us)
- [Merchandise](#merchandise)
- [Licentie](#license)
- [Over Planet Argon](#about-planet-argon)

</details>

## Aan de slag

### Compatibiliteit besturingssysteem

| O/S            | Status |
| :------------- | :----: |
| Android        |   ✅   |
| freeBSD        |   ✅   |
| LCARS          |   🛸   |
| Linux          |   ✅   |
| macOS          |   ✅   |
| OS/2 Warp      |   ❌   |
| Windows (WSL2) |   ✅   |

### Vereisten

- [Zsh](https://www.zsh.org) moet geïnstalleerd zijn (v4.3.9 of nieuwer is goed, maar we geven de voorkeur aan 5.0.8 en nieuwer). Indien niet vooraf geïnstalleerd (voer `zsh --version` uit om te bevestigen), bekijk dan de volgende wiki-instructies: [ZSH installeren](https://github.com/ohmyzsh/ohmyzsh/wiki/Installing-ZSH)
- `curl` of `wget` moet geïnstalleerd zijn
- `git` moet geïnstalleerd zijn (aanbevolen v2.4.11 of hoger)

### Basisinstallatie

Oh My Zsh wordt geïnstalleerd door een van de volgende commando's in je terminal uit te voeren. Je kunt dit installeren via de command-line met `curl`, `wget` of een vergelijkbaar programma.

| Methode    | Commando                                                                                           |
| :--------- | :------------------------------------------------------------------------------------------------ |
| **curl**   | `sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |
| **wget**   | `sh -c "$(wget -O- https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`   |
| **fetch**  | `sh -c "$(fetch -o - https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |

Daarnaast is de installer ook buiten GitHub gespiegeld. Gebruik deze URL als je je in een land als China of India bevindt (voor bepaalde providers) die `raw.githubusercontent.com` blokkeert:

| Methode    | Commando                                           |
| :--------- | :------------------------------------------------- |
| **curl**   | `sh -c "$(curl -fsSL https://install.ohmyz.sh/)"`  |
| **wget**   | `sh -c "$(wget -O- https://install.ohmyz.sh/)"`    |
| **fetch**  | `sh -c "$(fetch -o - https://install.ohmyz.sh/)"`  |

_Let op: een eventuele eerdere `.zshrc` wordt hernoemd naar `.zshrc.pre-oh-my-zsh`. Na installatie kun je de configuratie die je wilt behouden overzetten naar de nieuwe `.zshrc`._

#### Handmatige inspectie

Het is verstandig om het installatiescript van projecten die je nog niet kent te bekijken. Je kunt dit doen door eerst het installatiescript te downloaden, het te bekijken zodat alles normaal lijkt, en het vervolgens uit te voeren:

```sh
wget https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh
sh install.sh
```

Als de bovenstaande URL niet werkt of time-out, moet je mogelijk de URL vervangen door
`https://install.ohmyz.sh` om het script te kunnen ophalen.

## Oh My Zsh gebruiken

### Plugins

Oh My Zsh wordt geleverd met een enorme hoeveelheid plugins waar je gebruik van kunt maken. Je kunt een kijkje nemen in de [plugins](https://github.com/ohmyzsh/ohmyzsh/tree/master/plugins) map en/of de [wiki](https://github.com/ohmyzsh/ohmyzsh/wiki/Plugins) om te zien wat er momenteel beschikbaar is.

#### Plugins inschakelen

Als je een plugin (of meerdere) hebt gevonden die je wilt gebruiken met Oh My Zsh, moet je deze inschakelen in het `.zshrc` bestand. Je vindt het zshrc-bestand in je `$HOME` directory. Open het met je favoriete teksteditor en je ziet daar een plek om alle plugins te vermelden die je wilt laden.

```sh
vi ~/.zshrc
```

Bijvoorbeeld, dit zou er zo uit kunnen gaan zien:

```sh
plugins=(
  git
  bundler
  dotenv
  macos
  rake
  rbenv
  ruby
)
```

_Let op: de plugins worden gescheiden door spaties, tabs of nieuwe regels. **Gebruik geen** komma's ertussen, anders werkt het niet._

#### Plugins gebruiken

Elke ingebouwde plugin bevat een **README** die het documenteert. Deze README toont de aliassen (indien de plugin die toevoegt) en extra functionaliteiten die in die specifieke plugin zijn opgenomen.

### Thema's

We geven het toe. In het begin van de Oh My Zsh-wereld waren we misschien iets te enthousiast met thema's. We hebben nu meer dan honderdvijftig thema's gebundeld. De meeste hebben [screenshots](https://github.com/ohmyzsh/ohmyzsh/wiki/Themes) op de wiki (We werken eraan om deze bij te werken!). Bekijk ze gerust!

#### Een thema kiezen

_Robby's thema is het standaardthema. Het is niet het meest opvallende. Het is niet het simpelste. Het is gewoon het juiste (voor hem)._

Als je een thema hebt gevonden dat je wilt gebruiken, moet je het `~/.zshrc` bestand bewerken. Je ziet daar een omgevingsvariabele (in hoofdletters) die er zo uitziet:

```sh
ZSH_THEME="robbyrussell"
```

Om een ander thema te gebruiken, verander je simpelweg de waarde naar de naam van je gewenste thema. Bijvoorbeeld:

```sh
ZSH_THEME="agnoster" # (dit is een van de fancy thema's)
# zie https://github.com/ohmyzsh/ohmyzsh/wiki/Themes#agnoster
```

<!-- prettier-ignore-start -->
> [!OPMERKING]
> Je zult vaak screenshots zien van een zsh-thema, het proberen, en merken dat het er bij jou anders uitziet.
>
> Dit komt omdat veel thema's een [Powerline Font](https://github.com/powerline/fonts) of een
> [Nerd Font](https://github.com/ryanoasis/nerd-fonts) vereisen om correct weer te geven. Zonder deze fonts tonen de thema's vreemde prompt-symbolen. Zie
> [de FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#i-have-a-weird-character-in-my-prompt) voor meer informatie.
>
> Let op: thema's bepalen alleen hoe je prompt eruitziet. Dat is de tekst die je vóór of na je cursor ziet, waar je je commando's typt. Thema's bepalen niet de kleuren van je terminalvenster (ook wel _color scheme_ genoemd) of het lettertype van je terminal. Deze instellingen kun je wijzigen in je terminalemulator. Meer informatie: [wat is een zsh-thema](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#what-is-a-zsh-theme).
<!-- prettier-ignore-end -->

Open een nieuw terminalvenster en je prompt zou er ongeveer zo uit moeten zien:

![Agnoster theme](https://cloud.githubusercontent.com/assets/2618447/6316862/70f58fb6-ba03-11e4-82c9-c083bf9a6574.png)

Heb je geen geschikt thema gevonden, kijk dan op de wiki voor [meer thema's](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes).

Voel je je avontuurlijk, dan kun je de computer bij elke nieuwe terminalsessie willekeurig een thema laten kiezen.

```sh
ZSH_THEME="random" # (...laat het alsjeblieft pie zijn... alsjeblieft pie..)
```

En als je een willekeurig thema wilt kiezen uit een lijst met je favoriete thema's:

```sh
ZSH_THEME_RANDOM_CANDIDATES=(
  "robbyrussell"
  "agnoster"
)
```

Weet je alleen welke thema's je niet leuk vindt, dan kun je deze op een vergelijkbare manier op een negeerlijst zetten:

```sh
ZSH_THEME_RANDOM_IGNORED=(pygmalion tjkirch_mod)
```

### FAQ

Heb je nog vragen of problemen, dan vind je mogelijk een oplossing in onze [FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ).

## Geavanceerde onderwerpen

Als je graag de handen uit de mouwen steekt, zijn deze secties voor jou.

### Geavanceerde installatie

Sommige gebruikers willen Oh My Zsh handmatig installeren, of het standaardpad of andere instellingen aanpassen die de installer accepteert (deze instellingen staan ook bovenaan het installatiescript beschreven).

#### Aangepaste map

De standaardlocatie is `~/.oh-my-zsh` (verborgen in je home-directory, je kunt er naartoe via `cd ~/.oh-my-zsh`)

Wil je de installatiemap wijzigen met de `ZSH` omgevingsvariabele, doe dit dan door `export ZSH=/jouw/pad` uit te voeren voor de installatie, of stel het in voor het einde van de installatiepipeline:

```sh
ZSH="$HOME/.dotfiles/oh-my-zsh" sh install.sh
```

#### Onbeheerde installatie

Als je het Oh My Zsh installatiescript uitvoert als onderdeel van een geautomatiseerde installatie, kun je de `--unattended` vlag toevoegen aan het `install.sh` script. Dit zorgt ervoor dat de standaard shell niet wordt gewijzigd, en `zsh` wordt ook niet automatisch gestart na installatie.

```sh
sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)" "" --unattended
```

Als je je in China, India of een ander land bevindt dat `raw.githubusercontent.com` blokkeert, moet je mogelijk de URL vervangen door `https://install.ohmyz.sh` om te kunnen installeren.

#### Installeren vanuit een geforkte repository

Het installatiescript accepteert ook deze variabelen om installatie van een andere repository mogelijk te maken:

- `REPO` (standaard: `ohmyzsh/ohmyzsh`): dit heeft de vorm `eigenaar/repository`. Als je deze variabele instelt, zoekt de installer naar een repository op `https://github.com/{owner}/{repository}`.

- `REMOTE` (standaard: `https://github.com/${REPO}.git`): dit is de volledige URL van de git repository clone. Gebruik deze instelling als je wilt installeren vanaf een fork die niet op GitHub staat (GitLab, Bitbucket...) of als je via SSH wilt klonen in plaats van HTTPS (`git@github.com:user/project.git`).

  _OPMERKING: dit is niet compatibel met het instellen van de `REPO` variabele. Deze instelling heeft voorrang._

- `BRANCH` (standaard: `master`): gebruik deze instelling als je de standaardbranch wilt wijzigen die wordt uitgecheckt bij het klonen van de repository. Dit is handig voor het testen van een Pull Request of als je een andere branch dan `master` wilt gebruiken.

Bijvoorbeeld:

```sh
REPO=apjanke/oh-my-zsh BRANCH=edge sh install.sh
```

#### Handmatige installatie

##### 1. Clone de repository <!-- omit in toc -->

```sh
git clone https://github.com/ohmyzsh/ohmyzsh.git ~/.oh-my-zsh
```

##### 2. _Optioneel_, maak een back-up van je bestaande `~/.zshrc` bestand <!-- omit in toc -->

```sh
cp ~/.zshrc ~/.zshrc.orig
```

##### 3. Maak een nieuw Zsh-configuratiebestand <!-- omit in toc -->

Je kunt een nieuw zsh-configuratiebestand aanmaken door de meegeleverde template te kopiëren.

```sh
cp ~/.oh-my-zsh/templates/zshrc.zsh-template ~/.zshrc
```

##### 4. Wijzig je standaard shell <!-- omit in toc -->

```sh
chsh -s $(which zsh)
```

Je moet uitloggen en opnieuw inloggen om deze wijziging te zien.

##### 5. Initialiseer je nieuwe Zsh-configuratie <!-- omit in toc -->

Zodra je een nieuw terminalvenster opent, zou zsh met de configuratie van Oh My Zsh geladen moeten worden.

### Installatieproblemen

Heb je problemen bij de installatie, dan zijn hier enkele veelvoorkomende oplossingen.

- Je _moet_ mogelijk je `PATH` aanpassen in `~/.zshrc` als je bepaalde commando's niet kunt vinden na het overschakelen naar `oh-my-zsh`.
- Als je handmatig hebt geïnstalleerd of de installatielocatie hebt gewijzigd, controleer dan de `ZSH` omgevingsvariabele in `~/.zshrc`.

### Aangepaste plugins en thema's

Wil je standaardgedrag overschrijven, voeg dan een nieuw bestand toe (eindigend op `.zsh`) in de `custom/` map.

Heb je meerdere functies die goed samengaan, plaats ze dan als een `XYZ.plugin.zsh` bestand in de `custom/plugins/` map en schakel deze plugin in.

Wil je de functionaliteit van een meegeleverde plugin overschrijven, maak dan een plugin met dezelfde naam aan in de `custom/plugins/` map; deze wordt dan in plaats van die in `plugins/` geladen.

### GNU ls inschakelen op macOS en freeBSD-systemen

<a name="enable-gnu-ls"></a>

Standaard gebruikt Oh My Zsh BSD `ls` op macOS en FreeBSD-systemen. Als GNU `ls` is geïnstalleerd (als `gls` commando), kun je ervoor kiezen dit te gebruiken. Hiervoor kun je deze zstyle-gebaseerde configuratie gebruiken vóór het sourcen van `oh-my-zsh.sh`:

```zsh
zstyle ':omz:lib:theme-and-appearance' gnu-ls yes
```

_Let op: dit is niet compatibel met `DISABLE_LS_COLORS=true`_

### Aliases overslaan

<a name="remove-directories-aliases"></a>

Wil je standaard Oh My Zsh aliassen (die in `lib/*` bestanden staan) of plugin-aliassen overslaan, gebruik dan onderstaande instellingen in je `~/.zshrc` bestand, **voordat Oh My Zsh wordt geladen**. Er zijn verschillende manieren om aliassen over te slaan, afhankelijk van je behoeften.

```sh
# Sla alle aliassen over, zowel in lib-bestanden als ingeschakelde plugins
zstyle ':omz:*' aliases no

# Sla alle aliassen in lib-bestanden over
zstyle ':omz:lib:*' aliases no
# Sla alleen aliassen over die zijn gedefinieerd in het directories.zsh lib-bestand
zstyle ':omz:lib:directories' aliases no

# Sla alle plugin-aliassen over
zstyle ':omz:plugins:*' aliases no
# Sla alleen de aliassen van de git-plugin over
zstyle ':omz:plugins:git' aliases no
```

Je kunt deze op verschillende manieren combineren. Meer specifieke scopes hebben voorrang:

```sh
# Sla alle plugin-aliassen over, behalve die van de git-plugin
zstyle ':omz:plugins:*' aliases no
zstyle ':omz:plugins:git' aliases yes
```

Een eerdere versie van deze functionaliteit gebruikte de onderstaande instelling, die is verwijderd:

```sh
zstyle ':omz:directories' aliases no
```

Gebruik nu het volgende:

```sh
zstyle ':omz:lib:directories' aliases no
```

#### Opmerking <!-- omit in toc -->

> Deze functionaliteit bevindt zich momenteel in een testfase en kan in de toekomst wijzigen. Het is ook niet compatibel met pluginmanagers zoals zpm of zinit, die het init-script (`oh-my-zsh.sh`) niet sourcen waarin deze feature is geïmplementeerd.

> Het is momenteel ook niet op de hoogte van "aliassen" die als functies zijn gedefinieerd. Voorbeelden hiervan zijn functies als `gccd`, `ggf`, of `ggl` uit de git-plugin.

### Async git prompt

Async prompt-functies zijn een experimentele functie (toegevoegd op 3 april 2024) waarmee Oh My Zsh prompt-informatie asynchroon kan weergeven. Dit kan de prestaties van de prompt verbeteren, maar werkt mogelijk niet goed in sommige setups. Hopelijk is dat geen probleem, maar als je problemen ondervindt met deze functie, kun je het uitschakelen door het volgende in je .zshrc te zetten vóór het laden van Oh My Zsh:

```sh
zstyle ':omz:alpha:lib:git' async-prompt no
```

Als je probleem is dat de git prompt helemaal niet meer verschijnt, probeer dan het volgende vóór het sourcen van `oh-my-zsh.sh`. Werkt het nog steeds niet, open dan een issue met jouw situatie.

```sh
zstyle ':omz:alpha:lib:git' async-prompt force
```

## Updaten

Standaard word je elke 2 weken gevraagd om te controleren op updates. Je kunt andere updatemodi kiezen door een regel toe te voegen aan je `~/.zshrc` bestand, **voordat Oh My Zsh wordt geladen**:

1. Automatische update zonder bevestigingsprompt:

   ```sh
   zstyle ':omz:update' mode auto
   ```

2. Alleen een herinnering geven om de paar dagen, als er updates zijn:

   ```sh
   zstyle ':omz:update' mode reminder
   ```

3. Automatische updates volledig uitschakelen:

   ```sh
   zstyle ':omz:update' mode disabled
   ```

OPMERKING: je kunt bepalen hoe vaak Oh My Zsh op updates controleert met deze instelling:

```sh
# Dit controleert elke 7 dagen op updates
zstyle ':omz:update' frequency 7
# Dit controleert bij elke terminalsessie op updates (niet aanbevolen)
zstyle ':omz:update' frequency 0
```

### Update-verbositeit

Je kunt ook de hoeveelheid update-informatie beperken met de volgende instellingen:

```sh
zstyle ':omz:update' verbose default # standaard update prompt

zstyle ':omz:update' verbose minimal # slechts een paar regels

zstyle ':omz:update' verbose silent # alleen fouten
```

### Handmatig updaten

Wil je op elk moment updaten (bijvoorbeeld als er net een nieuwe plugin is uitgebracht en je niet wilt wachten), voer dan uit:

```sh
omz update
```

> [!OPMERKING]
> Wil je dit proces automatiseren in een script, roep dan direct het `upgrade` script aan, als volgt:
>
> ```sh
> $ZSH/tools/upgrade.sh
> ```
>
> Zie meer opties in de [FAQ: Hoe update ik Oh My Zsh?](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#how-do-i-update-oh-my-zsh).
>
> **HET GEBRUIK VAN `omz update --unattended` IS VERWIJDERD, OMDAT DIT BIJWERKINGEN HEEFT**.

Magie! 🎉

## Oh My Zsh verwijderen

Oh My Zsh is niet voor iedereen. We zullen je missen, maar we willen het je makkelijk maken om afscheid te nemen.

Wil je `oh-my-zsh` verwijderen, voer dan `uninstall_oh_my_zsh` uit vanaf de command-line. Hiermee wordt alles verwijderd en je eerdere `bash`- of `zsh`-configuratie hersteld.

## Hoe draag ik bij aan Oh My Zsh?

Voordat je deelneemt aan onze geweldige community, lees de [gedragscode](CODE_OF_CONDUCT.md).

Ik ben verre van een [Zsh](https://www.zsh.org/) expert en vermoed dat er veel manieren zijn om te verbeteren – heb je ideeën om de configuratie makkelijker onderhoudbaar (en sneller) te maken, aarzel dan niet om te forken en pull requests te sturen!

We hebben ook mensen nodig die pull requests testen. Bekijk [de open issues](https://github.com/ohmyzsh/ohmyzsh/issues) en help waar je kunt.

Zie [Contributing](CONTRIBUTING.md) voor meer details.

### Stuur ons geen thema's

We hebben (meer dan) genoeg thema's voor nu. Voeg je thema toe aan de [externe thema's](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes) wiki-pagina.

## Bijdragers

Oh My Zsh heeft een bruisende community van tevreden gebruikers en fantastische bijdragers. Zonder de tijd en hulp van onze bijdragers zou het niet zo geweldig zijn.

Heel erg bedankt!

<a href="https://github.com/ohmyzsh/ohmyzsh/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ohmyzsh/ohmyzsh" width="100%"/>
</a>

## Volg ons

We zijn actief op sociale media:

- [@ohmyzsh](https://x.com/ohmyzsh) op X (voorheen Twitter). Je zou ons moeten volgen.
- [Facebook](https://www.facebook.com/Oh-My-Zsh-296616263819290/) geef ons een poke.
- [Instagram](https://www.instagram.com/_ohmyzsh/) tag ons in je post waarin je Oh My Zsh laat zien!
- [Discord](https://discord.gg/ohmyzsh) om met ons te chatten!

## Merchandise

We hebben [stickers, shirts en koffiemokken](https://shop.planetargon.com/collections/oh-my-zsh?utm_source=github) zodat je je liefde voor Oh My Zsh kunt tonen. Wederom: je wordt het gesprek van de dag!

## Licentie

Oh My Zsh is uitgebracht onder de [MIT-licentie](LICENSE.txt).

## Over Planet Argon

![Planet Argon](https://pa-github-assets.s3.amazonaws.com/PARGON_logo_digital_COL-small.jpg)

Oh My Zsh is gestart door het team van [Planet Argon](https://www.planetargon.com/?utm_source=github), een [Ruby on Rails ontwikkelbureau](https://www.planetargon.com/services/ruby-on-rails-development?utm_source=github).
Bekijk onze [andere open source projecten](https://www.planetargon.com/open-source?utm_source=github).


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---