<p align="center">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/logo.png" alt="Logo silnika Basketo Game Engine" width="200"/>
</p>

<h2 align="center">Twórz, Graj, Inspiruj. Gry ożywają. ✨</h2>

<h1 align="center">Basketo Game Engine</h1>

<div align="center">

[![Discord](https://img.shields.io/discord/1373185493742911609?logo=discord&label=Discord&color=5B5BD6&logoColor=white)](https://discord.gg/F3DswRMW) <!-- Zamień your_discord_server_id na swój rzeczywisty identyfikator serwera -->
[![GitHub stars](https://img.shields.io/github/stars/basketoengine/Basketo?style=social)](https://github.com/basketoengine/Basketo)
[![X (formerly Twitter)](https://img.shields.io/twitter/follow/BaslaelWorkneh?style=social&logo=x)](https://x.com/BaslaelWorkneh)

</div>

<p align="center">
Witamy w Basketo Engine - projekcie z pasji, w którym wkładamy maksimum wysiłku, aby stworzyć niesamowity i wydajny silnik, z ekscytującym planem uczynienia go natywnym silnikiem gier AI. Oferuje interfejs edytora podobny do Unity, integrację z Gemini AI, zaawansowany system efektów dźwiękowych oraz potężną architekturę ECS. Niezależnie od tego, czy chcesz współtworzyć, sugerować pomysły, czy po prostu obserwować rozwój projektu, jesteś częścią tej podróży! 🚀
</p>
## 🚀 Aktualny stan silnika
<p align="center">
  <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image3.png" alt="Aktualny stan silnika Basketo" width="700"/>
</p>

<p align="center">
  <em>Sprawdź najnowsze funkcje i rozwój silnika w akcji!</em> 🎮
</p>

## ✨ Kluczowe funkcje

### 🎮 **Interfejs edytora podobny do Unity**
- **Układ z dwoma oknami**: Edytor sceny i widok gry obok siebie
- **Edycja na żywo**: Modyfikacja scen podczas działania gry
- **Panel inspektora**: Wizualna edycja komponentów metodą „przeciągnij i upuść”
- **Widok hierarchii**: Organizowanie i zarządzanie encjami
- **Przeglądarka zasobów**: Łatwe zarządzanie teksturami i dźwiękiem

### 🤖 **Natywny rozwój AI**
- **Integracja z Gemini AI**: Polecenia w języku naturalnym do tworzenia gier
- **Inteligentne generowanie skryptów**: Tworzenie skryptów Lua wspierane przez AI
- **Modyfikacja encji**: Opisuj zmiany w prostym języku angielskim
- **Łatwa konfiguracja API**: Wbudowana konfiguracja klucza API Gemini
### 🔊 **Zaawansowany System Audio**
- **Wiele efektów dźwiękowych**: Wiele nazwanych dźwięków na jednostkę (chód, skok, atak itp.)
- **Tradycyjne audio**: Muzyka w tle i dźwięki otoczenia
- **Integracja z Lua**: Wywoływanie dźwięków ze skryptów za pomocą `PlaySound(entity, "action")`
- **Edytor wizualny**: Zarządzanie efektami dźwiękowymi przez inspektor

### 🎯 **Entity-Component-System (ECS)**
- **Wysoka wydajność**: Optymalizacja pod dużą liczbę jednostek
- **Modułowa konstrukcja**: Dowolne łączenie komponentów według potrzeb
- **Integracja skryptów**: Skryptowanie w Lua z pełnym dostępem do ECS
- **Aktualizacje w czasie rzeczywistym**: Edycja komponentów na żywo

### 🎨 **Grafika i Animacja**
- **Renderowanie sprite’ów**: Wydajny pipeline grafiki 2D
- **System animacji**: Animacje klatkowe z zapętlaniem
- **System transformacji**: Pozycja, obrót i skalowanie
- **System kamery**: Obsługa wielu kamer

### ⚡ **Fizyka i Kolizje**
- **Detekcja kolizji**: Kolizje AABB z optymalizacją przestrzenną
- **Fizyka rigidbody**: Grawitacja, prędkość i siły
- **Callbacki kolizji**: Zdarzenia kolizji dostępne ze skryptów
- **Podział przestrzenny**: Optymalizacja wydajności przez quadtree
## 🎬 Kliknij poniższy obraz, aby zobaczyć demonstrację wideo:
<p align="center">
  <a href="https://x.com/BaslaelWorkneh/status/1922713614697288096">
    <img src="https://raw.githubusercontent.com/basketoengine/Basketo/main/readmeimgs/image2.png" alt="Basketo Engine Demo" width="500"/>
  </a>
</p>

## � Szybki przewodnik startowy

### 1. **Uzyskaj swój klucz API Gemini** (opcjonalne, ale zalecane)
- Odwiedź [Google AI Studio](https://aistudio.google.com/app/apikey)
- Zaloguj się i utwórz darmowy klucz API
- Umożliwia to funkcje oparte na AI, takie jak polecenia w języku naturalnym

### 2. **Zbuduj i uruchom**
```bash
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo && mkdir build && cd build
cmake .. && make -j$(nproc)
./BasketoGameEngine
```
### 3. **Konfiguracja funkcji AI**
- W silniku przejdź do panelu AI Prompt (na dole)
- Znajdź "🤖 Gemini AI Configuration"
- Wprowadź swój klucz API i kliknij "Zapisz"

### 4. **Zacznij tworzyć**
- Wypróbuj komendy AI: `"create a player at 100 200"`
- Dodaj efekty dźwiękowe do obiektów w inspektorze
- Napisz skrypty Lua lub pozwól AI je wygenerować
- Użyj edytora z dwoma oknami do pracy na żywo

## �🛠️ Budowanie silnika (Linux) 🐧

### Wymagania wstępne
- Wymagany jest CMake w wersji 3.26.0 lub wyższej.
- SDL2, SDL2_image, SDL2_ttf, SDL2_mixer
- Lua 5.4
- g++ (C++17)
- libcurl (do obsługi funkcji AI)
- nlohmann/json (dołączony jako submoduł)
- ImGui (dołączony jako submoduł)

### Kroki budowania
```bash
# Sklonuj repozytorium
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git

cd Basketo

mkdir build && cd build

cmake ..

make -j$(nproc)

```

### Uruchamianie
```bash
./BasketoGameEngine

```
Jeśli chcesz uruchomić test fizyki:
```bash
./PhysicsTest

```

## 🛠️ Budowanie silnika (Windows) 💻

### Wymagania wstępne

1. **Visual Studio 2022 (Community Edition lub wyższa)**  
   Zainstaluj z następującymi pakietami roboczymi:
   - Programowanie aplikacji klasycznych przy użyciu C++
   - Narzędzia CMake dla C++ w systemie Windows
   - Windows 10 lub 11 SDK

2. **CMake** (w zestawie z Visual Studio lub do pobrania z https://cmake.org/download/)

3. **vcpkg** (używany do instalowania zależności)


---
### Instalowanie zależności

```bash
# Otwórz Developer Command Prompt dla VS 2022 lub PowerShell

# Sklonuj vcpkg

git clone https://github.com/microsoft/vcpkg.git
cd vcpkg

.\bootstrap-vcpkg.bat

# Zainstaluj wymagane biblioteki
.\vcpkg install sdl2 sdl2-image sdl2-ttf sdl2-mixer lua curl

```

---

### Kroki budowania
```bash
# Sklonuj repozytorium Basketo
git clone --recurse-submodules git@github.com:basketoengine/Basketo.git
cd Basketo
mkdir build && cd build

# Konfiguracja za pomocą CMake
cmake .. -DCMAKE_TOOLCHAIN_FILE=C:/ścieżka/do/vcpkg/scripts/buildsystems/vcpkg.cmake -DCMAKE_BUILD_TYPE=Release

# Zamień "C:/ścieżka/do/vcpkg" na pełną ścieżkę do swojego katalogu vcpkg

# Budowanie silnika
cmake --build . --config Release
```

---

### Uruchamianie

```bash
# Z katalogu build/Release
```
./BasketoGameEngine.exe

# Aby uruchomić test fizyki
./PhysicsTest.exe
```

## 📚 Dokumentacja

### Główne funkcje
- **[System efektów dźwiękowych](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/SoundEffectsSystem.md)**: Kompletny przewodnik po wieloelementowych efektach dźwiękowych
- **[Konfiguracja Gemini API](https://raw.githubusercontent.com/basketoengine/Basketo/main/docs/GeminiAPIKeySetup.md)**: Konfigurowanie AI krok po kroku
- **[Skrypty Lua](assets/Scripts/)**: Przykładowe skrypty i odniesienie do API

### Przykład użycia

#### Rozwój wspierany przez AI
```bash
# Polecenia w języku naturalnym
"stwórz postać gracza na pozycji 100 200"
"dodaj zachowanie skoku do gracza"
"spraw, aby wróg poruszał się szybciej"

# Generowanie skryptów
gemini_script utwórz kontroler platformówki z podwójnym skokiem
```

#### Efekty dźwiękowe wielokrotne
```lua
-- W Twoich skryptach Lua
PlaySound(entity, "jump")    -- Odtwórz dźwięk skoku
PlaySound(entity, "walk")    -- Odtwórz dźwięk chodzenia
PlaySound(entity, "attack")  -- Odtwórz dźwięk ataku

-- Sprawdź, czy dźwięk istnieje
if HasSoundEffect(entity, "jump") then
    PlaySound(entity, "jump")
end
```

#### System komponentów
- **Transform**: Pozycja, rotacja, skala
- **Sprite**: Renderowanie tekstur
- **Animation**: Animacje klatkowe
- **Script**: Skrypty zachowań w Lua
- **Collider**: Kolizje fizyczne
- **Rigidbody**: Symulacja fizyki
- **Audio**: Muzyka w tle
- **SoundEffects**: Wiele nazwanych dźwięków
- **Camera**: Zarządzanie widokiem

## 🤝 Zaangażuj się

Uwielbiamy wkład naszej społeczności ❤️. Szczegóły dotyczące współtworzenia lub uruchamiania projektu w celach deweloperskich znajdziesz w naszych [Wytycznych dotyczących współpracy](https://raw.githubusercontent.com/basketoengine/Basketo/main/ContributionGuidline.md). <!-- Zakładając, że masz ten plik -->

- 🐛 Znalazłeś błąd? Otwórz zgłoszenie!
- ✨ Masz fajny pomysł na funkcję? Chętnie go poznamy!
- 💻 Chcesz współtworzyć? Forkuj, koduj i utwórz pull requesta!

Zbudujmy ten silnik razem i sprawmy, by tworzenie gier było przyjemne i łatwe dla każdego. 🌍

## 👥 Społeczność
Witamy ogromnym uściskiem 🤗. Jesteśmy bardzo podekscytowani każdym wkładem społeczności – niezależnie czy to ulepszenia kodu 📝, aktualizacje dokumentacji 📚, zgłoszenia błędów 🐞, propozycje nowych funkcji 💡, czy dyskusje na naszym Discordzie 🗣️.

Dołącz do naszej społeczności tutaj:

- 👋 [Dołącz do naszej społeczności na Discordzie](https://discord.gg/F3DswRMW)
- ⭐ [Daj nam gwiazdkę na GitHubie](https://github.com/basketoengine/Basketo)

## 🙏 Wesprzyj nas:
Stale się rozwijamy, a już wkrótce pojawią się nowe funkcje i przykłady 🌟. Jeśli podoba Ci się ten projekt, daj nam gwiazdkę ⭐ w repozytorium GitHub [![GitHub](https://img.shields.io/github/stars/basketoengine/Basketo?color=5B5BD6)](https://github.com/basketoengine/Basketo), aby być na bieżąco i pomóc nam się rozwijać. 🌱

---

Udanej pracy i tworzenia gier! 🎉🎮

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---