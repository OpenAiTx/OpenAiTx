
<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Mapperatorinator

Wypróbuj model generatywny [tutaj](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb), lub MaiMod [tutaj](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb). Zobacz prezentację wideo [tutaj](https://youtu.be/FEr7t1L2EoA).

Mapperatorinator to wielomodelowa platforma wykorzystująca wejścia spektrogramowe do generowania w pełni funkcjonalnych beatmap osu! dla wszystkich trybów gry oraz [wspomagania moderacji beatmap](#maimod-the-ai-driven-modding-tool).
Celem tego projektu jest automatyczne generowanie beatmap osu! o rankowalnej jakości z dowolnej piosenki, z wysokim stopniem możliwości personalizacji.

Projekt bazuje na [osuT5](https://github.com/gyataro/osuT5) oraz [osu-diffusion](https://github.com/OliBomby/osu-diffusion). Podczas tworzenia poświęciłem około 2500 godzin obliczeń GPU podczas 142 sesji na moim 4060 Ti oraz wynajmowanych instancjach 4090 na vast.ai.

#### Używaj tego narzędzia odpowiedzialnie. Zawsze ujawniaj wykorzystanie AI w swoich beatmapach.

## Instalacja

Instrukcja poniżej pozwala na generowanie beatmap na Twoim lokalnym komputerze, alternatywnie możesz uruchomić ją w chmurze za pomocą [notatnika colab](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb).

### 1. Sklonuj repozytorium

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2. (Opcjonalnie) Utwórz środowisko wirtualne

Użyj Pythona 3.10, nowsze wersje mogą być niekompatybilne z zależnościami.

```sh
python -m venv .venv

# In cmd.exe
.venv\Scripts\activate.bat
# In PowerShell
.venv\Scripts\Activate.ps1
# In Linux or MacOS
source .venv/bin/activate
```

### 3. Zainstaluj zależności

- Python 3.10
- [Git](https://git-scm.com/downloads)
- [ffmpeg](http://www.ffmpeg.org/)
- [CUDA](https://developer.nvidia.com/cuda-zone) (dla GPU NVIDIA) lub [ROCm](https://rocmdocs.amd.com/en/latest/Installation_Guide/Installation-Guide.html) (dla GPU AMD na Linuksie)
- [PyTorch](https://pytorch.org/get-started/locally/): Upewnij się, że postępujesz zgodnie z przewodnikiem Get Started, aby zainstalować `torch` i `torchaudio` z obsługą GPU. Wybierz odpowiednią wersję Compute Platform, którą zainstalowałeś w poprzednim kroku.

- oraz pozostałe zależności Pythona:

```sh
pip install -r requirements.txt
```

## Graficzny interfejs WWW (zalecane)

Dla bardziej przyjaznej obsługi zalecamy użycie interfejsu WWW. Zapewnia on graficzny interfejs do konfiguracji parametrów generowania, uruchamiania procesu oraz monitorowania wyników.

### Uruchomienie GUI

Przejdź do sklonowanego katalogu `Mapperatorinator` w terminalu i uruchom:

```sh
python web-ui.py
```

To uruchomi lokalny serwer WWW i automatycznie otworzy interfejs użytkownika w nowym oknie.

### Korzystanie z GUI

- **Konfiguracja:** Ustaw ścieżki wejścia/wyjścia za pomocą pól formularza i przycisków "Przeglądaj". Dostosuj parametry generowania takie jak tryb gry, poziom trudności, styl (rok, ID mappera, deskryptory), timing, konkretne funkcje (hitsounds, super timing) i więcej, odzwierciedlając opcje z wiersza poleceń. (Uwaga: Jeśli podasz `beatmap_path`, interfejs automatycznie określi `audio_path` oraz `output_path`, więc możesz zostawić te pola puste)
- **Start:** Kliknij przycisk "Start Inference", aby rozpocząć generowanie beatmapy.
- **Anuluj:** Możesz zatrzymać trwający proces, korzystając z przycisku "Cancel Inference".
- **Otwórz wyjście:** Po zakończeniu użyj przycisku "Otwórz folder wyjściowy", aby szybko uzyskać dostęp do wygenerowanych plików.

Web UI działa jako wygodna nakładka na skrypt `inference.py`. W celu uzyskania zaawansowanych opcji lub rozwiązywania problemów, zapoznaj się z instrukcjami wiersza poleceń.

![python_u3zyW0S3Vs](https://github.com/user-attachments/assets/5312a45f-d51c-4b37-9389-da3258ddd0a1)

## Wnioskowanie z wiersza poleceń

Dla użytkowników preferujących wiersz poleceń lub wymagających dostępu do zaawansowanych ustawień, postępuj zgodnie z poniższymi krokami. **Uwaga:** Dla prostszego interfejsu graficznego zobacz sekcję [Web UI (Zalecane)](#web-ui-recommended) powyżej.

Uruchom `inference.py` i przekaż odpowiednie argumenty, aby wygenerować beatmapy. Użyj w tym celu [składni nadpisywania Hydra](https://hydra.cc/docs/advanced/override_grammar/basic/). Wszystkie dostępne parametry znajdziesz w `configs/inference_v29.yaml`.
```
python inference.py \
  audio_path           [Path to input audio] \
  output_path          [Path to output directory] \
  beatmap_path         [Path to .osu file to autofill metadata, and output_path, or use as reference] \
  
  gamemode             [Game mode to generate 0=std, 1=taiko, 2=ctb, 3=mania] \
  difficulty           [Difficulty star rating to generate] \
  mapper_id            [Mapper user ID for style] \
  year                 [Upload year to simulate] \
  hitsounded           [Whether to add hitsounds] \
  slider_multiplier    [Slider velocity multiplier] \
  circle_size          [Circle size] \
  keycount             [Key count for mania] \
  hold_note_ratio      [Hold note ratio for mania 0-1] \
  scroll_speed_ratio   [Scroll speed ratio for mania and ctb 0-1] \
  descriptors          [List of beatmap user tags for style] \
  negative_descriptors [List of beatmap user tags for classifier-free guidance] \
  
  add_to_beatmap       [Whether to add generated content to the reference beatmap instead of making a new beatmap] \
  start_time           [Generation start time in milliseconds] \
  end_time             [Generation end time in milliseconds] \
  in_context           [List of additional context to provide to the model [NONE,TIMING,KIAI,MAP,GD,NO_HS]] \
  output_type          [List of content types to generate] \
  cfg_scale            [Scale of the classifier-free guidance] \
  super_timing         [Whether to use slow accurate variable BPM timing generator] \
  seed                 [Random seed for generation] \
```

Przykład:
```
python inference.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'" gamemode=0 difficulty=5.5 year=2023 descriptors="['jump aim','clean']" in_context=[TIMING,KIAI]
```

## Interaktywny CLI
Dla osób preferujących pracę w terminalu, które chcą przejść przez konfigurację krok po kroku, interaktywny skrypt CLI jest doskonałą alternatywą dla interfejsu Web UI.

### Uruchomienie CLI
Przejdź do sklonowanego katalogu. Może być konieczne nadanie skryptowi uprawnień do wykonywania.

```sh
# Make the script executable (only needs to be done once)
chmod +x cli_inference.sh
```

```sh
# Run the script
./cli_inference.sh
```

### Używanie CLI
Skrypt przeprowadzi cię przez serię pytań konfiguracyjnych dotyczących wszystkich parametrów generowania, podobnie jak interfejs Web UI.

Wykorzystuje interfejs z kolorowym kodowaniem dla przejrzystości.
Oferuje zaawansowane menu wielokrotnego wyboru do wybierania deskryptorów stylu za pomocą klawiszy strzałek i spacji.
Po udzieleniu odpowiedzi na wszystkie pytania, wyświetli końcową komendę do przejrzenia.
Możesz wtedy potwierdzić jej wykonanie bezpośrednio lub anulować i skopiować komendę do ręcznego użycia.

## Wskazówki dotyczące generowania

- Możesz edytować plik `configs/inference_v29.yaml` i dodać tam swoje argumenty zamiast wpisywać je za każdym razem w terminalu.
- Wszystkie dostępne deskryptory znajdziesz [tutaj](https://osu.ppy.sh/wiki/en/Beatmap/Beatmap_tags).
- Zawsze podawaj argument roku pomiędzy 2007 a 2023. Jeśli pozostawisz go nieznanym, model może wygenerować beatmapę o niespójnym stylu.
- Zawsze podawaj argument trudności. Jeśli pozostawisz go nieznanym, model może wygenerować beatmapę o niespójnej trudności.
- Zwiększ parametr `cfg_scale`, aby zwiększyć skuteczność argumentów `mapper_id` oraz `descriptors`.
- Możesz użyć argumentu `negative_descriptors`, by odciągnąć model od niektórych stylów. Działa to tylko, gdy `cfg_scale > 1`. Upewnij się, że liczba negatywnych deskryptorów jest równa liczbie deskryptorów.
- Jeśli styl twojej piosenki i pożądany styl beatmapy nie pasują do siebie, model może nie wykonać twoich poleceń. Na przykład trudno wygenerować beatmapę o wysokim SR, wysokim SV dla spokojnej piosenki.
- Jeśli masz już gotowe czasy timingów i kiai dla utworu, możesz je przekazać modelowi, znacznie zwiększając szybkość i dokładność wnioskowania: użyj argumentów `beatmap_path` oraz `in_context=[TIMING,KIAI]`.
- Aby zremapować tylko fragment beatmapy, użyj argumentów `beatmap_path`, `start_time`, `end_time` oraz `add_to_beatmap=true`.
- Aby wygenerować gościnną trudność dla beatmapy, użyj argumentów `beatmap_path` oraz `in_context=[GD,TIMING,KIAI]`.
- Aby wygenerować hitsoundy dla beatmapy, użyj argumentów `beatmap_path` oraz `in_context=[NO_HS,TIMING,KIAI]`.
- Aby wygenerować tylko timing dla utworu, użyj argumentów `super_timing=true` oraz `output_type=[TIMING]`.

## MaiMod: Narzędzie do modowania wspierane przez AI

MaiMod to narzędzie do modowania beatmap osu!, które wykorzystuje predykcje Mapperatorinator do wykrywania potencjalnych błędów i niespójności, których nie wykrywają inne automatyczne narzędzia do modowania, takie jak [Mapset Verifier](https://github.com/Naxesss/MapsetVerifier).
Może wykryć takie problemy jak:
- Nieprawidłowe snapowanie lub wzorce rytmiczne
- Niedokładne punkty timingowe
- Niespójne pozycje obiektów lub oznaczenia nowych combo
- Dziwne kształty sliderów
- Niespójne hitsoundy lub głośności

Możesz wypróbować MaiMod [tutaj](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb) lub uruchomić go lokalnie:
Aby uruchomić MaiMod lokalnie, musisz zainstalować Mapperatorinator. Następnie uruchom skrypt `mai_mod.py`, podając ścieżkę do swojej beatmapy argumentem `beatmap_path`.
```sh
python mai_mod.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'"
```
To wydrukuje sugestie dotyczące modyfikacji na konsoli, które następnie możesz ręcznie zastosować do swojej beatmapy.
Sugestie są uporządkowane chronologicznie i pogrupowane w kategorie.
Pierwsza wartość w okręgu wskazuje „zaskoczenie”, czyli miarę tego, jak bardzo model uznał dany problem za nieoczekiwany, dzięki czemu możesz nadać priorytet najważniejszym kwestiom.

Model może popełniać błędy, szczególnie w przypadku problemów o niskim zaskoczeniu, więc zawsze dokładnie sprawdzaj sugestie przed ich zastosowaniem do swojej beatmapy.
Głównym celem jest pomoc w zawężeniu obszaru poszukiwań potencjalnych problemów, abyś nie musiał ręcznie sprawdzać każdego pojedynczego obiektu w beatmapie.

### MaiMod GUI
Aby uruchomić MaiMod Web UI, musisz zainstalować Mapperatorinator.
Następnie uruchom skrypt `mai_mod_ui.py`. Spowoduje to uruchomienie lokalnego serwera WWW i automatyczne otwarcie interfejsu użytkownika w nowym oknie:

```sh
python mai_mod_ui.py
```

<img width="850" height="1019" alt="afbeelding" src="https://github.com/user-attachments/assets/67c03a43-a7bd-4265-a5b1-5e4d62aca1fa" />

## Przegląd

### Tokenizacja

Mapperatorinator konwertuje beatmapy osu! na pośrednią reprezentację zdarzeń, którą można bezpośrednio konwertować na tokeny i z powrotem.
Uwzględnia obiekty trafień, dźwięki trafień, prędkości sliderów, nowe kombosy, punkty tempa, czasy kiai oraz prędkości przewijania taiko/mania.

Oto krótki przykład procesu tokenizacji:

![mapperatorinator_parser](https://github.com/user-attachments/assets/84efde76-4c27-48a1-b8ce-beceddd9e695)

Aby zaoszczędzić na wielkości słownika, zdarzenia czasowe są kwantyzowane do 10 ms, a współrzędne pozycji do siatki co 32 piksele.

### Architektura modelu
Model jest w zasadzie nakładką na [HF Transformers Whisper](https://huggingface.co/docs/transformers/en/model_doc/whisper#transformers.WhisperForConditionalGeneration), z niestandardowymi osadzeniami wejściowymi i funkcją straty.
Wielkość modelu to 219M parametrów.
Ten model okazał się szybszy i dokładniejszy od T5 dla tego zadania.

Ogólny schemat wejścia-wyjścia modelu wygląda następująco:

![Picture2](https://user-images.githubusercontent.com/28675590/201044116-1384ad72-c540-44db-a285-7319dd01caad.svg)

Model używa klatek spektrogramu Mel jako wejścia enkodera, jedna klatka na pozycję wejściową. Wyjście dekodera na każdym kroku to rozkład softmax nad dyskretnym, zdefiniowanym z góry słownikiem zdarzeń. Wyjścia są rzadkie, zdarzenia są potrzebne tylko gdy występuje obiekt trafienia, zamiast adnotacji dla każdej pojedynczej klatki audio.

### Format treningu multitaskowego

![Multitask training format](https://github.com/user-attachments/assets/62f490bc-a567-4671-a7ce-dbcc5f9cd6d9)

Przed tokenem SOS znajdują się dodatkowe tokeny ułatwiające generowanie warunkowe. Tokeny te obejmują tryb gry, trudność, ID mapera, rok i inne metadane.
Podczas treningu tokeny te nie mają przypisanych etykiet, więc nigdy nie są generowane przez model.
Podczas treningu istnieje także losowa szansa, że token metadanych zostanie zastąpiony tokenem 'nieznanym', dzięki czemu podczas inferencji możemy użyć tych tokenów 'nieznanych', by ograniczyć ilość metadanych przekazywanych do modelu.

### Płynne długie generowanie

Długość kontekstu modelu to 8,192 sekundy. To oczywiście za mało, by wygenerować całą beatmapę, więc musimy podzielić utwór na kilka okien i generować beatmapę małymi fragmentami.
Aby wygenerowana beatmapa nie miała widocznych szwów między oknami, używamy 90% nakładania i generujemy okna sekwencyjnie.
Każde okno generacji z wyjątkiem pierwszego zaczyna się z dekoderem wstępnie wypełnionym do 50% długości okna tokenami z poprzednich okien.
Używamy procesora logitów, aby upewnić się, że model nie może generować tokenów czasu, które znajdują się w pierwszych 50% okna generacji.
Dodatkowo, ostatnie 40% okna generacji jest zarezerwowane dla następnego okna. Wszelkie wygenerowane tokeny czasu w tym zakresie są traktowane jako tokeny EOS.
Zapewnia to, że każdy wygenerowany token jest uzależniony od co najmniej 4 sekund poprzednich tokenów i 3,3 sekundy przyszłego dźwięku do przewidzenia.

Aby zapobiec dryfowi offsetu podczas długiej generacji, do zdarzeń czasowych w dekoderze podczas treningu dodano losowe offsety.
Wymusza to korygowanie błędów czasowych poprzez nasłuchiwanie ataków w audio, co skutkuje konsekwentnie dokładnym offsetem.

### Udoskonalone współrzędne z dyfuzją

Współrzędne pozycji generowane przez dekoder są kwantowane do siatki o oczkach 32 pikseli, dlatego później używamy dyfuzji do odszumiania współrzędnych do ostatecznych pozycji.
W tym celu wytrenowaliśmy zmodyfikowaną wersję [osu-diffusion](https://github.com/OliBomby/osu-diffusion), która jest wyspecjalizowana tylko do ostatnich 10% harmonogramu szumu i akceptuje bardziej zaawansowane tokeny metadanych, których Mapperatorinator używa do warunkowej generacji.

Ponieważ model Mapperatorinator generuje SV sliderów, wymagana długość slidera jest stała niezależnie od kształtu ścieżki punktów kontrolnych.
Dlatego staramy się ukierunkować proces dyfuzji na tworzenie współrzędnych pasujących do wymaganych długości sliderów.
Robimy to, przeliczając pozycje końcowe slidera po każdym kroku procesu dyfuzji na podstawie wymaganej długości i aktualnej ścieżki punktów kontrolnych.
Oznacza to, że proces dyfuzji nie ma bezpośredniej kontroli nad pozycjami końcowymi slidera, ale nadal może je wpływać, zmieniając ścieżkę punktów kontrolnych.

### Post-processing

Mapperatorinator wykonuje dodatkową post-obróbkę w celu poprawy jakości wygenerowanej beatmapy:

- Udoskonal współrzędne pozycji za pomocą dyfuzji.
- Przyciągnij zdarzenia czasowe do najbliższego taktu, używając podziałek snap wygenerowanych przez model.
- Przyciągnij niemal idealne nakładki pozycyjne.
- Konwertuj zdarzenia kolumn mania na współrzędne X.
- Generuj ścieżki sliderów dla taiko drumrolls.
- Napraw duże rozbieżności między wymaganą długością slidera a długością ścieżki punktów kontrolnych.

### Generator super-timingu

Generator super-timingu to algorytm, który poprawia precyzję i dokładność generowanego timingu poprzez wywnioskowanie timingu dla całej piosenki 20 razy i uśrednienie wyników.
Jest to przydatne dla utworów o zmiennym BPM lub utworów ze zmianami BPM. Wynik jest niemal idealny, czasami tylko jedna sekcja wymaga ręcznej korekty.

## Trening

Instrukcja poniżej tworzy środowisko treningowe na Twoim lokalnym komputerze.

### 1. Sklonuj repozytorium

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2. Utwórz zestaw danych

Utwórz własny zestaw danych za pomocą [aplikacji konsolowej Mapperator](https://github.com/mappingtools/Mapperator/blob/master/README.md#create-a-high-quality-dataset). Wymaga ona [osu! OAuth client token](https://osu.ppy.sh/home/account/edit), aby weryfikować beatmapy i pobierać dodatkowe metadane. Umieść zestaw danych w katalogu `datasets` obok katalogu `Mapperatorinator`.

```sh
Mapperator.ConsoleApp.exe dataset2 -t "/Mapperatorinator/datasets/beatmap_descriptors.csv" -i "path/to/osz/files" -o "/datasets/cool_dataset"
```

### 3. (Opcjonalnie) Skonfiguruj Weight & Biases do rejestrowania
Załóż konto na [Weight & Biases](https://wandb.ai/site) i pobierz swój klucz API z ustawień konta.
Następnie ustaw zmienną środowiskową `WANDB_API_KEY`, aby proces treningu wiedział, na który klucz logować.

```sh
export WANDB_API_KEY=<your_api_key>
```

### 4. Utwórz kontener Docker
Szkolenie w twoim venv jest również możliwe, ale zalecamy użycie Dockera na WSL dla lepszej wydajności.
```sh
docker compose up -d --force-recreate
docker attach mapperatorinator_space
cd Mapperatorinator
```

### 5. Skonfiguruj parametry i rozpocznij trening

Wszystkie konfiguracje znajdują się w pliku `./configs/train/default.yaml`. 
Upewnij się, że ustawiłeś poprawne `train_dataset_path` oraz `test_dataset_path` do swojego zbioru danych, a także indeksy mapsetu początkowego i końcowego dla podziału train/test.
Ścieżka jest lokalna względem kontenera Docker, więc jeśli umieściłeś swój zbiór danych o nazwie `cool_dataset` w katalogu `datasets`, to powinna ona być `/workspace/datasets/cool_dataset`.

Zalecam utworzenie własnego pliku konfiguracyjnego, który nadpisuje domyślną konfigurację, aby mieć zapis konfiguracji treningu dla powtarzalności.

```yaml
data:
  train_dataset_path: "/workspace/datasets/cool_dataset"
  test_dataset_path: "/workspace/datasets/cool_dataset"
  train_dataset_start: 0
  train_dataset_end: 90
  test_dataset_start: 90
  test_dataset_end: 100
```

Begin training by calling `python osuT5/train.py` or `torchrun --nproc_per_node=NUM_GPUS osuT5/train.py` for multi-GPU training.


```sh
python osuT5/train.py -cn train_v29 train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```

### 6. Dostrajanie LoRA

Możesz również dostroić wstępnie wytrenowany model za pomocą [LoRA](https://arxiv.org/abs/2106.09685), aby dostosować go do konkretnego stylu lub trybu gry.
Aby to zrobić, dostosuj `configs/train/lora.yaml` do swoich potrzeb i uruchom konfigurację treningową `lora`:

```sh
python osuT5/train.py -cn lora train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```

Ważne parametry LoRA do rozważenia:
- `pretrained_path`: Ścieżka lub repozytorium HF bazowego modelu do dalszego trenowania.
- `r`: Ranga macierzy LoRA. Wyższe wartości zwiększają pojemność modelu, ale także zużycie pamięci.
- `lora_alpha`: Współczynnik skalowania dla aktualizacji LoRA.
- `total_steps`: Całkowita liczba kroków treningowych. Wyważ ją w zależności od wielkości zbioru danych.
- `enable_lora`: Czy używać LoRA czy pełnego tuningu modelu.

Podczas wnioskowania możesz określić wagę LoRA za pomocą argumentu `lora_path`.
Może to być lokalna ścieżka lub repozytorium Hugging Face.

## Zobacz także
- [Mapper Classifier](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./classifier/README.md)
- [RComplexion](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./rcomplexion/README.md)

## Podziękowania

Szczególne podziękowania dla:
1. Autorów [osuT5](https://github.com/gyataro/osuT5) za kod treningowy.
2. Zespołu Hugging Face za ich [narzędzia](https://huggingface.co/docs/transformers/index).
3. [Jason Won](https://github.com/jaswon) i [Richard Nagyfi](https://github.com/sedthh) za wymianę pomysłów.
4. [Marvin](https://github.com/minetoblend) za przekazanie kredytów treningowych.
5. Społeczności osu! za beatmapy.

## Powiązane projekty

1. [osu! Beatmap Generator](https://github.com/Syps/osu_beatmap_generator) autorstwa Syps (Nick Sypteras)
2. [osumapper](https://github.com/kotritrona/osumapper) autorstwa kotritrona, jyvden, Yoyolick (Ryan Zmuda)
3. [osu-diffusion](https://github.com/OliBomby/osu-diffusion) autorstwa OliBomby (Olivier Schipper), NiceAesth (Andrei Baciu)
4. [osuT5](https://github.com/gyataro/osuT5) autorstwa gyataro (Xiwen Teoh)
5. [Beat Learning](https://github.com/sedthh/BeatLearning) autorstwa sedthh (Richard Nagyfi)
6. [osu!dreamer](https://github.com/jaswon/osu-dreamer) autorstwa jaswon (Jason Won)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-24

---