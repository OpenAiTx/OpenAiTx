## Anti-spam for Telegram

Originally developed to solve the problem with spammers in the Vastik.Club chats, but can also be used in chats of other forks, as well as in any large chats.

### How it works
- Club users with a linked bot are automatically added to trusted
- On the "user joined the chat" event, a simple captcha is issued
- If the user is already in trusted, all checks are skipped
- If the user is in known spammer lists - no way
- If there are too many emojis in the message - no way
- If the message contains words that look like Russian but have English letters inside - no way. This aspect is currently mainly tuned for Russian-speaking chats and may trigger on normal words from languages written in Cyrillic, but so far all known cases are added to tests.
- If the message contains stop words like "earning online" - no way
- Then the message is cleaned of emojis, punctuation, diacritics and fed to ML. If ML thinks it’s spam - no way.
- If the user wrote several normal messages, they are added to trusted - spammers rarely “gain trust” and usually reveal themselves in the first or second message
- The bot automatically only deletes messages; users are banned only manually from the admin panel to reduce damage from false positives
- - Except blacklist. Such users are banned immediately, but this can be disabled
- If someone in the chat is banned not by the bot, a notification arrives in the admin panel, possibly the bot missed spam and it should be added to the dataset

### Admin commands
All commands are called by replying to another message
- /spam - adds the message to the spam dataset
- /ham - adds the message to the non-spam dataset
- /check - runs the message through all checks

### Config
Create an admin chat, remember its ID.
Environment variables:
- DOORMAN_BOT_API: Telegram bot token. Required
- DOORMAN_ADMIN_CHAT: Admin chat ID. Required
- DOORMAN_CLUB_SERVICE_TOKEN: Service token for the Club, created here: https://vas3k.club/apps/. If the variable is not set, automatic approval of people from the Club is skipped.
- DOORMAN_CLUB_URL: Base URL for Club forks, for example https://rationalanswer.club/
- DOORMAN_BLACKLIST_AUTOBAN_DISABLE: Set to true or 1 to prevent the bot from banning people (not from the Club, not approved, from blacklist) immediately upon joining
- DOORMAN_LOW_CONFIDENCE_HAM_ENABLE: Set to true or 1 to send to admin panel non-spam messages with low confidence score, useful for chats where spammers constantly test ML robustness
- DOORMAN_CHANNELS_AUTOBAN_DISABLE: Set to true or 1 to prevent the bot from banning messages sent on behalf of channels (except those linked to the current group)
- DOORMAN_APPROVE_BUTTON: Set to true or 1 to add the option "this is a friend, acquaintance, regular" to each deleted message
- DOORMAN_LOOKALIKE_AUTOBAN_DISABLE: Set to true or 1 to prevent the bot from banning messages containing words that mimic Russian
- DOORMAN_BUTTON_AUTOBAN_DISABLE: Set to true or 1 to prevent the bot from banning messages containing buttons
- DOORMAN_HIGH_CONFIDENCE_AUTOBAN_DISABLE: Set to true or 1 to prevent the bot from banning messages where the ML classifier is quite confident it is spam
- DOORMAN_CHANNEL_AUTOBAN_EXCLUSION: Comma-separated groups where channels are not banned

#### Thank you
- https://lols.bot/ for fighting spammers and providing the API for ban lists
- https://github.com/umputun/tg-spam/ for some ideas and three quarters of the dataset

### Translation
If you're willing to do the heavy lifting of translating all the text of this bot to other languages, please let me know first before running headfirst and creating a PR.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-02

---