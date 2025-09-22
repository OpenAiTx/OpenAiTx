# BookHaven

![BookHaven Home](https://raw.githubusercontent.com/HrBingR/BookHaven/master/./bookhaven_home.png)

## Table of Contents
1. [What the Application Does](#what-the-application-does)
2. [Features](#features)
3. [Deployment](#deployment)
   - [Docker](#docker)
   - [Development](#development)
4. [Building the Application](#building-the-application)
5. [Change log](#change-log)


## What the Application Does
BookHaven scans and manages your local library of EPUB ebooks, and allows you to read and download your ebooks on any of your devices, with a sleek, modern, and responsive interface.

## Features
- **Read eBooks in the Browser**
  Users can access and read their EPUB-formatted eBooks directly without any additional software.
- **Download eBooks**
  Easily download a copy of any eBook in the collection to your device.
- **Non-Destructive Metadata Editing**
  Changes to eBook metadata (e.g., title, author, series) are stored in the database, leaving the original EPUB files untouched.
- **Automatic or Manual Library Scanning**
  Once deployed the app will periodically, on a configurable interval, scan your library for any changes, while also allowing for manual library scans.
- **Home Page with Alphabetical Sorting**
  Books are sorted first alphabetically by their author and then by series, offering a clean and intuitive browsing experience.
- **Powerful Search**
  The search feature on the home page allows users to filter their library by author, book title, or series, helping locate specific content quickly.
- **Filters**
  Basic filters are made available to allow filtering for books marked as favorite, as finished, or books that haven't been marked as finished.
- **Author Page with Intuitive Navigation**
  A dedicated author page organizes authors into a clickable alphabetical grid. Users can click on a letter to expand its list of authors, navigate to an author's page, and view their books sorted alphabetically by series and standalone titles.
- **Supports CloudFlare Access**
  Has a flag to bypass the login screen when making use of CloudFlare Access. See `.env.example` for details.
- **OIDC Support**
  Allows for the configuration of OIDC for new user registration, and for existing users.
- **OPDS Support**
  Use your favorite OPDS-compatible e-reader or app to browse, download, and read books from your library.
- **Uploads**  
  Users can now upload ebooks directly via the user interface, with a post-upload form to fix the metadata.  
- **Basic RBAC Support**  
  Admins can now give users different roles with different levels of access.  
- **Book Requests**  
  Users can now request specific books they'd like to see on the site. Admins and editors can view and resolve these requests once uploaded/added.  

## Deployment  

### Requirements  

At a minimum to run the application you require:  

- A database (MySQL, SQLite, PostgreSQL)  
- A Redis instance  

For quick and easy deployment the .compose.yml.example defines both of these already.  

### Docker  
Follow these steps to deploy the application with Docker Compose:  
1. **Download Configuration Files**  
Download or clone the repository to get `compose.yml.example` and `.env.example`.  

2. **Rename the Example Files**
``` bash
   mv compose.yml.example compose.yml
   mv .env.example .env
```
3. **Customize the `.env` File**

Edit `.env` to configure essential settings.

4. **Start the Application**

Run the following command:
``` bash
   docker compose up -d
```
This starts the `BookHaven`, Redis, and MySQL containers.
5. **Access the Application**

Open your browser and navigate to the `BASE_URL`:`APP_PORT` you configured (default is `http://localhost:5000`).

6. **Stopping the Application**

``` bash
   docker compose down
```

### Development
Follow these steps to deploy for development:
1. **Clone the repository**:
``` bash
   git clone https://github.com/HrBingR/BookHaven.git
   cd BookHaven
```

2. **Rename the example files**:
```bash
   mv compose.exmaple.yml compose.yml
   mv .env.example .env
```

3. **Customize the `.env` file**:

Edit `.env` to configure essential settings.

4. **Modify the `compose.yml` file**:

Change:

```yaml
    epub-reader:
       image: hrbingr/bookhaven:latest
```

To:

```yaml
  epub-reader:
     build:
        context: .
        dockerfile: Dockerfile
```
5. **Build the container**:

```bash
   docker compose up --build -d
```

6. **Access the app**:

Access the app at the `BASE_URL` and `APP_PORT` specified in the `.env` file.

## Building the Application
To build the application for production:
1. **Build the Frontend**:
``` bash
   cd frontend
   npm run build:dev
```
2. **Build the Docker Image**:

In the root project directory (BookHaven), run:
``` bash
   docker build -t tag:version .
```
Replace `tag:version` with your preferred image name and version (e.g., `bookhaven:1.0.0`).

## Change log:

For detailed changelog see [CHANGELOG](https://raw.githubusercontent.com/HrBingR/BookHaven/master/CHANGELOG.md)

- v1.0.x
  - Initial Release
- v1.1.0 - v1.1.1
  - Added OIDC support
  - Fixed a bug where OIDC front-end components would still render with OIDC disabled.
- v1.2.0 - v1.2.2
  - Added support for optionally writing metadata to the ePub file, instead of just to the database.
  - Fixed issue where Celery would detect PERIODIC_SCAN_INTERVAL, if explicitly defined, as a string and throw an exception.
  - Fixed migration and DB model logic that would prevent Postgres users from successfully initializing the database.
- v1.3.0 - v1.3.5
  - Added rudimentary OPDS support.
  - Improved OPDS functionality.
  - Fixed UI issues on Authors page
  - Fixed some UX issues related to scrolling on Home page
  - Improved cover image loading on the front-end
  - Upped default API rate limit and made it customizable
  - Implemented locking for the scan process to ensure only one scan runs at a time
  - Improved DB component of the scan logic
  - Fixed rendering of expanded author lists on mobile on the "Authors" page
  - Updated scan logic - library will now be automatically scanned on start
- v1.4.0 - v1.4.1
  - Added Upload functionality - check .env.example on how to enable and use
  - Updated scanner fallback identifiers from relative paths to filenames
  - Created migration to update existing fallback identifiers
  - Swapped from gunicorn sync to gunicorn gthread for better upload performance
  - Fixed celery task imports for scheduled scans
  - Fixed hiding the upload button when uploads feature is disabled
- v1.5.0 - v1.5.2
  - Added role-based access (RBAC). Admins can now give users different roles as follows:
    - User: Access to all basic features except for uploads, editing metadata, and manging users.
    - Editor: Includes access to uploads and editing metadata.
    - Admin: Includes access to managing other users.
  - Improved logic when logging in via Cloudflare Access.
  - Fixed minor bug affecting legacy columns that were never removed.
  - Made migration script more resilient.
- v.1.6.0
  - Added requests feature for users to request for new books to be added to the site.

## TODO:

- Update tests with latest additions
- Explore support for other formats
- Explore adding more metadata fields for editing

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---