# Una API para recuperar portadas de libros de internet.

Esta es una API sencilla que obtiene imágenes de portadas de libros desde Goodreads. Puedes buscar portadas usando el título y el autor del libro, o su número ISBN. Devuelve una URL directa a la imagen de la portada que puedes usar en tus aplicaciones.

## Documentación

### GET /bookcover

Busca la portada de un libro usando el título del libro y el nombre del autor.

**Parámetros requeridos:**
- `book_title` (string): El título del libro
- `author_name` (string): El nombre del autor del libro

**Ejemplo de solicitud:**
```bash
curl -X GET "https://bookcover.longitood.com/bookcover?book_title=The+Pale+Blue+Dot&author_name=Carl+Sagan"
```
**Respuesta de ejemplo:**

```json
{
  "url": "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1388620656i/55030.jpg"
}
```

### GET /portadadelibro/:isbn

Buscar la portada de un libro usando su número ISBN-13.

**Ejemplo de Solicitud:**
```bash
curl -X GET "https://bookcover.longitood.com/bookcover/978-0345376596"
```
**Respuesta de ejemplo:**

```json
{
  "url": "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1500191671i/61663.jpg"
}
```

## Cómo Funciona

La API obtiene imágenes de portadas de libros de Goodreads usando dos métodos diferentes:

1. **Búsqueda por Título y Autor**
   - Toma el título del libro y el nombre del autor como entrada
   - Busca en Goodreads y encuentra el libro que coincide
   - Extrae la URL de la portada de alta calidad
   - Guarda en caché el resultado para futuras solicitudes más rápidas

2. **Búsqueda por ISBN-13**
   - Acepta un número ISBN de 13 dígitos
   - Realiza una búsqueda directa en Goodreads
   - Devuelve la URL de la portada del libro
   - También guarda en caché los resultados exitosos


La API proporciona mensajes de error claros en formato JSON:
- 400 Solicitud Incorrecta: Parámetros faltantes o ISBN inválido
- 404 No Encontrado: No se encontró ninguna portada coincidente
- Todas las respuestas incluyen encabezados CORS apropiados


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-19

---