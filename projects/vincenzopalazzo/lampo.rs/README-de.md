<div align="center">
  <h1>Lampo</h1>

  <img src="https://github.com/saradurante/lampo.docs/blob/dc0dce971c3052f0e9dd668fdf0c7376b12fee7b/imgs/web/icon-512.png?raw=true"  width="150" height="150" />

  <p>
    <strong>Schnelle und modulare Lightning-Netzwerk-Implementierung für alle Anwendungsfälle, geschrieben in Rust.</strong>
  </p>

  <h4>
    <a href="https://lampo.devcrew.cc">Projekt-Homepage</a>
  </h4>
</div>

## Crates

Dies ist die vollständige Liste der aktuell unterstützten Crates:

| Crate       | Beschreibung                                   | Version     |
|:------------|:----------------------------------------------:|------------:|
| lampod-cli  | Lampo Daemon Kommandozeilenschnittstelle zum Ausführen des Daemons | _unrelated_ |
| lampo-cli   | Einfache Lampo Kommandozeilenschnittstelle zur Interaktion mit dem Daemon | _unrelated_ |

## Installation

Um alle Anforderungen und die Lampo-Binärdatei zu installieren, muss Rust installiert sein. Führen Sie dann den folgenden Befehl aus:

```
make install
```

Nachdem Sie `lampod-cli` und `lampo-cli` zur Verfügung haben, können Sie den folgenden Befehl ausführen, um Lampo im Signet-Modus zu starten:

```
➜  ~ lampod-cli --network signet
✓ Wallet Generated, bitte bewahren Sie diese Wörter sicher auf
 wallet-keys  maple have fitness decide food joy flame coast stereo front grab stumble
```

>[!HINWEIS]
Bewahren Sie Ihre Wallet-Wörter sicher auf und verwenden Sie sie, um das Wallet mit `--restore-wallet` wiederherzustellen.
Wenn Sie Ihre Wörter nicht speichern, gehen Ihre Gelder beim nächsten Start von Lampo verloren!

Bitte beachten Sie, dass Sie eine `lampo.conf` im Pfad `~/.lampo/signet` benötigen. Führen Sie den folgenden Befehl aus, um die Beispiel-Konfigurationsdatei zu verwenden:

```
cp lampo.example.conf ~/.lampo/signet/lampo.conf
```

Anschließend können Sie den Node mit folgendem Befehl abfragen:

``` 
➜  ~ lampo-cli --network signet getinfo
{
  "node_id": "035b889551a44e502cd0cd6657acf067336034986cd6639b222cd4be563a7fc205",
  "peers": 0,
  "channels": 0
}
```

### Integrationstests mit Core Lightning ausführen:

Stellen Sie sicher, dass Sie Core-Lightning im Entwicklermodus kompiliert haben. Die Installationsanleitung finden Sie [hier](https://docs.corelightning.org/docs/installation).

Integrationstests können Sie mit folgendem Befehl ausführen:

```
make integration
```

## Richtlinien für Beiträge

Bitte lesen Sie unseren [Beitragsleitfaden](https://raw.githubusercontent.com/vincenzopalazzo/lampo.rs/main/CONTRIBUTING.md).

## Community

Um Klarheit zu gewährleisten, haben wir bestimmte Kanäle für die Kommunikation gewählt:
- Entwickler, kommt zu uns auf [Zulip](https://lampo-dev.zulipchat.com/).
- Community-Mitglieder, unsere [Twitter-Community](https://twitter.com/i/communities/1736414802849706087) freut sich auf eure Beiträge.
- Für technische Fragen und Feature-Anfragen nutzt bitte unsere GitHub-Diskussionen.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---