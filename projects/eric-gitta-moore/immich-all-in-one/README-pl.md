<translate-content># Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~Docelowo planuję migrację do ente-io/ente, ponieważ potrzebuję s3 do przechowywania zdjęć~~
> 
> ente nadal ma zbyt mało funkcji
> 
> Zmieniono na użycie juicedata/juicefs do montowania s3

## Opis projektu

Projekt ten to rozwiązanie wzbogacające możliwości AI w systemie zarządzania zdjęciami [Immich](https://github.com/immich-app/immich). Rozwija natywne funkcje Immich głównie przez następujące komponenty:

- **inference-gateway**: bramka napisana w Go, odpowiedzialna za inteligentne przekierowywanie żądań ML z Immich
- **mt-photos-ai**: serwis AI oparty na Pythonie i FastAPI, integrujący modele RapidOCR i cn-clip
- Rozszerzenia funkcjonalności Immich, w tym wyszukiwanie tekstu OCR oraz ponowne przetwarzanie danych AI dla pojedynczych mediów, mieszane sortowanie na podstawie wektorów OCR i CLIP
- PostgreSQL z dodanym zhparser do segmentacji tekstu chińskiego

## Najważniejsze funkcje

### 1. Rozpoznawanie i wyszukiwanie tekstu OCR

- Wykorzystanie RapidOCR do rozpoznawania tekstu na obrazach
- Obsługa rozpoznawania tekstu w języku chińskim i angielskim
- Możliwość wyszukiwania na podstawie tekstu znajdującego się na zdjęciu

### 2. Przetwarzanie wektorów obrazów CLIP

- Dokładniejsze dopasowanie obraz-tekst w języku chińskim w oparciu o model cn-clip
- Wspiera wyszukiwanie semantyczne, zwiększając precyzję wyników

### 3. Ponowne przetwarzanie danych AI dla pojedynczych mediów

- Obsługa ponownego generowania danych OCR dla pojedynczego zdjęcia/wideo
- Obsługa ponownego generowania wektorów CLIP dla pojedynczego zdjęcia/wideo
- Możliwość ręcznego odświeżania w przypadku niedokładnych wyników rozpoznawania

## Architektura systemu
</translate-content>
```
┌─────────────┐      ┌──────────────────┐      ┌───────────────┐
│             │      │                  │      │               │
│   Immich    │─────▶│ inference-gateway│─────▶│  Immich ML    │
│   Server    │      │    (Go网关)      │      │   Server      │
│             │      │                  │      │               │
└─────────────┘      └──────────────────┘      └───────────────┘
                              │
                              │ OCR/CLIP请求
                              ▼
                     ┌──────────────────┐
                     │                  │
                     │   mt-photos-ai   │
                     │  (Python服务)    │
                     │                  │
                     └──────────────────┘
```
## Szczegółowy opis komponentów

### inference-gateway

Usługa bramki napisana w języku Go, główne zadania:
- Odbieranie żądań uczenia maszynowego od Immich
- Przekazywanie żądań OCR i CLIP do usługi mt-photos-ai w zależności od typu żądania
- Przekazywanie innych żądań uczenia maszynowego (np. rozpoznawania twarzy) do natywnej usługi uczenia maszynowego Immich
- Obsługa autoryzacji i konwersji formatów danych

### mt-photos-ai

Usługa AI napisana w Pythonie i FastAPI, oferuje:
- API do rozpoznawania tekstu OCR (oparte na RapidOCR)
- API do przetwarzania wektorów CLIP (oparte na cn-clip)
- Obsługa akceleracji GPU

## Instrukcja wdrożenia

### Wymagania środowiskowe

- Docker i Docker Compose
- Karta NVIDIA GPU (opcjonalnie, ale zalecana do przyspieszenia przetwarzania)
- Wystarczająca ilość miejsca na dysku

### Instrukcja konfiguracji

1. **Konfiguracja inference-gateway**

Główne zmienne środowiskowe:

```
IMMICH_API=http://localhost:3003  # Immich API地址
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai服务地址
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API密钥
PORT=8080  # 网关监听端口
```
2. **mt-photos-ai konfiguracja**

Główne zmienne środowiskowe:

```
CLIP_MODEL=ViT-B-16  # CLIP模型名称
CLIP_DOWNLOAD_ROOT=./models/clip  # 模型下载路径
DEVICE=cuda  # 或 cpu，推理设备
HTTP_PORT=8060  # 服务监听端口
```
### Kroki wdrożenia

1. Sklonuj repozytorium:

```bash
git clone https://github.com/你的用户名/immich-all-in-one.git
cd immich-all-in-one
```
2. Uruchom usługę:

```bash
docker-compose up -d
```
## Instrukcja użytkowania

1. **Konfiguracja Immich do używania niestandardowej usługi ML**

W pliku konfiguracyjnym Immich ustaw adres usługi uczenia maszynowego na inference-gateway:

```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```
2. **Użycie wyszukiwania OCR**

- W pasku wyszukiwania Immich użyj prefiksu `ocr:` do wyszukiwania OCR
- Na przykład: `ocr:faktura` wyszuka zdjęcia zawierające słowo "faktura" na obrazach

3. **Ponowne przetwarzanie danych AI dla pojedynczego medium**

- Na stronie szczegółów zdjęcia kliknij opcje menu
- Wybierz "Wygeneruj ponownie dane OCR" lub "Wygeneruj ponownie wektory CLIP"
- System ponownie przetworzy dane AI tego zdjęcia

## Przewodnik dla deweloperów

### inference-gateway (Go)

Kompilacja i uruchamianie:

```bash
cd inference-gateway
go build
./inference-gateway
```
### mt-photos-ai (Python)

Ustawienia środowiska deweloperskiego:

```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```
## Licencja

Ten projekt jest otwarty na licencji MIT.

## Podziękowania

- [Immich](https://github.com/immich-app/immich) - otwartoźródłowe, samodzielnie hostowane rozwiązanie do tworzenia kopii zapasowych zdjęć i filmów
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - wieloplatformowa biblioteka OCR oparta na PaddleOCR
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - chiński, multimodalny, wstępnie wytrenowany model uczenia przez porównanie



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---