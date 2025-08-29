# MangaJaNai

[![Discord](https://img.shields.io/discord/1121653618173546546?label=Discord&logo=Discord&logoColor=white)](https://discord.gg/EeFfZUBvxj)

<a href="./mangajanaiv1demo.webp?raw=1"><img src="https://raw.githubusercontent.com/the-database/MangaJaNai/main/mangajanaiv1demo.webp"/></a>
<p align="center"><sup>(cliquer sur l'image pour agrandir)</sup></p>

## Aperçu

MangaJaNai est une collection de modèles de suréchantillonnage pour manga. Les modèles sont principalement optimisés pour agrandir des images de manga numériques en japonais ou en anglais avec une hauteur allant d'environ 1200px à 2048px.

Rejoignez le [**serveur Discord JaNai**](https://discord.gg/EeFfZUBvxj) pour obtenir les dernières nouvelles, télécharger des modèles préliminaires et expérimentaux, obtenir de l’aide et poser des questions, partager vos agrandissements ou donner votre avis. 日本語も大丈夫です。

## Instructions d’utilisation

### Suréchantillonnage avec MangaJaNaiConverterGui

Pour une expérience simple prête à l’emploi, utilisez [MangaJaNaiConverterGui](https://github.com/the-database/MangaJaNaiConverterGui) pour agrandir vos mangas avec les modèles MangaJaNai.

## Modèles MangaJaNai
Alors que les mangas sont produits à très haute résolution (plus de 10000px) et imprimés avec une excellente qualité dans les livres physiques, les mangas numériques officiels sont souvent en basse résolution et truffés d’artefacts JPEG et moirés. L’objectif des modèles MangaJaNai est d’agrandir les mangas numériques en noir et blanc de faible qualité afin de produire des résultats qui nettoient les artefacts JPEG et moirés, donnant des résultats plus proches des versions imprimées.

La plupart des mangas sont produits avec des points demi-teintes, mais certaines éditions numériques sont tellement dégradées que ces points ne sont plus visibles. Les modèles MangaJaNai peuvent sembler créer des points qui n’étaient pas dans l’image originale, mais dans la plupart des cas, les modèles restaurent correctement des points qui n’étaient plus visibles dans l’image source de faible qualité. Afin de garantir que les demi-teintes sont générées à la bonne taille et fréquence, plusieurs modèles MangaJaNai ont été entraînés, chacun optimisé pour être utilisé sur des images avec l’une des sept hauteurs différentes, correspondant aux tailles d’image les plus courantes des mangas numériques publiés au Japon : 1200p, 1300p, 1400p, 1500p, 1600p, 1920p et 2048p. [MangaJaNaiConverterGui](https://github.com/the-database/MangaJaNaiConverterGui) sélectionne automatiquement le meilleur modèle à utiliser selon la résolution de l’image d’entrée.

## Modèles IllustrationJaNai
Puisque les modèles MangaJaNai conviennent uniquement aux pages de manga en noir et blanc, des modèles IllustrationJaNai supplémentaires ont été entraînés pour être utilisés sur des images en couleur provenant de mangas, comme les couvertures et les pages en couleur. Ces modèles ont été entraînés pour supprimer les artefacts d’image courants, tels que les artefacts JPEG et les points demi-teintes imprimés en basse résolution, et fonctionnent également bien comme modèles de suréchantillonnage polyvalents pour l’art numérique. [MangaJaNaiConverterGui](https://github.com/the-database/MangaJaNaiConverterGui) sélectionne automatiquement le modèle IllustrationJaNai pour les images en couleur.

## Projets connexes

- [mpv-upscale-2x_animejanai](https://github.com/the-database/mpv-upscale-2x_animejanai) : Suréchantillonnage d’anime en temps réel jusqu’en 4k dans mpv avec les modèles Real-ESRGAN compact
- [MangaJaNaiConverterGui](https://github.com/the-database/MangaJaNaiConverterGui) : Interface graphique Windows pour le suréchantillonnage de manga avec les modèles MangaJaNai
- [traiNNer-redux](https://github.com/the-database/traiNNer-redux) : Logiciel pour l’entraînement de modèles de suréchantillonnage

## Remerciements
- [422415](https://github.com/422415) pour une aide significative dans la préparation des jeux de données et un retour continu durant le développement des modèles V1
- Membres du serveur Discord JaNai pour leur aide avec les ressources manga :
    - Alexandros
    - umzi
    - M7MedOo
    - Gnathonic
- Membres du serveur Discord JaNai pour des retours continus sur les modèles bêta :
    - junmittens
    - SOUNDSPHERE BEST GAME
    - marv
    - Big_herooooo
    - avc1657
    - risho
- [traiNNer-redux](https://github.com/joeyballentine/traiNNer-redux)
- [Dataset Destroyer](https://github.com/Kim2091/helpful-scripts/tree/main/Dataset%20Destroyer)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---