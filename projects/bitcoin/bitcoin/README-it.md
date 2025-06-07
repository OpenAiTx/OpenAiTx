Albero di integrazione/staging di Bitcoin Core
==============================================

https://bitcoincore.org

Per una versione binaria di Bitcoin Core immediatamente utilizzabile, consulta
https://bitcoincore.org/en/download/.

Cos'è Bitcoin Core?
-------------------

Bitcoin Core si connette alla rete peer-to-peer di Bitcoin per scaricare e validare completamente
blocchi e transazioni. Include anche un portafoglio e un'interfaccia grafica utente, che possono essere opzionalmente compilati.

Ulteriori informazioni su Bitcoin Core sono disponibili nella [cartella doc](/doc).

Licenza
-------

Bitcoin Core è rilasciato secondo i termini della licenza MIT. Vedi [COPYING](COPYING) per ulteriori
informazioni oppure consulta https://opensource.org/license/MIT.

Processo di sviluppo
--------------------

Il branch `master` viene compilato regolarmente (vedi `doc/build-*.md` per le istruzioni) e testato, ma non è garantito che sia
completamente stabile. I [Tag](https://github.com/bitcoin/bitcoin/tags) vengono creati
regolarmente dai branch di rilascio per indicare le nuove versioni ufficiali e stabili di Bitcoin Core.

Il repository https://github.com/bitcoin-core/gui è utilizzato esclusivamente per lo
sviluppo della GUI. Il suo branch master è identico in tutti i repository monotree.
Non esistono branch di rilascio né tag, quindi si prega di non fare fork
di quel repository se non per motivi di sviluppo.

Il flusso di lavoro per i contributi è descritto in [CONTRIBUTING.md](CONTRIBUTING.md)
e suggerimenti utili per sviluppatori si trovano in [doc/developer-notes.md](doc/developer-notes.md).

Testing
-------

Il testing e la revisione del codice sono il collo di bottiglia per lo sviluppo; riceviamo più pull
request di quante ne possiamo revisionare e testare in breve tempo. Si prega di avere pazienza e di aiutare testando
le pull request di altri, ricordando che questo è un progetto critico per la sicurezza in cui qualsiasi errore potrebbe costare
molti soldi agli utenti.

### Test automatizzati

Si incoraggiano fortemente gli sviluppatori a scrivere [unit test](src/test/README.md) per il nuovo codice e a
sottomettere nuovi unit test anche per il codice esistente. Gli unit test possono essere compilati ed eseguiti
(a meno che non siano stati disabilitati durante la generazione del sistema di build) con: `ctest`. Ulteriori dettagli sull'esecuzione
e l'estensione degli unit test si trovano in [/src/test/README.md](/src/test/README.md).

Esistono anche [test di regressione e integrazione](/test), scritti
in Python.
Questi test possono essere eseguiti (se le [dipendenze dei test](/test) sono installate) con: `build/test/functional/test_runner.py`
(presumendo che `build` sia la tua cartella di build).

I sistemi CI (Continuous Integration) assicurano che ogni pull request sia compilata per Windows, Linux e macOS,
e che i test di unità/sanity vengano eseguiti automaticamente.

### Test manuali di Quality Assurance (QA)

Le modifiche dovrebbero essere testate da qualcuno diverso dallo sviluppatore che ha scritto il
codice. Questo è particolarmente importante per modifiche grandi o ad alto rischio. È utile
aggiungere un piano di test alla descrizione della pull request se il test delle modifiche non è
immediato.

Traduzioni
----------

Modifiche alle traduzioni così come nuove traduzioni possono essere inviate alla
[pagina Transifex di Bitcoin Core](https://www.transifex.com/bitcoin/bitcoin/).

Le traduzioni vengono periodicamente prelevate da Transifex e integrate nel repository git. Consulta il
[processo di traduzione](doc/translation_process.md) per dettagli su come funziona.

**Importante**: Non accettiamo modifiche alle traduzioni come pull request su GitHub perché il prossimo
prelievo da Transifex le sovrascriverebbe automaticamente.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---