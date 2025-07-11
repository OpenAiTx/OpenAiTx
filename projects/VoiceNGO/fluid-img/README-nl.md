# Fluid Image Web Component

Afbeeldingen die intelligent schalen naar elke gewenste grootte (binnen redelijke grenzen).

![Fluid Images](https://raw.githubusercontent.com/VoiceNGO/fluid-img/refs/heads/main/resources/images/responsive-images.jpg)

**Klein!:** 7kb geminificeerd & ge-gzipt

## Gebruik

```html
<script src="fluid-img.js"></script>
<fluid-img src="image.jpg"></fluid-img>
```

Dat is alles. Schaal de afbeeldingen zoals je wilt, en ze doen gewoon hun werk.

## Demo

[Demo Hier](https://voicengo.github.io/fluid-img/public/fluid-demo.html)

Er is ook een speelomgeving beschikbaar om [te experimenteren met je eigen afbeeldingen](https://voicengo.github.io/fluid-img/public).
## Installatie

### Clientbibliotheek

```sh
npm install fluid-img
```

Importeer vervolgens `fluid-img` in je project, waarmee de webcomponent wordt geleverd en geregistreerd:

```ts
import 'fluid-img';
```

Of voeg het script toe via jsdelivr of unpkg:

```html
<script src="https://cdn.jsdelivr.net/npm/fluid-img@latest/dist/fluid-img.js" />

<!-- of -->

<script src="https://unpkg.com/fluid-img@latest/dist/fluid-img.js" />
```
### Kanttekeningen

De fluid image component werkt het beste voor het horizontaal of verticaal schalen van afbeeldingen binnen een bereik van ongeveer 0,5x tot 1,5x van hun oorspronkelijke grootte. Hoewel het grotere of kleinere schalen aankan, kan de visuele kwaliteit snel achteruitgaan. Het wordt niet aanbevolen voor afbeeldingen waarbij precieze pixelintegriteit cruciaal is, zoals portretten, grafieken of gedetailleerde technische tekeningen, omdat seam carving vervormingen introduceert. Het wordt sterk aanbevolen om uw afbeeldingen op verschillende groottes te testen om te garanderen dat ze aan uw visuele verwachtingen voldoen.

#### CORS

Vanwege beveiligingsbeperkingen van de browser zullen afbeeldingen die worden geladen vanaf een andere oorsprong (domein, protocol of poort) dan de webpagina een Cross-Origin Resource Sharing (CORS)-fout veroorzaken. Deze component vereist toegang tot de ruwe pixelgegevens van de afbeelding, wat door CORS wordt beperkt.

Om afbeeldingen van een andere oorsprong te gebruiken, moet de server die de afbeeldingen host, geconfigureerd zijn om de juiste CORS-headers te verzenden (bijv. `Access-Control-Allow-Origin: *` of `Access-Control-Allow-Origin: your-domain.com`). Zonder deze headers kan de component de afbeelding niet verwerken.

(Ter info: voor testdoeleinden heeft elke afbeelding op imgur de benodigde CORS-headers)

#### Fallback

Als het component er niet in slaagt om de afbeelding te laden of te verwerken, of een interne fout geeft, degradeert het op een nette manier door een standaard `<img>`-tag in het `<fluid-img>`-component te injecteren, met 100% breedte en hoogte, zodat de afbeelding toch getoond wordt.

## Opties

Gebruik: `<fluid-img src="image.jpg" generator="random" max-carve-up-scale="5"></fluid-img>`

Standaard wordt de `random` generator gebruikt omdat deze het snelst is.

| Optie                         | Waarden                          | Standaard    | Beschrijving                                                                                                         |
| ----------------------------- | -------------------------------- | ------------ | -------------------------------------------------------------------------------------------------------------------- |
| `src`                         | URL                              |              | De URL van de te verwerken afbeelding.                                                                               |
| `generator`                   | `random`, `predictive`           | `predictive` | De te gebruiken seam carving generator. `random` is sneller maar van lagere kwaliteit.                               |
| `scaling-axis`                | `horizontal`, `vertical`, `auto` | `horizontal` | De as voor schaling. `auto` schaalt horizontaal of verticaal op basis van wijzigingen in de beeldverhouding.         |
| `mask`                        | URL                              |              | De URL van een maskeraffbeelding. Zwarte gebieden van het masker hebben een lagere energie en worden eerder behouden.|
| `carving-priority`            | Nummer (0-1, bijv. `0.5`)        | `1`          | Het percentage van de schaling dat door seam carving wordt uitgevoerd versus traditionele afbeeldingsschaling.       |
| `max-carve-up-seam-percentage`| Nummer (0-1, bijv. `0.5`)        | `0.6`        | Het maximale percentage naden dat mag worden toegevoegd bij het vergroten. Beperkt het creëren van nieuwe naden om de beeldkwaliteit te behouden. |
| `max-carve-up-scale`          | Nummer (bijv. `3`)               | `3`          | De maximale vergrotingsfactor met seam carving. Daarboven wordt traditionele schaling toegepast.                     |
| `max-carve-down-scale`        | Nummer (0-1, bijv. `0.7`)        | `0.7`        | Het maximale percentage van de afbeelding dat bij het verkleinen door seam carving mag worden verwijderd.            |
### Generator-specifieke opties

Generator-specifieke opties worden toegevoegd aan de `<fluid-img>` component, maar zijn alleen geldig wanneer het bijbehorende
`generator` attribuut ook is ingesteld.

#### Opties voor Random & Predictive Generator

| Optie              | Waarden                | Standaard | Beschrijving                                      |
| ------------------ | ---------------------- | --------- | ------------------------------------------------- |
| `batch-percentage` | Nummer (0-1, bv. 0.1)  | 0.1       | Het percentage naden dat per batch wordt gegenereerd |
| `min-batch-size`   | Nummer (bv. `10`)      | 10        | Het minimum aantal naden dat per batch wordt gegenereerd |

## Hoe het werkt

Seam carving is een content-bewuste techniek voor het aanpassen van afbeeldingsgrootte, die intelligent pixels verwijdert of toevoegt. Hierdoor kan een afbeelding worden aangepast zonder belangrijke inhoud te vervormen. Voor meer informatie, zie het [Wikipedia-artikel](https://en.wikipedia.org/wiki/Seam_carving) over dit onderwerp.

Historisch gezien was seam carving te computationeel intensief voor gebruik in real-time in webbrowsers. Deze beperking kan echter worden overwonnen door gebruik te maken van alternatieve algoritmen die minder veeleisend zijn en in veel scenario's goed werken.

Er zijn twee implementaties van de seam carving generator:
### Willekeurig Carven

De willekeurige seam carving-benadering laat het traditionele seam carving-algoritme los, omdat dit te traag is voor realtime uitvoering in de browser.

In plaats daarvan genereert het een reeks willekeurige naden die zorgen voor 100% beelddekking door elke pixel in een rij te verbinden met een aangrenzende pixel in de volgende rij. Vervolgens wordt er door elke naad gelopen, wordt de energie berekend en wordt een batch van de naden met de laagste energie verwijderd. Dit proces wordt herhaald totdat het gewenste aantal naden is bereikt. Deze methode levert verrassend goede resultaten op voor veel afbeeldingen.

### Predictief Carven

Net als bij willekeurig carven genereert deze methode een energiemap en worden naden in batches gemaakt. Ook wordt er voor elke batch een minimale energiemap gegenereerd. Het kernidee is om zowel "goede" als "slechte" naden te creëren. Goede naden hebben een lage energie en worden behouden. Slechte naden bevatten pixels met hoge energie, zodat deze later gefilterd kunnen worden.

Vanaf de eerste rij worden pixelparen verbonden met corresponderende paren in de volgende rij. De naad met de lagere energie uit de lopende berekening wordt verbonden met de naad met de lagere energie uit de minimale energiemap.

Het resultaat is één echt optimale naad, veel "zeer goede" naden, veel "zeer slechte" naden en een hoop middelmatige. We selecteren een batch van de "goede" naden, verwijderen de rest, en herhalen het proces.

##

## TODO

### Hoge Prioriteit

- [x] Webcomponent
- [x] Renderer die data van generators neemt en schaalt naar elk formaat
- [x] Willekeurige generator
- [x] Verticale carving
- [x] Predictieve generator
- [ ] Web workers voor alle generators
### Lage prioriteit

- [x] Maskeren
- [ ] Gezichtsherkenning

### Droom

- [ ] 2D graveren

## Licentie

Deze software is gelicentieerd onder de Fluid-Img Revenue-Limited License.

**Gratis gebruik** voor individuen en organisaties met een jaarlijkse bruto-omzet van minder dan $10.000.000 USD.

**Commerciële licentie vereist** voor organisaties met een jaarlijkse omzet van $10 miljoen of meer. Neem contact op met [licensing@voice.ngo] voor commerciële licentievoorwaarden.

Zie het [LICENSE](./LICENSE) bestand voor de volledige voorwaarden.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---