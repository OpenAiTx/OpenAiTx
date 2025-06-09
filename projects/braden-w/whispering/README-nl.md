<p align="center">
  <a href="https://whispering.bradenwong.com">
    <img width="180" src="https://raw.githubusercontent.com/braden-w/whispering/main/apps/app/src-tauri/recorder-state-icons/studio_microphone.png" alt="Whispering">
  </a>
  <h1 align="center">Whispering</h1>
  <p align="center">Naadloze dicteren mogelijk gemaakt door OpenAI's Whisper Model</p>
</p>

<p align="center">
  <!-- Latest Version Badge -->
  <img src="https://img.shields.io/github/v/release/braden-w/whispering?style=flat-square&label=Latest%20Version&color=brightgreen" />
  <!-- License Badge -->
  <a href="LICENSE" target="_blank">
    <img alt="MIT License" src="https://img.shields.io/github/license/braden-w/whispering.svg?style=flat-square" />
  </a>
  <!-- Badges for Technologies -->
  <img alt="TypeScript" src="https://img.shields.io/badge/-TypeScript-blue?style=flat-square&logo=typescript&logoColor=white" />
  <img alt="Rust" src="https://img.shields.io/badge/-Rust-orange?style=flat-square&logo=rust&logoColor=white" />
  <!-- Platform Support Badges -->
  <a href="https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo" target="_blank">
    <img alt="Chrome" src="https://img.shields.io/chrome-web-store/stars/oilbfihknpdbpfkcncojikmooipnlglo?color=blue&label=Chrome&style=flat-square&logo=google-chrome&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="macOS" src="https://img.shields.io/badge/-macOS-black?style=flat-square&logo=apple&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Windows" src="https://img.shields.io/badge/-Windows-blue?style=flat-square&logo=windows&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Linux" src="https://img.shields.io/badge/-Linux-yellow?style=flat-square&logo=linux&logoColor=white" />
  </a>
</p>


## Over

Whispering is een open-source transcriptie-applicatie die wereldwijde spraak-naar-tekst functionaliteit biedt, met opties zoals sneltoetsen en automatisch kopiëren en plakken om dicteren zo soepel mogelijk te maken.

Onder de motorkap wordt het aangedreven door OpenAI's Whisper-model, waardoor het aanzienlijk nauwkeuriger is dan ingebouwde dicteerfuncties.

> **Belangrijke Opmerking**: Whispering is primair ontworpen als transcriptietool, niet als opnamehulpmiddel. Voor langere opnames waarbij betrouwbaarheid essentieel is, raad ik aan een speciale opname-app op je telefoon of apparaat te gebruiken die gebruikmaakt van native opname-API's. Dit zorgt voor optimale geluidskwaliteit en opnamebetrouwbaarheid.

## Demo's

https://github.com/user-attachments/assets/eca93701-10a0-4d91-b38a-f715bd7e0357

https://github.com/user-attachments/assets/a7934f1f-d08b-4037-9bbc-aadd1b13501e

## Belangrijkste Functies

1. **Wereldwijde Transcriptie**: Toegang tot Whisper's spraak-naar-tekst functionaliteit overal met een globale sneltoets of binnen twee muisklikken.
2. **Cross-Platform Ervaring**:
   - Desktop-app: Maakt wereldwijde transcriptie in alle applicaties mogelijk.
   - Browserextensie: Biedt wereldwijde transcriptie in de browser door te communiceren met de webapp.
3. **Chatintegratie**: De browserextensie voegt een opnameknop toe aan de ChatGPT- en Claude-websites, waardoor directe steminvoer en transcriptie in de chatinterface mogelijk zijn.
4. **Transcriptiebeheer**: Bekijk en bewerk transcripties binnen de Whispering-app om nauwkeurigheid en duidelijkheid te waarborgen.
5. **Automatische Klembordintegratie**: Zodra de transcriptie is voltooid, wordt de tekst automatisch naar je klembord gekopieerd. Een optie voor automatisch plakken is ook beschikbaar.

## Hoe worden mijn gegevens opgeslagen?

Whispering slaat zoveel mogelijk gegevens lokaal op je apparaat op, inclusief opnames en teksttranscripties. Deze aanpak zorgt voor maximale privacy en gegevensbeveiliging. Hier volgt een overzicht van hoe gegevens worden behandeld:

1. **Lokale Opslag**: Spraakopnames en transcripties worden opgeslagen in IndexedDB, dat wordt gebruikt als blobopslag en als plek om al je gegevens zoals tekst en transcripties op te slaan.

2. **Transcriptieservice**: De enige gegevens die elders naartoe worden gestuurd, zijn je opnames naar een externe transcriptieservice—als je daarvoor kiest. Je hebt de volgende opties:
   - Externe diensten zoals OpenAI of Groq
   - Een lokale transcriptieservice zoals `faster-whisper-server`, waarmee alles op het apparaat blijft

3. **Configureerbare Instellingen**: Je kunt de transcriptieservice wijzigen in de instellingen om maximale lokale functionaliteit te waarborgen.


## Installatie

### Webapp

Bezoek [whispering.bradenwong.com](https://whispering.bradenwong.com/), waar de nieuwste versie van de map `apps/app` wordt gehost op Vercel.

### Chrome-extensie

Installeer de Chrome-extensie vanuit de Chrome Web Store [hier](https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo).

### Desktop-app

Volg de stappen voor je besturingssysteem om de Whispering desktop-app te downloaden en installeren:

#### Windows

1. Download het installatiepakket dat eindigt op `.msi` van de [laatste releases-pagina](https://github.com/braden-w/whispering/releases).
2. Open het gedownloade `.msi` bestand om de installer uit te voeren.
3. Als er een waarschuwing verschijnt dat het onveilig is, klik dan op `Meer informatie` -> `Toch uitvoeren` om door te gaan met de installatie.
4. Volg de instructies op het scherm om de installatie te voltooien.

#### macOS

Voor macOS volg je deze stappen om Whispering te installeren:

1. **Download het installatiepakket**:
   - Bezoek de [laatste releases-pagina](https://github.com/braden-w/whispering/releases).
   - Kies het juiste pakket:
     - Voor Apple Silicon: `Whispering_x.x.x_aarch64.dmg`
     - Voor Intel: `Whispering_x.x.x_x64.dmg`

2. **Installeer de applicatie**:
   - Open het gedownloade `.dmg` bestand.
   - Sleep de Whispering-app naar de map Programma's.

3. **Start Whispering**:
   - Open Whispering vanuit de map Programma's.
   - Als je een waarschuwing ziet over een niet-geverifieerde ontwikkelaar:
     - Klik op `Annuleren`
     - Klik met de rechtermuisknop op de app in Finder en selecteer `Open`

4. **Probleemoplossing** (alleen Apple Silicon):
   Als je de foutmelding krijgt `"Whispering" is beschadigd en kan niet worden geopend`:
   - Open Terminal
   - Voer het volgende commando uit:
     ```bash
     xattr -cr /Applications/Whispering.app
     ```
   - Probeer de applicatie opnieuw te openen

Na het voltooien van deze stappen zou Whispering klaar moeten zijn voor gebruik op je macOS-systeem.

#### Linux

Voor Linux zijn er meerdere installatie-opties beschikbaar. Kies de optie die het beste bij jouw omgeving past:

1. **AppImage**:

   - Download het `.AppImage` bestand van de [laatste releases-pagina](https://github.com/braden-w/whispering/releases).
   - Maak het bestand uitvoerbaar:
     ```bash
     chmod +x whispering_x.x.x_amd64.AppImage
     ```
   - Voer de AppImage uit:
     ```bash
     ./whispering_x.x.x_amd64.AppImage
     ```

2. **DEB-pakket (Debian/Ubuntu)**:
   - Download het `.deb` bestand van de [laatste releases-pagina](https://github.com/braden-w/whispering/releases).
   - Installeer het pakket met `dpkg`:
     ```bash
     sudo dpkg -i whispering_x.x.x_amd64.deb
     ```
   - Los eventuele afhankelijkheidsproblemen op:
     ```bash
     sudo apt-get install -f
     ```

Na de installatie is de app klaar voor gebruik.

## Gebruik

### Chrome-extensie

Na het installeren van de Chrome-extensie vind je een Whispering-icoon op de Chrome-extensie-balk. Klik op dit icoon om de extensie te openen. Klik op de microfoonknop om je stem op te nemen, en klik vervolgens op de vierkante knop als je klaar bent. Je transcriptie verschijnt in het tekstvak hieronder.

Om toegang te krijgen tot de ChatGPT- of Claude-functie, navigeer naar de ChatGPT- of Claude-webpagina. Je ziet een nieuwe opnameknop in de chatinterface. Klik op deze knop om de opname te starten en te stoppen, en de getranscribeerde tekst wordt automatisch in het chat-invoerveld geplaatst.

Om de sneltoetsfunctie te gebruiken, druk op <kbd>Control</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> of <kbd>Command</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> (later aan te passen via de sneltoetsen van de Chrome-extensie) om vanaf elke website een opname te starten. De transcriptie wordt automatisch naar je klembord gekopieerd en in het huidige invoerveld geplakt.

De Chrome-extensie communiceert met [whispering.bradenwong.com](https://whispering.bradenwong.com), en zal automatisch proberen een tabblad op de achtergrond aan te maken als er geen wordt gevonden. De meeste bugs zijn te wijten aan het falen van deze communicatie, zoals zeldzame gevallen waarin het tabblad in slaapstand raakt.

### Webapp

De webapp is bereikbaar via [whispering.bradenwong.com](https://whispering.bradenwong.com). Klik op de microfoonknop om je stem op te nemen, en klik vervolgens op de vierkante knop als je klaar bent. Je transcriptie verschijnt in het tekstvak.

### Desktop-app

Na installatie van de Whispering desktop-app druk je op <kbd>Control/Command</kbd> + <kbd>Shift</kbd> + <kbd>;</kbd> (instelbaar in de instellingen) om vanaf elke plek op je desktop een opname te starten. De transcriptie wordt automatisch naar je klembord gekopieerd en geplakt, hoewel beide functies in de instellingen kunnen worden in- of uitgeschakeld.

## Gebouwd Met

#### Web en Desktop

De Whispering-app is gebouwd met de volgende technologieën en bibliotheken:

- [Svelte 5](https://svelte.dev): De gekozen UI-reactiviteitsbibliotheek.
- [SvelteKit](https://kit.svelte.dev/docs): Voor routing en statische sitegeneratie, gebruikt voor zowel de website als de statische frontend voor de Tauri-app.
- [Tauri](https://tauri.studio/en/docs/intro/): Het desktop-app-framework.
- [Effect-TS](https://github.com/Effect-TS/effect): Voor het toevoegen van functionele programmeerconcepten en het schrijven van extreem type-veilige functies, waarbij fouten zijn opgenomen in het retourtype van de functiehandtekening.
- [Svelte Sonner](https://svelte-sonner.vercel.app/): Een eenvoudige, aanpasbare toastbibliotheek voor Svelte-applicaties. Gebruikt om fouten weer te geven via Effect-TS met de `renderAsToast` functie.
- [TanStack Table](https://tanstack.com/table): Voor alle datatabellen.
- [IndexedDB](https://developer.mozilla.org/en-US/docs/Web/API/IndexedDB_API): Een low-level API voor het opslaan van grote hoeveelheden gestructureerde data in de browser. Gesynchroniseerd met Tanstack Table.
- [ShadCN-Svelte](https://github.com/huntabyte/shadcn-svelte): De gekozen UI-componentenbibliotheek.
- [TailwindCSS](https://tailwindcss.com/docs): Een utility-first CSS-framework voor het snel bouwen van aangepaste gebruikersinterfaces.
- [Turborepo](https://turborepo.org/): Voor monorepo-beheer, zodat `apps/app` en `apps/extension` dezelfde codebase kunnen delen, wat code-duplicatie sterk vermindert en belangrijker nog, één enkele bron van waarheid handhaaft.
- [Rust](https://www.rust-lang.org): Voor het uitbreiden van desktop-app-functionaliteiten, zoals het gebruik van de `enigo` crate voor het automatisch plakken.
- [Vercel](https://vercel.com/): Hosting die geschikt is voor hobbyprojecten en goede Turborepo-integraties biedt.
- [Zapsplat.com](https://www.zapsplat.com/): Een rechtenvrije geluidseffectenbibliotheek.

#### Extensie

De Whispering Chrome-extensie is gebouwd met:

- [Plasmo](https://docs.plasmo.com/): Een framework voor het bouwen van Chrome-extensies. We gebruiken de [relay flow](https://docs.plasmo.com/framework/messaging#relay-flow) om te communiceren met de Whispering-website.
- [Effect-TS](https://github.com/Effect-TS/effect): Voor het toevoegen van functionele programmeerconcepten en het schrijven van extreem type-veilige functies, waarbij fouten zijn opgenomen in het retourtype van de functiehandtekening.
- [React](https://reactjs.org): De UI-reactiviteitsbibliotheek voor de Chrome-extensie, aangezien Plasmo helaas geen Svelte 5 ondersteunt.
- [ShadCN](https://github.com/shadcn): De UI-componentenbibliotheek voor de Chrome-extensie.
- [TailwindCSS](https://tailwindcss.com/docs): Een utility-first CSS-framework voor het snel bouwen van aangepaste gebruikersinterfaces.
- [Chrome API](https://developer.chrome.com/docs/extensions/reference/): De Chrome-extensie API.
- [Zapsplat.com](https://www.zapsplat.com/): Een rechtenvrije geluidseffectenbibliotheek.

## Whispering uitvoeren in lokale ontwikkelmodus

Om het project op je lokale machine op te zetten, volg je deze stappen:

1. Clone de repository: `git clone https://github.com/braden-w/whispering.git`
2. Ga naar de projectmap: `cd whispering`
3. Installeer de benodigde afhankelijkheden: `pnpm i`

Om de Whispering desktop-app en website in ontwikkelmodus te draaien:

4. Ga naar de app-map: `cd apps/app`
5. Start de ontwikkelserver: `pnpm tauri dev`

De desktop-app zou automatisch moeten openen voor lokale ontwikkeling. Om de web-app te ontwikkelen, open je je browser en navigeer je naar `http://localhost:5173`.

Om de Whispering Chrome-extensie in ontwikkelmodus te draaien:

4. Ga naar de extensiemap: `cd apps/extension`
5. Start de ontwikkelserver: `pnpm dev --target=chrome-mv3`

Om de Chrome-extensie te ontwikkelen, laad je deze in Chrome door te navigeren naar `chrome://extensions`, de ontwikkelaarsmodus in te schakelen, en de map `apps/extension/build/{platform}-{manifest-version}-dev` te laden als een niet-gepakte extensie.

## Bouw het uitvoerbare bestand zelf

Als je ooit twijfels hebt over de betrouwbaarheid van de installers of meer controle wilt, kun je altijd het uitvoerbare bestand zelf bouwen. Dit vereist meer installatie, maar het verzekert dat je de code draait die je verwacht. Dat is het mooie van open-source software!

### Chrome

1. Ga naar de extensiemap: `cd apps/extension`
2. Installeer de benodigde afhankelijkheden: `pnpm i`
3. Voer Plasmo build uit: `pnpm plasmo build --target=chrome-mv3`
4. De output is te vinden in `apps/extension/build/chrome-mv3-prod`, die je kunt laden in Chrome als een niet-gepakte extensie.
5. Je kunt de extensie ook bouwen voor de Chrome Web Store: `pnpm plasmo build --target=chrome-mv3 --release`

### Firefox

1. Ga naar de extensiemap: `cd apps/extension`
2. Installeer de benodigde afhankelijkheden: `pnpm i`
3. Voer Plasmo build uit: `pnpm plasmo build --target=firefox-mv3`
4. De output is te vinden in `apps/extension/build/firefox-mv3-prod`, die je kunt laden in Chrome als een niet-gepakte extensie.
5. Je kunt de extensie ook bouwen voor de Chrome Web Store: `pnpm plasmo build --target=firefox-mv3 --release`

### Desktop

1. Ga naar de app-map: `cd apps/app`
2. Installeer de benodigde afhankelijkheden: `pnpm i`
3. Voer Tauri Build uit: `pnpm tauri build`
4. Je vindt het uitvoerbare bestand in de map `apps/app/target/release`.

## Bijdragen

We verwelkomen bijdragen van de community! Als je wilt bijdragen aan Whispering, volg dan deze stappen:

1. Fork de repository.
2. Maak een nieuwe branch voor je feature of bugfix: `git checkout -b feature/your-feature-name` of `git checkout -b fix/your-bugfix-name`
3. Maak je aanpassingen en commit ze met een beschrijvende boodschap.
4. Push je branch naar je geforkte repository: `git push origin your-branch-name`
5. Maak een pull request van je geforkte repository naar het origineel.

Zorg ervoor dat je code de vastgestelde conventies volgt en goed gedocumenteerd is.

## Licentie

Whispering wordt uitgebracht onder de [MIT Licentie](https://opensource.org/licenses/MIT).

## Sponsors

Dit project wordt ondersteund door de volgende geweldige mensen en organisaties:

<!-- sponsors --><a href="https://github.com/DavidGP"><img src="https://github.com/DavidGP.png" width="60px" alt="" /></a><a href="https://github.com/cgbur"><img src="https://github.com/cgbur.png" width="60px" alt="Chris Burgess" /></a><a href="https://github.com/Wstnn"><img src="https://github.com/Wstnn.png" width="60px" alt="" /></a><a href="https://github.com/rkhrkh"><img src="https://github.com/rkhrkh.png" width="60px" alt="" /></a><a href="https://github.com/doxgt"><img src="https://github.com/doxgt.png" width="60px" alt="" /></a><a href="https://github.com/worldoptimizer"><img src="https://github.com/worldoptimizer.png" width="60px" alt="Max Ziebell" /></a><a href="https://github.com/AlpSantoGlobalMomentumLLC"><img src="https://github.com/AlpSantoGlobalMomentumLLC.png" width="60px" alt="" /></a><!-- sponsors -->

## Support en feedback

Als je problemen tegenkomt of suggesties hebt voor verbeteringen, open dan een issue op de [GitHub issues tab](https://github.com/braden-w/whispering/issues) of neem contact met mij op via [whispering@bradenwong.com](mailto:whispering@bradenwong.com). Ik waardeer je feedback enorm!

Bedankt voor het gebruiken van Whispering en veel schrijfplezier!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---