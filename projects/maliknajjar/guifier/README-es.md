> ⚠️ **Advertencia:** Este README está ligeramente desactualizado. Las secciones del tutorial pueden no coincidir con Guifier V2. Los documentos actualizados llegarán pronto.

# Guifier

Un conjunto de herramientas front-end interactivo que simplifica datos en JSON, YAML, TOML y XML. Visualiza, edita y realiza manipulaciones de datos en tiempo real. Potencia tus aplicaciones basadas en datos con procesamiento de datos fácil de usar y visualización interactiva.

## Comenzando
### Instalación
Ejecutando este comando en tu proyecto npm, puedes instalar guifier sin esfuerzo.
```bash
npm install guifier
``` 
### Importación

```js
import Guifier from 'guifier'
```
O impórtalo como un CDN agregando esta etiqueta de script a tu página HTML
```html
<script src="https://cdn.jsdelivr.net/npm/guifier/dist/Guifier.js"></script>
```

Puedes especificar una versión así
```html
<script src="https://cdn.jsdelivr.net/npm/guifier@1.0.8/dist/Guifier.js"></script>
```

### Ejemplo Hola mundo
A continuación, encontrarás un ejemplo que demuestra cómo generar una representación HTML basada en los datos que proporcionaste a la clase Guifier.
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
Ofrecemos soporte para exportar datos en cinco formatos: 'json', 'yaml', 'xml', 'toml' y 'js'. Por lo tanto, puede importar sus datos como JSON, realizar las ediciones necesarias y luego exportarlos en el formato deseado, como TOML, YAML, XML u objeto nativo de JavaScript.

Si desea modificar los datos que se muestran en la representación GUI, puede ejecutar el método.


```js
// The first parameter is used to indicate the data format in which you wish to set your data.
guifier.setData('[1,2,3]', 'json')
```

After executing this method, your GUI representation element will be updated to accommodate your new data.

![Example Image](https://guifier.com/images/image_2.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-02

---