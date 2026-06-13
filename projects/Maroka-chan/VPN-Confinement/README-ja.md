

<div align="center" id="user-content-toc">
  <ul style="list-style: none;">
    <summary>
      <h1>⛓️ VPN-隔離 ⛓️</h1>
      <p>systemdサービスのトラフィックをVPN経由でルーティングし、DNSリークを防止するNixOSモジュールです。</p>
    </summary>
  </ul>
</div>

<br />

> [!IMPORTANT]
> DNSリークを「防止」するために、このモジュールは単純にNSCDソケットへのアクセスをsystemdサービスから遮断します。これにより他の問題が発生する可能性があり、リークはUDP経由のDNS解決時のみテストされています。DoTやDoHなど他のDNS解決方法はテストされておらず、DNSは他の方法でもリークする可能性があるため、常にDNSリークの監視とテストを自身で行うことが推奨されます。

# インストール

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

# 使用方法

## VPNネットワーク名前空間の定義

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

## VPNネットワーク名前空間にsystemdサービスを追加する

```nix
systemd.services.<name>.vpnConfinement = {
  enable = true;
  vpnNamespace = "<network namespace name>";
};
```

## 例

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

> [!注意]
> デフォルトのネットワーク名前空間からのアクセスは、VPNネットワーク名前空間のアドレスを使用して行います。\
> `curl 192.168.15.1:9091`

すべてのオプションとその説明は、[モジュールファイル](https://raw.githubusercontent.com/Maroka-chan/VPN-Confinement/master/modules/options.nix)でご覧いただけます。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---