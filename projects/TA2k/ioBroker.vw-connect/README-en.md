![Logo](https://raw.githubusercontent.com/TA2k/ioBroker.vw-connect/master/admin/vw-connect.png)

# ioBroker.vw-connect

[![NPM version](http://img.shields.io/npm/v/iobroker.vw-connect.svg)](https://www.npmjs.com/package/iobroker.vw-connect)
[![Downloads](https://img.shields.io/npm/dm/iobroker.vw-connect.svg)](https://www.npmjs.com/package/iobroker.vw-connect)
[![Dependency Status](https://img.shields.io/david/ta2k/iobroker.vw-connect.svg)](https://david-dm.org/ta2k/iobroker.vw-connect)
[![Known Vulnerabilities](https://snyk.io/test/github/ta2k/ioBroker.vw-connect/badge.svg)](https://snyk.io/test/github/ta2k/ioBroker.vw-connect)

[![NPM](https://nodei.co/npm/iobroker.vw-connect.png?downloads=true)](https://nodei.co/npm/iobroker.vw-connect/)

**Tests:**: [![Travis-CI](http://img.shields.io/travis/ta2k/ioBroker.vw-connect/master.svg)](https://travis-ci.org/ta2k/ioBroker.vw-connect)

## vw-connect adapter for ioBroker

Adapter for VW We Connect, We Connect ID, We Charge, myAudi, Skoda Connect, Seat Connect and We Connect Go

Please update your system to Node 10.
<https://forum.iobroker.net/topic/22867/how-to-node-js-f%C3%BCr-iobroker-richtig-updaten>

## Usage

Use the state under remote control to control your car remotely.
Normal refresh is the polling interval to receive data from the VAG Cloud
Force refresh is for non E-Cars to enforce a refresh; this number is limited by VAG until the car is turned on again.
Trip data is only available for non E-Cars.

You can set climatization temperature in
.climater.settings.targetTemperature.content

## Discussion and Questions

<https://forum.iobroker.net/topic/26438/test-adapter-vw-connect-für-vw-id-audi-seat-skoda>

## Status fields Explanation

### List of entries

```

```
## Changelog

### 0.7.12 (2025-05-05)

- fix for skoda refresh token
- fix for ventilation activation
- add new not supported endpoints

### 0.7.9 (2025-03-20)

- fix for id wall charger

### 0.7.7 (2025-03-02)

- fix for skoda auxiliaryheating and duration
- fix for skoda lock/unlock

### 0.7.6 (2025-02-28)

- fix for charging status updates only at startup
- fix for skoda ismoving state

### 0.7.3 (2025-02-26)

- fix for set setTemperature
- fix for Skoda unlock lock

### 0.7.0 (2025-02-25)

- fix for skoda and seat
- State structure changed completly please delete old states under Objects

### 0.6.1 (2024-10-01)

- fix for skoda login

### 0.6.0 (2024-04-11)

- add additonal cupra states

### 0.5.4 (2024-03-17)

- fix door window states

### 0.4.1

- Fix VW Status Update

### 0.0.65

- Fix Cupra login

### 0.0.63

- Fix VW/Skoda etron login

### 0.0.62

- Fix Audi etron login

### 0.0.61

- Fix ID login

### 0.0.60

- Minor improvements. WeCharge Minimum interval is now 15 minutes

### 0.0.55

- fix id status update

### 0.0.51

- fix audi etron login

### 0.0.48

- fix login, fix audi update, add limit for wallbox

### 0.0.43

- increase refresh token timeouts

### 0.0.42

- fix skoda login

### 0.0.40

- add climate v3 for newer cars. Add Powerpass and Seat Elli

### 0.0.39

- fix id login

### 0.0.36

- add Skoda Enyaq support


### 0.0.35

- add nodeJS v10 compatibility

### 0.0.34

- add auto accept of new privacy consent

### 0.0.32

- correct selection of last recent trips

### 0.0.31

- enable multiple selection of trip types

### 0.0.30

- fix mutiple car problem, add VWv2 mode at the moment there is no different between VW and VWv2

### 0.0.29

- fix skoda refreshToken, smaller improvements

### 0.0.26

- bugfixes

### 0.0.25

- add we charge

### 0.0.24

- add remote state update

### 0.0.23

- add Seat and new climatisation v2

### 0.0.22

- calculate outside temperatur in °C also for Skoda and Audi

### 0.0.21

- add remotes for id

### 0.0.20

- fix audi login, add ID login

### 0.0.19

- save status objects in state by id instead of consecutive numbers

### 0.0.18

- fix battery status for 2020 models

### 0.0.17

- add support for 2020 models

### 0.0.16

- fix js.controller 3 problems

### 0.0.11

- fix audi bug with multiple vehicles
- hide status update error if feature is not available

## License

MIT License

Copyright (c) 2019-2030 ta2k <tombox2020@gmail.com>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-01

---