Dit is Python versie 3.15.0 alpha 0
=====================================

.. image:: https://github.com/python/cpython/actions/workflows/build.yml/badge.svg?branch=main&event=push
   :alt: CPython buildstatus op GitHub Actions
   :target: https://github.com/python/cpython/actions

.. image:: https://dev.azure.com/python/cpython/_apis/build/status/Azure%20Pipelines%20CI?branchName=main
   :alt: CPython buildstatus op Azure DevOps
   :target: https://dev.azure.com/python/cpython/_build/latest?definitionId=4&branchName=main

.. image:: https://img.shields.io/badge/discourse-join_chat-brightgreen.svg
   :alt: Python Discourse chat
   :target: https://discuss.python.org/


Copyright © 2001 Python Software Foundation.  Alle rechten voorbehouden.

Zie het einde van dit bestand voor verdere copyright- en licentie-informatie.

.. contents::

Algemene Informatie
-------------------

- Website: https://www.python.org
- Broncode: https://github.com/python/cpython
- Issue tracker: https://github.com/python/cpython/issues
- Documentatie: https://docs.python.org
- Developer's Guide: https://devguide.python.org/

Bijdragen aan CPython
---------------------

Voor meer volledige instructies over bijdragen aan de ontwikkeling van CPython,
zie de `Developer Guide`_.

.. _Developer Guide: https://devguide.python.org/

Python gebruiken
----------------

Installeerbare Python-pakketten en informatie over het gebruik van Python zijn beschikbaar op
`python.org`_.

.. _python.org: https://www.python.org/

Build-instructies
-----------------

Op Unix, Linux, BSD, macOS en Cygwin::

    ./configure
    make
    make test
    sudo make install

Dit installeert Python als ``python3``.

U kunt veel opties aan het configure-script meegeven; voer ``./configure --help`` uit
om meer te weten te komen.  Op macOS case-insensitive bestandssystemen en op Cygwin,
heet het uitvoerbare bestand ``python.exe``; elders is het gewoon ``python``.

Voor het bouwen van een volledige Python-installatie zijn diverse
extra third-party bibliotheken nodig, afhankelijk van uw buildplatform en
configure-opties.  Niet alle standaardbibliotheekmodules zijn te bouwen of
te gebruiken op alle platforms.  Raadpleeg de
`Install dependencies <https://devguide.python.org/getting-started/setup-building.html#build-dependencies>`_
sectie van de `Developer Guide`_ voor actuele gedetailleerde informatie over
afhankelijkheden voor verschillende Linux-distributies en macOS.

Op macOS zijn er extra configure- en build-opties gerelateerd
aan macOS framework en universele builds.  Zie `Mac/README.rst
<https://github.com/python/cpython/blob/main/Mac/README.rst>`_.

Op Windows, zie `PCbuild/readme.txt
<https://github.com/python/cpython/blob/main/PCbuild/readme.txt>`_.

Voor het bouwen van een Windows-installer, zie `Tools/msi/README.txt
<https://github.com/python/cpython/blob/main/Tools/msi/README.txt>`_.

Indien gewenst kunt u een subdirectory aanmaken en configure daarvandaan uitvoeren.
Bijvoorbeeld::

    mkdir debug
    cd debug
    ../configure --with-pydebug
    make
    make test

(Dit zal mislukken als u *ook* in de hoofdmap hebt gebouwd.  U moet dan eerst
een ``make clean`` uitvoeren in de hoofdmap.)

Voor een geoptimaliseerde build van Python, gebruik ``configure --enable-optimizations``
voordat u ``make`` uitvoert.  Dit stelt de standaard make-doelen in om
Profile Guided Optimization (PGO) te activeren en kan worden gebruikt om Link Time
Optimization (LTO) automatisch in te schakelen op sommige platforms.  Zie de secties
hieronder voor meer details.

Profile Guided Optimization
^^^^^^^^^^^^^^^^^^^^^^^^^^^

PGO maakt gebruik van recente versies van de GCC- of Clang-compilers.  Indien gebruikt,
hetzij via ``configure --enable-optimizations`` of door handmatig
``make profile-opt`` uit te voeren ongeacht de configure-vlaggen, zal het geoptimaliseerde buildproces
de volgende stappen uitvoeren:

De gehele Python-directory wordt opgeschoond van tijdelijke bestanden die mogelijk
zijn achtergebleven na een eerdere compilatie.

Er wordt een geïnstrumenteerde versie van de interpreter gebouwd, met geschikte compiler
vlaggen voor elke variant. Let op: dit is slechts een tussenstap.
De binaire die uit deze stap komt, is niet geschikt voor productiegebruik omdat er
profilinginstructies zijn ingebed.

Nadat de geïnstrumenteerde interpreter is gebouwd, zal het Makefile een trainings-
workload uitvoeren.  Dit is noodzakelijk om de uitvoering van de interpreter te profileren.
Let ook op dat eventuele uitvoer, zowel stdout als stderr, die tijdens deze stap verschijnt,
wordt onderdrukt.

De laatste stap is het bouwen van de daadwerkelijke interpreter, met behulp van de informatie
die uit de geïnstrumenteerde is verkregen.  Het eindresultaat is een Python-binary
die geoptimaliseerd is; geschikt voor distributie of productie-installatie.


Link Time Optimization
^^^^^^^^^^^^^^^^^^^^^^

Ingeschakeld via de ``--with-lto`` vlag van configure.  LTO maakt gebruik van de
mogelijkheid van recente compilertoolchains om over de anders willekeurige ``.o``-bestandgrens heen te optimaliseren
bij het bouwen van uiteindelijke uitvoerbare bestanden of gedeelde
bibliotheken voor extra prestatieverbeteringen.


Wat is er nieuw
---------------

We hebben een uitgebreid overzicht van de wijzigingen in het document `What's new in Python
3.15 <https://docs.python.org/3.15/whatsnew/3.15.html>`_.  Voor een meer
gedetailleerd wijzigingslogboek, lees `Misc/NEWS
<https://github.com/python/cpython/tree/main/Misc/NEWS.d>`_, maar een volledig
overzicht van de wijzigingen kan alleen worden verkregen uit de `commit history
<https://github.com/python/cpython/commits/main>`_.

Als u meerdere versies van Python wilt installeren, zie de sectie hieronder
getiteld "Meerdere versies installeren".


Documentatie
------------

`Documentatie voor Python 3.15 <https://docs.python.org/3.15/>`_ is online,
dagelijks bijgewerkt.

Het kan ook in vele formaten worden gedownload voor snellere toegang.  De documentatie
is te downloaden in HTML-, PDF- en reStructuredText-formaten; de laatste versie
is vooral voor documentatie-auteurs, vertalers en mensen met speciale
formatteerbehoeften.

Voor informatie over het bouwen van de documentatie van Python, zie `Doc/README.rst
<https://github.com/python/cpython/blob/main/Doc/README.rst>`_.


Testen
------

Om de interpreter te testen, typ ``make test`` in de hoofdmap.  De
testset geeft enige uitvoer.  U kunt de meldingen over
overgeslagen tests vanwege optionele features die niet geïmporteerd kunnen worden, meestal negeren.
Als een melding wordt afgedrukt over een mislukte test of als er een traceback of core dump wordt geproduceerd,
is er iets mis.

Standaard wordt voorkomen dat tests overmatig gebruik maken van resources zoals schijfruimte en
geheugen.  Om deze tests in te schakelen, voer ``make buildbottest`` uit.

Als er tests mislukken, kunt u de mislukte test(s) opnieuw uitvoeren in verbose-modus.
Bijvoorbeeld, als ``test_os`` en ``test_gdb`` mislukten, kunt u uitvoeren::

    make test TESTOPTS="-v test_os test_gdb"

Als de fout aanhoudt en het lijkt een probleem met Python te zijn in plaats van
uw omgeving, kunt u een `bugrapport indienen
<https://github.com/python/cpython/issues>`_ en relevante uitvoer van
dat commando toevoegen om het probleem aan te tonen.

Zie `Running & Writing Tests <https://devguide.python.org/testing/run-write-tests.html>`_
voor meer over het uitvoeren van tests.

Meerdere versies installeren
----------------------------

Op Unix- en Mac-systemen, als u van plan bent meerdere versies van Python te installeren
met dezelfde installatieprefix (``--prefix``-argument voor het configure-script),
moet u ervoor zorgen dat uw primaire Python-uitvoerbaar bestand niet
wordt overschreven door de installatie van een andere versie.  Alle bestanden en
mappen die met ``make altinstall`` worden geïnstalleerd, bevatten het hoofd- en subversienummer en kunnen dus naast elkaar bestaan.  ``make install`` maakt ook
``${prefix}/bin/python3`` aan, dat verwijst naar ``${prefix}/bin/python3.X``.  Als u
meerdere versies met dezelfde prefix wilt installeren, moet u beslissen welke
versie (indien een) uw "primaire" versie is.  Installeer die versie met
``make install``.  Installeer alle andere versies met behulp van ``make altinstall``.

Bijvoorbeeld, als je Python 2.7, 3.6 en 3.15 wilt installeren, waarbij 3.15 de
primaire versie is, voer je ``make install`` uit in de buildmap van 3.15
en ``make altinstall`` in de andere mappen.


Releaseplanning
---------------

Zie `PEP 790 <https://peps.python.org/pep-0790/>`__ voor details over de release van Python 3.15.


Copyright- en licentie-informatie
---------------------------------


Copyright © 2001 Python Software Foundation.  Alle rechten voorbehouden.

Copyright © 2000 BeOpen.com.  Alle rechten voorbehouden.

Copyright © 1995-2001 Corporation for National Research Initiatives.  Alle
rechten voorbehouden.

Copyright © 1991-1995 Stichting Mathematisch Centrum.  Alle rechten voorbehouden.

Zie de `LICENSE <https://github.com/python/cpython/blob/main/LICENSE>`_ voor
informatie over de geschiedenis van deze software, de voorwaarden voor gebruik en een
DISCLAIMER VAN ALLE GARANTIES.

Deze Python-distributie bevat *geen* GNU General Public License (GPL) code,
dus het mag gebruikt worden in propriëtaire projecten.  Er zijn koppelingen met sommige GNU-code,
maar deze zijn geheel optioneel.

Alle hierin genoemde handelsmerken zijn eigendom van hun respectievelijke eigenaren.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---