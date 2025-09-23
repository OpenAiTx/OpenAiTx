# Node Monkey

A tool for inspecting, debugging and commanding Node.js applications through a web browser or SSH interface into your app (with your own custom commands).

Node Monkey runs a simple server (or attaches to your existing server) and uses [Socket.IO](https://github.com/LearnBoost/socket.io) to create a websocket connection between the browser and server. Its primary feature captures anything that would normally be logged to the terminal and passes it to the browser for inspection.

It is incredibly easy to get started (see [Quick Usage](#quick-usage) below) but Node Monkey also provides additional features and significant flexibility for more advanced usage. You can actually SSH into your app where Node Monkey will provide a command line interface to execute your own custom commands. This can be very useful for debugging, monitoring or otherwise controlling your application while it is running. It provides authentication for security in production applications.

## Contents

- [Motivation](#motivation)
- [Features](#features)
- [Installation](#installation)
- [Quick Usage](#quick-usage)
- [Server](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md)
  - [Provide your own](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#provide-your-own)
  - [Options](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#options)
  - [Properties](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#properties)
  - [Methods](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#methods)
- [Client (browser)](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/client.md)
  - [Properties](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/client.md#properties)
  - [Methods](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/client.md#methods)
- [SSH](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/ssh.md)
  - [Setup](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/ssh.md#setup)
  - [Usage](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/ssh.md#usage)
- [User Management](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/user-management.md)
- [Contributing](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/contributing.md)
- [Changelog](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/CHANGELOG.md)
- [MIT License](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/LICENSE.md)

## Motivation

The motivation for this project came from trying to debug a Node.js server I wrote that used websockets. I found it problematic trying to inspect objects with the terminal because the output was too large and not browsable. I tried using the built-in debugging that works with the [Chrome Developer Tools plugin](https://github.com/joyent/node/wiki/using-eclipse-as-node-applications-debugger) for Eclipse. Unfortunately, I ran into a problem where setting breakpoints to inspect objects would cause the server to stop responding to heartbeats thus causing the client to disconnect. This would entirely mess up my debugging efforts. All I really needed to do was have a good way to inspect objects.

I searched Google and found projects like [node-inspector](https://github.com/dannycoates/node-inspector), which didn't work with the latest versions of Node, and [node-codein](http://thomashunter.name/blog/nodejs-console-object-debug-inspector/) which had many bugs. And neither worked with Firefox. So, Node Monkey was born!

## Features

- Log console output from your app to a browser console for easier inspection
  - Provides a stream for those using Bunyan (see [here](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#nodemonkeybunyan_stream))
- Provides SSH capability so you can get a shell into your app for inspection, debugging or controlling your app
- Register commands for your application that can be executed from the browser console or the SSH interface

## Installation

```
npm install --save node-monkey
```

If you're interested in testing experimental and upcoming features, run this instead:

```
npm install --save node-monkey@next
```

## Quick Usage

Although Node Monkey supports many features, getting started is designed to be extremely easy. All you have to do is include a line or two in your application. Anything that is logged to the console after this will show up in the browser console once connected. It captures the output to most `console.*` function calls and forwards the output to the browser for inspection.

The simplest usage looks like this:

```js
const NodeMonkey = require("node-monkey")
NodeMonkey()
```

Node Monkey also supports many configuration [options](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#options) and named instances. The call takes the form `NodeMonkey([options[, name])`. So, for example, to suppress local console output and only see output in your connected browser or terminal you might do something like this:

```js
const NodeMonkey = require("node-monkey")
const monkey = NodeMonkey({
  server: {
    disableLocalOutput: true,
  },
})
```

You can include Node Monkey in all the files within your app that you want and if used like the examples above, each call to `NodeMonkey()` will always return the same instance you first constructed, ignoring any options passed on subsequent calls. However, you may want to construct new instances with different options. To do so, give your instance a name:

```js
const NodeMonkey = require("node-monkey")
const monkey1 = NodeMonkey() // Creates an instance named 'default'
const monkey2 = NodeMonkey("george") // Creates a new instance with default options
const monkey3 = NodeMonkey(
  {
    // Creates a new instance with custom options named 'ninja'
    server: {
      silent: true,
    },
  },
  "ninja",
)
```

If you don't specify a port for additional instances it will automatically be set for you and will just increment from the default (e.g. 50502, 50504 for the websocket server and 50503, 50505 for the SSH server).

To get an already constructed instance in another file just call it with the name again:

```js
const NodeMonkey = require("node-monkey")
const monkey3 = NodeMonkey("ninja")
```

When you start your app you will see the following output:

```
Node Monkey listening at http://0.0.0.0:50500
```

To connect your browser simply go to the address it shows in your web browser (`http://0.0.0.0:50500` in this case). If you change the default `host` and `port` bindings or pass in your own server be sure to adjust your URL accordingly. It will prompt you for a username and password. Until you setup a user the default is `guest` and `guest`.

If you provide your own server you can view output in the console of your own web application instead. To see how to provide your own server check out the [documentation](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/doc/usage/server.md#provide-your-own). You will need to include the following `<script>` tag in your HTML source to integrate Node Monkey output with your app:

```html
<script type="text/javascript" src="http://0.0.0.0:50500/monkey.js"></script>
```

**NOTE**: You do NOT have to refresh the page when you restart your Node.js application to continue to receive output. Node Monkey will automatically reconnect.

---

### LICENSE: [MIT](https://raw.githubusercontent.com/jwarkentin/node-monkey/master/LICENSE.md)
