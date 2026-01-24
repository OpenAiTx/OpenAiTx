# Drawing-with-Metapost

Toby Thurston -- 28 Jan 2025

This project provides a document that discusses how to draw technical diagrams
with John Hobby's Metapost language. It includes over 200 illustrations created
with Metapost, complete with source code as inspiration and examples.  The
intended level is for intermediate to advanced users rather than complete
beginners.  For introductions, tutorials, and other articles about Metapost, see
http://www.tug.org/metapost.html

Start with `Drawing-with-Metapost.pdf` in the top directory.

The `src` directory contains 
- the TeX source for the main document
- the style file used for marking up Metapost source code
- the Metapost source for each illustration used in the main document
- the corresponding PDF files created from each MP source file

The text includes a discussion of the techniques used for drawing the
illustrations, and includes complete or partial listings for most of them.
These listings are included directly from the source code used, so in all cases
the output should exactly match what you see on the page.

You might like to read the main document first, but you might also like to
browse through the PDFs in the `src` directory, and when you find one that is
interesting, have a look at the corresponding MP source file.  There is a
one-to-one match between the PDF names and the MP source names, so
`geometry-apollonius.pdf` is created from `geometry-apollonius.mp`.  The `src`
directory contains a few drawings that are not included in the main document.

If you find any errors, or have any suggestions for improvement, please raise an
issue or submit a pull request on Github.

Copyright (c) 2025 by Toby Thurston. This material may be distributed only
subject to the terms and conditions set forth in the Open Publication License,
v1.0 or later.  The latest version is presently available at
https://opencontent.org/openpub/

Distribution of substantively modified versions of this document is prohibited
without the explicit permission of the copyright holder.  Distribution of the
work or derivative of the work in any standard (paper) book form is prohibited
unless prior permission is obtained from the copyright holder.
