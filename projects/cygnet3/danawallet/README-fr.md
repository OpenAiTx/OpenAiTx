# Dana wallet

Dana est une application Flutter utilisée pour accepter des dons en bitcoin. Elle utilise les paiements silencieux, un nouveau protocole de paiements statiques, pour recevoir des dons tout en préservant la confidentialité on-chain.

## Essayez Dana wallet

**Dana wallet est actuellement encore en phase expérimentale. Nous recommandons d’utiliser le testnet/signet. Si vous souhaitez vraiment tester le portefeuille sur le mainnet, n’utilisez que des fonds que vous êtes prêt à perdre. Nous ne prenons aucune responsabilité en cas de perte de fonds.**

Nous envisageons de publier Dana wallet sur les boutiques d’applications populaires une fois que l’application sera plus stable.

En attendant, il y a deux façons d’essayer Dana wallet :

- Téléchargez le dernier APK de Dana wallet depuis la [page des releases](https://github.com/cygnet3/danawallet/releases)
- Téléchargez Dana wallet via notre [dépôt F-Droid auto-hébergé](https://fdroid.silentpayments.dev/fdroid/repo)

### Télécharger via F-Droid

Nous recommandons l’option F-Droid, car elle supporte les mises à jour automatiques et ne nécessite une configuration qu’une seule fois.

- Ouvrez F-Droid sur votre téléphone Android
- Allez dans « Paramètres »
- Dans la section « Mes apps », cliquez sur « Dépôts »
- Ajoutez un nouveau dépôt en cliquant sur l’icône '+'
- Scannez le QR code trouvé sur cette page : https://fdroid.silentpayments.dev/fdroid/repo

Vous avez maintenant ajouté notre dépôt auto-hébergé. Pour télécharger l’app, cherchez « Dana Wallet » dans la section boutique de l’app F-Droid (vous devrez peut-être rafraîchir la liste des applications en tirant vers le bas sur l’écran de la boutique F-Droid).

## Compiler Dana wallet depuis les sources

Voici quelques instructions pour compiler Dana wallet depuis les sources. Cela est recommandé uniquement si vous souhaitez contribuer au développement de Dana wallet.

### Compilation pour linux (bureau)

La compilation pour linux ne devrait pas demander d’effort supplémentaire, exécutez simplement

```
flutter run
```

Cela peut aussi fonctionner sur d’autres plateformes (macOS, Windows), mais nous n’avons pas testé.

### Compilation pour android

La compilation pour un appareil android demande quelques préparatifs pour générer les binaires pour cette architecture.

D’abord, vous avez besoin de `cargo-ndk`. Vous devez aussi ajouter les chaînes d’outils désirées :

```
cargo install cargo-ndk
rustup target add \
    aarch64-linux-android \
    armv7-linux-androideabi \
    x86_64-linux-android \
    i686-linux-android
```

Une fois installés, allez dans le répertoire rust et lancez `just build-android`.

```
cd rust
just build-android
```

Si vous n’avez pas `just` installé, vous pouvez aussi copier les commandes dans le `justfile`.
Cela génère les binaires.

Ensuite, connectez votre téléphone et activez le mode débogage.
Vérifiez que votre téléphone est connecté en lançant

```
flutter devices
```

Enfin, pour compiler et installer l’app sur votre appareil android :

```
flutter run
```

## Faire un don à Dana

Vous pouvez faire un don à Dana wallet en utilisant notre adresse :

> ₿donate@danawallet.app

ou vous pouvez utiliser l’adresse de paiement silencieux suivante :

> sp1qq0cygnetgn3rz2kla5cp05nj5uetlsrzez0l4p8g7wehf7ldr93lcqadw65upymwzvp5ed38l8ur2rznd6934xh95msevwrdwtrpk372hyz4vr6g

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---