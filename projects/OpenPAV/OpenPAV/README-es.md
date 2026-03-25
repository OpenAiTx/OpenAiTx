# Open-PAV

OpenPAV (Vehículo Automatizado de Producción Abierto) es una plataforma abierta diseñada para facilitar la **recolección de datos, modelado de comportamiento y evaluación de desempeño** de vehículos automatizados de producción (PAV). Integra diversos conjuntos de datos y modelos de vehículos calibrados, convirtiéndola en una herramienta esencial para investigadores y desarrolladores que buscan estudiar la dinámica de los PAV y sus impactos. El proyecto fomenta contribuciones de la comunidad investigadora y proporciona parámetros de modelos listos para usar para una integración fluida con herramientas de simulación. Consulta el [Sitio Web de OpenPAV](https://openpav.github.io/OpenPAV) para más detalles.

![Framework](https://raw.githubusercontent.com/OpenPAV/OpenPAV/main/./docs/images/Framework.png)

## Fuentes de Datos y Colaboradores

### Fuentes de Datos Originales:

Actualmente el conjunto de datos ha examinado 14 conjuntos de datos de código abierto de 7 proveedores, cada uno proporcionando perspectivas distintas sobre el comportamiento de AV en diversas condiciones y escenarios de conducción. Son:

- **Conjunto de Datos Argoverse 2 de Predicción de Movimiento**. Recopilado en Austin, Texas; Detroit, Michigan; Miami, Florida; Pittsburgh, Pennsylvania; Palo Alto, California; y Washington, D.C. por Argo AI con investigadores de la Universidad Carnegie Mellon y el Instituto de Tecnología de Georgia. Disponible en -  [Conjunto de Datos Argoverse 2 de Predicción de Movimiento](https://www.argoverse.org/av2.html).
- **Conjuntos de Datos Abiertos de CATS**. Tres conjuntos de datos fueron recopilados en Tampa, Florida, y Madison, Wisconsin por el Laboratorio CATS. Disponible en - [Laboratorio CATS](https://github.com/CATS-Lab).
- **Conjuntos de Datos ACC del Centro de Ohio**. Dos conjuntos de datos fueron recopilados en Ohio por el Laboratorio de Movilidad de UCLA y el Centro de Investigación en Transporte. Disponible en - [Datos de Vehículo Único Equipado con Sistema Avanzado de Asistencia al Conductor (ADAS) para el Centro de Ohio](https://catalog.data.gov/dataset/advanced-driver-assistance-system-adas-equipped-single-vehicle-data-for-central-ohio).
- **Conjunto de Datos MircoSimACC**. Recopilado en cuatro ciudades de Florida, incluyendo Delray Beach, Loxahatchee, Boca Ratón y Parkland por el grupo de investigación de la Universidad Atlántica de Florida. Disponible en  - [microSIM-ACC](https://github.com/microSIM-ACC).
- **Base de Datos OpenACC**. Cuatro conjuntos de datos fueron recopilados en Italia, Suecia y Hungría por el Centro Común de Investigación de la Comisión Europea. Disponible en - [data.europa.eu](https://data.europa.eu/data/datasets/9702c950-c80f-4d2f-982f-44d06ea0009f?locale=en).
- **Conjunto de Datos ACC de Vanderbilt**. Recopilado en Nashville, Tennessee por el grupo de investigación de la Universidad de Vanderbilt. Disponible en - [Conjunto de Datos de Control de Crucero Adaptativo](https://acc-dataset.github.io/).
- **Conjunto de Datos Abierto de Waymo**. Dos conjuntos de datos fueron recopilados en seis ciudades incluyendo San Francisco, Mountain View y Los Ángeles en California, Phoenix en Arizona, Detroit en Michigan y Seattle en Washington por Waymo. Disponible en - [Conjunto de Datos de Movimiento de Waymo](https://waymo.com/open/data/motion/) y [Datos de trayectoria vehicular procesados del Conjunto de Datos Abierto de Waymo](https://data.mendeley.com/datasets/wfn2c3437n/2).

<img src="https://raw.githubusercontent.com/OpenPAV/OpenPAV/main/./docs/images/Dataset.png" alt="Major Components" width="600">

### Fuente de Datos Procesados:

Organizando los datos de los conjuntos anteriores, procesamos un conjunto unificado de trayectorias ULTra-AV, en el cual todos los datos están representados usando un formato estandarizado. Disponible en -  [Un conjunto de datos unificado de trayectorias longitudinales para vehículos automatizados](https://www.nature.com/articles/s41597-024-03795-y) y [ULTra-AV](https://github.com/CATS-Lab/Filed-Experiment-Data-ULTra-AV).

## Novedades

- **Marzo 2026:** El proyecto ha lanzado una nueva interfaz.
- **Noviembre 2024:** Inicio inicial del proyecto con guías de instalación y uso.

## Componentes Principales

Open-PAV consta de los siguientes componentes:

- **Procesamiento de Datos:** Dado el dato bruto de AV (LiDAR, imágenes, videos, trayectorias) como entrada, este módulo convierte datos del mismo tipo en un formato unificado y realiza una limpieza preliminar de los datos.
- **Modelado de Comportamiento:** Usando los datos procesados de AV, este módulo calibra los modelos cinemáticos del vehículo automatizado y los exporta para uso en simulación. Los usuarios también pueden ingresar directamente su pila de software AV para probar su sistema AV desarrollado dentro de este módulo.
- **Evaluación Acelerada:** Este módulo está diseñado para generar escenarios de conducción críticos para la seguridad específicos para un modelo AV dado, con el objetivo de evaluar su desempeño en seguridad.


## Colaboradores

### Grupos Colaboradores

[CATS Lab](https://catslab.engr.wisc.edu/) (Investigador Principal: [Xiaopeng Li](https://catslab.engr.wisc.edu/staff/xiaopengli/))

[CAT Lab](http://www.connectedandautonomoustransport.com/dr-zhengs-research.html) (Investigador Principal: [Zuduo Zheng](https://civil.uq.edu.au/profile/857/zuduo-zheng))

[SHINE Lab](https://sites.google.com/site/danjuechen/) (Investigador Principal: Danjue Chen)

NextGen-ITS Lab (Investigador Principal: David Kan)

### Colaboradores Técnicos:

- [Hang Zhou](https://catslab.engr.wisc.edu/staff/zhou-hang/), [Ke Ma](https://markmaaaaa.github.io/KeMa.github.io/), Keke Long , Chengyuan Ma.

### Publicaciones Relacionadas:

- Zhou, H., Ma, K., Liang, S., Li, X., y Qu, X. (2024). *Un conjunto de datos unificado de trayectorias longitudinales para vehículos automatizados*. *Scientific Data*, 11, 1123.

### Agradecimientos:

Este proyecto está parcialmente financiado por la National Science Foundation (NSF) a través de "[NSF CPS: Small: NSF-DST: Transformando la “Tragedia de los Comunes (ToC)” en “Comportamiento Cooperativo Emergente (ECB)” para Vehículos Automatizados en Intersecciones con Meta-Aprendizaje](https://www.nsf.gov/awardsearch/show-award?AWD_ID=2343167)" (No. 2343167). También agradecemos el apoyo del [Comité Técnico de Pruebas de Tecnología de Transporte Emergente (ET3) de la IEEE Intelligent Transportation Systems Society (ITSS)](https://ieee-itss.org/chapters-committees/emerging-transportation-technology-testing).

También apreciamos sinceramente a todos los proveedores de datos y colaboradores que hicieron posible este trabajo.

## Licencia

Open-PAV se publica bajo la [Licencia MIT](LICENSE). Consulte el archivo LICENSE para más detalles.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-25

---