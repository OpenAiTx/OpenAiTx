<div align="center">
  <img width="360" height="112" alt="onigiri" src="https://github.com/user-attachments/assets/eaebfec6-f6df-45b4-a3be-22e2ae97c1e8" />
  <br>
  <br>
  <h3>Onigiri (Beta)</h3>
</div>

<div align="center">
  <img width="400" height="22" alt="Onigiri divider" src="https://github.com/user-attachments/assets/77958660-41fd-4a43-85df-6c17cda02958" />
</div>

Onigiri es un **complemento experimental** que reemplaza la interfaz estándar de Anki con un panel moderno, altamente personalizable y personalizado, transformando completamente la apariencia de Anki, una forma de mantenerte motivado para estudiar tus tarjetas todos los días. 

Onigiri (お握り), también conocido como omusubi (おむすび) o bola de arroz (🍙), es una receta tradicional japonesa rica en carbohidratos, que son esenciales para proporcionar energía, ¡para que puedas estudiar tus tarjetas de Anki! Esta es la intención de Onigiri, darte la motivación adecuada para estudiar tus tarjetas con un hermoso nuevo diseño para Anki (暗記), un carbohidrato extra para darte ese impulso para estudiar. 

### 📝 Filosofía

- **Anki es democrático**: Anki es una herramienta que es usada por todos, desde todos los rincones del mundo, cada usuario debería tener el derecho de adaptarla a sus propias necesidades, con los colores y aspectos que desee. Onigiri ayuda a que Anki sea una experiencia aún más democrática y amigable para el usuario. 
- **Un gran diseño puede motivar**: La motivación puede traer más productividad y motivación para que los estudiantes estudien, visiten la aplicación más a menudo y se sientan atraídos por ella. La investigación ha demostrado que un diseño bien estructurado y fácil de usar puede, de hecho, [cultivar la motivación](https://www.mdpi.com/2414-4088/2/1/6).
- **Predeterminados tranquilos, opciones poderosas**: La experiencia base se mantiene simple. Los controles avanzados son descubiertos, no abrumadores—permitiendo que los usuarios crezcan en complejidad a su propio ritmo.
- **Consistencia con flexibilidad**: Los usuarios pueden cambiar la apariencia sin romper los paradigmas básicos de Anki—tarjetas, revisiones, intervalos—por lo que la memoria muscular sigue funcionando.
&nbsp;

### 🧐 ¿Por qué Onigiri?

Puedes preguntarte "Pero Anki ya funciona bien, ¿por qué debería cambiar?". 
Lo sé, Anki funciona, pero Onigiri ayuda a que se sienta genial usarlo. Al refrescar la interfaz con predeterminados tranquilos, tipografía legible y señales suaves, Onigiri reduce la fricción y aumenta la motivación – para que aparezcas ante tus tarjetas más a menudo, con más energía.

###  🚨 Problemas comunes que podrías encontrar
Si tienes algún problema mientras usas Onigiri, por favor no dudes en publicar un [issue](https://github.com/thepeacemonk/Onigiri/issues), hagamos este complemento lo más fluido posible. Estos son algunos posibles errores que podrías encontrar, estoy trabajando para resolverlos:

- Durante el desarrollo tuve algunos problemas con el formato de tarjetas en el Revisor mientras usaba un fondo de imagen, esto se debe a la interacción de las funciones CSS del complemento y la tarjeta, si notas algo, házmelo saber. 
- Algunas configuraciones requieren que reinicies Anki, así que si hiciste clic en "Guardar" y no pasó nada, probablemente encontraste una configuración que requiere reiniciar. Además, algunas configuraciones solo requieren que hagas una actualización, solo presiona "D" para actualizar el menú principal.
- Este complemento interactúa mal con algunos otros complementos, como Shige's Leaderboard (que no se muestra, ya que tiene una función en conflicto con Onigiri) y The KING of Button Add-ons (algunos colores, fondos o alineaciones de los botones pueden verse diferentes a lo planeado).
- Como cualquier complemento que maneja fondos animados en formatos .gif y .webp, notarás que Anki usa un alto porcentaje de CPU, no te preocupes, esto no es un error, es un problema estructural de Anki y es esperado, esos dos formatos son procesados en la CPU y dado que se renderizan constantemente, toman un porcentaje más alto de CPU.
- Cuando lo descargues, tus complementos externos aparecerán archivados, ve a Configuración -> Menú -> Menú principal y organiza tus "Complementos externos archivados".
- Puede que notes que Onigiri hace que Anki se sienta "lento" debido al Modo de Gamificación, esto es un síntoma de registrar datos mientras estudias, y se considera normal, trabajaré en optimizaciones en futuras actualizaciones.
- Onigiri no funciona con versiones antiguas de Anki, solo con 25.07.5 y 25.09, por favor mantén tu Anki actualizado para una mejor experiencia. 

### 📜 Licencia

Este proyecto está licenciado bajo la `Licencia Pública General Affero GNU v3.0 (AGPL-3.0)`. En resumen: eres libre de usar, estudiar y modificar este código—pero si lo ejecutas como un servicio o distribuyes versiones modificadas, debes poner tu código fuente disponible bajo la misma licencia.

He dedicado mucho tiempo a diseñar y mantener este trabajo. Por favor respeta la licencia y mi esfuerzo:
- No copies partes de este proyecto en productos de código cerrado o comerciales.
- Si construyes sobre él, acredita al original y mantén tus cambios abiertos.
- Si encuentras valor aquí, considera contribuir o apoyar el proyecto.

## Aviso

No afiliado con [Onigiri Anki](https://www.onigiri-anki.com/). No se expresa ni implica ningún respaldo.

Onigiri (este complemento) es un complemento independiente para Anki que personaliza la interfaz de la aplicación. En contraste, [Onigiri Anki](https://www.onigiri-anki.com/) provee una baraja de estudio de japonés con su propio sistema. Estos son productos separados y no están afiliados de ninguna manera. 


### Créditos y Agradecimientos
Los siguientes proyectos y recursos informaron el diseño y desarrollo de este complemento:

- Paletas de colores y temas: [Catppuccin](https://github.com/catppuccin), [Dracula](https://draculatheme.com/), [Rosé Pine](https://rosepinetheme.com/palette/), [Nord](https://www.nordtheme.com/docs/colors-and-palettes), [Solarized](https://ethanschoonover.com/solarized/), [Temas Antinote](https://antinote.io/).
- Inspiración visual y temática: [Mochi Cards](https://mochi.cards/)
- Precedentes de complementos por Shige: [Mejorar ventana principal](https://ankiweb.net/shared/info/911023479), [Reorganizar complementos de inicio](https://ankiweb.net/shared/info/1797615099), [Rediseño de Anki](https://ankiweb.net/shared/info/1959668791) (todos por Shige)
- Guía funcional y de UI: Inspirado en [Review Heatmap](https://ankiweb.net/shared/info/1771074083) (por Glutanamite), [Modern Material Theme](https://ankiweb.net/shared/info/1321246682), y [Coloris](https://github.com/mdbassit/Coloris)

### 🫶 Gratitud

Gracias a la comunidad de **Anki** y [**Ankimon**](https://github.com/h0tp-ftw/ankimon) por enseñarme lo esencial sobre programación y desarrollo de complementos! Un agradecimiento especial a @Ouranos por la ayuda especial identificando errores.

### 💞 Apoya mi trabajo

Estoy lanzando activamente actualizaciones y nuevas funciones. Si mis complementos ayudaron en tus estudios o flujo de trabajo, considera apoyar mi trabajo. Tu contribución mantiene el proyecto mantenido y gratis para todos. Únete a nuestro [Discord](https://discord.gg/ZU9VZHMk3u)

<a href="https://www.buymeacoffee.com/peacemonk">
<img width="30%" height="auto" alt="Cómprame un onigiri" src="https://github.com/user-attachments/assets/2c993906-ccb5-4a75-9235-9b63a8d62252" />
<br>
<br>
</a>

### ⭐ Historial de estrellas en GitHub

[![Gráfico de historial de estrellas](https://api.star-history.com/svg?repos=thepeacemonk/Onigiri&type=date&logscale&legend=top-left)](https://www.star-history.com/#thepeacemonk/Onigiri&type=date&logscale&legend=top-left)

### 🍙 This is Onigiri

<img width="60%" height="auto" alt="1" src="https://github.com/user-attachments/assets/523a7890-d599-4030-80c5-45bf9626ad17" />
<img width="60%" height="auto" alt="2" src="https://github.com/user-attachments/assets/75fa35cb-e74b-402d-880a-0b98a7ce3ce4" />
<img width="60%" height="auto" alt="3" src="https://github.com/user-attachments/assets/44e0627d-2a57-40b5-9e5a-6b237a848f7c" />
<img width="60%" height="auto" alt="4" src="https://github.com/user-attachments/assets/6bddc6d2-2105-40fd-9b89-df86f39732a3" />
<img width="60%" height="auto" alt="5" src="https://github.com/user-attachments/assets/983121f6-6c63-4f5d-9cf0-3491100ed28d" />
<img width="60%" height="auto" alt="6" src="https://github.com/user-attachments/assets/6a907210-1d64-4d3f-986c-6816641a7080" />


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-18

---