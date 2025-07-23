<p align="center">
	<img src="https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/logo.png" width="100">
<br>

</p>

# Product Introduction

HummingBird is an ultra-lightweight IoT development platform implemented in Golang. Its core services are entirely developed by our team. From the initial design of this platform, lightweight and excellent performance have been our development principles. Therefore, all its services are written in Golang, consuming very little memory. For data storage, we innovatively use SQLite and LevelDB as our storage databases. Thanks to SQLite’s lightweight nature and LevelDB’s high throughput and high compression characteristics, actual tests on a 1C/1G 100G storage physical machine can support thousands of device connections and 80 million message storage.

Of course, if you have requirements for data reliability, massive storage, etc., you can completely replace SQLite and LevelDB with MySQL and TDengine. The HummingBird IoT platform supports multiple database connections, allowing users to choose the database that suits their business needs.

"Though small as a sparrow (HummingBird), it has all vital organs." Although HummingBird is an ultra-lightweight IoT platform, its core functions are not reduced. Device access, product management, thing models, alarm center, rule engine... All standard functions of an IoT platform can be found in this platform.



![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/architecture.png)



# Partial Page Display

| ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/1.png) | ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/2.png)  |
|:--------------------------|:---------------------------|
| ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/3.png) | ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/4.png)  |
| ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/5.png) | ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/6.png)  |
| ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/9.png) | ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/10.png) |
| ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/7.png) | ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/8.png)  |

# Mini Program Page Display

| ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/miniapp-merge1.png) | ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/miniapp-merge2.png) |
|:---------------------------------------|:---------------------------------------|
| ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/miniapp-merge3.png) | ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/miniapp-merge4.png) |

# Official Documentation URL
https://doc.hummingbird.winc-link.com/

# Quick Start

git clone https://gitee.com/winc-link/hummingbird.git

cd hummingbird/manifest/docker 

docker-compose up -d

# Main Features

- Product Management
- Device Management
- Image Management
- Driver Management
- Driver Marketplace
- System Monitoring
- Alarm Center
- Resource Management
- Rule Engine
- Scene Linkage
- Plugin Marketplace
- Data Dashboard

# Product Advantages

- **Free and Open Source**: Our source code is fully open source for personal study.
- **Excellent Performance**: Actual tests show that on a 2C4G host, it supports 60k device connections. Simulating 4k devices sending 16kb property data to the server at 1000ms intervals, CPU usage stabilizes at 60%, and memory usage stabilizes at 16%.
- **Multi-Data Support**: The platform supports SQLite, LevelDB, MySQL, and TDengine databases, allowing users to choose the database that fits their project needs.
- **Supports Visual Dashboard**: Users can complete visual dashboard design simply by dragging without writing any code.
- **Built-in Product Template Library**: The platform has 390 built-in product templates to help users create products with one click.
- **Clear Documentation**: The platform documentation is clear and complete, containing many usage examples and video tutorials to help users quickly understand and use the product.
- **Simple Deployment**: All platform services run as Docker containers and support one-click startup with docker-compose commands.
- **Cost Advantage**: For small and medium IoT projects (device count <= 5000), only a 2C4G host is needed, and local deployment is supported.

# Contact Us

We have opened a HummingBird user group. If you encounter any problems while using the product, you can join the group for communication.


| WeChat Group (Add friend first with note to join group)                                        | QQ Group                                                                  |
|:------------------------------------------------------------------------|:--------------------------------------------------------------------------|
| ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/qweixin.png) | ![](https://raw.githubusercontent.com/winc-link/hummingbird/master/manifest/image/qq.png) |

# Open Source Contribution

-   Checkout a new branch from the `master` branch (**Note**: Please ensure the `master` code is up to date)
-   New branch naming format: `feature/username/description`, e.g., `feature/pick/mqtt_driver`
-   Edit documentation and code on the new branch, then commit
-   Submit a `PR` to merge into the `develop` branch and wait for the author to merge

# Open Source License

The `Hummingbird` open source platform follows the [Apache 2.0 License](https://www.apache.org/licenses/LICENSE-2.0.html). If you want to use the HummingBird IoT platform for commercial purposes, please contact the author for authorization in advance!



## Stargazers over time

[![Stargazers over time](https://starchart.cc/winc-link/hummingbird.svg)](https://starchart.cc/winc-link/hummingbird)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---