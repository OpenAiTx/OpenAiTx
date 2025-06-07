Árbol de integración/staging de Bitcoin Core
============================================

https://bitcoincore.org

Para una versión binaria de Bitcoin Core lista para usar de inmediato, consulte
https://bitcoincore.org/en/download/.

¿Qué es Bitcoin Core?
---------------------

Bitcoin Core se conecta a la red peer-to-peer de Bitcoin para descargar y validar completamente
bloques y transacciones. También incluye una billetera y una interfaz gráfica de usuario, que pueden compilarse opcionalmente.

Hay más información sobre Bitcoin Core en la [carpeta doc](/doc).

Licencia
--------

Bitcoin Core se publica bajo los términos de la licencia MIT. Consulte [COPYING](COPYING) para más
información o visite https://opensource.org/license/MIT.

Proceso de desarrollo
---------------------

La rama `master` se compila regularmente (consulte `doc/build-*.md` para instrucciones) y se prueba, pero no se garantiza que sea
completamente estable. Se crean [etiquetas](https://github.com/bitcoin/bitcoin/tags)
regularmente a partir de ramas de lanzamiento para indicar nuevas versiones oficiales y estables de Bitcoin Core.

El repositorio https://github.com/bitcoin-core/gui se utiliza exclusivamente para el
desarrollo de la GUI. Su rama master es idéntica en todos los repositorios monotree.
No existen ramas de lanzamiento ni etiquetas, así que por favor no haga fork
de ese repositorio a menos que sea por razones de desarrollo.

El flujo de trabajo para las contribuciones está descrito en [CONTRIBUTING.md](CONTRIBUTING.md)
y los consejos útiles para desarrolladores pueden encontrarse en [doc/developer-notes.md](doc/developer-notes.md).

Pruebas
-------

Las pruebas y la revisión de código son el cuello de botella del desarrollo; recibimos más pull
requests de los que podemos revisar y probar en poco tiempo. Por favor, sea paciente y ayude probando
los pull requests de otras personas, y recuerde que este es un proyecto crítico para la seguridad donde cualquier error podría costarles a las personas
mucho dinero.

### Pruebas automatizadas

Se recomienda encarecidamente a los desarrolladores escribir [pruebas unitarias](src/test/README.md) para el código nuevo y
enviar nuevas pruebas unitarias para el código antiguo. Las pruebas unitarias pueden compilarse y ejecutarse
(suponiendo que no se hayan deshabilitado durante la generación del sistema de compilación) con: `ctest`. Puede encontrar más detalles sobre cómo ejecutar
y ampliar las pruebas unitarias en [/src/test/README.md](/src/test/README.md).

También hay [pruebas de regresión e integración](/test), escritas
en Python.
Estas pruebas pueden ejecutarse (si se han instalado las [dependencias de prueba](/test)) con: `build/test/functional/test_runner.py`
(suponiendo que `build` sea su directorio de compilación).

Los sistemas CI (Integración Continua) aseguran que cada pull request se compile para Windows, Linux y macOS,
y que las pruebas unitarias/de verificación se ejecuten automáticamente.

### Pruebas manuales de aseguramiento de calidad (QA)

Los cambios deben ser probados por alguien distinto al desarrollador que escribió el
código. Esto es especialmente importante para cambios grandes o de alto riesgo. Es útil
añadir un plan de pruebas a la descripción del pull request si probar los cambios no es
directo.

Traducciones
------------

Los cambios en las traducciones, así como nuevas traducciones, pueden enviarse a la
[página de Transifex de Bitcoin Core](https://www.transifex.com/bitcoin/bitcoin/).

Las traducciones se extraen periódicamente de Transifex y se integran en el repositorio git. Consulte el
[proceso de traducción](doc/translation_process.md) para más detalles sobre cómo funciona esto.

**Importante**: No aceptamos cambios de traducción como pull requests de GitHub porque la próxima
extracción desde Transifex los sobrescribiría automáticamente.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---