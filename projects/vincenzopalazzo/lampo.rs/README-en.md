<div align="center">
  <h1>Lampo</h1>

  <img src="https://github.com/saradurante/lampo.docs/blob/dc0dce971c3052f0e9dd668fdf0c7376b12fee7b/imgs/web/icon-512.png?raw=true"  width="150" height="150" />

  <p>
    <strong>Fast and modular lightning network implementation for all usages, written in Rust.</strong>
  </p>

  <h4>
    <a href="https://lampo.devcrew.cc">Project Homepage</a>
  </h4>
</div>

## Crates

This is the complete list of crates supported right now:

| Crate       | Description                                   | Version     |
|:------------|:---------------------------------------------:|------------:|
| lampod-cli  | Lampo Daemon command line interface to run the daemon | _unrelated_ |
| lampo-cli   | Simple Lampo command line interface to interact with the daemon | _unrelated_ |

## How to Install

To install all the requirements and the Lampo binary, you need to
have rust installed, and then run the following command:

```
make install
```

After you have `lampod-cli` and `lampo-cli` available, you can
run the following command to launch Lampo in signet mode:

```
➜  ~ lampod-cli --network signet
✓ Wallet Generated, please store these words in a safe way
 wallet-keys  maple have fitness decide food joy flame coast stereo front grab stumble
```

>[!NOTE]
Store your wallet words, and then reuse them to restore the wallet with `--restore-wallet`.
If you do not store your words anywhere, your funds will be lost the next time Lampo starts!

Please note that you need to have a `lampo.conf` in the path `~/.lampo/signet`. Run the
following command to use the example config file:

```
cp lampo.example.conf ~/.lampo/signet/lampo.conf
```

Then you can query the node with the following command:

``` 
➜  ~ lampo-cli --network signet getinfo
{
  "node_id": "035b889551a44e502cd0cd6657acf067336034986cd6639b222cd4be563a7fc205",
  "peers": 0,
  "channels": 0
}
```

### To run integration tests with core lightning:

Make sure you have compiled core-lightning in developer mode. The installation guide can be found [here](https://docs.corelightning.org/docs/installation).

Integration tests can be run using the following command:

```
make integration
```

## Contributing guidelines

Please read our [Contributing guide](https://raw.githubusercontent.com/vincenzopalazzo/lampo.rs/main/CONTRIBUTING.md).

## Community

Determined to maintain clarity, we’ve chosen specific channels for communication:
- Developers, join us on [Zulip](https://lampo-dev.zulipchat.com/).
- Community members, our [Twitter community](https://twitter.com/i/communities/1736414802849706087) awaits your insights.
- For technical questions and feature requests, dive into our GitHub discussions.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---