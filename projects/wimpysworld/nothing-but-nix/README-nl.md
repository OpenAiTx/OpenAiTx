
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Nothing but Nix

**Transformeer je GitHub Actions-runner in een [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ krachtpatser door rigoureus vooraf geïnstalleerde overbodige software te verwijderen.**

GitHub Actions-runners hebben weinig schijfruimte voor Nix - slechts ongeveer ~20GB.
*Nothing but Nix* **zuivert genadeloos** onnodige software, waardoor je **65GB tot 130GB** beschikbaar krijgt voor je Nix store! 💪

## Gebruik 🔧

Voeg deze actie **toe vóór** het installeren van Nix in je workflow:

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

### Vereisten ️✔️

- Ondersteunt alleen officiële **Ubuntu** GitHub Actions runners
- Moet **voorafgaand** aan de installatie van Nix worden uitgevoerd

## Het Probleem: Ruimte maken zodat Nix kan floreren 🌱

Standaard GitHub Actions runners zitten vol met *"bloatware"* die je nooit zult gebruiken in een Nix-werkstroom:

- 🌍 Webbrowsers. Heel veel. Je moet ze allemaal hebben!
- 🐳 Docker-images die gigabytes aan kostbare schijfruimte innemen
- 💻 Overbodige taalruntimes (.NET, Ruby, PHP, Java...)
- 📦 Pakketbeheerders die digitale stof verzamelen
- 📚 Documentatie die niemand ooit zal lezen

Door deze bloat blijft er slechts ~20GB over voor je Nix-store - nauwelijks genoeg voor serieuze Nix-builds! 😞

## De Oplossing: Alleen Nix ️❄️

**Alleen Nix** hanteert een scorched-earth-benadering op GitHub Actions runners en claimt meedogenloos schijfruimte terug met een tweefasige aanval:

1. **Initiële Slag:** Creëert direct een groot `/nix`-volume (~65GB) door vrije ruimte van `/mnt` te claimen
2. **Achtergrondbarrage:** Terwijl je workflow doorgaat, ruimen we genadeloos onnodige software op om je `/nix`-volume uit te breiden tot wel ~130GB
   - Webbrowsers? Nee ⛔
   - Docker-images? Weg 🗑️
   - Taalruntimes? Uitgewist 💥
   - Pakketbeheerders? Geëlimineerd 💣
   - Documentatie? Verdwenen ️👻

De bestandsopruiming wordt aangedreven door `rmz` (van het [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc) project) - een high-performance alternatief voor `rm` dat ruimte extreem snel vrijmaakt! ⚡
   - Presteert een orde van grootte sneller dan standaard `rm`
   - Voert verwijderingen parallel uit voor maximale efficiëntie
   - **Claimt schijfruimte in seconden in plaats van minuten!** ️⏱️

Het eindresultaat? Een GitHub Actions runner met **65GB tot 130GB** aan Nix-klare ruimte! 😁

### Dynamische Volume Groei

In tegenstelling tot andere oplossingen groeit **Alleen Nix** je `/nix`-volume dynamisch:

1. **Initiële Volumecreatie (1-10 seconden):** (*afhankelijk van het Hatchet Protocol*)
   - Maakt een loopapparaat aan van vrije ruimte op `/mnt`
   - Zet een BTRFS-bestandssysteem op in RAID0-configuratie
   - Mount met compressie en prestatieoptimalisatie
   - Biedt direct een 65GB `/nix`, zelfs voordat de opruiming begint

2. **Achtergronduitbreiding (30-180 seconden):** (*afhankelijk van het Hatchet Protocol*)
   - Voert opruimacties uit
   - Houdt in de gaten of er nieuwe vrije ruimte beschikbaar komt naarmate bloat wordt verwijderd
   - Voegt dynamisch een uitbreidingsschijf toe aan het `/nix`-volume
   - Herbalanceert het bestandssysteem om nieuwe ruimte toe te voegen

Het `/nix`-volume **groeit automatisch tijdens de uitvoering van de workflow** 🎩🪄

### Kies je Wapen: Het Hatchet Protocol 🪓

Bepaal het niveau van vernietiging 💥 met de `hatchet-protocol` input:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'cleave'  # Options: holster, carve, cleave (default), rampage
```

#### Protocol Vergelijking ⚖️

| Protocol | `/nix` | Beschrijving                                      | Verwijder apt  | Verwijder docker | Verwijder snap | Verwijderde bestandssystemen     |
|----------|--------|---------------------------------------------------|----------------|------------------|----------------|-------------------------------|
| Holster  | ~65GB  | Houd het bijl in de schede, gebruik ruimte van `/mnt` | Nee           | Nee              | Nee            | Geen                          |
| Carve    | ~85GB  | Maak en combineer vrije ruimte van `/` en `/mnt`  | Nee           | Nee              | Nee            | Geen                          |
| Cleave   | ~115GB | Maak krachtige, beslissende sneden in grote pakketten | Minimaal      | Ja               | Ja             | `/opt` en `/usr/local`        |
| Rampage  | ~130GB | Meedogenloze, brute eliminatie van alle ballast   | Agressief      | Ja               | Ja             | Muahahaha! 🔥🌎               |

Kies wijs:
- **Holster** wanneer je wilt dat de runner-tools volledig functioneel blijven
- **Carve** om functionele runner-tooling te behouden maar alle vrije ruimte voor Nix te claimen
- **Cleave** (*standaard*) voor een goede balans tussen ruimte en functionaliteit
- **Rampage** wanneer je maximale Nix-ruimte wilt en het je niet uitmaakt wat er breekt `#nix-is-life`

### Getuige De Slachting 🩸

Standaard wordt het opschoningsproces stilletjes op de achtergrond uitgevoerd terwijl je workflow doorgaat. Maar als je het bloedbad in realtime wilt bekijken:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    witness-carnage: true  # Default: false
```

### Pas veilige havens aan 🛡️

Bepaal hoeveel ruimte je wilt vrijhouden van de Nix store-inname met aangepaste veilige haven-groottes:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    root-safe-haven: '3072'   # Reserve 3GB on the / filesystem
    mnt-safe-haven: '2048'    # Reserve 2GB on the /mnt filesystem
```

Deze veilige havens bepalen hoeveel ruimte (in MB) genadig zal worden gespaard tijdens ruimte-terugwinning:
- Standaard `root-safe-haven` is 2048MB (2GB)
- Standaard `mnt-safe-haven` is 1024MB (1GB)

Verhoog deze waarden als je meer ademruimte op je bestandssystemen nodig hebt, of verlaag ze om geen genade te tonen! 😈

### Geef gebruikers eigenaarschap van /nix (Nix Permission Edict) 🧑‍⚖️

Sommige Nix-installers of configuraties verwachten dat de map `/nix` schrijfbaar is voor de huidige gebruiker. Standaard is `/nix` eigendom van root. Als je gebruikers-eigenaarschap nodig hebt (bijvoorbeeld voor bepaalde Nix-installatiescripts die niet `sudo` gebruiken voor alle bewerkingen binnen `/nix`), kun je de `nix-permission-edict` inschakelen:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    nix-permission-edict: true  # Default: false
```

Wanneer `nix-permission-edict` is ingesteld op `true`, zal de actie `sudo chown -R "$(id --user)":"$(id --group)" /nix` uitvoeren na het aankoppelen van `/nix`.

Ga nu iets geweldigs bouwen met al die glorieuze Nix store-ruimte! ❄️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---