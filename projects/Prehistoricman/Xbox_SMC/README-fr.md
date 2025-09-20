
<div align="right">
  <details>
    <summary >🌐 Langue</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Xbox_SMC
Dumps PIC16/Xyclops provenant de la Xbox originale et des bases de données IDA avec un peu de rétro-ingénierie effectuée.

![Image du PIC16LC63A d'une Xbox originale](https://raw.githubusercontent.com/Prehistoricman/Xbox_SMC/master/pic16lc63a.jpg)

# Flashage Xyclops (XycloMod)
Voir [le répertoire Xyclops et le README](/Xyclops)

# Dumps
Le fichier .bin de chaque dump PIC a les octets inversés pour un chargement correct dans IDA. Ainsi, le premier mot de la mémoire PIC est byte_0 + byte_1 << 8.

Les bases de données .idb d’IDA contiennent des informations sur les variables et quelques observations sur le bloc-notes de la base de données.

Voir cette page wiki pour une présentation des versions SMC : https://xboxdevwiki.net/Xboxen_Info

## B2A
Dumpé à partir d’une Xbox DVT3. Même mot de configuration que P01. Il possède également l’ID du périphérique gravé dans la zone de configuration comme 0000 0000 000B 002A, contrairement aux PICs de production.

Le boot challenge est complètement absent.

## D01
Dumpé à partir d’une Xbox XDK BETA 2. Identique à P01 sauf pour le boot challenge manquant. La fonction de calcul de la réponse attendue au boot challenge est encore présente, mais jamais appelée.

## DXF
Dumpé à partir d’un kit de debug XDK D2. Très similaire à D01 mais avec une logique de plateau, de surchauffe et de démarrage légèrement différente. Le boot challenge manque de la même manière que sur D01.

## D2E
Dumpé à partir d’un kit de développement Tuscany (v1.6). La puce Xyclops porte la mention X01202-001 et ne comporte pas la ligne A-A02 ou A-B01 que possèdent les unités commerciales.

Le code série de debug à FC00 correspond au dump retail P2L. Il y a un motif de données étrange de 0x4000 à 0xFBFF.

## P01
Dumpé à partir d’une Xbox v1.0. Le mot de configuration est 0x86 :
- CP1:CP0 = 0 (Protection du code activée pour toute la mémoire)
- BODEN = 0 (Réinitialisation par chute de tension désactivée)
- ~PWRTE = 0 (Minuterie de mise sous tension activée)
- WDTE = 1 (Minuterie de surveillance activée)
- FOSC1:FOSC0 = 2 (Oscillateur HS)

Une valeur de configuration de 0x3FB6 convient pour les clones SMC afin qu’ils n’aient pas la protection du code activée.

## P11
Dumpé à partir d’une Xbox v1.3. Même mot de configuration que P01.

Il existe quelques petites différences dans P11 par rapport à P01, incluant une commande SMBus supplémentaire (écriture 0x22), des priorités LED différentes et des temporisations plus souples pour le démarrage.

J’ai comparé les dumps brouillés de v1.3 avec ceux de v1.4 et ils correspondaient. Cela signifie qu’il est très probable qu’ils aient le même programme.

## P2L
Extrait d'une Xbox v1.6. Révision Xyclops A-A02. Il contient du code Intel 8051 mais possède de nombreux registres de fonction spéciale dont la fonction est inconnue.

Le port série de débogage est alimenté par le code à l'adresse FC00. Il ressemble à un débogueur rudimentaire pouvant mettre en pause l'exécution, extraire des données et écrire dans les registres/RAM.

# Extraction Xyclops

La puce Xyclops possède 3 broches pour le « debug » : TXD (broche 64), RXD (broche 63) et DEBUG (broche 29). Il faut mettre la broche DEBUG à l'état haut pour activer le port série sur les broches TX et RX. La communication série fonctionne à 9600 bauds.

Le protocole est basé sur des commandes de 4 octets généralement au format `<cmd>` `<adresse octet fort>` `<adresse octet faible>` `<sans importance>`

La commande 0x14 extrait 64 octets de données BIOS à la fois et la commande 0x15 extrait 64 octets de données du programme SMC à la fois. Un dump de Xyclops, P2L.bin, est inclus dans le dépôt. [xyclops_dumper.py](/Xyclops/xyclops_dumper.py) est aussi inclus pour vous permettre de dumper votre propre machine.

# Méthodologie d’extraction PIC
Article complet sur https://wiki.recessim.com/view/PIC_Burnout

Le PIC a sa protection de code activée, donc toutes les données lues sont 0000. J'ai utilisé une astuce pour obtenir des données brouillées en sortie, découvert l'algorithme de brouillage à l'aide d'une puce sacrifiée, puis utilisé une sorte d’exploit pour modifier les données ROM afin de fixer certains bits à des valeurs connues. Je peux alors extraire les informations requises à partir des multiples dumps brouillés pour reconstruire les données originales.

# PICProgrammer
PICProgrammer est l’un des quelques projets Arduino pour le RP2040 que j’ai utilisés dans mes recherches. Il offre une interface en ligne de commande simple permettant d’exécuter des opérations ICSP (programmation série in-circuit) sur le PIC. Ceci est préféré à l’utilisation d’un programmateur dédié comme le PICkit en raison de sa flexibilité et de la possibilité de faire des choses que le fabricant n’avait pas prévues.

Vous devez avoir une bonne compréhension de l’électronique et de la programmation avant d’utiliser cet outil, et examiner soigneusement ce que font les commandes avant de les exécuter.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---