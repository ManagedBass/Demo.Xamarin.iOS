# ManagedBass

Simple audio player example using [ManagedBass](https://github.com/ManagedBass/ManagedBass) with Xamarin on iOS

Bass and its Add-Ons can be downloaded at http://un4seen.com/  
ManagedBass is targeted for **Any CPU**, but bass Libraries(dll/so/dylib) are separate for x86, x64, ARM, etc.  
Download the versions you need.

# How To Use

Download libbass.a from the [Un4seen forums](http://www.un4seen.com/forum/?topic=10910), and place it in this project folder directly next to the 'Xamarin.iOS.Player.sln' file.

Open Xamarin.iOS.Player.sln using Xamarin Studio.

Within Xamarin studio, add a Native Reference to the project, adding libbass.a

Compile and Run the application.

When the app opens, click Play.

While the audio is playing, click the Stop button when you wish to stop the audio.

If you encounter any exceptions, please be sure that libbass.a is properly added as a Native Reference.  Open the Options for the project, and under ‘iOS Build’, confirm the following settings:

Linker behavior : Link All
Additional mtouch arguments: -gcc_flags "-L${ProjectDir} -lbass -framework CFNetwork -framework AudioToolbox -framework SystemConfiguration -framework Accelerate -force_load ${ProjectDir}/libbass.a"




Bass and other Add-Ons are trademarks of their respective owners: **Un4Seen Bass - (c) Ian Luck**
