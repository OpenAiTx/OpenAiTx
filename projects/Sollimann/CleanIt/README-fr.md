<h1 align="center">CleanIt</h1>

[![Build Status](https://github.com/Sollimann/CleanIt/actions/workflows/rust-ci.yml/badge.svg)](https://github.com/Sollimann/CleanIt/actions)
[![codecov](https://codecov.io/gh/Sollimann/CleanIt/branch/main/graph/badge.svg?token=EY3JRZN71M)](https://codecov.io/gh/Sollimann/CleanIt)
[![minimum rustc 1.45](https://img.shields.io/badge/rustc-1.45+-blue.svg)](https://rust-lang.github.io/rfcs/2495-min-rust-version.html)
[![version](https://img.shields.io/badge/version-1.0.0-blue)](https://GitHub.com/Sollimann/CleanIt/releases/)
[![Maintenance](https://img.shields.io/badge/Maintained%3F-yes-green.svg)](https://GitHub.com/Sollimann/CleanIt/graphs/commit-activity)
[![GitHub pull-requests](https://img.shields.io/github/issues-pr/Sollimann/CleanIt.svg)](https://GitHub.com/Sollimann/CleanIt/pulls)
[![GitHub pull-requests closed](https://img.shields.io/github/issues-pr-closed/Sollimann/CleanIt.svg)](https://GitHub.com/Sollimann/CleanIt/pulls)
![ViewCount](https://views.whatilearened.today/views/github/Sollimann/CleanIt.svg)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

<p align="center">
    <em>Logiciel d'autonomie open-source en Rust-lang avec gRPC pour les aspirateurs robots de la série Roomba</em>
</p>

<p align="center">
  <img src="https://github.com/Sollimann/CleanIt/blob/main/resources/gifs/roomba.gif">
</p>

## Motivation

La motivation est de construire un logiciel d'autonomie complet en DIY à partir de zéro (planification de mouvement, guidage et contrôle du mouvement, SLAM, contrôle de mission, visualisation 2D/3D, etc.) avec un flux de communication client-serveur en temps réel utilisant gRPC asynchrone pour l'intercommunication et le calcul distribué.

La partie SLAM est en cours de réalisation ici : https://github.com/Sollimann/Occupancy-Grid-FastSLAM/tree/main

## Les contributions sont les bienvenues !

Souhaitez-vous contribuer par du travail et/ou des idées ? N'hésitez pas à consulter le [Project Backlog](https://github.com/Sollimann/CleanIt/projects)

## Exécuter le client Roomba et l'API

#### Exécuter le serveur

```
$ cargo run --bin streaming-server
```
#### Exécuter le client


```
$ cargo run --bin roomba-client
```

## Structure
 
#### Organisation du projet
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
 
#### Disposition de la caisse/du paquet
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

## Prérequis

### *Logiciel*

#### _Linux_
```bash
$ [sudo] apt-get install libudev-dev pkg-config
```

La permission d’utilisateur série est requise pour se connecter à Create via le port série. Vous pouvez ajouter votre utilisateur au groupe dialout pour obtenir cette permission :

```bash
$ [sudo] usermod -a -G dialout $USER
```

Déconnectez-vous puis reconnectez-vous pour que cela prenne effet.
##### _MacOs_
```bash
$ brew install *TODO*
```

### *Matériel*
 - iRobot Create 2 (ou iRobot Roomba série 6xx avec câble USB série - https://store.irobot.com/en_US/parts-and-accessories/create-accessories/communication-cable-for-create-2/4466502.html )
 - Raspberry Pi 4 (4 Go)
 - Caméra de profondeur Intel RealSense D435 ou D435i
 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-03

---