# BPCells

BPCells es un paquete para el análisis de alto rendimiento de células individuales en grandes conjuntos de datos de RNA-seq y ATAC-seq.  
Puede ejecutar la normalización y PCA de un conjunto de datos de 1.3M de células en 4 minutos con 2GB de RAM, o crear matrices de picos scATAC-seq a partir de coordenadas de fragmentos con 50 veces menos tiempo de CPU que ArchR o SnapATAC2.  
BPCells puede incluso manejar el conjunto de datos completo del censo humano CELLxGENE, ejecutando PCA de precisión completa en una matriz de 44M de células x 60k genes en 6 horas en una laptop o <1 hora en un servidor. Vea nuestra [página de benchmarks](https://bnprks.github.io/BPCells/articles/web-only/benchmarks.html) para más detalles.

BPCells ofrece:

  - Almacenamiento eficiente de conjuntos de datos de células individuales mediante compresión por bitpacking  
  - Procesamiento rápido de datos RNA-seq y ATAC-seq respaldado en disco impulsado por C++  
  - Análisis posterior como genes marcadores y agrupamiento  
  - Interoperabilidad con AnnData, conjuntos de datos 10x, matrices dispersas R y GRanges  
  - Escalabilidad demostrada hasta 44M de células en una laptop  

Adicionalmente, BPCells expone su infraestructura optimizada de procesamiento de datos para su uso en la escalabilidad de herramientas de células individuales de terceros (p. ej. Seurat)

## [Aprende más en nuestro sitio web](https://bnprks.github.io/BPCells/)

- [Preprint en BioRxiv](https://www.biorxiv.org/content/10.1101/2025.03.27.645853v1)  
- [Documentación de Python](https://bnprks.github.io/BPCells/python/index.html)  
- [Benchmarks](https://bnprks.github.io/BPCells/articles/web-only/benchmarks.html)  
- [Ejemplo de análisis multiómico](https://bnprks.github.io/BPCells/articles/pbmc3k.html)  
- [Cómo funciona BPCells](https://bnprks.github.io/BPCells/articles/web-only/how-it-works.html)  
- [Artículos adicionales](https://bnprks.github.io/BPCells/articles/index.html)  
- [Documentación de funciones](https://bnprks.github.io/BPCells/reference/index.html)  
- [Noticias](https://bnprks.github.io/BPCells/news/index.html)  

## Instalación en R  
Recomendamos instalar BPCells directamente desde github:

```R
remotes::install_github("bnprks/BPCells/r")
```
Antes de instalar, debe tener la biblioteca HDF5 instalada y accesible en su sistema.  
HDF5 se puede instalar desde el gestor de paquetes de su elección. Consulte las instrucciones específicas del sistema operativo a continuación.  

Para usuarios de Mac y Windows que tengan problemas para instalar desde github, consulte nuestra página de [R-universe](https://bnprks.r-universe.dev/BPCells) para obtener instrucciones sobre cómo instalar paquetes binarios precompilados. Estos paquetes binarios rastrean automáticamente la última rama principal de github.  

BPCells está disponible a través de conda gracias a [@mfansler](https://github.com/mfansler) del equipo Conda Forge R (vea [issue #241](https://github.com/bnprks/BPCells/issues/241) para más detalles).  
Cualquier problema con el paquete bioconda debe reportarse en [bioconda-recipes](https://github.com/bioconda/bioconda-recipes/). Las actualizaciones de versiones son gestionadas por el equipo bioconda.  

<details>  
<summary>Haga clic aquí para obtener información específica del sistema operativo para instalaciones basadas en github</summary>  
<div>  

### Linux  
Obtener la dependencia HDF5 suele ser bastante sencillo en Linux  

- apt: `sudo apt-get install libhdf5-dev`  
- yum: `sudo yum install hdf5-devel`  
- conda: `conda install -c conda-forge hdf5`  
  - Nota: Los usuarios de Linux deberían preferir el gestor de paquetes de su distribución (por ejemplo, `apt` o `yum`) cuando sea posible,  
    ya que parece ofrecer una experiencia de instalación un poco más fiable.  

### Windows  
Compilar paquetes R desde la fuente en Windows requiere instalar [R tools para Windows](https://cran.r-project.org/bin/windows/Rtools/). Consulte [Issue #9](https://github.com/bnprks/BPCells/issues/9) para más discusión.  

### MacOS  
Para MacOS, instalar HDF5 mediante homebrew parece ser lo más fiable: `brew install hdf5`.  

**Solución de problemas específica para Mac**:  

- **Macs con CPU ARM**: un error común es tener una instalación HDF5 basada en ARM pero una instalación R basada en x86. Esto causará errores cuando BPCells intente acceder a HDF5 durante la instalación.  
    - Verifique su instalación de R  
  ejecutando `sessionInfo()` y observe si lista ARM o x86 bajo "Platform".  
    - La opción más sencilla es usar  
  R ARM porque homebrew por defecto instalará una versión ARM de hdf5  
    - Es [posible](https://codetinkering.com/switch-homebrew-arm-x86/) (aunque complicado) instalar una copia x86 de homebrew para acceder a una versión x86 de hdf5  
- **Macs antiguos (10.14 Mojave o anteriores)**: el compilador por defecto en Macs antiguos no soporta las características necesarias de filesystem de C++17. Consulte [issue #3](https://github.com/bnprks/BPCells/issues/3#issuecomment-1375238635) para




  consejos para configurar un compilador más reciente mediante homebrew.

### Compiladores compatibles
En la mayoría de los casos, ya tendrá un compilador apropiado. BPCells recomienda
gcc >=9.1, o clang >= 9.0. 
Esto corresponde a versiones desde finales de 2018 y posteriores. 
Las versiones más antiguas pueden funcionar en algunos casos siempre que
tengan soporte básico para C++17, pero no están oficialmente soportadas.

</div>
</details>
<details>
<summary>Haga clic aquí para información de solución de problemas para instalaciones basadas en github</summary>

### Solución general de problemas de instalación
BPCells intenta mostrar mensajes de error informativos durante la compilación para ayudar a diagnosticar el problema. Para un conjunto más
detallado de información, ejecute `Sys.setenv(BPCELLS_DEBUG_INSTALL="true")` antes de `remotes::install_github("bnprks/BPCells/r")`. Si aún no puede resolver el problema con esa información adicional, no dude en abrir un issue en Github, asegurándose de usar una [sección plegable](https://docs.github.com/en/get-started/writing-on-github/working-with-advanced-formatting/organizing-information-with-collapsed-sections) para el registro detallado de la instalación.

</details>

## Instalación de Python

BPCells se puede instalar directamente vía pip:


```shell
python -m pip install bpcells
```

## Contribuyendo
BPCells es un proyecto de código abierto, y damos la bienvenida a contribuciones de calidad. Si
estás interesado en contribuir y tienes experiencia con C++, junto con Python
o R, no dudes en contactarnos con ideas que te gustaría implementar tú mismo.
Estamos felices de ofrecer orientaciones sobre cómo comenzar, si el tiempo lo permite.

Si no estás familiarizado con C++ te será difícil contribuir con código,
pero los informes detallados de errores con
[ejemplos reproducibles](https://reprex.tidyverse.org/articles/reprex-dos-and-donts.html)
siguen siendo una excelente forma de ayudar. Los issues de Github son el mejor foro para esto.

Si mantienes un paquete de análisis de células individuales y quieres usar BPCells para
mejorar tu escalabilidad, estamos felices de ofrecer asesoría. Hasta ahora hemos tenido un par de laboratorios
que lo han intentado, con éxito prometedor. El correo electrónico es la mejor manera de ponerse en contacto
para esto (mira en el archivo `DESCRIPTION` en github para información de contacto). Los desarrolladores de Python
son bienvenidos, aunque el paquete de python actual aún está en estado experimental.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-25

---