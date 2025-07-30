# Ventoy CPIO

Un ramdisk alternatif pour [Ventoy](https://github.com/ventoy/Ventoy).

La documentation est disponible [ici](https://github.com/fnr1r/ventoy-meta/tree/main/docs)  
et les versions [ici](https://github.com/fnr1r/ventoy-cpio/releases).

NOTE : Ceci n’est qu’une petite partie de ma tentative d’ajouter un système de compilation plus sensé(-ish)  
à Ventoy. Un index de tous mes projets liés à Ventoy peut être trouvé  
[ici](https://github.com/fnr1r/ventoy-meta).

## Objectif

Créer un ramdisk de remplacement pour Ventoy

- [?] avec un système de compilation plus sensé(-er)  
- [x] un ramdisk amorçable  
- [ ] un ramdisk fonctionnellement identique  
  (c’est-à-dire capable de faire les mêmes choses que l’original)  
- [x] un ramdisk plus petit

### Non-objectifs

- ❌ un ramdisk binaire-identique à celui officiel  
  - compiler des binaires identiques avec les instructions données serait presque  
  impossible et est finalement inutile  
  - cependant, les ramdisks construits avec ce projet devraient être reproductibles

### Changements possibles à l’avenir

- Suppression des suffixes des binaires (ils sont juste agaçants et incohérents)  
  (aucun changement en amont requis)  
- Séparer les ramdisks en x86 32 bits et 64 bits  
  (exigerait des modifications dans grub)  
- Nettoyage des scripts shell dans le ramdisk  
  (aucun changement en amont requis)

## Progrès

Ça démarre, mais certaines fonctionnalités pourraient ne pas fonctionner.

### ventoy.cpio

100 %, car c’est littéralement juste une compression xz d’un tas de fichiers.

Ratio de taille :

- du - 1 (64 / 64)  
- ls -l - 1 (62976 / 62976)

### ventoy_ARCH.cpio

~75 %

Tous les outils sont là (pour la plupart), compilés d’une manière ou d’une autre. Il ne reste plus qu’à optimiser.

Ratio de taille (x86) :

- du - 0.8540245566166439 (2504 / 2932)  
- ls -l - 0.8624375107740045 (2561536 / 2970112)

Ratio de taille (arm64) :

- du - 0.8159806295399516 (1348 / 1652)  
- ls -l - 0.8159490600363857 (1377792 / 1688576)

Ratio de taille (mips64) :

- du - 0.9816849816849817 (1072 / 1092)  
- ls -l - 0.981642955484167 (1095168 / 1115648)

### vtloopex.cpio

À FAIRE : ajouter ceci

## Utilisation

### Compilation


```sh
docker compose build
```

```sh
docker compose up
```

Indice :

Si vous ne souhaitez pas retélécharger les archives à chaque reconstruction du conteneur,
allez dans `docker/base/{dietlibc,musl,toolchains}`, parcourez le script d'installation
et téléchargez manuellement le fichier avec `wget`.

Vous pouvez également exécuter ceci pour entrer dans le conteneur :

```sh
docker run -it --rm \
  -v ".:/build" \
  ventoy-cpio-builder:latest \
  bash
```

### Installation

Une fois que vous avez les fichiers `ventoy*.cpio` :

1. Montez la deuxième partition de votre clé USB Ventoy
1. !!! SAUVEGARDEZ LES FICHIERS ORIGINAUX `ventoy*.cpio` !!!
1. Copiez le cpio que vous souhaitez essayer. (indice : si vous ne savez pas lequel c’est,
  alors c’est probablement `ventoy_x86.cpio`)

## Mini TODO

- Compiler avec une version plus ancienne des en-têtes Linux pour la compatibilité

## Notes

- [En termes de GCC](https://gcc.gnu.org/onlinedocs/gccint/Configure-Terms.html) :
  - La compilation est supposée être pour un *nix x86_64
  - L’hôte (pour les outils d’installation de ventoy) est supposé être x86_64
  - Les cibles sont x86_64, i386, aarch64 et mips64el


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-30

---