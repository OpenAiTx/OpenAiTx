    Copyright (C) 2013-2018 Christian Thomas Jacobs.

    Este archivo es parte de PyQSO.

    PyQSO es software libre: puede redistribuirlo y/o modificarlo
    bajo los términos de la Licencia Pública General GNU tal como la publica
    la Free Software Foundation, ya sea la versión 3 de la Licencia, o
    (a su elección) cualquier versión posterior.

    PyQSO se distribuye con la esperanza de que sea útil,
    pero SIN NINGUNA GARANTÍA; ni siquiera la garantía implícita de
    COMERCIABILIDAD o IDONEIDAD PARA UN PROPÓSITO PARTICULAR. Vea la
    Licencia Pública General GNU para más detalles.

    Usted debería haber recibido una copia de la Licencia Pública General GNU
    junto con PyQSO. Si no, vea <http://www.gnu.org/licenses/>.

# PyQSO

PyQSO es una herramienta de registro de contactos para operadores de radioafición.

[![Estado de la documentación](https://readthedocs.org/projects/pyqso/badge/?version=latest)](https://readthedocs.org/projects/pyqso/?badge=latest)

## Dependencias

Como su nombre indica, PyQSO está escrito principalmente en el lenguaje de programación [Python](https://www.python.org/) (versión 3.x). La interfaz gráfica de usuario ha sido desarrollada usando la [biblioteca GTK+](https://www.gtk.org/) a través de los enlaces [PyGObject](https://pygobject.readthedocs.io). Por lo tanto, para ejecutar PyQSO, el intérprete de Python debe estar presente en su sistema junto con soporte para GTK+. En muchos sistemas basados en Linux esto se puede lograr instalando los siguientes paquetes Debian:

* python3
* gir1.2-gtk-3.0
* python3-gi-cairo

Varios paquetes adicionales son necesarios para habilitar la funcionalidad completa de PyQSO. Muchos de estos (especificados en el archivo `requirements.txt`) pueden instalarse fácilmente a nivel del sistema usando el gestor de paquetes de Python mediante el siguiente comando en la terminal:

    sudo pip3 install -U -r requirements.txt

pero la lista completa se indica a continuación:

* python3-matplotlib (versión 1.3.0 o posterior)
* python3-numpy
* libxcb-render0-dev
* [cartopy](http://scitools.org.uk/cartopy/), para dibujar el mapa mundial. Este paquete a su vez depende de python3-scipy, python3-cairocffi, cython, libproj-dev (versión 4.9.0 o posterior) y libgeos-dev (versión 3.3.3 o posterior).
* [geocoder](https://pypi.python.org/pypi/geocoder), para búsquedas QTH.
* python3-sphinx, para construir la documentación.
* python3-hamlib, para soporte de Hamlib.

### Soporte de Hamlib

Actualmente no existe un paquete Debian compatible con Python 3 para [Hamlib](http://www.hamlib.org). Esta biblioteca debe compilarse manualmente para habilitar el soporte de Hamlib. Según las instrucciones en la [lista de correo de Hamlib](https://sourceforge.net/p/hamlib/mailman/message/35692744/), ejecute los siguientes comandos en el directorio raíz de Hamlib (es posible que necesite ejecutar `sudo apt-get install build-essential autoconf automake libtool` antes):

    export PYTHON=/usr/bin/python3
    autoreconf --install
    ./configure --with-python-binding
    make
    sudo make install

También necesitará añadir los directorios `bindings` y `bindings/.libs` de Hamlib al `PYTHONPATH`:

    export PYTHONPATH=$PYTHONPATH:/path/to/hamlib/bindings:/path/to/hamlib/bindings/.libs

## Instalación y ejecución

Asumiendo que el directorio de trabajo actual es el directorio base de PyQSO (el directorio donde está el `Makefile`), PyQSO puede ejecutarse sin instalación emitiendo el siguiente comando en la terminal:

    python3 bin/pyqso

Si el gestor de paquetes de Python `pip3` está disponible en su sistema, PyQSO puede instalarse a nivel del sistema usando:

    sudo make install

Una vez instalado, el siguiente comando ejecutará PyQSO:

    pyqso

## Documentación

La guía sobre cómo usar PyQSO está disponible en [Read the Docs](http://pyqso.readthedocs.io/) y en el screencast a continuación.

[![PyQSO: Una herramienta de registro para operadores de radioaficionados](https://img.youtube.com/vi/sVdZl9KnDsk/0.jpg)](https://www.youtube.com/watch?v=sVdZl9KnDsk)

La documentación también puede construirse localmente con el siguiente comando:

    make docs

lo que producirá una versión HTML de la documentación en `docs/build/html` que se puede abrir en un navegador web.

## Contacto

Por favor, plantee cualquier problema técnico o sugerencia de características sobre PyQSO en el rastreador de problemas de GitHub.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-13

---