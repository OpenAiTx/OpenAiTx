<div align="center">

<img src="https://media.giphy.com/media/Pt2yOXUALOhpB5dpiM/giphy.gif" alt="Meteor Devtool Evolved Gif" />

<p style="font-size: 30px">
Extensión Meteor Devtools
</p>
Contempla, la evolución de Meteor DevTools.</p>

Meteor Devtools Evolved está actualmente disponible para Google Chrome y Mozilla Firefox.

</div>

<p align="center" >
    <a href="https://chrome.google.com/webstore/detail/meteor-devtools-evolved/ibniinmoafhgbifjojidlagmggecmpgf">
    <img width="120" src="https://img.shields.io/badge/%20-Chrome-orange?logo=google-chrome&logoColor=white" alt="Descargar para Chrome" />
    </a>
    <a href="https://addons.mozilla.org/en-US/firefox/addon/meteor-devtools-evolved/">
    <img width="110" src="https://img.shields.io/badge/%20-Firefox-red?logo=mozilla&logoColor=white" alt="Descargar para Firefox" />
    </a>
</p>

[Más duro, mejor, más rápido, más fuerte](https://www.youtube.com/watch?v=gAjR4_CbPpQ) :rocket:

¿Estás comenzando con Meteor? ¿Quieres tener una idea de "qué está pasando" o incluso optimizar tu aplicación Meteor? Esta es la herramienta para ti.

:point_right: [Registro de cambios](https://raw.githubusercontent.com/leonardoventurini/meteor-devtools-evolved/development/CHANGELOG.md)

### Protocolo de Datos Distribuidos (DDP)

Todo lo que necesitas para rastrear y entender lo que sucede bajo el capó de tu aplicación Meteor. La extensión te permite filtrar y buscar cualquier mensaje DDP, pudiendo manejar miles y miles de mensajes sin problema alguno.

### Marcadores

La inspección DDP es efímera, pero puedes guardar tantos mensajes DDP como quieras para búsquedas y recuperaciones posteriores, desde cualquier host. Ten cuidado, sin embargo, se guarda en IndexedDB.

### Minimongo

¿No sabes qué datos pertenecen a dónde? Puedes buscar rápidamente cualquier cosa en tus datos de Minimongo y visualizar fácilmente los documentos con nuestro velocísimo Object Treerinator hecho a medida.

---

## Desarrollo

> DESCARGO DE RESPONSABILIDAD: Este trabajo se basa en parte en la extensión [Meteor DevTools](https://github.com/bakery/meteor-devtools) de The Bakery. La cual lamentablemente ya no se mantiene. Aunque no es necesariamente un fork, utilicé algunos conocimientos útiles y decisiones arquitectónicas, y algunas cosas convergieron naturalmente en la misma solución más práctica. De ahí el "evolucionado".

La extensión está casi completamente escrita en TypeScript, dejando fuera algo de código específico de Chrome por razones prácticas. Usa MobX para gestionar el estado, y SASS para sus estilos. También usamos componentes de la biblioteca [Blueprint](https://github.com/palantir/blueprint) de Palantir. Todo está unido con Webpack.

> Cualquiera es bienvenido a contribuir, más información [aquí](https://raw.githubusercontent.com/leonardoventurini/meteor-devtools-evolved/development/CONTRIBUTING.md).

## Firefox

El puerto de la extensión para Firefox fue una contribución hecha por [@nilooy](https://github.com/nilooy). ¡Gracias!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-08

---