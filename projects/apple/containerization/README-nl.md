# Containerization

Het Containerization-pakket stelt applicaties in staat Linux-containers te gebruiken.  
Containerization is geschreven in [Swift](https://www.swift.org) en maakt gebruik van [Virtualization.framework](https://developer.apple.com/documentation/virtualization) op Apple silicon.

Containerization biedt API's om:

- [OCI-images te beheren](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/).
- [Te communiceren met externe registries](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/Client/).
- [ext4-bestandssystemen te creëren en te vullen](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationEXT4/).
- [Te communiceren met de Netlink socket-familie](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationNetlink/).
- [Een geoptimaliseerde Linux-kernel te creëren voor snelle opstarttijden](https://raw.githubusercontent.com/apple/containerization/main/kernel/).
- [Lichte virtuele machines te starten en de runtime-omgeving te beheren](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxContainer.swift).
- [Gecontaineriseerde processen te starten en ermee te communiceren](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxProcess.swift).
- Rosetta 2 te gebruiken voor het draaien van linux/amd64-containers op Apple silicon.

Bekijk de [API-documentatie](https://apple.github.io/containerization/documentation/) voor informatie over de Swift-pakketten die Containerization biedt.

## Ontwerp

Containerization voert elke Linux-container uit binnen zijn eigen lichte virtuele machine. Clients kunnen voor elke container een toegewijd IP-adres aanmaken, waardoor individuele poortdoorschakeling overbodig wordt. Containers bereiken sub-seconde starttijden dankzij een geoptimaliseerde [Linux-kernelconfiguratie](https://raw.githubusercontent.com/apple/containerization/main/kernel) en een minimaal root-bestandssysteem met een lichtgewicht init-systeem.

[vminitd](https://raw.githubusercontent.com/apple/containerization/main/vminitd) is een klein init-systeem, dat een subproject binnen Containerization is.  
`vminitd` wordt gestart als het initiële proces binnen de virtuele machine en biedt een GRPC API via vsock.  
De API maakt het mogelijk de runtime-omgeving te configureren en gecontaineriseerde processen te starten.  
`vminitd` verzorgt I/O, signalen en events voor het oproepende proces wanneer een proces wordt uitgevoerd.

## Vereisten

Je hebt een Apple silicon Mac nodig om Containerization te bouwen en uit te voeren.

Om het Containerization-pakket te bouwen, heeft je systeem het volgende nodig:

- macOS 15 of nieuwer en Xcode 26 beta  
- macOS 26 beta of nieuwer

Applicaties die met het pakket zijn gebouwd, draaien op macOS 15 of later, maar de volgende functies zijn niet beschikbaar op macOS 15:

- Niet-geïsoleerde container-netwerken - met macOS 15 kunnen containers op hetzelfde vmnet-netwerk niet met elkaar communiceren

## Voorbeeldgebruik

Voor voorbeelden van het gebruik van sommige bibliotheken is de cctl uitvoerbare file een goed startpunt. Deze tool dient primair als een speelveld om de API uit te proberen. Het bevat commando's die enkele kernfunctionaliteiten van de verschillende onderdelen testen, zoals:

1. [OCI-images manipuleren](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/ImageCommand.swift)  
2. [Inloggen op container-registries](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/LoginCommand.swift)  
3. [Root-bestandssysteemblokken creëren](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RootfsCommand.swift)  
4. [Eenvoudige Linux-containers draaien](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RunCommand.swift)  

## Linux-kernel

Een Linux-kernel is vereist om lichte virtuele machines te starten op macOS.  
Containerization biedt een geoptimaliseerde kernelconfiguratie in de [kernel](https://raw.githubusercontent.com/apple/containerization/main/kernel) map.

Deze map bevat een gecontaineriseerde build-omgeving om eenvoudig een kernel te compileren voor gebruik met Containerization.

De kernelconfiguratie bevat een minimale set functies om snelle starttijden en een lichte omgeving te ondersteunen.

Hoewel deze configuratie voor de meeste workloads werkt, begrijpen we dat sommige workloads extra functies nodig hebben.  
Om dit op te lossen biedt Containerization first-class API's om verschillende kernelconfiguraties en versies per container te gebruiken.  
Dit stelt containers in staat ontwikkeld en gevalideerd te worden op verschillende kernelversies.

Zie de [README](https://raw.githubusercontent.com/apple/containerization/main/kernel/README.md) in de kernelmap voor instructies over het compileren van de geoptimaliseerde kernel.

### Vooraf gebouwde kernel

Als je een vooraf gebouwde kernel wilt gebruiken, moet deze `VIRTIO`-drivers in de kernel bevatten, niet als modules.

Het [Kata Containers](https://github.com/kata-containers/kata-containers) project biedt een geoptimaliseerde kernel voor containers met alle vereiste configuratie-opties ingeschakeld, beschikbaar op de [releases](https://github.com/kata-containers/kata-containers/releases/) pagina.

Een kernel-image genaamd `vmlinux.container` is te vinden in de `/opt/kata/share/kata-containers/` map van de release-artifacts.

## Voorbereiden om het pakket te bouwen

Installeer Swiftly, [Swift](https://www.swift.org) en [Static Linux SDK](https://www.swift.org/documentation/articles/static-linux-getting-started.html):

```bash
make cross-prep
```

Als je een aangepaste terminalapplicatie gebruikt, moet je deze opdracht mogelijk verplaatsen van `.zprofile` naar `.zshrc` (vervang `<USERNAME>`):

```bash
# Toegevoegd door swiftly
. "/Users/<USERNAME>/.swiftly/env.sh"
```

Herstart de terminalapplicatie. Controleer of dit commando `/Users/<USERNAME>/.swiftly/bin/swift` retourneert (vervang `<USERNAME>`):

```bash
which swift
```

Als je eerder een Static Linux SDK hebt geïnstalleerd of gebruikt, moet je mogelijk oudere SDK-versies van het systeem verwijderen (vervang `<SDK-ID>`):

```bash
swift sdk list
swift sdk remove <SDK-ID>
```

## Het pakket bouwen

Bouw Containerization vanuit de broncode:

```bash
make all
```

## Het pakket testen

Na het bouwen, voer basistests en integratietests uit:

```bash
make test integration
```

Een kernel is vereist om integratietests uit te voeren.  
Als je lokaal geen kernel hebt, kan een standaardkernel worden opgehaald met de `make fetch-default-kernel` target.

Het ophalen van de standaardkernel hoeft alleen na een initiële build of na een `make clean`.

```bash
make fetch-default-kernel
make all test integration
```

## Protobufs

Containerization is afhankelijk van specifieke versies van `grpc-swift` en `swift-protobuf`. Je kunt deze installeren en RPC-interfaces opnieuw genereren met:

```bash
make protos
```

## Documentatie

Genereer de API-documentatie voor lokaal gebruik met:

```bash
make docs
make serve-docs
```

Bekijk de documentatie door in een andere terminal te runnen:

```bash
open http://localhost:8000/documentation/
```

## Bijdragen

Bijdragen aan Containerization worden gewaardeerd en aangemoedigd. Zie [CONTRIBUTING.md](https://raw.githubusercontent.com/apple/containerization/main/CONTRIBUTING.md) voor meer informatie.

## Projectstatus

Versie 0.1.0 is de eerste officiële release van Containerization. Eerdere versies bieden geen garantie op bronstabiliteit.

Omdat de Containerization-bibliotheek actief in ontwikkeling is, wordt bronstabiliteit alleen gegarandeerd binnen minor-versies (bijv. tussen 0.1.1 en 0.1.2). Als je geen mogelijk bronbrekende pakketupdates wilt, kun je je pakketafhankelijkheid specificeren met .upToNextMinorVersion(from: "0.1.0").

Toekomstige minor-versies van het pakket kunnen deze regels naar behoefte wijzigen.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---