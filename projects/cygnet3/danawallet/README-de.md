# Dana Wallet

Dana ist eine Flutter-App, die verwendet wird, um Bitcoin-Spenden zu akzeptieren. Sie nutzt Silent Payments, ein neues statisches Zahlungsprotokoll, um Spenden zu empfangen und dabei die On-Chain-Privatsphäre zu wahren.

## Probieren Sie Dana Wallet aus

**Dana Wallet befindet sich derzeit noch in einer experimentellen Phase. Wir empfehlen, das Testnet/Signet zu verwenden. Wenn Sie die Wallet wirklich im Mainnet testen möchten, verwenden Sie nur Gelder, deren Verlust Sie verkraften können. Wir übernehmen keine Verantwortung für verlorene Gelder.**

Wir planen, Dana Wallet in den beliebten App-Stores zu veröffentlichen, sobald die App stabiler ist.

In der Zwischenzeit gibt es zwei Möglichkeiten, Dana Wallet auszuprobieren:

- Laden Sie die neueste Dana Wallet APK von der [Releases-Seite](https://github.com/cygnet3/danawallet/releases) herunter
- Laden Sie Dana Wallet über unser [selbst gehostetes F-Droid-Repository](https://fdroid.silentpayments.dev/fdroid/repo) herunter

### Download über F-Droid

Wir empfehlen die F-Droid-Option, da diese automatische Updates unterstützt und nur einmal eingerichtet werden muss.

- Öffnen Sie F-Droid auf Ihrem Android-Telefon
- Gehen Sie zu „Einstellungen“
- Klicken Sie im Abschnitt „Meine Apps“ auf „Repositories“
- Fügen Sie ein neues Repository hinzu, indem Sie auf das „+“-Symbol klicken
- Scannen Sie den QR-Code auf dieser Seite: https://fdroid.silentpayments.dev/fdroid/repo

Sie haben jetzt unser selbst gehostetes Repository hinzugefügt. Um die App herunterzuladen, suchen Sie im F-Droid-App-Store-Bereich nach „Dana Wallet“ (möglicherweise müssen Sie die App-Liste zuerst aktualisieren, indem Sie auf dem F-Droid-Store-Bildschirm nach unten wischen).

## Dana Wallet aus dem Quellcode bauen

Nachfolgend finden Sie einige Anweisungen, um Dana Wallet aus dem Quellcode zu bauen. Dies wird nur empfohlen, wenn Sie an der Entwicklung von Dana Wallet mithelfen möchten.

### Build für Linux (Desktop)

Der Build für Linux erfordert normalerweise keine zusätzlichen Schritte, führen Sie einfach aus:

```
flutter run
```

Dies kann auch auf anderen Plattformen (macOS, Windows) funktionieren, wurde aber von uns nicht getestet.

### Build für Android

Der Build für ein Android-Gerät erfordert einige Vorbereitungen, um Binaries für diese Architektur zu erzeugen.

Zuerst benötigen Sie `cargo-ndk`. Möglicherweise müssen Sie auch die gewünschten Toolchains hinzufügen:

```
cargo install cargo-ndk
rustup target add \
    aarch64-linux-android \
    armv7-linux-androideabi \
    x86_64-linux-android \
    i686-linux-android
```

Nachdem diese installiert sind, wechseln Sie ins Rust-Verzeichnis und führen `just build-android` aus.

```
cd rust
just build-android
```

Wenn Sie `just` nicht installiert haben, können Sie auch die Befehle aus der `justfile` kopieren.
Dies erzeugt die Binaries.

Als Nächstes verbinden Sie Ihr Telefon und aktivieren den Debugging-Modus.
Prüfen Sie, ob Ihr Telefon verbunden ist, indem Sie ausführen:

```
flutter devices
```

Schließlich, um die App für Ihr Android-Gerät zu bauen und zu installieren:

```
flutter run
```

## Spenden an Dana

Sie können Dana Wallet über unsere Adresse spenden:

> ₿donate@danawallet.app

oder Sie können die folgende Silent Payment-Adresse verwenden:

> sp1qq0cygnetgn3rz2kla5cp05nj5uetlsrzez0l4p8g7wehf7ldr93lcqadw65upymwzvp5ed38l8ur2rznd6934xh95msevwrdwtrpk372hyz4vr6g

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---