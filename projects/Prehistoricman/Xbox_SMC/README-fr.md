# Xbox_SMC
Dumps PIC16/Xyclops de la Xbox originale et bases de données IDA avec un peu de rétro-ingénierie réalisée.

![Image du PIC16LC63A d'une Xbox originale](https://raw.githubusercontent.com/Prehistoricman/Xbox_SMC/master/pic16lc63a.jpg)

# Flashage Xyclops (XycloMod)
Voir [le répertoire Xyclops et le README](/Xyclops)

# Dumps
Le fichier .bin pour chaque dump PIC a les octets inversés pour un chargement correct dans IDA. Ainsi, le premier mot de la mémoire PIC est byte_0 + byte_1 << 8.

Les bases de données .idb IDA contiennent des infos sur les variables et quelques observations dans le bloc-notes de la base de données.

Voir cette page wiki pour une répartition des versions SMC : https://xboxdevwiki.net/Xboxen_Info

## B2A
Dumpé d’une Xbox DVT3. Même mot de configuration que P01. Il contient aussi l’ID du dispositif gravé dans la zone de configuration comme 0000 0000 000B 002A, contrairement aux PIC de production.

Le défi de démarrage est complètement absent.

## D01
Dumpé d’une Xbox XDK BETA 2. Identique à P01 sauf l’absence du défi de démarrage. La fonction pour calculer la réponse attendue au défi de démarrage est toujours là, mais jamais appelée.

## DXF
Dumpé d’un kit de débogage XDK D2. Très similaire à D01 mais avec une logique de plateau, de surchauffe et de démarrage légèrement différente. Le défi de démarrage est absent de la même manière que D01.

## D2E
Dumpé d’un kit de développement Tuscany (v1.6). La puce Xyclops est marquée X01202-001, et il manque la ligne A-A02 ou A-B01 que les unités commerciales possèdent.

Le code série de débogage à FC00 correspond au dump P2L commercial. Il y a un motif étrange de données de 0x4000 à 0xFBFF.

## P01
Dumpé d’une Xbox v1.0. Le mot de configuration est 0x86 :
- CP1:CP0 = 0 (Protection du code activée pour toute la mémoire)
- BODEN = 0 (Réinitialisation par sous-tension désactivée)
- ~PWRTE = 0 (Minuterie de mise sous tension activée)
- WDTE = 1 (Minuterie de surveillance activée)
- FOSC1:FOSC0 = 2 (Oscillateur HS)

Une valeur de configuration de 0x3FB6 convient pour les clones SMC afin qu’ils n’aient pas la protection du code activée.

## P11
Dumpé depuis une Xbox v1.3. Même mot de configuration que P01.

Il y a quelques petites différences dans P11 par rapport à P01, notamment une commande SMBus supplémentaire (écriture 0x22), des priorités LED différentes, et des timings de démarrage plus souples.

J'ai comparé des dumps brouillés de la v1.3 avec ceux de la v1.4 et ils correspondaient. Cela signifie qu'il est très probable qu'ils aient le même programme.

## P2L
Dumpé depuis une Xbox v1.6. Révision Xyclops A-A02. Il contient du code Intel 8051 mais possède beaucoup de registres de fonction spéciale dont la fonction est inconnue.

Le port série de débogage est alimenté par le code à FC00. On dirait un débogueur rudimentaire qui peut suspendre l'exécution, dumper des données, et écrire dans les registres/RAM.

# Dumping Xyclops

La puce Xyclops a 3 broches pour le « debug » : TXD (broche 64), RXD (broche 63), et DEBUG (broche 29). Mettez la broche DEBUG à l'état haut pour activer le port série sur les broches TX et RX. Le port série fonctionne à 9600 bauds.

Le protocole est basé sur des commandes de 4 octets qui sont généralement au format `<cmd>` `<adresse MSByte>` `<adresse LSByte>` `<octet sans importance>`

La commande 0x14 dump 64 octets de données BIOS à la fois et 0x15 dump 64 octets de programme SMC à la fois. Un dump de Xyclops, P2L.bin, est inclus dans le dépôt. [xyclops_dumper.py](/Xyclops/xyclops_dumper.py) est aussi inclus pour que vous puissiez dumper votre propre machine.

# Méthodologie de dumping PIC
Description complète sur https://wiki.recessim.com/view/PIC_Burnout

Le PIC a sa protection de code activée donc toutes les lectures de données donnent 0000. J’ai utilisé un truc pour obtenir une sortie de données brouillées à la place, découvert l’algorithme de brouillage en utilisant une puce sacrificielle, puis utilisé une sorte d’exploit pour modifier les données ROM afin de fixer certains bits à des valeurs connues. Ensuite, je peux extraire les informations requises des multiples dumps brouillés pour reconstituer les données originales.

# PICProgrammer
PICProgrammer est l’un des quelques projets Arduino pour le RP2040 que j’ai utilisé dans mes recherches. Il fournit une interface en ligne de commande simple pour exécuter des opérations ICSP (programmation série en circuit) sur le PIC. Il est préféré à l’utilisation d’un programmateur dédié comme le PICkit en raison de sa flexibilité et de la possibilité de faire des choses que le fabricant n’avait pas prévues.

Vous devriez bien comprendre l’électronique et la programmation avant de l’utiliser, et bien examiner ce que font les commandes avant de les exécuter.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-17

---