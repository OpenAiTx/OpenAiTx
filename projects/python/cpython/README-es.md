Esta es la versión 3.15.0 alpha 0 de Python
===========================================

.. image:: https://github.com/python/cpython/actions/workflows/build.yml/badge.svg?branch=main&event=push
   :alt: Estado de compilación de CPython en GitHub Actions
   :target: https://github.com/python/cpython/actions

.. image:: https://dev.azure.com/python/cpython/_apis/build/status/Azure%20Pipelines%20CI?branchName=main
   :alt: Estado de compilación de CPython en Azure DevOps
   :target: https://dev.azure.com/python/cpython/_build/latest?definitionId=4&branchName=main

.. image:: https://img.shields.io/badge/discourse-join_chat-brightgreen.svg
   :alt: Chat de Discourse de Python
   :target: https://discuss.python.org/


Copyright © 2001 Python Software Foundation.  Todos los derechos reservados.

Consulte el final de este archivo para obtener más información sobre los derechos de autor y la licencia.

.. contents::

Información general
-------------------

- Sitio web: https://www.python.org
- Código fuente: https://github.com/python/cpython
- Seguimiento de incidencias: https://github.com/python/cpython/issues
- Documentación: https://docs.python.org
- Guía del desarrollador: https://devguide.python.org/

Contribuir a CPython
-----------------------

Para obtener instrucciones más completas sobre cómo contribuir al desarrollo de CPython,
consulte la `Guía del Desarrollador`_.

.. _Guía del Desarrollador: https://devguide.python.org/

Uso de Python
-------------

Kits instalables de Python e información sobre el uso de Python están disponibles en
`python.org`_.

.. _python.org: https://www.python.org/

Instrucciones de compilación
----------------------------

En Unix, Linux, BSD, macOS y Cygwin::

    ./configure
    make
    make test
    sudo make install

Esto instalará Python como ``python3``.

Puede pasar muchas opciones al script configure; ejecute ``./configure --help``
para saber más. En sistemas de archivos insensibles a mayúsculas/minúsculas en macOS y en Cygwin,
el ejecutable se llama ``python.exe``; en otros lugares es simplemente ``python``.

La construcción de una instalación completa de Python requiere el uso de varias
bibliotecas adicionales de terceros, dependiendo de su plataforma de compilación y
opciones de configuración. No todos los módulos de la biblioteca estándar se pueden compilar o
utilizar en todas las plataformas. Consulte la sección
`Instalar dependencias <https://devguide.python.org/getting-started/setup-building.html#build-dependencies>`_
de la `Guía del Desarrollador`_ para obtener información detallada y actualizada sobre
las dependencias para varias distribuciones de Linux y macOS.

En macOS, existen opciones adicionales de configuración y compilación relacionadas
con el framework de macOS y compilaciones universales. Consulte `Mac/README.rst
<https://github.com/python/cpython/blob/main/Mac/README.rst>`_.

En Windows, consulte `PCbuild/readme.txt
<https://github.com/python/cpython/blob/main/PCbuild/readme.txt>`_.

Para compilar el instalador de Windows, consulte `Tools/msi/README.txt
<https://github.com/python/cpython/blob/main/Tools/msi/README.txt>`_.

Si lo desea, puede crear un subdirectorio e invocar configure desde allí.
Por ejemplo::

    mkdir debug
    cd debug
    ../configure --with-pydebug
    make
    make test

(Esto fallará si *también* ha compilado en el directorio de nivel superior. Debe ejecutar
un ``make clean`` en el nivel superior primero.)

Para obtener una compilación optimizada de Python, ejecute ``configure --enable-optimizations``
antes de ejecutar ``make``. Esto configura los objetivos de make predeterminados para habilitar
la Optimización Guiada por Perfil (PGO) y puede usarse para habilitar automáticamente la Optimización
en Tiempo de Enlace (LTO) en algunas plataformas. Para más detalles, consulte las secciones
a continuación.

Optimización Guiada por Perfil (PGO)
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

PGO aprovecha las versiones recientes de los compiladores GCC o Clang. Si se utiliza,
ya sea mediante ``configure --enable-optimizations`` o ejecutando manualmente
``make profile-opt`` independientemente de los flags de configure, el proceso de compilación optimizada
realizará los siguientes pasos:

Todo el directorio de Python se limpia de archivos temporales que puedan haber
resultado de una compilación anterior.

Se construye una versión instrumentada del intérprete, utilizando los flags de compilador apropiados para cada sabor. Tenga en cuenta que este es solo un paso intermedio. El
binario resultante de este paso no es apto para cargas de trabajo reales ya que contiene
instrucciones de perfilado embebidas.

Después de construir el intérprete instrumentado, el Makefile ejecutará una carga de trabajo de entrenamiento.
Esto es necesario para perfilar la ejecución del intérprete. Tenga en cuenta que cualquier salida,
tanto stdout como stderr, que pueda aparecer en este paso
se suprime.

El paso final es construir el intérprete real, utilizando la información
recopilada del instrumentado. El resultado final será un binario de Python
optimizado, adecuado para distribución o instalación en producción.


Optimización en Tiempo de Enlace (LTO)
^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

Se habilita mediante el flag ``--with-lto`` de configure. LTO aprovecha la
capacidad de los toolchains de compiladores recientes para optimizar a través de los límites
arbitrarios de archivos ``.o`` al construir ejecutables finales o bibliotecas compartidas
para obtener mejoras adicionales de rendimiento.


Novedades
----------

Disponemos de una visión general completa de los cambios en el documento `Novedades en Python
3.15 <https://docs.python.org/3.15/whatsnew/3.15.html>`_. Para un registro
de cambios más detallado, lea `Misc/NEWS
<https://github.com/python/cpython/tree/main/Misc/NEWS.d>`_, pero el recuento
completo de cambios solo puede obtenerse del `historial de commits
<https://github.com/python/cpython/commits/main>`_.

Si desea instalar varias versiones de Python, consulte la sección siguiente
titulada "Instalar varias versiones".


Documentación
-------------

La `Documentación de Python 3.15 <https://docs.python.org/3.15/>`_ está disponible en línea,
y se actualiza diariamente.

También puede descargarse en muchos formatos para un acceso más rápido. La documentación
se puede descargar en formatos HTML, PDF y reStructuredText; esta última versión
es principalmente para autores de documentación, traductores y personas con requisitos
especiales de formato.

Para obtener información sobre cómo compilar la documentación de Python, consulte `Doc/README.rst
<https://github.com/python/cpython/blob/main/Doc/README.rst>`_.


Pruebas
-------

Para probar el intérprete, escriba ``make test`` en el directorio de nivel superior. El
conjunto de pruebas produce alguna salida. Generalmente puede ignorar los mensajes sobre
pruebas omitidas debido a características opcionales que no se pueden importar. Si se imprime un mensaje
sobre una prueba fallida, un traceback o se produce un core dump,
algo está mal.

Por defecto, se evita que las pruebas hagan un uso excesivo de recursos como espacio en disco y
memoria. Para habilitar estas pruebas, ejecute ``make buildbottest``.

Si alguna prueba falla, puede volver a ejecutar la(s) prueba(s) fallida(s) en modo detallado (verbose).
Por ejemplo, si fallaron ``test_os`` y ``test_gdb``, puede ejecutar::

    make test TESTOPTS="-v test_os test_gdb"

Si la falla persiste y parece ser un problema de Python en lugar de su entorno,
puede `reportar un error
<https://github.com/python/cpython/issues>`_ e incluir la salida relevante de
ese comando para mostrar el problema.

Consulte `Ejecución y escritura de pruebas <https://devguide.python.org/testing/run-write-tests.html>`_
para más información sobre cómo ejecutar pruebas.

Instalar varias versiones
----------------------------

En sistemas Unix y Mac, si tiene la intención de instalar varias versiones de Python
utilizando el mismo prefijo de instalación (argumento ``--prefix`` del script configure)
debe tener cuidado de que su ejecutable principal de python no sea
sobrescrito por la instalación de una versión diferente. Todos los archivos y
directorios instalados usando ``make altinstall`` contienen la versión mayor y menor y por lo tanto pueden coexistir. ``make install`` también crea
``${prefix}/bin/python3`` que hace referencia a ``${prefix}/bin/python3.X``. Si
tiene la intención de instalar varias versiones usando el mismo prefijo debe decidir qué
versión (si alguna) será su versión "principal". Instale esa versión usando
``make install``. Instale todas las demás versiones usando ``make altinstall``.

Por ejemplo, si desea instalar Python 2.7, 3.6 y 3.15 siendo 3.15 la versión principal, debe ejecutar ``make install`` en el directorio de compilación de 3.15 y ``make altinstall`` en los otros.


Calendario de Lanzamiento
-------------------------

Consulte `PEP 790 <https://peps.python.org/pep-0790/>`__ para los detalles del lanzamiento de Python 3.15.


Información de Derechos de Autor y Licencia
-------------------------------------------


Copyright © 2001 Python Software Foundation. Todos los derechos reservados.

Copyright © 2000 BeOpen.com. Todos los derechos reservados.

Copyright © 1995-2001 Corporation for National Research Initiatives. Todos los derechos reservados.

Copyright © 1991-1995 Stichting Mathematisch Centrum. Todos los derechos reservados.

Consulte la `LICENSE <https://github.com/python/cpython/blob/main/LICENSE>`_ para obtener información sobre la historia de este software, términos y condiciones de uso, y una
EXENCIÓN DE TODAS LAS GARANTÍAS.

Esta distribución de Python *no* contiene código de la Licencia Pública General de GNU (GPL), por lo que puede ser utilizada en proyectos propietarios. Existen interfaces para algún código GNU, pero estas son completamente opcionales.

Todas las marcas comerciales mencionadas aquí son propiedad de sus respectivos titulares.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---