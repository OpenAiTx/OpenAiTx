# eBAF - Zapora reklamowa oparta na eBPF
<p align="center">
    <img src="https://raw.githubusercontent.com/Kazedaa/eBAF/main/assets/banner.png" alt="eBAF - eBPF Ad Firewall Banner" width="600"/>
</p>

## "Nie ściągnąłbyś reklamy"
### Ale zablokowałbyś jedną!

Spotify zbudował imperium na prostym wzorze: monetyzuj swoją uwagę, nie dość płacąc artystom, a następnie sprzedaj ci z powrotem twój własny czas jako funkcję premium.  
W ich świecie twoje doświadczenie słuchania nie należy do ciebie. To starannie wyselekcjonowany rynek — twoje uszy są produktem, a twoja cierpliwość walutą.

Lubią to nazywać „darmowym” poziomem.
Ale bądźmy szczerzy: to nie jest darmowe, jeśli płacisz swoim czasem.

Tymczasem artyści, których kochasz — ludzie, których praca utrzymuje platformę przy życiu — często zarabiają zaledwie ułamki grosza za jedno odtworzenie. Spotify czerpie ogromne zyski, reklamodawcy dostają swoją ekspozycję, a twórcy? Dostają ochłapy.

To nie tylko kwestia pomijania kilku irytujących reklam.
To odmowa udziału w systemie, który czerpie zyski z wyzysku, rozpraszania uwagi i utowarowienia twojej uwagi.

#### Czym to jest?
Elegancki, mały akt cyfrowego oporu: czysty, otwartoźródłowy adblocker dla Spotify, który zatrzymuje hałas — dosłownie.

Bez podejrzanych modów, bez zhakowanych klientów, bez złośliwego oprogramowania udającego wolność. Tylko jeden cel: pozwól muzyce grać bez bycia zakładnikiem reklam.

Spotify nie jest darmowe — płacisz swoją cierpliwością.

Zasypują Cię tymi samymi irytującymi reklamami, raz za razem, aż w końcu się poddajesz i wykupujesz subskrypcję. Nie dlatego, że kochasz Premium. Ale dlatego, że zostałeś złamany. To nie jest freemium — to wojna psychologiczna z playlistą.

A artyści? Nadal niedopłacani.
Reklamy? Głośniejsze. Częstsze. Czasem dosłownie głośniejsze.
Ty? Po prostu chcesz się zrelaksować.

Oni czerpią zyski z Twojej cierpliwości i zaniżania wynagrodzeń twórców, udając jednocześnie, że to jedyny zrównoważony sposób. Spoiler: to nieprawda. Mieli wybór — ale wybrali marżę zysku zamiast ludzi.

Spotify chce, żebyś wierzył, że to koszt dostępu.
My wierzymy, że to kłamstwo.

Nie jesteśmy piratami. Nie jesteśmy przestępcami. Jesteśmy po prostu ludźmi, którzy uważają, że można postawić granicę.

Ten projekt nie polega na pominięciu kilku reklam. Chodzi o odrzucenie systemu, który mówi, że twoje milczenie można sprzedać, twoje doświadczenie można przerwać, a twoja wartość zaczyna się dopiero wtedy, gdy otworzysz portfel.

Blokowanie reklam to nie kradzież.<br>
Kradzieżą jest zabieranie twojego czasu.<br>
Nie jesteśmy tu, by piracić. Jesteśmy tu, by się wypisać.<br>
<br>
**Nie pobrałbyś reklamy. Ale zablokowałbyś ją.**
## Jak działa eBAF?

eBAF (eBPF Ad Firewall) wykorzystuje moc eBPF (Extended Berkeley Packet Filter) do blokowania niechcianych reklam na poziomie jądra systemu. Oto ogólny przegląd jego działania:

## Jak działa eBAF?

eBAF (eBPF Ad Firewall) wykorzystuje eBPF (Extended Berkeley Packet Filter), aby skutecznie blokować reklamy na poziomie jądra. Oto uproszczony przegląd:

1. **Filtrowanie pakietów**:
   - Analizuje przychodzące pakiety sieciowe i blokuje te, które pasują do czarnej listy adresów IP, wykorzystując XDP (eXpress Data Path).

2. **Dynamiczne aktualizacje**:
   - Rozwiązuje nazwy domen na adresy IP i dynamicznie aktualizuje czarną listę, aby zachować skuteczność wobec zmieniających się serwerów reklamowych.

3. **Panel internetowy**:
   - Udostępnia statystyki na żywo i monitorowanie za pośrednictwem przyjaznego dla użytkownika interfejsu.

4. **Wysoka wydajność**:
   - Działa bezpośrednio na poziomie interfejsu sieciowego, pomijając stos sieciowy jądra dla szybszego przetwarzania i minimalnego zużycia zasobów.

eBAF łączy wydajność, przejrzystość i łatwość obsługi, oferując skuteczne rozwiązanie do blokowania reklam.
## Prosta instalacja (Zalecane)
Upewnij się, że masz zainstalowane git i curl
```bash
git --version
curl --version
```
### Instalacja
#### Włącz integrację ze Spotify (Zalecane)
```bash
EBAF_ENABLE_SPOTIFY=yes curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo -E bash
```
#### Wyłącz explicite
```bash
EBAF_ENABLE_SPOTIFY=no curl -sSL https://github.com/Kazedaa/eBAF/raw/main/install.sh | sudo bash```
```

### Odinstaluj
```bash
curl -sSL https://raw.githubusercontent.com/Kazedaa/eBAF/main/uninstall.sh | sudo bash
```
## Instalacja dla deweloperów
Uruchom poniższe polecenia, aby zainstalować wymagane zależności:
### Ubuntu/Debian
```bash
sudo apt-get update
sudo apt-get install libbpf-dev clang llvm libelf-dev zlib1g-dev gcc make python3

sudo apt update
sudo apt install net-tools
```

### Fedora/CentOS/RHEL 8+
```bash
sudo dnf update
sudo dnf install -y libbpf-devel clang llvm elfutils-libelf-devel zlib-devel gcc make python3 net-tools bc
```

### Arch
```bash
sudo pacman -Syu
sudo pacman -S --needed libbpf clang llvm libelf zlib gcc make python net-tools bc
```

### Naprawa błędu asm/types.h podczas uruchamiania kodu eBPF
Sprawdź aktualny link
`ls -l /usr/include/asm`
Znajdź poprawny link
`find /usr/include -name "types.h" | grep asm`
Napraw link symboliczny
```bash
sudo rm /usr/include/asm
sudo ln -s <current_link> /usr/include/asm
```

### Budowanie projektu

Aby zbudować eBPF Adblocker, wykonaj następujące kroki:

1. Sklonuj repozytorium:
   ```bash
   git clone <repository-url>
   cd eBAF
   ```
2. Zbuduj projekt:
   ```bash
   make
   ```

3. (Opcjonalnie) Zainstaluj globalnie w systemie:
   ```bash
   sudo make install
   ```

4. Inne opcje instalacji (pomoc)
    ```bash
    make help
    ````
5. Odinstaluj
    ```bash
    make uninstall
    ````

## Użytkowanie

### Uruchamianie Adblockera
    Domyślnie używa spotify-stable.txt jako czarnej listy.
    Użycie: ebaf [OPCJE] [INTERFEJS...]
    OPCJE:
    -a, --all               Uruchom na wszystkich aktywnych interfejsach
    -d, --default           Uruchom tylko na domyślnym interfejsie (z dostępem do internetu)
    -i, --interface IFACE   Wskaż interfejs do użycia
    -D, --dash              Uruchom panel internetowy (http://localhost:8080)
    -q, --quiet             Wycisz wyjście (tryb cichy)
    -h, --help              Wyświetl tę pomoc


### Konfigurowanie czarnej listy
Edytuj listy, aby dodać lub usunąć domeny. Każda domena powinna znajdować się w osobnym wierszu. Komentarze zaczynają się od `#`.

## Podziękowania

Szczególne podziękowania dla ❤️ <br>
1. [Spotify-AdsList od Isaakera](https://github.com/Isaaker/Spotify-AdsList/tree/main) <br>
2. [spotify-adblock od AnanthVivekananda](https://github.com/AnanthVivekanand/spotify-adblock)

za udostępnienie listy blokowania Spotify
## ⭐️ Wesprzyj projekt

Jeśli uważasz, że eBAF jest przydatny, rozważ oznaczenie repozytorium gwiazdką na GitHubie! Twoje wsparcie pomaga zwiększyć widoczność i zachęca do dalszego rozwoju.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---