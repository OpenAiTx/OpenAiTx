# cmyflix
*A Netflix clone, now in C!*

cmyflix is also a complete rewrite of my original ![Myflix](https://github.com/farfalleflickan/Myflix/) using C, so it's about 30x **faster** than the original whilst keeping almost all functionality.

cmyflix tries to be a somewhat simple and lightweight "DIY Netflix", similar to Plex, streama or Emby, for your NAS, especially aimed at the Raspberry Pi/Odroid/etc ecosystem. It's not **meant** or **designed** to be fancy (if you have the hardware and want a ton of functionality, go for other solutions :) ), but the bare minimum to be somewhat pretty, fast and usable. The program create json databases that store the files location and metadata, these databases are then used to create static web pages that can be served from any web server!    

Big props to the following libraries: ![cwalk](https://github.com/likle/cwalk), ![cjson](https://github.com/DaveGamble/cJSON).   
If you want to password protect your cmyflix files, you might want to look at ![this](https://github.com/farfalleflickan/JSONlogin)!  

Do you like my work? Feel free to donate :)  
[<img src="https://raw.githubusercontent.com/andreostrovsky/donate-with-paypal/master/dark.svg" alt="donation" width="150"/>](https://www.paypal.com/donate?hosted_button_id=YEAQ4WGKJKYQQ)

# Sreenshots:  
TV shows page
![TV shows](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/ec53e53f252f908bc8bac7f8c4486790.jpg)   

TV show season/episode modal
![TV show episodes](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/fb31129a22d81b732ce88f02cae27fea.jpg)  


TV show episode player
![TV show episode player](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/102b3df4924efeae7476d6ceee79bec9.png)

Movies page
![Movies](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/d4271907a9af78d8dd84f3941ca1e56a.jpg)  

Movies player
![Movies player](https://github.com/farfalleflickan/Myflix/blob/master/screenshots/2eb41c935d1c11e19adb66466bcdf97e.png)

# How to compile:
Simply compile by running make, the required libraries are (in Ubuntu) `libbsd-dev libcjson-dev libcurl4-openssl-dev`.

# How to install:
Either install from source with make install OR use a pre-compiled package from the release tab.

Beware, the pre-compiled `deb` file is built using the default `libcurl4-openssl-dev` backend.

# Requirements to run:
cmyflix uses libcjson(>=1.7.15), libcurl(>=7.68), imagemagick, ffmpeg and a TMDB api key. Please do also note that cmyflix searches for `mp4`,`mkv`,`ogv` and `webm` files due to the usage of HTML5 and its supported formats.

# Configuration & usage:
For starters, cmyflix looks for `cmyflix.cfg` first in the same folder as the binary, then in `$HOME/.config/cmyflix/` and lastly in `/etc/cmyflix/`. Same thing applies for folder `html` and its contents.

For more options and information, look in the configuration file or see the help menu, which can be invoked by passing `--help`.

# Folder structure expectations
cmyflix is a bit picky in the sense that it expects everything to be in organized folders. 
For TV shows it expects every show to be in its own folder, with a sub-folder for every season (plus a "Season.Extras" for anything else). Example: `/path/to/files/Name.of.TV.show/Season.1/Name.Of.TV.show.S01E01.mp4`.
For movies, they should ideally be in a sub-folder for every movie, example: `/path/to/files/Name.of.Movie/Name.Of.Movie.mp4`. Note that multiple movies can technically be in the same sub-folder, as in `/path/to/files/Movies/Star.Wars/Revenge.of.The.Sith.mp4` and `/path/to/files/Movies/Star.Wars/Empire.Strikes.Back.mp4`.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-27

---