# Plugin Meilisearch pour Jellyfin

Un plugin pour Jellyfin qui tente d'améliorer la vitesse de recherche et les résultats en utilisant Meilisearch comme moteur de recherche.

Ce plugin décharge la logique de recherche vers Meilisearch, et modifie la réponse de Jellyfin.

Tant que votre client utilise le point de terminaison `/Items` pour la recherche, il devrait être pris en charge de manière transparente, je suppose.

Inspiré par [JellySearch](https://gitlab.com/DomiStyle/jellysearch).

---

### Utilisation

1. Configurez une instance Meilisearch (peut-être qu’une instance hébergée dans le cloud fonctionnera aussi, mais je ne recommande pas).
2. Ajoutez le dépôt suivant et installez le plugin Meilisearch.
    ```
    https://raw.githubusercontent.com/arnesacnussem/jellyfin-plugin-meilisearch/refs/heads/master/manifest.json
    ```
3. Remplissez l'URL de votre instance Meilisearch dans les paramètres du plugin, et peut-être que la clé API est également requise selon la configuration de votre Meilisearch.  
4. Si vous souhaitez partager une instance Meilisearch entre plusieurs instances Jellyfin, vous pouvez remplir le `Nom de l'Index Meilisearch`, si laissé vide, il utilisera le nom du serveur.  
5. N'oubliez pas de cliquer sur `Enregistrer` et assurez-vous que le statut indique `ok`.  
6. Essayez de taper quelque chose dans la page de recherche.  

    ---  

L'index sera mis à jour lors des événements suivants :  
- Démarrage du serveur  
- Changement de configuration  
- Fin de l'analyse de la bibliothèque  
- Tâche de mise à jour de l'index déclenchée  

---  

### Comment ça fonctionne  

La fonctionnalité principale, qui consiste à modifier la requête de recherche, est réalisée en injectant un [`ActionFilter`](https://learn.microsoft.com/en-us/aspnet/core/mvc/controllers/filters?view=aspnetcore-8.0#action-filters).  
Donc, cela peut ne supporter que quelques versions de Jellyfin. Actuellement, j'utilise `Jellyfin 10.10.0`,  
mais cela devrait fonctionner sur d'autres versions tant que le nom du paramètre requis de l'endpoint `/Items` ne change pas.  

---  
###  

J'ai vu JellySearch, qui est un projet merveilleux, mais je n'aime pas vraiment configurer un proxy inverse ou toute cette complication.  

Donc j'écris ceci, mais cela nécessite toujours une instance Meilisearch.  

À ce jour, seul l'endpoint `/Items` est affecté par ce plugin, mais cela améliore beaucoup ma bibliothèque de 200k éléments.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---