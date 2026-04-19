<p>
  <div align="center">
  <h1>
    Téléchargeur d'Histoires Publiques Snapchat<br /> <br />
    <a href="https://pypi.python.org/pypi/snapchat-dl">
      <img
        src="https://img.shields.io/pypi/v/snapchat-dl.svg?cacheSeconds=360"
        alt="Package Python"
      />
    </a>
    <a href="https://pypi.python.org/pypi/snapchat-dl">
      <img
        src="https://img.shields.io/pypi/wheel/snapchat-dl"
        alt="Roue Python"
      />
    </a>
    <a href="https://pypi.python.org/pypi/snapchat-dl">
      <img
        src="https://img.shields.io/github/actions/workflow/status/skyme5/snapchat-dl/continuous-integration-pip.yml?cacheSeconds=360"
        alt="CI"
      />
    </a>
    <a href="https://codecov.io/gh/skyme5/snapchat-dl">
      <img
        src="https://img.shields.io/codecov/c/github/skyme5/snapchat-dl?cacheSeconds=360"
        alt="Couverture du code"
      />
    </a>
    <a href="https://codecov.io/gh/skyme5/snapchat-dl">
      <img
        src="https://img.shields.io/pypi/pyversions/snapchat-dl"
        alt="Versions Python"
      />
    </a>
    <a href="https://github.com/psf/black">
      <img
        src="https://img.shields.io/badge/code%20style-black-000000.svg"
        alt="Le formateur de code sans compromis"
      />
    </a>
    <a href="https://pepy.tech/project/snapchat-dl">
      <img
        src="https://static.pepy.tech/badge/snapchat-dl"
        alt="Téléchargements mensuels"
      />
    </a>
    <a href="https://opensource.org/licenses/MIT">
      <img
        src="https://img.shields.io/badge/License-MIT-blue.svg"
        alt="Licence : MIT"
      />
    </a>
  </h1>
  <a href="https://buymeacoffee.com/skyme5" target="_blank"><img src="https://www.buymeacoffee.com/assets/img/custom_images/orange_img.png" alt="Achetez-moi un café" style="height: 41px !important;width: 174px !important;" ></a>
  </div>
</p>

### Installation

Installez avec pip,

```bash
pip install snapchat-dl
```

Installer depuis GitHub,

```bash
pip install git+git://github.com/skyme5/snapchat-dl
```

Les utilisateurs Unix peuvent vouloir ajouter le drapeau `--user` pour installer sans nécessiter `sudo`.

### Usage

```text

usage: snapchat-dl [-h] [-c | -u] [-i BATCH_FILENAME] [-P DIRECTORY_PREFIX]
                   [-s] [-d] [-l MAX_NUM_STORY] [-j MAX_WORKERS] [-t INTERVAL]
                   [--sleep-interval INTERVAL] [-q]
                   [username [username ...]]

positional arguments:
  username              At least one or more usernames to download stories
                        for.

optional arguments:
  -h, --help            show this help message and exit
  -c, --scan-clipboard  Scan clipboard for story links
                        ('https://story.snapchat.com/<s>/<username>').
  -u, --check-for-update
                        Periodically check for new stories.
  -i BATCH_FILENAME, --batch-file BATCH_FILENAME
                        Read usernames from batch file (one username per
                        line).
  -P DIRECTORY_PREFIX, --directory-prefix DIRECTORY_PREFIX
                        Location to store downloaded media.
  -s, --scan-from-prefix
                        Scan usernames (as directory name) from prefix
                        directory.
  -d, --dump-json       Save metadata to a JSON file next to downloaded
                        videos/pictures.
  -l MAX_NUM_STORY, --limit-story MAX_NUM_STORY
                        Set maximum number of stories to download.
  -j MAX_WORKERS, --max-concurrent-downloads MAX_WORKERS
                        Set maximum number of parallel downloads.
  -t INTERVAL, --update-interval INTERVAL
                        Set the update interval for checking new story in
                        seconds. (Default: 10m)
  --sleep-interval INTERVAL
                        Sleep between downloads in seconds. (Default: 1s)
  -q, --quiet           Do not print anything except errors to the console.

```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-19

---