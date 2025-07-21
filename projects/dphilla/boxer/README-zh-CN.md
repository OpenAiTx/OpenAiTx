<translate-content># 拳击手

<p align="center">
  <p align="center">
    <a href="https://en.wikipedia.org/wiki/Mia_St._John" target="_blank">
      <img src="https://user-images.githubusercontent.com/20820229/164059786-8d082b44-59d6-431a-adf4-993116c8d492.png" alt="Mia St John" width="300"             height="400">
    </a>
  </p>
</p>

**该项目正在快速开发中**

# 拳击手

## 概述
Boxer 是一个开源项目，旨在通过从传统容器技术转向基于 WebAssembly（Wasm）的分发版，即“盒子”或“Wasm-盒子”，重新构想云计算。

## 动机
虽然容器一直是云计算的基石，提供应用程序的隔离环境，但它们存在显著缺点。容器往往导致部署体积大、效率低、启动时间慢，并且高度依赖底层操作系统/内核的安全性，这可能引入漏洞和平台锁定。

## 解决方案：Boxer
Boxer 提供了一种新解决方案，提供将现有容器化工作负载和定义转换为几乎通用可部署的 Wasm 分发版的工具。这些“盒子”提供了与容器相当的环境，但由于 WebAssembly 轻量级、沙箱执行能力，效率大幅提升。

<p align="center">
  <p align="center">
    <a href="https://boxer.dev" target="_blank">
      <img src="https://github.com/dphilla/wasm-vfs/assets/20820229/4b0309d8-c8ae-427a-8af3-67857a8eebf3" alt="容器与盒子" width="400"             height="400">
    </a>
  </p>
</p>


### WebAssembly 的主要优势：
- **降低开销：** Wasm 紧凑的二进制指令格式确保轻量执行，大幅减少传统容器中的开销。
- **性能提升：** Wasm 的高效性带来更优性能和更小、更高效的部署，极适合云计算。
- **更高安全性：** Wasm 的内存安全、隔离执行环境提供了独立于操作系统的更高安全级别。
- **几乎随处可运行** Wasm 可在任何拥有 WebAssembly 运行时的地方运行，包括浏览器、服务器和嵌入式设备；现有运行时支持[多种架构。](https://github.com/appcypher/awesome-wasm-runtimes)

## 示例

### Dockerfile ➡ (Wasm)盒子

对于此文件：

```Dockerfile
FROM scratch
RUN mkdir -p /app
COPY a.out /app
WORKDIR /app
CMD ["/app/a.out"]
```
运行 `box build -f Dockerfile`

这将引入 libc 接口（作为导入）并创建必要的文件系统状态，从而声明式地创建一个可运行的 Wasm 二进制文件。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---