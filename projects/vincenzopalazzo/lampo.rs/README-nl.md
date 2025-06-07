<div align="center">
  <h1>Lampo</h1>

  <img src="https://github.com/saradurante/lampo.docs/blob/dc0dce971c3052f0e9dd668fdf0c7376b12fee7b/imgs/web/icon-512.png?raw=true"  width="150" height="150" />


  <p>
    <strong>Snelle en modulaire lightning network-implementatie voor alle toepassingen, geschreven in Rust.</strong>
  </p>

  <h4>
    <a href="https://lampo.devcrew.cc">Project Homepage</a>
  </h4>
</div>

## Crates

Dit is de volledige lijst van momenteel ondersteunde crates:

| Crate       | Beschrijving                                   | Versie     |
|:------------|:----------------------------------------------:|-----------:|
| lampod-cli  | Lampo Daemon command line interface om de daemon te draaien | _unrelated_ |
| lampo-cli   | Simpele Lampo command line interface om te communiceren met de daemon | _unrelated_ |

## Installatie

Om aan alle vereisten te voldoen en het Lampo-binary te installeren, moet je
rust geïnstalleerd hebben en vervolgens het volgende commando uitvoeren:

```
make install
```

Zodra je `lampod-cli` en `lampo-cli` beschikbaar hebt, kun je
het volgende commando uitvoeren om Lampo in signet-modus te starten:

```
➜  ~ lampod-cli --network signet
✓ Wallet gegenereerd, bewaar deze woorden op een veilige plek
 wallet-keys  maple have fitness decide food joy flame coast stereo front grab stumble
```

>[!NOTE]
Bewaar je wallet-woorden en gebruik ze opnieuw om de wallet te herstellen met `--restore-wallet`.
Als je je woorden nergens opslaat, gaan je fondsen verloren bij de volgende keer dat Lampo wordt gestart!

Let op dat je een `lampo.conf` bestand moet hebben in het pad `~/.lampo/signet`. Voer het
volgende commando uit om het voorbeeldconfiguratiebestand te gebruiken:

```
cp lampo.example.conf ~/.lampo/signet/lampo.conf
```

Daarna kun je de node opvragen met het volgende commando:

``` 
➜  ~ lampo-cli --network signet getinfo
{
  "node_id": "035b889551a44e502cd0cd6657acf067336034986cd6639b222cd4be563a7fc205",
  "peers": 0,
  "channels": 0
}
```

### Integratietests uitvoeren met core lightning:

Zorg ervoor dat je core-lightning hebt gecompileerd in ontwikkelaarsmodus. De installatiegids vind je [hier](https://docs.corelightning.org/docs/installation).

Integratietests kunnen uitgevoerd worden met het volgende commando:

```
make integration
```

## Richtlijnen voor bijdragen

Lees onze [Contributiehandleiding](https://raw.githubusercontent.com/vincenzopalazzo/lampo.rs/main/CONTRIBUTING.md).

## Community

Om duidelijkheid te behouden, hebben we gekozen voor specifieke communicatiekanalen:
- Ontwikkelaars, sluit je aan bij ons op [Zulip](https://lampo-dev.zulipchat.com/).
- Communityleden, onze [Twitter-community](https://twitter.com/i/communities/1736414802849706087) verwelkomt je inzichten.
- Voor technische vragen en feature requests, ga naar onze GitHub discussies.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---