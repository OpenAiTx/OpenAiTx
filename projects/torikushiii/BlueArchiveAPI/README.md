
# Blue Archive API

## *This API provides data for both the global and Japanese versions of Blue Archive.*

- [Blue Archive EN](https://bluearchive.nexon.com/home): Official EN Website
- [Blue Archive JP](https://bluearchive.jp/): Official JP Website

API that provides various data from the game Blue Archive. If you want to contribute to this project, feel free to open a pull request or an issue. If you want to support me, you can donate to my [Ko-Fi](https://ko-fi.com/torikushiii).

**Hosted API at https://api.ennead.cc/buruaka**

## Prerequisites

- [Go](https://go.dev/dl/): 1.24 or newer
- MongoDB instance reachable by the API (the default URI is `mongodb://localhost:27017`)

## Configuration

Runtime options are loaded from a YAML file. By default the server reads `config.yaml` in the project root. Set the `CONFIG_PATH` environment variable to point to an alternate configuration file if needed.

See `config.yaml` for an example that matches the local defaults.

## Running the API

Build dependencies and start the server using Go:

```bash
go run ./cmd/server
```

The listener address is controlled through configuration (default `0.0.0.0:9999`). All REST endpoints are served under the `/buruaka` base path (e.g. `/buruaka/character`), and the server connects to MongoDB using the configured URI to deliver character, raid, and banner data.

To produce a standalone binary:

```bash
go build -o server ./cmd/server
```

Run tests with:

```bash
go test ./...
```

## REST API Documentation

Endpoint details are in the [docs](https://github.com/torikushiii/BlueArchiveAPI/tree/main/docs) folder.
