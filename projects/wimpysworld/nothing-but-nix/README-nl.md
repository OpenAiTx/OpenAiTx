
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
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=hi">Hindi</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ar">Arabisch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fa">Perzisch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Nothing but Nix

**Transformeer je GitHub Actions-runner in een [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ krachtpatser door genadeloos vooraf geïnstalleerde rommel te verwijderen.**

GitHub Actions-runners hebben slechts weinig schijfruimte voor Nix – slechts ~20GB.
*Nothing but Nix* **verwijdert meedogenloos** onnodige software, waardoor je **65GB tot 130GB** voor je Nix-store krijgt! 💪

## Gebruik 🔧

Voeg deze actie toe **voordat** je Nix installeert in je workflow:

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
- Moet **uitgevoerd worden vóór** Nix wordt geïnstalleerd
- **macOS/Darwin runners**: Deze actie wordt met een waarschuwing overgeslagen als deze op macOS wordt uitgevoerd. macOS runners bieden al voldoende ruimte voor Nix en hebben deze actie niet nodig
- **Windows runners**: Deze actie wordt met een waarschuwing overgeslagen als deze op Windows wordt uitgevoerd. Windows runners hebben een andere indeling en beperkingen van het bestandssysteem

## Het Probleem: Ruimte maken voor Nix om te gedijen 🌱

Standaard GitHub Actions runners zitten vol met *"bloatware"* die je nooit zult gebruiken in een Nix workflow:

- 🌍 Web browsers. Heel veel. Je moet ze allemaal hebben!
- 🐳 Docker images die gigabytes aan kostbare schijfruimte opslokken
- 💻 Onnodige taalruntimes (.NET, Ruby, PHP, Java...)
- 📦 Pakketbeheerders die digitale stof verzamelen
- 📚 Documentatie die niemand ooit zal lezen

Deze bloat laat slechts ~20GB over voor je Nix store - nauwelijks genoeg voor serieuze Nix builds! 😞

## De Oplossing: Alleen Nix ️❄️

**Alleen Nix** neemt een radicale aanpak op GitHub Actions runners en herovert genadeloos schijfruimte via een tweefasige aanval:

1. **Initiële Slag:** Creëert direct een groot `/nix` volume (~65GB) door vrije ruimte van `/mnt` te claimen
2. **Achtergrondcampagne:** Terwijl je workflow doorgaat, verwijderen we onnodige software om je `/nix` volume uit te breiden tot ~130GB
   - Web browsers? Nee ⛔
   - Docker images? Weg 🗑️
   - Taalruntimes? Uitgewist 💥
   - Pakketbeheerders? Geëlimineerd 💣
   - Documentatie? Verdampd ️👻

De bestandsysteemopruiming wordt aangedreven door `rmz` (van het [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc) project) - een high-performance alternatief voor `rm` dat het terugwinnen van ruimte razendsnel maakt! ⚡
   - Presteert een orde van grootte beter dan standaard `rm`
   - Voert parallelle verwijderingen uit voor maximale efficiëntie
   - **Herovert schijfruimte in seconden in plaats van minuten!** ️⏱️

Het eindresultaat? Een GitHub Actions runner met **65GB tot 130GB** aan Nix-klare ruimte! 😁

### Dynamische volumegroei

In tegenstelling tot andere oplossingen groeit **Nothing but Nix** je `/nix` volume dynamisch:

1. **Initiële Volumecreatie (1-10 seconden):** (*afhankelijk van Hatchet Protocol*)
   - Maakt een loop-apparaat aan van vrije ruimte op `/mnt`
   - Zet een BTRFS-bestandssysteem op in RAID0-configuratie
   - Mount met compressie en prestatietuning
   - Biedt onmiddellijk een 65GB `/nix`, zelfs voordat de opschoonactie begint

2. **Achtergronduitbreiding (30-180 seconden):** (*afhankelijk van Hatchet Protocol*)
   - Voert opschoonbewerkingen uit
   - Controleert op nieuw vrijgekomen ruimte terwijl overtolligheid wordt verwijderd
   - Voegt dynamisch een uitbreidingsschijf toe aan het `/nix` volume
   - Herbalanceert het bestandssysteem om de nieuwe ruimte te integreren

Het `/nix` volume **groeit automatisch tijdens workflow-uitvoering** 🎩🪄

### Kies je wapen: Het Hatchet Protocol 🪓

Beheer het niveau van vernietiging 💥 met de `hatchet-protocol` input:

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

Wanneer `nix-permission-edict` is ingesteld op `true`, zal de actie `sudo chown -R "$(id --user)":"$(id --group)" /nix` uitvoeren nadat `/nix` is aangekoppeld.

### Configureer Nix om /nix/build te gebruiken

Deze actie maakt `/nix/build` aan zodat Nix-afleidingsbuilds de teruggewonnen ruimte kunnen gebruiken. Voeg `build-dir` toe aan je Nix-configuratie:

```yaml
- uses: cachix/install-nix-action@v31
  with:
    extra_nix_config: |
      build-dir = /nix/build
```

Of met DeterminateSystems:

```yaml
- uses: DeterminateSystems/nix-installer-action@main
  with:
    extra-conf: |
      build-dir = /nix/build
```

Dit instrueert Nix om builds uit te voeren op het grote BTRFS-volume in plaats van de standaard tijdelijke map van het systeem.

## Problemen oplossen 🔍

### "Geen ruimte meer op apparaat" tijdens grote builds

Als je build geen ruimte meer heeft ondanks dat je alleen Nix gebruikt, komt dit waarschijnlijk doordat de achtergrondopruiming nog niet voltooid is voordat je build de beschikbare ruimte verbruikt. Dit treft vaak:

- NixOS VM-tests die grote schijfafbeeldingen samenstellen
- Builds met veel afhankelijkheden die niet in de cache staan
- Rust-toolchains en andere grote compilaties

**Oplossing:** Gebruik `witness-carnage: true` om synchrone opruiming af te dwingen. Dit zorgt ervoor dat alle ruimte wordt teruggewonnen *voordat* je build start:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'rampage'
    witness-carnage: true
```

Dit voegt 30-180 seconden toe aan je workflow-setup, maar garandeert dat maximale ruimte beschikbaar is wanneer je build begint.

Ga nu iets fantastisch bouwen met al die prachtige Nix store ruimte! ❄️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-18

---