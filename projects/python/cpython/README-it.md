Questa è la versione 3.15.0 alpha 0 di Python
=============================================

.. image:: https://github.com/python/cpython/actions/workflows/build.yml/badge.svg?branch=main&event=push
   :alt: Stato della build di CPython su GitHub Actions
   :target: https://github.com/python/cpython/actions

.. image:: https://dev.azure.com/python/cpython/_apis/build/status/Azure%20Pipelines%20CI?branchName=main
   :alt: Stato della build di CPython su Azure DevOps
   :target: https://dev.azure.com/python/cpython/_build/latest?definitionId=4&branchName=main

.. image:: https://img.shields.io/badge/discourse-join_chat-brightgreen.svg
   :alt: Chat Discourse Python
   :target: https://discuss.python.org/


Copyright © 2001 Python Software Foundation.  Tutti i diritti riservati.

Per ulteriori informazioni su copyright e licenza, consultare la fine di questo file.

.. contents::

Informazioni generali
---------------------

- Sito web: https://www.python.org
- Codice sorgente: https://github.com/python/cpython
- Issue tracker: https://github.com/python/cpython/issues
- Documentazione: https://docs.python.org
- Guida per sviluppatori: https://devguide.python.org/

Contribuire a CPython
---------------------

Per istruzioni più complete su come contribuire allo sviluppo di CPython,
consultare la `Developer Guide`_.

.. _Developer Guide: https://devguide.python.org/

Utilizzo di Python
------------------

Kit Python installabili e informazioni sull'utilizzo di Python sono disponibili su
`python.org`_.

.. _python.org: https://www.python.org/

Istruzioni di compilazione
--------------------------

Su Unix, Linux, BSD, macOS e Cygwin::

    ./configure
    make
    make test
    sudo make install

Questo installerà Python come ``python3``.

È possibile passare molte opzioni allo script configure; eseguire ``./configure --help``
per saperne di più. Su file system macOS case-insensitive e su Cygwin,
l'eseguibile si chiama ``python.exe``; altrove è semplicemente ``python``.

La compilazione di un'installazione completa di Python richiede l'uso di varie
librerie di terze parti aggiuntive, a seconda della piattaforma di compilazione e delle
opzioni di configure. Non tutti i moduli della libreria standard sono compilabili o
utilizzabili su tutte le piattaforme. Fare riferimento alla sezione
`Install dependencies <https://devguide.python.org/getting-started/setup-building.html#build-dependencies>`_
della `Developer Guide`_ per informazioni dettagliate aggiornate sulle
dipendenze per varie distribuzioni Linux e macOS.

Su macOS, sono disponibili opzioni aggiuntive di configure e build relative
a framework macOS e build universali. Consultare `Mac/README.rst
<https://github.com/python/cpython/blob/main/Mac/README.rst>`_.

Su Windows, vedere `PCbuild/readme.txt
<https://github.com/python/cpython/blob/main/PCbuild/readme.txt>`_.

Per creare l'installer di Windows, consultare `Tools/msi/README.txt
<https://github.com/python/cpython/blob/main/Tools/msi/README.txt>`_.

Se lo desideri, puoi creare una sottodirectory ed eseguire configure da lì.
Ad esempio::

    mkdir debug
    cd debug
    ../configure --with-pydebug
    make
    make test

(Questo fallirà se hai *anche* compilato nella directory principale. È necessario eseguire
un ``make clean`` nella directory principale prima.)

Per ottenere una build ottimizzata di Python, utilizzare ``configure --enable-optimizations``
prima di eseguire ``make``. Questo imposterà i target predefiniti di make per abilitare
Profile Guided Optimization (PGO) e potrebbe essere usato per abilitare automaticamente la
Link Time Optimization (LTO) su alcune piattaforme. Per maggiori dettagli, consultare le sezioni
seguenti.

Profile Guided Optimization
^^^^^^^^^^^^^^^^^^^^^^^^^^^

PGO sfrutta le versioni recenti dei compilatori GCC o Clang. Se utilizzato,
sia tramite ``configure --enable-optimizations`` sia eseguendo manualmente
``make profile-opt`` indipendentemente dai flag di configure, il processo di build ottimizzata
eseguirà i seguenti passaggi:

L'intera directory di Python viene ripulita dai file temporanei che potrebbero essere
stati generati da una compilazione precedente.

Viene compilata una versione strumentata dell'interprete, usando i flag di compilazione
appropriati per ogni variante. Nota che questo è solo un passaggio intermedio.
Il binario risultante da questo passaggio non è adatto all'uso reale poiché contiene
istruzioni di profilazione integrate.

Dopo che l'interprete strumentato è stato compilato, il Makefile eseguirà un carico di lavoro di training.
Questo è necessario per profilare l'esecuzione dell'interprete.
Nota inoltre che qualsiasi output, sia stdout che stderr, che potrebbe apparire in questo passaggio,
viene soppresso.

Il passaggio finale consiste nel compilare l'interprete effettivo, utilizzando le informazioni
raccolte da quello strumentato. Il risultato finale sarà un binario Python
ottimizzato; adatto per la distribuzione o l'installazione in produzione.


Link Time Optimization
^^^^^^^^^^^^^^^^^^^^^^

Abilitata tramite il flag ``--with-lto`` di configure. LTO sfrutta la
capacità delle toolchain di compilatori recenti di ottimizzare oltre i limiti
arbitrari dei file ``.o`` durante la creazione degli eseguibili finali o delle librerie
condivise per ottenere ulteriori miglioramenti delle prestazioni.


Novità
------

Abbiamo una panoramica completa delle modifiche nel documento `What's new in Python
3.15 <https://docs.python.org/3.15/whatsnew/3.15.html>`_. Per un
changelog più dettagliato, leggere `Misc/NEWS
<https://github.com/python/cpython/tree/main/Misc/NEWS.d>`_, ma un
resoconto completo delle modifiche può essere ottenuto solo dallo `storico dei commit
<https://github.com/python/cpython/commits/main>`_.

Se desideri installare più versioni di Python, consulta la sezione seguente
intitolata "Installazione di più versioni".


Documentazione
--------------

La `Documentazione di Python 3.15 <https://docs.python.org/3.15/>`_ è online,
aggiornata quotidianamente.

Può anche essere scaricata in molti formati per un accesso più rapido. La documentazione
è scaricabile in formato HTML, PDF e reStructuredText; quest'ultima versione
è principalmente per autori della documentazione, traduttori e persone con esigenze
di formattazione particolari.

Per informazioni sulla compilazione della documentazione di Python, consultare `Doc/README.rst
<https://github.com/python/cpython/blob/main/Doc/README.rst>`_.


Testing
-------

Per testare l'interprete, digitare ``make test`` nella directory principale. Il
set di test produce alcuni output. In genere puoi ignorare i messaggi relativi ai
test saltati a causa di funzionalità opzionali che non possono essere importate. Se viene
stampato un messaggio relativo a un test fallito, o viene prodotto un traceback o un core dump,
c'è qualcosa che non va.

Per impostazione predefinita, i test sono impediti dall'usare eccessivamente risorse come spazio su disco e
memoria. Per abilitare questi test, eseguire ``make buildbottest``.

Se alcuni test falliscono, puoi rieseguire i test falliti in modalità verbosa. Ad
esempio, se ``test_os`` e ``test_gdb`` sono falliti, puoi eseguire::

    make test TESTOPTS="-v test_os test_gdb"

Se il problema persiste e sembra essere causato da Python e non dal tuo ambiente,
puoi `segnalare un bug
<https://github.com/python/cpython/issues>`_ e includere l'output rilevante
di quel comando per mostrare il problema.

Vedere `Running & Writing Tests <https://devguide.python.org/testing/run-write-tests.html>`_
per ulteriori informazioni sull'esecuzione dei test.

Installazione di più versioni
-----------------------------

Su sistemi Unix e Mac, se si desidera installare più versioni di Python
utilizzando lo stesso prefisso di installazione (argomento ``--prefix`` allo script configure)
è necessario fare attenzione che il proprio eseguibile python principale non venga
sovrascritto dall'installazione di una versione diversa. Tutti i file e le
directory installate utilizzando ``make altinstall`` contengono la versione maggiore e minore e possono quindi coesistere. ``make install`` crea anche
``${prefix}/bin/python3`` che fa riferimento a ``${prefix}/bin/python3.X``. Se si
desidera installare più versioni usando lo stesso prefisso è necessario decidere quale
versione (se presente) sarà la versione "principale". Installare quella versione usando
``make install``.  Installa tutte le altre versioni utilizzando ``make altinstall``.

Ad esempio, se desideri installare Python 2.7, 3.6 e 3.15 con la 3.15 come versione
principale, dovresti eseguire ``make install`` nella directory di build della 3.15
e ``make altinstall`` nelle altre.


Pianificazione delle Release
----------------------------

Consulta `PEP 790 <https://peps.python.org/pep-0790/>`__ per i dettagli sulla release di Python 3.15.


Copyright e Informazioni sulla Licenza
--------------------------------------


Copyright © 2001 Python Software Foundation.  Tutti i diritti riservati.

Copyright © 2000 BeOpen.com.  Tutti i diritti riservati.

Copyright © 1995-2001 Corporation for National Research Initiatives.  Tutti
i diritti riservati.

Copyright © 1991-1995 Stichting Mathematisch Centrum.  Tutti i diritti riservati.

Consulta il file `LICENSE <https://github.com/python/cpython/blob/main/LICENSE>`_ per
informazioni sulla storia di questo software, termini e condizioni d'uso, e una
ESCLUSIONE DI TUTTE LE GARANZIE.

Questa distribuzione di Python *non* contiene codice sotto GNU General Public License (GPL),
quindi può essere utilizzata in progetti proprietari.  Esistono interfacce ad alcuni codici GNU,
ma sono completamente opzionali.

Tutti i marchi citati nel presente documento sono di proprietà dei rispettivi titolari.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---