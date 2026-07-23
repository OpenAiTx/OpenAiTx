# jerry-list

Une liste de mots sélectionnée, construite et affinée grâce à la chasse aux bugs en conditions réelles. Il s'agit de ma collection personnelle que j'ai utilisée en privé depuis longtemps et qui est maintenant publiée publiquement pour aider la communauté de la sécurité.

---

## Qu'est-ce que c'est

jerry-list est la liste de mots principale de ce dépôt, couvrant un large éventail de chemins, paramètres, points de terminaison et modèles qui se sont avérés efficaces dans la chasse aux bugs active. Chaque entrée de cette liste a été façonnée par une expérience réelle d'engagement, pas seulement générée automatiquement ou recyclée à partir de sources publiques. C'est la liste qui m'a aidé à obtenir plusieurs découvertes P1 et P2 sur divers programmes.

Une liste privée de DNS est également en préparation. Cette liste est quelque chose sur laquelle je me suis beaucoup appuyé pour découvrir des sous-domaines uniques que la plupart des outils conventionnels et des listes publiques manquent complètement. Elle sera publiée ici une fois nettoyée et prête à être diffusée.

---

## Contenu

| Fichier | Description |
|---|---|
| jerry-list.txt | Liste principale pour le fuzzing de répertoires, chemins et points de terminaison |
| jerry-dns.txt | Liste de sous-domaines DNS — à venir bientôt |

---

## Utilisation

Fonctionne avec tout outil de fuzzing standard. Quelques exemples rapides :

**ffuf**
```bash
ffuf -u https://target.com/FUZZ -w jerry-list.txt -mc 200,301,302,403,500
```

**gobuster**
```bash
gobuster dir -u https://target.com -w jerry-list.txt
```

**subfinder / Brute DNS (une fois la liste DNS obtenue)**
```bash
puredns brute target.com -w jerry-dns.txt
```

---

## Résultats

Ces listes de mots ont directement contribué à la découverte de plusieurs vulnérabilités P1 et P2 tout au long de mon parcours en bug bounty. La liste DNS en particulier a été l’un de mes outils les plus constants pour faire émerger des sous-domaines uniques menant à des découvertes à fort impact.

---

## À venir

- jerry-dns.txt — publication privée de la liste de mots DNS
- Liste possible de fuzzing de paramètres basée sur des paramètres réels observés

---

## Contribution

Il s’agit d’une liste personnelle, je n’accepte donc pas les pull requests pour le moment. Si vous trouvez quelque chose d’utile ou découvrez un bug en utilisant cette liste, n’hésitez pas à mettre une étoile ou à me contacter.

---

## Avertissement

Ces listes de mots sont destinées uniquement aux tests de sécurité autorisés et aux programmes de bug bounty. Ne les utilisez que sur des cibles pour lesquelles vous avez une permission explicite de tester. L’auteur ne saurait être tenu responsable de toute mauvaise utilisation.

---

## Auteur

--**Jerry1319**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-23

---