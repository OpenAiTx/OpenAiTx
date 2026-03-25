# Open-PAV

OpenPAV (Open Production Automated Vehicle) est une plateforme ouverte conçue pour faciliter la **collecte de données, la modélisation du comportement et l’évaluation des performances** des véhicules automatisés de production (PAV). Elle intègre diverses bases de données et modèles de véhicules calibrés, en faisant un outil essentiel pour les chercheurs et développeurs souhaitant étudier la dynamique des PAV et leurs impacts. Le projet encourage les contributions de la communauté scientifique et fournit des paramètres de modèles prêts à l’emploi pour une intégration fluide avec les outils de simulation. Consultez le [site OpenPAV](https://openpav.github.io/OpenPAV) pour plus de détails.

![Framework](https://raw.githubusercontent.com/OpenPAV/OpenPAV/main/./docs/images/Framework.png)

## Sources de données et contributeurs

### Sources de données originales :

Actuellement, le jeu de données a examiné 14 jeux de données open-source provenant de 7 fournisseurs, chacun apportant des perspectives distinctes sur le comportement des AV dans diverses conditions de conduite et scénarios. Ils sont :

- **Argoverse 2 Motion Forecasting Dataset**. Collecté à Austin au Texas, Detroit dans le Michigan, Miami en Floride, Pittsburgh en Pennsylvanie, Palo Alto en Californie, et Washington, D.C. par Argo AI avec des chercheurs de Carnegie Mellon University et du Georgia Institute of Technology. Disponible sur -  [Argoverse 2 Motion Forecasting Dataset](https://www.argoverse.org/av2.html).
- **CATS Open Datasets**. Trois jeux de données ont été rassemblés à Tampa en Floride, et Madison au Wisconsin par le CATS Lab. Disponible sur - [CATS Lab](https://github.com/CATS-Lab).
- **Central Ohio ACC Datasets**. Deux jeux de données ont été collectés dans l’Ohio par le UCLA Mobility Lab et le Transportation Research Center. Disponible sur - [Advanced Driver Assistance System (ADAS)-Equipped Single-Vehicle Data for Central Ohio](https://catalog.data.gov/dataset/advanced-driver-assistance-system-adas-equipped-single-vehicle-data-for-central-ohio).
- **MircoSimACC Dataset**. Collecté dans quatre villes en Floride, incluant Delray Beach, Loxahatchee, Boca Raton, et Parkland par le groupe de recherche de Florida Atlantic University. Disponible sur - [microSIM-ACC](https://github.com/microSIM-ACC).
- **OpenACC Database**. Quatre jeux de données ont été recueillis en Italie, Suède, et Hongrie par le Centre commun de recherche de la Commission européenne. Disponible sur - [data.europa.eu](https://data.europa.eu/data/datasets/9702c950-c80f-4d2f-982f-44d06ea0009f?locale=en).
- **Vanderbilt ACC Dataset**. Collecté à Nashville, Tennessee par le groupe de recherche de Vanderbilt University. Disponible sur - [Adaptive Cruise Control Dataset](https://acc-dataset.github.io/).
- **Waymo Open Dataset**. Deux jeux de données ont été collectés dans six villes incluant San Francisco, Mountain View, et Los Angeles en Californie, Phoenix en Arizona, Detroit dans le Michigan, et Seattle dans l’État de Washington par Waymo. Disponible sur - [Waymo Motion Dataset](https://waymo.com/open/data/motion/) et [Vehicle trajectory data processed from the Waymo Open Dataset](https://data.mendeley.com/datasets/wfn2c3437n/2).

<img src="https://raw.githubusercontent.com/OpenPAV/OpenPAV/main/./docs/images/Dataset.png" alt="Major Components" width="600">

### Source de données traitées :

En organisant les données des jeux ci-dessus, nous avons traité un jeu de données unifié de trajectoires ULTra-AV, dans lequel toutes les données sont représentées selon un format standardisé. Disponible sur -  [A unified longitudinal trajectory dataset for automated vehicle](https://www.nature.com/articles/s41597-024-03795-y) et [ULTra-AV](https://github.com/CATS-Lab/Filed-Experiment-Data-ULTra-AV).

## Nouveautés

- **Mars 2026 :** Le projet a lancé une nouvelle interface.
- **Novembre 2024 :** Démarrage initial du projet avec guides d’installation et d’utilisation.

## Composants majeurs

Open-PAV se compose des éléments suivants :

- **Traitement des données :** À partir des données brutes AV (LiDAR, images, vidéos, trajectoires) en entrée, ce module convertit les données du même type en un format unifié et effectue un nettoyage préliminaire des données.
- **Modélisation du comportement :** Utilisant les données AV traitées, ce module calibre les modèles cinématiques des véhicules automatisés et les exporte pour usage en simulation. Les utilisateurs peuvent aussi directement intégrer leur pile logicielle AV pour tester leur système AV développé dans ce module.
- **Évaluation accélérée :** Ce module est conçu pour générer des scénarios de conduite critiques en sécurité adaptés à un modèle AV donné, visant à évaluer ses performances en matière de sécurité.


## Contributeurs

### Groupes contributeurs

[CATS Lab](https://catslab.engr.wisc.edu/) (PI : [Xiaopeng Li](https://catslab.engr.wisc.edu/staff/xiaopengli/))

[CAT Lab](http://www.connectedandautonomoustransport.com/dr-zhengs-research.html) (PI : [Zuduo Zheng](https://civil.uq.edu.au/profile/857/zuduo-zheng))

[SHINE Lab](https://sites.google.com/site/danjuechen/) (PI : Danjue Chen)

NextGen-ITS Lab (PI : David Kan)

### Contributeurs techniques :

- [Hang Zhou](https://catslab.engr.wisc.edu/staff/zhou-hang/), [Ke Ma](https://markmaaaaa.github.io/KeMa.github.io/), Keke Long, Chengyuan Ma.

### Publications associées :

- Zhou, H., Ma, K., Liang, S., Li, X., et Qu, X. (2024). *A unified longitudinal trajectory dataset for automated vehicle*. *Scientific Data*, 11, 1123.

### Remerciements :

Ce projet est partiellement financé par la National Science Foundation (NSF) via "[NSF CPS : Small : NSF-DST : Turning “Tragedy of the Commons (ToC)” into “Emergent Cooperative Behavior (ECB)” for Automated Vehicles at Intersections with Meta-Learning](https://www.nsf.gov/awardsearch/show-award?AWD_ID=2343167)" (No. 2343167). Nous remercions également le soutien de la [IEEE Intelligent Transportation Systems Society (ITSS) Emerging Transportation Technology Testing (ET3) Technical Committee](https://ieee-itss.org/chapters-committees/emerging-transportation-technology-testing).

Nous exprimons aussi notre sincère gratitude à tous les fournisseurs et contributeurs de données ayant rendu ce travail possible.

## Licence

Open-PAV est publié sous la [Licence MIT](LICENSE). Voir le fichier LICENSE pour plus de détails.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-25

---