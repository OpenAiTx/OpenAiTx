
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=th">Thai</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Rosetta Stonks

- [Introductie](#introductie)
- [Installeren](#installeren)
  - [Chrome](#chrome-gebaseerde-browsers)
    - [Visuele Gids](#chrome-gebaseerde-browsers)
  - [Firefox](#firefox-gebaseerde-browsers)
- [Hoe te gebruiken](#hoe-te-gebruiken)
  - [Tijd toevoegen](#tijd-toevoegen)
    - [Foundations](#tijd-toevoegen-in-foundations)
    - [Fluency builder](#tijd-toevoegen-in-fluency-builder)
  - [Les valideren](#les-valideren)
    - [Foundations](#les-valideren-in-foundations)
    - [Fluency builder](#les-valideren-in-fluency-builder)

## Introductie

RosettaStonks is een browserextensie waarmee je tijd kunt toevoegen en lessen kunt valideren op het Rosetta Stone taal leerplatform.

> RosettaStonks, en jouw Rosetta Stone gaat stonks.

## Installeren

### Chrome gebaseerde browsers

➡️ **Nieuw in het handmatig installeren van Chrome-extensies?** Bekijk de [Stapsgewijze Visuele Handleiding](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md) — bevat handige screenshots! 🖼️

#### 1. Gebruik van GitHub Release

Om de extensie in een Chrome-gebaseerde browser te gebruiken, moet je:

- het bestand `rosettastonks-chrome.tar.gz` downloaden van de laatste release op
  je computer.
- een map maken met de naam `rosettastonks` ergens op je computer om de
  extensie in op te slaan
- het volgende commando uitvoeren in de map `rosettastonks`.


```bash
$ tar xvzf /path/to/rosettastonks-chrome.tar.gz
```

2. Gebruik maken van de nix pakketbeheerder

In plaats van de vorige commando's, als je op een nix-systeem zit dat **flakes ondersteunt**,
kun je de volgende commando's uitvoeren, die een map zullen installeren
onder het pad `/tmp/rosettastonks` met alle bestanden.

```bash
$ nix build --out-link "/tmp/rosettastonks" github:m1dugh/RosettaStonks#chrome
```

De map is nu geïnstalleerd onder `/tmp/rosettastonks/`

**Dit deel is voor alle gebruikers, ongeacht of je de github-methode
of de nix-methode gebruikt.**

In je browser:

- ga naar `chrome://extensions`
- schakel de optie `Developer mode` in
- klik op `Load unpacked`
- Selecteer je `rosettastonks`-map

### Firefox-gebaseerde browsers

- download het bestand `rosettastonks.xpi` van de laatste release.
- als alternatief, als je de nix package manager met flake-ondersteuning gebruikt, kun je
  het volgende commando uitvoeren.

```bash
$ nix build --out-link "/tmp/rosettatonks.xpi" github:m1dugh/RosettaStonks#mozilla
```

- ga naar `about:debugging#/runtime/this-firefox` in je browser
- klik op de instellingenknop en ga naar `Debug addons`.
- klik op `Load Temporary Add-On`
- selecteer het `/tmp/rosettastonks.xpi` bestand in de bestandskiezer.

_Waarschuwing: Deze methode installeert de extensie slechts tijdelijk, wat betekent dat als
je je browser sluit, de addon wordt verwijderd. Dit komt door het beleid van Firefox
dat het gebruik van niet-geverifieerde extensies niet toestaat._

## Hoe te gebruiken

### Tijd toevoegen

#### Tijd toevoegen in Foundations

Om tijd toe te voegen aan het `foundations` product, moet je naar je oefeningen gaan en
ten minste één vraag negeren of oplossen. Zodra dit is gedaan, zou er een tijdveld
moeten verschijnen op de extensiepagina waarop je je tijd kunt toevoegen.

#### Tijd toevoegen in Fluency builder

Om tijd toe te voegen aan het `fluency builder` product, moet je naar je oefeningen gaan en
minstens één oefening beantwoorden. Als het tijd toevoegen-veld niet verschijnt, betekent
dit dat er geen tijdsverzoek is geregistreerd; je moet de vraag verversen en opnieuw
beantwoorden. Om de tijd toe te voegen, moet je de les afronden waarin je tijd hebt
toegevoegd.

_Noot: Als je het tijd toevoegen-veld niet ziet, betekent dit dat de acties die je hebt
ondernomen op de Rosetta Stone-website niet hebben geleid tot het toevoegen van geldige tijd,
en moet je andere vragen beantwoorden._

### Les valideren

#### Les valideren in Foundations

Om een les te valideren, moet je een les starten en alle vragen doorlopen via de
`negeren` knop rechtsonder. Zodra alle vragen zijn gezien, zou het klikken op de
`les valideren` knop de les moeten valideren. Zo niet, ga dan terug naar je startpagina,
klik op dezelfde les, het
moet je vragen `Wilt u doorgaan of opnieuw instellen?`, je kunt beide kiezen, en
de les opnieuw valideren totdat het werkt. Het zou na maximaal 3/4 pogingen moeten werken.

#### Les valideren in Fluency builder

Op dit moment is de les valideren functie niet beschikbaar op rosetta stonks.

## De applicatie bouwen

### De worker bouwen

De worker kan worden verpakt met het volgende commando

```
$ deno task build:worker
```

Hierdoor wordt het verpakte bestand `/dist/worker.esm.js` gemaakt, wat het verpakte
bestand voor de worker is.

### Het frontend bouwen

De worker kan verpakt worden met het volgende commando

```
$ deno task build:frontend
```

Hierdoor wordt het verpakte bestand `/dist/frontend.esm.js` aangemaakt, wat het verpakte
bestand voor de frontend is.

## De extensie verpakken

### Chrome

Om de extensie voor Chrome te verpakken, kan het volgende commando worden uitgevoerd:

```
$ make chrome
```

### Firefox

Om de extensie voor Firefox te verpakken, kan het volgende commando worden uitgevoerd:

```
$ make firefox
```

Hierdoor wordt `rosettastonks.xpi` geproduceerd, het bestand voor de extensie dat kan worden
geladen in Firefox.

📸 Liever visueel? Bekijk de [Chrome Installatiegids met Afbeeldingen](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-14

---