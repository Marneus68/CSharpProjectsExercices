%NURL(1) Nurl User Manual
%Duane Bekaert
%2014-05-29

# NAME

nurl - cli url tool

# SYNOPSIS

nurl [*mode*] [*options*]

# DESCRIPTION

nurl is a command line utility that allows the user to grab, download or 
display distant information from an URL. Nurl expects at least a *mode*. 
See **MODES** to see what every mode does. If nothing is provided,
nurl will display its version number and build information before exiting.
See **OPTIONS** to see what *options* are available for each *mode*.

# MODES

The mode can be:

`get`
:   This mode will grab the content from an url. 
    See **OPTIONS** to see the options that can be applied to this
    mode.

`test`
:   This mode will test the downloading times.
    See **OPTIONS** to see the options that can be applied to this
    mode.

# OPTIONS
-url *url*, \--url *url*
:   Available in *get* and *test* mode.
    This is used to specify the *url* that should be used.
    In *get* mode, the content located at the url will be printed on the
    standard output unless another option is present.

-save *output*, \--save *output*
:   Only available in *get* mode.
    This is used to specify the name of the file where the output should be
    saved.

-times *number*, \--times *number*
:   Only available in *test* mode.
    This is used to specify the *number* of times the download will be done and
    will display all the transfer times.

-avg, --average
:   Only available in *test* mode.
    This will display the average download time.

# EXAMPLES

    nurl get -url "http://abc"

    nurl get -url "http://abc" -save "./abc.json"

    nurl test -url "http://abc" -times 5

    nurl test -url "http://abc" -times 5 -avg

# SEE ALSO

`wget`(1), `curl`(1).

# BUGS
    
bunny, hopefully nothing more.
