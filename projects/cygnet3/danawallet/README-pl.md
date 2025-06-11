# Dana wallet

Dana to aplikacja flutter służąca do przyjmowania darowizn w bitcoinach. Używa silent payments, nowego statycznego protokołu płatności, aby otrzymywać darowizny, zachowując prywatność on-chain.

## Wypróbuj Dana wallet

**Dana wallet jest obecnie w fazie eksperymentalnej. Zalecamy korzystanie z testnet/signet. Jeśli naprawdę chcesz przetestować portfel na mainnet, używaj tylko środków, które jesteś gotów stracić. Nie bierzemy odpowiedzialności za utracone środki.**

Planujemy wypuścić Dana wallet w popularnych sklepach z aplikacjami, gdy aplikacja będzie bardziej stabilna.

Tymczasem są dwa sposoby, aby wypróbować Dana wallet:

- Pobierz najnowszy plik APK Dana wallet ze [strony z wydaniami](https://github.com/cygnet3/danawallet/releases)
- Pobierz Dana wallet używając naszego [samodzielnie hostowanego repozytorium F-Droid](https://fdroid.silentpayments.dev/fdroid/repo)

### Pobieranie za pomocą F-Droid

Zalecamy opcję F-Droid, ponieważ wspiera automatyczne aktualizacje i wymaga konfiguracji tylko raz.

- Otwórz F-Droid na swoim telefonie z Androidem
- Przejdź do „Ustawienia”
- W sekcji „Moje aplikacje” kliknij „Repozytoria”
- Dodaj nowe repozytorium klikając ikonę '+'
- Zeskanuj kod QR znajdujący się na tej stronie: https://fdroid.silentpayments.dev/fdroid/repo

Teraz dodałeś nasze samodzielnie hostowane repozytorium. Aby pobrać aplikację, wyszukaj „Dana Wallet” w sekcji sklepu F-Droid (może być konieczne odświeżenie listy aplikacji, przeciągając w dół ekran sklepu F-Droid).

## Budowanie Dana wallet ze źródeł

Poniżej znajdują się instrukcje budowania Dana wallet ze źródeł. Zalecane tylko jeśli chcesz pomóc w rozwoju Dana wallet.

### Budowanie na linux (desktop)

Budowanie na linux nie powinno wymagać dodatkowych działań, po prostu wykonaj

```
flutter run
```

Może to również działać na innych platformach (macOS, Windows), ale nie testowaliśmy tego.

### Budowanie na android

Budowanie na urządzenie z androidem wymaga przygotowań, aby wygenerować binaria dla tej architektury.

Najpierw potrzebujesz `cargo-ndk`. Możesz również potrzebować dodać pożądane toolchainy:

```
cargo install cargo-ndk
rustup target add \
    aarch64-linux-android \
    armv7-linux-androideabi \
    x86_64-linux-android \
    i686-linux-android
```

Po zainstalowaniu przejdź do katalogu rust i uruchom `just build-android`.

```
cd rust
just build-android
```

Jeśli nie masz zainstalowanego `just`, możesz skopiować polecenia znajdujące się w pliku `justfile`.
To generuje binaria.

Następnie podłącz telefon i włącz tryb debugowania.
Sprawdź, czy telefon jest podłączony, uruchamiając

```
flutter devices
```

Na koniec, aby zbudować i zainstalować aplikację na urządzeniu z androidem:

```
flutter run
```

## Wspomóż Dana

Możesz wspomóc Dana wallet, wysyłając darowiznę na nasz adres:

> ₿donate@danawallet.app

lub możesz użyć następującego adresu silent payment:

> sp1qq0cygnetgn3rz2kla5cp05nj5uetlsrzez0l4p8g7wehf7ldr93lcqadw65upymwzvp5ed38l8ur2rznd6934xh95msevwrdwtrpk372hyz4vr6g

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---