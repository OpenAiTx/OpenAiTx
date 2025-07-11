# Komponent Webowy Fluid Image

Obrazy, które skalują się inteligentnie do dowolnego pożądanego rozmiaru (w rozsądnych granicach).

![Fluid Images](https://raw.githubusercontent.com/VoiceNGO/fluid-img/refs/heads/main/resources/images/responsive-images.jpg)

**Malutki!:** 7kb po minifikacji i kompresji gzip

## Użycie

```html
<script src="fluid-img.js"></script>
<fluid-img src="image.jpg"></fluid-img>
```

To wszystko. Skaluj obrazy według uznania, a one same się dopasują.

## Demo

[Zobacz demo](https://voicengo.github.io/fluid-img/public/fluid-demo.html)

Dostępny jest również playground do [eksperymentowania z własnymi obrazami](https://voicengo.github.io/fluid-img/public).
## Instalacja

### Biblioteka kliencka

```sh
npm install fluid-img
```

Następnie zaimportuj `fluid-img` w swoim projekcie, co zapewnia i rejestruje web-komponent:

```ts
import 'fluid-img';
```

Lub dołącz skrypt z jsdelivr albo unpkg:

```html
<script src="https://cdn.jsdelivr.net/npm/fluid-img@latest/dist/fluid-img.js" />

<!-- lub -->

<script src="https://unpkg.com/fluid-img@latest/dist/fluid-img.js" />
```
### Uwagi

Komponent płynnego obrazu najlepiej sprawdza się przy poziomym lub pionowym skalowaniu obrazów w zakresie około 0,5x do 1,5x ich oryginalnego rozmiaru. Chociaż może obsługiwać większe lub mniejsze skale, jakość wizualna może szybko ulec pogorszeniu. Nie jest zalecany dla obrazów, w których kluczowa jest precyzyjna integralność pikseli, takich jak portrety, wykresy czy szczegółowe rysunki techniczne, ponieważ szewkowanie (seam carving) wprowadza zniekształcenia. Zaleca się dokładne przetestowanie swoich obrazów w różnych rozmiarach, aby upewnić się, że spełniają oczekiwania wizualne.

#### CORS

Ze względu na ograniczenia bezpieczeństwa przeglądarki, obrazy ładowane z innego źródła (domeny, protokołu lub portu) niż strona internetowa wywołają błąd Cross-Origin Resource Sharing (CORS). Ten komponent wymaga dostępu do surowych danych pikselowych obrazu, co jest ograniczone przez CORS.

Aby używać obrazów z innego źródła, serwer hostujący obrazy musi być skonfigurowany do wysyłania odpowiednich nagłówków CORS (np. `Access-Control-Allow-Origin: *` lub `Access-Control-Allow-Origin: your-domain.com`). Bez tych nagłówków komponent nie będzie w stanie przetworzyć obrazu.

(Dla informacji: do celów testowych każdy obraz na imgur posiada wymagane nagłówki CORS)

#### Fallback

Jeśli komponent nie załaduje lub nie przetworzy obrazu, lub wystąpi błąd wewnętrzny, płynnie przełączy się na wstawienie standardowego znacznika `<img>` do komponentu `<fluid-img>`, z szerokością i wysokością 100%, aby obraz wciąż był wyświetlany.

## Opcje

Użycie: `<fluid-img src="image.jpg" generator="random" max-carve-up-scale="5"></fluid-img>`

Domyślnie używany jest generator `random`, ponieważ jest najszybszy.

| Opcja                          | Wartości                         | Domyślna     | Opis                                                                                                                   |
| ------------------------------ | -------------------------------- | ------------ | ---------------------------------------------------------------------------------------------------------------------- |
| `src`                          | URL                              |              | Adres URL obrazu do przetworzenia.                                                                                    |
| `generator`                    | `random`, `predictive`           | `predictive` | Generator szewkowania do użycia. `random` jest szybszy, ale o niższej jakości.                                        |
| `scaling-axis`                 | `horizontal`, `vertical`, `auto` | `horizontal` | Oś skalowania. `auto` skaluje poziomo lub pionowo w zależności od zmian proporcji.                                    |
| `mask`                         | URL                              |              | Adres URL obrazu maski. Czarne obszary maski mają niższą energię i są bardziej prawdopodobne do zachowania.           |
| `carving-priority`             | Liczba (0-1, np. `0.5`)           | `1`          | Procent skalowania realizowany przez szewkowanie względem tradycyjnego skalowania obrazu.                             |
| `max-carve-up-seam-percentage` | Liczba (0-1, np. `0.5`)           | `0.6`        | Maksymalny procent szwów do wstawienia przy skalowaniu w górę. Ogranicza tworzenie nowych szwów w celu zachowania jakości obrazu. |
| `max-carve-up-scale`           | Liczba (np. `3`)                  | `3`          | Maksymalny współczynnik powiększenia za pomocą szewkowania. Powyżej tej wartości używane jest tradycyjne skalowanie.   |
| `max-carve-down-scale`         | Liczba (0-1, np. `0.7`)           | `0.7`        | Maksymalny procent obrazu, który może zostać usunięty przez szewkowanie podczas zmniejszania rozmiaru.                |

### Opcje specyficzne dla generatora

Opcje specyficzne dla generatora są dodawane do komponentu `<fluid-img>`, ale są ważne tylko wtedy, gdy ustawiony jest również odpowiedni atrybut `generator`.

#### Opcje generatorów losowego i predykcyjnego

| Opcja               | Wartości               | Domyślna | Opis                                              |
| ------------------- | ---------------------- | -------- | ------------------------------------------------- |
| `batch-percentage`  | Liczba (0-1, np. 0.1)  | 0.1      | Procent szwów do wygenerowania na jedną partię    |
| `min-batch-size`    | Liczba (np. `10`)      | 10       | Minimalna liczba szwów do wygenerowania na partię |

## Jak to działa

Seam carving to technika zmiany rozmiaru obrazu z zachowaniem świadomości treści, która inteligentnie usuwa lub dodaje piksele, pozwalając na zmianę rozmiaru obrazu bez zniekształcania istotnych elementów. Więcej informacji można znaleźć w [artykule na Wikipedii](https://pl.wikipedia.org/wiki/Seam_carving) na ten temat.

Historycznie, seam carving był zbyt wymagający obliczeniowo, by można go było używać w czasie rzeczywistym w przeglądarkach internetowych. Ograniczenie to można jednak obejść, stosując alternatywne algorytmy, które są mniej zasobożerne i dobrze sprawdzają się w wielu przypadkach.

Istnieją dwie implementacje generatora seam carving:
### Losowe wycinanie

Podejście losowego wycinania szwów porzuca tradycyjny algorytm wycinania szwów, który jest zbyt wolny do wykonywania w czasie rzeczywistym w przeglądarce.

Zamiast tego generuje zestaw losowych szwów, które zapewniają 100% pokrycia obrazu, łącząc każdy piksel w jednym wierszu z sąsiadującym pikselem w następnym. Następnie przechodzi przez każdy szew, oblicza jego energię i odrzuca partię szwów o najniższej energii. Proces ten powtarza się, aż zostanie osiągnięta pożądana liczba szwów. Ta metoda daje zaskakująco dobre rezultaty dla wielu obrazów.

### Predykcyjne wycinanie

Podobnie jak losowe wycinanie, ta metoda generuje mapę energii i tworzy szwy partiami. Generuje także minimalną mapę energii dla każdej partii. Główną ideą jest stworzenie zarówno „dobrych”, jak i „złych” szwów. Dobre szwy mają niską energię i są zachowywane. Złe szwy zawierają piksele o wysokiej energii, co pozwala na ich późniejsze odfiltrowanie.

Zaczynając od pierwszego wiersza, łączy się pary pikseli z odpowiadającymi parami w następnym wierszu. Szew o niższej energii z bieżącego obliczenia łączony jest z szwem o niższej energii z minimalnej mapy energii.

Wynikiem jest jeden naprawdę optymalny szew, wiele „bardzo dobrych” szwów, wiele „bardzo złych” szwów i sporo przeciętnych. Wybieramy partię „dobrych” szwów, resztę odrzucamy i powtarzamy proces.

##

## DO ZROBIENIA

### Wysoki priorytet

- [x] Komponent webowy
- [x] Renderer pobierający dane z generatorów i skalujący do dowolnego rozmiaru
- [x] Generator losowy
- [x] Pionowe wycinanie
- [x] Generator predykcyjny
- [ ] Web workers dla wszystkich generatorów
### Niski priorytet

- [x] Maskowanie
- [ ] Rozpoznawanie twarzy

### Marzenie

- [ ] Rzeźbienie 2D

## Licencjonowanie

To oprogramowanie jest licencjonowane na podstawie licencji Fluid-Img Revenue-Limited License.

**Bezpłatne użycie** dla osób prywatnych i organizacji o rocznych przychodach brutto poniżej 10 000 000 USD.

**Wymagana licencja komercyjna** dla organizacji o rocznych przychodach powyżej 10 mln USD. Skontaktuj się z [licensing@voice.ngo], aby uzyskać warunki licencji komercyjnej.

Zobacz plik [LICENSE](./LICENSE) po pełne warunki.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---