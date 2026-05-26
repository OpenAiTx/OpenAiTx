# MaichartConverter

## Un programme simple fournissant la fonctionnalité de conversion des charts maimai entre Simai et Ma2.

> Les classes de support d'origine sont maintenant séparées de ce dépôt. Veuillez
> consulter [MaiLib](https://github.com/Neskol/MaiLib) pour plus d'informations.

### Compilation

    git clone
    git submodule update --init --recursive
    dotnet build

### Utilisation & Commandes Disponibles

> Tapez 'MaichartConverter help' pour le manuel détaillé de chaque commande.

- `CompileDatabase`([English](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/CompileDatabase.md)/[中文](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/CompileDatabase_CN.md)) : Composer
  toute la base de données ma2 en simai
- `CompileMa2`([English](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/CompileMa2.md)/[中文](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/CompileMa2_CN.md)) : Compiler le chart Ma2 assigné
  au format assigné
- `CompileMa2ID`([English](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/CompileMa2ID.md)/[中文](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/CompileMa2ID_CN.md)) : Compiler le
  chart Ma2 assigné indexé par ID au format assigné
- `CompileSimai`([English](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/CompileSimai.md)/[中文](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/CompileSimai_CN.md)) : Compiler le chart
  simai assigné au format assigné
-
`ReverseMa2FromSimaiDatabase`([English](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/ReverseMa2FromSimaiDatabase.md)/[中文](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/ReverseMa2FromSimaiDatabase_CN.md)) :
Inverser la base de données Simai depuis un dossier donné vers le dossier MaiAnalysis pour compilation

### Avis sur les paramètres

- Les fichiers musicaux doivent être nommés musicxxxxxx.mp3 où xxxxxx correspond à l’ID de la musique spécifié dans music.xml dans chaque dossier a000,
  et complétés par des 0 en tête pour atteindre 6 chiffres
- Les fichiers bga doivent être nommés xxxxxx.mp4 correspondant à l’ID de la musique spécifié dans music.xml dans chaque dossier a000, et
  complétés par des 0 en tête pour atteindre 6 chiffres
- Le dossier d’images doit être structuré en image/Texture2D/ et les fichiers doivent commencer par UI_Jacket_xxxxxx.jpg où
  xxxxxx correspond à l’ID de la musique spécifié dans music.xml dans chaque dossier a000, et complétés par des 0 en tête pour atteindre 6 chiffres
- Toutes les règles spécifiées ci-dessus sont pour votre commodité afin d’utiliser directement les données obtenues par des moyens appropriés
- Le paramètre de difficulté est listé de 0 à 4 de Basic à Re:Master. Dans MaiLib j’ai spécifié les règles pour Easy et Utage, mais il

  il me faut du temps pour comprendre, ou vous pouvez l’implémenter vous-même en vous référant au code MaiLib
- Tous les chemins doivent se terminer par un séparateur de chemin comme "/" ou "\". Vous ne pouvez pas inclure de guillemets dans le chemin.
- Si vous avez des difficultés à utiliser les commandes, veuillez vous référer au launch.json de VSCode où j’ai inclus plusieurs exemples
- Le programme entier était initialement prévu pour convertir de ma2 à simai et toutes les autres fonctionnalités ont été développées après cela,
  donc il y a eu un ÉNORME compromis dans la conception du code ce qui le rend difficile à lire (mais fonctionne jusqu’à présent). Ce serait
  très aimable de votre part si vous souhaitez m’aider à corriger cela

### Avertissement

- Les droits d’auteur des œuvres appartiennent à chaque détenteur de droits individuel. Cet outil est utilisé uniquement à des fins non commerciales et d’étude.
  Vous devez trouver votre propre voie pour toute ressource qui pourrait être utilisée et l’utiliser correctement à vos risques et périls.
- Si vous souhaitez utiliser le parseur dans votre projet, veuillez consulter [MaiLib](https://github.com/Neskol/MaiLib) et
  espérons que cela vous aidera !


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-26

---