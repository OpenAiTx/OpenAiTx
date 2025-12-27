![preview](https://github.com/user-attachments/assets/e6762b5a-479a-4261-8e5c-e6b5d04344c5)
# Pantry
[![build](https://github.com/imRohan/Pantry/actions/workflows/continuous_integration.yml/badge.svg)](https://github.com/imRohan/Pantry/actions/workflows/continuous_integration.yml)
![Maintainability](https://api.codeclimate.com/v1/badges/8f1460270ced1f60744c/maintainability)
![Issues Open](https://img.shields.io/github/issues/imrohan/Pantry?&logo=github)
![Issues Closed](https://img.shields.io/github/issues-closed-raw/imrohan/pantry?color=green&logo=github)
[![Coverage Status](https://coveralls.io/repos/github/imRohan/Pantry/badge.svg?branch=master)](https://coveralls.io/github/imRohan/Pantry?branch=master)

[Pantry](https://getpantry.cloud/) is a free service that provides perishable data storage for small projects. Data is securely stored for as long as you and your users need it and is deleted after a period of inactivity. Simply use the restful API to post JSON objects and we'll take care of the rest.

It was built to provide a simple, re-usable storage solution for smaller sized projects. It was created by developers for developers, to be there when you need it and to help you rapidly prototype your next project.

## Development

#### Clone the repo
`git clone https://github.com/imRohan/Pantry.git && cd Pantry`

#### Install Dependencies
`yarn`

#### Install Redis
You will need to install Redis (v^6.2.0) on your machine and have server running
using it's default settings

#### Create & Edit a `.env` and `config.ts`
`cp env.sample .env`
`cp src/app/config.dev.ts src/app/config.ts`

#### Build frontend assets and run server (default port 3000)

`yarn run dev`

#### Open Example HTML page

Open `http://localhost:3000/` in the browser of your choice
