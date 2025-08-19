<div align="left">
  <a href="https://github.com/microsoft/dotnet">
    <img src="https://img.shields.io/badge/-.NET-red">
  </a>
  <a href="https://avaloniaui.net/">
    <img src="https://img.shields.io/badge/Avalonia-8245A9">
  </a>
  <a href="https://dotnet.microsoft.com/zh-cn/languages/csharp">
    <img src="https://img.shields.io/badge/-C%23-yellow">
  </a>
  <a href="http://www.gnu.org/licenses/mit.en.html">
    <img src="https://img.shields.io/badge/License-MIT-green">
  </a>
</div>
<br/><br/>

![acss-brand](https://raw.githubusercontent.com/liwuqingxin/Avalonia.Css/main/img/AcssText.svg)

Avalonia Css, o Acss para abreviar, no sigue el CSS estándar (Hojas de Estilo en Cascada). Está diseñado para **separar las definiciones estructurales y visuales** de Avalonia UI y dotar a Avalonia con la capacidad de **modificar estilos dinámicamente y rápidamente**. 

Sí, sigue un patrón similar a **Html+CSS**.

# Promoción

Recientemente descubrí una biblioteca de controles Avalonia que sigue el estilo Ant Design—es impresionantemente bien elaborada. Después de hablar con el desarrollador principal, acordamos apoyarnos mutuamente mediante promoción cruzada. Si estás interesado, no dudes en echarle un vistazo [aquí](https://github.com/chinware/AtomUI).

![](https://github.com/chinware/AtomUI/blob/develop/resources/images/readme/AtomUIOSS.png)


![](https://resources.jetbrains.com/storage/products/company/brand/logos/jb_beam.svg)

Muchas gracias a Jet Brains por [herramientas para desarrolladores gratuitas](https://www.jetbrains.com/community/opensource/?utm_campaign=opensource&utm_content=approved&utm_medium=email&utm_source=newsletter&utm_term=jblogo#support).

# Características

- Separación de Estructura y Estilo
- Reutilización de Estructura
- Carga Dinámica
- Carga en Caliente
- Interceptar y Filtrar
- Extensiones de Comportamiento  
- Extensiones de Sintaxis  
- Depuración de Estilo  
- Dibujo Personalizado  

# Documentación  

La documentación está disponible [aquí](https://docs.en.avalonia.css.nlnet.net/documentation/readme).  Tenga en cuenta que la documentación en inglés está traducida del chino por DeepL. Si tiene algún problema con ella, puede editarla en github.  

> Para la documentación en chino por favor consulte [aquí](https://docs.avalonia.css.nlnet.net/documentation/readme).  

# Uso  

Por favor, vea [aquí](https://docs.en.avalonia.css.nlnet.net/documentation/zhu-ti-bang-zhu/ru-he-shi-yong-acss) para usar Acss.  

# Contribución  

Esperamos que más socios interesados puedan unirse a nosotros en la creación de Acss, haciéndolo más vibrante y capaz.  

Si está interesado en participar o tiene alguna idea, sugerencia o comentario, por favor envíe un correo electrónico a yangqi1990917@163.com.  

# Exhibición  

Proporcionamos un tema Fluent para los controles de Avalonia potenciado por Acss. Para más información sobre el tema, consulte [Acss.Fluent](https://docs.en.avalonia.css.nlnet.net/documentation/zhu-ti-bang-zhu/ru-he-shi-yong-acss.fluent).  

Vea más sobre la exhibición de acss en [bilibili](https://space.bilibili.com/1117754194/channel/seriesdetail?sid=3739599) o [youtube](https://www.youtube.com/channel/UCYvEgvGj-JVYZrOrup3aoBQ).  

<br/>  

![fluent ui](https://raw.githubusercontent.com/liwuqingxin/Avalonia.Css/main/./img/fluent-ui.png)  

# Por Qué Usar Acss  

> Tema = Estructura + Estilos  

Imagine que tenemos una biblioteca estándar de controles, donde la funcionalidad de sus controles depende de la estructura dentro de sus plantillas. Si queremos modificar la apariencia de los controles, usualmente necesitamos reescribir todos los ControlTheme de ellos. Esto significa que tenemos que reescribir la estructura del control y los estilos, incluso los recursos. Es un trabajo doloroso.  

Imagine que con el patrón Acss, extraemos los estilos de los temas estándar de los controles, reteniendo solo la estructura esquelética, el ControlTemplate. Cualquier biblioteca puede basarse en las estructuras estándar, definiendo su propia biblioteca Acss para lograr la apariencia deseada para los controles. Los creadores de esas bibliotecas no necesitan copiar dolorosamente el código existente de ControlTheme para modificaciones. No necesitan preocuparse si la plantilla de control es correcta. ¡Lo único que deben preocuparse es ajustar los estilos según el diseño de la interfaz!  

> El enfoque continuo hace que nuestro trabajo sea más fluido, más elegante y más efectivo.
Otro caso es cuando creamos una nueva página, el flujo de trabajo tradicional generalmente implica diseño, llenado de contenido, escritura de lógica de negocio, ajustes de estilo y afinación basada en el diseño de la interfaz de usuario. Esto suele ser trabajo de un desarrollador, requiriendo atención continua hasta que la página esté terminada. Ahora, con el patrón Acss, el enfoque implicaría que el personal funcional llene el contenido de la página, escriba la lógica de negocio y luego lo entregue a quienes se enfocan en lo visual para armonizar los estilos visuales.

# Paquetes que Proveemos

- **Nlnet.Avalonia.Css**. Este es el núcleo para Acss.

- **Nlnet.Avalonia.Css.Controls**. Esta biblioteca proporciona estructuras puras para los controles de Avalonia.Controls.

- **Nlnet.Avalonia.Css.Fluent**. Esta biblioteca proporciona Fluent UI para Avalonia.Controls, Nlnet.Avalonia.Senior y Nlnet.Avalonia.MessageBox.

- **Nlnet.Avalonia.Css.Behaviors**. Esta biblioteca proporciona comportamientos extendidos para Acss.
- **Nlnet.Avalonia.Senior**. Esta biblioteca ofrece algunas funciones extendidas como **desplazamiento suave** y otras funciones avanzadas que Avalonia.Controls no puede proporcionar.
- **Nlnet.Avalonia.MessageBox**. Esto proporciona un control MessageBox que puede seguir el estándar WPF o el estándar Avalonia.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---