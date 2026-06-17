# PicoLoader
Ceci est un modchip basé sur ODE pour la Nintendo GameCube permettant de lancer des homebrews.\
Son prix et ses fonctionnalités sont très similaires à [PicoBoot](https://github.com/webhdx/PicoBoot) mais il offre plusieurs avantages.

Rejoignez le [serveur Discord](https://discord.gg/YtA9aU3BKZ) pour obtenir du support et discuter du mod !

## Comment ça marche ?
Ce mod fonctionne en émulation d’un lecteur de disque au démarrage, en exécutant une application homebrew, puis en réactivant le lecteur de disque.\
Cela est réalisé à l’aide d’un PCB flexible similaire à FlippyDrive.
Cependant, ce n’est pas un émulateur complet de lecteur optique et permet seulement d’exécuter de petites applications homebrew (par exemple [swiss](https://github.com/emukidid/swiss-gc)) depuis la mémoire flash, tout comme PicoBoot.
Pour accéder aux fichiers sur une carte SD, vous avez besoin d’un SDGecko, SD2SP2 ou d’un adaptateur similaire, qui peut être acheté séparément.

## Caractéristiques
- Open source
- Vous pouvez garder le lecteur de disque
- Simple pour démarrer la plupart des homebrews grâce à un [convertisseur en ligne](https://makeo.github.io/PicoLoader/converter/)
- Pas de modifications permanentes à la GameCube
- [Connecteur imprimé en 3D](https://github.com/makeo/PicoLoader/raw/refs/heads/main/mount/Drive_PlugV1.1.stl) pour installations sans lecteur de disque
- Facile à retirer
- Pico fonctionne à 200 MHz pour une meilleure compatibilité avec les cartes clones

#### Variante soudée
- Composants bon marché et faciles à trouver (Raspberry Pi Pico/Pico 2 + PCB flexible + diode)
- Facilement disponible
- Pas de soudure directe sur la GameCube
- Soudure facile
- Options d’installation alternatives : [Panasonic Q](https://github.com/makeo/PicoLoader/wiki/4.-Advanced-Section#panasonic-q-install-option), [profil bas](https://github.com/makeo/PicoLoader/wiki/4.-Advanced-Section#low-profile-install-option)

#### Variante sans soudure
- Pas de soudure
- PCB flexible facilement remplaçable
- Préprogrammé avec le firmware PicoLoader et [Swiss](https://github.com/emukidid/swiss-gc)
> [!TIP]
> Vous pouvez acheter la variante sans soudure et la variante normale sur [store.makstech.io](https://store.makstech.io/).

## Fonctionnalités prévues
*bruit de grillons*

## Installation & Documentation
> [!IMPORTANT]
> Veuillez suivre les [instructions d'installation](https://makeo.github.io/PicoLoader/) dans le wiki.\
> En ne suivant pas les instructions, il y a un risque d'endommager le circuit imprimé flexible lors de l'installation.

Commencez par consulter le 📖[Wiki](https://github.com/makeo/PicoLoader/wiki/1.-Home) !

## Galerie

<div style="display: flex; gap: 10px; flex-wrap: nowrap; justify-content: center;">
  <a href="#"><img style="width: 23%; height: auto;" alt="1" src="https://github.com/user-attachments/assets/9dbe6a59-c3cd-4a4b-9462-4ebc6618a6cf" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="2" src="https://github.com/user-attachments/assets/87efdaf1-e2e6-4f9f-9bec-5a52d9c549fe" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="3" src="https://github.com/user-attachments/assets/02900e41-325a-48d2-bb01-8081845d7696" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="4" src="https://github.com/user-attachments/assets/9d39575d-f7d6-4cbe-b33c-1c6f40ef0f82" /></a>
</div>
<div style="display: flex; gap: 10px; flex-wrap: nowrap; justify-content: center;">
  <a href="#"><img style="width: 23%; height: auto;" alt="1" src="https://github.com/user-attachments/assets/6027feaa-74c6-407d-be00-104c46bffad4" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="2" src="https://github.com/user-attachments/assets/d55b692a-20f6-4cfc-925d-57860416c55e" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="3" src="https://github.com/user-attachments/assets/2b155744-3261-40e2-8d08-9167f2aca5f7" /></a>
  <a href="#"><img style="width: 23%; height: auto;" alt="4" src="https://github.com/user-attachments/assets/85811813-3d21-497a-a214-eda23bb56491" /></a>
</div>

## Remerciements spéciaux
- [silversteel](https://github.com/silverstee1) pour son aide, en particulier pour la fabrication des circuits imprimés flexibles et des supports
- [TeamOffBroadway](https://github.com/OffBroadway) pour l'idée géniale d'utiliser un circuit imprimé flexible pour intercepter les signaux du lecteur
- [Extrems](https://github.com/Extrems), [emukidid](https://github.com/emukidid) et tous ceux impliqués dans la création de Swiss
- [novenary (9ary)](https://github.com/9ary) pour gekkoboot

## Remerciements
La source de [gbi.hdr](https://github.com/makeo/PicoLoader/blob/main/picoloader/data/gbi.hdr) et [gbi_disable_ipl.hdr](https://github.com/makeo/PicoLoader/blob/main/picoloader/data/gbi_disable_ipl.hdr) est sous licence GPL-2.0 et disponible [ici](https://github.com/makeo/cubeboot-tools)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-17

---