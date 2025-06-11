# Containerization

Pakiet Containerization umożliwia aplikacjom korzystanie z kontenerów Linux.
Containerization jest napisany w [Swift](https://www.swift.org) i używa [Virtualization.framework](https://developer.apple.com/documentation/virtualization) na Apple silicon.

Containerization zapewnia API do:

- [Zarządzania obrazami OCI](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/).
- [Interakcji z zdalnymi rejestrami](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/Client/).
- [Tworzenia i wypełniania systemów plików ext4](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationEXT4/).
- [Interakcji z rodziną gniazd Netlink](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationNetlink/).
- [Tworzenia zoptymalizowanego jądra Linux dla szybkiego czasu uruchamiania](https://raw.githubusercontent.com/apple/containerization/main/kernel/).
- [Uruchamiania lekkich maszyn wirtualnych i zarządzania środowiskiem runtime](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxContainer.swift).
- [Uruchamiania i interakcji z procesami konteneryzowanymi](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxProcess.swift).
- Używania Rosetta 2 do uruchamiania kontenerów linux/amd64 na Apple silicon.

Proszę zapoznać się z [dokumentacją API](https://apple.github.io/containerization/documentation/) w celu uzyskania informacji o pakietach Swift dostarczanych przez Containerization.

## Projekt

Containerization uruchamia każdy kontener Linux w jego własnej lekkiej maszynie wirtualnej. Klienci mogą tworzyć dedykowane adresy IP dla każdego kontenera, aby wyeliminować konieczność przekierowywania poszczególnych portów. Kontenery osiągają czas uruchomienia poniżej sekundy dzięki zoptymalizowanej [konfiguracji jądra Linux](https://raw.githubusercontent.com/apple/containerization/main/kernel) oraz minimalnemu systemowi plików root z lekkim systemem init.

[vminitd](https://raw.githubusercontent.com/apple/containerization/main/vminitd) to mały system init, który jest podprojektem Containerization.
`vminitd` jest uruchamiany jako proces początkowy wewnątrz maszyny wirtualnej i udostępnia API GRPC przez vsock.
API pozwala na konfigurację środowiska runtime oraz uruchamianie procesów konteneryzowanych.
`vminitd` zapewnia I/O, sygnały i zdarzenia dla wywołującego procesu, gdy proces jest uruchamiany.

## Wymagania

Do budowy i uruchamiania Containerization potrzebny jest Mac z Apple silicon.

Aby zbudować pakiet Containerization, system musi mieć:

- macOS 15 lub nowszy oraz Xcode 26 beta
- macOS 26 beta lub nowszy

Aplikacje zbudowane przy użyciu tego pakietu będą działać na macOS 15 lub nowszym, jednak następujące funkcje nie są dostępne na macOS 15:

- Sieć kontenerów nieizolowanych - na macOS 15 kontenery w tej samej sieci vmnet nie mogą się ze sobą komunikować

## Przykładowe użycie

Aby zobaczyć przykłady użycia niektórych bibliotek, dobrym punktem startu jest wykonywalny plik cctl. Narzędzie to służy głównie jako plac zabaw do testowania API. Zawiera polecenia wykorzystujące niektóre z podstawowych funkcji różnych produktów, takie jak:

1. [Manipulacja obrazami OCI](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/ImageCommand.swift)
2. [Logowanie do rejestrów kontenerów](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/LoginCommand.swift)
3. [Tworzenie bloków systemu plików root](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RootfsCommand.swift)
4. [Uruchamianie prostych kontenerów Linux](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RunCommand.swift)

## Jądro Linux

Jądro Linux jest wymagane do uruchamiania lekkich maszyn wirtualnych na macOS.
Containerization dostarcza zoptymalizowaną konfigurację jądra znajdującą się w katalogu [kernel](https://raw.githubusercontent.com/apple/containerization/main/kernel).

Ten katalog zawiera konteneryzowane środowisko budowania, które umożliwia łatwą kompilację jądra do użycia z Containerization.

Konfiguracja jądra to minimalny zestaw funkcji wspierających szybkie czasy uruchamiania i lekkie środowisko.

Chociaż ta konfiguracja będzie działać dla większości obciążeń, rozumiemy, że niektóre wymagają dodatkowych funkcji.
Aby to rozwiązać, Containerization zapewnia zaawansowane API do używania różnych konfiguracji i wersji jądra na bazie pojedynczych kontenerów.
Umożliwia to rozwój i walidację kontenerów na różnych wersjach jądra.

Zobacz [README](https://raw.githubusercontent.com/apple/containerization/main/kernel/README.md) w katalogu kernel, aby uzyskać instrukcje dotyczące kompilacji zoptymalizowanego jądra.

### Wstępnie skompilowane jądro

Jeśli chcesz użyć wstępnie skompilowanego jądra, musi ono mieć wbudowane sterowniki `VIRTIO` w jądrze, a nie jako moduły.

Projekt [Kata Containers](https://github.com/kata-containers/kata-containers) dostarcza zoptymalizowane jądro dla kontenerów z wszystkimi wymaganymi opcjami konfiguracyjnymi włączonymi, dostępne na stronie [releases](https://github.com/kata-containers/kata-containers/releases/).

Obraz jądra o nazwie `vmlinux.container` można znaleźć w katalogu `/opt/kata/share/kata-containers/` w artefaktach wydania.

## Przygotowanie do budowy pakietu

Zainstaluj Swiftly, [Swift](https://www.swift.org) oraz [Static Linux SDK](https://www.swift.org/documentation/articles/static-linux-getting-started.html):

```bash
make cross-prep
```

Jeśli używasz niestandardowej aplikacji terminalowej, może być konieczne przeniesienie tego polecenia z `.zprofile` do `.zshrc` (zamień `<USERNAME>`):

```bash
# Dodane przez swiftly
. "/Users/<USERNAME>/.swiftly/env.sh"
```

Uruchom ponownie aplikację terminalową. Upewnij się, że to polecenie zwraca `/Users/<USERNAME>/.swiftly/bin/swift` (zamień `<USERNAME>`):

```bash
which swift
```

Jeśli wcześniej instalowałeś lub używałeś Static Linux SDK, może być konieczne usunięcie starszych wersji SDK z systemu (zamień `<SDK-ID>`):

```bash
swift sdk list
swift sdk remove <SDK-ID>
```

## Budowa pakietu

Zbuduj Containerization ze źródeł:

```bash
make all
```

## Testowanie pakietu

Po zbudowaniu uruchom testy podstawowe i integracyjne:

```bash
make test integration
```

Do uruchomienia testów integracyjnych wymagane jest jądro.
Jeśli nie masz lokalnie jądra do użytku, domyślne jądro można pobrać za pomocą celu `make fetch-default-kernel`.

Pobranie domyślnego jądra musi nastąpić tylko po początkowej kompilacji lub po `make clean`.

```bash
make fetch-default-kernel
make all test integration
```

## Protobufy

Containerization zależy od konkretnych wersji `grpc-swift` i `swift-protobuf`. Możesz je zainstalować i ponownie wygenerować interfejsy RPC za pomocą:

```bash
make protos
```

## Dokumentacja

Wygeneruj dokumentację API do lokalnego przeglądania za pomocą:

```bash
make docs
make serve-docs
```

Podgląd dokumentacji uruchom w innym terminalu:

```bash
open http://localhost:8000/documentation/
```

## Wkład w projekt

Wkłady do Containerization są mile widziane i zachęcane. Proszę zobaczyć [CONTRIBUTING.md](https://raw.githubusercontent.com/apple/containerization/main/CONTRIBUTING.md) po więcej informacji.

## Status projektu

Wersja 0.1.0 jest pierwszym oficjalnym wydaniem Containerization. Wcześniejsze wersje nie gwarantują stabilności źródła.

Ponieważ biblioteka Containerization jest aktywnie rozwijana, stabilność źródła jest gwarantowana tylko w obrębie wersji mniejszych (np. między 0.1.1 a 0.1.2). Jeśli nie chcesz potencjalnie łamiących źródło aktualizacji pakietu, możesz określić zależność pakietu używając `.upToNextMinorVersion(from: "0.1.0")`.

Przyszłe wersje mniejsze pakietu mogą wprowadzać zmiany w tych zasadach w razie potrzeby.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---