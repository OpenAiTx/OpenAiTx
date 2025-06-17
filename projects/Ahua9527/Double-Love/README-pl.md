# Double Love

<div align="center">

[![GitHub license](https://img.shields.io/github/license/Ahua9527/Double-Love)](https://github.com/Ahua9527/Double-Love/blob/main/LICENSE)
![GitHub stars](https://img.shields.io/github/stars/Ahua9527/Double-Love)

🎬 Klatki z miłością, podwójna wydajność

[//]: # (Ukryte Easter Egg w kodzie)
<!Double Love：Niech każda klatka kryje niewypowiedziany przeze mnie klatkaż -->

[English](https://raw.githubusercontent.com/Ahua9527/Double-Love/main/README.en.md) · 简体中文 · [Online demo](https://double-love.ahua.space)

</div>

Double Love zapewnia zautomatyzowane, standaryzowane przetwarzanie metadanych klapsów filmowych. Obsługuje pracę offline. Poprzez przetwarzanie wsadowe i lokalne umożliwia bezproblemową integrację z Adobe Premiere, Silverstack i DTG Slate, zapewniając spójność metadanych. Skutecznie zwiększa efektywność workflow postprodukcyjnego.

## ✨ Funkcje

- 🎬 Wsparcie dla zindustrializowanego workflow filmowego
- 📝 Inteligentna standaryzacja metadanych
- ⚡ Przetwarzanie lokalne bez opóźnień
- 🧩 Bezproblemowa integracja z Adobe Premiere

## 🚀 Szybki start

### Podstawowy workflow

1. Rejestracja klapsa: użyj DTG Slate do wygenerowania interaktywnej karty klapsa
2. Zarządzanie danymi: zaimportuj dane klapsa przez Silverstack Lab
3. Eksport pliku: wygeneruj XML dla Adobe Premiere Pro
4. Standaryzacja: zoptymalizuj automatycznie za pomocą Double Love

Przykład:
- Wejście xml: `UnitA_304_20250127.xml`
- Wyjście xml: `UnitA_304_20250127_Double_LOVE.xml`

### Szczegółowy przykład

#### Optymalizacja nazewnictwa plików
- Program automatycznie formatuje numery scen, ujęć i dubli
- Automatycznie dodaje zera wiodące do cyfr
- Automatycznie koryguje wielkość liter
- Automatycznie usuwa zbędne podkreślenia

#### Reguły nazywania klipów

Nazwy klipów po przetworzeniu mają następujący format:
```
{prefiks projektu}{scena}_{ujęcie}_{dubel}{kamera}{ocena}
```

- `prefix`: własny prefiks (opcjonalnie)
- `scene`: numer sceny (3 cyfry, np. 001)
- `shot`: numer ujęcia (2 cyfry, np. 01)
- `take`: numer dubla (2 cyfry, np. 01)
- `camera`: oznaczenie kamery (mała litera, np. a)
- `Rating`: ocena (ok/kp/ng)

#### Obsługa ocen
- `Circle` → `ok`
- `KEEP` → `kp`
- `NG` → `ng`

#### Informacja DIT
- Automatycznie dodaje informację DIT: 'DIT: 哆啦Ahua 🌱'
- Jeśli chcesz usunąć, wdroż wersję własną 😁😁

#### Przykład własnego prefiksu

1. Ustawienie prefiksu na "PROJECT_A_":
   - Plik wejściowy: `A304C007_250123G3`
   - Plik wyjściowy: `PROJECT_A_004_01_07a_kp`

2. Bez prefiksu:
   - Plik wejściowy: `A304C007_250123G3`
   - Plik wyjściowy: `004_01_07a_kp`

#### Przykład ustawienia rozdzielczości sekwencji

1. Rozdzielczość FHD (domyślnie):
   - Szerokość: 1920
   - Wysokość: 1080   
2. Rozdzielczość DCI 2K (niestandardowa):
   - Szerokość: 2048
   - Wysokość: 1080   

#### Przykład przetwarzania wsadowego

1. Prześlij kilka plików jednocześnie:
   ```
   UnitA_304_20250123.xml
   UnitA_305_20250124.xml
   UnitA_306_20250125.xml
   ```

2. Po przetworzeniu otrzymasz:
   ```
   UnitA_304_20250123_Double_LOVE.xml
   UnitA_305_20250124_Double_LOVE.xml
   UnitA_306_20250125_Double_LOVE.xml
   ```

## 🛠️ Stos technologiczny

- React 18
- TypeScript
- Vite
- Tailwind CSS
- Lucide Icons
- Wsparcie PWA

## 📦 Instalacja i użycie

1. Sklonuj repozytorium

```bash
git clone https://github.com/Ahua9527/Double-Love.git
cd Double-Love
```

2. Instaluj zależności

```bash
npm install
```

3. Rozwój lokalny

```bash
npm run dev
```

4. Budowanie projektu

```bash
npm run build
```

## 🔒 Informacje o bezpieczeństwie

- Całe przetwarzanie plików odbywa się lokalnie w przeglądarce, żadne pliki nie są wysyłane na serwer
- Obsługa plików o maksymalnym rozmiarze 50MB
- Obsługiwane są tylko pliki w formacie XML

## 🌈 Informacje dla deweloperów

### Struktura projektu

```
Double-Love/
├── src/
│   ├── components/     # Komponenty React
│   ├── context/       # React Context
│   ├── utils/         # Funkcje narzędziowe
│   ├── styles/        # Pliki stylów
│   └── App.tsx        # Główny komponent aplikacji
├── public/            # Zasoby statyczne
└── ...pliki konfiguracyjne
```


## 📃 Licencja

[MIT License](https://raw.githubusercontent.com/Ahua9527/Double-Love/main/LICENSE)

## 🤝 Wskazówki dotyczące współpracy

Zachęcamy do zgłaszania Issue i Pull Requestów!

## 👨‍💻 Autor

哆啦Ahua🌱

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---