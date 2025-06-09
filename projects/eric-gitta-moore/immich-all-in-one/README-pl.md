# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~Planuję przenieść się na ente-io/ente, ponieważ potrzebuję s3 do przechowywania zdjęć~~
> 
> Funkcjonalności ente są nadal zbyt ograniczone
> 
> Przełączono na użycie juicedata/juicefs do montowania s3

## Opis projektu

Projekt ten stanowi rozwiązanie rozszerzające możliwości AI systemu do zarządzania zdjęciami [Immich](https://github.com/immich-app/immich). Główne rozszerzenia natywnej funkcjonalności Immich realizowane są przez następujące komponenty:

- **inference-gateway**: bramka napisana w języku Go, odpowiedzialna za inteligentne przekierowywanie zapytań ML z Immich
- **mt-photos-ai**: usługa AI oparta na Pythonie i FastAPI, integrująca modele RapidOCR i cn-clip
- Rozszerzenie funkcji Immich, w tym wyszukiwanie tekstu OCR oraz ponowne przetwarzanie AI pojedynczych mediów, mieszane sortowanie OCR i CLIP na podstawie wektorów i wyników
- Dodanie segmentera chińskiego `zhparser` do PostgreSQL

## Główne funkcjonalności

### 1. Rozpoznawanie i wyszukiwanie tekstu OCR

- Wykorzystanie RapidOCR do rozpoznawania tekstu na zdjęciach
- Obsługa rozpoznawania tekstu mieszanego chińsko-angielskiego
- Możliwość wyszukiwania zdjęć na podstawie rozpoznanej treści tekstowej

### 2. Przetwarzanie wektorów obrazu CLIP

- Dokładniejsze dopasowanie obrazu i tekstu w języku chińskim w oparciu o model cn-clip
- Obsługa wyszukiwania semantycznego, zwiększająca precyzję wyszukiwania

### 3. Ponowne przetwarzanie AI pojedynczego medium

- Możliwość ponownego generowania danych OCR dla pojedynczego zdjęcia/wideo
- Możliwość ponownego generowania wektorów CLIP dla pojedynczego zdjęcia/wideo
- Ręczne odświeżanie danych w przypadku niedokładnych wyników rozpoznawania

## Architektura systemu

```
┌─────────────┐      ┌──────────────────┐      ┌───────────────┐
│             │      │                  │      │               │
│   Immich    │─────▶│ inference-gateway│─────▶│  Immich ML    │
│   Server    │      │    (Go bramka)   │      │   Server      │
│             │      │                  │      │               │
└─────────────┘      └──────────────────┘      └───────────────┘
                              │
                              │ Zapytania OCR/CLIP
                              ▼
                     ┌──────────────────┐
                     │                  │
                     │   mt-photos-ai   │
                     │  (Usługa Python) │
                     │                  │
                     └──────────────────┘
```

## Szczegóły komponentów

### inference-gateway

Bramka napisana w Go, główne zadania:
- Odbieranie zapytań ML z Immich
- Przekierowywanie zapytań OCR i CLIP do usługi mt-photos-ai na podstawie typu żądania
- Przekierowywanie innych zapytań ML (np. rozpoznawanie twarzy) do natywnej usługi ML Immich
- Obsługa autoryzacji i konwersji formatów danych

### mt-photos-ai

Usługa AI napisana w Pythonie (FastAPI), oferuje:
- API rozpoznawania tekstu OCR (w oparciu o RapidOCR)
- API przetwarzania wektorów CLIP (w oparciu o cn-clip)
- Obsługa akceleracji GPU

## Instrukcja wdrożenia

### Wymagania środowiskowe

- Docker i Docker Compose
- Karta NVIDIA GPU (opcjonalnie, zalecana dla przyspieszenia)
- Wystarczająca ilość miejsca na dane

### Konfiguracja

1. **Konfiguracja inference-gateway**

Główne zmienne środowiskowe:
```
IMMICH_API=http://localhost:3003  # Adres API Immich
MT_PHOTOS_API=http://localhost:8060  # Adres usługi mt-photos-ai
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # Klucz API
PORT=8080  # Port nasłuchu bramki
```

2. **Konfiguracja mt-photos-ai**

Główne zmienne środowiskowe:
```
CLIP_MODEL=ViT-B-16  # Nazwa modelu CLIP
CLIP_DOWNLOAD_ROOT=./models/clip  # Ścieżka pobierania modelu
DEVICE=cuda  # Lub cpu, urządzenie do inferencji
HTTP_PORT=8060  # Port nasłuchu usługi
```

### Kroki wdrożenia

1. Sklonuj repozytorium:
```bash
git clone https://github.com/TwojaNazwaUzytkownika/immich-all-in-one.git
cd immich-all-in-one
```

2. Uruchom usługę:
```bash
docker-compose up -d
```

## Instrukcja użytkowania

1. **Konfiguracja Immich do korzystania z niestandardowej usługi ML**

W pliku konfiguracyjnym Immich ustaw adres usługi ML na inference-gateway:
```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```

2. **Wyszukiwanie OCR**

- W pasku wyszukiwania Immich użyj prefiksu `ocr:` aby wyszukiwać za pomocą OCR
- Przykład: `ocr:发票` wyszuka zdjęcia, na których wykryto słowo "发票"

3. **Ponowne przetwarzanie AI pojedynczego medium**

- Na stronie szczegółów zdjęcia, kliknij menu opcji
- Wybierz "Ponownie wygeneruj dane OCR" lub "Ponownie wygeneruj wektor CLIP"
- System ponownie przetworzy dane AI dla tego zdjęcia

## Przewodnik dla deweloperów

### inference-gateway (Go)

Kompilacja i uruchomienie:
```bash
cd inference-gateway
go build
./inference-gateway
```

### mt-photos-ai (Python)

Konfiguracja środowiska deweloperskiego:
```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```

## Licencja

Projekt udostępniany na licencji MIT.

## Podziękowania

- [Immich](https://github.com/immich-app/immich) - Otwartoźródłowe rozwiązanie do backupu i hostowania zdjęć i wideo
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - Wieloplatformowa biblioteka OCR oparta na PaddleOCR
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - Chiński multimodalny model wstępnie wytrenowany do uczenia kontrastowego

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---