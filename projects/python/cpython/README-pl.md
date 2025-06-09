To jest Python w wersji 3.15.0 alpha 0
======================================

.. image:: https://github.com/python/cpython/actions/workflows/build.yml/badge.svg?branch=main&event=push
   :alt: Status budowy CPython na GitHub Actions
   :target: https://github.com/python/cpython/actions

.. image:: https://dev.azure.com/python/cpython/_apis/build/status/Azure%20Pipelines%20CI?branchName=main
   :alt: Status budowy CPython na Azure DevOps
   :target: https://dev.azure.com/python/cpython/_build/latest?definitionId=4&branchName=main

.. image:: https://img.shields.io/badge/discourse-join_chat-brightgreen.svg
   :alt: Czat Python Discourse
   :target: https://discuss.python.org/


Copyright © 2001 Python Software Foundation.  Wszelkie prawa zastrzeżone.

Zobacz koniec tego pliku, aby uzyskać dodatkowe informacje dotyczące praw autorskich i licencji.

.. contents::

Informacje ogólne
-----------------

- Strona internetowa: https://www.python.org
- Kod źródłowy: https://github.com/python/cpython
- Śledzenie błędów: https://github.com/python/cpython/issues
- Dokumentacja: https://docs.python.org
- Przewodnik dla deweloperów: https://devguide.python.org/

Wkład w rozwój CPython
----------------------

Bardziej szczegółowe instrukcje dotyczące wkładu w rozwój CPython znajdują się w `Developer Guide`_.

.. _Developer Guide: https://devguide.python.org/

Korzystanie z Pythona
---------------------

Instalowalne pakiety Pythona oraz informacje dotyczące korzystania z Pythona są dostępne na stronie
`python.org`_.

.. _python.org: https://www.python.org/

Instrukcje budowania
--------------------

Na systemach Unix, Linux, BSD, macOS i Cygwin::

    ./configure
    make
    make test
    sudo make install

To polecenie zainstaluje Pythona jako ``python3``.

Możesz przekazać wiele opcji do skryptu configure; uruchom ``./configure --help``,
aby dowiedzieć się więcej. Na systemach macOS z systemem plików niewrażliwym na wielkość liter i na Cygwin
plik wykonywalny nazywa się ``python.exe``; w innych przypadkach po prostu ``python``.

Zbudowanie kompletnej instalacji Pythona wymaga użycia różnych zewnętrznych bibliotek, w zależności od
platformy budowania i opcji configure. Nie wszystkie moduły biblioteki standardowej mogą być zbudowane lub
używane na wszystkich platformach. Zapoznaj się z sekcją
`Instalacja zależności <https://devguide.python.org/getting-started/setup-building.html#build-dependencies>`_
w `Developer Guide`_, aby uzyskać aktualne szczegółowe informacje o zależnościach dla różnych dystrybucji Linuksa oraz macOS.

Na macOS istnieją dodatkowe opcje configure i budowania związane z frameworkiem macOS i budowami uniwersalnymi. Zobacz `Mac/README.rst
<https://github.com/python/cpython/blob/main/Mac/README.rst>`_.

Na Windows, zobacz `PCbuild/readme.txt
<https://github.com/python/cpython/blob/main/PCbuild/readme.txt>`_.

Aby zbudować instalator Windows, zobacz `Tools/msi/README.txt
<https://github.com/python/cpython/blob/main/Tools/msi/README.txt>`_.

Jeśli chcesz, możesz utworzyć podkatalog i wywołać configure z tego miejsca.
Na przykład::

    mkdir debug
    cd debug
    ../configure --with-pydebug
    make
    make test

(To polecenie zakończy się niepowodzeniem, jeśli *również* zbudowałeś w katalogu głównym. Najpierw wykonaj
``make clean`` w katalogu głównym.)

Aby uzyskać zoptymalizowaną wersję Pythona, użyj ``configure --enable-optimizations``
przed uruchomieniem ``make``. Ustawi to domyślne cele make na włączenie
Profile Guided Optimization (PGO) i może być użyte do automatycznego włączenia Link Time
Optimization (LTO) na niektórych platformach. Więcej szczegółów znajdziesz w poniższych sekcjach.

Profile Guided Optimization
^^^^^^^^^^^^^^^^^^^^^^^^^^^

PGO korzysta z zalet nowszych wersji kompilatorów GCC lub Clang. Jeśli używasz,
albo poprzez ``configure --enable-optimizations``, albo ręcznie uruchamiając
``make profile-opt`` niezależnie od opcji configure, zoptymalizowany proces budowania
wykona następujące kroki:

Cały katalog Pythona jest czyszczony z plików tymczasowych, które mogły
powstać w wyniku wcześniejszej kompilacji.

Budowana jest zainstrumentowana wersja interpretera, z odpowiednimi flagami kompilatora dla każdej wersji. Zwróć uwagę, że to tylko krok pośredni.
Plik binarny powstały w tym kroku nie nadaje się do pracy produkcyjnej, ponieważ zawiera
wbudowane instrukcje profilujące.

Po zbudowaniu zainstrumentowanego interpretera, Makefile uruchomi zestaw treningowy.
Jest to konieczne, aby profilować wykonanie interpretera.
Należy również pamiętać, że wszelki output, zarówno stdout jak i stderr, który pojawi się na tym etapie,
jest tłumiony.

Ostatnim krokiem jest zbudowanie właściwego interpretera, wykorzystując informacje
zebrane z wersji zainstrumentowanej. Efektem końcowym będzie plik binarny Pythona,
który jest zoptymalizowany; nadaje się do dystrybucji lub instalacji produkcyjnej.


Link Time Optimization
^^^^^^^^^^^^^^^^^^^^^^

Włączane za pomocą flagi ``--with-lto`` w configure. LTO korzysta z możliwości
najnowszych narzędzi kompilacyjnych do optymalizacji poza granicami plików ``.o``
przy budowaniu końcowych plików wykonywalnych lub bibliotek współdzielonych w celu uzyskania dodatkowych korzyści wydajnościowych.


Co nowego
---------

Mamy kompleksowy przegląd zmian w dokumencie `Co nowego w Pythonie
3.15 <https://docs.python.org/3.15/whatsnew/3.15.html>`_. Bardziej szczegółowy dziennik zmian znajdziesz w pliku `Misc/NEWS
<https://github.com/python/cpython/tree/main/Misc/NEWS.d>`_, ale pełnego zestawienia zmian można się tylko dowiedzieć z `historii commitów
<https://github.com/python/cpython/commits/main>`_.

Jeśli chcesz zainstalować wiele wersji Pythona, zobacz poniższą sekcję
zatytułowaną "Instalowanie wielu wersji".


Dokumentacja
------------

`Dokumentacja dla Pythona 3.15 <https://docs.python.org/3.15/>`_ jest dostępna online,
aktualizowana codziennie.

Można ją również pobrać w wielu formatach dla szybszego dostępu. Dokumentacja
jest dostępna do pobrania w formatach HTML, PDF i reStructuredText; ta ostatnia wersja
jest głównie dla autorów dokumentacji, tłumaczy oraz osób ze specjalnymi wymaganiami dotyczącymi formatowania.

Informacje o budowaniu dokumentacji Pythona znajdziesz w pliku `Doc/README.rst
<https://github.com/python/cpython/blob/main/Doc/README.rst>`_.


Testowanie
----------

Aby przetestować interpreter, wpisz ``make test`` w katalogu głównym. Zestaw testowy
generuje pewien output. Zazwyczaj możesz zignorować komunikaty o pominiętych testach
z powodu opcjonalnych funkcji, które nie mogą być zaimportowane. Jeśli pojawi się komunikat
o nieudanym teście lub zostanie wygenerowany traceback albo zrzut pamięci,
oznacza to problem.

Domyślnie testy są chronione przed nadmiernym użyciem zasobów, takich jak miejsce na dysku czy pamięć.
Aby włączyć te testy, uruchom ``make buildbottest``.

Jeśli jakiekolwiek testy zakończą się niepowodzeniem, możesz ponownie uruchomić nieudane testy w trybie szczegółowym.
Na przykład, jeśli ``test_os`` i ``test_gdb`` nie powiodły się, możesz uruchomić::

    make test TESTOPTS="-v test_os test_gdb"

Jeśli błąd się powtarza i wygląda na problem z Pythonem, a nie z Twoim środowiskiem, możesz `zgłosić błąd
<https://github.com/python/cpython/issues>`_ i dołączyć odpowiedni output z tego polecenia, aby pokazać problem.

Zobacz `Uruchamianie i pisanie testów <https://devguide.python.org/testing/run-write-tests.html>`_
aby dowiedzieć się więcej o uruchamianiu testów.

Instalowanie wielu wersji
-------------------------

Na systemach Unix i Mac, jeśli zamierzasz zainstalować wiele wersji Pythona
używając tego samego prefiksu instalacyjnego (argument ``--prefix`` dla skryptu configure),
musisz upewnić się, że Twój główny plik wykonywalny python nie zostanie
nadpisany przez instalację innej wersji. Wszystkie pliki i katalogi instalowane przy użyciu ``make altinstall``
zawierają numer główny i pomocniczy wersji, dzięki czemu mogą istnieć obok siebie. ``make install`` tworzy także
``${prefix}/bin/python3``, który wskazuje na ``${prefix}/bin/python3.X``. Jeśli
zamierzasz zainstalować wiele wersji z użyciem tego samego prefiksu, musisz zdecydować, która
wersja (jeśli w ogóle) będzie Twoją "główną" wersją. Zainstaluj tę wersję używając
``make install``.  Zainstaluj wszystkie pozostałe wersje używając ``make altinstall``.

Na przykład, jeśli chcesz zainstalować Python 2.7, 3.6 i 3.15, przy czym 3.15 ma być
wersją główną, należy wykonać ``make install`` w katalogu budowania 3.15
i ``make altinstall`` w pozostałych.


Harmonogram wydania
-------------------

Zobacz `PEP 790 <https://peps.python.org/pep-0790/>`__ po szczegóły dotyczące wydania Python 3.15.


Informacje o prawach autorskich i licencji
------------------------------------------


Copyright © 2001 Python Software Foundation.  Wszelkie prawa zastrzeżone.

Copyright © 2000 BeOpen.com.  Wszelkie prawa zastrzeżone.

Copyright © 1995-2001 Corporation for National Research Initiatives.  Wszelkie prawa zastrzeżone.

Copyright © 1991-1995 Stichting Mathematisch Centrum.  Wszelkie prawa zastrzeżone.

Zobacz `LICENSE <https://raw.githubusercontent.com/python/cpython/main/LICENSE>`_ po
informacje dotyczące historii tego oprogramowania, warunków użytkowania oraz
ZASTRZEŻENIA WSZELKICH GWARANCJI.

Ta dystrybucja Pythona *nie* zawiera kodu objętego licencją GNU General Public License (GPL),
więc może być używana w projektach komercyjnych.  Istnieją interfejsy do niektórych komponentów GNU,
jednak są one całkowicie opcjonalne.

Wszystkie znaki towarowe wymienione w tym dokumencie są własnością ich odpowiednich właścicieli.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---