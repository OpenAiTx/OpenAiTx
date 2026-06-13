

<div align="center" id="user-content-toc">
  <ul style="list-style: none;">
    <summary>
      <h1>⛓️ VPN-Confinement ⛓️</h1>
      <p>Un módulo de NixOS que te permite enrutar el tráfico de servicios systemd a través de una VPN mientras previene fugas de DNS.</p>
    </summary>
  </ul>
</div>

<br />

> [!IMPORTANT]
> Para "prevenir" fugas de DNS, este módulo simplemente hace que el socket NSCD sea inaccesible para un servicio systemd. Esto podría causar otros problemas, y las fugas solo se han probado al resolver DNS sobre UDP. No se han probado otras formas de resolver DNS como DoT y DoH, y el DNS puede fugarse de otras maneras, por lo que siempre se recomienda monitorear y probar las fugas de DNS por ti mismo.

# Instalación

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

# Uso

## Definir el espacio de nombres de red VPN

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

## Añadir servicio systemd al espacio de nombres de red VPN

```nix
systemd.services.<name>.vpnConfinement = {
  enable = true;
  vpnNamespace = "<network namespace name>";
};
```

## Ejemplo

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

> [!NOTA]
> El acceso desde el espacio de nombres de red predeterminado se realiza utilizando la dirección del espacio de nombres de red VPN.\
> `curl 192.168.15.1:9091`

Vea todas las opciones y sus descripciones en el [archivo del módulo](https://raw.githubusercontent.com/Maroka-chan/VPN-Confinement/master/modules/options.nix).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---