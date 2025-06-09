Dies ist Python Version 3.15.0 Alpha 0
======================================

.. image:: https://github.com/python/cpython/actions/workflows/build.yml/badge.svg?branch=main&event=push
   :alt: CPython Build-Status bei GitHub Actions
   :target: https://github.com/python/cpython/actions

.. image:: https://dev.azure.com/python/cpython/_apis/build/status/Azure%20Pipelines%20CI?branchName=main
   :alt: CPython Build-Status bei Azure DevOps
   :target: https://dev.azure.com/python/cpython/_build/latest?definitionId=4&branchName=main

.. image:: https://img.shields.io/badge/discourse-join_chat-brightgreen.svg
   :alt: Python Discourse Chat
   :target: https://discuss.python.org/


Copyright © 2001 Python Software Foundation.  Alle Rechte vorbehalten.

Weitere Informationen zu Urheberrecht und Lizenz finden Sie am Ende dieser Datei.

.. contents::

Allgemeine Informationen
------------------------

- Webseite: https://www.python.org
- Quellcode: https://github.com/python/cpython
- Issue Tracker: https://github.com/python/cpython/issues
- Dokumentation: https://docs.python.org
- Entwicklerhandbuch: https://devguide.python.org/

Beitrag zu CPython
------------------

Vollständige Anweisungen zum Beitrag zur CPython-Entwicklung finden Sie im
`Entwicklerhandbuch`_.

.. _Entwicklerhandbuch: https://devguide.python.org/

Verwendung von Python
---------------------

Installierbare Python-Pakete und Informationen zur Verwendung von Python sind
unter `python.org`_ verfügbar.

.. _python.org: https://www.python.org/

Build-Anweisungen
-----------------

Unter Unix, Linux, BSD, macOS und Cygwin::

    ./configure
    make
    make test
    sudo make install

Dies installiert Python als ``python3``.

Dem Konfigurationsskript können viele Optionen übergeben werden; führen Sie
``./configure --help`` aus, um mehr zu erfahren. Auf macOS
case-insensitiven Dateisystemen und unter Cygwin heißt die ausführbare Datei
``python.exe``; andernorts einfach ``python``.

Für eine vollständige Python-Installation müssen je nach Build-Plattform und
Konfigurationsoptionen verschiedene zusätzliche Drittanbieter-Bibliotheken
verwendet werden. Nicht alle Standardbibliotheksmodule sind auf allen
Plattformen kompilierbar oder nutzbar. Siehe den Abschnitt
`Install dependencies <https://devguide.python.org/getting-started/setup-building.html#build-dependencies>`_
im `Entwicklerhandbuch`_ für aktuelle, detaillierte Informationen zu
Abhängigkeiten für verschiedene Linux-Distributionen und macOS.

Unter macOS gibt es zusätzliche Konfigurations- und Build-Optionen im
Zusammenhang mit Framework- und Universal-Builds. Siehe `Mac/README.rst
<https://github.com/python/cpython/blob/main/Mac/README.rst>`_.

Unter Windows siehe `PCbuild/readme.txt
<https://github.com/python/cpython/blob/main/PCbuild/readme.txt>`_.

Zum Erstellen eines Windows-Installers siehe `Tools/msi/README.txt
<https://github.com/python/cpython/blob/main/Tools/msi/README.txt>`_.

Bei Bedarf können Sie ein Unterverzeichnis anlegen und das Konfigurationsskript
dort aufrufen. Beispiel::

    mkdir debug
    cd debug
    ../configure --with-pydebug
    make
    make test

(Dies schlägt fehl, wenn Sie *auch* im Hauptverzeichnis gebaut haben. Sie
sollten zuerst ein ``make clean`` im Hauptverzeichnis ausführen.)

Für einen optimierten Build von Python führen Sie ``configure --enable-optimizations``
aus, bevor Sie ``make`` ausführen. Damit werden die Standard-Make-Ziele so
gesetzt, dass Profile Guided Optimization (PGO) aktiviert wird und auf einigen
Plattformen wird möglicherweise automatisch Link Time Optimization (LTO)
aktiviert. Weitere Einzelheiten finden Sie in den folgenden Abschnitten.

Profile Guided Optimization
^^^^^^^^^^^^^^^^^^^^^^^^^^^

PGO nutzt aktuelle Versionen der GCC- oder Clang-Compiler. Wird PGO verwendet,
entweder durch ``configure --enable-optimizations`` oder durch manuelles
Ausführen von ``make profile-opt`` unabhängig von den Konfigurations-Flags,
führt der optimierte Build-Prozess folgende Schritte aus:

Das gesamte Python-Verzeichnis wird von temporären Dateien gereinigt, die von
einer vorherigen Kompilierung stammen könnten.

Eine instrumentierte Version des Interpreters wird gebaut, wobei geeignete
Compiler-Flags für jede Variante verwendet werden. Dies ist nur ein
Zwischenschritt. Die dabei entstehende Binärdatei ist für reale
Arbeitslasten nicht geeignet, da sie Profiling-Anweisungen enthält.

Nachdem der instrumentierte Interpreter gebaut wurde, führt das Makefile einen
Trainings-Workload aus. Dies ist notwendig, um den Interpreter beim Ausführen zu
profilieren. Beachten Sie, dass jegliche Ausgaben, sowohl stdout als auch
stderr, in diesem Schritt unterdrückt werden.

Im letzten Schritt wird der eigentliche Interpreter gebaut, wobei die
gesammelten Profilinformationen verwendet werden. Das Endergebnis ist eine
optimierte Python-Binärdatei, geeignet für Distribution oder Produktion.

Link Time Optimization
^^^^^^^^^^^^^^^^^^^^^^

Wird über das Konfigurations-Flag ``--with-lto`` aktiviert. LTO nutzt die
Fähigkeit aktueller Compiler-Toolchains, über die ansonsten willkürlichen
``.o``-Dateigrenzen hinweg zu optimieren, wenn finale Ausführungsdateien oder
Shared Libraries für zusätzliche Performancegewinne gebaut werden.

Was ist neu
-----------

Eine umfassende Übersicht der Änderungen finden Sie im Dokument `Was ist neu in Python
3.15 <https://docs.python.org/3.15/whatsnew/3.15.html>`_. Für ein detailliertes
Changelog lesen Sie `Misc/NEWS
<https://github.com/python/cpython/tree/main/Misc/NEWS.d>`_, aber ein vollständiger
Überblick aller Änderungen ist nur aus dem `Commit-Verlauf
<https://github.com/python/cpython/commits/main>`_ ersichtlich.

Wenn Sie mehrere Versionen von Python installieren möchten, lesen Sie den untenstehenden
Abschnitt "Installation mehrerer Versionen".

Dokumentation
-------------

`Dokumentation für Python 3.15 <https://docs.python.org/3.15/>`_ ist online
und wird täglich aktualisiert.

Sie kann auch in vielen Formaten für einen schnelleren Zugriff heruntergeladen
werden. Die Dokumentation ist als HTML, PDF und reStructuredText verfügbar;
Letztere vor allem für Dokumentationsautoren, Übersetzer und Personen mit
besonderen Formatierungsanforderungen.

Informationen zum Bauen der Python-Dokumentation finden Sie unter `Doc/README.rst
<https://github.com/python/cpython/blob/main/Doc/README.rst>`_.

Tests
-----

Um den Interpreter zu testen, geben Sie ``make test`` im Hauptverzeichnis ein.
Die Testsuite erzeugt einige Ausgaben. Sie können Meldungen über übersprungene
Tests wegen optionaler, nicht importierbarer Features meist ignorieren. Wenn
eine Meldung über einen fehlgeschlagenen Test erscheint oder ein Traceback bzw.
Core Dump erzeugt wird, stimmt etwas nicht.

Standardmäßig werden Tests daran gehindert, Ressourcen wie Festplattenspeicher
und Arbeitsspeicher übermäßig zu nutzen. Um diese Tests zu aktivieren, führen Sie
``make buildbottest`` aus.

Wenn Tests fehlschlagen, können Sie die fehlgeschlagenen Tests im Verbose-Modus
erneut ausführen. Wenn zum Beispiel ``test_os`` und ``test_gdb`` fehlschlugen,
führen Sie aus::

    make test TESTOPTS="-v test_os test_gdb"

Wenn der Fehler weiterhin besteht und auf ein Problem mit Python selbst und nicht
mit Ihrer Umgebung hinzudeuten scheint, können Sie einen `Bugreport einreichen
<https://github.com/python/cpython/issues>`_ und die relevanten Ausgaben dieses
Befehls anhängen.

Weitere Informationen zum Ausführen von Tests finden Sie unter
`Running & Writing Tests <https://devguide.python.org/testing/run-write-tests.html>`_.

Installation mehrerer Versionen
-------------------------------

Unter Unix- und Mac-Systemen müssen Sie, wenn Sie mehrere Versionen von Python
mit demselben Installationsprefix (``--prefix``-Argument für das
Konfigurationsskript) installieren möchten, darauf achten, dass Ihr
primäres Python-Executable nicht durch die Installation einer anderen Version
überschrieben wird. Alle mit ``make altinstall`` installierten Dateien und
Verzeichnisse enthalten die Haupt- und Nebenversion und können daher
nebeneinander existieren. ``make install`` erstellt außerdem
``${prefix}/bin/python3``, das auf ``${prefix}/bin/python3.X`` verweist.
Wenn Sie mehrere Versionen mit demselben Prefix installieren möchten, müssen
Sie entscheiden, welche Version (falls überhaupt) Ihre "primäre" Version ist.
Installieren Sie diese Version mit
``make install``. Installieren Sie alle anderen Versionen mit ``make altinstall``.

Wenn Sie beispielsweise Python 2.7, 3.6 und 3.15 installieren möchten, wobei 3.15 die
primäre Version ist, führen Sie ``make install`` im Build-Verzeichnis von 3.15 aus
und ``make altinstall`` in den anderen.


Release-Zeitplan
----------------

Siehe `PEP 790 <https://peps.python.org/pep-0790/>`__ für Details zur Veröffentlichung von Python 3.15.


Urheberrecht und Lizenzinformationen
------------------------------------


Copyright © 2001 Python Software Foundation. Alle Rechte vorbehalten.

Copyright © 2000 BeOpen.com. Alle Rechte vorbehalten.

Copyright © 1995-2001 Corporation for National Research Initiatives. Alle
Rechte vorbehalten.

Copyright © 1991-1995 Stichting Mathematisch Centrum. Alle Rechte vorbehalten.

Siehe die `LICENSE <https://github.com/python/cpython/blob/main/LICENSE>`_ für
Informationen zur Historie dieser Software, Nutzungsbedingungen und einen
HAFTUNGSAUSSCHLUSS FÜR ALLE GARANTIEN.

Diese Python-Distribution enthält *keinen* Code unter der GNU General Public License (GPL),
sodass sie in proprietären Projekten verwendet werden kann. Es gibt Schnittstellen zu einigen GNU-
Codes, aber diese sind vollständig optional.

Alle hierin erwähnten Marken sind Eigentum der jeweiligen Rechteinhaber.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---