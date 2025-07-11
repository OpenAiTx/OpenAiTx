# Componente Web Immagine Fluida

Immagini che si adattano in modo intelligente a qualsiasi dimensione desiderata (entro limiti ragionevoli).

![Immagini Fluide](https://raw.githubusercontent.com/VoiceNGO/fluid-img/refs/heads/main/resources/images/responsive-images.jpg)

**Minuscolo!:** 7kb minificato & compresso con gzip

## Utilizzo

```html
<script src="fluid-img.js"></script>
<fluid-img src="image.jpg"></fluid-img>
```

Tutto qui. Ridimensiona le immagini come desideri, e faranno semplicemente il loro lavoro.

## Demo

[Demo Qui](https://voicengo.github.io/fluid-img/public/fluid-demo.html)

È disponibile anche un playground per [sperimentare con le tue immagini](https://voicengo.github.io/fluid-img/public).
## Installazione

### Libreria Client

```sh
npm install fluid-img
```

Poi importa `fluid-img` nel tuo progetto, che fornisce e registra il web-component:

```ts
import 'fluid-img';
```

Oppure includi lo script da jsdelivr o unpkg:

```html
<script src="https://cdn.jsdelivr.net/npm/fluid-img@latest/dist/fluid-img.js" />

<!-- oppure -->

<script src="https://unpkg.com/fluid-img@latest/dist/fluid-img.js" />
```
### Avvertenze

Il componente immagine fluida funziona al meglio per immagini che vengono scalate orizzontalmente o verticalmente entro un intervallo di circa 0,5x fino a 1,5x della loro dimensione originale. Sebbene possa gestire scale maggiori o minori, la qualità visiva può degradarsi rapidamente. Non è consigliato per immagini in cui l’integrità precisa dei pixel è fondamentale, come ritratti, grafici o disegni tecnici dettagliati, poiché il seam carving introduce distorsioni. Si raccomanda vivamente di testare le immagini a varie dimensioni per assicurarsi che soddisfino le proprie aspettative visive.

#### CORS

A causa delle restrizioni di sicurezza dei browser, le immagini caricate da un’origine diversa (dominio, protocollo o porta) rispetto alla pagina web genereranno un errore di Cross-Origin Resource Sharing (CORS). Questo componente richiede l’accesso ai dati grezzi dei pixel dell’immagine, il che è limitato da CORS.

Per utilizzare immagini da un’origine diversa, il server che ospita le immagini deve essere configurato per inviare gli header CORS appropriati (ad esempio, `Access-Control-Allow-Origin: *` o `Access-Control-Allow-Origin: your-domain.com`). Senza questi header, il componente non sarà in grado di elaborare l’immagine.

(Per tua informazione, a scopo di test, qualsiasi immagine su imgur possiede gli header CORS necessari)

#### Fallback

Se il componente non riesce a caricare o elaborare l’immagine, oppure genera un errore interno, effettuerà un degrado graduale inserendo un tag `<img>` standard all’interno del componente `<fluid-img>`, con larghezza e altezza al 100%, assicurando che l’immagine venga comunque visualizzata.

## Opzioni

Utilizzo: `<fluid-img src="image.jpg" generator="random" max-carve-up-scale="5"></fluid-img>`

Per impostazione predefinita, viene utilizzato il generatore `random` in quanto è il più veloce.

| Opzione                        | Valori                           | Predefinito  | Descrizione                                                                                                               |
| ------------------------------ | -------------------------------- | ------------ | ------------------------------------------------------------------------------------------------------------------------- |
| `src`                          | URL                              |              | L’URL dell’immagine da elaborare.                                                                                        |
| `generator`                    | `random`, `predictive`           | `predictive` | Il generatore di seam carving da utilizzare. `random` è più veloce ma di qualità inferiore.                              |
| `scaling-axis`                 | `horizontal`, `vertical`, `auto` | `horizontal` | L’asse su cui eseguire la scalatura. `auto` scala orizzontalmente o verticalmente in base alle variazioni del rapporto.   |
| `mask`                         | URL                              |              | L’URL di un’immagine maschera. Le aree nere della maschera hanno energia più bassa e sono più probabilmente preservate.  |
| `carving-priority`             | Numero (0-1, es. `0.5`)          | `1`          | Percentuale della scalatura da eseguire tramite seam carving rispetto alla scalatura tradizionale.                       |
| `max-carve-up-seam-percentage` | Numero (0-1, es. `0.5`)          | `0.6`        | Percentuale massima di seam da inserire durante l’ingrandimento. Limita la creazione di nuovi seam per preservare qualità.|
| `max-carve-up-scale`           | Numero (es. `3`)                 | `3`          | Fattore massimo di ingrandimento utilizzando il seam carving. Oltre questo valore, viene utilizzata la scalatura tradizionale. |
| `max-carve-down-scale`         | Numero (0-1, es. `0.7`)          | `0.7`        | Percentuale massima dell’immagine che può essere rimossa tramite seam carving durante la riduzione di scala.             |
### Opzioni specifiche del generatore

Le opzioni specifiche del generatore vengono aggiunte al componente `<fluid-img>`, ma sono valide solo quando anche l'attributo
`generator` corrispondente è impostato.

#### Opzioni del generatore Random & Predictive

| Opzione             | Valori                | Predefinito | Descrizione                                         |
| ------------------- | --------------------- | ----------- | --------------------------------------------------- |
| `batch-percentage`  | Numero (0-1, es. 0.1) | 0.1         | La percentuale di seam da generare per batch        |
| `min-batch-size`    | Numero (es. `10`)     | 10          | Il numero minimo di seam da generare per batch      |

## Come funziona

Il seam carving è una tecnica di ridimensionamento delle immagini "content-aware" che rimuove o aggiunge pixel in modo intelligente, permettendo di ridimensionare un'immagine senza distorcere i contenuti importanti. Per ulteriori informazioni, consulta l'[articolo di Wikipedia](https://en.wikipedia.org/wiki/Seam_carving) sull'argomento.

Storicamente, il seam carving era troppo intensivo dal punto di vista computazionale per l'uso in tempo reale nei browser web. Tuttavia, questa limitazione può essere superata utilizzando algoritmi alternativi meno esigenti che funzionano bene in molti scenari.

Esistono due implementazioni del generatore di seam carving:
### Ritaglio Casuale

L'approccio di carving casuale delle seam abbandona l'algoritmo tradizionale di seam carving, che è troppo lento per l'esecuzione in tempo reale nel browser.

Invece, genera un insieme di seam casuali che forniscono una copertura dell’immagine al 100% collegando ciascun pixel in una riga a un pixel adiacente nella successiva. Successivamente, itera attraverso ciascuna seam, ne calcola l’energia e scarta un gruppo di seam con energia più bassa. Questo processo si ripete fino a raggiungere il numero desiderato di seam. Questo metodo produce risultati sorprendentemente buoni per molte immagini.

### Ritaglio Predittivo

Simile al carving casuale, questo metodo genera una mappa energetica e crea seam in batch. Genera anche una mappa energetica minima per ogni batch. L’idea principale è creare sia seam "buone" che "cattive". Le seam buone hanno bassa energia e vengono mantenute. Le seam cattive incorporano pixel ad alta energia, permettendo che siano filtrate successivamente.

Partendo dalla prima riga, collega coppie di pixel alle corrispondenti coppie nella riga successiva. La seam a energia più bassa dal calcolo in corso viene collegata alla seam a energia più bassa della mappa energetica minima.

Il risultato è una seam realmente ottimale, molte seam "molto buone", molte seam "molto cattive" e molte mediocri. Selezioniamo un gruppo delle seam "buone", scartiamo le altre e ripetiamo il processo.

##

## DA FARE

### Priorità Alta

- [x] Componente web
- [x] Renderer che prende i dati dai generatori e scala a qualsiasi dimensione
- [x] Generatore casuale
- [x] Ritaglio verticale
- [x] Generatore predittivo
- [ ] Web worker per tutti i generatori
### Bassa Priorità

- [x] Mascheramento
- [ ] Riconoscimento facciale

### Sogno irrealizzabile

- [ ] Incisione 2D

## Licenza

Questo software è concesso in licenza secondo la Fluid-Img Revenue-Limited License.

**Uso gratuito** per individui e organizzazioni con un fatturato annuo inferiore a $10.000.000 USD.

**Licenza commerciale richiesta** per organizzazioni con un fatturato annuo pari o superiore a $10M. Contattare [licensing@voice.ngo] per i termini della licenza commerciale.

Consultare il file [LICENSE](./LICENSE) per i termini completi.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---