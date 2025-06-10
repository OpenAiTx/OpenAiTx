# TypeScript 7

[Weet je niet zeker wat dit is? Lees de aankondigingspost!](https://devblogs.microsoft.com/typescript/typescript-native-port/)

## Preview

Een preview-build is beschikbaar op npm als `@typescript/native-preview`.

```sh
npm install @typescript/native-preview
npx tsgo # Gebruik dit zoals je tsc zou gebruiken.
```

Een preview VS Code-extensie is [beschikbaar op de VS Code-marktplaats](https://marketplace.visualstudio.com/items?itemName=TypeScriptTeam.native-preview).

Om dit te gebruiken, stel je het volgende in je VS Code-instellingen:

```json
{
    "typescript.experimental.useTsgo": true
}
```

## Hoe te bouwen en uitvoeren

Deze repo gebruikt [Go 1.24 of hoger](https://go.dev/dl/), [Rust 1.85 of hoger](https://www.rust-lang.org/tools/install), [Node.js met npm](https://nodejs.org/), en [`hereby`](https://www.npmjs.com/package/hereby).

Voor tests en codegeneratie bevat deze repo een git-submodule naar de hoofd TypeScript-repo die wijst naar de commit die wordt geporteerd.
Bij het klonen wil je klonen met submodules:

```sh
git clone --recurse-submodules https://github.com/microsoft/typescript-go.git
```

Als je de repo al hebt gekloond, kun je de submodule initialiseren met:

```sh
git submodule update --init --recursive
```

Met de submodule op zijn plaats en na `npm ci`, kun je taken uitvoeren via `hereby`, vergelijkbaar met de TypeScript-repo:

```sh
hereby build          # Controleer of het project bouwt
hereby test           # Voer alle tests uit
hereby install-tools  # Installeer extra tools zoals linters
hereby lint           # Voer alle linters uit
hereby format         # Format alle code
hereby generate       # Genereer alle Go-code (bijv. diagnostics, gecommitteerd naar repo)
```

Aanvullende taken zijn in ontwikkeling.

`hereby` is niet vereist om aan de repo te werken; de reguliere `go` tooling (bijv. `go build`, `go test ./...`) werkt zoals verwacht.
`hereby`-taken zijn beschikbaar als gemak voor diegenen die bekend zijn met de TypeScript-repo.

### `tsgo` uitvoeren

Na het uitvoeren van `hereby build`, kun je `built/local/tsgo` uitvoeren, dat zich grotendeels hetzelfde gedraagt als `tsc`.

### LSP Prototype uitvoeren

Om de VS Code-extensie te debuggen en uit te voeren zonder deze globaal te installeren:

* Start VS Code in de repo-werkruimte (`code .`)
* Kopieer `.vscode/launch.template.json` naar `.vscode/launch.json`
* <kbd>F5</kbd> (of `Debug: Start Debugging` vanuit de opdrachtpalet)

Dit start een nieuw VS Code-venster dat de Corsa LS als backend gebruikt. Als alles correct is ingesteld, zou je "tsgo" in de statusbalk moeten zien wanneer een TypeScript- of JavaScript-bestand is geopend:

![LSP Prototype Screenshot](https://raw.githubusercontent.com/microsoft/typescript-go/main/.github/ls-screenshot.png)


## Wat werkt tot nu toe?

Dit is nog steeds een work in progress en heeft nog niet volledige functiepariteit met TypeScript. Er kunnen bugs bestaan. Controleer deze lijst zorgvuldig voordat je een nieuw issue aanmaakt of een opzettelijke wijziging aanneemt.

| Feature | Status | Opmerkingen |
|---------|--------|-------------|
| Programmacreatie | klaar | Zelfde bestanden en module-resolutie als TS5.8. Niet alle resolutiemodi worden nog ondersteund. |
| Parsing/scanning | klaar | Exact dezelfde syntaxfouten als TS5.8 |
| Commandline en `tsconfig.json` parsing | grotendeels klaar | Entry point is voorlopig iets anders |
| Type-resolutie | klaar | Zelfde types als TS5.8 |
| Typechecking | klaar | Zelfde fouten, locaties en berichten als TS5.8. Types in foutmeldingen kunnen anders worden weergegeven (in ontwikkeling) |
| JavaScript-specifieke inferentie en JS Doc | niet klaar | - |
| JSX | klaar | - |
| Declaration emit | in ontwikkeling | Meest voorkomende functies zijn aanwezig, maar sommige randgevallen en feature flags zijn nog niet afgehandeld |
| Emit (JS-output) | in ontwikkeling | `target: esnext` goed ondersteund, andere targets kunnen hiaten hebben |
| Watch-modus | prototype | Bekijkt bestanden en bouwt opnieuw, maar geen incrementele hercontrole |
| Build-modus / projectreferenties | niet klaar | - |
| Incrementele build | niet klaar | - |
| Language service (LSP) | prototype | Minimale functionaliteit (fouten, hover, ga naar definitie). Meer functies volgen binnenkort |
| API | niet klaar | - |

Definities:

 * **klaar** oftewel "vermoedelijk klaar": We zijn momenteel niet op de hoogte van tekorten of groot resterend werk. Bugs mogen worden aangemeld
 * **in ontwikkeling**: er wordt momenteel aan gewerkt; sommige functies werken mogelijk, andere niet. OK om panics te melden, maar verder niets graag
 * **prototype**: alleen proof-of-concept; meld geen bugs
 * **niet klaar**: nog niet aan begonnen, of ver genoeg van gereed dat je er voorlopig niet aan moet zitten

## Overige opmerkingen

Op de lange termijn verwachten we dat deze repo en de inhoud worden samengevoegd in `microsoft/TypeScript`.
Als gevolg daarvan zullen de repo en issue tracker voor typescript-go uiteindelijk worden gesloten, dus behandel discussies/issues dienovereenkomstig.

Voor een lijst van opzettelijke wijzigingen ten opzichte van TypeScript 5.7, zie CHANGES.md.

## Bijdragen

Dit project verwelkomt bijdragen en suggesties.  Voor de meeste bijdragen moet je een
Contributor License Agreement (CLA) ondertekenen waarin je verklaart dat je het recht hebt om, en daadwerkelijk verleent, ons het recht om je bijdrage te gebruiken. Zie voor details [Contributor License Agreements](https://cla.opensource.microsoft.com).

Wanneer je een pull request indient, zal een CLA-bot automatisch bepalen of je een CLA moet aanleveren en het PR dienovereenkomstig markeren (bijv. statuscontrole, opmerking). Volg eenvoudigweg de instructies van de bot. Je hoeft dit maar één keer te doen voor alle repos die onze CLA gebruiken.

Dit project heeft de [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/) aangenomen.
Voor meer informatie zie de [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) of
neem contact op met [opencode@microsoft.com](mailto:opencode@microsoft.com) voor verdere vragen of opmerkingen.

## Handelsmerken

Dit project kan handelsmerken of logo's bevatten voor projecten, producten of diensten. Geautoriseerd gebruik van Microsoft
handelsmerken of logo's is onderhevig aan en moet voldoen aan de
[Microsoft's Trademark & Brand Guidelines](https://www.microsoft.com/legal/intellectualproperty/trademarks/usage/general).
Gebruik van Microsoft-handelsmerken of logo's in aangepaste versies van dit project mag geen verwarring veroorzaken of Microsoft-sponsoring impliceren.
Elk gebruik van handelsmerken of logo's van derden is onderhevig aan het beleid van die derde partij.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---