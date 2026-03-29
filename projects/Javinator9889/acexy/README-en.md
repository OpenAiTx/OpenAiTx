# `acexy` - An AceStream Proxy Written In Go! ⚡

[![Go Build](https://github.com/Javinator9889/acexy/actions/workflows/build.yaml/badge.svg)](https://github.com/Javinator9889/acexy/actions/workflows/build.yaml)
[![Docker Release](https://github.com/Javinator9889/acexy/actions/workflows/release.yaml/badge.svg?event=release)](https://github.com/Javinator9889/acexy/actions/workflows/release.yaml)

## Table of Contents

- [How It Works? 🛠](#how-it-works-)
- [Key Features 🔗](#key-features-)
- [Usage 📐](#usage-)
- [Optimizing 🚀](#optimizing-)
  - [Alternative 🧃](#alternative-)
- [Configuration Options ⚙](#configuration-options-)

## How It Works? 🛠

This project is a wrapper around the
[AceStream middleware HTTP API](https://docs.acestream.net/developers/start-playback/#using-middleware), allowing both
[HLS](https://en.wikipedia.org/wiki/HTTP_Live_Streaming) and
[MPEG-TS](https://en.wikipedia.org/wiki/HTTP_Live_Streaming) playback
of a stream.

I was tired of the limitations of AceStream and some of the problems that 
exist when playing a stream 📽. For example, it is only possible to play
the same channel for **1 single client**. For having multiple clients
playing **different streams**, you must manually add a unique `pid` per 
client. If there was an error during the transmission, the **whole stream
goes down**, etc.

I found quite frustrating the experience of using AceStream in a home network
with a single server and multiple clients, to try to optimize resources. This
is the topology for which I am using AceStream:

![AceStream Topology For My Network](https://raw.githubusercontent.com/Javinator9889/acexy/main/doc/img/topology.svg)

There are some problems:

* Only **one client** can play the same stream at a time 🚫.
* Having each client to run AceStream on their own is a waste of resources
  and saturates the network 📉.
* Multiple clients can play different streams if they have a unique `pid`
  (Player ID) associated 🔓.
* The standard AceStream HTTP API is not resilient enough against errors,
  if the transmission stops it stops for every client ❌.

## Key Features 🔗

When using `acexy`, you automatically have:

* A single, centralized server running **all your AceStream streams** ⛓.
* Automatic assignation of a unique `pid` (Player ID) **per client per stream** 🪪.
* **Stream Multiplexing** 🕎: The same stream can be reproduced *at the
  same time in multiple clients*.
* **Resilient, error-proof** streaming thanks to the HTTP Middleware 🛡.
* *Blazing fast, minimal proxy* ☄ written in Go!

With this proxy, the following architecture is now possible:

![acexy Topology](https://raw.githubusercontent.com/Javinator9889/acexy/main/doc/img/acexy.svg)

## Usage 📐

`acexy` is available and published as a Docker image. Make sure you have
the latest [Docker](https://docker.com) image installed and available.

The Acexy container will connect against an AceStream server. You need to
deploy either a Docker image, and link Acexy within the same network; Or
have a running AceStream version on your host and run Acexy in host-networked
mode.

> **INFO**: There is a `docker-compose.yml` file in the repo you can directly
> use to launch the whole block. This is **the recommended setup starting
> from `v0.2.0`**.

To run the services block, first grab the `docker-compose.yml` file, and run:

```shell
wget https://raw.githubusercontent.com/Javinator9889/acexy/refs/heads/main/docker-compose.yml
docker compose run -d
```
If you don't want to use Docker Compose, assuming you already have an  
AceStream server, another way could be:


```shell
docker run --network host ghcr.io/javinator9889/acexy
```

> **NOTE**: For your convenience, a `docker-compose.yml` file is given with
> all the possible adjustable parameters. It should be ready to run, and it's
> the recommended way starting from `v0.2.0`.

By default, the proxy will operate in MPEG-TS mode. To switch between modes,
you must add the **`-m3u8` flag** or set the **`ACEXY_M3U8=true` environment
variable**.

> **NOTE**: The HLS mode - `ACEXY_M3U8` or `-m3u8` flag - is currently untested.
> Its use is discouraged and not guaranteed to work.

There is a single available endpoint: `/ace/getstream` which accepts the same
parameters as the standard
[AceStream Middleware/HTTP API](https://docs.acestream.net/developers/api-reference/). Therefore,
to run a stream, just open the following link in your preferred application—such as VLC:

```
http://127.0.0.1:8080/ace/getstream?id=dd1e67078381739d14beca697356ab76d49d1a2
```
where `dd1e67078381739d14beca697356ab76d49d1a2` is the ID of the AceStream 
channel.

## Optimizing 🚀

The AceStream Engine running behind the proxy has a number of ports that can
be exposed to optimize performance. These are, by default:

- `8621/tcp`
- `8621/udp`

> NOTE: They can be adjusted through the `EXTRA_FLAGS` variable - within Docker - by
> using the `--port` flag.

Exposing these ports should help achieve a more stable streaming experience. Note
that you will also need to open these ports on your gateway.

For reference, this is how you should run the Docker command:


```shell
docker run -t -p 8080:8080 -p 8621:8621 ghcr.io/javinator9889/acexy
```

### Alternative 🧃

AceStream underneath attempts to use UPnP IGD to connect against a remote machine.
The problem is that this is not working because of the bridging layer added by Docker
(see: https://docs.docker.com/engine/network/drivers/bridge/).

If you are running a single instance of Acexy - and a single instance of AceStream -
it should be safe for you to run the container with *host networking*. This means:

- The container **can access** any other application bridged to your main network.
- You **don't need** to expose any ports.
- Performance **is optimized** a little bit.

> NOTE: This only works on Linux environments. See https://docs.docker.com/engine/network/drivers/host/
> for more information.

The command is quite straightforward:

```shell
docker run -t --network host ghcr.io/javinator9889/acexy
```

That should enable AceStream to use UPnP freely.

## Configuration Options ⚙

Acexy has tons of configuration options that allow you to customize the behavior. All of them have
default values that were tested for the optimal experience, but you may need to adjust them
to fit your needs.

> **PRO-TIP**: You can issue `acexy -help` to have a complete view of all the available options.

As Acexy was thought to be run inside a Docker container, all the variables and settings are
adjustable by using environment variables.


<table>
  <thead>
    <tr>
      <th>Flag</th>
      <th>Environment Variable</th>
      <th>Description</th>
      <th>Default</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <th><code>-license</code></th>
      <th>-</th>
      <th>Prints the program license and exits</th>
      <th>-</th>
    <tr>
    <tr>
      <th><code>-help</code></th>
      <th>-</th>
      <th>Prints the help message and exits</th>
      <th>-</th>
    <tr>
    <tr>
      <th><code>-addr</code></th>
      <th><code>ACEXY_LISTEN_ADDR</code></th>
      <th>Address where Acexy is listening to. Useful when running in <code>host</code> mode.</th>
      <th><code>:8080</code></th>
    <tr>
    <tr>
      <th><code>-scheme</code></th>
      <th><code>ACEXY_SCHEME</code></th>
      <th>
        The scheme of the AceStream middleware. If you have configured AceStream to work in HTTPS,
        you will have to tweak this value.
      </th>
      <th><code>http</code></th>
    <tr>
    <tr>
      <th><code>-acestream-host</code></th>
      <th><code>ACEXY_HOST</code></th>
      <th>
        Where the AceStream middleware is located. Change it if you need Acexy to connect to a
        different AceStream Engine.
      </th>
      <th><code>localhost</code></th>
    <tr>
    <tr>
      <th><code>-acestream-port</code></th>
      <th><code>ACEXY_PORT</code></th>
      <th>
        The port to connect to the AceStream middleware. Change it if you need Acexy to connect
        to a different AceStream Engine.
      </th>
      <th><code>6878</code></th>
    <tr>
    <tr>
      <th><code>-m3u8-stream-timeout</code></th>
      <th><code>ACEXY_M3U8_STREAM_TIMEOUT</code></th>
      <th>
        When running Acexy in M3U8 mode, the timeout to consider a stream is done.
      </th>
      <th><code>60s</code></th>
    <tr>
    <tr>
      <th><code>-m3u8</code></th>
      <th><code>ACEXY_M3U8</code></th>
      <th>
        Enable M3U8 mode in Acexy. <b>WARNING</b>: This mode is experimental and may not work as expected.
      </th>
      <th>Disabled</th>
    <tr>
    <tr>
      <th><code>-empty-timeout</code></th>
      <th><code>ACEXY_EMPTY_TIMEOUT</code></th>
      <th>
        Timeout to consider a stream is finished once empty information is received from
        the middleware. Useless when in M3U8 mode.
      </th>
      <th><code>1m</code></th>
    <tr>
    <tr>
      <th><code>-buffer-size</code></th>
      <th><code>ACEXY_BUFFER_SIZE</code></th>
      <th>
        Buffers up-to <code>buffer-size</code> bytes of a stream before copying the data to the
        player. Useful to have better stability during plays.
      </th>
      <th><code>4.2MiB</code></th>
    <tr>
    <tr>
      <th><code>-no-response-timeout</code></th>
      <th><code>ACEXY_NO_RESPONSE_TIMEOUT</code></th>
      <th>
        Time to wait for the AceStream middleware to return a response for a newly opened stream.
        This must be as low as possible unless your Internet connection is really bad
        (ie: You have very big latencies).
      </th>
      <th><code>1s</code></th>
    <tr>
  </tbody>
</table>

> **NOTE**: The list of options is extensive but could be outdated. Always refer to the
> Acexy binary `-help` output when in doubt.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-29

---