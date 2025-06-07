Bitcoin Core integratie/staging tree
=====================================

https://bitcoincore.org

Voor een direct bruikbare, binaire versie van de Bitcoin Core software, zie
https://bitcoincore.org/en/download/.

Wat is Bitcoin Core?
--------------------

Bitcoin Core maakt verbinding met het peer-to-peer netwerk van Bitcoin om blokken en transacties te downloaden en volledig te valideren. Het bevat ook een portemonnee en een grafische gebruikersinterface, die optioneel gebouwd kunnen worden.

Meer informatie over Bitcoin Core is te vinden in de [doc map](/doc).

Licentie
--------

Bitcoin Core wordt uitgebracht onder de voorwaarden van de MIT-licentie. Zie [COPYING](COPYING) voor meer informatie of bezoek https://opensource.org/license/MIT.

Ontwikkelingsproces
-------------------

De `master` branch wordt regelmatig gebouwd (zie `doc/build-*.md` voor instructies) en getest, maar het is niet gegarandeerd dat deze volledig stabiel is. [Tags](https://github.com/bitcoin/bitcoin/tags) worden regelmatig aangemaakt vanuit release branches om nieuwe officiële, stabiele releaseversies van Bitcoin Core aan te duiden.

De https://github.com/bitcoin-core/gui repository wordt uitsluitend gebruikt voor de ontwikkeling van de GUI. De master branch is identiek in alle monotree repositories. Er bestaan geen release branches of tags, dus fork deze repository alleen als het om ontwikkelingsredenen is.

De bijdrageworkflow wordt beschreven in [CONTRIBUTING.md](CONTRIBUTING.md) en nuttige tips voor ontwikkelaars zijn te vinden in [doc/developer-notes.md](doc/developer-notes.md).

Testen
------

Testen en code review zijn de bottleneck voor de ontwikkeling; we ontvangen meer pull requests dan we op korte termijn kunnen beoordelen en testen. Wees geduldig en help door pull requests van anderen te testen, en onthoud dat dit een beveiligingskritisch project is waar elke fout mensen veel geld kan kosten.

### Geautomatiseerd testen

Ontwikkelaars worden sterk aangemoedigd om [unittests](src/test/README.md) te schrijven voor nieuwe code, en om nieuwe unittests toe te voegen voor oude code. Unittests kunnen worden gecompileerd en uitgevoerd (ervan uitgaande dat ze niet zijn uitgeschakeld tijdens het genereren van het build systeem) met: `ctest`. Meer details over het uitvoeren en uitbreiden van unittests zijn te vinden in [/src/test/README.md](/src/test/README.md).

Er zijn ook [regressie- en integratietests](/test), geschreven in Python. 
Deze tests kunnen worden uitgevoerd (als de [testafhankelijkheden](/test) zijn geïnstalleerd) met: `build/test/functional/test_runner.py`
(ervan uitgaande dat `build` uw build directory is).

De CI (Continuous Integration) systemen zorgen ervoor dat elke pull request wordt gebouwd voor Windows, Linux en macOS, en dat unit/sanity tests automatisch worden uitgevoerd.

### Handmatig testen van kwaliteitsborging (QA)

Wijzigingen dienen getest te worden door iemand anders dan de ontwikkelaar die de code heeft geschreven. Dit is vooral belangrijk voor grote of risicovolle wijzigingen. Het is handig om een testplan toe te voegen aan de beschrijving van de pull request als het testen van de wijzigingen niet eenvoudig is.

Vertalingen
-----------

Wijzigingen aan vertalingen en nieuwe vertalingen kunnen worden ingediend via de
[Transifex pagina van Bitcoin Core](https://www.transifex.com/bitcoin/bitcoin/).

Vertalingen worden periodiek opgehaald van Transifex en samengevoegd in de git-repository. Zie het
[vertaalproces](doc/translation_process.md) voor meer informatie over hoe dit werkt.

**Belangrijk**: We accepteren geen vertaalwijzigingen als GitHub pull requests omdat deze bij de volgende
pull van Transifex automatisch weer zouden worden overschreven.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---