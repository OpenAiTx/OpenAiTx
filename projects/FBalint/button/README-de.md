# 3D Drückbarer Button

Eine realistische 3D-Button-Komponente, erstellt mit HTML, CSS und SVG, die das Gefühl des Drückens eines physischen Buttons simuliert. Der Button bietet flüssige Animationen, anpassbare Farben und reaktionsschnelle Interaktionen.

Erstellt von [@BalintFerenczy](https://x.com/BalintFerenczy)

Inspiriert von der großartigen Arbeit bei [Resend](https://resend.com/)

## Funktionen

- **Realistisches 3D-Erscheinungsbild** durch geschichtete SVG-Grafiken
- **Sanfte Animationen** mit benutzerdefinierten Easing-Funktionen
- **Interaktive Zustände** – Hover- und Druckeffekte
- **Anpassbare Farben** durch CSS-Variablen
- **Responsives Design**, das sich an die Containergröße anpasst

## Demo
Die Schaltfläche reagiert auf Benutzerinteraktionen mit drei verschiedenen Zuständen:
- **Normal**: Die Schaltfläche in ihrer Ruhestellung
- **Hover**: Sanfte Abwärtsbewegung, wenn die Maus darüber schwebt
- **Aktiv**: Deutliche Abwärtsbewegung beim Drücken/Klicken

## Verwendung

### Anpassung

Die Schaltfläche kann einfach mit CSS-Custom Properties angepasst werden:

```css
.frame {
    /* Schaltflächendimensionen */
    width: 400px; 
    height: 400px; 

    /* Bewegungsdistanzen */
    --hover-travel: 3px;
    --press-travel: 40px;
    
    /* Farb-Anpassung */
    --color: black;
    --brightness: 1;
    --blend-mode: color;

    /* Übergangseinstellungen */
    --transition-duration: 0.4s;
    --transition-easing: ease-in-out;
}
```
#### Button-Text ändern

Ändern Sie einfach den Textinhalt:

```html
<p class="text">Klick mich!</p>
```

#### Button-Größe ändern

Passen Sie die Rahmenmaße an:

```css
.frame {
    width: 200px;
    height: 200px;
}
```
## Lizenz

Dieses Projekt ist Open Source und steht unter der MIT-Lizenz zur Verfügung.

## Beitragende

Du kannst dieses Projekt gerne forken und Pull Requests für Verbesserungen oder neue Funktionen einreichen!

## Autor

Erstellt von [@BalintFerenczy](https://x.com/BalintFerenczy)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---