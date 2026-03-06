# Letterboxd-to-IMDb

[![GitHub stars](https://img.shields.io/github/stars/TobiasPankner/Letterboxd-to-IMDb.svg?style=social&label=Star)](https://GitHub.com/TobiasPankner/Letterboxd-to-IMDb/stargazers/)
[![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=3TU2XDBK2JFU4&source=url)

- [Prerequisites](#prerequisites)
- [Run the script](#run-the-script)
- [Getting the IMDb cookie](#getting-the-imdb-cookie)
- [Common use cases](#common-use-cases)
- [Command line options](#command-line-options)

Python script to import your Letterboxd movies into IMDb.  

How it works:  
The script first "visits" all the Letterboxd links in your zip file and gets the corresponding IMDb page. This way, it can be ensured the correct movie is rated.  
After that, your cookie is used to authenticate a request to the internal IMDb GraphQL rating API.  

**Video tutorial** on how to use this: <https://www.youtube.com/watch?v=KF7cfdUTEgw>

## Run this script online (Python not required)

[![Run Script](https://simple-script.com/api/badge/letterboxd-to-imdb)](https://simple-script.com/app/letterboxd-to-imdb)

## Prerequisites  
  
- Python 3 ([Download](https://www.python.org/downloads/))
- [Letterboxd](https://letterboxd.com/) Account
- [IMDb](https://www.imdb.com/) Account

## Run the script

 1. Export your Letterboxd ratings and watchlist ([How to](https://listy.is/help/how-to-export-letterboxd-watchlists-reviews/))
 2. [Get the IMDb cookie](#getting-the-imdb-cookie) and save it as "cookie.txt" in the script folder
 3. Install dependencies: `pip install -r requirements.txt`
 4. Run letterboxd2imdb.py: `python letterboxd2imdb.py -f <YOUR ZIP FILE>.zip`

[Common use cases](#common-use-cases)

## Getting the IMDb cookie

**Treat this cookie like your password!**

  1. Log into your IMDb account
  2. Open Chrome dev tools -> Network
  3. Filter by Fetch/XHR
  4. Refresh the page
  5. Copy the cookie of one of the requests (Right click -> Copy Value)
  
  ![Example](https://imgur.com/chRo9wj.jpg)  

## Common use cases

**Transfer your ratings and watchlist:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -w`

**Transfer your watched movies with a rating of 5/10:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -r 5`

**Create an IMDb list for unrated watched movies:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -l`

**Create a custom-named IMDb list for unrated watched movies:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -l --list-name "My Letterboxd Movies"`

## Command line options

```
usage: letterboxd2imdb.py [-h] -f ZIPFILE [-p PARALLEL] [-c] [-r RATING] [-w] [-l] [--list-name LIST_NAME]

Imports your Letterboxd ratings and watchlist into IMDb. Can also create custom lists for unrated movies.

required arguments:
  -f ZIPFILE            The exported zip file from letterboxd

options:
  -h, --help            show this help message and exit
  -p PARALLEL           Urls to be processed in parallel (valid: 1 to 20)
  -c                    Add this flag to disable the history
  -r RATING             The rating to give watched but unrated movies. By default they are ignored (valid: 1 to 10)
  -w                    Add this flag to also transfer your watchlist
  -l                    Create an IMDb list for watched but unrated movies instead of rating them
  --list-name LIST_NAME Name for the IMDb list to create for unrated movies (default: 'Watched on Letterboxd - Unrated')
```
`-p`: Can be used if you want to speed up the process, if you set it too high you might get rate limited. Default: 5  
`-c`: If the history is causing problems, you can add this flag to disable it.  
`-r`: Can be used to rate watched but unrated movies. Because IMDb doesn't have an option to "just watch", a default rating has to be specified  
`-w`: Used to also transfer your watchlist  
`-l`: Creates an IMDb list for watched but unrated movies instead of assigning them arbitrary ratings. This preserves clean rating data while still tracking watched movies.  
`--list-name`: Specifies a custom name for the IMDb list created with the `-l` option. Default: "Watched on Letterboxd - Unrated"

**Note:** The `-r` and `-l` options are mutually exclusive. You can either assign default ratings to unrated movies (`-r`) or create a list for them (`-l`), but not both.
  
## Usage Examples  
  
**Basic import (ratings only):**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip`  
*Imports only your rated movies from Letterboxd to IMDb. Unrated movies are ignored.*  
  
**Import ratings and watchlist:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -w`  
*Transfers both your movie ratings and watchlist from Letterboxd to IMDb.*  
  
**Give default rating to unrated movies:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -r 7`  
*Imports your ratings and gives a default rating of 7/10 to all watched but unrated movies.*  
  
**Create a list for unrated movies:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -l`  
*Creates an IMDb list called "Watched on Letterboxd - Unrated" for movies you've watched but haven't rated.*  
  
**Create a custom-named list for unrated movies:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -l --list-name "My Letterboxd Backlog"`  
*Creates an IMDb list with a custom name for your unrated watched movies.*  
  
**Fast processing with higher parallelization:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -p 15`  
*Processes 15 movies in parallel for faster execution (be careful with rate limiting).*  
  
**Complete transfer with custom settings:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -p 10 -r 5 -w`  
*Fast processing (10 parallel), imports ratings and watchlist, gives 5/10 rating to unrated movies.*  
  

**Create a custom list with watchlist and fast processing:**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -p 10 -l --list-name "My Letterboxd Movies" -w`  
*Processes quickly, imports watchlist, and creates a custom-named list for unrated movies.*  
  
**Disable history (troubleshooting):**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -c`  
*Runs without using the history feature, useful if you're experiencing issues with the history file.*  
  
**Conservative approach (slow but safe):**  
`py letterboxd2imdb.py -f .\letterboxd-user-2022-02-20-16-16-utc.zip -p 1 -w`  
*Processes one movie at a time to avoid any rate limiting issues while importing both ratings and watchlist.*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-06

---