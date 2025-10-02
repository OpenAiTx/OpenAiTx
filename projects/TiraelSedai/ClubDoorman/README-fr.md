## Antispam pour Telegram

Initialement développé pour résoudre le problème des spammeurs dans les chats de Vasstrik.Club, mais peut également être utilisé dans les chats d’autres forks, voire simplement dans n’importe quels grands chats.

### Principe de fonctionnement
- Les utilisateurs du Club avec un bot lié sont automatiquement ajoutés aux utilisateurs de confiance
- Lors de l’événement « utilisateur a rejoint le chat », un simple captcha est délivré
- Si l’utilisateur est déjà dans les utilisateurs de confiance, toutes les vérifications sont ignorées
- Si l’utilisateur figure dans les listes connues de spammeurs - suppression directe
- Si le message contient trop d’emojis - suppression directe
- Si le message contient des mots qui ressemblent à du russe mais comportent des lettres anglaises à l’intérieur - suppression directe. Cet aspect est actuellement surtout optimisé pour les chats russophones et peut déclencher sur des mots normaux dans des langues écrites en cyrillique, mais tous les cas connus sont pour l’instant ajoutés aux tests.
- Si le message contient des mots interdits du type « gagner de l’argent en ligne » - suppression directe
- Ensuite, le message est nettoyé des emojis, de la ponctuation, des diacritiques et analysé par ML. Si ML considère que c’est du spam - suppression directe.
- Si l’utilisateur a envoyé plusieurs messages normaux, il est ajouté aux utilisateurs de confiance - les spammeurs réussissent très rarement à « gagner la confiance » et donnent généralement tout dès le premier ou deuxième message
- Automatiquement, le bot supprime uniquement les messages, les utilisateurs sont bannis uniquement manuellement via l’admin pour réduire les dommages liés aux faux positifs
- - Sauf pour la liste noire. Ceux-ci sont bannis immédiatement, mais cette option peut être désactivée
- Si quelqu’un est banni dans le chat par un autre que le bot, une notification est envoyée à l’admin, il est possible que le bot ait laissé passer du spam et qu’il faille l’ajouter au dataset

### Commandes admin
Toutes les commandes sont appelées en répondant à un autre message
- /spam - ajoute le message au dataset de spam
- /ham - ajoute le message au dataset de non-spam
- /check - passe le message à travers toutes les vérifications

### Configuration
Créer un chat admin, mémoriser l’ID.
Variables d’environnement :
- DOORMAN_BOT_API : Token du bot Telegram. Obligatoire
- DOORMAN_ADMIN_CHAT : ID du chat admin. Obligatoire
- DOORMAN_CLUB_SERVICE_TOKEN : Token de service pour le Club, créé ici : https://vas3k.club/apps/. Si la variable n’est pas définie, l’approbation automatique des personnes du Club est ignorée.
- DOORMAN_CLUB_URL : URL de base pour les forks du Club, par exemple https://rationalanswer.club/
- DOORMAN_BLACKLIST_AUTOBAN_DISABLE : Mettre à true ou 1 pour que le bot ne bannisse pas immédiatement les personnes (hors Club, non approuvées, figurant sur la liste noire) à leur arrivée
- DOORMAN_LOW_CONFIDENCE_HAM_ENABLE : Mettre à true ou 1 pour envoyer à l’admin le non-spam avec un score de confiance faible, utile pour les chats où les spammeurs testent constamment la robustesse du ML
- DOORMAN_CHANNELS_AUTOBAN_DISABLE : Mettre à true ou 1 pour que le bot ne bannisse pas les messages au nom des chaînes (sauf celles liées au groupe actuel)
- DOORMAN_APPROVE_BUTTON : Mettre à true ou 1 pour ajouter à chaque message supprimé une option « c’est un habitué, un ami »
- DOORMAN_LOOKALIKE_AUTOBAN_DISABLE : Mettre à true ou 1 pour que le bot ne bannisse pas les messages contenant des mots ressemblant à du russe
- DOORMAN_BUTTON_AUTOBAN_DISABLE : Mettre à true ou 1 pour que le bot ne bannisse pas les messages contenant des boutons
- DOORMAN_HIGH_CONFIDENCE_AUTOBAN_DISABLE : Mettre à true ou 1 pour que le bot ne bannisse pas les messages où le classificateur ML est assez sûr du spam
- DOORMAN_CHANNEL_AUTOBAN_EXCLUSION : Groupes séparés par des virgules dans lesquels les chaînes ne sont pas bannies

#### Merci
- https://lols.bot/ pour la lutte contre les spammeurs et l'API pour les listes de bannissement
- https://github.com/umputun/tg-spam/ pour certaines idées et les trois quarts du jeu de données

### Traduction
Si vous êtes prêt à faire le travail difficile de traduire tous les textes de ce bot dans d'autres langues, veuillez me le faire savoir avant de vous lancer tête baissée et de créer une PR.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-02

---