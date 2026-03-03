[\[EN-ReadMe\]](https://github.com/Sugobet/API_Sword/blob/main/%5BEN%5D-README.md) <------ veuillez lire ceci  
# WeChat officiel : APT250

## Fidèle au principe de l'open source avant tout et de l'échange d'apprentissage, API Sword sera open source dans deux semaines (après le 7 septembre) et sera également mis en ligne sur le magasin officiel de plugins Burp, BApp Store, pour faciliter les mises à jour et l'utilisation futures. Actuellement, le code est en cours de révision officielle, et il sera bientôt disponible sur le BApp Store.

# [Nouveau plugin classique burp] API Sword - collecte automatique et approfondie des API dans diverses réponses

Le fichier jar est disponible en release, il sera aussi téléchargeable depuis le magasin officiel de plugins Burp après mise en ligne.

## Avant-propos

Ce plugin combine mon travail récent et une partie de mon expérience acquise lors d’un bug bounty de 40 000 dollars sur des failles d’API dans des comptes Microsoft,

Les développeurs d’API Sword ont obtenu plusieurs résultats et des zero-day généraux grâce à cet outil. Depuis que je possède cet outil, je ne cherche plus péniblement manuellement dans aucun JS les interfaces, chemins et paramètres.

![Insérer une description d'image ici](https://i-blog.csdnimg.cn/direct/388ed286aff845ce8863640b37d4636e.png)

Comparé à de nombreux outils populaires comme JS Finder, URLFinder pour l’extraction de js et api, ils sont d’excellents outils, **mais API Sword tire sa force et son avantage des caractéristiques de Burp.**

Capture d’écran de la page principale du plugin :

<img width="3020" height="1582" alt="image" src="https://github.com/user-attachments/assets/e1677009-917b-4e90-a5e8-ccd067263d6e" />

## Fonctionnalités principales d’API Sword

API Sword est entièrement automatique avec prévention des boucles, il extrait les API et fichiers JS dans une plage spécifiée à partir de diverses réponses, puis effectue une extraction récursive en profondeur des API, en initiant activement des requêtes API, JS et autres fichiers utiles.

Le résultat API est WYSIWYG, la fenêtre de droite affiche le JS source de l’API, permettant d’obtenir immédiatement les informations sur les paramètres de l’API depuis le JS, puis Burp peut les tester directement avec Ctrl + R.

Ce n’est pas aussi complexe que l’on pourrait l’imaginer, API Sword réduit surtout pour nous **une grande quantité de recherches répétitives, longues et fastidieuses de js, api et paramètres d’api.**

1. API Sword capture le trafic dans la plage configurée dans Burp et extrait la grande majorité des liens des **réponses HTTP**  
2. API Sword nettoie les liens et chemins extraits, puis **détermine et initie activement des requêtes GET, POST sur les API, JS, etc.**  
3. API Sword traite les réponses des requêtes actives, extrait plus d’informations et répète cette opération, **avec prévention des boucles pour éviter les requêtes infinies**  
4. API Sword envoie toutes les requêtes API, réponses et fichiers JS sources associés dans l’interface Burp d’API Sword  
5. API Sword ajoute automatiquement toutes les requêtes concernées dans le sitemap cible de Burp, **vous pouvez alors pleinement profiter des analyses et fonctionnalités du sitemap avec les résultats d’API Sword**

L’utilisateur doit simplement activer API Sword et définir une « plage raisonnable », puis continuer à naviguer et cliquer sur les diverses fonctionnalités du système web dans le navigateur, en laissant tout le trafic passer par Burp. API Sword analysera et traitera tout cela pour vous fournir le fruit de vos recherches.

**Pour des raisons de sécurité opérationnelle (opsec), API Sword ne fuzz pas activement les paramètres pour l’instant, cette fonctionnalité pourra être ajoutée ultérieurement en option si besoin.**

## Comment utiliser ?

`Remarque : Le plugin doit fonctionner sur BurpSuite version 2024.7 ou supérieure ; (pour les versions inférieures à 2024.7, il faut manuellement désactiver la fonction "Utiliser les en-têtes d'origine" dans la page des paramètres du plugin)`

L'utilisation de l'API Sword est très simple,

1. Installer le plugin sur une version de Burp 2024 ou ultérieure, s'assurer qu'aucune erreur ne survient
2. Définir le périmètre pour le plugin
3. Ouvrir le navigateur en s'assurant que le trafic passe par Burp
4. Naviguer sur le site cible, cliquer et tester tout ce que l'on voit sur le site
5. Après un certain temps, vérifier les résultats dans le Sitemap de l'API Sword

## Configuration de l'API Sword

Dans l'onglet Scope, nous pouvons définir la portée, qui peut être une URL, un domaine ou une IP

<img width="1946" height="1068" alt="image" src="https://github.com/user-attachments/assets/945d1e66-9d1a-4c59-920c-3fadacbeeb4f" />

Cette portée est particulièrement importante, il est conseillé de réfléchir attentivement, sinon vous risquez de scanner à l'extérieur de la cible.

Une fois la portée définie, passons à l'onglet Setting

<img width="3018" height="1338" alt="image" src="https://github.com/user-attachments/assets/4e67c07f-0e37-470c-881e-fa234632d30b" />

1. Autoriser les requêtes actives vers l'API

Cette option est activée par défaut, il est déconseillé de la désactiver, sinon l'API Sword ne pourra pas extraire les données en profondeur

2. Utiliser les en-têtes d'origine

Activé par défaut, si vous souhaitez tester spécifiquement les API non autorisées, vous pouvez désactiver cette option, ce qui empêchera l’envoi de cookies ou sessions

3. Arrêter immédiatement l'envoi de toutes les requêtes

Désactivé par défaut, cette option sert à suspendre en cas d'urgence, il est conseillé de l’utiliser conjointement avec la première option

4. Effacer toutes les données actuelles du SiteMap

Ce bouton sert à supprimer toutes les données des sites dans le Site Map de l'API Sword

![在这里插入图片描述](https://i-blog.csdnimg.cn/direct/d7e8eca0e2994a65b9bae2abb8554e69.png)

5. Activer le taux de requêtes HTTP actives

Limiter l'intervalle entre chaque requête

6. Ajouter un chemin personnalisé supplémentaire lors des requêtes actives

En activant cette option, API Jian ajoutera un chemin personnalisé spécifié avant la concaténation de l'URL principale

7. Filtrer les codes de réponse personnalisés non 200

8. Permettre à API Jian de rechercher activement le baseURL dans la réponse et de concaténer activement le chemin au baseURL

9. Ajouter des champs d'en-tête personnalisés : (écrase automatiquement les champs d'en-tête existants)

10. Activer la contournement des accès aux interfaces dangereuses (l'interface contenant la chaîne sera ignorée)

11. Enregistrer la portée et tous les paramètres

12. Ajouter un chemin personnalisé supplémentaire après l'interface API et avant les paramètres

13. Contrôle du nombre de threads

Autres paramètres en cours de développement et d'amélioration, pour toute idée, suggestion ou problème, vous pouvez faire un retour via les issues sur GitHub

## Remerciements

Merci à `Microsoft`

Merci à mon `mentor de Green Alliance`

Merci à `mil1ln`

Merci à `探姬`

Merci à tous ceux qui ont apporté des conseils précieux et des retours pendant la phase de test d'API Jian

Merci à tous ceux qui ont soutenu API Jian !
## TODO

1. Collecter un polo de la marque Meihua K ⬛️  
2. Ajouter un fuzzing optionnel du chemin base url ✅  
3. Ajouter un filtrage personnalisé des codes de réponse ✅  
4. Ajouter une option de chemin base personnalisé lors des requêtes actives avec API Sword ✅  
5. Optimiser la stratégie de correspondance, débloquant 80% des performances d'API Sword ✅  
6. Optimiser les requêtes actives d'API Sword pour éviter l'accès aux API dangereuses ✅  
7. Résoudre le problème du header par défaut de Burp ne contenant pas le champ CT ✅  
8. Optimiser la largeur des tags dans le tableau des réponses ✅  
9. Corriger le clignotement de l'UI du sitemap ✅  
10. Ajouter une fonctionnalité optionnelle d'en-têtes personnalisés ✅  
11. Ajouter le tri automatique des tags dans la liste des réponses ✅  
12. Optimiser la stratégie de correspondance ✅  
13. Optimiser les blocs de code ⬛️  
14. Enregistrer la gestion de la désinstallation de Burp ✅  
15. Ajouter des commentaires de code bilingues (chinois-anglais) dans tout le code ⬛️  
16. Ajouter une fonction de basculement bilingue dans l'interface graphique ✅  
17. Optimiser les problèmes de blocage et de rendu de Burp causés par l'interface graphique ✅  
18. Ajouter la fonction de sauvegarde des portées et configurations ✅  
19. Ajouter la fonction de taux de requêtes HTTP actives ✅  
20. Ajouter la fonctionnalité multithread ✅  
21. Ajouter une fonction de chemin personnalisé avant les paramètres de l'interface ✅  
22. Correction urgente du dysfonctionnement de la logique anti-boucle causée par le multithreading ✅  
23. Corriger les erreurs d'affichage du tri automatique ✅  
24. Optimiser l'UI de la liste d'API, les flèches directionnelles ne perturbent plus la saisie lors de l'insertion des données ✅  
25. Corriger définitivement le bug de la logique anti-boucle défaillante due au multithreading ✅  
26. Ajouter un filtre ✅  
27. Ajouter les fonctions d'expansion et de repli de tous les nœuds ✅  
28. Optimiser la fonction de nettoyage du sitemap ✅  
29. Optimiser la logique de concaténation JS dans CDN/cross-site en utilisant le referer comme baseUrl ✅  
30. Ajouter une fonction de scan manuel, le scan manuel ajoute automatiquement l'hôte à la liste des portées : clic droit sur un corps de requête dans Burp -> Extensions -> API Sword -> API Scan ✅



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---