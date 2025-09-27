# Courant alternatif

Le Courant alternatif est une implémentation efficace de la poussière de redstone non localisée. Son objectif principal est de réduire le lag causé par la poussière de redstone, en optimisant les calculs de puissance et en réduisant le nombre de mises à jour de forme et de bloc émises. Comme effet secondaire de ces changements, l'ordre des mises à jour de bloc des réseaux de poussière de redstone est prévisible et intuitif plutôt que localisé et chaotique.

## Performance

Les contributions MSPT de la poussière de redstone sont jusqu'à 20 fois plus faibles avec Courant alternatif, tout en maintenant un haut niveau de conformité Vanilla. Son faible nombre de modifications de code le rend peu invasif, ce qui en fait un remplacement facile à intégrer pour la poussière de redstone Vanilla.

## Comment ça fonctionne ?

L'algorithme utilisé par Courant alternatif a été conçu avec les objectifs suivants en tête :
1. Minimiser le nombre de fois qu’un fil vérifie son environnement pour déterminer son niveau de puissance.
2. Minimiser le nombre de mises à jour de bloc et de forme émises.
3. Émettre les mises à jour de bloc et de forme dans un ordre déterministe, non localisé, corrigeant le bug MC-11193.

Dans Vanilla, le fil de redstone est lent car il échoue aux points 1 et 2.

Le fil de redstone se met à jour de manière récursive et chaque fil calcule son niveau de puissance isolément plutôt que dans le contexte du réseau auquel il appartient. Cela signifie qu’un fil dans une grille peut changer son niveau de puissance plus d’une demi-douzaine de fois avant de se stabiliser à sa valeur finale. Ce problème était pire en 1.13 et versions antérieures, où un fil ne diminuait son niveau de puissance que d’1 à la fois.

En plus de cela, un fil émet 42 mises à jour de bloc et jusqu’à 22 mises à jour de forme à chaque fois qu’il change son niveau de puissance.

Parmi ces 42 mises à jour de bloc, 6 sont pour lui-même, ce qui est donc non seulement redondant, mais aussi une grande source de lag, car cela provoque un recalcul inutile de son niveau de puissance. Un bloc n’a que 24 voisins dans une distance de Manhattan de 2, ce qui signifie que 12 des 36 mises à jour de bloc restantes sont des doublons et donc également redondantes.

Sur les 22 mises à jour de forme, seules 6 sont strictement nécessaires. Les 16 autres sont envoyées aux blocs en diagonale au-dessus et en dessous. Celles-ci sont nécessaires si un fil change ses connexions, mais pas lorsqu’il change son niveau de puissance.

Le fil de redstone dans Vanilla échoue aussi au point 3, bien que ce soit plus un problème de confort d’utilisation qu’un problème de lag. La nature récursive de ses mises à jour, combinée à l’ordre dépendant de la localisation dans lequel chaque fil met à jour ses voisins, rend l’ordre des mises à jour des voisins d’un réseau de fils incroyablement incohérent et apparemment aléatoire.

Courant alternatif corrige chacun de ces problèmes de la manière suivante.

(1)
Pour s’assurer qu’un fil calcule son niveau de puissance le moins possible, nous supprimons la nature récursive des mises à jour du fil de redstone dans Vanilla. À la place, nous construisons un réseau de fils connectés, trouvons ceux qui reçoivent de la puissance redstone de "l’extérieur" du réseau, et répartissons la puissance à partir de là. Cela présente quelques avantages :

- Chaque fil vérifie la puissance provenant de composants non-fils au maximum une fois, et de fils proches seulement deux fois.
- Chaque fil ne définit son niveau de puissance dans le monde qu’une seule fois. C’est important, car les appels à Level.setBlock sont encore plus coûteux que les appels à Level.getBlockState.

(2)
Il y a 2 moyens évidents pour réduire le nombre de mises à jour de bloc et de forme.

- Éliminer les 18 mises à jour de bloc redondantes et les 16 mises à jour de forme redondantes, de sorte que chaque fil n’émette que 24 mises à jour de bloc et 6 mises à jour de forme chaque fois qu’il change de niveau de puissance.
- N’émettre les mises à jour de bloc et de forme qu’une fois qu’un fil atteint son niveau de puissance final, plutôt qu’à chaque étape intermédiaire.
Pour un fil individuel, ces deux optimisations sont les meilleures que vous puissiez faire, mais pour une grille entière, vous pouvez faire mieux !

Puisque nous calculons la puissance de tout le réseau, envoyer des mises à jour de blocs et de formes aux fils qu’il contient est redondant. Supprimer ces mises à jour peut réduire le nombre de mises à jour de blocs et de formes jusqu’à 20 %.

(3)
Pour rendre l’ordre des mises à jour des blocs aux voisins d’un réseau déterministe, la première chose à faire est de remplacer l’ordre dépendant de la localisation dans lequel un fil met à jour ses voisins. À la place, nous le basons sur la direction du flux de puissance. Cette partie de l’algorithme a été fortement inspirée par le ‘RedstoneWireTurbo’ de theosib, dont vous pouvez en apprendre plus dans le commentaire de theosib sur Mojira [ici](https://bugs.mojang.com/browse/MC-81098?focusedCommentId=420777&page=com.atlassian.jira.plugin.system.issuetabpanels%3Acomment-tabpanel#comment-420777) ou en consultant son implémentation dans le mod carpet [ici](https://github.com/gnembon/fabric-carpet/blob/master/src/main/java/carpet/helpers/RedstoneWireTurbo.java).

L’idée est de déterminer la direction du flux de puissance à travers un fil en fonction de la puissance qu’il reçoit des fils voisins. Par exemple, si la seule puissance reçue par un fil provient d’un fil voisin à l’ouest, on peut dire que la direction du flux de puissance à travers le fil est vers l’est.

Nous faisons en sorte que l’ordre des mises à jour des blocs aux voisins d’un fil dépende de ce qui est déterminé comme la direction du flux de puissance. Cela supprime non seulement complètement la localisation, mais enlève même la directionnalité dans un grand nombre de cas. Contrairement à ‘RedstoneWireTurbo’, cependant, j’ai décidé de garder un élément directionnel dans les cas ambigus, plutôt que d’introduire de l’aléa, bien que cela soit trivial à changer.

Bien que ce changement corrige l’ordre des mises à jour des blocs des fils individuels, nous devons encore traiter l’ordre global des mises à jour des blocs d’un réseau. Cela s’avère être une correction simple, grâce à un changement que nous avons fait plus tôt : nous recherchons dans le réseau les fils qui reçoivent de la puissance de l’extérieur, et diffusons la puissance à partir de là. Si nous faisons en sorte que chaque fil transmette sa puissance aux fils voisins dans un ordre dépendant de la direction du flux de puissance, nous obtenons un ordre de mise à jour des fils non localisé et en grande partie non directionnel.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-27

---