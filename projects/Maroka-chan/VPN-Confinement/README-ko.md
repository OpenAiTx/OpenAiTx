
<div align="center" id="user-content-toc">
  <ul style="list-style: none;">
    <summary>
      <h1>⛓️ VPN-격리 ⛓️</h1>
      <p>시스템 서비스의 트래픽을 VPN을 통해 라우팅하면서 DNS 누출을 방지하는 NixOS 모듈입니다.</p>
    </summary>
  </ul>
</div>

<br />

> [!IMPORTANT]
> DNS 누출을 "방지"하기 위해 이 모듈은 단순히 NSCD 소켓에 대한 접근을 시스템 서비스에서 불가능하게 만듭니다. 이로 인해 다른 문제가 발생할 수 있으며, 누출은 UDP를 통한 DNS 해석 시에만 테스트되었습니다. DoT 및 DoH 같은 다른 DNS 해석 방법은 테스트되지 않았고, DNS는 다른 방식으로도 누출될 수 있으므로 항상 직접 DNS 누출 여부를 모니터링하고 테스트할 것을 권장합니다.

# 설치

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

# 사용법

## VPN 네트워크 네임스페이스 정의하기

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

## VPN 네트워크 네임스페이스에 systemd 서비스 추가

```nix
systemd.services.<name>.vpnConfinement = {
  enable = true;
  vpnNamespace = "<network namespace name>";
};
```

## 예제

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

> [!참고]
> 기본 네트워크 네임스페이스에서의 접근은 VPN 네트워크 네임스페이스 주소를 사용하여 이루어집니다.\
> `curl 192.168.15.1:9091`

모든 옵션과 그 설명은 [모듈 파일](https://raw.githubusercontent.com/Maroka-chan/VPN-Confinement/master/modules/options.nix)에서 확인할 수 있습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---