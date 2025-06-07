# Stable Diffusion web UI
Interfejs internetowy dla Stable Diffusion, zaimplementowany przy użyciu biblioteki Gradio.

![](screenshot.png)

## Funkcje
[Szczegółowy przegląd funkcji ze zrzutami ekranu](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features):
- Oryginalne tryby txt2img i img2img
- Skrypt instalacji i uruchamiania jednym kliknięciem (należy wcześniej zainstalować Pythona i git)
- Outpainting
- Inpainting
- Color Sketch
- Prompt Matrix
- Stable Diffusion Upscale
- Attention – możliwość wskazania fragmentów tekstu, na które model powinien zwrócić większą uwagę
    - a man in a `((tuxedo))` – większa uwaga na smoking
    - a man in a `(tuxedo:1.21)` – alternatywna składnia
    - zaznacz tekst i naciśnij `Ctrl+Góra` lub `Ctrl+Dół` (lub `Command+Góra` / `Command+Dół` na MacOS), by automatycznie regulować uwagę na zaznaczony tekst (kod współtworzony przez anonimowego użytkownika)
- Loopback – wielokrotne przetwarzanie img2img
- Wykres X/Y/Z – sposób rysowania trójwymiarowych wykresów obrazów z różnymi parametrami
- Textual Inversion
    - dowolna liczba embeddingów i dowolne nazwy
    - możliwość użycia wielu embeddingów z różną liczbą wektorów na token
    - obsługa liczb zmiennoprzecinkowych o połowicznej precyzji
    - trening embeddingów na 8GB VRAM (są też doniesienia o pracy na 6GB)
- Zakładka Extras z:
    - GFPGAN – sieć neuronowa poprawiająca twarze
    - CodeFormer – narzędzie do rekonstrukcji twarzy, alternatywa dla GFPGAN
    - RealESRGAN – sieć neuronowa do powiększania obrazów
    - ESRGAN – sieć neuronowa do powiększania obrazów z wieloma modelami zewnętrznymi
    - SwinIR i Swin2SR ([szczegóły](https://github.com/AUTOMATIC1111/stable-diffusion-webui/pull/2092)), sieci neuronowe do powiększania obrazów
    - LDSR – powiększanie superrozdzielczości za pomocą latent diffusion
- Opcje zmiany proporcji przy skalowaniu
- Wybór metody próbkowania
    - Regulacja wartości eta samplera (mnożnik szumu)
    - Zaawansowane opcje ustawień szumu
- Możliwość przerwania przetwarzania w dowolnym momencie
- Obsługa kart graficznych 4GB VRAM (są też doniesienia o 2GB)
- Poprawne nasiona dla batchy
- Walidacja długości promptu w czasie rzeczywistym
- Parametry generowania
     - parametry użyte do wygenerowania obrazu są zapisywane z tym obrazem
     - w chunkach PNG dla PNG, w EXIF dla JPEG
     - przeciągnij obrazek do zakładki PNG info, by przywrócić parametry generowania i automatycznie skopiować je do UI
     - można wyłączyć w ustawieniach
     - przeciągnij i upuść obrazek/parametry tekstowe do promptboxa
- Przycisk "Read Generation Parameters" ładuje parametry promptu do UI
- Strona ustawień
- Uruchamianie dowolnego kodu Pythona z UI (należy uruchomić z `--allow-code`)
- Podpowiedzi po najechaniu myszką dla większości elementów UI
- Możliwość zmiany wartości domyślnych/min/maks/kroku elementów UI przez plik tekstowy konfiguracyjny
- Obsługa tilingu – opcja tworzenia obrazów możliwych do kafelkowania jak tekstury
- Pasek postępu i podgląd generowanego obrazu na żywo
    - Możliwość użycia oddzielnej sieci neuronowej do podglądu przy minimalnym użyciu VRAM i mocy obliczeniowej
- Negative prompt – dodatkowe pole tekstowe pozwalające określić, czego nie chcesz widzieć na obrazie
- Style – możliwość zapisania fragmentu promptu i późniejszego, łatwego użycia przez rozwijane menu
- Wariacje – generowanie tych samych obrazów z drobnymi różnicami
- Seed resizing – generowanie tego samego obrazu w lekko innej rozdzielczości
- CLIP interrogator – przycisk próbujący odgadnąć prompt z obrazu
- Prompt Editing – możliwość zmiany promptu w trakcie generacji, np. rozpoczęcie od arbuza i przejście do dziewczyny z anime w połowie procesu
- Batch Processing – przetwarzanie grupy plików przy użyciu img2img
- Img2img Alternative – odwrotna metoda Eulera kontroli cross-attention
- Highres Fix – opcja wygenerowania obrazów w wysokiej rozdzielczości jednym kliknięciem bez typowych zniekształceń
- Przeładowanie checkpointów bez restartu
- Checkpoint Merger – zakładka pozwalająca połączyć do 3 checkpointów w jeden
- [Skrypty niestandardowe](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Custom-Scripts) z wieloma rozszerzeniami społeczności
- [Composable-Diffusion](https://energy-based-model.github.io/Compositional-Visual-Generation-with-Composable-Diffusion-Models/) – możliwość używania wielu promptów jednocześnie
     - oddziel prompty wielkimi literami `AND`
     - obsługa wag promptów: `a cat :1.2 AND a dog AND a penguin :2.2`
- Brak limitu tokenów w promptach (oryginalny stable diffusion pozwalał na 75 tokenów)
- Integracja DeepDanbooru – generuje tagi w stylu danbooru dla promptów anime
- [xformers](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Xformers) – znaczne przyspieszenie dla wybranych kart (dodaj `--xformers` do argumentów linii poleceń)
- przez rozszerzenie: [Zakładka historii](https://github.com/yfszzx/stable-diffusion-webui-images-browser): wygodne przeglądanie, usuwanie i zarządzanie obrazami z poziomu UI
- Opcja "Generate forever"
- Zakładka treningu
     - opcje hypernetworków i embeddingów
     - Preprocessing obrazów: kadrowanie, odbijanie lustrzane, autotagowanie przez BLIP lub deepdanbooru (dla anime)
- Clip skip
- Hypernetworks
- Loras (jak Hypernetworks, ale bardziej przejrzyste)
- Oddzielny UI pozwalający wybierać (z podglądem) embeddingi, hypernetworki lub Loras do promptu
- Możliwość wyboru innego VAE z poziomu ustawień
- Szacowany czas zakończenia w pasku postępu
- API
- Obsługa dedykowanego [modelu inpaintingu](https://github.com/runwayml/stable-diffusion#inpainting-with-stable-diffusion) od RunwayML
- przez rozszerzenie: [Aesthetic Gradients](https://github.com/AUTOMATIC1111/stable-diffusion-webui-aesthetic-gradients) – generowanie obrazów o określonej estetyce przy użyciu embedów obrazów z CLIP (implementacja [https://github.com/vicgalle/stable-diffusion-aesthetic-gradients](https://github.com/vicgalle/stable-diffusion-aesthetic-gradients))
- Wsparcie dla [Stable Diffusion 2.0](https://github.com/Stability-AI/stablediffusion) – instrukcje w [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#stable-diffusion-20)
- Wsparcie dla [Alt-Diffusion](https://arxiv.org/abs/2211.06679) – instrukcje w [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#alt-diffusion)
- Teraz bez żadnych niepożądanych znaków!
- Ładowanie checkpointów w formacie safetensors
- Złagodzone ograniczenie rozdzielczości: wymiary wygenerowanego obrazu muszą być wielokrotnością 8 (zamiast 64)
- Teraz z licencją!
- Przestawianie elementów w UI z poziomu ustawień
- Wsparcie dla [Segmind Stable Diffusion](https://huggingface.co/segmind/SSD-1B)

## Instalacja i uruchamianie
Upewnij się, że spełnione są wymagane [zależności](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Dependencies) i postępuj według instrukcji dla:
- [NVidia](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs) (zalecane)
- [AMD](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-AMD-GPUs) GPU
- [Intel CPU, Intel GPU (zintegrowane i dedykowane)](https://github.com/openvinotoolkit/stable-diffusion-webui/wiki/Installation-on-Intel-Silicon) (zewnętrzna wiki)
- [Ascend NPU](https://github.com/wangshuai09/stable-diffusion-webui/wiki/Install-and-run-on-Ascend-NPUs) (zewnętrzna wiki)

Alternatywnie można korzystać z usług online (np. Google Colab):

- [Lista usług online](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Online-Services)

### Instalacja na Windows 10/11 z kartą NVidia przy użyciu paczki release
1. Pobierz `sd.webui.zip` z [v1.0.0-pre](https://github.com/AUTOMATIC1111/stable-diffusion-webui/releases/tag/v1.0.0-pre) i wypakuj zawartość.
2. Uruchom `update.bat`.
3. Uruchom `run.bat`.
> Szczegóły w [Install-and-Run-on-NVidia-GPUs](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs)

### Automatyczna instalacja na Windows
1. Zainstaluj [Python 3.10.6](https://www.python.org/downloads/release/python-3106/) (nowsze wersje nie obsługują torch), zaznaczając "Add Python to PATH".
2. Zainstaluj [git](https://git-scm.com/download/win).
3. Pobierz repozytorium stable-diffusion-webui, np. uruchamiając `git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui.git`.
4. Uruchom `webui-user.bat` z Eksploratora Windows jako zwykły (nie administrator) użytkownik.

### Automatyczna instalacja na Linux
1. Zainstaluj zależności:
```bash
# Dystrybucje Debian:
sudo apt install wget git python3 python3-venv libgl1 libglib2.0-0
# Dystrybucje Red Hat:
sudo dnf install wget git python3 gperftools-libs libglvnd-glx
# openSUSE:
sudo zypper install wget git python3 libtcmalloc4 libglvnd
# Arch:
sudo pacman -S wget git python3
```
Jeśli Twój system jest bardzo nowy, zainstaluj python3.11 lub python3.10:
```bash
# Ubuntu 24.04
sudo add-apt-repository ppa:deadsnakes/ppa
sudo apt update
sudo apt install python3.11

# Manjaro/Arch
sudo pacman -S yay
yay -S python311 # nie mylić z pakietem python3.11

# Tylko dla 3.11
# Następnie ustaw zmienną środowiskową w skrypcie startowym
export python_cmd="python3.11"
# lub w webui-user.sh
python_cmd="python3.11"
```
2. Przejdź do katalogu, w którym chcesz zainstalować webui i wykonaj polecenie:
```bash
wget -q https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/webui.sh
```
Lub po prostu sklonuj repozytorium gdzie chcesz:
```bash
git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui
```

3. Uruchom `webui.sh`.
4. Sprawdź `webui-user.sh` pod kątem opcji.
### Instalacja na Apple Silicon

Instrukcje znajdziesz [tutaj](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Installation-on-Apple-Silicon).

## Współtworzenie
Jak dodać kod do tego repozytorium: [Contributing](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Contributing)

## Dokumentacja

Dokumentacja została przeniesiona z tego README do [wiki projektu](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki).

Aby Google i inne wyszukiwarki mogły indeksować wiki, poniżej znajduje się link do (nie dla ludzi) [crawlable wiki](https://github-wiki-see.page/m/AUTOMATIC1111/stable-diffusion-webui/wiki).

## Zasługi
Licencje dla zapożyczonego kodu znajdują się w ekranie `Ustawienia -> Licencje` oraz w pliku `html/licenses.html`.

- Stable Diffusion - https://github.com/Stability-AI/stablediffusion, https://github.com/CompVis/taming-transformers, https://github.com/mcmonkey4eva/sd3-ref
- k-diffusion - https://github.com/crowsonkb/k-diffusion.git
- Spandrel - https://github.com/chaiNNer-org/spandrel implementujący
  - GFPGAN - https://github.com/TencentARC/GFPGAN.git
  - CodeFormer - https://github.com/sczhou/CodeFormer
  - ESRGAN - https://github.com/xinntao/ESRGAN
  - SwinIR - https://github.com/JingyunLiang/SwinIR
  - Swin2SR - https://github.com/mv-lab/swin2sr
- LDSR - https://github.com/Hafiidz/latent-diffusion
- MiDaS - https://github.com/isl-org/MiDaS
- Pomysły na optymalizacje - https://github.com/basujindal/stable-diffusion
- Optymalizacja warstwy Cross Attention - Doggettx - https://github.com/Doggettx/stable-diffusion, oryginalny pomysł na edycję promptu.
- Optymalizacja warstwy Cross Attention - InvokeAI, lstein - https://github.com/invoke-ai/InvokeAI (oryginalnie http://github.com/lstein/stable-diffusion)
- Sub-kwadratowa optymalizacja Cross Attention – Alex Birch (https://github.com/Birch-san/diffusers/pull/1), Amin Rezaei (https://github.com/AminRezaei0x443/memory-efficient-attention)
- Textual Inversion – Rinon Gal – https://github.com/rinongal/textual_inversion (nie używamy jego kodu, ale jego pomysły)
- Pomysł na SD upscale – https://github.com/jquesnelle/txt2imghd
- Generowanie szumu do outpaintingu mk2 – https://github.com/parlance-zz/g-diffuser-bot
- CLIP interrogator – pomysł i zapożyczenie fragmentów kodu – https://github.com/pharmapsychotic/clip-interrogator
- Pomysł na Composable Diffusion – https://github.com/energy-based-model/Compositional-Visual-Generation-with-Composable-Diffusion-Models-PyTorch
- xformers – https://github.com/facebookresearch/xformers
- DeepDanbooru – interrogator dla anime diffusers https://github.com/KichangKim/DeepDanbooru
- Próbkowanie w float32 z float16 UNet – marunine (pomysł), Birch-san (przykład Diffusers implementation) (https://github.com/Birch-san/diffusers-play/tree/92feee6)
- Instruct pix2pix – Tim Brooks (star), Aleksander Holynski (star), Alexei A. Efros (no star) – https://github.com/timothybrooks/instruct-pix2pix
- Porady bezpieczeństwa – RyotaK
- UniPC sampler – Wenliang Zhao – https://github.com/wl-zhao/UniPC
- TAESD – Ollin Boer Bohan – https://github.com/madebyollin/taesd
- LyCORIS – KohakuBlueleaf
- Restart sampling – lambertae – https://github.com/Newbeeer/diffusion_restart_sampling
- Hypertile – tfernd – https://github.com/tfernd/HyperTile
- Początkowy skrypt Gradio – opublikowany na 4chan przez anonimowego użytkownika. Dziękujemy anonimowemu użytkownikowi.
- (Ty)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---