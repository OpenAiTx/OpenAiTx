
<div align="right">
  <details>
    <summary >🌐 Język</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Nothing but Nix

**Zmień swojego runnera GitHub Actions w potęgę [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ poprzez bezwzględne usunięcie zbędnych preinstalowanych pakietów.**

Runnery GitHub Actions mają niewiele miejsca na dysku dla Nix – zaledwie około ~20GB.
*Nothing but Nix* **brutalnie czyści** niepotrzebne oprogramowanie, dając Ci **65GB do 130GB** na Twój Nix store! 💪

## Użycie 🔧

Dodaj tę akcję **przed** instalacją Nix w swoim przepływie pracy:

```yaml
jobs:
  build:
    runs-on: ubuntu-latest
    permissions:
      contents: read
      id-token: write
    steps:
      - uses: actions/checkout@v4
      - uses: wimpysworld/nothing-but-nix@main
      - name: Install Nix
        uses: DeterminateSystems/nix-installer-action@main
      - name: Run Nix
        run: |
          nix --version
          # Your Nix-powered steps here...
```

### Wymagania ️✔️

- Obsługuje tylko oficjalne **Ubuntu** runner'y GitHub Actions
- Musi być uruchomione **przed** instalacją Nix
- **Runner'y macOS/Darwin**: Ta akcja zostanie uprzejmie pominięta z ostrzeżeniem, jeśli uruchomiona na macOS. Runner'y macOS już zapewniają wystarczającą ilość miejsca dla Nix i nie wymagają tej akcji
- **Runner'y Windows**: Ta akcja zostanie uprzejmie pominięta z ostrzeżeniem, jeśli uruchomiona na Windows. Runner'y Windows mają inne układy systemu plików i ograniczenia

## Problem: Zrobienie miejsca, by Nix mógł rozkwitnąć 🌱

Standardowe runner'y GitHub Actions są zapchane *"bloatware"*, którego nigdy nie użyjesz w workflow Nix:

- 🌍 Przeglądarki internetowe. Dużo ich. Musisz mieć je wszystkie!
- 🐳 Obrazy Dockera zajmujące gigabajty cennego miejsca na dysku
- 💻 Niepotrzebne środowiska uruchomieniowe języków (.NET, Ruby, PHP, Java...)
- 📦 Menedżery pakietów zbierające cyfrowy kurz
- 📚 Dokumentacja, której nikt nigdy nie przeczyta

Ten bloat zostawia tylko ~20GB dla twojego sklepu Nix - ledwo wystarczająco na poważne budowy Nix! 😞

## Rozwiązanie: Tylko Nix ️❄️

**Nothing but Nix** stosuje taktykę "spalonej ziemi" na runner'ach GitHub Actions i bezlitośnie odzyskuje miejsce na dysku za pomocą dwufazowego ataku:

1. **Początkowe Cięcie:** Natychmiast tworzy dużą partycję `/nix` (~65GB), przejmując wolne miejsce z `/mnt`
2. **W tle Rampage:** Gdy twój workflow trwa, bezwzględnie eliminujemy niepotrzebne oprogramowanie, by powiększyć twoją partycję `/nix` do ~130GB
   - Przeglądarki? Nie ma ⛔
   - Obrazy Dockera? Usunięte 🗑️
   - Środowiska języków? Zlikwidowane 💥
   - Menedżery pakietów? Zniszczone 💣
   - Dokumentacja? Wyparowana ️👻

Czyszczenie systemu plików obsługiwane jest przez `rmz` (z projektu [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc)) - wydajną alternatywę dla `rm`, która błyskawicznie odzyskuje miejsce! ⚡
   - Przewyższa standardowe `rm` o rząd wielkości
   - Usuwa pliki równolegle dla maksymalnej wydajności
   - **Odzyskuje miejsce na dysku w sekundy, a nie minuty!** ️⏱️

Efekt końcowy? Runner GitHub Actions z **65GB do 130GB** miejsca gotowego na Nix! 😁

### Dynamiczny przyrost woluminu
W przeciwieństwie do innych rozwiązań, **Nothing but Nix** dynamicznie powiększa wolumen `/nix`:

1. **Początkowe tworzenie wolumenu (1-10 sekund):** (*w zależności od protokołu Hatchet*)
   - Tworzy urządzenie loop z wolnej przestrzeni na `/mnt`
   - Konfiguruje system plików BTRFS w trybie RAID0
   - Montuje z kompresją i optymalizacją wydajności
   - Zapewnia 65GB dla `/nix` natychmiast, jeszcze przed rozpoczęciem oczyszczania

2. **Rozszerzanie w tle (30-180 sekund):** (*w zależności od protokołu Hatchet*)
   - Wykonuje operacje oczyszczania
   - Monitoruje nowo zwolnioną przestrzeń podczas usuwania nadmiaru
   - Dynamicznie dodaje dysk rozszerzający do wolumenu `/nix`
   - Równoważy system plików, aby włączyć nową przestrzeń

Wolumen `/nix` **automatycznie powiększa się podczas wykonywania workflow** 🎩🪄

### Wybierz swoją broń: Protokół Hatchet 🪓

Kontroluj poziom anihilacji 💥 za pomocą parametru `hatchet-protocol`:


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'cleave'  # Options: holster, carve, cleave (default), rampage
```

#### Porównanie protokołów ⚖️

| Protokół | `/nix` | Opis                                             | Usuń apt   | Usuń docker  | Usuń snap  | Usunięte systemy plików     |
|----------|--------|--------------------------------------------------|------------|--------------|------------|-----------------------------|
| Holster  | ~65GB  | Trzymaj topór w pochwie, użyj miejsca z `/mnt`   | Nie        | Nie          | Nie        | Brak                        |
| Carve    | ~85GB  | Zgromadź i połącz wolne miejsce z `/` i `/mnt`   | Nie        | Nie          | Nie        | Brak                        |
| Cleave   | ~115GB | Wykonaj potężne, zdecydowane cięcia dużych pakietów | Minimalnie | Tak          | Tak        | `/opt` i `/usr/local`       |
| Rampage  | ~130GB | Bezlitosna, brutalna eliminacja wszelkich śmieci | Agresywne  | Tak          | Tak        | Muahahaha! 🔥🌎             |

Wybieraj mądrze:
- **Holster** gdy potrzebujesz, aby narzędzia runnera pozostały w pełni funkcjonalne
- **Carve** aby zachować funkcjonalność narzędzi runnera, ale zdobyć całe wolne miejsce dla Nix
- **Cleave** (*domyślne*) dla dobrej równowagi między miejscem a funkcjonalnością
- **Rampage** gdy potrzebujesz maksymalnej przestrzeni dla Nix i nie obchodzi Cię, co się zepsuje `#nix-is-life`

### Obejrzyj rzeź 🩸

Domyślnie proces czyszczenia wykonuje się po cichu w tle, podczas gdy Twój workflow trwa dalej. Ale jeśli chcesz oglądać rzeźnię na żywo:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    witness-carnage: true  # Default: false
```

### Dostosuj Bezpieczne Przestrzenie 🛡️

Kontroluj, ile miejsca chcesz zarezerwować przed przejęciem przez Nix store, ustalając własne rozmiary bezpiecznych przestrzeni:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    root-safe-haven: '3072'   # Reserve 3GB on the / filesystem
    mnt-safe-haven: '2048'    # Reserve 2GB on the /mnt filesystem
```

Te bezpieczne strefy określają, ile miejsca (w MB) zostanie łaskawie oszczędzone podczas odzyskiwania przestrzeni:
- Domyślna wartość `root-safe-haven` to 2048MB (2GB)
- Domyślna wartość `mnt-safe-haven` to 1024MB (1GB)

Zwiększ te wartości, jeśli potrzebujesz więcej wolnej przestrzeni na swoich systemach plików, lub zmniejsz je, aby nie okazywać litości! 😈

### Przyznanie użytkownikowi własności /nix (Dekret uprawnień Nix) 🧑‍⚖️

Niektóre instalatory lub konfiguracje Nix oczekują, że katalog `/nix` będzie zapisywalny przez bieżącego użytkownika. Domyślnie `/nix` jest własnością roota. Jeśli potrzebujesz własności użytkownika (np. dla niektórych skryptów instalacyjnych Nix, które nie używają `sudo` do wszystkich operacji w `/nix`), możesz włączyć `nix-permission-edict`:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    nix-permission-edict: true  # Default: false
```

Gdy `nix-permission-edict` jest ustawione na `true`, akcja wykona `sudo chown -R "$(id --user)":"$(id --group)" /nix` po zamontowaniu `/nix`.

### Skonfiguruj Nix do używania /nix/build

Ta akcja tworzy `/nix/build`, aby budowy derivacji Nix mogły wykorzystać odzyskaną przestrzeń. Dodaj `build-dir` do swojej konfiguracji Nix:

```yaml
- uses: cachix/install-nix-action@v31
  with:
    extra_nix_config: |
      build-dir = /nix/build
```

Lub z DeterminateSystems:

```yaml
- uses: DeterminateSystems/nix-installer-action@main
  with:
    extra-conf: |
      build-dir = /nix/build
```
To nakazuje Nixowi wykonywanie kompilacji na dużym wolumenie BTRFS zamiast w domyślnym katalogu tymczasowym systemu.

## Rozwiązywanie problemów 🔍

### "Brak miejsca na urządzeniu" podczas dużych kompilacji

Jeśli podczas kompilacji zabraknie miejsca, mimo że używasz wyłącznie Nix, prawdopodobnie czyszczenie w tle nie zostało zakończone zanim kompilacja wykorzystała dostępne miejsce. Najczęściej dotyczy to:

- Testów VM NixOS, które tworzą duże obrazy dysków
- Kompilacji z wieloma zależnościami, które nie są w cache'u
- Toolchainów Rust i innych dużych kompilacji

**Rozwiązanie:** Użyj `witness-carnage: true`, aby wymusić synchroniczne czyszczenie. Zapewnia to zwolnienie całej przestrzeni *przed* rozpoczęciem kompilacji:


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'rampage'
    witness-carnage: true
```

To dodaje 30-180 sekund do konfiguracji przepływu pracy, ale gwarantuje maksymalną dostępną przestrzeń, gdy rozpocznie się Twoja kompilacja.

Teraz idź i zbuduj coś niesamowitego, korzystając z całej tej wspaniałej przestrzeni w magazynie Nix! ❄️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-18

---