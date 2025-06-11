# Dana wallet

Dana is a flutter app used for accepting bitcoin donations. It uses silent payments, a new static payments protocol, to receive donations while preserving on-chain privacy.

## Try out Dana wallet

**Dana wallet is currently still in an experimental phase. We recommend sticking to testnet/signet. If you really want to test out the wallet on mainnet, only use funds you are willing to lose. We don't take responsibility for lost funds.**

We are looking into releasing Dana wallet on the popular app stores once the app is more stable.

In the meantime, there are two ways to try out Dana wallet:

- Download the latest Dana wallet APK from the [releases page](https://github.com/cygnet3/danawallet/releases)
- Download Dana wallet using our [self-hosted F-Droid repository](https://fdroid.silentpayments.dev/fdroid/repo)

### Download using F-Droid

We recommend the F-Droid option, since this has support for automatic updates, and only requires setup once.

- Open F-Droid on your android phone
- Go to 'Settings'
- In the 'My Apps' section, click on 'Repositories'
- Add a new repository by clicking the '+' icon
- Scan the QR code found on this page: https://fdroid.silentpayments.dev/fdroid/repo

You now have added our self-hosted repository. To download the app, search for 'Dana Wallet' in the F-Droid app store section (you may need to refresh the app list first, by swiping down on the F-Droid store screen).

## Building Dana wallet from source

Below are some instructions to build Dana wallet from souce. This is only recommended if you want to want to help out with development for Dana wallet.

### Building for linux (desktop)

Building for linux should require no extra effort, simply execute

```
flutter run
```

This may also work on other platforms (macOS, Windows), but we have not tested this.

### Building for android

Building for an android device requires some preparatory work, to generate binaries for this architecture.

First, you need `cargo-ndk`. You may also need to add your desired toolchains:

```
cargo install cargo-ndk
rustup target add \
    aarch64-linux-android \
    armv7-linux-androideabi \
    x86_64-linux-android \
    i686-linux-android
```

After these are installed, go in to the rust directory and run `just build-android`.

```
cd rust
just build-android
```

If you don't have `just` installed, you can also copy the commands found in the `justfile`.
This generates the binaries.

Next, connect your phone and enable debugging mode.
Check if you phone is connected by running

```
flutter devices
```

Finally, to build and install the app for your android device:

```
flutter run
```

## Donate to Dana

You can donate to Dana wallet using our address:

> ₿donate@danawallet.app

or you can use the following silent payment-address:

> sp1qq0cygnetgn3rz2kla5cp05nj5uetlsrzez0l4p8g7wehf7ldr93lcqadw65upymwzvp5ed38l8ur2rznd6934xh95msevwrdwtrpk372hyz4vr6g

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---