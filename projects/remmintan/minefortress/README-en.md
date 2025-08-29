![the mod that will turn your Minecraft into real-time strategy](https://raw.githubusercontent.com/remmintan/minefortress/master/docs/main-banner.png)
# MineFortress
[![Support the project](https://img.shields.io/badge/PATREON-SUPPORT_THE_PROJECT-f96854?style=for-the-badge&logo=patreon&logoColor=f96854&labelColor=052d49&color=f96854)](https://www.patreon.com/minefortress)
[![Join Discord](https://img.shields.io/discord/906943962659561515?style=for-the-badge&logo=discord&label=discord&color=5865F2)](https://discord.gg/6rt7VJxPcq)
[![Website](https://img.shields.io/badge/website-minefortress-CC9966?style=for-the-badge)](https://minefortress.net/)

The mod that turns your Minecraft into RTS. Take the role of a village leader, gather resources, build houses, hire professionals to grow and expand your village and even conquer your neighbors! Forget about the first-person view and control everything with your mouse pointer like in classic RTS games.
## Links
* **[Website](https://minecraftfortress.org/)**
* **[Patreon](https://www.patreon.com/minefortress)**
* **[Modrinth](https://modrinth.com/mod/minefortress)**
* **[CurseForge](https://www.curseforge.com/minecraft/mc-mods/minefortress-rts)**
## For Players
This repo is intended for developers. If you want to play the mod, please download it from [CurseForge](https://www.curseforge.com/minecraft/mc-mods/minefortress-rts) or [Modrinth](https://modrinth.com/mod/minefortress).

Mod requires Fabric Loader and Fabric API to work.
Follow the detailed installation instructions in our [wiki](https://wiki.minecraftfortress.org/wiki/Installation:Curseforge_Launcher).

## For Developers
### Prerequisites
I assume that everyone who wants to contribute to the project is familiar with Java/Kotlin development in general.
I won't go into details of installing basic developer setup, but I will list all the tools that are required to work with the project:
* Java 17 - I prefer using [Adoptium](https://adoptium.net/) builds 
* IntelliJ IDEA - For the most convenient development experience and to get the results matching my results, I recommend using IntelliJ IDEA. You can download it [here](https://www.jetbrains.com/idea/download/).
* Git - To clone the repository and to commit your changes. You can download it [here](https://git-scm.com/downloads).

If you need some support in setting up your developer environment, please read articles located here: [Java development with IntelliJ IDEA](https://www.jetbrains.com/help/idea/getting-started.html)

Feel free to ask for help in our [Discord server](https://discord.gg/6rt7VJxPcq).
### Getting started / Installation
1. Clone the repository using Git.
2. Make sure that the project is cloned in the directory named `minefortress`. This is required to make Gradle work properly with IDEA.
3. Open the project in IntelliJ IDEA.
4. Wait for Gradle to finish importing the project.
5. We still need to make Run Configurations work. Fabric plugin will do it automatically, but we need to close the project.
6. Close the project and open it again.
7. New Run Configurations should appear. If they don't, try to restart IDEA.
8. Run Configuration may have small cross near it. It means that Fabric plugin used wrong module when setting up the configuration.
![](https://raw.githubusercontent.com/remmintan/minefortress/master/docs/run-configurations-1.png)
9. To fix it, edit the configuration and select `minefortress.main` module classpath dropdown.
![](https://raw.githubusercontent.com/remmintan/minefortress/master/docs/run-configurations-2.png)
10. Now you can run the project using the `Minecraft Client` configuration.
![](https://raw.githubusercontent.com/remmintan/minefortress/master/docs/run-configurations-3.png)

### Contributing
Any help is highly appreciated! If you want to contribute to the project, please follow these steps:
1. Fork the repository.
2. Create a new branch from the `master` branch.
3. Make your changes.
4. Commit your changes and push them to your fork.
5. Create a pull request to the `master` branch of this repository.

There is no contribution guide yet, but you can check out the [issues](https://github.com/remmintan/minefortress/issues) to find something to work on.
I will try to collect bugs and feature requests in the issues, but if you have any questions, feel free to ask them in our [Discord server](https://discord.gg/6rt7VJxPcq).

Also feel free to create issues if you find any bugs or have any feature requests.

Over time, I will try to create a contribution guide and a list of issues that are good for beginners.

## License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Donate
Support the open-source development by donating to the project. You can donate using the following methods:
* **[Patreon](https://www.patreon.com/minefortress)**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---