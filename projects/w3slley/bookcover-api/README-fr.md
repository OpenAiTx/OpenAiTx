# Une API pour récupérer les couvertures de livres depuis internet.

Ceci est une API simple qui récupère les images de couvertures de livres depuis Goodreads. Vous pouvez rechercher des couvertures en utilisant soit le titre et l'auteur du livre, soit son numéro ISBN. Elle retourne une URL directe vers l'image de la couverture que vous pouvez utiliser dans vos applications.

## Documentation

### GET /bookcover

Recherchez une couverture de livre en utilisant le titre du livre et le nom de l'auteur.

**Paramètres requis :**
- `book_title` (string) : Le titre du livre
- `author_name` (string) : Le nom de l'auteur du livre

**Exemple de requête :**
```bash
curl -X GET "https://bookcover.longitood.com/bookcover?book_title=The+Pale+Blue+Dot&author_name=Carl+Sagan"
```
**Exemple de réponse :**

```json
{
  "url": "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1388620656i/55030.jpg"
}
```

### GET /bookcover/:isbn

Rechercher une couverture de livre en utilisant son numéro ISBN-13.

**Exemple de requête :**
```bash
curl -X GET "https://bookcover.longitood.com/bookcover/978-0345376596"
```
**Exemple de réponse :**

```json
{
  "url": "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1500191671i/61663.jpg"
}
```

## Comment ça fonctionne

L'API récupère les images de couverture des livres depuis Goodreads en utilisant deux approches différentes :

1. **Recherche par titre et auteur**
   - Prend en entrée le titre du livre et le nom de l'auteur
   - Recherche sur Goodreads et trouve le livre correspondant
   - Extrait l'URL de l'image de couverture haute qualité
   - Met en cache le résultat pour des requêtes futures plus rapides

2. **Recherche par ISBN-13**
   - Accepte un numéro ISBN à 13 chiffres
   - Effectue une recherche directe sur Goodreads
   - Renvoie l'URL de la couverture du livre
   - Met également en cache les résultats réussis


L'API fournit des messages d'erreur clairs au format JSON :
- 400 Bad Request : Paramètres manquants ou ISBN invalide
- 404 Not Found : Aucune couverture de livre correspondante trouvée
- Toutes les réponses incluent les en-têtes CORS appropriés


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-19

---