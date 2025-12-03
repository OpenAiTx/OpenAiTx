<h1 align="center">CleanIt</h1>

[![Estado de compilación](https://github.com/Sollimann/CleanIt/actions/workflows/rust-ci.yml/badge.svg)](https://github.com/Sollimann/CleanIt/actions)
[![codecov](https://codecov.io/gh/Sollimann/CleanIt/branch/main/graph/badge.svg?token=EY3JRZN71M)](https://codecov.io/gh/Sollimann/CleanIt)
[![rustc mínimo 1.45](https://img.shields.io/badge/rustc-1.45+-blue.svg)](https://rust-lang.github.io/rfcs/2495-min-rust-version.html)
[![versión](https://img.shields.io/badge/version-1.0.0-blue)](https://GitHub.com/Sollimann/CleanIt/releases/)
[![Mantenimiento](https://img.shields.io/badge/Maintained%3F-yes-green.svg)](https://GitHub.com/Sollimann/CleanIt/graphs/commit-activity)
[![Solicitudes de extracción en GitHub](https://img.shields.io/github/issues-pr/Sollimann/CleanIt.svg)](https://GitHub.com/Sollimann/CleanIt/pulls)
[![Solicitudes de extracción cerradas en GitHub](https://img.shields.io/github/issues-pr-closed/Sollimann/CleanIt.svg)](https://GitHub.com/Sollimann/CleanIt/pulls)
![Contador de vistas](https://views.whatilearened.today/views/github/Sollimann/CleanIt.svg)
[![Licencia: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

<p align="center">
    <em>Software de autonomía de código abierto en Rust-lang con gRPC para los robots aspiradores de la serie Roomba</em>
</p>

<p align="center">
  <img src="https://github.com/Sollimann/CleanIt/blob/main/resources/gifs/roomba.gif">
</p>

## Motivación

La motivación es construir un software completo de autonomía DIY desde cero (planificación de movimiento, guía y control de movimiento, SLAM, control de misión, visualización 2D/3D, etc.) con una comunicación cliente-servidor en tiempo real usando gRPC asíncrono para la intercomunicación y cómputo distribuido.

La parte de SLAM está en progreso aquí: https://github.com/Sollimann/Occupancy-Grid-FastSLAM/tree/main

## ¡Contribuciones son bienvenidas!

Si te gustaría contribuir con trabajo y/o ideas, no dudes en revisar el [Project Backlog](https://github.com/Sollimann/CleanIt/projects)

## Ejecutar el cliente Roomba y la API

#### Ejecutar el servidor

```
$ cargo run --bin streaming-server
```

#### Ejecutar el cliente

```
$ cargo run --bin roomba-client
```

## Estructura
 
#### Diseño del Proyecto
 ```bash
 ├── Cargo.toml (workspace)
 ├── Cargo.lock
 ├── api (lib/bin)
 |   └── client
 |   └── server
 ├── autonomy (bin)
 |   └── mission
 |   └── motion
 |   └── slam
 |   └── perception
 |   └── risk
 ├── drivers (lib)
 |   └── roomba
 |   └── realsense
 |   └── rplidar
 |   └── raspberryPi
 └── proto (lib)
 |   └── roomba_service.proto
 |   └── messages.proto
 |   └── types.proto
 |   └── robot_state.proto
 |   └── map2D.proto
 ├── setup (bin)
 |   └── config
 |   └── main
 └── visualization (bin)
 |   └── urdf
 |   └── map
 |   └── camera
 ```
 
#### Diseño de caja/paquete
```bash
├── Cargo.toml
├── Cargo.lock
├── src
│   ├── main.rs
│   ├── lib.rs
│   └── bin
│       └── another_executable.rs
├── tests
│   └── some_integration_tests.rs
├── benches
│   └── simple_bench.rs
└── examples
    └── simple_example.rs
```

## Requisitos previos

### *Software*

#### _Linux_
```bash
$ [sudo] apt-get install libudev-dev pkg-config
```

Se requiere permiso de usuario serial para conectar con Create a través del puerto serial. Puedes añadir tu usuario al grupo dialout para obtener permiso:

```bash
$ [sudo] usermod -a -G dialout $USER
```
Cierre sesión y vuelva a iniciar sesión para que esto surta efecto.
##### _MacOs_

```bash
$ brew install *TODO*
```

### *Hardware*
 - iRobot Create 2 (o iRobot Roomba serie 6xx con cable USB serial - https://store.irobot.com/en_US/parts-and-accessories/create-accessories/communication-cable-for-create-2/4466502.html )
 - Raspberry Pi 4 (4GB)
 - Cámara de profundidad Intel RealSense D435 o D435i
 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-03

---