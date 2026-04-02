<div align="center">
   <img src="https://i.imgur.com/BMpvtWP.png">
</div>

 AutoPlug-Client is a standalone, executable Java program that has multiple execution modes: Server-Wrapper, CLI-Tool, Background-Service. Its main purpose is to automate updating of any software related to servers and simplify server maintenance in general. While all server types are compatible (including Steam game servers), the majority of its features cater specifically to Minecraft, which is renowned as the world's top-selling game and boasts an exceptionally extensive modding community.
 
## Links

- Download stable/beta versions at the [AutoPlug-Releases](https://github.com/Osiris-Team/AutoPlug-Releases) repo.
- Follow the [AutoPlug-Client-Development](https://bit.ly/acprogress) and see what we are currently working on.
- Support the development by [donating](https://www.paypal.com/donate?hosted_button_id=JNXQCWF2TF9W4).
- Issues or questions? Checkout the [FAQ](/docs/FAQ.md) and/or join our [Discord](https://discord.com/invite/GGNmtCC), for live chat/voice
support.

## What can it do?

- Automated self, server-software, plugins, mods and JRE (Java Runtime Environment) updating
- Scheduled server restarts
- Automated, modularized backup creation
- Fast, asynchronous, multithreaded task execution
- Have synchronized (shared) folders
- Web-Panel for starting, stopping restarting the server and viewing the last updating results summaries

Premium [AutoPlug-Web](https://autoplug.one) features:

- [Online Console](https://raw.githubusercontent.com/Osiris-Team/AutoPlug-Client/master/./docs/online-console.gif)
- [Online File-Manager](https://raw.githubusercontent.com/Osiris-Team/AutoPlug-Client/master/./docs/file-manager.gif)
- Staff Access
- Plugin details database

## Status
Stable and feature-complete, thus community driven development, meaning the lead developer will not develop new features and rely on pull requests by others, except for security issues and critical bugs.

## Community projects

- Docker support: https://github.com/lkkuma/AutoPlug-Client-Docker
- Pterodactly panel support: https://github.com/ImLunaUwU/PteroPlug

Developers: 

You can also use AutoPlug in your projects by adding it as a dependency
via [Maven/Gradle/Sbt/Leinigen](https://jitpack.io/#Osiris-Team/AutoPlug-Client/-SNAPSHOT). Some useful classes would be
the AutoPlugConsole for example, which lets you execute AutoPlug commands programmatically:

```java
AutoPlugConsole.executeCommand(".check plugins");
AutoPlugConsole.executeCommand(".check server");
// etc...
```
## Contribute ![Build test](https://github.com/Osiris-Team/AutoPlug-Client/workflows/build/badge.svg)

Thank you for considering to contribute, the community 💙 that! Just keep these things in mind:
- Create an issue first if you want to do big changes, so we can discuss it.
- Remember that big changes also require you to write tests.
- You can pick and work on any open issue. Let us know that you are working on it.
- Avoid using and writing static methods/fields/classes to ensure minimal memory usage.

Beginners:

- [contribute-to-projects](https://www.jetbrains.com/help/idea/contribute-to-projects.html)
- [clone-a-project-from-github](https://blog.jetbrains.com/idea/2020/10/clone-a-project-from-github/)

Bounties:

Some open issues are marked with a tag/label like this: `bounty: 15€` (show the [list](https://github.com/Osiris-Team/AutoPlug-Client/labels/bounty%3A%2015%E2%82%AC)), which means that the first person
creating a pull request for fixing/closing that issue will receive the bounty (15€). Note that your code must have
at least one test demonstrating that the implemented fix/feature is working. Also note that payments are only made via PayPal, so make sure
that the public Github page of your profile, with which you commit the pull request, contains your PayPal email address somewhere.
By commiting to an issue with the bounty tag you agree to these terms.

Details:

- Written in [Java](https://java.com/), with [JDK 8](https://www.oracle.com/java/technologies/javase/javase-jdk8-downloads.html), inside of [IntelliJ IDEA](https://www.jetbrains.com/idea/)
- Built with [1JPM](https://github.com/Osiris-Team/1JPM), command: `java ./src/main/java/JPM.java`
(if you want to directly run it too append `andRun` at the end).

## Libraries

Note that this list may be outdated. Check the [build.gradle](/build.gradle) file for our current dependencies.
- [AutoPlug-Core](https://github.com/Osiris-Team/AutoPlug-Core) contains frequently used code accross all AutoPlug
  projects in one jar.
- [Dream-Yaml](https://github.com/Osiris-Team/Dream-Yaml) is used for handling YAML files.
- [Better-Thread](https://github.com/Osiris-Team/Better-Thread) enables display of 'live-tasks'.
- For console coloring and task display [Jansi](https://github.com/fusesource/jansi) and [Jline](https://github.com/jline/jline3) is used.
- [Zip4j](https://github.com/srikanth-lingala/zip4j) to unpack and handle jar/zips.
- Server restarts are scheduled with [Quartz](http://www.quartz-scheduler.org/).



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-02

---