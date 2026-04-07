# Plugin Payload OAuth2

<a href="LICENSE">
  <img src="https://img.shields.io/badge/license-MIT-brightgreen.svg" alt="Licencia de Software" />
</a>
<a href="https://github.com/wilsonle/payload-oauth2/issues">
  <img src="https://img.shields.io/github/issues/wilsonle/payload-oauth2.svg" alt="Problemas" />
</a>
<a href="https://npmjs.org/package/payload-oauth2">
  <img src="https://img.shields.io/npm/v/payload-oauth2.svg?style=flat-squar" alt="NPM" />
</a>

# Características

- ✅ Compatible con Payload v3
- 🔐 Configura OAuth2 con cualquier proveedor
- ✨ Sin dependencias
- ⚙ Altamente personalizable

# Integraciones

Técnicamente este plugin debería funcionar con todos los proveedores genéricos de OAuth2. Aquí está la lista de proveedores que han sido probados:

| Proveedor | Estado                                                                                                                                                                                                      | Ejemplo                         |
| --------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------- |
| Google    | [![Test Google OAuth](https://github.com/WilsonLe/payload-oauth2/actions/workflows/test-google-oauth.yml/badge.svg)](https://github.com/WilsonLe/payload-oauth2/actions/workflows/test-google-oauth.yml)    | [Config](https://raw.githubusercontent.com/WilsonLe/payload-oauth2/main/./examples/google.ts)  |
| Zitadel   | [![Test Zitadel OAuth](https://github.com/WilsonLe/payload-oauth2/actions/workflows/test-zitadel-oauth.yml/badge.svg)](https://github.com/WilsonLe/payload-oauth2/actions/workflows/test-zitadel-oauth.yml) | [Config](https://raw.githubusercontent.com/WilsonLe/payload-oauth2/main/./examples/zitadel.ts) |
| Apple     | Prueba no implementada                                                                                                                                                                                      | [Config](https://raw.githubusercontent.com/WilsonLe/payload-oauth2/main/./examples/apple.ts)   |

# Instalación

```
npm install payload-oauth2
yarn install payload-oauth2
pnpm install payload-oauth2
```
Si te sientes aventurero y quieres gestionar el plugin tú mismo, puedes copiar el directorio `src` en tus proyectos de Payload.

# Contribuir

Las contribuciones y comentarios son muy bienvenidos.

Para ponerlo en marcha:

1. Clona el proyecto.
2. `pnpm install`
3. `pnpm dev`

# Licencia

La Licencia MIT (MIT). Por favor, consulta el [Archivo de Licencia](LICENSE) para más información.

# Créditos

Este paquete fue inspirado por [Payload Plugin OAuth](https://github.com/thgh/payload-plugin-oauth).



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-07

---