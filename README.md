Nurl
====

Building
--------

TODO

Specification
-------------

Building the documentation and specifications requires [pandoc](http://johnmacfarlane.net/pandoc/) and GNU make. If you don't want to install pandoc, you can still check out MANPAGE.md.

    make doc

will make a standard manpage that can be opened by running

    man ./NURLMAN

If you'd rather have an html documentation, easier to open on non-*nix systems, you can run  

    make webdoc

That will create an html file called `NURLMAN.html`.  

The original statement of requirements can be found [here](https://github.com/Marneus68/CSharpProjectsExercices/blob/master/Project-10-Nurl.md].
