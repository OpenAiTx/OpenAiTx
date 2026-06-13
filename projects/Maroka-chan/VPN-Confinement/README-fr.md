

<div align="center" id="user-content-toc">
  <ul style="list-style: none;">
    <summary>
      <h1>⛓️ VPN-Confinement ⛓️</h1>
      <p>Un module NixOS qui vous permet de router le trafic des services systemd via un VPN tout en empêchant les fuites DNS.</p>
    </summary>
  </ul>
</div>

<br />

> [!IMPORTANT]
> Pour "prévenir" les fuites DNS, ce module rend simplement la socket NSCD inaccessible à un service systemd. Cela peut causer d’autres problèmes, et les fuites n’ont été testées que lors de la résolution DNS via UDP. D’autres méthodes de résolution DNS comme DoT et DoH n’ont pas été testées, et le DNS peut fuir de différentes manières, il est donc toujours conseillé de surveiller et de tester vous-même les fuites DNS.

# Installation

## Nix Flake

```nix
{
  inputs = {
    nixpkgs.url = "github:NixOS/nixpkgs/nixos-unstable";
    vpn-confinement.url = "github:Maroka-chan/VPN-Confinement";
  };

  outputs = { self, nixpkgs, vpn-confinement, ... }:
  {
    # Change hostname, system, etc. as needed
    nixosConfigurations.hostname = nixpkgs.lib.nixosSystem {
      system = "x86_64-linux";
      modules = [
        ./configuration.nix
        vpn-confinement.nixosModules.default
      ];
    };
  };
}

```

# Utilisation

## Définir un espace de noms réseau VPN

```nix
vpnNamespaces.<name> = { # The name is limited to 7 characters
  enable = true;
  wireguardConfigFile = <path to secret wireguard config file>;
  accessibleFrom = [
    "<ip or subnet>"
  ];
  portMappings = [{
      from = <port on host>;
      to = <port in VPN network namespace>;
      protocol = "<transport protocol>"; # protocol = "tcp"(default), "udp", or "both"
  }];
  openVPNPorts = [{
    port = <port to access through VPN interface>;
    protocol = "<transport protocol>"; # protocol = "tcp"(default), "udp", or "both"
  }];
};
```

## Ajouter un service systemd au namespace réseau VPN

```nix
systemd.services.<name>.vpnConfinement = {
  enable = true;
  vpnNamespace = "<network namespace name>";
};
```

## Exemple

```nix
# configuration.nix
{ pkgs, lib, config, ... }:
{
  # Define VPN network namespace
  vpnNamespaces.wg = {
    enable = true;
    wireguardConfigFile = /. + "/secrets/wg0.conf";
    accessibleFrom = [
      "192.168.0.0/24"
    ];
    portMappings = [
      { from = 9091; to = 9091; }
    ];
    openVPNPorts = [{
      port = 60729;
      protocol = "both";
    }];
  };

  # Add systemd service to VPN network namespace
  systemd.services.transmission.vpnConfinement = {
    enable = true;
    vpnNamespace = "wg";
  };

  services.transmission = {
    enable = true;
    settings = {
      "rpc-bind-address" = "192.168.15.1"; # Bind RPC/WebUI to VPN network namespace address

      # RPC-whitelist examples
      "rpc-whitelist" = "192.168.15.5"; # Access from default network namespace
      "rpc-whitelist" = "192.168.1.*";  # Access from other machines on specific subnet
      "rpc-whitelist" = "127.0.0.1";    # Access through loopback within VPN network namespace
    };
  };
}
```

> [!NOTE]
> L'accès depuis l'espace de noms réseau par défaut se fait en utilisant l'adresse de l'espace de noms réseau VPN.\
> `curl 192.168.15.1:9091`

Voir toutes les options et leurs descriptions dans le [fichier du module](https://raw.githubusercontent.com/Maroka-chan/VPN-Confinement/master/modules/options.nix).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---