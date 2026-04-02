> ⚠️ **Avertissement :** Ce README est légèrement obsolète. Les sections du tutoriel peuvent ne pas correspondre à Guifier V2. Des documents mis à jour arrivent bientôt.

# Guifier

Une boîte à outils frontale interactive simplifiant les données JSON, YAML, TOML et XML. Visualisez, modifiez et effectuez des manipulations de données en temps réel. Donnez du pouvoir à vos applications basées sur les données grâce à un traitement convivial des données et une visualisation interactive.

## Pour commencer
### Installation
En exécutant cette commande dans votre projet npm, vous pouvez installer guifier sans effort.
```bash
npm install guifier
``` 

### Importation
```js
import Guifier from 'guifier'
```
Ou importez-le en tant que CDN en ajoutant cette balise script à votre page HTML
```html
<script src="https://cdn.jsdelivr.net/npm/guifier/dist/Guifier.js"></script>
```
Vous pouvez spécifier une version comme ceci

```html
<script src="https://cdn.jsdelivr.net/npm/guifier@1.0.8/dist/Guifier.js"></script>
```

### Exemple Bonjour le monde
Ci-dessous, vous trouverez un exemple démontrant comment générer une représentation HTML basée sur les données que vous avez fournies à la classe Guifier.
```js
const jsonString = '{
  "name": "Alice",
  "age": 25,
  "isStudent": true,
  "hobbies": ["reading", "painting"],
  "address": {
    "city": "London",
    "zipcode": "SW1A 1AA",
    "country": "United Kingdom"
  }
}'

const params = {
    // To select a container element, you can use a selector
    // such as a hashtag followed by the element's id (similar to CSS selectors).
    elementSelector: '#app',
    // Here, you need to specify the JSON string.
    data: jsonString,
    // You should specify the data type (in this case, JSON)
    // as Guifier supports five data formats: 'json', 'yaml', 'xml', 'toml' and 'js' (javascipt object).
    dataType: 'json'
}

const guifier = new Guifier(params)
```

That's it! When you execute this code, it will parse your data, generate an HTML GUI, and paste it into the element you selected using the elementSelector property of the params.

![Example Image](https://guifier.com/images/image_1.png)

This GUI will allow you to visualize and edit your JSON data easily. Once you've made the necessary modifications, you can obtain the edited version of your JSON data simply by executing this Guifier method.

```js
// The first parameter is used to indicate the data format in which you wish to receive your data.
const editedData = guifier.getData('json')
```

Nous offrons un support pour l'exportation des données dans cinq formats : 'json', 'yaml', 'xml', 'toml' et 'js'. Par conséquent, vous pouvez importer vos données au format JSON, effectuer les modifications nécessaires, puis les exporter dans le format souhaité, tel que TOML, YAML, XML ou objet javascript natif.

Si vous souhaitez modifier les données affichées dans la représentation GUI, vous pouvez exécuter la méthode.

```js
// The first parameter is used to indicate the data format in which you wish to set your data.
guifier.setData('[1,2,3]', 'json')
```

After executing this method, your GUI representation element will be updated to accommodate your new data.

![Example Image](https://guifier.com/images/image_2.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-02

---