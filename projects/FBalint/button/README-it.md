# Pulsante 3D Pressabile

Un componente di pulsante 3D realistico realizzato con HTML, CSS e SVG che simula la sensazione di premere un pulsante fisico. Il pulsante presenta animazioni fluide, colori personalizzabili e interazioni reattive.

Creato da [@BalintFerenczy](https://x.com/BalintFerenczy)

Ispirato al fantastico lavoro su [Resend](https://resend.com/)

## Caratteristiche

- **Aspetto 3D realistico** utilizzando grafica SVG a livelli
- **Animazioni fluide** con funzioni di easing personalizzate
- **Stati interattivi** - effetti al passaggio del mouse e alla pressione
- **Colori personalizzabili** tramite variabili CSS
- **Design responsivo** che si adatta alla dimensione del contenitore

## Demo
Il pulsante risponde alle interazioni dell'utente con tre stati distinti:
- **Normale**: Il pulsante nella sua posizione di riposo
- **Hover**: Leggero movimento verso il basso quando il mouse passa sopra
- **Attivo**: Movimento verso il basso più marcato quando viene premuto/cliccato

## Utilizzo

### Personalizzazione

Il pulsante può essere facilmente personalizzato utilizzando le proprietà personalizzate CSS:

```css
.frame {
    /* Dimensioni del pulsante */
    width: 400px; 
    height: 400px; 

    /* Distanze di movimento */
    --hover-travel: 3px;
    --press-travel: 40px;
    
    /* Personalizzazione dei colori */
    --color: black;
    --brightness: 1;
    --blend-mode: color;

    /* Impostazioni di transizione */
    --transition-duration: 0.4s;
    --transition-easing: ease-in-out;
}
```
#### Modifica del Testo del Pulsante

Semplicemente modifica il contenuto del testo:

```html
<p class="text">Clicca qui!</p>
```

#### Modifica della Dimensione del Pulsante

Regola le dimensioni del frame:

```css
.frame {
    width: 200px;
    height: 200px;
}
```
## Licenza

Questo progetto è open source e disponibile sotto licenza MIT.

## Contribuire

Sentiti libero di fare il fork di questo progetto e inviare pull request per miglioramenti o nuove funzionalità!

## Autore

Creato da [@BalintFerenczy](https://x.com/BalintFerenczy)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---