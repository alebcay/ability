Ability
=======

Ability is a package manager for Microsoft Windows modeled after *nix's apt.

Planned features:
- install functions, e.g. "ability install", repo and package names are then prompted for
- uninstall functions
- "repo" style containers similar to Ubuntu PPAs?

How to use Ability?

End users:

1. When prompted, provide the address of the repository your package is in. Here, syntax is KEY:

Okay:
- http://example.com
- http://www.example.com
- example.com
- www.example.com
- example.com/repo1

NOT Okay:
- http://example.com/
- http://www.example.com/
- example.com/
- www.example.com/
- example.com/repo1/packagename.exe

2. Provide package name. Syntax here is not as stringent.

Distribution users:

1. Get a web server or web space on a server. Duh.
2. For your software, you'll need to make an installer EXE file. This file can be as simple as a CLI or can be walked-through (preferably silent though).
3. Upload this installer EXE to a desired folder on the web server. This folder will become the REPO.
4. Make sure the EXE has public read rights and chmod it accordingly.
5. Similarly, make an uninstaller EXE file.
6. Rename this uninstaller EXE file (for example "foo.exe") to an RMV file (for example, "foo.rmv"). This file extension will be changed back at execution time, but is stored in a different file format so as not to get deleted when a "clean cache" command is run.
7. Upload this RMV file to the SAME directory as the installer EXE on the webserver. Make sure that the uninstaller RMV file has the same filename (other than file extension) as the installer EXE file. For example, for a package named "foo", the installer will be called "foo.exe", and the uninstaller MUST match and shall be called "foo.rmv".
8. Chmod the RMV file accordingly.
9. Tell potential users about your product, and how to get it! And also give Ability a mention if you like it!
