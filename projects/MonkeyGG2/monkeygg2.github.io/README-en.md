<p align="center"><img src="https://raw.githubusercontent.com/MonkeyGG2/monkeygg2.github.io/main/imgs/icon-256-256.png" height="200"></p>

<div align="center">
<a href="https://discord.com/invite/yPYyZ78qCB"><img alt="Discord" src="https://img.shields.io/discord/1051660971900407839?label=discord"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="Github Repo stars" src="https://img.shields.io/github/stars/MonkeyGG2/monkeygg2.github.io?label=github%20stars"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="GitHub Repo forks" src="https://img.shields.io/github/forks/MonkeyGG2/monkeygg2.github.io?label=github%20forks"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo stars" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20stars&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=stars_count"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo forks" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20forks&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=forks_count"></a>
<a href="http://www.wtfpl.net/about"><img alt="License: WTFPL" src="https://img.shields.io/badge/License-WTFPL-brightgreen.svg"></a>
</div>
<h1 align="center">MonkeyGG2</h1>
<p align="center" style="opacity: 0.65;">Your Friendly Neighborhood Games Site.</p>
<br>

Welcome to MonkeyGG2, a feature-rich game site created for you! With over 150 games to choose from, MonkeyGG2 offers a unique and customizable gaming experience. Whether you're a gamer, a developer, or your average Joe, MonkeyGG2 provides a seamless and enjoyable gaming environment.

> Consider giving us a star! Especially if you forked this repository or you found some other use out of this repository.

## Features

-   Over 150 games
-   Easy to use
-   Easy to deploy
-   Customizable
-   Proxy
-   And More...

## Customization

### Settings

#### Cloaking

Cloaking refers to opening the page in an `about:blank` tab. This behavior is forced by default, although it can be disabled. Presets are available for the redirect link however that can also be manually configured.

#### Masking

Masking refers to changing the icon and tab title of the about:blank tab. Presets are available for the icon and tab title however that can also be manually configured.

#### Shortcuts

Custom keyboard shortcuts can be created to perform a variety of tasks. For example, exiting the game, masking the tab, and executing custom JavaScript are all supported.
> Note: if you want to execute custom JavaScript, make sure you know what you are doing. If you do break something, a page reload is always the solution.

#### Theme

The following theme customizations are supported currently:
- Toggle Background Animation (if you are worried about performance mid-game, don't worry it's automatically disabled whenever you are playing a game)
- Background Color
- Block Color
- Button Color
- Games Color
- Hover Color
- Scrollbar Color
- Scroll Track Color
- Font Color

> Note: if you accidentally change the colors so that the site is unusable, you'll have to clear your cookies and local storage.

### Advanced Customization

> Disclaimer: The following customizations are only available to owners of the repository or any fork of this repository.

The `config.jsonc` file is formatted to include configuration for the entire site. Currently, the following items are supported:
- Games
- Themes (coming soon)
- Proxy Configuration

#### Games

Each game entry has a key representing the display name of the game, and the value should be an object with three key-value pairs:
- `"path"`: Path to the game from `./games` directory
- `"aliases"`: List of alternative names for the game used to enhance search
- `"categories"`: List of categories the game fits in (support for adding icons coming soon)

Adding an entry manually is possible, but tedious especially if you want to alphanumerically order the list (not required for the configuration to work though!)
This is why the script `add-game-entry.js` was created, an easy way to add a new game into the configuration without having to manually edit the file.

```bash
# You can use any js runtime such as node.js, bun, or deno
# For this demonstration bun will be used as dependencies are automatically installed
bun add-game-script.js
# Answer the prompts that follow and the configuration will be updated
```

#### Themes

Theme standard not implemented yet (TODO)

#### Proxy

Proxy configuration options are under the **"config"** key. 
The value for key `"proxy"` is a boolean value that enables or disables the proxy function. If `"proxy"` is set to false, then the user will be greeted with an error dialog when attempting to access the proxy.
The value for key `"proxyPath"` is the path to the proxy. It can be an absolute path or a relative path, but the proxy must support **CORS** as the proxy page will be displayed as an iframe on the site.


## Deployment

### Without Proxy

[![Run on Replit](https://binbashbanana.github.io/deploy-buttons/buttons/remade/replit.svg)](https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Remix on Glitch](https://binbashbanana.github.io/deploy-buttons/buttons/remade/glitch.svg)](https://glitch.com/edit/#!/import/github/MonkeyGG2/monkeygg2.github.io)
[![Deploy to IBM Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/ibmcloud.svg)](https://cloud.ibm.com/devops/setup/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Amplify Console](https://binbashbanana.github.io/deploy-buttons/buttons/remade/amplifyconsole.svg)](https://console.aws.amazon.com/amplify/home#/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Run on Google Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/googlecloud.svg)](https://deploy.cloud.run/?git_repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Oracle Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/oraclecloud.svg)](https://cloud.oracle.com/resourcemanager/stacks/create?zipUrl=https://github.com/MonkeyGG2/monkeygg2.github.io/archive/refs/heads/main.zip)
[![Deploy with Vercel](https://binbashbanana.github.io/deploy-buttons/buttons/remade/vercel.svg)](https://vercel.com/new/clone?repository-url=https%3A%2F%2Fgithub.com%2FMonkeyGG2%2Fmonkeygg2.github.io)
[![Deploy with Netlify](https://binbashbanana.github.io/deploy-buttons/buttons/remade/netlify.svg)](https://app.netlify.com/start/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Render](https://binbashbanana.github.io/deploy-buttons/buttons/remade/render.svg)](https://render.com/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)

Alternatively, you can simply fork this repository on [GitHub](https://github.com/MonkeyGG2/monkeygg2.github.io) or [Codeberg](https://codeberg.org/MonkeyGG2/pages) and deploy to GitHub Pages or Codeberg Pages, respectively.

### With Proxy

Visit the [VioletGG2](https://github.com/MonkeyGG2/VioletGG2) page to learn more about hosting MonkeyGG2 with a proxy.

### Running Locally

```bash
# WARNING: if you have a folder named "monkeygg2", this command will remove all files inside of that folder
# please change the name of the directory in the following two commands
git clone https://github.com/MonkeyGG2/monkeygg2.github.io.git monkeygg2
cd monkeygg2
# from here you can use any tool for running a static server, "live-server" from npm will be used here
npm install -g live-server # only if you don't have it installed already
npx live-server
```

## License

Distributed under the WTFPL License. See [here](https://github.com/MonkeyGG2/monkeygg2.github.io/blob/main/LICENSE) for more details.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---