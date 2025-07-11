# Fluid Image Webkomponente

Bilder, die sich intelligent auf jede gewünschte Größe skalieren lassen (innerhalb vernünftiger Grenzen).

![Flüssige Bilder](https://raw.githubusercontent.com/VoiceNGO/fluid-img/refs/heads/main/resources/images/responsive-images.jpg)

**Winzig!:** 7kb minifiziert & gzip-komprimiert

## Verwendung

```html
<script src="fluid-img.js"></script>
<fluid-img src="image.jpg"></fluid-img>
```

Das war's. Skalieren Sie die Bilder nach Belieben, sie passen sich automatisch an.

## Demo

[Demo hier](https://voicengo.github.io/fluid-img/public/fluid-demo.html)

Ein Playground ist ebenfalls verfügbar, um [mit eigenen Bildern zu experimentieren](https://voicengo.github.io/fluid-img/public).
## Installation

### Client-Bibliothek

```sh
npm install fluid-img
```

Importieren Sie dann `fluid-img` in Ihr Projekt, welches die Web-Komponente bereitstellt und registriert:

```ts
import 'fluid-img';
```

Oder binden Sie das Skript von jsdelivr oder unpkg ein:

```html
<script src="https://cdn.jsdelivr.net/npm/fluid-img@latest/dist/fluid-img.js" />

<!-- oder -->

<script src="https://unpkg.com/fluid-img@latest/dist/fluid-img.js" />
```
### Hinweise

Die Fluid-Image-Komponente eignet sich am besten für das horizontale oder vertikale Skalieren von Bildern innerhalb eines Bereichs von etwa 0,5x bis 1,5x ihrer Originalgröße. Sie kann zwar auch größere oder kleinere Skalierungen bewältigen, jedoch kann die visuelle Qualität schnell abnehmen. Sie wird nicht empfohlen für Bilder, bei denen die exakte Pixeltreue entscheidend ist, wie Porträts, Diagramme oder detaillierte technische Zeichnungen, da das Nahtschnitzen (Seam Carving) Verzerrungen einführt. Es wird dringend empfohlen, Ihre Bilder in verschiedenen Größen zu testen, um sicherzustellen, dass sie Ihren visuellen Erwartungen entsprechen.

#### CORS

Aufgrund von Sicherheitseinschränkungen im Browser lösen Bilder, die von einer anderen Quelle (Domain, Protokoll oder Port) als die Webseite geladen werden, einen Cross-Origin Resource Sharing (CORS)-Fehler aus. Diese Komponente benötigt Zugriff auf die Rohpixel-Daten des Bildes, was durch CORS eingeschränkt wird.

Um Bilder von einer anderen Quelle zu verwenden, muss der Server, der die Bilder bereitstellt, so konfiguriert sein, dass er die entsprechenden CORS-Header sendet (z. B. `Access-Control-Allow-Origin: *` oder `Access-Control-Allow-Origin: your-domain.com`). Ohne diese Header kann die Komponente das Bild nicht verarbeiten.

(Zur Information: Zu Testzwecken hat jedes Bild auf imgur die erforderlichen CORS-Header.)

#### Fallback

Wenn die Komponente das Bild nicht laden oder verarbeiten kann oder einen internen Fehler wirft, wird sie auf elegante Weise auf das Einfügen eines Standard-`<img>`-Tags in die `<fluid-img>`-Komponente mit 100% Breite und Höhe zurückfallen, sodass das Bild weiterhin angezeigt wird.

## Optionen

Verwendung: `<fluid-img src="image.jpg" generator="random" max-carve-up-scale="5"></fluid-img>`

Standardmäßig wird der Generator `random` verwendet, da er am schnellsten ist.

| Option                         | Werte                            | Standard     | Beschreibung                                                                                                           |
| ------------------------------ | -------------------------------- | ------------ | ---------------------------------------------------------------------------------------------------------------------- |
| `src`                          | URL                              |              | Die URL des zu verarbeitenden Bildes.                                                                                 |
| `generator`                    | `random`, `predictive`           | `predictive` | Der zu verwendende Seam-Carving-Generator. `random` ist schneller, aber von geringerer Qualität.                      |
| `scaling-axis`                 | `horizontal`, `vertical`, `auto` | `horizontal` | Die Achse für die Skalierung. `auto` skaliert horizontal oder vertikal basierend auf Änderungen im Seitenverhältnis.   |
| `mask`                         | URL                              |              | Die URL eines Maskenbildes. Schwarze Bereiche der Maske haben eine geringere Energie und werden eher erhalten.         |
| `carving-priority`             | Zahl (0-1, z. B. `0.5`)          | `1`          | Der Prozentsatz der Skalierung, der durch Seam Carving im Vergleich zur traditionellen Bildskalierung durchgeführt wird.|
| `max-carve-up-seam-percentage` | Zahl (0-1, z. B. `0.5`)          | `0.6`        | Der maximale Prozentsatz der beim Vergrößern einzufügenden Nähte. Begrenzt das Einfügen neuer Nähte zur Wahrung der Bildqualität.|
| `max-carve-up-scale`           | Zahl (z. B. `3`)                 | `3`          | Der maximale Vergrößerungsfaktor mittels Seam Carving. Darüber hinaus wird eine traditionelle Skalierung verwendet.    |
| `max-carve-down-scale`         | Zahl (0-1, z. B. `0.7`)          | `0.7`        | Der maximale Prozentsatz des Bildes, der beim Verkleinern durch Seam Carving entfernt werden darf.                     |

### Generator-spezifische Optionen

Generator-spezifische Optionen werden zur `<fluid-img>`-Komponente hinzugefügt, sind jedoch nur gültig, wenn das entsprechende
`generator`-Attribut ebenfalls gesetzt ist.

#### Optionen für Zufalls- & Prädiktiven Generator

| Option              | Werte                  | Standard | Beschreibung                                            |
| ------------------- | ---------------------- | -------- | ------------------------------------------------------- |
| `batch-percentage`  | Zahl (0-1, z. B. 0.1)  | 0.1      | Der Prozentsatz der Nähte, die pro Batch generiert werden |
| `min-batch-size`    | Zahl (z. B. `10`)      | 10       | Die Mindestanzahl an Nähten, die pro Batch generiert werden |

## Funktionsweise

Seam Carving ist eine inhaltsbasierte Bildgrößenanpassungstechnik, die intelligent Pixel entfernt oder hinzufügt. Dadurch kann ein Bild ohne Verzerrung wichtiger Inhalte in der Größe verändert werden. Weitere Informationen finden Sie im [Wikipedia-Artikel](https://de.wikipedia.org/wiki/Seam_Carving) zu diesem Thema.

Historisch gesehen war Seam Carving für den Echtzeiteinsatz in Webbrowsern zu rechenintensiv. Dieses Problem kann jedoch durch alternative Algorithmen überwunden werden, die weniger anspruchsvoll sind und in vielen Szenarien gut funktionieren.

Es gibt zwei Implementierungen des Seam-Carving-Generators:
### Zufälliges Carving

Der Ansatz des zufälligen Seam Carving verzichtet auf den traditionellen Seam Carving Algorithmus, der für eine Ausführung in Echtzeit im Browser zu langsam ist.

Stattdessen wird eine Menge zufälliger Nähte erzeugt, die eine 100%ige Abdeckung des Bildes bieten, indem jeder Pixel in einer Zeile mit einem benachbarten Pixel in der nächsten Zeile verbunden wird. Anschließend wird jede Naht durchlaufen, ihre Energie berechnet und eine Charge der energieärmsten Nähte verworfen. Dieser Prozess wird wiederholt, bis die gewünschte Anzahl an Nähten erreicht ist. Diese Methode liefert für viele Bilder überraschend gute Ergebnisse.

### Prädiktives Carving

Ähnlich wie beim zufälligen Carving erzeugt diese Methode eine Energiekarte und erstellt Nähte in Chargen. Für jede Charge wird außerdem eine minimale Energiekarte erstellt. Die Kernidee besteht darin, sowohl „gute“ als auch „schlechte“ Nähte zu erzeugen. Gute Nähte haben eine geringe Energie und werden beibehalten. Schlechte Nähte enthalten Pixel mit hoher Energie, sodass sie später herausgefiltert werden können.

Ausgehend von der ersten Zeile werden Pixelpaare mit den entsprechenden Paaren in der nächsten Zeile verbunden. Die energieärmere Naht aus der laufenden Berechnung wird mit der energieärmeren Naht aus der minimalen Energiekarte verbunden.

Das Ergebnis ist eine wirklich optimale Naht, viele „sehr gute“ Nähte, viele „sehr schlechte“ Nähte und zahlreiche mittelmäßige. Wir wählen eine Charge der „guten“ Nähte aus, verwerfen den Rest und wiederholen den Prozess.

##

## TODO

### Hohe Priorität

- [x] Web-Komponente
- [x] Renderer, der Daten von Generatoren übernimmt und auf jede Größe skaliert
- [x] Zufallsgenerator
- [x] Vertikales Carving
- [x] Prädiktiver Generator
- [ ] Web Worker für alle Generatoren
### Niedrige Priorität

- [x] Maskierung
- [ ] Gesichtserkennung

### Wunschtraum

- [ ] 2D-Schnitzen

## Lizenzierung

Diese Software ist unter der Fluid-Img Revenue-Limited License lizenziert.

**Kostenlose Nutzung** für Einzelpersonen und Organisationen mit einem jährlichen Bruttoumsatz unter 10.000.000 USD.

**Kommerzielle Lizenz erforderlich** für Organisationen mit einem Jahresumsatz von 10 Mio. USD oder mehr. Kontaktieren Sie [licensing@voice.ngo] für kommerzielle Lizenzbedingungen.

Siehe die [LICENSE](./LICENSE)-Datei für vollständige Bedingungen.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---