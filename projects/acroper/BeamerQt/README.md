# BeamerQt
BeamerQT is a user-friendly graphical interface designed to facilitate the creation of Beamer presentations without manually editing LaTeX code associated with the Slides. It provides a comprehensive set of features that allow users to define layouts, insert content (including text, blocks, and images), and configure some advance settings of the theme. BeamerQT provides both beginners and advanced LaTeX users the ability to create amazing presentations and focus in the contents rather than in the code.

### Library requirements:
* PyQt6

* PyMuPDF

<img src="https://github.com/user-attachments/assets/b123f050-dff5-4584-b40d-c2fd581c2f16" width="600">


# Features
BeamerQT features a graphical user interface that provides easy access to most desired Beamer/LaTeX features without adding LaTeX code. 

## Theme Editor (New Feature!)
Edit source code of templates. 

* Supports attaching included files.
* Extract attached files during LaTeX generation.
* Share the custom .xml file with ease.
* New features in the near future.

## Layout Selection
BeamerQT provides a range of predefined layout schemes inspired by common presentation tools such as PowerPoint or LibreOffice Impress. Instead of manually writing LaTeX code for columns and blocks, the user can simply select a layout and BeamerQT will automatically insert and manage the required Beamer columns and blocks.

Key capabilities include: 

* Automatic creation of columns and blocks based on the chosen layout. 
* A slider control to adjust column widths dynamically, without manual code edits. 
* Seamless reconfiguration of the slide layout with minimal user intervention.

<img src="https://github.com/user-attachments/assets/1c313ed2-337c-4925-aaef-b18aa718bd0e" width="600">

<img src="https://github.com/user-attachments/assets/305af2c5-7726-43bd-b457-fe68d8ff3fd9" width="600">


## Slides

Each slide can contain a title, a subtitle, and a set of blocks for content. Additionally, slides can be configured as either a new section or subsection, enabling automatic insertion of corresponding section or subsection titles into the presentation.

Key features: 

* Easy input of slide title and subtitle. 
* Marking a slide as a section or subsection to structure the presentation. 
* Automatic adjustment of slide-level formatting options.

## Slides List

The Slides List provides an overview of the entire presentation, showing each slide’s position, number, and title. Sections and subsections are clearly marked, assisting in navigation and organization. Users can reorder, duplicate, copy, or delete slides as needed, ensuring efficient slide management.

## Blocks

Blocks are fundamental units of content in BeamerQT. The tool supports various block types—such as Block, Alert, Example, or plain text blocks—through a simple radio-button interface. This approach eliminates the need to write LaTeX commands manually.

Core functionalities of blocks include: 

* Selection of block type (Block, Alert, Example, or plain text). 
* Position controls for rearranging blocks within the layout. 
* A dedicated button for removing the block from the slide. 
* A title field and text input area for each block, with multiline support. 
* Automatic line breaks or retention of manual line breaks depending on user input.
* Multiple sub-blocks
<img src="https://github.com/user-attachments/assets/5b914c96-e691-4fdf-af42-faba89b2c8f4" width="600">


## Sub-blocks

Sub-blocks allow for more granular content organization within a block. Each block contains at least one sub-block (generally text-based), and users can add multiple sub-blocks as needed.

Sub-block features include: 

* Arrangement in up to four columns, with horizontal navigation buttons to reorder sub-blocks. 
* A slider to adjust column widths, offering flexible layout customization. 
* Alignment controls for each sub-block (left, center, right, or default).

## Image sub-block

The image sub-block is a specialized sub-block type for inserting images. BeamerQT supports bitmap files (e.g., .jpg, .png), vector images (.svg), and .pdf files. For .svg images, BeamerQT utilizes Inkscape to convert them to .pdf format, ensuring seamless integration into the final presentation (tested Linux systems only).

Image sub-block features: 

* Adjustable image sizing as a percentage of the sub-block’s width. 
* Automatic adaptation to layout changes for consistently scaled visuals. 
* Compatibility with multiple image formats, ensuring flexibility in presentation design.

## Front-matter

The front-matter section allows for easy configuration of presentation-wide settings. Users can define the presentation title, author names, and customize the LaTeX preamble. Additionally, advanced features can be enabled to further refine the overall look and structure of the presentation, such as: 

* Changing the aspect ratio (4:3 to 16:9). 
* Creating title frames for each section. 
* Automatically generating an outline frame for each section.
<img src="https://github.com/user-attachments/assets/07629d96-ba38-4e5b-87ff-c1648598ad9f" width="600">


<img src="https://github.com/user-attachments/assets/bb47ffe5-7d92-408e-a42d-1cd734f53d51" width="600">

<img src="https://github.com/user-attachments/assets/9149eb46-020a-4f02-b3fe-9959fb231fd3" width="600">



## LaTeX generation

When the user is satisfied with the content and layout, clicking the **Generate LaTeX** button exports the presentation to LaTeX and runs pdflatex to compile a PDF. The resulting PDF is then displayed, enabling immediate review. 

The **LaTeX folder** button opens the output directory, allowing for further customization or integration with other tools. Note that each LaTeX generation overwrites files in the output folder.


## File format

BeamerQT uses a .bqt file format, which is essentially a zipped directory containing all necessary metadata, such as: 

* An XML file with presentation details. 
* Preview images of slides. 
* (Future feature) Embedded images and custom themes to ensure portability.

This approach ensures that .bqt files can be easily shared, backed up, and edited across different systems without losing essential data.


## Installation

* Windows

  Install MikTex:
  
  https://miktex.org/download

  Install BeamerQT:
  
  https://sourceforge.net/projects/beamerqt/

* Linux
  Install python3, TexLive and Inkscape, according to your distribution:
  

  Debian based:
  ```
  apt-get install python3 texlive-beamer inkscape 
  ```
  Install PyQt6 and PyMuPDF:
  ```
  pip install pyqt6 pymupdf
  ```
  

  Run BeamerQT:

  Download the source code of BeamerQT from this repository.
  
  Open a terminal in the directory that contains the file main.py
  ```
  python3 main.py
  ```


## Example video:

https://www.youtube.com/watch?v=XQKJbuT8q1g

## Screenshots:
### BeamerQT GUI
<img src="https://github.com/user-attachments/assets/cf332d4e-9962-4251-9619-67e146af9851" width="600">

### PDF Output
<img src="https://github.com/user-attachments/assets/be7b2e0c-20a4-41f0-b09d-93131973c4d4" width="600">


## Donate
Please donate to help me developing this software. Paypal donation link:

https://www.paypal.com/donate/?business=2PP5H8Z8L5E8E&no_recurring=0&item_name=Support+the+development+of+BeamerQT&currency_code=USD


## Science Fiction Book
If you enjoyed this, you might also like my science fiction book, Synapses: The Chaos of Order.

http://synapsesbook.wordpress.com/

Jorge Guerrero
