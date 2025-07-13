# 3D Drukbare Knop

Een realistische 3D-knopcomponent gebouwd met HTML, CSS en SVG die het gevoel van het indrukken van een fysieke knop simuleert. De knop bevat soepele animaties, aanpasbare kleuren en responsieve interacties.

Gemaakt door [@BalintFerenczy](https://x.com/BalintFerenczy)

Geïnspireerd door het geweldige werk van [Resend](https://resend.com/)

## Kenmerken

- **Realistisch 3D-uiterlijk** met behulp van gelaagde SVG-graphics
- **Soepele animaties** met aangepaste easing-functies
- **Interactieve toestanden** - hover- en druk-effecten
- **Aanpasbare kleuren** via CSS-variabelen
- **Responsief ontwerp** dat schaalt met de grootte van de container

## Demo
De knop reageert op gebruikersinteracties met drie verschillende toestanden:
- **Normaal**: De knop in zijn rustpositie
- **Hover**: Subtiele neerwaartse beweging wanneer de muis eroverheen zweeft
- **Actief**: Significante neerwaartse beweging wanneer ingedrukt/aangeklikt

## Gebruik

### Aanpassen

De knop kan eenvoudig worden aangepast met behulp van CSS custom properties:

```css
.frame {
    /* Afmetingen van de knop */
    width: 400px; 
    height: 400px; 

    /* Afstanden van de beweging */
    --hover-travel: 3px;
    --press-travel: 40px;
    
    /* Kleurinstellingen */
    --color: black;
    --brightness: 1;
    --blend-mode: color;

    /* Overgangsinstellingen */
    --transition-duration: 0.4s;
    --transition-easing: ease-in-out;
}
```
#### Knoptekst wijzigen

Wijzig eenvoudig de tekstinhoud:

```html
<p class="text">Klik hier!</p>
```

#### Knopgrootte wijzigen

Pas de afmetingen van het frame aan:

```css
.frame {
    width: 200px;
    height: 200px;
}
```
## Licentie

Dit project is open source en beschikbaar onder de MIT-licentie.

## Bijdragen

Voel je vrij om dit project te forken en pull requests in te dienen voor verbeteringen of nieuwe functies!

## Auteur

Gemaakt door [@BalintFerenczy](https://x.com/BalintFerenczy)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---