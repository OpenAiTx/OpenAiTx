# Shape up downloader

## ¿Qué hace?
Esta es una aplicación CLI simple que descarga el [excelente libro gratuito Shape Up de Basecamp](https://basecamp.com/shapeup)
en un solo archivo HTML autónomo.
* usa imágenes en base64
* usa enlaces internos en el documento
* solo el mínimo indispensable de CSS

## ¿Por qué existe esto?
El libro está actualmente disponible en un formato HTML, donde cada capítulo es un documento, y un documento PDF donde todos
los capítulos están en un solo archivo autónomo. Mientras leía el libro, deseaba una forma de leerlo en mi lector de libros electrónicos,
pero leer PDF en un Kindle es terrible y convertir PDFs a epub o mobi es problemático en el mejor de los casos. El software usado para generar
este PDF en particular combinó algunas combinaciones de caracteres (por ejemplo, "tf") en un solo punto de código UTF-8 con ligaduras. Esto,
sin embargo, confunde a la mayoría del software de conversión.

Por lo tanto, este proyecto nació para descargar y combinar todos los documentos web en un solo archivo autónomo sin estilos.
No se pretende leer el libro en ese formato HTML, pero puede usarse como base para pasos de conversión posteriores.

Para convertir el archivo en formatos más útiles, recomiendo usar la utilidad `ebook-convert` de calibre:
```bash
$ ebook-convert shape-up.html shape-up.epub \
    --authors "Ryan Singer" \
    --title "Shape Up: Stop Running in Circles and Ship Work that Matters" \
    --book-producer "Basecamp" \
    --publisher "Basecamp" \
    --language "en"
```

## ¿Dónde puedo descargar esta versión de una sola página en HTML/EPUB/MOBI?  
No estoy muy seguro sobre las implicaciones legales de alojar estos archivos, por lo que no lo hago.  
El código para descargarlo tú mismo está aquí, pero debes usarlo tú mismo.  

## Uso  
### PHP local  

1. [Instala PHP](https://www.php.net/manual/en/install.php)  
2. [Instala Composer](https://getcomposer.org/download/)  
3. Ejecuta `php composer.phar install` (o `composer install` en caso de que composer esté instalado globalmente)  
4. Ejecuta `php cli.php download:single-html`  

Esto creará un archivo `shape-up.html` en tu directorio actual.  
Eso es todo.  

### Método Docker  

Existe una manera de no lidiar con php en absoluto. Para eso basta con tener instalado el motor de docker.  

Uso
```
docker run -it --rm -v $(pwd)/output:/app/output thej6s/shape-up-downloader

```
Esto creará un archivo `shape-up.html` en el directorio ./output


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-19

---