# getmic.ro

![Test](https://github.com/benweissmann/getmic.ro/workflows/Test/badge.svg)

The fastest way to install [Micro](https://micro-editor.github.io/)

```Bash
# local install just for your user
curl https://getmic.ro | bash
```

Or, using `wget` in place of `curl` and any `sh`ell interpreter in place of `bash`:

```Bash
# local install just for your user
wget -O- https://getmic.ro | sh
```
This script will install micro to the directory you're in. To install somewhere else (e.g. /usr/local/bin), cd there and make sure you can write to that directory, e.g. `cd /usr/local/bin; curl https://getmic.ro | sudo sh` like so:


```Bash
# global install for all users
cd /usr/bin
curl https://getmic.ro | sudo sh
```

This script can also use update-alternatives to register micro as a system text editor.
For example, this will allow `crontab -e` to open the cron file with micro.

To enable this feature, define the `GETMICRO_REGISTER` variable or use the URL
`https://getmic.ro/r`. Note that you must install micro to a directory
accessible to all users when doing this, typically /usr/bin:

```Bash
# global install for all users, registering with update-alternatives
cd /usr/bin
curl https://getmic.ro/r | sudo sh
```

> Don't understand English? Do you speak French? **Check out the [*FRENCH README*](https://raw.githubusercontent.com/benweissmann/getmic.ro/master/./README.fr.md)!**

## Advanced usage

There's a couple other things you can do with getmic.ro. Listed below are environment variables you can choose from:

* `GETMICRO_HTTP=<COMMAND ...ARGS>`
    + Use this command with arguments delimited by spaces to download files off the internet.
        - It MUST follow redirects (via HTTP Location headers).
        - It MUST print the resulting file contents to stdout.
        - It MUST accept the next argument to be the URL of the file to be downloaded
        - It IS OPTIONAL for the command to also accept a `--header` parameter used for non-essential GitHub authentication fallback shim.
    + For example, to force using `curl`, do: `curl https://getmic.ro | GETMICRO_HTTP="curl -L" sh`
    + For example, to force using `wget`, do: `wget -O- https://getmic.ro | GETMICRO_HTTP="wget -O-" sh`
* `GETMICRO_PLATFORM=[freebsd32 | freebsd64 linux-arm | linux-arm64 | linux32 | linux64 | linux64-static | macos-arm64 | netbsd32 | netbsd64 | openbsd32 | openbsd64 | osx | win32 | win64]`
    + This manually overrides the platform detection mechanism and downloads the binaries for the platform you specify
    + One usage of this is specifying `https://getmic.ro | GETMICRO_PLATFORM=linux64-static sh` when using an incompatible libc implementation such as musl.
* `GETMICRO_REGISTER=[y | n]`
    + Whether to register micro with `update-alternatives` so you can seamlessly use micro as the system text editor.
        - y => yes
        - n => no (the default)
    + If GETMICRO_REGISTER is defined but the system does not support `update-alternatives`, then this option is silently ignored.
    + When enabled, getmicro must be running with sufficient privileges (typically the root user) to use `update-alternatives`, otherwise getmicro will exit with an error.
    + As a shorthand, you can use `https://getmic.ro/r` which defines `GETMICRO_REGISTER=y`.

Putting it all together, the following command line would always use wget, always install the linux32 binaries, and always register with `update-alternatives`:

```Bash
wget -O- https://getmic.ro | GETMICRO_HTTP="wget -O-" GETMICRO_PLATFORM=linux32 GETMICRO_REGISTER=y sh
```

### Verify the script checksum

To verify the script, you can download it and checksum it. The sha256 checksum is `d041f51b97871dc7de1f01879c12a978b074a5acdb6528e884ce8f4c05d2ad35`.

```Bash
gmcr="$(curl https://getmic.ro)" && [ $(echo "$gmcr" | shasum -a 256 | cut -d' ' -f1) = d041f51b97871dc7de1f01879c12a978b074a5acdb6528e884ce8f4c05d2ad35 ] && echo "$gmcr" | sh
```
Alternatively, you can use the following manual method.


```Bash
# 1. Manually verify that this outputs d041f51b97871dc7de1f01879c12a978b074a5acdb6528e884ce8f4c05d2ad35
curl https://getmic.ro | shasum -a 256

# 2. If #1 was successful, then execute getmicro
curl https://getmic.ro | sh
```

## Contributing

Thank you for contributing! We use the Github pull request workflow: fork this repo, make your changes, and then submit a pull request. There's a couple things you'll need to do to get your PR merged:

- Make sure all of the tests pass. Github Actions will report test failures on the PR page once you open it.

- If you introduce new behavior, update the Github Actions tests (in [`.github/workflows/test.yml`](https://github.com/benweissmann/getmic.ro/blob/master/.github/workflows/test.yml)) to test that behavior.

- If you introduce new user-facing options or behavior, update the README files to document that behavior (don't translate if you don't know the destination file's language).

If you're not sure how to do any of these things, feel free to open a PR with your work-in-progress and whatever questions you have!

## Acknowledgments:

- Micro, of course: https://micro-editor.github.io/

- Loosely based on the Chef curl|bash: https://docs.chef.io/install_omnibus.html

- ASCII art courtesy of figlet: http://www.figlet.org/

<!--shasum=d041f51b97871dc7de1f01879c12a978b074a5acdb6528e884ce8f4c05d2ad35-->


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-10

---