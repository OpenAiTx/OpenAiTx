# Dana wallet

Dana è un'app Flutter utilizzata per accettare donazioni in bitcoin. Utilizza i pagamenti silenziosi, un nuovo protocollo di pagamenti statici, per ricevere donazioni preservando la privacy on-chain.

## Prova Dana wallet

**Dana wallet è attualmente ancora in fase sperimentale. Raccomandiamo di utilizzare testnet/signet. Se desideri davvero testare il wallet sulla mainnet, usa solo fondi che sei disposto a perdere. Non ci assumiamo responsabilità per fondi persi.**

Stiamo valutando di rilasciare Dana wallet nei principali app store una volta che l'app sarà più stabile.

Nel frattempo, ci sono due modi per provare Dana wallet:

- Scarica l'ultima APK di Dana wallet dalla [pagina delle release](https://github.com/cygnet3/danawallet/releases)
- Scarica Dana wallet usando il nostro [repository F-Droid self-hosted](https://fdroid.silentpayments.dev/fdroid/repo)

### Download tramite F-Droid

Raccomandiamo l'opzione F-Droid, poiché supporta aggiornamenti automatici e richiede la configurazione solo una volta.

- Apri F-Droid sul tuo telefono Android
- Vai su 'Impostazioni'
- Nella sezione 'Le mie app', clicca su 'Repository'
- Aggiungi un nuovo repository cliccando sull'icona '+'
- Scansiona il codice QR che si trova su questa pagina: https://fdroid.silentpayments.dev/fdroid/repo

Hai ora aggiunto il nostro repository self-hosted. Per scaricare l'app, cerca 'Dana Wallet' nella sezione store di F-Droid (potrebbe essere necessario aggiornare prima la lista delle app, scorrendo verso il basso nella schermata dello store F-Droid).

## Compilare Dana wallet dal sorgente

Di seguito alcune istruzioni per compilare Dana wallet dal sorgente. È consigliato solo se vuoi contribuire allo sviluppo di Dana wallet.

### Compilazione per linux (desktop)

La compilazione per linux non dovrebbe richiedere sforzi aggiuntivi, basta eseguire

```
flutter run
```

Questo potrebbe funzionare anche su altre piattaforme (macOS, Windows), ma non è stato testato.

### Compilazione per android

La compilazione per un dispositivo android richiede alcune operazioni preparatorie per generare i binari per questa architettura.

Prima, ti serve `cargo-ndk`. Potresti inoltre dover aggiungere le toolchain desiderate:

```
cargo install cargo-ndk
rustup target add \
    aarch64-linux-android \
    armv7-linux-androideabi \
    x86_64-linux-android \
    i686-linux-android
```

Dopo l’installazione, entra nella directory rust e esegui `just build-android`.

```
cd rust
just build-android
```

Se non hai `just` installato, puoi anche copiare i comandi trovati nel `justfile`.
Questo genera i binari.

Poi, collega il telefono e abilita la modalità debug.
Controlla se il telefono è collegato eseguendo

```
flutter devices
```

Infine, per compilare e installare l’app sul tuo dispositivo android:

```
flutter run
```

## Dona a Dana

Puoi donare a Dana wallet usando il nostro indirizzo:

> ₿donate@danawallet.app

oppure puoi usare il seguente indirizzo di pagamento silenzioso:

> sp1qq0cygnetgn3rz2kla5cp05nj5uetlsrzez0l4p8g7wehf7ldr93lcqadw65upymwzvp5ed38l8ur2rznd6934xh95msevwrdwtrpk372hyz4vr6g

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---