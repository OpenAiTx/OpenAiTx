![Imagen de banner](https://user-images.githubusercontent.com/10284570/173569848-c624317f-42b1-45a6-ab09-f0ea3c247648.png)

# n8n - Automatización de Flujos de Trabajo Segura para Equipos Técnicos

n8n es una plataforma de automatización de flujos de trabajo que ofrece a los equipos técnicos la flexibilidad del código con la rapidez del no-code. Con más de 400 integraciones, capacidades nativas de IA y una licencia fair-code, n8n te permite crear potentes automatizaciones manteniendo el control total sobre tus datos y despliegues.

![n8n.io - Captura de pantalla](https://raw.githubusercontent.com/n8n-io/n8n/master/assets/n8n-screenshot-readme.png)

## Capacidades Clave

- **Código Cuando Lo Necesites**: Escribe en JavaScript/Python, añade paquetes npm o utiliza la interfaz visual
- **Plataforma Nativa en IA**: Crea flujos de trabajo de agentes de IA basados en LangChain con tus propios datos y modelos
- **Control Total**: Alojamiento propio con nuestra licencia fair-code o usa nuestra [oferta en la nube](https://app.n8n.cloud/login)
- **Preparado para Empresas**: Permisos avanzados, SSO y despliegues aislados (air-gapped)
- **Comunidad Activa**: Más de 400 integraciones y más de 900 [plantillas](https://n8n.io/workflows) listas para usar

## Inicio Rápido

Prueba n8n al instante con [npx](https://docs.n8n.io/hosting/installation/npm/) (requiere [Node.js](https://nodejs.org/en/)):

```
npx n8n
```

O despliega con [Docker](https://docs.n8n.io/hosting/installation/docker/):

```
docker volume create n8n_data
docker run -it --rm --name n8n -p 5678:5678 -v n8n_data:/home/node/.n8n docker.n8n.io/n8nio/n8n
```

Accede al editor en http://localhost:5678

## Recursos

- 📚 [Documentación](https://docs.n8n.io)
- 🔧 [400+ Integraciones](https://n8n.io/integrations)
- 💡 [Flujos de Trabajo de Ejemplo](https://n8n.io/workflows)
- 🤖 [Guía de IA & LangChain](https://docs.n8n.io/langchain/)
- 👥 [Foro de la Comunidad](https://community.n8n.io)
- 📖 [Tutoriales de la Comunidad](https://community.n8n.io/c/tutorials/28)

## Soporte

¿Necesitas ayuda? Nuestro foro de la comunidad es el lugar para obtener soporte y conectar con otros usuarios:
[community.n8n.io](https://community.n8n.io)

## Licencia

n8n es [fair-code](https://faircode.io) distribuido bajo la [Sustainable Use License](https://github.com/n8n-io/n8n/blob/master/LICENSE.md) y la [Licencia Empresarial de n8n](https://github.com/n8n-io/n8n/blob/master/LICENSE_EE.md).

- **Código Fuente Disponible**: Código fuente siempre visible
- **Autoalojable**: Despliega en cualquier lugar
- **Extensible**: Añade tus propios nodos y funcionalidades

[Licencias empresariales](mailto:license@n8n.io) disponibles para características y soporte adicionales.

Puedes encontrar información adicional sobre el modelo de licencia en la [documentación](https://docs.n8n.io/reference/license/).

## Contribuir

¿Encontraste un error 🐛 o tienes una idea para una función ✨? Consulta nuestra [Guía de Contribución](https://github.com/n8n-io/n8n/blob/master/CONTRIBUTING.md) para comenzar.

## Únete al Equipo

¿Quieres dar forma al futuro de la automatización? Revisa nuestras [ofertas de trabajo](https://n8n.io/careers) y únete a nuestro equipo.

## ¿Qué significa n8n?

**Respuesta corta:** Significa "nodemation" y se pronuncia como n-ocho-n.

**Respuesta larga:** "Me hacen esa pregunta bastante a menudo (más de lo que esperaba), así que decidí que probablemente lo mejor sería responderla aquí. Mientras buscaba un buen nombre para el proyecto con un dominio libre, me di cuenta muy rápido de que todos los buenos que se me ocurrían ya estaban tomados. Así que, al final, elegí nodemation. 'node-' en el sentido de que usa una Vista de Nodos y que utiliza Node.js y '-mation' por 'automation', que es para lo que se supone que ayuda el proyecto. Sin embargo, no me gustaba lo largo que era el nombre y no podía imaginarme escribiendo algo tan largo cada vez en la CLI. Ahí fue cuando terminé en 'n8n'." - **Jan Oberhauser, Fundador y CEO, n8n.io**

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---