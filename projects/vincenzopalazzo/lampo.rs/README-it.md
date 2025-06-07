<div align="center">
  <h1>Lampo</h1>

  <img src="https://github.com/saradurante/lampo.docs/blob/dc0dce971c3052f0e9dd668fdf0c7376b12fee7b/imgs/web/icon-512.png?raw=true"  width="150" height="150" />


  <p>
    <strong>Implementazione della rete lightning veloce e modulare per tutti gli utilizzi, scritta in Rust.</strong>
  </p>

  <h4>
    <a href="https://lampo.devcrew.cc">Homepage del Progetto</a>
  </h4>
</div>

## Crate

Questa è la lista completa dei crate attualmente supportati:

| Crate       | Descrizione                                   | Versione    |
|:------------|:---------------------------------------------:|------------:|
| lampod-cli  | Interfaccia a riga di comando del demone Lampo per eseguire il demone | _unrelated_ |
| lampo-cli   | Semplice interfaccia a riga di comando Lampo per interagire con il demone | _unrelated_ |

## Come Installare

Per installare tutti i requisiti e il binario di Lampo, è necessario
avere rust installato, quindi eseguire il seguente comando:

```
make install
```

Dopo che hai `lampod-cli` e `lampo-cli` disponibili, puoi
eseguire il seguente comando per avviare Lampo in modalità signet:

```
➜  ~ lampod-cli --network signet
✓ Wallet Generato, per favore conserva queste parole in modo sicuro
 wallet-keys  maple have fitness decide food joy flame coast stereo front grab stumble
```

>[!NOTE]
Conserva le parole del tuo wallet, poi riutilizzale per ripristinare il wallet con `--restore-wallet`.
Se non conservi le tue parole da nessuna parte, i tuoi fondi andranno persi al prossimo avvio di Lampo!

Nota che è necessario avere un file `lampo.conf` nel percorso `~/.lampo/signet`. Esegui il
seguente comando per utilizzare il file di configurazione di esempio:

```
cp lampo.example.conf ~/.lampo/signet/lampo.conf
```

Poi puoi interrogare il nodo con il seguente comando:

``` 
➜  ~ lampo-cli --network signet getinfo
{
  "node_id": "035b889551a44e502cd0cd6657acf067336034986cd6639b222cd4be563a7fc205",
  "peers": 0,
  "channels": 0
}
```

### Per eseguire i test di integrazione con core lightning:

Assicurati di aver compilato core-lightning in modalità sviluppatore. La guida all’installazione è disponibile [qui](https://docs.corelightning.org/docs/installation).

I test di integrazione possono essere eseguiti con il seguente comando:

```
make integration
```

## Linee guida per contribuire

Per favore, leggi la nostra [Guida per i contributori](https://raw.githubusercontent.com/vincenzopalazzo/lampo.rs/main/CONTRIBUTING.md).

## Comunità

Determinati a mantenere la chiarezza, abbiamo scelto canali specifici per la comunicazione:
- Sviluppatori, unitevi a noi su [Zulip](https://lampo-dev.zulipchat.com/).
- Membri della comunità, la nostra [community su Twitter](https://twitter.com/i/communities/1736414802849706087) attende i vostri suggerimenti.
- Per domande tecniche e richieste di funzionalità, unitevi alle nostre discussioni su GitHub.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---