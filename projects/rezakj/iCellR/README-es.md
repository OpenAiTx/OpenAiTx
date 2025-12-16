[![Versión CRAN](https://www.r-pkg.org/badges/version/iCellR)](https://cran.r-project.org/package=iCellR)
[![Descargas CRAN](https://cranlogs.r-pkg.org/badges/iCellR)](https://cran.r-project.org/package=iCellR)
[![Licencia: GPL v2](https://img.shields.io/badge/License-GPL%20v2-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)

# Paquete R para célula única (i) (iCellR)
iCellR es un paquete interactivo de R diseñado para facilitar el análisis y la visualización de datos de secuenciación unicelular de alto rendimiento. Soporta una variedad de tecnologías unicelulares, incluyendo `scRNA-Seq`, `scVDJ-Seq`, `scATAC-Seq`, `CITE-Seq` y `Transcriptómica Espacial` (ST).

Mantenedor: [Alireza Khodadadi-Jamayran](https://scholar.google.com/scholar?q=author:%22Khodadadi-Jamayran%20A%22)

### Noticias (abril 2021)
Use la última versión de iCellR (v1.6.4) para análisis de scATAC-seq y Transcriptómica Espacial (ST). Aproveche la función [i.score](https://github.com/rezakj/iCellR/wiki/i.score) para `puntuar células basándose en firmas génicas` usando métodos como `Tirosh, Media, Suma, GSVA, ssgsea, Zscore y Plage`.

### Noticias (julio 2020)
Explore la versión 1.5.5 de iCellR, ahora con herramientas para análisis del ciclo celular `(fases G0, G1S, G2M, M, G1M y S)`. Vea un ejemplo de [fase](https://genome.med.nyu.edu/results/external/iCellR/example1/All_cellcycle.png), nueva funcionalidad de Pseudotiempo Abstracto KNetL (mapa PAK) añadida – visualice la progresión del pseudotiempo [(mapa PAK)](https://genome.med.nyu.edu/results/external/iCellR/example1/pseudotime.KNetL.png). Realice análisis de correlación gen-gen usando herramientas de visualización actualizadas. [correlaciones](https://genome.med.nyu.edu/results/external/iCellR/example1/gene-gene.correlation.png).

### Noticias (mayo 2020)
Explore el `mapa KNetL`, un método avanzado, ajustable y dinámico de reducción dimensional [mapa KNetL](https://genome.med.nyu.edu/results/external/iCellR/example1/Allclusts.Annotated.png) <img src="https://github.com/rezakj/scSeqR/blob/master/doc/logo.png" alt="drawing" width="30"/> KNetL (pronunciado “nettle”) ofrece capacidades mejoradas de zoom [KNetL](https://www.biorxiv.org/content/10.1101/2020.05.05.078550v1.full) para mostrar muchos más detalles en comparación con tSNE y UMAP.

### Noticias (abril 2020)
Introducción de métodos de `imputación y corrección de cobertura (CC)` para mejorar el análisis de correlación gen-gen. ([CC](https://genome.med.nyu.edu/results/external/iCellR/example1/gene-gene.correlation.png)). Realice `alineación de lotes usando CPCA` y herramientas CCCA de iCellR (CCCA y [CPCA](https://genome.med.nyu.edu/results/external/iCellR/example2/AllCondsClusts.png)) [métodos](https://www.biorxiv.org/content/10.1101/2020.03.31.019109v1.full). Bases de datos ampliadas para predicción de tipos celulares que ahora incluyen ImmGen y MCA.

### Noticias (sep. 2018)
`scSeqR` ha sido renombrado a `iCellR`, y scSeqR ha sido descontinuado. Por favor utilice iCellR en adelante, ya que scSeqR ya no tiene soporte. `UMAP` se añade a iCellR. Se ha incorporado `selección interactiva de células`, permitiendo a los usuarios seleccionar células directamente dentro de gráficos HTML usando Plotly.

### Tutoriales y manual
- Enlace al `manual` [Manual](https://cran.r-project.org/web/packages/iCellR/iCellR.pdf) y al Comprehensive R Archive Network [(CRAN)](https://cran.r-project.org/web/packages/iCellR/index.html).
- Para `empezar` y `tutoriales` visite nuestra [página Wiki](https://github.com/rezakj/iCellR/wiki).
- Enlace a un tutorial en video para análisis CITE-Seq y scRNA-Seq: [Video](https://vimeo.com/337822487)
- Todo lo que necesita saber sobre el mapa KNetL: [Video](https://youtu.be/tkoPTVciQm0)
- Si usa `FlowJo` o `SeqGeq`, ofrecen plugins para iCellR y otras herramientas de análisis unicelular. Puede encontrar la lista completa de plugins aquí: https://www.flowjo.com/exchange/#/ . Específicamente, el plugin iCellR está aquí: https://www.flowjo.com/exchange/#/plugin/profile?id=34. Además, hay un tutorial de Expresión Diferencial (DE) para SeqGeq disponible para guiarlo en el proceso: [Tutorial DE SeqGeq](https://www.youtube.com/watch?v=gXFmWRpdwow)

Para `citar iCellR` use este [PMID: 34353854](https://cancerdiscovery.aacrjournals.org/content/early/2021/07/28/2159-8290.CD-21-0369)

iCellR publications: [PMID: 35660135](https://pubmed.ncbi.nlm.nih.gov/35660135/) (scRNA-seq/KNetL) [PMID: 35180378](https://pubmed.ncbi.nlm.nih.gov/35180378/) (CITE-seq/KNetL), [PMID: 34911733](https://pubmed.ncbi.nlm.nih.gov/34911733/) (i.score and cell ranking), [PMID: 34963055](https://www.cell.com/cell/fulltext/S0092-8674(21)01427-6?_returnURL=https%3A%2F%2Flinkinghub.elsevier.com%2Fretrieve%2Fpii%2FS0092867421014276%3Fshowall%3Dtrue) (scRNA-seq), [PMID 31744829](https://www.ncbi.nlm.nih.gov/pubmed/31744829) (scRNA-seq), [PMID: 31934613](https://www.ncbi.nlm.nih.gov/pubmed/31934613) (bulk RNA-seq from TCGA), [PMID: 32550269](https://pubmed.ncbi.nlm.nih.gov/32550269/) (scVDJ-seq), [PMID: 34135081](https://jasn.asnjournals.org/content/32/8/1987), [PMID: 33593073](https://www.ahajournals.org/doi/10.1161/CIRCRESAHA.120.317914), [PMID: 34634466](https://pubmed.ncbi.nlm.nih.gov/34634466/), [PMID: 35302059](https://pubmed.ncbi.nlm.nih.gov/35302059/), [PMID: 34353854](https://cancerdiscovery.aacrjournals.org/content/early/2021/07/28/2159-8290.CD-21-0369)


Single (i) Cell R package (iCellR)

<p align="center">
  <img src="https://github.com/rezakj/scSeqR/blob/dev/doc/first.gif" width="400"/>
  <img src="https://github.com/rezakj/scSeqR/blob/dev/doc/out2.gif" width="400"/>
		 <img src="https://github.com/rezakj/scSeqR/blob/master/doc/Slide1_1.png"/>
			 <img src="https://genome.med.nyu.edu/results/external/iCellR/example1/Allclusts.Annotated.png"/>
  <img src="https://github.com/rezakj/scSeqR/blob/dev/doc/out3.gif" width="400"/>
  <img src="https://github.com/rezakj/scSeqR/blob/dev/doc/out4.gif" width="400"/> 
	  <img src="https://github.com/rezakj/scSeqR/blob/master/doc/gating2.gif"/>
</p>

***

## For `getting started` and `tutorials` go to our [Wiki page](https://github.com/rezakj/iCellR/wiki).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-16

---