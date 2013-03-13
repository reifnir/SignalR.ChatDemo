SignalR Simple Chat Demo
========================

Summary
-------

The purpose of this app is to show exactly how simple it is to begin to leverage SignalR in an ASP.NET app.

The intent is not to serve as an exhibition of all of SignalR's functionality. Once you start fiddling with SignalR, you can dig into that more yourself. Just know that it's pretty darn easy to have the server notify clients selectively such as a current caller, everyone but the current caller, subscribed groups, other individual callers, etc.

Have fun and dig in!

How To Use It
-------------

1.  Pull down the repo
2.  Open the solution
3.  Start debugging
4.  Open a couple of browser windows to the root of the application. Ex: http://localhost:11637/
5.  Chat amongst the various browser windows :)


![Chrome](/Images/Chrome.png)

Firefox
![Firefox](/Images/Firefox.png)

IE
![IE](/Images/IE.png)



All The Code That's Fit To Print
--------------------------------

The sum of the code in this project, such as it is, consists of the following deviations from a standard new project.

/Global.asax.cs
There's just one line of code to initialize the hubs.

/SimpleChat.cs
The hub is essentially a one line method and a DTO.

/Index.html
Just a little JavaScript to...
*    Make create the simpleChat hub proxy
*    Wire up the button to call the server
*    Wire up the listener to the server's spamEveryone method
*    Start the hub

That was easy :)

Thanks
------

Huge thanks to the people behind [SignalR](https://github.com/SignalR/SignalR) for making such a powerful, easy to use tool!