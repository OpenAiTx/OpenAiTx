## Outils de Shape Key pour Blender
<!-- BADGES/ -->
<span class="badge-blenderartists"><a href="https://blenderartists.org/t/free-shape-key-transfer-addon" title="Lien vers le post du forum Blender Artists"><img src="https://img.shields.io/badge/Blender-Artists-orange.svg?logo=blender&longCache=true&style=popout-square" alt="Post du forum Blender Artists" /></a></span>
<span class="badge-discord"><a href="https://discord.gg/CmgdEvw" title="Rejoindre sur discord"><img src="https://img.shields.io/badge/Discord-Join-768ADC.svg?logo=discord&longCache=true&style=popout-square" alt="Bouton serveur Discord" /></a></span>
<span class="badge-youtube"><a href="https://www.youtube.com/watch?v=-zBlaedkkVs" title="Regarder le tutoriel sur Youtube"><img src="https://img.shields.io/badge/Tutorial-Video-F40000.svg?logo=youtube&longCache=true&style=popout-square" alt="Tutoriel Youtube" /></a></span>

Transfert de Shape Key pour Blender 2.93

Utilisez cet addon pour transférer facilement les shape keys entre des maillages de topologies différentes.

Placez les deux maillages à l’origine et superposez-les à l’endroit où vous souhaitez que le maillage destination copie les shape keys du maillage source.

Cet addon a été initialement créé pour copier les shape keys du personnage ManuelBastioniLab vers d’autres maillages, mais peut être utilisé dans toute situation.

Cet addon est basé sur le code contenu dans ce [post Stackoverflow](https://blender.stackexchange.com/questions/119836/scripting-transferring-shape-keys-between-different-meshes/119867#119867) réalisé par moi.

L’addon sera accessible sous Outils -> Outils de Shape Key

Vous pouvez aussi exclure des shape keys.

Utilisez Rayon d’Incrément pour augmenter le nombre de sommets du maillage source qui affectent le maillage destination.

Quand Utiliser le Sommet le Plus Proche est désactivé, il fera la moyenne des positions de tous les sommets proches dans le Rayon d’Incrément.

#### Moins de sommets dans le maillage source rendra l’opération plus rapide.

##

### Fonctionnalités :

- Transférer des Shape Keys entre des maillages de topologies différentes

- Gérer les shape keys transférées en ajoutant des exclusions

- Copier tous les noms de shape keys d’un maillage dans le presse-papiers

### Exemples d’utilisation :

- Copier les shape keys du visage vers les cartes de cheveux pour moustache ou sourcils.

- Copier les clés de forme du maillage de base vers le LOD.

##

### Note :
Il est parfois utile de dupliquer le maillage source et de supprimer les vertices que vous estimez ne pas devoir influencer le maillage de destination.

Un exemple dans le cas d’une moustache et d’un visage : dupliquez le visage et supprimez tous les vertices sauf ceux autour des lèvres qui sont les plus susceptibles d’influencer la moustache, puis utilisez le maillage résultant comme source pour copier les clés de forme vers vos cartes de cheveux moustache ou maillage de destination.

Plus de fonctionnalités seront ajoutées à cet addon si nécessaire. Vous pouvez également supprimer facilement toutes les clés de forme d’un maillage avec cet outil.

##

### Licence :

Addon de transfert de clés de forme pour Blender - Copyright (C) 2018 Ajit Christopher D'Monte

Tous les fichiers python sont publiés sous licence GNU General Public License 3.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-05

---