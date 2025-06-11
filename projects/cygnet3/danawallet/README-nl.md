# Dana wallet

Dana is een Flutter-app die wordt gebruikt voor het accepteren van bitcoin-donaties. Het maakt gebruik van stille betalingen, een nieuw statisch betalingsprotocol, om donaties te ontvangen terwijl de privacy op de blockchain behouden blijft.

## Probeer Dana wallet uit

**Dana wallet bevindt zich momenteel nog in een experimentele fase. We raden aan om de testnet/signet te gebruiken. Als je de wallet echt op mainnet wilt testen, gebruik dan alleen geld dat je bereid bent te verliezen. Wij nemen geen verantwoordelijkheid voor verloren fondsen.**

We zijn bezig met het uitbrengen van Dana wallet in de populaire app stores zodra de app stabieler is.

In de tussentijd zijn er twee manieren om Dana wallet uit te proberen:

- Download de nieuwste Dana wallet APK van de [releases pagina](https://github.com/cygnet3/danawallet/releases)
- Download Dana wallet via onze [zelf-gehoste F-Droid repository](https://fdroid.silentpayments.dev/fdroid/repo)

### Downloaden via F-Droid

We raden de F-Droid optie aan, omdat deze ondersteuning biedt voor automatische updates en slechts één keer ingesteld hoeft te worden.

- Open F-Droid op je Android-telefoon
- Ga naar 'Instellingen'
- Klik in het gedeelte 'Mijn apps' op 'Repositories'
- Voeg een nieuwe repository toe door op het '+'-icoon te klikken
- Scan de QR-code op deze pagina: https://fdroid.silentpayments.dev/fdroid/repo

Je hebt nu onze zelf-gehoste repository toegevoegd. Om de app te downloaden, zoek je naar 'Dana Wallet' in de F-Droid app store sectie (je moet mogelijk eerst de app-lijst verversen door omlaag te swipen op het F-Droid store-scherm).

## Dana wallet bouwen vanuit de broncode

Hieronder staan enkele instructies om Dana wallet vanuit de broncode te bouwen. Dit wordt alleen aanbevolen als je wilt bijdragen aan de ontwikkeling van Dana wallet.

### Bouwen voor Linux (desktop)

Bouwen voor Linux vereist geen extra moeite, voer simpelweg uit

```
flutter run
```

Dit kan ook werken op andere platforms (macOS, Windows), maar dit hebben we niet getest.

### Bouwen voor Android

Bouwen voor een Android-apparaat vereist wat voorbereidend werk om binaries voor deze architectuur te genereren.

Allereerst heb je `cargo-ndk` nodig. Mogelijk moet je ook de gewenste toolchains toevoegen:

```
cargo install cargo-ndk
rustup target add \
    aarch64-linux-android \
    armv7-linux-androideabi \
    x86_64-linux-android \
    i686-linux-android
```

Nadat deze zijn geïnstalleerd, ga je naar de rust-map en voer je `just build-android` uit.

```
cd rust
just build-android
```

Als je `just` niet geïnstalleerd hebt, kun je ook de commando's uit het `justfile` kopiëren.
Dit genereert de binaries.

Verbind vervolgens je telefoon en schakel de debugmodus in.
Controleer of je telefoon verbonden is door het volgende uit te voeren:

```
flutter devices
```

Tot slot, om de app te bouwen en te installeren op je Android-apparaat:

```
flutter run
```

## Doneren aan Dana

Je kunt doneren aan Dana wallet via ons adres:

> ₿donate@danawallet.app

of je kunt het volgende adres voor stille betalingen gebruiken:

> sp1qq0cygnetgn3rz2kla5cp05nj5uetlsrzez0l4p8g7wehf7ldr93lcqadw65upymwzvp5ed38l8ur2rznd6934xh95msevwrdwtrpk372hyz4vr6g

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---