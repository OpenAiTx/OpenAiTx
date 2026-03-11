# Introduction  
**LOLAutomationTools** est un outil d'extension fonctionnelle pour **League of Legends** ; destiné à aider les joueurs dans certaines situations où ils ne peuvent pas libérer leurs mains ou doivent s'absenter temporairement, en effectuant quelques opérations simples sur le client pour économiser un peu de temps ; le logiciel n'intervient pas excessivement dans la compréhension et le gameplay du joueur, donc certaines fonctions nécessitent toujours une configuration manuelle préalable (comme la configuration des runes du champion), une trop grande contrainte peut engendrer de la lassitude et faire perdre le plaisir du jeu lui-même ; jouez activement et joyeusement, construisons ensemble un environnement harmonieux.  

# Fonctionnalités  
- Sélection de champion  
  - Préréglage de champion  
- Désactivation de champion  
  - Ignorer la sélection d'équipe  
  - Mode de désactivation en groupe  
- Champion aléatoire  
- Prévention de bannissement pour champions  
- Accepter une partie  
  - Acceptation différée de la partie  
- Création de partie  
- Recherche de partie  
  - Détection de dépassement du temps de recherche  
- Fonction d’échange  
  - Échange de champion en mode aléatoire  
    - Ou acceptation passive d’échange de champion par d’autres joueurs  
    - Refuser l’échange de champions non sélectionnés  
  - Échange de position en mode draft  
    - Ou réception passive d’échange de position par d’autres joueurs  
    - Refuser l’échange de positions non préréglées  
  - Échange d’étage en mode draft  
    - Ou acceptation passive d’échange d’étage par d’autres joueurs  
    - Refuser l’échange d’étage non configuré  
- Passer la page d’éloge  
- Passer la page de déverrouillage  
- Contrôle des réponses de chat  
  - Répondre aux messages d’amis en cas d’absence  
  - Répondre aux invitations de partie en cas d’absence  
    - Refuser les invitations de partie en cas d’absence  
- Fenêtre supplémentaire  
  - Affichage du buff d’équilibrage des champions en mode fun  
  - Application automatique des runes  
  - Correction des runes  
  - Configuration indépendante des champions  
- Fermeture automatique de la partie  
- Reconnexion automatique à la partie  
- Réception automatique des récompenses du passe de combat (y compris Teamfight Tactics)
- Gestion des demandes d'amis  
  - Suppression en masse d'amis  
- Carrière personnalisée  
  - Contexte de carrière  
  - Avatar du invocateur  
  - Statut client  
  - Signature de statut  
  - Rang de la carte de visite  
  - Points d'accomplissement des héros  
  - Réinitialiser les médailles portées  
- Blocage des touches fonction  
- Consultation des performances  
  - Envoi des performances  
  - Détection de jeu en équipe dans la partie  
  - Spectateur des parties des joueurs  
  - Signalement des joueurs après la partie  
- Messages dans la partie  
- Liste noire  
- Configuration des raccourcis  
- Paramètres de thème  
  - Thème clair/sombre  
  - Thème adaptatif  
  - Thème personnalisé  
  - Paramétrage de l'image de fond  
  - Personnalisation de la police  
- Fonctionnalités étendues  
  - Sélection automatique des cartes (Maître des cartes)  


## Sélection des héros  
Avant d'utiliser la **sélection des héros** et la **désactivation des héros**, il est nécessaire d'effectuer des modifications dans la page de configuration (bouton à côté de l'interrupteur).  

Les héros ajoutés dans les réglages de voie ne sont effectifs que dans certains modes de jeu avec *emplacements de pré-sélection* (comme *Classement* et *Éclair extrême*), le mode aléatoire ne s'applique que dans le mode *Héros aléatoires* (comme *Bataille arctique*, *Chaos infini*, la configuration des héros désactivés ne contient pas la page de configuration aléatoire), le mode universel s'applique à tous les autres modes (hors modes mentionnés précédemment, ceci pour des raisons de conformité). Lors de l'exécution de la sélection automatique des héros, la sélection sera effectuée selon la configuration de **sélection des héros**, de haut en bas dans l'ordre.  

<img width="900" height="680" alt="image" src="https://github.com/user-attachments/assets/6aa4f1ad-28db-4bd5-a917-df4197024f5f" />  

## Pré-sélection des héros  
La logique d'exécution de cette fonction est essentiellement la même que celle de la **sélection des héros**, la différence étant que la **pré-sélection des héros** ne sera effective que dans les modes comportant une phase de désactivation, tels que *Classement* et certains modes de divertissement nécessitant la désactivation des héros.  

## Désactivation des héros
**La page de configuration des héros désactivés** est essentiellement la même que celle des **héros sélectionnés**, avec en plus un bouton en haut à droite pour changer de mode, permettant de basculer en mode désactivation.

*Mode désactivation normal* : Ce mode fonctionne de la même manière que la page de configuration des **héros sélectionnés** ; lors de l’exécution de la désactivation automatique des héros, si aucun héros n’est configuré pour être désactivé, un ban vide sera effectué lorsque le temps restant à l’étape de ban sera de 0 secondes.

*Mode désactivation en groupe* : Les éléments de la liste de configuration seront remplacés par les héros correspondants dans la configuration des **héros sélectionnés**. En sélectionnant un élément, double-cliquez sur un héros dans la liste de gauche pour l’ajouter au **groupe de désactivation** de ce héros. Lors de l’exécution de la désactivation automatique, les héros seront désactivés dans l’ordre des éléments configurés dans **héros sélectionnés**. Si aucun héros à désactiver n’est configuré dans les **groupes de désactivation** de toutes les configurations des **héros sélectionnés**, la désactivation suivra la logique du mode désactivation normal.

> Si l’option *Ignorer la pré-sélection des coéquipiers* est activée, la détection de la pré-sélection dans l’équipe sera ignorée lors de l’exécution de la désactivation automatique. Il est déconseillé d’activer cette option.

## Accepter la partie  
Accepte automatiquement la partie une fois qu’elle est trouvée.

> Après activation de l’option *Acceptation différée de la partie*, **Accepter la partie** ne se fera automatiquement que dans la dernière seconde du compte à rebours d’acceptation.

## Créer une partie  
Vous pouvez créer manuellement une partie via le bouton **Créer une partie** ou activer ce commutateur pour créer automatiquement une partie.

> *Création automatique de partie* nécessite de choisir le mode de partie à créer dans *Paramètres avancés*, cette option ne sera pas sauvegardée dans la configuration.

## Chercher une partie  
Recherche automatiquement une partie, cette option est active uniquement dans une salle de mode de partie et si vous êtes le leader de l’équipe (hôte).

> Si l’option *Détection de dépassement de temps* est activée, une nouvelle recherche de partie sera automatiquement lancée si le temps dans la file d’attente dépasse l’estimation pendant un intervalle spécifié.

## Passer les compliments  
Ignore la page de compliments des coéquipiers à la fin de la partie.

## Passer le décompte final  
Ignore l’attente de fin de partie (écran noir avec roue de chargement) ou la page de résultats post-partie, et retourne directement dans la salle du mode de partie.

## Fonction d’échange  
Comprend un interrupteur principal et trois interrupteurs indépendants, nécessitant d’autres réglages. Dans les *Paramètres avancés* de la **fonction d’échange**, vous pouvez configurer si vous souhaitez échanger les héros avec vos coéquipiers en mode héros aléatoire, ou échanger l’ordre de sélection (étage) et les positions pré-sélectionnées en mode draft.

*La configuration des échanges de héros et de positions est relativement simple, donc peu détaillée ici.*

<img width="900" height="680" alt="image" src="https://github.com/user-attachments/assets/361b4b19-cd72-4cb3-901f-69d49284bc11" />

Dans les **Paramètres avancés** de **l’échange d’étage**, vous pouvez configurer l’ordre d’échange (c’est-à-dire l’étage) et le mode d’échange.

<img width="900" height="680" alt="image" src="https://github.com/user-attachments/assets/697bed4a-2984-43f6-b747-36c7911ef99d" />

*Mode d’échange* :  
- Ordre cible uniquement : accepter les demandes des coéquipiers dont l’*ordre* correspond à l’*ordre* spécifié.  
- Priorité incluant la cible : accepter les demandes des coéquipiers avec un ordre ≤ à l’*ordre* spécifié.  
- Retard incluant la cible : accepter les demandes des coéquipiers avec un ordre ≥ à l’*ordre* spécifié.  
- Plage basée sur l’ordre cible : accepter les demandes des coéquipiers avec un *ordre* ≤ (*ordre spécifié* - *plage*) et *ordre* ≥ (*ordre spécifié* + *plage*).  

De plus, dans les **autres paramètres**, il existe deux options de refus d’échange qui, si elles sont **activées**, rejettent automatiquement une demande d’échange si le coéquipier ne correspond pas aux conditions définies pour échanger un héros ou une position, **sinon** aucune action n’est effectuée, vous pouvez décider vous-même d’accepter l’échange.  

## Protection contre la désertion lors de la sélection/bannissement  
Une fois activée, cette option exécute la **sélection** ou le **bannissement** du héros à la dernière seconde de la phase BP.  

> Vous pouvez modifier le mode de la fonction **Protection contre la désertion lors de la sélection/bannissement** sur la *page des paramètres de fonctionnalité*.  

## Réponse automatique en cas d’absence  
Cette option est un interrupteur principal, d’autres réglages sont nécessaires. Sur la page de configuration **Plus**, définissez si vous souhaitez répondre automatiquement aux messages d’amis ou aux invitations de parties lors de votre absence (activé par défaut), ainsi que le texte de la réponse.  

<img width="900" height="680" alt="image" src="https://github.com/user-attachments/assets/68f9e16f-7263-4924-954f-8e4f880a4007" />  

## Fenêtre additionnelle  
Une fois activée, la **fenêtre additionnelle** s’affiche à certaines phases du client. De plus, vous pouvez accéder à la **page de configuration** de cette fenêtre additionnelle via le bouton situé derrière cet interrupteur ; vous pouvez aussi consulter les **attributs d’équilibre** des héros dans les modes de jeu divertissants disponibles (le cas échéant), et configurer les runes utilisables pour chaque mode ainsi que les configurations indépendantes du client.  

**Page de configuration de la fenêtre additionnelle**</br>  
<img width="900" height="680" alt="image" src="https://github.com/user-attachments/assets/dd7a6d53-177e-4132-b612-20aaf4a4d2e6" />  
<img width="900" height="680" alt="image" src="https://github.com/user-attachments/assets/7675278c-5ed8-4d0d-9248-d8ef8b07201d" />  

> Pour ajouter ou mettre à jour une configuration de runes sur la **page de configuration des runes**, vous devez d’abord sélectionner et sauvegarder une page de runes dans le client de jeu, sous **Collection - Runes**, puis changer les compétences d’invocateur en haut à droite et cliquer sur le bouton **Ajouter une configuration** ou utiliser le bouton *Mettre à jour la configuration actuelle avec cette configuration* dans la configuration de runes à mettre à jour.  

**Fenêtre additionnelle**</br>  
<img width="388" height="650" alt="image" src="https://github.com/user-attachments/assets/b7a1df40-f496-4c8a-a540-54806fc8d3f4" />  

## Fermeture automatique de la partie  
Simple et direct, ferme automatiquement le processus du jeu à la fin de la partie lors de l’animation de destruction du cristal.  

## Reconnexion automatique à la partie  
Tente une reconnexion automatique lorsque le jeu demande une reconnexion.  

## Sélection automatique des cartes (extension supplémentaire)  
Lorsque le héros utilisé en jeu est le Maître des cartes, les touches Z/X/C sélectionnent automatiquement les cartes bleue/rouge/jaune.  

![pickCards](https://github.com/user-attachments/assets/df5aa45a-8593-44c9-8c3f-bec315552113)
> Cette fonctionnalité utilise le traitement graphique et la simulation clavier, testée uniquement sur les deux résolutions courantes (1920x1080/2560x1440), les autres résolutions ne fonctionnant pas correctement sans configuration personnalisée (en particulier celles hors du ratio 16:9).  
> La détection tolère une certaine plage de filtres, mais il est conseillé de ne pas activer de filtres lors de l'utilisation de cette fonctionnalité afin d'éviter l'invalidité de certaines détections.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-11

---