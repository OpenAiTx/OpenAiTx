# Plugin Meilisearch para Jellyfin

Un plugin para Jellyfin que intenta mejorar la velocidad de búsqueda y los resultados utilizando Meilisearch como motor de búsqueda.

Este plugin descarga la lógica de búsqueda a Meilisearch y modifica la respuesta de Jellyfin.

Mientras tu cliente use el endpoint `/Items` para la búsqueda, debería ser compatible sin problemas, supongo.

Inspirado por [JellySearch](https://gitlab.com/DomiStyle/jellysearch).

---

### Uso

1. Configura una instancia de Meilisearch (quizás una alojada en la nube también funcione, pero no lo recomiendo).
2. Añade el siguiente repositorio e instala el plugin de Meilisearch.
    ```
    https://raw.githubusercontent.com/arnesacnussem/jellyfin-plugin-meilisearch/refs/heads/master/manifest.json
    ```
3. Rellene la URL de su instancia de Meilisearch en la configuración del plugin, y tal vez también se requiera la clave API según la configuración de su Meilisearch.  
4. Si desea compartir una instancia de Meilisearch entre múltiples instancias de Jellyfin, puede rellenar el `Nombre del Índice de Meilisearch`; si lo deja vacío, usará el nombre del servidor.  
5. Recuerde hacer clic en `Guardar` y asegúrese de que el estado informe `ok`.  
6. Intente escribir algo en la página de búsqueda.  

    ---  

El índice se actualizará en los siguientes eventos:  
- Inicio del servidor  
- Cambio de configuración  
- Escaneo completo de la biblioteca  
- Tarea de actualización de índice activada  

---  

### Cómo funciona  

La función principal, que es modificar la solicitud de búsqueda, se realiza inyectando un [`ActionFilter`](https://learn.microsoft.com/en-us/aspnet/core/mvc/controllers/filters?view=aspnetcore-8.0#action-filters).  
Por lo tanto, puede que solo sea compatible con algunas versiones de Jellyfin. En este momento estoy usando `Jellyfin 10.10.0`,  
pero debería funcionar en otras versiones siempre que no cambie el nombre del parámetro requerido del endpoint `/Items`.  

---  
###  

He visto JellySearch, que es un proyecto maravilloso, pero realmente no me gusta configurar un proxy inverso ni toda esa complicación.  

Así que estoy escribiendo esto, pero aún requiere una instancia de Meilisearch.  

En este momento, solo el endpoint `/Items` se ve afectado por este plugin, pero aún así mejora mucho en mi biblioteca de 200k ítems.  



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---