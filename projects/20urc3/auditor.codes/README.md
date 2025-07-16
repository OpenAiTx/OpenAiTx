# Code Auditor CTF
![image](https://github.com/user-attachments/assets/fdfbbffc-71f9-4463-856d-aca054399a0f)

A web-based Capture The Flag (CTF) platform offering unparalleled depth and breadth in source code auditing challenges. With the largest collection of real-world C/C++ vulnerability examples available anywhere, users analyze authentic code snippets, identify sophisticated security flaws, and master secure coding practices through hands-on experience.

Our comprehensive training environment features thousands of meticulously curated challenges spanning the entire vulnerability spectrum - from classic buffer overflows to the most obscure memory corruption bugs. No other platform provides this level of completeness in source code security education.

### This application is currently in ALPHA stage and was entirely "vibe coded" with the assistance of Large Language Models.

What does this mean? The development process prioritized creative flow and rapid iteration over traditional software engineering practices.
As an ALPHA release, users should consider themselves active testers of the platform. You will likely encounter bugs, unexpected behaviors, and incomplete features as you explore. These experiences are an integral part of our development process, not exceptions to it.
By using this platform, you're participating in its evolution and helping shape its future. We encourage you to report any issues, share your insights, and suggest improvements as we transform this LLM-assisted creation into a more stable and refined tool.

## Features ✨

* **Vulnerability Challenges:** Practice identifying various CWEs (Common Weakness Enumerations) in C/C++ code snippets.
* **Multiple Difficulty Levels:** Challenges categorized by difficulty (Easy, Medium, Hard, Insane - *Note: Current implementation might be simplified*).
* **Code Diff View:** Compare vulnerable code side-by-side with a fixed version.
* **User Authentication:** Secure user registration, login, and logout functionality using Flask-Login.
* **Persistent Progress:** User scores and completed challenges are tracked in a database.
* **User Profiles:** View individual scores and completion stats.
* **Leaderboard:** See how you rank against other auditors!
* **Educational Content:** Dedicated "Learn" section with comprehensive resources on vulnerability identification.
* **Modern UI:** Dark theme with Tailwind CSS for landing/auth pages and Prism.js for code highlighting.
* **Extensive Challenge Dataset:** Features over 7000+ challenges derived from real C/C++ code snippets. *(Based on the excellent [MegaVul dataset](https://github.com/Icyrockton/MegaVul) by Icyrockton)*.

## Tech Stack ️

* **Backend:**
    * Python 3
    * Flask (Web Framework)
    * Flask-Login (User Session Management)
    * Werkzeug (Password Hashing, WSGI utilities)
    * SQLite (Database)
    * Gunicorn (Production WSGI Server - Recommended)
* **Frontend:**
    * HTML5
    * CSS3 (including custom styles)
    * Tailwind CSS (for specific pages like landing/auth)
    * Vanilla JavaScript (DOM manipulation, API calls)
    * Prism.js (Syntax Highlighting)
 
*Deployment configuration information can be found in `conf/readme.md`*

## Database Schema

The application uses an SQLite database (`auditor_challenges.db`) with the following main tables:

* **`users`**: Stores user information.
    * `id` (INTEGER, PK, AI): Unique user ID.
    * `username` (TEXT, UNIQUE, NOT NULL): User's chosen name.
    * `password_hash` (TEXT, NOT NULL): Securely hashed password.
    * `created_at` (TIMESTAMP): When the user registered.
* **`user_progress`**: Tracks individual user progress.
    * `user_id` (INTEGER, PK, FK -> users.id): Links to the user.
    * `total_score` (INTEGER): User's current score.
    * `completed_count` (INTEGER): Number of challenges correctly solved.
    * `seen_challenges` (TEXT): JSON string list of challenge IDs the user has been assigned.
* **`challenges`**: Stores the CTF challenge data (derived from sources like MegaVul).
    * `id` (INTEGER, PK): Unique challenge ID.
    * `title` (TEXT): Title of the challenge.
    * `vulnerable_code` (TEXT): The code snippet with the vulnerability.
    * `fixed_code` (TEXT): The corrected version of the code (for diff view).
    * `difficulty` (TEXT): e.g., 'easy', 'medium', 'hard', 'insane'.
    * `cwe_id` (TEXT): The primary CWE associated with the vulnerability (e.g., 'CWE-120').
    * `cwe_name` (TEXT): A descriptive name for the CWE.
    * `cve_id` (TEXT, Optional): Associated CVE identifier, if applicable.
    * `solution` (TEXT): Explanation of the vulnerability and fix.

## Usage

1.  Navigate to the application URL.
2.  Register a new account or Log In via the "My Account" dropdown.
3.  Go to the "Challenges" page (`/ctf`).
4.  Select a difficulty level using the dropdown.
5.  A challenge will load. Analyze the source code.
6.  Optionally, use the "Show Diff View" button to compare with a fixed version (incurs a score penalty).
7.  Select the CWE you believe is present in the code from the radio buttons.
8.  Click "Submit Assessment".
9.  View the results, explanation, and your updated score.
10. Use the "Load Next Challenge" button (on the results page) or the "New Challenge" button (next to the difficulty dropdown) to get a new challenge.
11. Check your progress on the "Profile" page and see rankings on the "Scoreboard" (both accessible from the "My Account" dropdown).

## Acknowledgements

* The challenge dataset used in this project is based on the [MegaVul dataset](https://github.com/Icyrockton/MegaVul) created by Icyrockton.

## Contributing

Contributions are welcome! Please feel free to submit pull requests or open issues for bugs, feature requests, or improvements.

## License

This project is licensed under the MIT License - see the [LICENSE.md](https://raw.githubusercontent.com/20urc3/auditor.codes/main/LICENSE.md) file for details.
