# Przycisk 3D do Naciskania

Realistyczny komponent przycisku 3D zbudowany przy użyciu HTML, CSS i SVG, który symuluje wrażenie naciskania fizycznego przycisku. Przycisk oferuje płynne animacje, możliwość dostosowania kolorów oraz responsywne interakcje.

Stworzony przez [@BalintFerenczy](https://x.com/BalintFerenczy)

Zainspirowany niesamowitą pracą zespołu [Resend](https://resend.com/)

## Funkcje

- **Realistyczny wygląd 3D** dzięki warstwowej grafice SVG
- **Płynne animacje** z niestandardowymi funkcjami łagodzenia
- **Interaktywne stany** – efekty najechania kursorem i naciśnięcia
- **Możliwość dostosowania kolorów** za pomocą zmiennych CSS
- **Responsywny design**, który dopasowuje się do rozmiaru kontenera

## Demo
Przycisk reaguje na interakcje użytkownika trzema różnymi stanami:
- **Normalny**: Przycisk w pozycji spoczynkowej
- **Najechanie**: Delikatny ruch w dół po najechaniu myszką
- **Aktywny**: Znaczący ruch w dół po naciśnięciu/kliknięciu

## Użycie

### Personalizacja

Przycisk można łatwo dostosować za pomocą niestandardowych właściwości CSS:

```css
.frame {
    /* Wymiary przycisku */
    width: 400px; 
    height: 400px; 

    /* Odległości ruchu */
    --hover-travel: 3px;
    --press-travel: 40px;
    
    /* Personalizacja kolorów */
    --color: black;
    --brightness: 1;
    --blend-mode: color;

    /* Ustawienia przejścia */
    --transition-duration: 0.4s;
    --transition-easing: ease-in-out;
}
```
#### Zmiana tekstu przycisku

Wystarczy zmodyfikować zawartość tekstową:

```html
<p class="text">Kliknij mnie!</p>
```

#### Zmiana rozmiaru przycisku

Dostosuj wymiary ramki:

```css
.frame {
    width: 200px;
    height: 200px;
}
```
## Licencja

Ten projekt jest open source i dostępny na licencji MIT.

## Wkład

Zachęcamy do forka tego projektu i przesyłania pull requestów z ulepszeniami lub nowymi funkcjami!

## Autor

Stworzony przez [@BalintFerenczy](https://x.com/BalintFerenczy)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---