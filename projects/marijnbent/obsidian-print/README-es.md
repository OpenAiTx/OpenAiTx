# Imprimir

El plugin Imprimir añade herramientas de impresión a tu espacio de trabajo en Obsidian. Puedes imprimir la nota actual, una selección de texto o todas las notas en una carpeta desde la paleta de comandos, el ícono de impresora o el menú contextual. Si te gusta o te resulta útil, considera darle una [estrella ![GitHub Repo stars](https://img.shields.io/github/stars/marijnbent/obsidian-print?style=social)](https://github.com/marijnbent/obsidian-print) en GitHub.

https://github.com/user-attachments/assets/5882f08c-19e6-46da-b808-608b95376979

*Grabación de pantalla del plugin en uso.*

## Características

- **Imprime la nota actual**: Inicia la impresión desde la paleta de comandos, el ícono de impresora o haciendo clic derecho en una nota.
- **Imprime una selección**: Imprime solo el texto seleccionado del editor activo.
- **Imprime todas las notas en una carpeta**: Haz clic derecho en una carpeta o usa la paleta de comandos para imprimir todas las notas markdown en esa carpeta.

También puedes añadir un atajo para la acción de imprimir para un acceso aún más rápido.

| | |
|:------:|:-------------------------:|
|![image](https://github.com/user-attachments/assets/8ba2959c-20a2-4cab-8ae7-c2f5f2475217)|![image](https://github.com/user-attachments/assets/ddb54bd0-4b58-410f-9d69-0f6a58b2ddfd)

## Soporte

Si disfrutas este plugin, por favor apoya mi trabajo y entusiasmo comprándome un café
en [https://www.buymeacoffee.com/marijnbent](https://www.buymeacoffee.com/marijnbent).

<a href="https://www.buymeacoffee.com/marijnbent"><img src="https://img.buymeacoffee.com/button-api/?text=Buy me a coffee&emoji=&slug=marijnbent&button_colour=6495ED&font_colour=ffffff&font_family=Lato&outline_colour=000000&coffee_colour=FFDD00"></a>

## Comenzando

### Instalar desde la Tienda de Plugins Comunitarios

1. Abre Obsidian y ve a **Configuración** > **Plugins comunitarios**.
2. Haz clic en **Explorar** y busca **Imprimir**.
3. Haz clic en **Instalar** para añadir el plugin a tu configuración de Obsidian.
4. Una vez instalado, activa el plugin y opcionalmente ve a la página de configuración.

Si imprimes con frecuencia, probablemente querrás añadir un atajo a uno o más comandos de impresión. Ve a **Configuración** > **Atajos de teclado**, busca `print` y asigna tus atajos preferidos.

## Configuración

- **Imprimir título de la nota**: Incluir el título de la nota en la impresión.  
- **Imprimir propiedades**: Incluir las propiedades/frontmatter de la nota en la parte superior de la nota impresa.  
- **Tamaño de fuente y tamaños de encabezado**: Ajustar el texto del cuerpo y los tamaños de encabezado cuando **Normalizar estilo** esté activado.  
- **Combinar notas de carpeta**: Eliminar los saltos de página entre notas al imprimir todas las notas de una carpeta.  
- **Tratar líneas horizontales como saltos de página**: Interpretar los separadores `---` como saltos de página de impresión.  
- **Modo de depuración**: Abrir una ventana de inspección separada con el HTML y CSS generados para que puedas solucionar problemas de estilo.  
- **Heredar `cssclasses` de la nota**: Aplicar las `cssclasses` de la nota de Obsidian a la salida impresa para que el CSS de impresión específico de la nota se transfiera.  
- **Normalizar estilo**: Usar un estilo de impresión integrado y neutral en lugar de conservar el estilo activo del tema de Obsidian.  
- **CSS personalizado**: En Configuración avanzada, habilitar un fragmento `print.css` desde la carpeta de fragmentos CSS de Obsidian cuando esté disponible.  

![image](https://github.com/user-attachments/assets/2ffed185-cc8f-43d9-8444-7cb9657d61f7)  

## Personalizar CSS  

En la configuración, puedes ocultar opcionalmente el título, y cuando **Normalizar estilo** esté activado también puedes ajustar el tamaño de fuente para el texto del cuerpo y los encabezados.  

Para personalizar aún más la apariencia de tus notas impresas, puedes crear un fragmento `print.css` en `.obsidian/snippets` y habilitarlo desde la configuración del plugin una vez que Obsidian lo detecte. El cuerpo del documento impreso contiene la clase `obsidian-print`. Asegúrate de envolver tu CSS en `@media print` o de prefijar tu CSS específico para impresión con `.obsidian-print` para que solo se aplique al contenido impreso. Si habilitas **Heredar `cssclasses` de la nota**, las clases de Obsidian a nivel de nota también estarán disponibles en la salida impresa. Los estilos del tema para bloques de código y MathJax también se trasladan al documento de impresión cuando es necesario, a menos que actives **Normalizar estilo** para usar el estilo neutral de reserva del plugin. Puedes ver los estilos predeterminados [en este archivo](/styles.css). Cada nota individual contiene la clase `obsidian-print-note`.  

Si tienes problemas con el estilo, activa el Modo de depuración para abrir una ventana de inspección del documento impreso generado.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-08

---