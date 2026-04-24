<div align="center" width="100%">
    <img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/upstat.png" width="128" alt="" />
</div>

# Upstat

> herramienta simple y fácil de usar para monitoreo de estado autoalojada

![](https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/dashboard.png)

## 💻 Demo en Vivo

Pruébalo.

Servidor de Demo (Ubicación: Singapur): [https://demo.upstat.com](https://upstat.chamanbudhathoki.com.np/)

Usuario: `demo`
Contraseña: `demodemo`

## ⭐ Características

Necesita más características pero por ahora...

- Monitoreo de tiempo activo para HTTP(s)
- Gráfica de Estado y Latencia
- Notificaciones vía Discord
- Intervalos de 60 segundos
- UI/UX elegante, reactiva y rápida
- Múltiples páginas de estado
- Asignar páginas de estado a dominios específicos
- Gráfica de ping
- Información de certificado
- PWA
- Soporte para bases de datos Sqlite y Postgres

Y docenas de características menores por añadir.

## 🔧 Cómo Instalar

### 🐳 Docker

Para Sqlite

```bash
curl https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose-sqlite.yml -o docker-compose.yml
docker compose up
```
Para Postgres


```bash
curl -O https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose.yml
docker compose up
```

Upstat ahora se está ejecutando en http://localhost:3000

> [!IMPORTANT]
> Asegúrese de cambiar los valores del entorno antes de desplegar.

### 💪🏻 Sin Docker

Requisitos:

- Node.js 14 / 16 / 18 / 20.4
- npm 9
- Golang 1.21+
- Postgres (Opcional)

```shell
cp .sample.env .env
```

```shell
air
cd web && npm run dev
```
## Tecnología utilizada

- React
- Shadcn
- Golang
- Postgres/Sqlite

## 🙌 Contribuciones

¡Doy la bienvenida a las contribuciones! Las contribuciones son lo que hace que la comunidad de código abierto sea un lugar increíble para aprender, inspirar y crear. Cualquier contribución que hagas es **muy apreciada**.

Si tienes una sugerencia que mejore esto, por favor haz un fork del repositorio, realiza los cambios y crea un pull request. También puedes simplemente abrir un issue con la etiqueta "enhancement".
¡No olvides darle una estrella al proyecto! ¡Gracias de nuevo!

1. Haz un fork del proyecto
2. Crea tu rama de característica (`git checkout -b feature/AmazingFeature`)
3. Confirma tus cambios (`git commit -m 'Add some AmazingFeature'`)
4. Envía la rama (`git push origin feature/AmazingFeature`)
5. Abre un Pull Request

## Colaboradores

<a href="https://github.com/chamanbravo/upstat/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=chamanbravo/upstat" />
</a>

## 📄 Licencia

Este proyecto está licenciado bajo la [Licencia MIT](https://opensource.org/license/mit/).

## 🖼 Más capturas de pantalla

Crear un Monitor

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/create.png" width="512" alt="" />

Página del Monitor

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/chart.png" width="512" alt="" />


Settings Page

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/settings.png" width="512" alt="" />

Notifications

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/notifications.png" width="512" alt="" />

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/discord_notification.png" width="512" alt="" />


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-24

---