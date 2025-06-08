# Mamba: El gestor de paquetes multiplataforma rápido

![imagen de cabecera de mamba](https://raw.githubusercontent.com/mamba-org/mamba/main/docs/assets/mamba_header.png)

<!-- markdownlint-disable-file MD033 -->

<table>
<thead align="center" cellspacing="10">
  <tr>
    <th colspan="3" align="center" border="">parte de mamba-org</th>
  </tr>
</thead>
<tbody>
  <tr background="#FFF">
    <td align="center">Gestor de Paquetes <a href="https://github.com/mamba-org/mamba">mamba</a></td>
    <td align="center">Servidor de Paquetes <a href="https://github.com/mamba-org/quetz">quetz</a></td>
  </tr>
</tbody>
</table>

## mamba

[![Build Status](https://github.com/mamba-org/mamba/actions/workflows/tests.yml/badge.svg)](https://github.com/mamba-org/mamba/actions/workflows/tests.yml?query=branch%3Amain)
[![Únete al Chat de Gitter](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/mamba-org/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![docs](https://readthedocs.org/projects/mamba/badge/?version=latest&style=flat)](https://mamba.readthedocs.io/en/latest)
[![Gurubase](https://img.shields.io/badge/Gurubase-Ask%20mamba%20Guru-006BFF)](https://gurubase.io/g/mamba)

`mamba` es una reimplementación del gestor de paquetes conda en C++.

- descarga en paralelo de datos de repositorios y archivos de paquetes usando multi-hilo
- libsolv para una resolución de dependencias mucho más rápida, una biblioteca de última generación utilizada en el gestor de paquetes RPM de Red Hat, Fedora y OpenSUSE
- las partes centrales de `mamba` están implementadas en C++ para máxima eficiencia

Al mismo tiempo, `mamba` utiliza el mismo analizador de línea de comandos, el código de instalación y desinstalación de paquetes y las rutinas de verificación de transacciones que `conda` para mantener la máxima compatibilidad posible.

`mamba` forma parte del ecosistema [conda-forge](https://conda-forge.org/), que también incluye `quetz`, un servidor de paquetes `conda` de código abierto.

Puedes leer nuestro [anuncio en el blog](https://medium.com/@QuantStack/open-software-packaging-for-science-61cecee7fc23).

## micromamba

`micromamba` es la versión enlazada estáticamente de `mamba`.

Puede instalarse como un ejecutable independiente sin dependencias, lo que lo convierte en una opción perfecta para pipelines CI/CD y entornos contenerizados.

Consulta la [documentación sobre `micromamba`](https://mamba.readthedocs.io/en/latest/user_guide/micromamba.html) para más detalles.

## `mamba` vs. `micromamba`

Debe preferirse `mamba` cuando:

- `libmambapy` o `libmamba` es utilizada por otro software en el mismo entorno.
- Escenarios donde se requieren actualizaciones regulares de las bibliotecas (especialmente por razones de seguridad).
- Los entornos están enfocados en reducir el espacio en disco utilizado por las dependencias.

Debe preferirse `micromamba` cuando:

- Se requiere confiar en un solo ejecutable autocontenido.
- No está presente una distribución miniforge.
- El uso requiere un tiempo de ejecución mínimo.

## Instalación

Por favor, consulta la guía de instalación de [mamba](https://mamba.readthedocs.io/en/latest/installation/mamba-installation.html)
y [micromamba](https://mamba.readthedocs.io/en/latest/installation/micromamba-installation.html) en la documentación.

## Características adicionales en Mamba y Micromamba

`mamba` y `micromamba` incluyen características adicionales respecto a `conda` estándar.

### `repoquery`

Para consultar eficientemente los repositorios y dependencias de paquetes puedes usar `mamba repoquery` o `micromamba repoquery`.

Consulta la [documentación de repoquery](https://mamba.readthedocs.io/en/latest/user_guide/mamba.html#repoquery) para más detalles.

### Instalación de archivos de bloqueo

`micromamba` puede usarse para instalar archivos de bloqueo generados por [conda-lock](https://conda.github.io/conda-lock/) sin necesidad de instalar `conda-lock`.

Simplemente ejecuta `micromamba create` con la opción `-f`, proporcionando un archivo de bloqueo de entorno cuyo nombre termine en
`-lock.yml` o `-lock.yaml`; por ejemplo:

```bash
micromamba create -n my-env -f conda-lock.yml
```

### setup-micromamba (reemplazo de setup-miniconda)

[setup-micromamba](https://github.com/marketplace/actions/setup-micromamba) es un reemplazo de [setup-miniconda](https://github.com/marketplace/actions/setup-miniconda) que utiliza `micromamba`.

Puede reducir significativamente el tiempo de configuración en tu CI al:

- Usar `micromamba`, que tarda alrededor de 1 s en instalarse.
- Cachear las descargas de paquetes.
- Cachear entornos completos de `conda`.

## Diferencias con `conda`

Aunque `mamba` y `micromamba` son en general reemplazos directos de `conda`, existen algunas diferencias:

- `mamba` y `micromamba` no soportan revisiones (para discusiones, ver <https://github.com/mamba-org/mamba/issues/803>)
- `mamba` y `micromamba` normalizan las cadenas `MatchSpec` a la forma más simple, mientras que `conda` utiliza una forma más detallada.
  Esto puede llevar a ligeras diferencias en la salida de `conda env export` y `mamba env export`.

## Instalación para desarrollo

Por favor, consulta las instrucciones dadas en la [documentación oficial](https://mamba.readthedocs.io/en/latest/developer_zone/dev_environment.html).

## Estabilidad de API y ABI

El proyecto Mamba utiliza [versionado semántico](https://semver.org/) de la forma `MAJOR.MINOR.PATCH`.
Aunque intentamos mantener la estabilidad para los usuarios, también necesitamos hacer cambios incompatibles para mejorar
Mamba y reducir la deuda técnica.
Las versiones futuras de Mamba pueden ofrecer garantías más estrictas.

### `libmamba` (C++)

No tenemos conocimiento de consumidores de la API de C++, por lo que nos damos espacio para mejoras.
Para `libmamba`, el término _compatible hacia atrás_ se entiende de la siguiente manera:

- _ABI compatible hacia atrás_ significa que puedes reemplazar los archivos binarios de la biblioteca sin recompilar
  tu código con los encabezados actualizados.
  El comportamiento observado será el mismo, excepto por errores (que esperamos desaparezcan) y el rendimiento.
- _API compatible hacia atrás_ significa que debes recompilar tu código con la nueva versión de la biblioteca,
  pero no necesitas cambiar tu código, solo reconstruirlo.
  Esto aplica siempre que no hayas usado ninguna declaración considerada privada, por ejemplo
  en los subespacios de nombres `detail`.
  El comportamiento observado será el mismo, excepto por errores (que esperamos desaparezcan) y el rendimiento.
  Cuando las declaraciones están obsoletas pero no eliminadas y siguen siendo funcionales, también lo consideramos
  compatible hacia atrás, ya que solo cambia el comportamiento observado durante la compilación.

Teniendo esto en cuenta, `libmamba` ofrece las siguientes garantías:

- Las versiones `PATCH` son compatibles hacia atrás en API y ABI;
- Las versiones `MINOR` son compatibles en API para las declaraciones en `mamba/api`,
  pueden romper la API en otros lugares y la ABI en cualquier parte;
- Las versiones `MAJOR` no ofrecen garantías.

### `libmambapy` (Python)

Para `libmambapy`, el término _compatible hacia atrás en API_ implica que tu código Python funcionará
igual en una versión más reciente de `libmambapy` siempre que no hayas utilizado ninguna declaración considerada
privada, por ejemplo, accedida con un nombre que comienza con un `_`.
El comportamiento observado será el mismo, excepto por errores (que esperamos desaparezcan) y el rendimiento.
Cuando las declaraciones están obsoletas pero no eliminadas y siguen siendo funcionales, también lo consideramos
compatible hacia atrás, ya que el comportamiento solo es observable al activar el `DeprecationWarning`
de Python, que normalmente solo se activa en desarrollo.

Teniendo esto en cuenta, `libmambapy` ofrece las siguientes garantías:

- Las versiones `PATCH` son compatibles hacia atrás en API;
- Las versiones `MINOR` son compatibles hacia atrás en API;
- Las versiones `MAJOR` no ofrecen garantías.

### `mamba` y `micromamba` (ejecutables)

Para los ejecutables, el término _compatible hacia atrás_ aplica a las entradas y salidas programables y significa
que tu código (incluyendo scripts de shell) funcionará con versiones más recientes del ejecutable sin
modificaciones.
Las entradas/salidas programables incluyen el nombre del ejecutable, argumentos de línea de comandos, archivos de configuración,
variables de entorno, salidas JSON en línea de comandos y archivos creados.
Se _excluyen_ las salidas legibles por humanos y los mensajes de error, y por tanto las advertencias de obsolescencia escritas
en la salida legible por humanos.

Teniendo esto en cuenta, `mamba` y `micromamba` ofrecen las siguientes garantías:

- Las versiones `PATCH` son compatibles hacia atrás;
- Las versiones `MINOR` son compatibles hacia atrás;
- Las versiones `MAJOR` no ofrecen garantías.

## Apóyanos

Solo `mamba` y `micromamba` 2.0 y posteriores son soportados y están en desarrollo activo.

La rama `1.x` solo se mantiene para abordar problemas de seguridad como CVEs.

Para preguntas, también puedes unirte a nosotros en el [Chat de QuantStack](https://gitter.im/QuantStack/Lobby)
o en el [canal de Conda](https://gitter.im/conda/conda) (ten en cuenta que este proyecto no está oficialmente afiliado a `conda` ni a Anaconda Inc.).

## Licencia

Usamos un modelo de derechos de autor compartido que permite a todos los contribuyentes mantener el copyright
sobre sus contribuciones.

Este software está licenciado bajo la licencia BSD-3-Clause. Consulta el archivo [LICENSE](https://raw.githubusercontent.com/mamba-org/mamba/main/LICENSE) para más detalles.

---

### Reunión de desarrollo quincenal

Tenemos reuniones por videoconferencia cada dos semanas donde discutimos en qué hemos estado trabajando y recibimos retroalimentación entre nosotros.

Cualquiera es bienvenido a asistir, si desea discutir un tema o simplemente escuchar.

- Cuándo: Martes [4:00 PM CET (Europa)](https://calendar.google.com/calendar/u/0/embed?src=ab3jrfpede0kq0ubsroe82cd00@group.calendar.google.com&ctz=Europe/Paris)
- Dónde: [Mamba jitsi](https://meet.jit.si/mamba-org)
- Qué: [Notas de la reunión](https://hackmd.io/@guj2k_aBSSyr1YHBG9raWw/HyHt-Ekzj)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---