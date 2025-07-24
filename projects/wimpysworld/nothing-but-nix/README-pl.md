
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

**Zamień swojego runnera GitHub Actions w potęgę [Nix](https://zero-to-nix.com/concepts/nix/) ❄️, bezlitośnie usuwając zbędne, preinstalowane oprogramowanie.**

Runnery GitHub Actions mają niewiele miejsca na dysku dla Nix – zaledwie ~20GB.
*Nothing but Nix* **brutalnie czyści** niepotrzebne oprogramowanie, zapewniając Ci **65GB do 130GB** na Twój store Nix! 💪

## Użycie 🔧

Dodaj tę akcję **przed** instalacją Nix w swoim workflow:

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

- Obsługuje tylko oficjalne runner'y **Ubuntu** GitHub Actions
- Musi być uruchomiony **przed** instalacją Nix

## Problem: Zrób miejsce, by Nix mógł rozkwitnąć 🌱

Standardowe runner'y GitHub Actions są wypchane *"bloatware'em"*, którego nigdy nie użyjesz w workflow Nix:

- 🌍 Przeglądarki internetowe. Dużo ich. Trzeba mieć wszystkie!
- 🐳 Obrazy Dockera zużywające gigabajty cennego miejsca na dysku
- 💻 Niepotrzebne środowiska uruchomieniowe (.NET, Ruby, PHP, Java...)
- 📦 Menedżery pakietów zbierające cyfrowy kurz
- 📚 Dokumentacja, której nikt nigdy nie przeczyta

To zbędne oprogramowanie zostawia tylko ~20GB dla twojego Nix store – ledwie wystarcza na poważne buildy Nix! 😞

## Rozwiązanie: Nic poza Nix ️❄️

**Nic poza Nix** stosuje taktykę spalonej ziemi wobec runner'ów GitHub Actions i bezwzględnie odzyskuje miejsce na dysku, stosując dwufazowy atak:

1. **Początkowe cięcie:** Natychmiast tworzy dużą woluminę `/nix` (~65GB), przejmując wolne miejsce z `/mnt`
2. **Tło destrukcji:** Podczas kontynuowania workflow, bezlitośnie eliminujemy zbędne oprogramowanie, by powiększyć wolumin `/nix` do ~130GB
   - Przeglądarki? Nie ma ⛔
   - Obrazy Dockera? Zniknęły 🗑️
   - Środowiska uruchomieniowe? Zniszczone 💥
   - Menedżery pakietów? Anihilowane 💣
   - Dokumentacja? Wyparowała ️👻

Czyszczenie systemu plików napędza `rmz` (z projektu [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc)) – wysokowydajna alternatywa dla `rm`, która błyskawicznie odzyskuje miejsce! ⚡
   - Wydajność większa o rząd wielkości od standardowego `rm`
   - Usuwa pliki równolegle dla maksymalnej efektywności
   - **Odzyskuje miejsce na dysku w sekundy zamiast minut!** ️⏱️

Efekt końcowy? Runner GitHub Actions z **65GB do 130GB** miejsca gotowego na Nix! 😁

### Dynamiczny wzrost woluminu

W przeciwieństwie do innych rozwiązań, **Nic poza Nix** dynamicznie powiększa wolumin `/nix`:

1. **Tworzenie woluminu (1-10 sekund):** (*w zależności od Hatchet Protocol*)
   - Tworzy urządzenie loop z wolnego miejsca na `/mnt`
   - Ustawia system plików BTRFS w konfiguracji RAID0
   - Montuje z kompresją i tuningiem wydajności
   - Zapewnia natychmiast 65GB na `/nix`, jeszcze przed rozpoczęciem czyszczenia

2. **Rozszerzanie w tle (30-180 sekund):** (*w zależności od Hatchet Protocol*)
   - Wykonuje operacje czyszczenia
   - Monitoruje nowo zwolnione miejsce podczas eliminacji bloatware'u
   - Dynamicznie dodaje dysk rozszerzający do woluminu `/nix`
   - Równoważy system plików, aby włączyć nowe miejsce

Wolumin `/nix` **powiększa się automatycznie podczas wykonywania workflow** 🎩🪄

### Wybierz swoją broń: Hatchet Protocol 🪓

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

Teraz idź i zbuduj coś niesamowitego, mając do dyspozycji całą tę wspaniałą przestrzeń sklepu Nix! ❄️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---