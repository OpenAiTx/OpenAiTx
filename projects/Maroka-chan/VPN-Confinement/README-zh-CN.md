

<div align="center" id="user-content-toc">
  <ul style="list-style: none;">
    <summary>
      <h1>⛓️ VPN-限制 ⛓️</h1>
      <p>一个 NixOS 模块，允许你将 systemd 服务的流量通过 VPN 路由，同时防止 DNS 泄漏。</p>
    </summary>
  </ul>
</div>

<br />

> [!IMPORTANT]
> 为了“防止”DNS 泄漏，该模块仅仅使 NSCD 套接字对 systemd 服务不可访问。这可能会引发其他问题，且泄漏仅在通过 UDP 解析 DNS 时进行了测试。其他解析 DNS 的方式如 DoT 和 DoH 尚未测试，且 DNS 可能通过其他方式泄漏，因此建议你始终自行监控和测试 DNS 泄漏。

# 安装

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

## 定义 VPN 网络命名空间

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

## 将 systemd 服务添加到 VPN 网络命名空间

```nix
systemd.services.<name>.vpnConfinement = {
  enable = true;
  vpnNamespace = "<network namespace name>";
};
```

## 示例

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
> 从默认网络命名空间访问时使用VPN网络命名空间地址。\
> `curl 192.168.15.1:9091`

请参阅[模块文件](https://raw.githubusercontent.com/Maroka-chan/VPN-Confinement/master/modules/options.nix)中的所有选项及其描述。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---