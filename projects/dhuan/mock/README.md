# mock

[![Go Reference](https://pkg.go.dev/badge/github.com/dhuan/mock.svg)](https://pkg.go.dev/github.com/dhuan/mock)
[![Go Report Card](https://goreportcard.com/badge/github.com/dhuan/mock)](https://goreportcard.com/report/github.com/dhuan/mock)

*mock* is an API utility - it lets you:

- define API routes easily through API configuration files or through
  command-line parameters.
- use shells scripts as response handlers. Or any other type of program can act
  as response handlers.
- test your API - make assertions on whether an endpoint was requested.

[The fastest way to learn and understand `mock` is to see the examples page.](https://dhuan.github.io/mock/latest/examples.html)

## Quick links

- [User guide](https://dhuan.github.io/mock)
- [User guide (main branch, not released yet)](https://dhuan.github.io/mock/latest)
- [How-tos & Examples](https://dhuan.github.io/mock/latest/examples.html)

## Getting started

```sh
$ mock serve --port 3000 \
  --get "/time-now" \
  --exec 'printf "Now it is %s" $(date +"%H:%M") | mock write' \
  --post "/shut-down/{application}" \
  --exec 'killall $(mock get-route-param application)'
```

Let's test it out:

```sh
$ curl localhost:3000/time-now
# Prints out:
Now it is 22:00

$ curl -X POST localhost:3000/shut-down/mock
# Shuts down the server!
```

*mock* lets you also extend other APIs (or any HTTP service, for that matter.)
Suppose you want to add a new route to an existing API running at
``example.com``:

```sh
$ mock serve --port 3000 \
  --base example.com \
  --get 'some-new-route' \
  --exec 'printf "Hello, world!" | mock write' 
```

With the ``--base example.com`` option above, your API will act as proxy to
that other website, and extend it with an extra route `GET /some-new-route`.
Look up "Base APIs" in the docs for more details.

*[There are many other ways of further customising your APIs with *mock*. Read further through the guide to learn.](https://dhuan.github.io/mock)*

## Installing

mock is distributed as a single-file executable. Check the releases page and download the latest tarball.

## License

**mock** is licensed under MIT. For more information check the [LICENSE file.](LICENSE)
