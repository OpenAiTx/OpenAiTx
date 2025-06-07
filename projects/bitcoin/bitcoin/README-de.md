Bitcoin Core Integrations-/Staging-Tree
=======================================

https://bitcoincore.org

Für eine sofort nutzbare, binäre Version der Bitcoin Core Software siehe
https://bitcoincore.org/en/download/.

Was ist Bitcoin Core?
---------------------

Bitcoin Core verbindet sich mit dem Bitcoin Peer-to-Peer-Netzwerk, um Blöcke und Transaktionen herunterzuladen und vollständig zu validieren. Es enthält außerdem eine Wallet und eine grafische Benutzeroberfläche, die optional gebaut werden kann.

Weitere Informationen über Bitcoin Core sind im [doc-Verzeichnis](/doc) verfügbar.

Lizenz
------

Bitcoin Core wird unter den Bedingungen der MIT-Lizenz veröffentlicht. Siehe [COPYING](COPYING) für weitere Informationen oder https://opensource.org/license/MIT.

Entwicklungsprozess
-------------------

Der `master`-Branch wird regelmäßig gebaut (siehe `doc/build-*.md` für Anweisungen) und getestet, aber es wird nicht garantiert, dass er vollständig stabil ist. [Tags](https://github.com/bitcoin/bitcoin/tags) werden regelmäßig von Release-Branches erstellt, um neue offizielle, stabile Release-Versionen von Bitcoin Core anzuzeigen.

Das Repository https://github.com/bitcoin-core/gui wird ausschließlich für die Entwicklung der GUI verwendet. Sein Master-Branch ist in allen Monotree-Repositories identisch. Release-Branches und Tags existieren nicht, daher bitte dieses Repository nicht forken, es sei denn, es geschieht zu Entwicklungszwecken.

Der Beitrag-Workflow ist in [CONTRIBUTING.md](CONTRIBUTING.md) beschrieben, und nützliche Hinweise für Entwickler finden sich in [doc/developer-notes.md](doc/developer-notes.md).

Tests
-----

Tests und Code-Review sind der Engpass für die Entwicklung; wir erhalten mehr Pull-Requests, als wir kurzfristig überprüfen und testen können. Bitte haben Sie Geduld und helfen Sie, indem Sie die Pull-Requests anderer testen, und bedenken Sie, dass dies ein sicherheitskritisches Projekt ist, bei dem jeder Fehler Menschen viel Geld kosten kann.

### Automatisierte Tests

Entwickler werden dringend ermutigt, [Unit-Tests](src/test/README.md) für neuen Code zu schreiben und neue Unit-Tests für alten Code einzureichen. Unit-Tests können kompiliert und ausgeführt werden (sofern sie beim Erzeugen des Build-Systems nicht deaktiviert wurden) mit: `ctest`. Weitere Details zum Ausführen und Erweitern von Unit-Tests finden Sie in [/src/test/README.md](/src/test/README.md).

Es gibt auch [Regressions- und Integrationstests](/test), die in Python geschrieben sind. Diese Tests können ausgeführt werden (wenn die [Testabhängigkeiten](/test) installiert sind) mit: `build/test/functional/test_runner.py` (vorausgesetzt, `build` ist Ihr Build-Verzeichnis).

Die CI-(Continuous Integration)-Systeme stellen sicher, dass jeder Pull-Request für Windows, Linux und macOS gebaut wird und dass Unit-/Sanity-Tests automatisch ausgeführt werden.

### Manuelles Qualitätssicherungs-(QA)-Testing

Änderungen sollten von jemand anderem getestet werden als dem Entwickler, der den Code geschrieben hat. Dies ist besonders wichtig bei großen oder risikoreichen Änderungen. Es ist hilfreich, einen Testplan zur Pull-Request-Beschreibung hinzuzufügen, wenn das Testen der Änderungen nicht unkompliziert ist.

Übersetzungen
-------------

Änderungen an Übersetzungen sowie neue Übersetzungen können auf der
[Transifex-Seite von Bitcoin Core](https://www.transifex.com/bitcoin/bitcoin/) eingereicht werden.

Übersetzungen werden regelmäßig von Transifex abgerufen und in das Git-Repository übernommen. Siehe den
[Übersetzungsprozess](doc/translation_process.md) für Details, wie dies funktioniert.

**Wichtig**: Wir akzeptieren keine Übersetzungsänderungen als GitHub-Pull-Requests, da der nächste
Pull von Transifex diese automatisch wieder überschreiben würde.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---