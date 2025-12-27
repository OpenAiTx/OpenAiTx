![preview](https://github.com/user-attachments/assets/e6762b5a-479a-4261-8e5c-e6b5d04344c5)
# Despensa
[![build](https://github.com/imRohan/Pantry/actions/workflows/continuous_integration.yml/badge.svg)](https://github.com/imRohan/Pantry/actions/workflows/continuous_integration.yml)
![Maintainability](https://api.codeclimate.com/v1/badges/8f1460270ced1f60744c/maintainability)
![Issues Open](https://img.shields.io/github/issues/imrohan/Pantry?&logo=github)
![Issues Closed](https://img.shields.io/github/issues-closed-raw/imrohan/pantry?color=green&logo=github)
[![Coverage Status](https://coveralls.io/repos/github/imRohan/Pantry/badge.svg?branch=master)](https://coveralls.io/github/imRohan/Pantry?branch=master)

[Pantry](https://getpantry.cloud/) es un servicio gratuito que proporciona almacenamiento de datos perecederos para proyectos pequeños. Los datos se almacenan de forma segura mientras tú y tus usuarios los necesiten y se eliminan tras un período de inactividad. Simplemente usa la API RESTful para enviar objetos JSON y nosotros nos encargaremos del resto.

Fue creado para ofrecer una solución de almacenamiento simple y reutilizable para proyectos de tamaño pequeño. Fue creado por desarrolladores para desarrolladores, para estar disponible cuando lo necesites y ayudarte a prototipar rápidamente tu próximo proyecto.

## Desarrollo

#### Clonar el repositorio
`git clone https://github.com/imRohan/Pantry.git && cd Pantry`

#### Instalar dependencias
`yarn`

#### Instalar Redis
Necesitarás instalar Redis (v^6.2.0) en tu máquina y tener el servidor funcionando
usando su configuración predeterminada

#### Crear y editar un `.env` y `config.ts`
`cp env.sample .env`
`cp src/app/config.dev.ts src/app/config.ts`

#### Construir los assets del frontend y ejecutar el servidor (puerto por defecto 3000)

`yarn run dev`

#### Abrir página HTML de ejemplo

Abre `http://localhost:3000/` en el navegador de tu elección


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-27

---