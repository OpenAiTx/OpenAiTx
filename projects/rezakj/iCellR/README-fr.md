[![Version CRAN](https://www.r-pkg.org/badges/version/iCellR)](https://cran.r-project.org/package=iCellR)
[![Téléchargements CRAN](https://cranlogs.r-pkg.org/badges/iCellR)](https://cran.r-project.org/package=iCellR)
[![Licence : GPL v2](https://img.shields.io/badge/License-GPL%20v2-blue.svg)](https://www.gnu.org/licenses/old-licenses/gpl-2.0.en.html)

# Paquet R Single (i) Cell (iCellR)
iCellR est un paquet R interactif conçu pour faciliter l'analyse et la visualisation des données de séquençage à cellule unique à haut débit. Il supporte diverses technologies de cellule unique, y compris `scRNA-Seq`, `scVDJ-Seq`, `scATAC-Seq`, `CITE-Seq` et `Transcriptomique Spatiale` (ST).

Mainteneur : [Alireza Khodadadi-Jamayran](https://scholar.google.com/scholar?q=author:%22Khodadadi-Jamayran%20A%22)

### Actualités (avril 2021)
Utilisez la dernière version d’iCellR (v1.6.4) pour les analyses scATAC-seq et Transcriptomique Spatiale (ST). Profitez de la fonction [i.score](https://github.com/rezakj/iCellR/wiki/i.score) pour le `scorage des cellules basé sur des signatures géniques` avec des méthodes telles que `Tirosh, Mean, Sum, GSVA, ssgsea, Zscore et Plage`.

### Actualités (juillet 2020)
Découvrez iCellR version 1.5.5, désormais doté d’outils pour l’analyse du cycle cellulaire `(phases G0, G1S, G2M, M, G1M et S)`. Voir l’exemple [phase](https://genome.med.nyu.edu/results/external/iCellR/example1/All_cellcycle.png), nouvelle fonctionnalité Pseudotime Abstract KNetL (carte PAK) ajoutée – visualisez la progression du pseudotemps [(carte PAK)](https://genome.med.nyu.edu/results/external/iCellR/example1/pseudotime.KNetL.png). Effectuez une analyse de corrélation gène-gène avec des outils de visualisation mis à jour. [corrélations](https://genome.med.nyu.edu/results/external/iCellR/example1/gene-gene.correlation.png).

### Actualités (mai 2020)
Explorez la `carte KNetL`, une méthode avancée de réduction dimensionnelle ajustable et dynamique [carte KNetL](https://genome.med.nyu.edu/results/external/iCellR/example1/Allclusts.Annotated.png) <img src="https://github.com/rezakj/scSeqR/blob/master/doc/logo.png" alt="dessin" width="30"/> KNetL (prononcé « nettle ») offre des capacités de zoom améliorées [KNetL](https://www.biorxiv.org/content/10.1101/2020.05.05.078550v1.full) pour montrer beaucoup plus de détails par rapport à tSNE et UMAP.

### Actualités (avril 2020)
Introduction des méthodes `imputation et correction de couverture (CC)` pour une meilleure analyse de corrélation gène-gène. ([CC](https://genome.med.nyu.edu/results/external/iCellR/example1/gene-gene.correlation.png)). Effectuez un `alignement de lot avec les outils CPCA` et CCCA d’iCellR (CCCA et [CPCA](https://genome.med.nyu.edu/results/external/iCellR/example2/AllCondsClusts.png)) [méthodes](https://www.biorxiv.org/content/10.1101/2020.03.31.019109v1.full). Bases de données élargies pour la prédiction du type cellulaire incluant désormais ImmGen et MCA.

### Actualités (sept. 2018)
`scSeqR` a été renommé en `iCellR`, et scSeqR a été abandonné. Merci d’utiliser iCellR dorénavant, car scSeqR n’est plus supporté. `UMAP` est ajouté à iCellR. Le `gating cellulaire` interactif a été ajouté, permettant aux utilisateurs de sélectionner des cellules directement dans les graphiques HTML via Plotly.

### Tutoriels et manuel
- Lien vers le `manuel` [Manuel](https://cran.r-project.org/web/packages/iCellR/iCellR.pdf) et Comprehensive R Archive Network [(CRAN)](https://cran.r-project.org/web/packages/iCellR/index.html).
- Pour `démarrer` et accéder aux `tutoriels`, rendez-vous sur notre [page Wiki](https://github.com/rezakj/iCellR/wiki).
- Lien vers un tutoriel vidéo pour l’analyse CITE-Seq et scRNA-Seq : [Vidéo](https://vimeo.com/337822487)
- Tout ce que vous devez savoir sur la carte KNetL : [Vidéo](https://youtu.be/tkoPTVciQm0)
- Si vous utilisez `FlowJo` ou `SeqGeq`, ils proposent des plugins pour iCellR et d’autres outils d’analyse à cellule unique. Vous pouvez trouver la liste complète des plugins ici : https://www.flowjo.com/exchange/#/ . Plus précisément, le plugin iCellR est disponible ici : https://www.flowjo.com/exchange/#/plugin/profile?id=34. De plus, un tutoriel SeqGeq sur l’Expression Différentielle (DE) est disponible pour vous guider : [Tutoriel SeqGeq DE](https://www.youtube.com/watch?v=gXFmWRpdwow)

Pour `citer iCellR`, utilisez ce [PMID : 34353854](https://cancerdiscovery.aacrjournals.org/content/early/2021/07/28/2159-8290.CD-21-0369)

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